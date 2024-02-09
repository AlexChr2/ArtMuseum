using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ergasia3.src.Frontend.CinemaHall
{
	public partial class Cafeteria : Form
	{

		#region Constructor definition
		public Cafeteria()
		{
			InitializeComponent();
		}
		#endregion

		#region Function definition
		private void Cafeteria_FormClosed( object sender, FormClosedEventArgs e )
		{
			Application.OpenForms[ 0 ].Show();
		}
		#endregion
	}
}
