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
		public Account()
		{
			InitializeComponent();
		}

		private void Account_FormClosed( object sender, FormClosedEventArgs e )
		{
			var openformslist = Application.OpenForms;
			var openformsexist = (openformslist.Count > 0);
			if( openformsexist )
				Application.OpenForms[ 0 ].Show();
		}
	}
}
