using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ergasia3.Source.Frontend.CinemaHall;
using Ergasia3.Source.Frontend.ConcertHall;
using Ergasia3.Source.Frontend.DJockeyHall;
using Ergasia3.Source.Frontend.ExhibitionHall;
using Ergasia3.Source.Backend;
	
namespace Ergasia3.Source.Frontend
{
	public partial class MenuTable : BaseForm
	{

		#region Constructor definition
		public MenuTable()
		{
			InitializeComponent();
		}
		#endregion

		#region Function definition
		private void NavigateBtn_Click( object sender, EventArgs e )
		{
			if (gotoMenuIfSelected<Cafeteria>(CinemaHallRbtn)) return;
			if (gotoMenuIfSelected<SignIn>(ConcertHallRbtn)) return;
			if (gotoMenuIfSelected<SelectionHall>(ExhibitionHallRbtn)) return;
			if (gotoMenuIfSelected<DJHall>(DJHallRbtn)) return;
			if (gotoMenuIfSelected<MainHall>(MainHallRbtn)) return;
			if (gotoMenuIfSelected<DeviceHall>(DeviceHallRbtn)) return;

			var message = "Please select a hall to navigate through!";
			var boxIcon = MessageBoxIcon.Exclamation;
			AppMessage.showMessageBox( message, boxIcon );
		}

		private bool gotoMenuIfSelected<T>(RadioButton btn) where T : Form, new()
		{
			if (btn.Checked)
			{
				new T().Show();
				this.Hide();
				return true;
			}
			return false;
		}

		#endregion
	}
}