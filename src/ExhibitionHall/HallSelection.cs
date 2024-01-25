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
	}
}
