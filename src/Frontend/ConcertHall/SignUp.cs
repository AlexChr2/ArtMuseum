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
		private void SignUpBtn_Click( object sender, EventArgs e )
		{
			if( AccountBase.areFieldsEmpty( this.UserNameTxtbx.Text,
											this.EmailTxtbx.Text,
											this.PasswordTxtbx.Text )
)
			{
				var message = "Please fill all of the fields!";
				var boxIcon = MessageBoxIcon.Warning;
				AppMessage.showMessageBox( message, boxIcon );

				return;
			}

			this.saveAccount();
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
				if( rootNode == null ) throw new Exception();
			}
			catch( Exception )
			{
				rootNode = document.CreateElement( AccountBase.RootNode );
				rootNodeExists = false;
			}

			if( rootNode != null )
			{
				if( rootNodeExists &&
					AccountBase.duplicateUsernameExists( rootNode, UserNameTxtbx.Text ) )
				{
					var message1 = "A user with that username already exists!";
					var boxIcon1 = MessageBoxIcon.Warning;
					AppMessage.showMessageBox( message1, boxIcon1 );

					return;
				}
			}

			this.createUserElement( document, rootNode, rootNodeExists );
			document.Save( AccountBase.File );

			var message = "Sign up successful!";
			var boxIcon = MessageBoxIcon.Information;
			AppMessage.showMessageBox( message, boxIcon );

			new SignIn().Show();
			this.Close();
		}

		private void createUserElement( XmlDocument document, XmlNode? rootNode, bool rootNodeExists )
		{
			var userNode = document.CreateElement( AccountBase.UserNodeName );
			var username = document.CreateAttribute( "username" );
			var email = document.CreateAttribute( "email" );
			var password = document.CreateAttribute( "password" );

			email.Value = this.EmailTxtbx.Text;
			username.Value = UserNameTxtbx.Text;

			var encryptedPassword = Encode.encryptPassword( this.PasswordTxtbx.Text );
			password.Value = encryptedPassword;

			userNode.Attributes.Append( username );
			userNode.Attributes.Append( email );
			userNode.Attributes.Append( password );

			rootNode.AppendChild( userNode );
			if( !rootNodeExists ) document.AppendChild( rootNode );
		}

		private void SignUp_FormClosed( object sender, FormClosedEventArgs e )
		{
			new SignIn().Show();
		}
		#endregion

		private void SignInLbl_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
		{
			new SignIn().Show();
			this.Close();
		}
	}
}