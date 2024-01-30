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
				new LogIn().Show();
				this.Hide();
				return;
			}
			
			if (CinemaHallRbtn.Checked)
			{
				new Cafeteria().Show();
				this.Hide();
				return;
			}

			var promptMessage = "Please select a hall to navigate through!";
			var caption = "Warning";
			var buttons = MessageBoxButtons.OK;
			var boxIcon = MessageBoxIcon.Exclamation;
			MessageBox.Show(promptMessage, caption, buttons, boxIcon);
		}
		#endregion
	}
}