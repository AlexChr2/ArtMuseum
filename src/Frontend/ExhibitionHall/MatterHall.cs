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
		private readonly List<InformationNode> informationList = [];
		private readonly HallCategory hallCategory;
		private int currentNode = 0;

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

		private void NextBtn_Click( object sender, EventArgs e )
		{
			int direction = 1;
			this.updateContent( direction );
		}

		private void PreviousBtn_Click( object sender, EventArgs e )
		{
			var direction = -1;
			this.updateContent( direction );
		}

		private void updateContent( int direction )
		{
			if( this.informationList.Count <= 0 )
				return;

			this.currentNode += direction + this.informationList.Count;
			this.currentNode %= this.informationList.Count;

			this.refreshHallContent();
		}

		private void randomizeNode()
		{
			var randomSeed = new Random().NextDouble();
			var randomNode = ( int )(randomSeed * this.informationList.Count);
			this.currentNode = randomNode;
		}

		private void refreshHallContent()
		{
			var url = this.informationList[ currentNode ].ImagePath;

			try
			{
				this.ImagePbx.Load( url );
			}
			catch( Exception )
			{
				var message = $"Image {url} not found!";
				this.showExceptionMessage( message );
			}

			this.InformationTxtbx.Text = this.informationList[ this.currentNode ].Information;
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
					)
						continue;
					else
					{
						var imagePath = imageNode.Attributes[ "path" ].Value;
						var information = informationNode.InnerText.Replace( Environment.NewLine, " " );
						information = information.Replace( "\t", "" );

						this.informationList.Add( new InformationNode( imagePath, information ) );
					}
				}
			}
			catch( FileNotFoundException f )
			{
				this.showExceptionMessage( f.Message );
			}
			catch( Exception e )
			{
				this.showExceptionMessage( $"Invalid XML: {e.Message}" );
			}
		}

		private void showExceptionMessage( string message )
		{
			var promptMessage = $"{message}";
			var caption = "Warning";
			var buttons = MessageBoxButtons.OK;
			var boxIcon = MessageBoxIcon.Exclamation;
			MessageBox.Show( promptMessage, caption, buttons, boxIcon );
		}

		private void MatterHall_FormClosed( object sender, FormClosedEventArgs e )
		{
			new HallSelection().Show();
		}

		// TODO: Giving the user the ability to
		// navigate, using only the arrows of
		// the keyboard.
		#endregion

		private readonly struct InformationNode( string imagePath, string information )
		{
			public readonly string ImagePath { get; } = imagePath;
			public readonly string Information { get; } = information;
		}
	}
}