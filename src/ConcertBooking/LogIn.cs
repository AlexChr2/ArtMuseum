using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Ergasia3.src.ConcertBooking
{
	public partial class LogIn : Form
	{
		public LogIn()
		{
			InitializeComponent();
		}

		private void loginButton_Click(object sender, EventArgs e)
		{
			if (Accounts.AreFieldsEmpty(usernameTextbox.Text, passwordTextbox.Text))
				return;

			try
			{
				checkInputData();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Oops",
					MessageBoxButtons.OK, MessageBoxIcon.Exclamation
				);
			}
		}

		private void checkInputData()
		{
			// TODO: perhaps declare this as a member variable to avoid re-opening the file
			// again and again when pressing the login button
			XmlDocument doc = new();

			doc.Load(Accounts.File);
			XmlNode? rootNode = doc.SelectSingleNode(Accounts.RootNode);
			if (rootNode == null)
				throw new Exception("No users were found!");

			Accounts.User? user = Accounts.FindUser(rootNode, usernameTextbox.Text);
			if (user == null)
				throw new Exception("The username or email are wrong. Please try again");

			byte[] hashedBytes =
				SHA512.HashData(Encoding.ASCII.GetBytes(passwordTextbox.Text));

			if (Convert.ToHexString(hashedBytes).ToLower().Equals(user.Value.Password))
			{
				MessageBox.Show("Login successful!");
				new Account().Show();
			}
			else
				throw new Exception("Wrong password!");
		}
	}
}
