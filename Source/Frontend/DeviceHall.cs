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
	public partial class DeviceHall : Form
	{

		private readonly string[] acState = [ "Off", "On" ];

		private readonly int[] audioBounds = [ 12, 95 ];
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
		private void DeviceHall_FormClosed( object sender, FormClosedEventArgs e )
		{
			Application.OpenForms[ 0 ]?.Show();
		}

		private void ACIncrementBtn_Click( object sender, EventArgs e )
		{
			if( !Globals.IsAcOn ) return;

			if (!Globals.Temperature.CanIncrement())
			{
				var message = "Can't increment temperature anymore :)\n" +
							  "Max AC output level reached.";
				var boxIcon = MessageBoxIcon.Warning;
				AppMessage.showMessageBox( message, boxIcon );

				return;
			}

			Globals.Temperature++;
			updateAcText();
		}

		private void ACDecrementBtn_Click( object sender, EventArgs e )
		{
			if( !Globals.IsAcOn ) return;

			if (!Globals.Temperature.CanDecrement())
			{
				var message = "Can't decrement temperature anymore :)\n" +
							  "Minimum AC output level reached.";
				var boxIcon = MessageBoxIcon.Information;
				AppMessage.showMessageBox( message, boxIcon );

				return;
			}
			Globals.Temperature--;
			updateAcText();
		}

		private void updateAcText()
		{
			this.ACLbl.Text = $"{Globals.Temperature:f2}";
		}

		private void ACFunctionBtn_Click( object sender, EventArgs e )
		{
			Globals.IsAcOn = !Globals.IsAcOn;
			var acStateText = Globals.IsAcOn ? acState[1] : acState[0];

			var message = $"Ac turned {acStateText.ToLower()}";
			var boxIcon = MessageBoxIcon.Information;
			AppMessage.showMessageBox( message, boxIcon );

			this.ACFunctionBtn.Text = acStateText;
		}

		private void AudioScrlBar_ValueModified( object sender, EventArgs e )
		{
			this.sampleSoundValue = this.AudioScrlBar.Value;
			this.SampleSoundLbl.Text = $"{this.sampleSoundValue}";
		}

		private void SetAudioBtn_Click( object sender, EventArgs e )
		{
			var message = $"Are you sure you want to change\n" +
						  $"the audio of the main hall to {this.sampleSoundValue}?";
			var boxIcon = MessageBoxIcon.Question;
			var buttons = MessageBoxButtons.YesNo;
			var result = AppMessage.showMessageBox( message, boxIcon, buttons );

			var userChangedMainAudio = (result == DialogResult.Yes);
			if( userChangedMainAudio )
			{
				this.actualSoundValue = this.sampleSoundValue;
				this.ActualSoundLbl.Text = $"{this.actualSoundValue}";

				this.sampleSoundValue = 0;
				this.SampleSoundLbl.Text = $"{this.sampleSoundValue}";
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
			//this.BackColor = Palette.DarkColors[ paletteIndex ];
			ApplyColorMatrix( this, paletteIndex );
			Globals.SelectedPaletteIndex = paletteIndex;

			// restore the colors on the palette previews
			setPreviewPaletteColors();
		}

		public static void ApplyColorMatrix( Control container, int paletteIndex )
		{
			foreach( Control control in container.Controls )
			{
				if( control is Panel || control is Label ||
					control is Button || control is PictureBox)
				{
					var backColor = control.BackColor;
					var foreColor = control.ForeColor;

					if( IsInColorList( Palette.DarkColors, backColor ) )
						backColor = Palette.DarkColors[ paletteIndex ];

					if( IsInColorList( Palette.MediumColors, backColor ) )
						backColor = Palette.MediumColors[ paletteIndex ];

					if( IsInColorList( Palette.FrontColors, backColor ) )
						backColor = Palette.FrontColors[ paletteIndex ];

					if( IsInColorList( Palette.DarkColors, foreColor ) )
						foreColor = Palette.DarkColors[ paletteIndex ];

					if( IsInColorList( Palette.MediumColors, foreColor ) )
						foreColor = Palette.MediumColors[ paletteIndex ];

					if( IsInColorList( Palette.FrontColors, foreColor ) )
						foreColor = Palette.FrontColors[ paletteIndex ];

					control.BackColor = backColor;
					control.ForeColor = foreColor;
				}

				ApplyColorMatrix( control, paletteIndex );
			}
		}

		public static bool IsInColorList( Color[] colorList, Color targetColor )
		{
			return colorList.ToList().Contains( targetColor );
		}

		void setPreviewPaletteColors()
		{
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

		private void initializeElements()
		{
			this.ACLbl.Text = $"{Globals.Temperature:f2}";
			this.ACFunctionBtn.Text = acState[Globals.IsAcOn ? 1 : 0];

			this.AudioScrlBar.ValueChanged += this.AudioScrlBar_ValueModified;
			var avgSound = (audioBounds[ 1 ] - audioBounds[ 0 ]) / 2;
			this.actualSoundValue = audioBounds[ 0 ] + (avgSound - 6 * deltaSound);

			this.AudioScrlBar.Value = this.actualSoundValue;
			this.AudioScrlBar.Minimum = this.audioBounds[ 0 ];
			this.AudioScrlBar.Maximum = this.audioBounds[ 1 ];
			this.AudioScrlBar.LargeChange = deltaSound;
			this.ActualSoundLbl.Text = $"{this.actualSoundValue}";
			this.SampleSoundLbl.Text = $"{this.sampleSoundValue}";

			setPreviewPaletteColors();
		}
		#endregion

	}
}