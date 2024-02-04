using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ergasia3.src.Backend
{
	public static class AppMessage
	{

		public static DialogResult showMessageBox(string message, MessageBoxIcon boxIcon,
										  MessageBoxButtons buttons = MessageBoxButtons.OK)
		{
			var promptMessage = $"{message}";
			var caption = $"{boxIcon}";
			return MessageBox.Show( promptMessage, caption,
									buttons, boxIcon );
		}

	}
}