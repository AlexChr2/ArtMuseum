using Ergasia3.Source.Backend;
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

namespace Ergasia3.Source.Frontend.CinemaHall
{
	public partial class CinemaHall : BaseForm
	{
		private readonly List<string> movieFiles;
		private int selectedIndex = 0;

		#region Constructor definition
		public CinemaHall()
		{
			InitializeComponent();
			readXML();
			mediaPlayer.uiMode = "none";
			mediaPlayer.settings.volume = Globals.Volume;
			updateVideo();
		}
		#endregion

		#region Function definition
		private void readXML()
		{
			XmlDocument doc = new();
			doc.Load( "Data/Movies.xml" );

			XmlNode rootNode = doc.SelectSingleNode( "videos" );
			if( rootNode == null )
				throw new XmlException( "root node != videos" );

			foreach(XmlNode node in rootNode.ChildNodes)
			{
				if( node.Attributes == null ||
					node.Attributes.Count != 1 ||
					node.Attributes[ "movie" ] == null )
					throw new XmlException( "invalid node structure" );

				movieFiles.Add( node.Attributes[ "movie" ].Value );
			}
		}

		private void ProjectionHall_FormClosed( object sender, FormClosedEventArgs e )
		{
			Application.OpenForms[ 1 ]?.Show();
		}

		private void leftArrow_Click( object sender, EventArgs e )
		{
			++selectedIndex;
			selectedIndex %= movieFiles.Count;
		}

		private void rightArrow_Click( object sender, EventArgs e )
		{
			--selectedIndex;
			selectedIndex %= movieFiles.Count;
		}

		private void updateVideo()
		{
			mediaPlayer.URL = movieFiles[ selectedIndex ];
			mediaPlayer.Ctlcontrols.play();
		}

		private void helpLbl_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
		{
			HelpFile.Show( HelpFile.ProjectionHall );
		}
		#endregion

	}
}
