using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using Ergasia3.src.Backend;

namespace Ergasia3.src.Frontend.ConcertHall
{
	public partial class SignUp : Form
	{

		#region Constructor definition
		public SignUp()
		{
			InitializeComponent();
		}
		#endregion

		#region Function definition
		private void signUpButton_Click( object sender, EventArgs e )
		{
			if( Accounts.AreFieldsEmpty( usernameTextbox.Text,
										 emailTextBox.Text,
										 passwordTextBox.Text )
			) return;

			saveAccount();
		}

		private void saveAccount()
		{
			XmlDocument document = new();
			XmlNode? rootNode;
			bool rootNodeExists = true;

			try
			{
				document.Load( Accounts.File );
				rootNode = document.SelectSingleNode( Accounts.RootNode );
				var nodeDoesntExist = (rootNode == null);
				if( nodeDoesntExist ) throw new Exception();
			}
			catch( Exception )
			{
				rootNode = document.CreateElement( Accounts.RootNode );
				rootNodeExists = false;
			}

			if (rootNode != null)
			{
				if( rootNodeExists && 
					Accounts.CheckDuplicateUsername( rootNode, usernameTextbox.Text )
				  ) return;
			}

			createUserElement( document, rootNode, rootNodeExists );
			document.Save( Accounts.File );

			var infoMessage = "Sign up successful!";
			var caption = "Information";
			var buttons = MessageBoxButtons.OK;
			var boxIcon = MessageBoxIcon.Information;
			MessageBox.Show( infoMessage, caption, buttons, boxIcon );
		}

		private void createUserElement( XmlDocument document, XmlNode? rootNode, bool rootNodeExists )
		{
			var userNode = document.CreateElement( Accounts.UserNodeName );
			var username = document.CreateAttribute( "username" );
			var email = document.CreateAttribute( "email" );
			var password = document.CreateAttribute( "password" );

			email.Value = emailTextBox.Text;
			username.Value = usernameTextbox.Text;

			var hashedText = Encoding.ASCII.GetBytes( passwordTextBox.Text );
			byte[] hashedBytes = SHA512.HashData( hashedText );

			password.Value = Convert.ToHexString( hashedBytes ).ToLower();

			userNode.Attributes.Append( username );
			userNode.Attributes.Append( email );
			userNode.Attributes.Append( password );

			rootNode.AppendChild( userNode );
			if( !rootNodeExists ) document.AppendChild( rootNode );
		}

		private void SignUp_FormClosed( object sender, FormClosedEventArgs e )
		{
			Application.OpenForms[ 0 ]?.Show();
		}
		#endregion
	}
}