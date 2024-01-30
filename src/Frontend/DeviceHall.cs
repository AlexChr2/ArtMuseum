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

		private bool isAcOn = false;
		private readonly float[] acBounds = [ 15f, 30f ];
		private const float deltaAc = 0.5f;
		private float currentTemperature;

		private readonly string[] acState = [ "Off", "On" ];
		private bool canIncrementAc = true;
		private bool canDecrementAc = true;

		#region Constructor definition
		public DeviceHall()
		{
			InitializeComponent();

			var avgTemperature = (acBounds[ 1 ] - acBounds[ 0 ]) / 2;
			this.currentTemperature = acBounds[ 0 ] + avgTemperature;
			this.ACLbl.Text = $"{this.currentTemperature:f2}";
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

			this.checkAcState();
			if( this.isTemperatureValid() )
			{
				if (!this.canIncrementAc)
				{
					var infoMessage = $"Can't increment temperature anymore:)\n" +
									  $"Max AC output level reached.";
					var caption = "Warning";
					var buttons = MessageBoxButtons.OK;
					var boxIcon = MessageBoxIcon.Warning;
					MessageBox.Show( infoMessage, caption, buttons, boxIcon );

					return;
				}

				var signAc = 1;
				this.updateAc( signAc );
			}
		}

		private void checkAcState()
		{
			this.canDecrementAc = (this.currentTemperature - deltaAc >= acBounds[ 0 ]);
			this.canIncrementAc = (this.currentTemperature + deltaAc <= acBounds[ 1 ]);
		}

		private bool isTemperatureValid()
		{
			return this.currentTemperature <= acBounds[ 1 ] &&
				   this.currentTemperature >= acBounds[ 0 ];
		}

		private void updateAc( int signAc )
		{
			this.currentTemperature += signAc * deltaAc;
			this.ACLbl.Text = $"{this.currentTemperature:f2}";
		}

		private void ACDecrementBtn_Click( object sender, EventArgs e )
		{
			if( !this.isAcOn ) return;

			this.checkAcState();
			if( this.isTemperatureValid() )
			{
				if( !this.canDecrementAc )
				{
					var infoMessage = $"Can't decrement temperature anymore:)\n" +
									  $"Minimum AC output level reached.";
					var caption = "Warning";
					var buttons = MessageBoxButtons.OK;
					var boxIcon = MessageBoxIcon.Warning;
					MessageBox.Show( infoMessage, caption, buttons, boxIcon );

					return;
				}

				var signAc = -1;
				this.updateAc( signAc );
			}
		}

		private void ACFunctionBtn_Click( object sender, EventArgs e )
		{
			this.isAcOn = !this.isAcOn;
			var state = Convert.ToInt32( this.isAcOn );
			var acStateText = this.acState[ state ];

			var infoMessage = $"Ac turned {acStateText}";
			var caption = "Information";
			var buttons = MessageBoxButtons.OK;
			var boxIcon = MessageBoxIcon.Information;
			MessageBox.Show( infoMessage, caption, buttons, boxIcon );

			this.ACFunctionBtn.Text = acStateText;
		}
	}
}