using System;
using System.Data;
using System.Data.SQLite; 
using System.Windows.Forms;

namespace DentalClinic
{
    internal class BD
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

            // Metoda do sprawdzenia połączenia
            public void CheckConnection()
            {
                using (SQLiteConnection connection = GetConnection())
                {
                    try
                    {
                        connection.Open(); // Otwieranie połączenia
                        MessageBox.Show("Połączenie z bazą danych zostało nawiązane pomyślnie!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        // Obsługa błędów
                        MessageBox.Show("Wystąpił błąd podczas nawiązywania połączenia: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        // Zamknięcie połączenia
                        connection.Close();
                    }
                }
            }

            // Metoda do dodawania użytkownika
            public void AddUser(string imie, string nazwisko, string telephone, int wiek, string plec, string userName, string email, string password)
            {
                using (SQLiteConnection connection = GetConnection())
                {
                    try
                    {
                        connection.Open();
                        using (SQLiteCommand command = new SQLiteCommand(
                            "INSERT INTO Uzytkownicy (Imie, Nazwisko, Telephone, Wiek, Plec, UserName, Email, Password) " +
                            "VALUES (@Imie, @Nazwisko, @Telephone, @Wiek, @Plec, @UserName, @Email, @Password)", connection))
                        {
                            // Przypisanie parametrów do kolumn
                            command.Parameters.AddWithValue("@Imie", imie);
                            command.Parameters.AddWithValue("@Nazwisko", nazwisko);
                            command.Parameters.AddWithValue("@Telephone", telephone);
                            command.Parameters.AddWithValue("@Wiek", wiek);
                            command.Parameters.AddWithValue("@Plec", plec);
                            command.Parameters.AddWithValue("@UserName", userName);
                            command.Parameters.AddWithValue("@Email", email);
                            command.Parameters.AddWithValue("@Password", password);

                            command.ExecuteNonQuery();
                            MessageBox.Show("Użytkownik dodany pomyślnie!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Wystąpił błąd podczas dodawania użytkownika: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }


            // Metoda do pobierania danych użytkowników
            public DataTable GetUsers()
            {
                DataTable usersTable = new DataTable();

                using (SQLiteConnection connection = GetConnection())
                {
                    try
                    {
                        connection.Open();
                        using (SQLiteCommand command = new SQLiteCommand("SELECT UserName, Email FROM Users", connection)) // Pobieramy tylko UserName i Email
                        {
                            using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                            {
                                adapter.Fill(usersTable);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Wystąpił błąd podczas pobierania użytkowników: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                return usersTable;
            }

            // Metoda do usuwania użytkownika
            public void DeleteUser(string email)
            {
                using (SQLiteConnection connection = GetConnection())
                {
                    try
                    {
                        connection.Open();
                        using (SQLiteCommand command = new SQLiteCommand("DELETE FROM Users WHERE Email = @Email", connection))
                        {
                            command.Parameters.AddWithValue("@Email", email);
                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Użytkownik usunięty pomyślnie!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Nie znaleziono użytkownika o podanym adresie e-mail.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Wystąpił błąd podczas usuwania użytkownika: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
