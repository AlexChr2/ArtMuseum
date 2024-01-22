using System.Xml;
using static System.Windows.Forms.ListBox;

namespace Ergasia3
{
	public partial class DigitalDJForm : Form
	{
		private const string SaveFileName = "save.xml";
		private const string SaveFileRootNodeName = "config";

		public DigitalDJForm()
		{
			InitializeComponent();
		}

		private void colorButton_Click(object sender, EventArgs e)
		{
			DialogResult dr = colorDialog1.ShowDialog();
			if (dr == DialogResult.OK)
			{
				Application.OpenForms[0].BackColor = colorDialog1.Color;
			}
		}

		private void configurationbackupButton_Click(object sender, EventArgs e)
		{
			XmlDocument xmlDocument = new();
			XmlNode configNode = xmlDocument.CreateElement(SaveFileRootNodeName);

			void save(string setting, string value)
			{
				configNode.AppendChild(encodeSettingToXML(xmlDocument, setting, value));
			}

			void saveList(string listName, ObjectCollection items)
			{
				configNode.AppendChild(encodeListToXml(xmlDocument, listName, items));
			}

			save("playsong", playsongCombobox.Text);
			save("BPM", BPMscrollbar.Value.ToString());
			saveList("songplaysequence", songplaysequenceListbox.Items);
			save("songcategory", songcategoryCombobox.Text);
			save("bgcolor", colorDialog1.Color.ToArgb().ToString());

			xmlDocument.AppendChild(configNode);
			xmlDocument.Save(SaveFileName);
		}

		private void audiencesongrequestsButton_Click(object sender, EventArgs e)
		{

		}

		private void partytimeButton_Click(object sender, EventArgs e)
		{

		}

		private void specialfxButton_Click(object sender, EventArgs e)
		{

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

		// same as above, but for a list of items (useful for ComboBoxes and such)
		private XmlNode encodeListToXml(XmlDocument doc,
									string listName,
									ObjectCollection settingNames)
		{
			XmlNode node = doc.CreateElement(listName);
			foreach (string name in settingNames)
			{
				node.AppendChild(encodeSettingToXML(doc, "listitem", name));
			}
			return node;
		}
	}
}
