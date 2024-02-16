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
		private readonly Control[] cinemaSeats = new Control[5];

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
			cinemaSeats = [panel45, panel44, panel43, panel48, panel47];
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
			if (hoveredMoviePanel == null)
			{
				foreach (Control seat in cinemaSeats)
					seat.BackColor = Color.White;
			}
			// the fors below are only temporary
			// TODO: get the available seats through the XML tickets file,
			// and also update the tickets label number
			else if (hoveredMoviePanel.Equals(moviePnl1))
			{
				for (int i = 0; i < cinemaSeats.Length; i++)
					if (i == 0)
						cinemaSeats[i].BackColor = ReservedSeatColor;
					else
						cinemaSeats[i].BackColor = Color.White;
			}
			else if (hoveredMoviePanel.Equals(moviePnl2))
			{
				for (int i = 0; i < cinemaSeats.Length; i++)
					cinemaSeats[i].BackColor = ReservedSeatColor;
			}
			else if (hoveredMoviePanel.Equals(moviePnl3))
			{
				for (int i = 0; i < cinemaSeats.Length; i++)
					if (i < 3)
						cinemaSeats[i].BackColor = ReservedSeatColor;
					else
						cinemaSeats[i].BackColor = Color.White;
			}
			else
				throw new ArgumentException("hoveredMoviePanel has an invalid value!");
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
