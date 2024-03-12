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

namespace Ergasia3.Source.Frontend.CinemaHall
{
	public partial class CinemaHall : BaseForm
	{

		#region Constructor definition
		public CinemaHall()
		{
			InitializeComponent();
			mediaPlayer.uiMode = "none";
			mediaPlayer.settings.volume = Globals.Volume;
		}
		#endregion

		#region Function definition
		private void ProjectionHall_FormClosed( object sender, FormClosedEventArgs e )
		{
			Application.OpenForms[ 1 ]?.Show();
		}

		private void leftArrow_Click( object sender, EventArgs e )
		{

		}

		private void rightArrow_Click( object sender, EventArgs e )
		{

		}

		private void helpLbl_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
		{
			HelpFile.Show( HelpFile.ProjectionHall );
		}
		#endregion

	}
}
