using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ergasia3.src.Frontend.CinemaHall;
using Ergasia3.src.Frontend.ConcertHall;
using Ergasia3.src.Frontend.DJHall;
using Ergasia3.src.Frontend.ExhibitionHall;
using Ergasia3.src.Backend;

namespace Ergasia3.src.Frontend
{
	public partial class MainHall : Form
	{

		#region Constructor definition
		public MainHall()
		{
			InitializeComponent();
		}
		#endregion

		#region Function definition
		private void NavigateBtn_Click( object sender, EventArgs e )
		{
			if (DeviceHallRbtn.Checked)
			{
				new DeviceHall().Show();
				this.Hide();
				return;
			}
			
			if (ExhibitionHallRbtn.Checked)
			{
				new HallSelection().Show();
				this.Hide();
				return;
			}

			if (DJHallRbtn.Checked)
			{
				new DigitalDJ().Show();
				this.Hide();
				return;
			}

			if (ConcertHallRbtn.Checked)
			{
				new SignIn().Show();
				this.Hide();
				return;
			}
			
			if (CinemaHallRbtn.Checked)
			{
				new Cafeteria().Show();
				this.Hide();
				return;
			}

			var message = "Please select a hall to navigate through!";
			var boxIcon = MessageBoxIcon.Exclamation;
			AppMessage.showMessageBox( message, boxIcon );
		}
		#endregion
	}
}