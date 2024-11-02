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

            
            //LogowanieUz logowanieUz = new LogowanieUz(); // Utwórz instancję LogowanieUz
            //WizytaOmow wizytaOmow = new WizytaOmow(logowanieUz); // Tworzenie instancji WizytaOmow i przekazanie logowanieUz
            //Application.Run(wizytaOmow); // Uruchomienie aplikacji z instancją WizytaOmow




            Application.Run(new GlownaStr());
        }
    }
}
