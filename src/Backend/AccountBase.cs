using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Ergasia3.src.Backend
{
	public static class AccountBase
	{

		public static string File { get; } = "accounts.xml";
        public static string RootNode { get; } = "users";
        public static string UserNodeName { get; } = "user";

        public readonly struct User(string name, string email, string password)
        {
            internal string Name { get; } = name;
            internal string Email { get; } = email;
            internal string Password { get; } = password;
        }

		public static bool duplicateUsernameExists ( XmlNode rootNode, string username )
        {
			return findUser( rootNode, username ) != null;
        }

		public static User? findUser( XmlNode rootNode, string key )
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
					var name = node.Attributes[ "username" ].Value;
					var email = node.Attributes[ "email" ].Value;
					var password = node.Attributes[ "password" ].Value;

					return new User( name, email, password );
				}
			}

			return null;
		}

		public static bool areFieldsEmpty(params string[] fields)
        {
            foreach ( var field in fields )
                if ( field.Equals( string.Empty ) )
					return true;

            return false;
        }
    }
}