using Ergasia3.src;
using Ergasia3.src.Cinema;
using Ergasia3.src.ConcertBooking;
using Ergasia3.src.ExhibitionHall;

namespace Ergasia3.src
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new DeviceManager());
        }
    }
}