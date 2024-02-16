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

namespace Ergasia3.Source.Frontend.ConcertHall
{
	public partial class Account : Form
	{
		private static readonly Color ReservedSeatColor = Color.Red;
		private const uint TotalSeats = 36;
		private const uint TotalMoviePresentations = 3;

		// the first two are stored here for easy access
		private readonly Control[] moviePanels = new Control[TotalMoviePresentations];
		private readonly Control[] movieBackPanels = new Control[TotalMoviePresentations];
		private readonly Point[] moviePanelsOffsets = new Point[TotalMoviePresentations];
		// the panel that the cursor is on at the current moment
		private Control? hoveredMoviePanel = null;

		// TODO: this will be expanded for the total number of seats that
		// the form provides (TotalSeats)
		private readonly Control[] cinemaSeats = new Control[18];
		private readonly ConcertHallXMLs.Presentation[] presentations;
		private readonly List<ConcertHallXMLs.Ticket> tickets;
		private readonly uint[] tickets_reserved_per_movie = new uint[TotalMoviePresentations];

		#region Constructor definition
		public Account()
		{
			InitializeComponent();
			cinemaReservedPnl.BackColor = ReservedSeatColor;
			moviePanels = [moviePnl1, moviePnl2, moviePnl3];
			movieBackPanels = [movieBackPnl1, movieBackPnl2, movieBackPnl3];
			moviePanelsOffsets = [
				CalcRelativeOffsetForControl(moviePnl1),
				CalcRelativeOffsetForControl(moviePnl2),
				CalcRelativeOffsetForControl(moviePnl3)
			];
			cinemaSeats = [panel45, panel44, panel43, panel48, panel47,
				panel46, panel4, panel6, panel5, panel7, panel31, panel8,
				panel32, panel9, panel16, panel14, panel15, panel13
			];

			try
			{
				presentations = ConcertHallXMLs.GetPresentations();
				tickets = ConcertHallXMLs.GetTickets();

				Array.Clear(tickets_reserved_per_movie, 0, tickets_reserved_per_movie.Length);
				foreach (var ticket in tickets)
				{
					if (ticket.Presentation_ID > TotalMoviePresentations)
						throw new ArgumentException(@$"Invalid seat count 
							({ticket.Presentation_ID}) for ticket!"
						);
					for (uint _ = 0; _ < ticket.Seats; _++)
						tickets_reserved_per_movie[ticket.Presentation_ID]++;
				}
			}
			catch (XmlException e)
			{
				AppMessage.showMessageBox($"XML Error: {e.Message}", MessageBoxIcon.Error);
			}
			catch (Exception e)
			{
				AppMessage.showMessageBox(e.Message, MessageBoxIcon.Error);
			}
		}
		#endregion

		#region Function definition
		private void Account_FormClosed( object sender, FormClosedEventArgs e )
		{
			new SignIn().Show();
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			for (int i = 0; i < moviePanels.Length; i++)
			{
				lightUpHoveredMoviePanel(moviePanels[i], moviePanelsOffsets[i], movieBackPanels[i]);
			}
			lightUpCinemaSeats();

			if (hoveredMoviePanel == null)
				ticketsLbl.Text = string.Empty;
			// TODO: maybe this can be pulled off better than doing
			// hoveredMoviePanel.Equals... comparisons
			else if (hoveredMoviePanel.Equals(moviePnl1))
				ticketsLbl.Text = (TotalSeats - tickets_reserved_per_movie[0]).ToString();
			else if (hoveredMoviePanel.Equals(moviePnl2))
				ticketsLbl.Text = (TotalSeats - tickets_reserved_per_movie[1]).ToString();
			else if (hoveredMoviePanel.Equals(moviePnl3))
				ticketsLbl.Text = (TotalSeats - tickets_reserved_per_movie[2]).ToString();
		}

		private void lightUpHoveredMoviePanel(Control pnl, Point pnlOffset, Control bgPnl)
		{
			if (isCursorInControl(pnl, pnlOffset))
			{
				bgPnl.BackColor = Color.White;
				hoveredMoviePanel = pnl;
			}
			else
			{
				bgPnl.BackColor =
					Palette.ColorMap[Globals.SelectedPaletteIndex].Color1;
				if (pnl.Equals(hoveredMoviePanel))
					hoveredMoviePanel = null;
			}
		}

		private void lightUpCinemaSeats()
		{
			int index;
			if (hoveredMoviePanel == null)
			{
				foreach (Control seat in cinemaSeats)
					seat.BackColor = Color.White;
				return;
			}
			// TODO: same as TODO in timer_tick
			else if (hoveredMoviePanel.Equals(moviePnl1))
				index = 0;
			else if (hoveredMoviePanel.Equals(moviePnl2))
				index = 1;
			else if (hoveredMoviePanel.Equals(moviePnl3))
				index = 2;
			else
				throw new ArgumentException("hoveredMoviePanel has an invalid value!");

			for (uint i = 0; i < tickets_reserved_per_movie[index]; i++)
				cinemaSeats[i].BackColor = ReservedSeatColor;
			for (uint i = tickets_reserved_per_movie[index]; i < 18; i++)
				cinemaSeats[i].BackColor = Color.White;
		}

		// calculate the offset for a control relative to the form.
		// ex: the Control c is X pixels right and Y pixels down from
		// the top left corner of the form.
		// this method will return (0, 0) if c is already a parent of the
		// main form and not some panel (in which case just use c.Location)
		private static Point CalcRelativeOffsetForControl(Control c)
		{
			int x = 0, y = 0;
			while (c.Parent != null)
			{
				x += c.Location.X;
				y += c.Location.Y;
				c = c.Parent;
			}
			return new Point(x, y);
		}

		private bool isCursorInControl(Control pnl, Point pnlOffset)
		{
			Point cursorpos = PointToClient(Cursor.Position);
			if (cursorpos.X >= pnlOffset.X && cursorpos.X < pnlOffset.X + pnl.Width &&
				cursorpos.Y >= pnlOffset.Y && cursorpos.Y < pnlOffset.Y + pnl.Height)
				return true;
			return false;
		}
		#endregion
	}
}
