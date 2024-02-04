using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;
using Ergasia3.src.Backend;

namespace Ergasia3.src.Frontend
{
	public partial class DeviceHall : Form
	{

		private bool isAcOn = false;
		private readonly float[] acBounds = [15f, 30f];
		private const float deltaAc = 0.54f;
		private float currentTemperature;

		private readonly string[] acState = ["Off", "On"];
		private bool canIncrementAc = true;
		private bool canDecrementAc = true;

		private readonly int[] audioBounds = [12, 95];
		private const int deltaSound = 6;
		private int actualSoundValue;
		private int sampleSoundValue = 0;

		#region Constructor definition
		public DeviceHall()
		{
			InitializeComponent();
			this.initializeElements();
		}
		#endregion

		#region Function definition
		private void DeviceHall_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.OpenForms[0]?.Show();
		}

		private void ACIncrementBtn_Click(object sender, EventArgs e)
		{
			if (!this.isAcOn) return;

			this.checkAcState();
			if (this.isTemperatureValid())
			{
				if (!this.canIncrementAc)
				{
					var message = "Can't increment temperature anymore:)\n" +
								  "Max AC output level reached.";
					var boxIcon = MessageBoxIcon.Warning;
					AppMessage.showMessageBox(message, boxIcon);

					return;
				}

				var signAc = 1;
				this.updateAc(signAc);
			}
		}

		private void checkAcState()
		{
			this.canDecrementAc = (this.currentTemperature - deltaAc >= acBounds[0]);
			this.canIncrementAc = (this.currentTemperature + deltaAc <= acBounds[1]);
		}

		private bool isTemperatureValid()
		{
			return this.currentTemperature <= acBounds[1] &&
				   this.currentTemperature >= acBounds[0];
		}

		private void updateAc(int signAc)
		{
			this.currentTemperature += signAc * deltaAc;
			this.ACLbl.Text = $"{this.currentTemperature:f2}"
		}

		private void ACDecrementBtn_Click(object sender, EventArgs e)
		{
			if (!this.isAcOn) return;

			this.checkAcState();
			if (this.isTemperatureValid())
			{
				if (!this.canDecrementAc)
				{
					var message = "Can't decrement temperature anymore:)\n" +
								  "Minimum AC output level reached.";
					var boxIcon = MessageBoxIcon.Information;
					AppMessage.showMessageBox(message, boxIcon);

					return;
				}

				var signAc = -1;
				this.updateAc(signAc);
			}
		}

		private void ACFunctionBtn_Click(object sender, EventArgs e)
		{
			this.isAcOn = !this.isAcOn;
			var state = Convert.ToInt32(this.isAcOn);
			var acStateText = this.acState[state];

			var message = $"Ac turned {acStateText}";
			var boxIcon = MessageBoxIcon.Information;
			AppMessage.showMessageBox(message, boxIcon);

			this.ACFunctionBtn.Text = acStateText;
		}

		private void AudioScrlBar_ValueModified(object sender, EventArgs e)
		{
			this.sampleSoundValue = this.AudioScrlBar.Value;
			this.SampleSoundLbl.Text = $"{this.sampleSoundValue}";
		}

		private void SetAudioBtn_Click(object sender, EventArgs e)
		{
			var message = $"Are you sure you want to change\n" +
						  $"the audio of the main hall to {this.sampleSoundValue}?";
			var boxIcon = MessageBoxIcon.Question;
			var buttons = MessageBoxButtons.YesNo;
			var result = AppMessage.showMessageBox(message, boxIcon, buttons);

			var userChangedMainAudio = (result == DialogResult.Yes);
			if (userChangedMainAudio)
			{
				this.actualSoundValue = this.sampleSoundValue;
				this.ActualSoundLbl.Text = $"{this.actualSoundValue}";

				this.sampleSoundValue = 0;
				this.SampleSoundLbl.Text = $"{this.sampleSoundValue}";
			}
		}
		#endregion

		private void initializeElements()
		{
			var avgTemperature = (acBounds[1] - acBounds[0]) / 2;
			this.currentTemperature = acBounds[0] + avgTemperature;
			this.ACLbl.Text = $"{this.currentTemperature:f2}";

			this.AudioScrlBar.ValueChanged += this.AudioScrlBar_ValueModified;
			var avgSound = (audioBounds[1] - audioBounds[0]) / 2;
			this.actualSoundValue = audioBounds[0] + (avgSound - 6 * deltaSound);

			this.AudioScrlBar.Value = this.actualSoundValue;
			this.AudioScrlBar.Minimum = this.audioBounds[0];
			this.AudioScrlBar.Maximum = this.audioBounds[1];
			this.AudioScrlBar.LargeChange = deltaSound;
			this.ActualSoundLbl.Text = $"{this.actualSoundValue}";
			this.SampleSoundLbl.Text = $"{this.sampleSoundValue}";

			this.palette1Col1Pnl.BackColor = Palette.ColorMap[1].Color1;
			this.palette1Col2Pnl.BackColor = Palette.ColorMap[1].Color2;
			this.palette1Col3Pnl.BackColor = Palette.ColorMap[1].Color3;

			this.palette2Col1Pnl.BackColor = Palette.ColorMap[2].Color1;
			this.palette2Col2Pnl.BackColor = Palette.ColorMap[2].Color2;
			this.palette2Col3Pnl.BackColor = Palette.ColorMap[2].Color3;

			this.palette3Col1Pnl.BackColor = Palette.ColorMap[3].Color1;
			this.palette3Col2Pnl.BackColor = Palette.ColorMap[3].Color2;
			this.palette3Col3Pnl.BackColor = Palette.ColorMap[3].Color3;
		}

		private void setPaletteBtn_Click(object sender, EventArgs e)
		{

		}

		private void applyPalette1Btn_Click(object sender, EventArgs e)
		{
			var colorMatrixToBeApplied = Palette.ColorMap[1];
			this.applyColorMatrix(this, colorMatrixToBeApplied, 1);
		}

		private void applyPalette2Btn_Click(object sender, EventArgs e)
		{
			var colorMatrixToBeApplied = Palette.ColorMap[2];
			this.applyColorMatrix(this, colorMatrixToBeApplied, 2);
		}

		private void applyPalette3Btn_Click(object sender, EventArgs e)
		{
			var colorMatrixToBeApplied = Palette.ColorMap[3];
			this.applyColorMatrix(this, colorMatrixToBeApplied, 3);
		}

		private void applyColorMatrix(Control container, Palette.ColorMatrix colorMatrix, int paletteIndex)
		{
			foreach (Control control in container.Controls)
			{
				if (control is Panel || control is Label ||
					control is Button)
				{
					var backColor = control.BackColor;
					//control.BackColor = Palette.DarkColors[paletteIndex];

					if (this.isInColorList(Palette.DarkColors, backColor))
					{
						control.BackColor = Palette.DarkColors[paletteIndex];
					}
					else if (this.isInColorList(Palette.MediumColors, backColor))
					{
						control.BackColor = Palette.MediumColors[paletteIndex];
					}
					else
						control.BackColor = Palette.FrontColors[paletteIndex];
				}

				this.applyColorMatrix(control, colorMatrix, 1);
			}
		}

		private bool isInColorList(Color[] colorList, Color targetColor)
		{
			var newColorList = colorList.ToList();
			return newColorList.Contains(targetColor);
		}
	}
}