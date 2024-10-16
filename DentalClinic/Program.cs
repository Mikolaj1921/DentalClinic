using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalClinic
{
    internal static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            // Tworzenie obiektu AccessDatabaseConnection z klasy BD
            //BD.AccessDatabaseConnection database = new BD.AccessDatabaseConnection();
            // Sprawdzenie połączenia z bazą danych
            //database.CheckConnection();


            //Application.Run(new LogowanieUz());
            Application.Run(new GlownaStr());
        }
    }
}
