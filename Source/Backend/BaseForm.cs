using Ergasia3.Source.Frontend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ergasia3.Source.Backend
{
	// all Form classes inherit from BaseForm so the color palette can
	// automatically be applied without any changes to the new forms
	public class BaseForm : Form
	{
		public BaseForm()
		{
			Shown += applyPalette;
			VisibleChanged += applyPalette;
		}

		private void applyPalette(object? sender, EventArgs e)
		{
			DeviceHall.ApplyColorMatrix(this, Globals.SelectedPaletteIndex);
		}
	}
}
