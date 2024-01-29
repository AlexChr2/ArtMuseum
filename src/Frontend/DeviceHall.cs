using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ergasia3.src.Frontend
{
	public partial class DeviceHall : Form
	{

		private readonly float[] acBounds = { 15f, 42f };
		private const float deltaAc = 0.5f;
		private bool isAcOn = false;

		private float currentTemperature = 24f;

		#region Constructor definition
		public DeviceHall()
		{
			InitializeComponent();
		}
		#endregion

		#region Function definition
		private void DeviceHall_FormClosed( object sender, FormClosedEventArgs e )
		{
			Application.OpenForms[ 0 ].Show();
		}
		#endregion

		private void ACIncrementBtn_Click( object sender, EventArgs e )
		{
			if( !this.isAcOn ) return;

			if (this.isTemperatureInBounds())
			{
				this.currentTemperature += deltaAc;
				this.updateAc();
			}

		}

		private void ACDecrementBtn_Click( object sender, EventArgs e )
		{
			if( !this.isAcOn ) return;

			if( this.isTemperatureInBounds() )
			{
				this.currentTemperature -= deltaAc;
				this.updateAc();
			}
		}

		private void ACFunctionBtn_Click( object sender, EventArgs e )
		{
			var acButtonText = this.isAcOn ? "Off" : "On";
			this.ACFunctionBtn.Text = acButtonText;
		}

		private bool isTemperatureInBounds()
		{
			return this.currentTemperature + deltaAc <= acBounds[ 1 ] &&
				   this.currentTemperature - deltaAc >= acBounds[ 0 ];
		}

		private void updateAc()
		{
			this.ACLbl.Text = $"{this.currentTemperature}";
		}
	}
}
