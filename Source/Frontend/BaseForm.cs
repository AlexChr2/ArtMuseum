using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ergasia3.Source.Backend;

namespace Ergasia3.Source.Frontend
{
	public partial class BaseForm : Form
	{
		public BaseForm()
		{
			InitializeComponent();

			Shown += applyPalette;
			VisibleChanged += applyPalette;
		}

		private void applyPalette( object? sender, EventArgs e )
		{
			DeviceHall.ApplyColorMatrix( this, Globals.SelectedPaletteIndex );
		}
	}
}
