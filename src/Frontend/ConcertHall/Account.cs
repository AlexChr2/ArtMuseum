using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ergasia3.src.Frontend.ConcertHall
{
	public partial class Account : Form
	{

		#region Constructor definition
		public Account()
		{
			InitializeComponent();
		}
		#endregion

		#region Function definition
		private void Account_FormClosed( object sender, FormClosedEventArgs e )
		{
			new SignIn().Show();
		}
		#endregion

		private void label8_Click( object sender, EventArgs e )
		{

		}
	}
}
