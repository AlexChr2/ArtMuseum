using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ergasia3.Source.Backend;
using Ergasia3.Source.Frontend.CinemaHall;
using Ergasia3.Source.Frontend.ConcertHall;
using Ergasia3.Source.Frontend.DJockeyHall;

namespace Ergasia3.Source.Frontend.ExhibitionHall
{

	public partial class SelectionHall : BaseForm
	{

		#region Constructor definition
		public SelectionHall()
		{
			InitializeComponent();
		}
		#endregion

		#region Function definition
		private void HallSelection_FormClosed( object sender, FormClosedEventArgs e )
		{
			Application.OpenForms[ 1 ]?.Show();
		}

		private void PreviewBtn_Click( object sender, EventArgs e )
		{
			if( this.isHallSelected( this.ArtRbtn, HallCategory.Art ) ) return;
			if( this.isHallSelected( this.MusicRbtn, HallCategory.Music ) ) return;
			if( this.isHallSelected( this.MoviesRbtn, HallCategory.Movies ) ) return;

			var message = "Please select a hall to preview!";
			var boxIcon = MessageBoxIcon.Exclamation;
			AppMessage.showMessageBox( message, boxIcon );
		}

		private bool isHallSelected( RadioButton radioButton, HallCategory hallCategory )
		{
			if( radioButton.Checked )
			{
				new MatterHall( hallCategory ).Show();
				this.Hide();
				return true;
			}

			return false;
		}

		private void helpLbl_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
		{
			HelpFile.Show( HelpFile.ExhibitionHall );
		}
		#endregion

	}

	public enum HallCategory
	{
		Art,
		Music,
		Movies
	}
}