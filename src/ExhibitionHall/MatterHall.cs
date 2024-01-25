using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Ergasia3.src.ExhibitionHall
{
	public partial class MatterHall : Form
	{
		private const string XMLPath = "Data/gallery.xml";
		private readonly List<PresentationContents> presentations = [];

		private readonly struct PresentationContents
		{
			private readonly string imagePath;
			private readonly string info;

			public PresentationContents(string imagePath, string info)
			{
				this.imagePath = imagePath;
				this.info = info;
			}
		}

		public MatterHall()
		{
			InitializeComponent();
		}

		private void MatterHall_Shown(object sender, EventArgs e)
		{
			// temporary, this should be passed as a parameter from HallSelection
			readGalleryFile(SelectionCategory.Music);
		}

		private void readGalleryFile(SelectionCategory category)
		{
			XmlDocument doc = new();
			try
			{
				doc.Load(XMLPath);
				XmlNode? rootNode = doc.SelectSingleNode("gallery");
				if (rootNode == null)
					throw new Exception();

				string nodeSelection = "";
				switch (category)
				{
					case SelectionCategory.Art:
						nodeSelection = "painting";
						break;
					case SelectionCategory.Music:
						nodeSelection = "music";
						break;
					case SelectionCategory.Movies:
						nodeSelection = "movies";
						break;
				}

				XmlNode? presContents = rootNode.SelectSingleNode(nodeSelection);
				if (presContents == null)
					throw new Exception();

				List<PresentationContents> presentationContents = [];
				foreach (XmlNode node in presContents.ChildNodes)
				{
					XmlNode? imagePath = node.SelectSingleNode("image");
					XmlNode? info = node.SelectSingleNode("info");

					if (imagePath == null ||
						info == null ||
						imagePath.Attributes["path"] == null
					)
						continue;
					else
					{
						// replace endlines with a space and remove \t
						string infoText = info.InnerText.Replace(
							Environment.NewLine, " ");
						infoText = infoText.Replace("\t", "");
						presentationContents.Add(new PresentationContents(
							imagePath.Attributes["path"].Value,
							infoText
						));
					}
				}
			}
			catch (Exception)
			{
				// TODO: what to show on-screen in this case?
				return;
			}

		}
	}
}
