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
			if( AccountBase.areFieldsEmpty( this.UserNameTxtbx.Text,
										 this.EmailTxtbx.Text,
										 this.PasswordTxtbx.Text )
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
				document.Load( AccountBase.File );
				rootNode = document.SelectSingleNode( AccountBase.RootNode );
				var nodeDoesntExist = (rootNode == null);
				if( nodeDoesntExist ) throw new Exception();
			}
			catch( Exception )
			{
				rootNode = document.CreateElement( AccountBase.RootNode );
				rootNodeExists = false;
			}

			if (rootNode != null)
			{
				if( rootNodeExists && 
					AccountBase.checkDuplicateUsername( rootNode, UserNameTxtbx.Text )
				  ) return;
			}

			createUserElement( document, rootNode, rootNodeExists );
			document.Save( AccountBase.File );

			var infoMessage = "Sign up successful!";
			var caption = "Information";
			var buttons = MessageBoxButtons.OK;
			var boxIcon = MessageBoxIcon.Information;
			MessageBox.Show( infoMessage, caption, buttons, boxIcon );
		}

		private void createUserElement( XmlDocument document, XmlNode? rootNode, bool rootNodeExists )
		{
			var userNode = document.CreateElement( AccountBase.UserNodeName );
			var username = document.CreateAttribute( "username" );
			var email = document.CreateAttribute( "email" );
			var password = document.CreateAttribute( "password" );

			email.Value = this.EmailTxtbx.Text;
			username.Value = UserNameTxtbx.Text;

			var hashedText = Encoding.ASCII.GetBytes( this.PasswordTxtbx.Text );
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