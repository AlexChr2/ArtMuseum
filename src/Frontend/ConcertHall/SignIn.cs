using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
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
			this.document.Load( AccountBase.File );
		}
		#endregion

		#region Function definition
		private void LogIn_FormClosed( object sender, FormClosedEventArgs e )
		{
			Application.OpenForms[ 0 ]?.Show();
		}

		private void SignInBtn_Click( object sender, EventArgs e )
		{
			if( AccountBase.areFieldsEmpty( this.UsernameEmailTxtbx.Text,
										 this.PasswordTxtbx.Text ) )
			{
				var message = "All fields must have a value!";
				var boxIcon = MessageBoxIcon.Warning;
				AppMessage.showMessageBox( message, boxIcon );

				return;
			}

			try { this.checkUserData(); }
			catch( Exception ex )
			{
				var boxIcon = MessageBoxIcon.Warning;
				AppMessage.showMessageBox( ex.Message, boxIcon );
			}
		}

		private void checkUserData()
		{
			XmlNode? rootNode = this.document.SelectSingleNode( AccountBase.RootNode );
			if( rootNode == null )
			{
				var message = "No users found!";
				throw new Exception( message );
			}

			AccountBase.User? user = AccountBase.findUser( rootNode, this.UsernameEmailTxtbx.Text );
			if( user == null )
			{
				var message = "Invalid username or email!";
				throw new Exception( message );
			}

			var encryptedPassword = this.encryptPassword();
			if( encryptedPassword.Equals( user.Value.Password ) )
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

		private string encryptPassword()
		{
			var bytePassword = Encoding.ASCII.GetBytes( this.PasswordTxtbx.Text );
			var hashedPassword = SHA512.HashData( bytePassword );
			var hexStringPassword = Convert.ToHexString( hashedPassword );

			return hexStringPassword.ToLower();
		}

		private void SignUpLbl_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
		{
			new SignUp().Show();
			this.Hide();
		}

		private void PreviewPasswordChkBx_CheckedChanged( object sender, EventArgs e )
		{
			var password = this.PasswordTxtbx.Text;
			if( password.Equals( string.Empty ) ) return;

			this.PasswordTxtbx.PasswordChar = this.PreviewPasswordChkBx.Checked ? '\0' : '*';

		}
		#endregion
	}
}