using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace DentalClinic
{
    internal class BD_wiadomosc
    {
        public class SQLiteDatabaseConnection
        {
            // Ciąg połączenia do bazy danych SQLite
            private string connectionString = @"Data Source=C:\Users\halin\Desktop\DentalClinic\DataBase\DentalClinic.db;Version=3;";

            // Metoda nawiązująca połączenie z bazą danych
            public SQLiteConnection GetConnection()
            {
                SQLiteConnection connection = new SQLiteConnection(connectionString);
                return connection;
            }

            // Metoda do zapisywania wiadomości do bazy danych
            public void SaveMessage(string imieINazwisko, string email, string telefon, string wiadomosc)
            {
                using (SQLiteConnection connection = GetConnection())
                {
                    try
                    {
                        connection.Open(); // Otwieranie połączenia

                        // Zapytanie SQL do wstawienia danych do tabeli Wiadomosci
                        string query = "INSERT INTO Wiadomosci (ImieINazwisko, Email, Telefon, Wiadomosc) VALUES (@ImieINazwisko, @Email, @Telefon, @Wiadomosc)";

                        using (SQLiteCommand command = new SQLiteCommand(query, connection))
                        {
                            // Przypisanie wartości do parametrów zapytania
                            command.Parameters.AddWithValue("@ImieINazwisko", imieINazwisko);
                            command.Parameters.AddWithValue("@Email", email);
                            command.Parameters.AddWithValue("@Telefon", telefon);
                            command.Parameters.AddWithValue("@Wiadomosc", wiadomosc);

                            // Wykonanie zapytania
                            command.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        // Obsługa błędów
                        MessageBox.Show("Wystąpił błąd podczas zapisywania wiadomości: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
