using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Ergasia3.Source.Backend
{
	// a class that reads ConcertHall.xml and tickets.xml, and returns
	// the information from them to a List or Array for easy access
	public static class ConcertHallXMLs
	{
		#region ConcertHall.xml parsing
		public static Presentation[] GetPresentations()
		{
			XmlDocument doc = new();
			doc.Load("Data/ConcertHall.xml");

			XmlNode? rootNode = doc.FirstChild;
			if (rootNode == null || !rootNode.Name.Equals("concert_hall"))
				throw new XmlException("Root Node != concert_hall!");
			XmlNode? presentationsNode = rootNode.SelectSingleNode("presentations");
			if (presentationsNode == null || presentationsNode.ChildNodes.Count == 0)
				throw new XmlException("Presentations node is null or empty!");
			if (presentationsNode.ChildNodes.Count != 3)
				throw new XmlException("Movie node count != 3!");

			return readMovieNodes(presentationsNode.ChildNodes);
		}

		private static Presentation[] readMovieNodes(XmlNodeList nodes)
		{
			Presentation[] resultArray = new Presentation[3];
			for (int i = 0; i < nodes.Count; i++)
			{
				if (!nodes[i].Name.Equals("movie") || nodes[i].Attributes == null
					|| nodes[i].Attributes["id"] == null)
					throw new XmlException("Invalid movie node!");

				uint id = uint.Parse(nodes[i].Attributes["id"].Value); // this can throw
				resultArray[i] = parseMovieNode(nodes[i], id);
			}
			return resultArray;
		}

		private static Presentation parseMovieNode(XmlNode node, uint id)
		{
			if (node.ChildNodes.Count != 4)
				throw new XmlException("Movie node attribute count != 4!");

			string title = string.Empty;
			string imagePath = string.Empty;
			string date = string.Empty;
			string time = string.Empty;
			foreach (XmlNode innode in node.ChildNodes)
			{
				switch (innode.Name)
				{
					case "title":
						title = innode.InnerText;
						break;
					case "image":
						imagePath = innode.InnerText;
						break;
					case "date":
						date = innode.InnerText;
						break;
					case "time":
						time = innode.InnerText;
						break;
					default:
						throw new XmlException($"Unknown attribute: {innode.Value}");
				}
			}
			return new Presentation(id, title, imagePath, date, time);
		}
		#endregion

		#region tickets.xml parsing
		public static Tickets GetTickets()
		{
			XmlDocument doc = new();
			doc.Load("tickets.xml");

			XmlNode? rootNode = doc.FirstChild;
			if (rootNode == null || !rootNode.Name.Equals("tickets"))
				throw new XmlException("Root Node != tickets!");
			if (rootNode.ChildNodes.Count == 0)
				return []; // return an empty list

			return readTicketNodes(rootNode.ChildNodes);
		}

		private static List<Ticket> readTicketNodes(XmlNodeList nodes)
		{
			List<Ticket> resultList = [];
			foreach (XmlNode node in nodes)
			{
				if (!node.Name.Equals("ticket") || node.Attributes == null)
					throw new XmlException("Invalid ticket node!");

				resultList.Add(parseTicketNode(node));
			}
			return resultList;
		}

		private static Ticket parseTicketNode(XmlNode node)
		{
			if (node.ChildNodes.Count != 3)
				throw new XmlException("Ticket node attribute count != 3!");

			string username = string.Empty;
			uint presentation_id = 0;
			uint seats = 0;
			foreach (XmlNode innode in node.ChildNodes)
			{
				switch (innode.Name)
				{
					case "username":
						username = innode.InnerText;
						break;
					case "presentation_id":
						presentation_id = uint.Parse(innode.InnerText);
						break;
					case "seats":
						seats = uint.Parse(innode.InnerText);
						break;
					default:
						throw new XmlException($"Unknown attribute: {innode.Value}");
				}
			}
			return new Ticket(username, presentation_id, seats);
		}
		#endregion

		#region tickets.xml saving
		#endregion

		#region Structs
		public readonly struct Presentation(uint id, string title,
			string imagePath, string date, string time)
		{
			public uint Id { get; } = id;
			public string Title { get; } = title;
			public string ImagePath { get; } = imagePath;
			public string Date { get; } = date;
			public string Time { get; } = time;
		}

		public readonly struct Ticket(string username, uint presentation_id, uint seats)
		{
			public string Username { get; } = username;
			public uint Presentation_ID { get; } = presentation_id;
			public uint Seats { get; } = seats;
		}
		#endregion
	}
}
