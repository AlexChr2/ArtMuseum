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

namespace Ergasia3.Source.Frontend.ConcertHall
{
	public partial class BookingHall : Form
	{
		private const uint MaxTicketReservations = 6;
		private const float SeatCost = 3.14f;

		private readonly Presentations presentations;
		private readonly string username;

		private uint seat_reservations = 2;

		public BookingHall(Presentations p, string username)
		{
			InitializeComponent();
			this.username = username;
			presentations = p;

			moviePB1.Load(presentations[0].ImagePath);
			movieDate1.Text = presentations[0].Date;
			movieTime1.Text = presentations[0].Time;
			movieTitle1.Text = presentations[0].Title;

			moviePB2.Load(presentations[1].ImagePath);
			movieDate2.Text = presentations[1].Date;
			movieTime2.Text = presentations[1].Time;
			movieTitle2.Text = presentations[1].Title;

			moviePB3.Load(presentations[2].ImagePath);
			movieDate3.Text = presentations[2].Date;
			movieTime3.Text = presentations[2].Time;
			movieTitle3.Text = presentations[2].Title;

			updateSeatAndPriceInfo();
		}

		private void updateSeatAndPriceInfo()
		{
			seatsLbl.Text = $"{seat_reservations}";
			float cost = SeatCost * seat_reservations;
			costTextLbl.Text = $"{cost:f2}";

			// if the cost exceeds the wallet's amount of money, make the price red
			if (cost > float.Parse(walletTextLbl.Text))
				costTextLbl.ForeColor = Color.Red;
			else
				costTextLbl.ForeColor = Palette.ColorMap[Globals.SelectedPaletteIndex].Color1;
		}

		private void ACDecrementBtn_Click(object sender, EventArgs e)
		{
			if (seat_reservations > 1)
			{
				--seat_reservations;
				updateSeatAndPriceInfo();
			}
		}

		private void ACIncrementBtn_Click(object sender, EventArgs e)
		{
			if (seat_reservations < MaxTicketReservations)
			{
				++seat_reservations;
				updateSeatAndPriceInfo();
			}
		}

		private void bookButton_Click(object sender, EventArgs e)
		{
			if (SeatCost * seat_reservations > float.Parse(walletTextLbl.Text))
			{
				AppMessage.showMessageBox(
					"You have insufficient funds to complete this operation!",
					MessageBoxIcon.Warning
				);
			}
			else
			{
				// TODO
				//ConcertHallXMLs.SaveTickets(tickets);
			}
		}
	}
}
