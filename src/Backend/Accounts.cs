using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Ergasia3.src.Backend
{
	public static class Accounts
	{
		public static string File { get; } = "accounts.xml";
        public static string RootNode { get; } = "users";
        public static string UserNodeName { get; } = "user";

        public readonly struct User(string name, string password, string email)
        {
            internal string Name { get; } = name;
            internal string Password { get; } = password;
            internal string Email { get; } = email;
        }

        public static bool CheckDuplicateUsername(XmlNode rootNode, string username)
        {
            if ( FindUser(rootNode, username) != null )
            {
				var infoMessage = "A user with that username already exists!";
				var caption = "Warning";
				var buttons = MessageBoxButtons.OK;
				var boxIcon = MessageBoxIcon.Warning;
				MessageBox.Show( infoMessage, caption, buttons, boxIcon );

                return true;
            }

            return false;
        }

		public static User? FindUser( XmlNode rootNode, string key )
		{
			foreach( XmlNode node in rootNode.ChildNodes )
			{
				if( node.Attributes == null ||
					node.Attributes[ "username" ] == null ||
					node.Attributes[ "password" ] == null ||
					node.Attributes[ "email" ] == null
				) continue;

				if( node.Attributes[ "username" ].Value.Equals( key ) ||
					node.Attributes[ "email" ].Value.Equals( key ) )
				{
					return new User(
						node.Attributes[ "username" ].Value,
						node.Attributes[ "password" ].Value,
						node.Attributes[ "email" ].Value
					);
				}
			}
			return null;
		}

		public static bool AreFieldsEmpty(params string[] fields)
        {
            foreach ( var field in fields )
            {
                if ( field.Equals( string.Empty ) )
                {
					var infoMessage = "All fields must have a value!";
					var caption = "Warning";
					var buttons = MessageBoxButtons.OK;
					var boxIcon = MessageBoxIcon.Warning;
					MessageBox.Show( infoMessage, caption, buttons, boxIcon );

                    return true;
                }
            }
            return false;
        }
    }
}