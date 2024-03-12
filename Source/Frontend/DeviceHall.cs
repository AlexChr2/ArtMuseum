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
using Ergasia3.Source.Backend;

namespace Ergasia3.Source.Frontend
{
	public partial class DeviceHall : BaseForm
	{

		private readonly string[] acState = [ "Off", "On" ];

		private readonly int[] audioBounds = [ 1, 100 ];
		private const int DeltaSound = 6;
		private int sampleSoundValue = 0;

		#region Constructor definition
		public DeviceHall()
		{
			InitializeComponent();
			this.initializeElements();
		}
		#endregion

		#region Function definition
		private void DeviceHall_FormClosed( object sender, FormClosedEventArgs e )
		{
			Application.OpenForms[ 1 ]?.Show();
		}

		private void initializeElements()
		{
			this.ACLbl.Text = $"{Globals.Temperature:f2}";
			this.ACFunctionBtn.Text = acState[ Globals.IsAcOn ? 1 : 0 ];

			this.AudioScrlBar.ValueChanged += this.AudioScrlBar_ValueModified;
			var avgSound = (audioBounds[ 1 ] - audioBounds[ 0 ]) / 2;
			Globals.Volume = audioBounds[ 0 ] + (avgSound - 6 * DeltaSound);

			this.AudioScrlBar.Value = Globals.Volume;
			this.AudioScrlBar.Minimum = this.audioBounds[ 0 ];
			this.AudioScrlBar.Maximum = this.audioBounds[ 1 ];
			this.AudioScrlBar.LargeChange = DeltaSound;
			this.ActualSoundLbl.Text = $"{Globals.Volume}";
			this.SampleSoundLbl.Text = $"{this.sampleSoundValue}";
		}

		private void DeviceHall_Shown( object sender, EventArgs e )
		{
			setPreviewPaletteColors();
		}

		private void ACIncrementBtn_Click( object sender, EventArgs e )
		{
			if( !Globals.IsAcOn )
				return;

			if( !Globals.Temperature.CanIncrement() )
			{
				var message = "Can't increment temperature anymore :)\n" +
							  "Max AC output level reached.";
				var boxIcon = MessageBoxIcon.Warning;
				AppMessage.showMessageBox( message, boxIcon );

				return;
			}

			Globals.Temperature++;
			updateAcText();
			SaveFile.SaveSetting( SaveFile.SN_temp, $"{Globals.Temperature}" );
		}

		private void ACDecrementBtn_Click( object sender, EventArgs e )
		{
			if( !Globals.IsAcOn )
				return;

			if( !Globals.Temperature.CanDecrement() )
			{
				var message = "Can't decrement temperature anymore :)\n" +
							  "Minimum AC output level reached.";
				var boxIcon = MessageBoxIcon.Information;
				AppMessage.showMessageBox( message, boxIcon );

				return;
			}
			Globals.Temperature--;
			updateAcText();
			SaveFile.SaveSetting( SaveFile.SN_temp, $"{Globals.Temperature}" );
		}

		private void updateAcText()
		{
			this.ACLbl.Text = $"{Globals.Temperature:f2}";
		}

		private void ACFunctionBtn_Click( object sender, EventArgs e )
		{
			Globals.IsAcOn = !Globals.IsAcOn;
			var acStateText = Globals.IsAcOn ? acState[ 1 ] : acState[ 0 ];

			var message = $"Ac turned {acStateText.ToLower()}";
			var boxIcon = MessageBoxIcon.Information;
			AppMessage.showMessageBox( message, boxIcon );

			this.ACFunctionBtn.Text = acStateText;

			SaveFile.SaveSetting( SaveFile.SN_acState, $"{Globals.IsAcOn}" );
		}

		private void AudioScrlBar_ValueModified( object sender, EventArgs e )
		{
			this.sampleSoundValue = this.AudioScrlBar.Value;
			this.SampleSoundLbl.Text = $"{this.sampleSoundValue}";
		}

		private void SetAudioBtn_Click( object sender, EventArgs e )
		{
			var result = AppMessage.showMessageBox(
				$"""
				Are you sure you want to change the audio 
				of the main hall to {this.sampleSoundValue}?
				""",
				MessageBoxIcon.Question,
				MessageBoxButtons.YesNo
			);

			if( result == DialogResult.Yes )
			{
				Globals.Volume = this.sampleSoundValue;
				this.ActualSoundLbl.Text = $"{Globals.Volume}";

				this.sampleSoundValue = 0;
				this.SampleSoundLbl.Text = $"{this.sampleSoundValue}";

				SaveFile.SaveSetting( SaveFile.SN_volume, $"{Globals.Volume}" );
			}
		}

		private void ApplyPalette0Btn_Click( object sender, EventArgs e )
		{
			var paletteIndex = 0;
			this.changePalette( paletteIndex );
		}

		private void PreviewPalette1Btn_Click( object sender, EventArgs e )
		{
			var paletteIndex = 1;
			this.changePalette( paletteIndex );
		}

		private void PreviewPalette2Btn_Click( object sender, EventArgs e )
		{
			var paletteIndex = 2;
			this.changePalette( paletteIndex );
		}

		private void PreviewPalette3Btn_Click( object sender, EventArgs e )
		{
			var paletteIndex = 3;
			this.changePalette( paletteIndex );
		}

		private void changePalette( int paletteIndex )
		{
			Palette.ApplyColorMatrix( this, paletteIndex );
			Globals.SelectedPaletteIndex = paletteIndex;

			setPreviewPaletteColors();
		}

		private void setPreviewPaletteColors()
		{
			this.palette1Col1Pnl.BackColor = Palette.ColorMap[ 1 ].Color1;
			this.palette1Col2Pnl.BackColor = Palette.ColorMap[ 1 ].Color2;
			this.palette1Col3Pnl.BackColor = Palette.ColorMap[ 1 ].Color3;

			this.palette2Col1Pnl.BackColor = Palette.ColorMap[ 2 ].Color1;
			this.palette2Col2Pnl.BackColor = Palette.ColorMap[ 2 ].Color2;
			this.palette2Col3Pnl.BackColor = Palette.ColorMap[ 2 ].Color3;

			this.palette3Col1Pnl.BackColor = Palette.ColorMap[ 3 ].Color1;
			this.palette3Col2Pnl.BackColor = Palette.ColorMap[ 3 ].Color2;
			this.palette3Col3Pnl.BackColor = Palette.ColorMap[ 3 ].Color3;
		}

		#endregion
	}
}