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


            //LogowanieUz logowanieUz = new LogowanieUz(); // Tworzenie instancji LogowanieUz
            //Application.Run(new WizytaOmow(logowanieUz)); // Przekazywanie instancji logowania



            Application.Run(new GlownaStr());
        }
    }
}
