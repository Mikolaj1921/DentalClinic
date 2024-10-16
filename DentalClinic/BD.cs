using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace DentalClinic
{
    internal class BD
    {
        public class AccessDatabaseConnection
        {
            // Ciąg połączenia do bazy danych Access
            private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\halin\Desktop\DentalClinic\DataBase\DentalClinic.accdb;";

            // Metoda nawiązująca połączenie z bazą danych
            public OleDbConnection GetConnection()
            {
                OleDbConnection connection = new OleDbConnection(connectionString);
                return connection;
            }

            // Metoda do sprawdzenia połączenia
            public void CheckConnection()
            {
                using (OleDbConnection connection = GetConnection())
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
            public void AddUser(string userName, string email, string password)
            {
                using (OleDbConnection connection = GetConnection())
                {
                    try
                    {
                        connection.Open();
                        using (OleDbCommand command = new OleDbCommand("INSERT INTO Users (UserName, Email, Password) VALUES (@UserName, @Email, @Password)", connection))
                        {
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

                using (OleDbConnection connection = GetConnection())
                {
                    try
                    {
                        connection.Open();
                        using (OleDbCommand command = new OleDbCommand("SELECT UserName, Email FROM Users", connection)) // Pobieramy tylko UserName i Email
                        {
                            using (OleDbDataAdapter adapter = new OleDbDataAdapter(command))
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
                using (OleDbConnection connection = GetConnection())
                {
                    try
                    {
                        connection.Open();
                        using (OleDbCommand command = new OleDbCommand("DELETE FROM Users WHERE Email = @Email", connection))
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
