using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Ergasia3.src.Frontend.ExhibitionHall
{
	public partial class MatterHall : Form
	{

		private const string XmlPath = "Data/Gallery.xml";
		private readonly List<InformationNode> informationTree = [];
		private readonly HallCategory hallCategory;
		private int currentNode = 0;
		private int direction = 1;

		#region Constructor definition
		public MatterHall( HallCategory hallCategory )
		{
			InitializeComponent();
			this.hallCategory = hallCategory;
		}
		#endregion

		#region Function definition
		private void MatterHall_Shown( object sender, EventArgs e )
		{
			this.readGalleryFile();
			this.randomizeNode();
			this.refreshHallContent();
		}

		private void nextButton_Click( object sender, EventArgs e )
		{
			this.direction = 1;
			this.updateContent();
		}

		private void PreviousBtn_Click( object sender, EventArgs e )
		{
			this.direction = -1;
			this.updateContent();
		}

		private void updateContent()
		{
			if( this.informationTree.Count <= 0 ) return;

			this.currentNode += (this.direction + this.informationTree.Count);
			this.currentNode %= this.informationTree.Count;

			this.refreshHallContent();
		}

		private void randomizeNode()
		{
			var randomSeed = new Random().NextDouble();
			var randomNode = ( int )(randomSeed * this.informationTree.Count);
			this.currentNode = randomNode;
		}

		private void refreshHallContent()
		{
			var url = this.informationTree[ currentNode ].ImagePath;

			try
			{
				this.ImagePbx.Load( url );
			}
			catch( Exception )
			{
				var message = $"Image {url} not found!";
				this.showExceptionMessage( message );
			}

			this.InformationTxtbx.Text = this.informationTree[ this.currentNode ].Information;
		}

		private void readGalleryFile()
		{
			XmlDocument document = new();

			try
			{
				document.Load( XmlPath );

				XmlNode? rootNode = document.SelectSingleNode( "gallery" );
				if( rootNode == null )
				{
					var message = $"Couldn't find root node!";
					throw new Exception( message );
				}

				var categoryNode = "";
				switch( this.hallCategory )
				{
					case HallCategory.Art:
						categoryNode = "painting";
						break;
					case HallCategory.Music:
						categoryNode = "music";
						break;
					case HallCategory.Movies:
						categoryNode = "movies";
						break;
				}

				XmlNode? infoTreeContent = rootNode.SelectSingleNode( categoryNode );
				if( infoTreeContent == null )
				{
					var message = $"Couldn't find selection choice {categoryNode}";
					throw new Exception( message );
				}

				foreach( XmlNode node in infoTreeContent.ChildNodes )
				{
					XmlNode? imageNode = node.SelectSingleNode( "image" );
					XmlNode? informationNode = node.SelectSingleNode( "info" );

					if( imageNode == null || informationNode == null ||
						imageNode.Attributes[ "path" ] == null
					) continue;
					else
					{
						var imagePath = imageNode.Attributes[ "path" ].Value;
						var information = informationNode.InnerText.Replace( Environment.NewLine, " " );
						information = information.Replace( "\t", "" );

						this.informationTree.Add( new InformationNode( imagePath, information ) );
					}
				}
			}
			catch( FileNotFoundException f )
			{
				this.showExceptionMessage( f.Message );
			}
			catch( Exception e )
			{
				this.showExceptionMessage( e.Message );
			}
		}

		private void showExceptionMessage( string message )
		{
			var promptMessage = $"Invalid XML:\n{message}";
			var caption = "Warning";
			var buttons = MessageBoxButtons.OK;
			var boxIcon = MessageBoxIcon.Exclamation;
			MessageBox.Show( promptMessage, caption, buttons, boxIcon );
		}

		private void MatterHall_FormClosed( object sender, FormClosedEventArgs e )
		{
			new HallSelection().Show();
		}
		#endregion

		private readonly struct InformationNode( string imagePath, string information )
		{
			public readonly string ImagePath { get; } = imagePath;
			public readonly string Information { get; } = information;
		}
	}
}