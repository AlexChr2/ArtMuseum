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

		#region Constructor definition
		public BaseForm()
		{
			InitializeComponent();

			this.Shown += this.applyPalette;
			this.VisibleChanged += this.applyPalette;
		}
		#endregion

		#region Function definition
		private void applyPalette( object? sender, EventArgs e )
		{
			DeviceHall.applyColorMatrix( this, Globals.SelectedPaletteIndex );
		}
		#endregion

	}
}
