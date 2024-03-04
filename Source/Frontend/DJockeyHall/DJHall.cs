using System.Xml;

namespace Ergasia3.Source.Frontend.DJockeyHall
{
	public partial class DJHall : Form
	{
		private readonly List<Song> songs = [];

		#region Constructor definition
		public DJHall()
		{
			InitializeComponent();
			readSongsFromXML();

			foreach (Song s in songs)
			{
				ListViewItem newItem = songsListView.Items.Add(s.Name);
				newItem.SubItems.Add(s.Artist);
				newItem.SubItems.Add(s.Category);
				newItem.SubItems.Add(s.Duration);
			}
		}
		#endregion

		#region Function definition

		private void readSongsFromXML()
		{
			XmlDocument doc = new();
			doc.Load("Data/Songs.xml");

			XmlNode? rootNode = doc.SelectSingleNode("songs");
			if (rootNode == null)
				throw new XmlException("Root node != songs");

			foreach (XmlNode song in rootNode.ChildNodes)
			{
				if (song.Attributes == null || song.Attributes.Count != 5)
					throw new XmlException("Incorrect amount of attributes for song!");

				if (song.Attributes["title"] == null ||
					song.Attributes["artist"] == null ||
					song.Attributes["category"] == null ||
					song.Attributes["duration"] == null ||
					song.Attributes["songPath"] == null)
					throw new XmlException("Incorrect attributes for song!");

				songs.Add(new Song(
					song.Attributes["title"].Value,
					song.Attributes["artist"].Value,
					song.Attributes["category"].Value,
					song.Attributes["duration"].Value
				));
			}
		}

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

		private readonly struct Song(string name, string artist, string category, string duration)
		{
			public string Name { get; } = name;
			public string Artist { get; } = artist;
			public string Category { get; } = category;
			public string Duration { get; } = duration;
		}
	}
}
