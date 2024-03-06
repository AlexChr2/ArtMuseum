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
	public partial class CoffeeHall : BaseForm
	{

		private const uint itemLimit = 3;

		private ItemSelection itemSelection = ItemSelection.Foods;
		private Item[] foods = new Item[ itemLimit ];
		private Item[] drinks = new Item[ itemLimit ];
		private uint[] foodAmount = new uint[ itemLimit ];
		private uint[] drinkAmount = new uint[ itemLimit ];
		private Item[] selectedItems = [];

		private PictureBox[] itemImages;
		private Label[] itemNames, itemsLeft, itemsPrice;

		#region Constructor definition
		public CoffeeHall()
		{
			InitializeComponent();
			this.initializeElements();
		}
		#endregion

		#region Function definition
		private void Cafeteria_FormClosed( object sender, FormClosedEventArgs e )
		{
			Application.OpenForms[ 1 ]?.Show();
		}

		private void initializeElements()
		{
			this.readCoffeeHallItems();

			this.itemImages = [ this.Food1Pbx, this.Food2Pbx, this.Food3Pbx ];
			this.itemNames = [ this.Food1Name, this.Food2Name, this.Food3Name ];
			this.itemsLeft = [ this.Left1Lbl, this.Left2Lbl, this.Left3Lbl ];
			this.itemsPrice = [ this.Price1Lbl, this.Price2Lbl, this.Price3Lbl ];

			Random random = new();
			for( int k = 0; k < itemLimit; k++ )
			{
				this.foodAmount[ k ] = ( uint )(33 * random.NextDouble());
				this.drinkAmount[ k ] = ( uint )(42 * random.NextDouble());
			}

			this.FoodRbtn.Checked = true;
			this.DrinkRbtn.Checked = false;
			this.updateFormItems();
		}

		private void readCoffeeHallItems()
		{
			XmlDocument document = new();
			document.Load( "Data/CoffeeHall.xml" );

			XmlNode? rootNode = document.SelectSingleNode( "coffeehall" );
			if( rootNode == null )
			{
				var message = "Couldn't find root node!";
				throw new Exception( message );
			}

			XmlNode? foodNode = rootNode.SelectSingleNode( "foods" );
			XmlNode? drinkNode = rootNode.SelectSingleNode( "drinks" );

			if( foodNode == null || drinkNode == null )
			{
				var message = "foods or drinks node doesn't exist!";
				throw new Exception( message );
			}

			this.foods = this.grabItemsFrom( foodNode );
			this.drinks = this.grabItemsFrom( drinkNode );
		}

		private Item[] grabItemsFrom( XmlNode node )
		{
			if( node.ChildNodes.Count != itemLimit )
			{
				var message = $"{node.Name} node must have {itemLimit} children nodes!";
				throw new Exception( message );
			}

			var returnedItems = new Item[ itemLimit ];
			foreach( XmlNode itemNode in node.ChildNodes )
			{
				if( itemNode.Attributes == null || itemNode.Attributes.Count != itemLimit )
				{
					var message = "Incorrect amount of attributes in item node!";
					throw new Exception( message );
				}

				if( itemNode.Attributes[ "name" ] == null ||
					itemNode.Attributes[ "price" ] == null ||
					itemNode.Attributes[ "imagePath" ] == null )
				{
					var message = "Incorrect attributes in item node!";
					throw new Exception( message );
				}

				var name = itemNode.Attributes[ "name" ]?.Value;
				var price = float.Parse( itemNode.Attributes[ "price" ]?.Value );
				var imagePath = itemNode.Attributes[ "imagePath" ]?.Value;
				returnedItems.Append( new Item( name, price, imagePath ) );
			}

			return returnedItems;
		}

		private void FoodRbtn_CheckedChanged( object sender, EventArgs e )
		{
			this.itemSelection = ItemSelection.Foods;
			updateFormItems();
		}

		private void DrinkRbtn_CheckedChanged( object sender, EventArgs e )
		{
			this.itemSelection = ItemSelection.Drinks;
			updateFormItems();
		}

		private void updateItems()
		{
			for( int item = 0; item < this.itemImages.Length; item++ )
			{
				this.itemImages[ item ].Load( this.selectedItems[ item ].ImagePath );
				this.itemNames[ item ].Text = this.selectedItems[ item ].Name;
				this.itemsPrice[ item ].Text = $"{this.selectedItems[ item ].Price:f2}";
			}
		}

		private void updateAmountQuantity()
		{
			for( int i = 0; i < this.itemImages.Length; i++ )
			{
				var amountLeft = (this.itemSelection == ItemSelection.Foods ?
								 this.foodAmount[ i ] : this.drinkAmount[ i ]);
				this.itemsLeft[ i ].Text = amountLeft.ToString();
			}
		}
		#endregion



		private void updateFormItems()
		{
			this.selectedItems = this.itemSelection switch
			{
				ItemSelection.Foods => this.foods,
				ItemSelection.Drinks => this.drinks,
				_ => this.foods,
			};

			this.updateItems();
			this.updateAmountQuantity();
			//disableOutOfStockItems();
			//updateTotalPrice();
		}

		private void BuyBtn_Click( object sender, EventArgs e )
		{
			//if( !food1CheckBox.Checked && !food2CheckBox.Checked && !food3CheckBox.Checked )
			//{
			//	AppMessage.showMessageBox(
			//		"Please select an item for purchase!",
			//		MessageBoxIcon.Warning
			//	);
			//	return;
			//}

			var selectedType = (itemSelection == ItemSelection.Foods ?
									foodAmount : drinkAmount);

			//if( food1CheckBox.Checked )
			//	--selectedType[ 0 ];
			//if( food2CheckBox.Checked )
			//	--selectedType[ 1 ];
			//if( food3CheckBox.Checked )
			//	--selectedType[ 2 ];

			AppMessage.showMessageBox( "Purchase successful!", MessageBoxIcon.Information );
			this.updateItems();
			//disableOutOfStockItems();
		}

		//private void updateTotalPrice()
		//{
		//	TotalPrice.Text = (
		//		(food1CheckBox.Checked ? selectedItems[ 0 ].Price : 0.0f) +
		//		(food2CheckBox.Checked ? selectedItems[ 1 ].Price : 0.0f) +
		//		(food3CheckBox.Checked ? selectedItems[ 2 ].Price : 0.0f)
		//	).ToString( "f2" );
		//}

		//private void disableOutOfStockItems()
		//{
		//	var selectedItems = (this.itemSelection == ItemSelection.Foods ? 
		//							this.foodAmount : this.drinkAmount);
		//	if( selectedItems[ 0 ] == 0 )
		//		food1CheckBox.Enabled = false;
		//	else if( selectedItems[ 1 ] == 0 )
		//		food2CheckBox.Enabled = false;
		//	else if( selectedItems[ 2 ] == 0 )
		//		food3CheckBox.Enabled = false;
		//}

		private readonly struct Item( string name, float price, string imagepath )
		{
			internal string Name { get; } = name;
			internal float Price { get; } = price;
			internal string ImagePath { get; } = imagepath;
		};

		private enum ItemSelection
		{
			Foods,
			Drinks
		}
	}
}