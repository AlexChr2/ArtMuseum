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

		private void MainHall_FormClosing( object sender, FormClosingEventArgs e )
		{
			SaveFile.PerformSave();
		}

		private void MainHall_Shown( object sender, EventArgs e )
		{
			if( SaveFile.SavedItems.TryGetValue( SaveFile.SN_palette, out string? value ) )
			{
				Globals.SelectedPaletteIndex = int.Parse(SaveFile.SavedItems[SaveFile.SN_palette]);
				Palette.ApplyColorMatrix( this, Globals.SelectedPaletteIndex );
			}
		}
		#endregion

	}
}
