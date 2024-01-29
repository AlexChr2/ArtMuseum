using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ergasia3.src.Frontend.CinemaHall;
using Ergasia3.src.Frontend.ConcertHall;
using Ergasia3.src.Frontend.DJHall;

namespace Ergasia3.src.Frontend.ExhibitionHall
{

	public partial class HallSelection : Form
	{
		#region Constructor definition
		public HallSelection()
		{
			InitializeComponent();
		}
		#endregion

		#region Function definition
		private void HallSelection_FormClosed( object sender, FormClosedEventArgs e )
		{
			Application.OpenForms[ 0 ].Show();
		}

		private void PreviewBtn_Click( object sender, EventArgs e )
		{
			if( ArtRbtn.Checked )
			{
				new MatterHall( SelectionCategory.Art ).Show();
				this.Hide();
				return;
			}

			if( MusicRbtn.Checked )
			{
				new MatterHall( SelectionCategory.Music ).Show();
				this.Hide();
				return;
			}

			if( MoviesRbtn.Checked )
			{
				new MatterHall( SelectionCategory.Movies ).Show();
				this.Hide();
				return;
			}

			var promptMessage = "Please select a hall to preview!";
			var caption = "Warning";
			var buttons = MessageBoxButtons.OK;
			var boxIcon = MessageBoxIcon.Exclamation;
			MessageBox.Show( promptMessage, caption, buttons, boxIcon );
		}
		#endregion
	}

	public enum SelectionCategory
	{
		Art,
		Music,
		Movies
	}
}