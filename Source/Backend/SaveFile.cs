using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Ergasia3.Source.Backend
{
	public class SaveFile
	{
		private const string SaveFileName = "save.xml";
		private const string SaveFileRootNodeName = "config";
		private const string XMLReadError = "Corrupted XML";

		public void Todo()
		{
			XmlDocument xmlDocument = new();
			XmlNode configNode = xmlDocument.CreateElement(SaveFileRootNodeName);

			//void save( string setting, string value )
			//{
			//	configNode.AppendChild( encodeSettingToXML( xmlDocument, setting, value ) );
			//}

			//void saveList(string listName, ObjectCollection items)
			//{
			//	configNode.AppendChild(encodeListToXml(xmlDocument, listName, items));
			//}

			//save("BPM", BPMscrollbar.Value.ToString());

			xmlDocument.AppendChild(configNode);
			try
			{
				xmlDocument.Save(SaveFileName);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error saving: " + ex.Message, "Error",
					MessageBoxButtons.OK, MessageBoxIcon.Error
				);
			}

			MessageBox.Show("Changes saved successfully!");
		}

		private void restoreSettings()
		{
			XmlDocument doc = new XmlDocument();
			try
			{
				doc.Load(SaveFileName);
			}
			catch (FileNotFoundException) // there's no file, just don't restore anything
			{
				return;
			}
			catch (XmlException)
			{
				MessageBox.Show("The backup save file is corrupted!", "Error",
					MessageBoxButtons.OK, MessageBoxIcon.Error
				);
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message, "Error",
					MessageBoxButtons.OK, MessageBoxIcon.Error
				);
			}

			try
			{
				XmlNodeList node = doc.GetElementsByTagName(SaveFileRootNodeName);
				if (node[0] == null)
					throw new Exception(XMLReadError);

				foreach (XmlNode innernode in node[0].ChildNodes)
				{
					restoreSettingFromXmlNode(innernode);
				}
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message, "Error parsing XML",
					MessageBoxButtons.OK, MessageBoxIcon.Error
				);
			}
		}

		private void restoreSettingFromXmlNode(XmlNode node)
		{
			static void throwIfNull(object obj)
			{
				if (obj == null)
					throw new Exception(XMLReadError);
			}

			// sanity check
			throwIfNull(node.Attributes["value"]);
			string value = node.Attributes["value"].Value;
			//switch( node.Name )
			//{
			//	case "BPM":
			//		BPMscrollbar.Value = int.Parse( value );
			//		break;
			//	case "bgcolor":
			//		int color = int.Parse( value );
			//		Application.OpenForms[ 0 ].BackColor = Color.FromArgb( color );
			//		break;
			//}

			//if (node.Name == "songplaysequence")
			//{
			//	songplaysequenceListbox.Items.Clear();
			//	foreach( XmlNode sps_node in node.ChildNodes )
			//	{
			//		// sanity check
			//		throwIfNull( sps_node.Attributes );
			//		XmlAttribute value = sps_node.Attributes[ "value" ];
			//		songplaysequenceListbox.Items.Add( value.Value );
			//	}
			//}
			//else
			//{

			//}
		}

		// gets information about a setting and encodes it to an XmlElement
		private XmlElement encodeSettingToXML(XmlDocument doc,
											string settingName, string value)
		{
			XmlElement playsongElement = doc.CreateElement(settingName);
			XmlAttribute playsongAttr = doc.CreateAttribute("value");
			playsongAttr.Value = value;
			playsongElement.Attributes.Append(playsongAttr);

			return playsongElement;
		}
	}
}
