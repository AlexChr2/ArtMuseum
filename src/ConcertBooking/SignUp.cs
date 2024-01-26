using System.Security.Cryptography;
using System.Text;
using System.Xml;

namespace Ergasia3.src.ConcertBooking
{
	public partial class SignUp : Form
	{
		public SignUp()
		{
			InitializeComponent();
		}

		private void signUpButton_Click(object sender, EventArgs e)
		{
			// don't sign up if the password, username, or email are blank
			if (Accounts.AreFieldsEmpty(usernameTextbox.Text,
				emailTextBox.Text, passwordTextBox.Text)
			)
				return;

			saveAccount();
		}

		private void saveAccount()
		{
			XmlDocument doc = new();
			XmlNode? rootNode;
			bool didRootNodeExist = true;
			try
			{
				doc.Load(Accounts.File);
				rootNode = doc.SelectSingleNode(Accounts.RootNode);
				if (rootNode == null)
					throw new Exception();
			}
			catch (Exception) // the file doesn't exist, re-create the root node
			{
				rootNode = doc.CreateElement(Accounts.RootNode);
				didRootNodeExist = false;
			}
			// check if this username already exists. if so, then show an error
			// message and exit
			if (didRootNodeExist && Accounts.CheckDuplicateUsername(rootNode, usernameTextbox.Text))
				return;

			// create the new user element
			XmlElement userNode = doc.CreateElement(Accounts.UserNodeName);
			XmlAttribute username = doc.CreateAttribute("username");
			username.Value = usernameTextbox.Text;
			XmlAttribute email = doc.CreateAttribute("email");
			email.Value = emailTextBox.Text;
			XmlAttribute password = doc.CreateAttribute("password");

			byte[] hashedBytes =
				SHA512.HashData(Encoding.ASCII.GetBytes(passwordTextBox.Text));
			password.Value = Convert.ToHexString(hashedBytes).ToLower();

			userNode.Attributes.Append(username);
			userNode.Attributes.Append(email);
			userNode.Attributes.Append(password);
			rootNode.AppendChild(userNode);
			if (!didRootNodeExist)
				doc.AppendChild(rootNode);

			doc.Save(Accounts.File);
			MessageBox.Show("Sign up successful!");
		}
	}
}
