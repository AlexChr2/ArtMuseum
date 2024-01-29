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
		private const string XMLPath = "Data/gallery.xml";
		private readonly List<PresentationContents> presentations = [];
		private int selectedMenuIndex = 0;
		private readonly SelectionCategory selectionCategory;

		#region Constructor definition
		private struct PresentationContents
		{
			public string ImagePath { get; }
			public string Info { get; }

			public PresentationContents( string imagepath, string info )
			{
				ImagePath = imagepath;
				Info = info;
			}
		}
		#endregion

		#region Function definition
		public MatterHall( SelectionCategory selectionCategory )
		{
			InitializeComponent();
			this.selectionCategory = selectionCategory;
		}

		private void MatterHall_Shown( object sender, EventArgs e )
		{
			readGalleryFile( selectionCategory );
			selectedMenuIndex = ( int )(new Random().NextDouble() * presentations.Count);
			refreshHallContent();
		}

		private void nextButton_Click( object sender, EventArgs e )
		{
			if( presentations.Count > 0 )
			{
				selectedMenuIndex += 1;
				selectedMenuIndex %= presentations.Count;
				refreshHallContent();
			}
		}

		private void refreshHallContent()
		{
			try
			{
				pictureBox1.Load( presentations[ selectedMenuIndex ].ImagePath );
			}
			catch( Exception ) { }
			infoTextBox.Text = presentations[ selectedMenuIndex ].Info;
		}

		private void readGalleryFile( SelectionCategory category )
		{
			XmlDocument doc = new();
			try
			{
				doc.Load( XMLPath );
				XmlNode? rootNode = doc.SelectSingleNode( "gallery" );
				if( rootNode == null )
					throw new Exception();

				string nodeSelection = "";
				switch( category )
				{
					case SelectionCategory.Art:
						nodeSelection = "painting";
						break;
					case SelectionCategory.Music:
						nodeSelection = "music";
						break;
					case SelectionCategory.Movies:
						nodeSelection = "movies";
						break;
				}

				XmlNode? presContents = rootNode.SelectSingleNode( nodeSelection );
				if( presContents == null )
					throw new Exception();

				foreach( XmlNode node in presContents.ChildNodes )
				{
					XmlNode? imagePath = node.SelectSingleNode( "image" );
					XmlNode? info = node.SelectSingleNode( "info" );

					if( imagePath == null ||
						info == null ||
						imagePath.Attributes[ "path" ] == null
					)
						continue;
					else
					{
						// replace endlines with a space and remove \t
						string infoText = info.InnerText.Replace(
							Environment.NewLine, " " );
						infoText = infoText.Replace( "\t", "" );
						presentations.Add( new PresentationContents(
							imagePath.Attributes[ "path" ].Value,
							infoText
						) );
					}
				}
			}
			catch( Exception )
			{
				// TODO: what to show on-screen in this case?
				return;
			}

		}

		private void MatterHall_FormClosed( object sender, FormClosedEventArgs e )
		{
			new HallSelection().Show();
		}
		#endregion
	}
}
