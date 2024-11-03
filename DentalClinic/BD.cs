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
            private string connectionString = @"Data Source=C:\Users\halin\Desktop\DentalClinic\DataBase\DentalClinic.db;Version=3;";

            public SQLiteConnection GetConnection()
            {
                return new SQLiteConnection(connectionString);
            }

            // Metoda do sprawdzenia unikalności UserName
            public bool IsUserNameAvailable(string userName)
            {
                using (SQLiteConnection connection = GetConnection())
                {
                    try
                    {
                        connection.Open();
                        string query = "SELECT COUNT(*) FROM Uzytkownicy WHERE UserName = @UserName";
                        using (SQLiteCommand command = new SQLiteCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@UserName", userName);
                            int count = Convert.ToInt32(command.ExecuteScalar());
                            return count == 0; // Zwraca true, jeśli UserName nie istnieje
                        }
                    }
                    catch (Exception ex)
                    {
                        //MessageBox.Show("Wystąpił błąd podczas sprawdzania dostępności loginu: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false; // Zakładamy, że login nie jest dostępny w przypadku błędu
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
                        string query = "INSERT INTO Uzytkownicy (Imie, Nazwisko, Telephone, Wiek, Plec, UserName, Email, Password) " +
                                       "VALUES (@Imie, @Nazwisko, @Telephone, @Wiek, @Plec, @UserName, @Email, @Password)";
                        using (SQLiteCommand command = new SQLiteCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Imie", imie);
                            command.Parameters.AddWithValue("@Nazwisko", nazwisko);
                            command.Parameters.AddWithValue("@Telephone", telephone);
                            command.Parameters.AddWithValue("@Wiek", wiek);
                            command.Parameters.AddWithValue("@Plec", plec);
                            command.Parameters.AddWithValue("@UserName", userName);
                            command.Parameters.AddWithValue("@Email", email);
                            command.Parameters.AddWithValue("@Password", password);

                            command.ExecuteNonQuery();
                           // MessageBox.Show("Użytkownik dodany pomyślnie!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        //MessageBox.Show("Wystąpił błąd podczas dodawania użytkownika: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        string query = "SELECT UserName, Email FROM Uzytkownicy";
                        using (SQLiteCommand command = new SQLiteCommand(query, connection))
                        {
                            using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                            {
                                adapter.Fill(usersTable);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        //MessageBox.Show("Wystąpił błąd podczas pobierania użytkowników: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                return usersTable;
            }

            // Metoda do sprawdzenia połączenia z bazą
            public void CheckConnection()
            {
                using (SQLiteConnection connection = GetConnection())
                {
                    try
                    {
                        connection.Open();
                        //MessageBox.Show("Połączenie z bazą danych zostało nawiązane pomyślnie!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        //MessageBox.Show("Wystąpił błąd podczas nawiązywania połączenia: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
