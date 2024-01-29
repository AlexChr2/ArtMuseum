using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ergasia3.src.Frontend.ExhibitionHall
{

	public partial class HallSelection : Form
	{
		public HallSelection()
		{
			InitializeComponent();
		}

		private void artButton_Click( object sender, EventArgs e )
		{
			new MatterHall( SelectionCategory.Art ).Show();
		}

		private void musicButton_Click( object sender, EventArgs e )
		{
			new MatterHall( SelectionCategory.Music ).Show();
		}

		private void moviesButton_Click( object sender, EventArgs e )
		{
			new MatterHall( SelectionCategory.Movies ).Show();
		}

		private void HallSelection_FormClosed( object sender, FormClosedEventArgs e )
		{
			var openformslist = Application.OpenForms;
			var openformsexist = (openformslist.Count > 0);
			if( openformsexist )
				Application.OpenForms[ 0 ].Show();
		}
	}

	public enum SelectionCategory
	{
		Art,
		Music,
		Movies
	}
}