using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ergasia3.src.ExhibitionHall
{
	public enum SelectionCategory
	{
		Art = 0,
		Music,
		Movies
	}

	public partial class HallSelection : Form
	{
		public HallSelection()
		{
			InitializeComponent();
		}

		private void artButton_Click(object sender, EventArgs e)
		{
			new MatterHall(SelectionCategory.Art).Show();
		}

		private void musicButton_Click(object sender, EventArgs e)
		{
			new MatterHall(SelectionCategory.Music).Show();
		}

		private void moviesButton_Click(object sender, EventArgs e)
		{
			new MatterHall(SelectionCategory.Movies).Show();
		}
	}
}
