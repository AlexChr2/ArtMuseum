using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Ergasia3.src.Backend;

namespace Ergasia3.src.Frontend.ConcertHall
{
	public partial class SignIn : Form
	{

		private readonly XmlDocument document = new();

		#region Constructor definition
		public SignIn()
		{
			InitializeComponent();
			this.document.Load( Accounts.File );
		}
		#endregion

		#region Function definition
		private void LogIn_FormClosed( object sender, FormClosedEventArgs e )
		{
			Application.OpenForms[ 0 ]?.Show();
		}
		#endregion

		private void SignInBtn_Click( object sender, EventArgs e )
		{
			if( Accounts.areFieldsEmpty( this.UsernameEmailTxtbx.Text,
										 this.PasswordTxtbx.Text )
			  ) return;

			try { this.checkUserData(); }
			catch( Exception ex ) 
			{
				var boxIcon = MessageBoxIcon.Warning;
				AppMessage.showMessageBox( ex.Message, boxIcon );
			}
		}

		private void checkUserData()
		{
			XmlNode? rootNode = this.document.SelectSingleNode( Accounts.RootNode );
			if( rootNode == null )
			{
				var message = "No users found!";
				throw new Exception( message );
			}

			Accounts.User? user = Accounts.findUser( rootNode, this.UsernameEmailTxtbx.Text );
			if( user == null )
			{
				var message = "Invalid username or email!";
				throw new Exception( message );
			}

			var byteSource = Encoding.ASCII.GetBytes( this.PasswordTxtbx.Text );
			var hashedBytes = SHA512.HashData( byteSource );

			var hexString = Convert.ToHexString( hashedBytes );
			hexString = hexString.ToLower();
			if( hexString.Equals( user.Value.Password ) )
			{
				var message = "Login successful!";
				var boxIcon = MessageBoxIcon.Information;
				AppMessage.showMessageBox( message, boxIcon );

				new Account().Show();
			}
			else
			{
				var message = "Wrong password inserted!";
				var boxIcon = MessageBoxIcon.Warning;
				AppMessage.showMessageBox( message, boxIcon );
			}
		}

		private void checkBox1_CheckedChanged( object sender, EventArgs e )
		{

		}

		private void SignInLbl_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
		{

		}
	}
}