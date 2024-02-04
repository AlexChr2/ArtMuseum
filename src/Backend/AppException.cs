using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ergasia3.src.Backend
{
	public static class AppException
	{

		public static void showExceptionMessage( string message )
		{
			var promptMessage = $"{message}";
			var caption = "Warning";
			var buttons = MessageBoxButtons.OK;
			var boxIcon = MessageBoxIcon.Exclamation;
			MessageBox.Show( promptMessage, caption, buttons, boxIcon );
		}

	}
}