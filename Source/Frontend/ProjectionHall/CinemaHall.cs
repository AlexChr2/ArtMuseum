using Ergasia3.Source.Backend;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ergasia3.Source.Frontend.CinemaHall
{
	public partial class CinemaHall : BaseForm
	{
		public CinemaHall()
		{
			InitializeComponent();
		}

		private void ProjectionHall_FormClosed( object sender, FormClosedEventArgs e )
		{
			Application.OpenForms[ 0 ]?.Show();
		}
	}
}
