using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ergasia3.Source.Frontend
{
	public partial class MainHall : BaseForm
	{

		#region Constructor definition
		public MainHall()
		{
			InitializeComponent();
		}
		#endregion

		#region Function definition
		private void LetGoBtn_Click( object sender, EventArgs e )
		{
			new MenuTable().Show();
			this.Hide();
		}
		#endregion

	}
}
