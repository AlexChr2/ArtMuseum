using Ergasia3.Source.Backend;
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

namespace Ergasia3.Source.Frontend.CinemaHall
{
	public partial class Cafeteria : BaseForm
	{

		private const uint NumberOfItems = 3;
		private Item[] foodItems = new Item[NumberOfItems];
		private Item[] drinksItems = new Item[NumberOfItems];
		private uint[] foodAmt = new uint[NumberOfItems];
		private uint[] drinksAmt = new uint[NumberOfItems];
		private ItemSelection itemSelection = ItemSelection.Foods;
		private Item[] selectedItems;

		// these exist for easier loop access
		private readonly PictureBox[] itemPBs;
		private readonly Label[] itemNames, itemLeftNums, itemPriceNums;

		#region Constructor definition
		public Cafeteria()
		{
			InitializeComponent();
			readAndUpdateInfoFromXML();
			itemPBs = [food1PB, food2PB, food3PB];
			itemNames = [food1Name, food2Name, food3Name];
			itemLeftNums = [food1LeftNum, food2LeftNum, food3LeftNum];
			itemPriceNums = [food1PriceNum, food2PriceNum, food3PriceNum];

			Random rnd = new();
			for (int i = 0; i < NumberOfItems; i++)
			{
				foodAmt[i] = (uint)rnd.Next(2, 60);
				drinksAmt[i] = (uint)rnd.Next(2, 80);
			}

			foodRadioBtn.Checked = true;
			drinksRadioBtn.Checked = false;
			selectedItems = foodItems;
			updateFormItems();
		}
		#endregion

		#region Function definition
		private void Cafeteria_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.OpenForms[1]?.Show();
		}

		private void foodRadioBtn_CheckedChanged(object sender, EventArgs e)
		{
			itemSelection = ItemSelection.Foods;
			updateFormItems();
		}

		private void drinksRadioBtn_CheckedChanged(object sender, EventArgs e)
		{
			itemSelection = ItemSelection.Drinks;
			updateFormItems();
		}

		private void food1CheckBox_CheckedChanged(object sender, EventArgs e)
		{
			updateTotalPrice();
		}

		private void food2CheckBox_CheckedChanged(object sender, EventArgs e)
		{
			updateTotalPrice();
		}

		private void food3CheckBox_CheckedChanged(object sender, EventArgs e)
		{
			updateTotalPrice();
		}

		private void buyButton_Click(object sender, EventArgs e)
		{
			if (!food1CheckBox.Checked && !food2CheckBox.Checked && !food3CheckBox.Checked)
			{
				AppMessage.showMessageBox(
					"Please select an item for purchase!",
					MessageBoxIcon.Warning
				);
				return;
			}

			uint[] selectedType = itemSelection == ItemSelection.Foods ? foodAmt : drinksAmt;

			if (food1CheckBox.Checked)
				--selectedType[0];
			if (food2CheckBox.Checked)
				--selectedType[1];
			if (food3CheckBox.Checked)
				--selectedType[2];
			AppMessage.showMessageBox("Purchase successful!", MessageBoxIcon.Information);
			updateItemAmounts();
			disableOutOfStockItems();
			resetAddToCheckBoxes();
		}

		#region XML Parsing
		private void readAndUpdateInfoFromXML()
		{
			XmlDocument doc = new();
			doc.Load("Data/CoffeeHall.xml");

			XmlNode? rootNode = doc.SelectSingleNode("coffee_hall");
			if (rootNode == null)
				throw new XmlException("Root node != coffee_hall");

			XmlNode? foodsNode = rootNode.SelectSingleNode("foods");
			XmlNode? drinksNode = rootNode.SelectSingleNode("drinks");

			if (foodsNode == null || drinksNode == null)
				throw new XmlException("foods or drinks node doesn't exist!");

			foodItems = grabItemsFromNode(foodsNode);
			drinksItems = grabItemsFromNode(drinksNode);
		}

		private static Item[] grabItemsFromNode(XmlNode node)
		{
			if (node.ChildNodes.Count != 3)
				throw new XmlException($"{node.Name} node must have 3 item children nodes!");

			Item[] returnedItems = new Item[NumberOfItems];
			for (int i = 0; i < node.ChildNodes.Count; i++)
			{
				XmlNode itemnode = node.ChildNodes[i];
				if (itemnode.Attributes == null || itemnode.Attributes.Count != 3)
					throw new XmlException("Incorrect amount of attributes in item node!");
				if (itemnode.Attributes["name"] == null ||
					itemnode.Attributes["price"] == null ||
					itemnode.Attributes["imagePath"] == null)
					throw new XmlException("Incorrect attributes in item node!");

				returnedItems[i] = new Item(
					itemnode.Attributes["name"].Value,
					float.Parse(itemnode.Attributes["price"].Value),
					itemnode.Attributes["imagePath"].Value
				);
			}
			return returnedItems;
		}
		#endregion

		private void updateFormItems()
		{
			switch (itemSelection)
			{
				case ItemSelection.Foods:
					selectedItems = foodItems;
					break;
				case ItemSelection.Drinks:
					selectedItems = drinksItems;
					break;
				default: // shouldn't happen
					selectedItems = foodItems;
					break;
			}

			for (int i = 0; i < itemPBs.Length; i++)
			{
				itemPBs[i].Load(selectedItems[i].ImagePath);
				itemNames[i].Text = selectedItems[i].Name;
				itemPriceNums[i].Text = $"{selectedItems[i].Price:f2}";
			}
			resetAddToCheckBoxes();
			updateItemAmounts();
			disableOutOfStockItems();
			updateTotalPrice();
		}

		private void updateTotalPrice()
		{
			totalPriceNum.Text = (
				(food1CheckBox.Checked ? selectedItems[0].Price : 0.0f) +
				(food2CheckBox.Checked ? selectedItems[1].Price : 0.0f) +
				(food3CheckBox.Checked ? selectedItems[2].Price : 0.0f)
			).ToString("f2");
		}

		private void updateItemAmounts()
		{
			for (int i = 0; i < itemPBs.Length; i++)
			{
				itemLeftNums[i].Text = itemSelection == ItemSelection.Foods ?
					foodAmt[i].ToString() : drinksAmt[i].ToString();
			}
		}

		private void resetAddToCheckBoxes()
		{
			food1CheckBox.Checked = false;
			food2CheckBox.Checked = false;
			food3CheckBox.Checked = false;
		}

		private void disableOutOfStockItems()
		{
			uint[] selectedItems = itemSelection == ItemSelection.Foods ? foodAmt : drinksAmt;
			if (selectedItems[0] == 0)
				food1CheckBox.Enabled = false;
			else if (selectedItems[1] == 0)
				food2CheckBox.Enabled = false;
			else if (selectedItems[2] == 0)
				food3CheckBox.Enabled = false;
		}
		#endregion

		private readonly struct Item( string name, float price, string imagepath )
		{
			internal string Name { get; } = name;
			internal float Price { get; } = price;
			internal string ImagePath { get; } = imagepath;
		};

		private enum ItemSelection
		{
			Foods,
			Drinks,
			max_itemselections
		}
	}
}