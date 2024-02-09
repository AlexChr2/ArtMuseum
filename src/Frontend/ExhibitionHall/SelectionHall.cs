using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ergasia3.src.Backend;
using Ergasia3.src.Frontend.CinemaHall;
using Ergasia3.src.Frontend.ConcertHall;
using Ergasia3.src.Frontend.DJHall;

namespace Ergasia3.src.Frontend.ExhibitionHall
{

	public partial class SelectionHall : Form
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
			Application.OpenForms[ 0 ]?.Show();
		}

		private void PreviewBtn_Click( object sender, EventArgs e )
		{
			if( ArtRbtn.Checked )
			{
				new MatterHall( HallCategory.Art ).Show();
				this.Hide();
				return;
			}

			if( MusicRbtn.Checked )
			{
				new MatterHall( HallCategory.Music ).Show();
				this.Hide();
				return;
			}

			if( MoviesRbtn.Checked )
			{
				new MatterHall( HallCategory.Movies ).Show();
				this.Hide();
				return;
			}

			var message = "Please select a hall to preview!";
			var boxIcon = MessageBoxIcon.Exclamation;
			AppMessage.showMessageBox( message, boxIcon );
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