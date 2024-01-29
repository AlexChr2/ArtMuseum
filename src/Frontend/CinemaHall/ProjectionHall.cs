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
	public partial class ProjectionHall : Form
	{
		public ProjectionHall()
		{
			InitializeComponent();
		}

		private void ProjectionHall_FormClosed( object sender, FormClosedEventArgs e )
		{
			var openformslist = Application.OpenForms;
			var openformsexist = (openformslist.Count > 0);
			if( openformsexist )
				Application.OpenForms[ 0 ].Show();
		}
	}
}
