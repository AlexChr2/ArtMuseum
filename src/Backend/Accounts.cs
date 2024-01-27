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
        public const string File = "accounts.xml";
        public const string RootNode = "users";
        public const string UserNodeName = "user";

        public readonly struct User(string name, string password, string email)
        {
            public string Name { get; } = name;
            public string Password { get; } = password;
            public string Email { get; } = email;
        }

        // key is either a username or email
        public static User? FindUser(XmlNode rootNode, string key)
        {
            foreach (XmlNode node in rootNode.ChildNodes)
            {
                // these shouldn't be null
                if (node.Attributes == null ||
                    node.Attributes["username"] == null ||
                    node.Attributes["password"] == null ||
                    node.Attributes["email"] == null
                )
                    continue;

                if (node.Attributes["username"].Value.Equals(key) ||
                    node.Attributes["email"].Value.Equals(key))
                {
                    return new User(
                        node.Attributes["username"].Value,
                        node.Attributes["password"].Value,
                        node.Attributes["email"].Value
                    );
                }
            }
            return null;
        }

        // returns true if there's already a user with the same username
        public static bool CheckDuplicateUsername(XmlNode rootNode, string username)
        {
            if (FindUser(rootNode, username) != null)
            {
                MessageBox.Show("A user with that username already exists!",
                    "Oops", MessageBoxButtons.OK, MessageBoxIcon.Exclamation
                );
                return true;
            }
            return false;
        }

        // if any field is empty, return true
        public static bool AreFieldsEmpty(params string[] fields)
        {
            foreach (string field in fields)
            {
                if (field == string.Empty)
                {
                    MessageBox.Show("All fields must have a value!",
                        ">:(", MessageBoxButtons.OK, MessageBoxIcon.Exclamation
                    );
                    return true;
                }
            }
            return false;
        }
    }
}
