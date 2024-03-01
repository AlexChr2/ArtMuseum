using System.Xml;

namespace Ergasia3.Source.Frontend.DJockeyHall
{
	public partial class DJHall : Form
	{

		#region Constructor definition
		public DJHall()
		{
			InitializeComponent();
		}
		#endregion

		#region Function definition

		private void DigitalDJForm_Shown(object sender, EventArgs e)
		{
			BPM_scrollbar.Value = int.Parse(BPM_textLbl.Text);
			//restoreSettings();
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
			// TODO
		}

		private void DigitalDJ_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.OpenForms[0]?.Show();
		}

		private void BPM_scrollbar_ValueChanged(object sender, EventArgs e)
		{
			BPM_textLbl.Text = BPM_scrollbar.Value.ToString();
		}

		// same as above, but for a list of items (useful for ComboBoxes and such)
		//private XmlNode encodeListToXml(XmlDocument doc,
		//							string listName,
		//							ObjectCollection settingNames)
		//{
		//	XmlNode node = doc.CreateElement(listName);
		//	foreach (string name in settingNames)
		//	{
		//		node.AppendChild(encodeSettingToXML(doc, "listitem", name));
		//	}
		//	return node;
		//}
		#endregion
	}
}
