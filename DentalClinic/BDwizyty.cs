using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace DentalClinic
{
    internal class BDwizyty
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
                    }
                    catch (Exception ex)
                    {
                        // Obsługa błędów
                        //MessageBox.Show("Wystąpił błąd podczas nawiązywania połączenia: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        // Zamknięcie połączenia
                        connection.Close();
                    }
                }
            }

            // Metoda do pobierania wizyt
            public DataTable GetWizyty()
            {
                DataTable dtWizyty = new DataTable();
                using (SQLiteConnection connection = GetConnection())
                {
                    try
                    {
                        connection.Open(); // Otwieranie połączenia

                        // Zapytanie SQL, aby pobierać tylko wiersze, gdzie ImieLekarza i dataIczas są wypełnione,
                        // a pozostałe kolumny są puste
                        string query = @"
                            SELECT id, ImieLekarza, dataIczas 
                            FROM Wizyty 
                            WHERE ImieLekarza IS NOT NULL AND ImieLekarza <> '' 
                            AND dataIczas IS NOT NULL AND dataIczas <> ''
                            AND (ImiePacjenta IS NULL OR ImiePacjenta = '')
                            AND (NazwiskoPacjenta IS NULL OR NazwiskoPacjenta = '')";
                

                        using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection))
                        {
                            adapter.Fill(dtWizyty); // Wypełnienie DataTable danymi z bazy
                        }
                    }
                    catch (Exception ex)
                    {
                        // Obsługa błędów
                        MessageBox.Show("Wystąpił błąd podczas pobierania wizyt: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                return dtWizyty; // Zwrócenie DataTable z danymi wizyt
            }






            //zapis do Wizyty

            public void SaveVisit(string nazwisko, string imie, int wiek, string nrTelefonu, string email, string plec, string imieLekarza, DateTime dataIczas, int idUsera)
            {
                using (SQLiteConnection connection = GetConnection())
                {
                    try
                    {
                        connection.Open(); // Otwieranie połączenia

                        // Zapytanie do sprawdzenia, czy pacjent już istnieje
                        string checkQuery = "SELECT COUNT(*) FROM Wizyty WHERE NrTelKlienta = @NrTelKlienta";
                        using (var checkCommand = new SQLiteCommand(checkQuery, connection))
                        {
                            checkCommand.Parameters.AddWithValue("@NrTelKlienta", nrTelefonu);
                            long count = (long)checkCommand.ExecuteScalar();

                            if (count > 0)
                            {
                                // Pacjent już istnieje, wykonaj aktualizację
                                string updateQuery = "UPDATE Wizyty SET NazwiskoPacjenta = @NazwiskoPacjenta, ImiePacjenta = @ImiePacjenta, " +
                                                     "WiekPacjenta = @WiekPacjenta, Email = @MailKlienta, PlecP = @PlecP, ImieLekarza = @ImieLekarza, " +
                                                     "DataICzas = @DataICzas, idUsera = @idUsera WHERE NrTelKlienta = @NrTelKlienta";

                                using (SQLiteCommand updateCommand = new SQLiteCommand(updateQuery, connection))
                                {
                                    updateCommand.Parameters.AddWithValue("@NazwiskoPacjenta", nazwisko);
                                    updateCommand.Parameters.AddWithValue("@ImiePacjenta", imie);
                                    updateCommand.Parameters.AddWithValue("@WiekPacjenta", wiek);
                                    updateCommand.Parameters.AddWithValue("@MailKlienta", email);
                                    updateCommand.Parameters.AddWithValue("@PlecP", plec);
                                    updateCommand.Parameters.AddWithValue("@ImieLekarza", imieLekarza);
                                    updateCommand.Parameters.AddWithValue("@DataICzas", dataIczas);
                                    updateCommand.Parameters.AddWithValue("@NrTelKlienta", nrTelefonu);
                                    updateCommand.Parameters.AddWithValue("@idUsera", idUsera);  // Przypisanie idUsera

                                    updateCommand.ExecuteNonQuery(); // Wykonaj aktualizację
                                }
                            }
                            else
                            {
                                // Pacjent nie istnieje, wykonaj wstawienie
                                string insertQuery = "INSERT INTO Wizyty (NazwiskoPacjenta, ImiePacjenta, WiekPacjenta, NrTelKlienta, MailKlienta, PlecP, ImieLekarza, DataICzas, idUsera) " +
                                                     "VALUES (@NazwiskoPacjenta, @ImiePacjenta, @WiekPacjenta, @NrTelKlienta, @MailKlienta, @PlecP, @ImieLekarza, @DataICzas, @idUsera)";

                                using (SQLiteCommand insertCommand = new SQLiteCommand(insertQuery, connection))
                                {
                                    insertCommand.Parameters.AddWithValue("@NazwiskoPacjenta", nazwisko);
                                    insertCommand.Parameters.AddWithValue("@ImiePacjenta", imie);
                                    insertCommand.Parameters.AddWithValue("@WiekPacjenta", wiek);
                                    insertCommand.Parameters.AddWithValue("@NrTelKlienta", nrTelefonu);
                                    insertCommand.Parameters.AddWithValue("@MailKlienta", email);
                                    insertCommand.Parameters.AddWithValue("@PlecP", plec);
                                    insertCommand.Parameters.AddWithValue("@ImieLekarza", imieLekarza);
                                    insertCommand.Parameters.AddWithValue("@DataICzas", dataIczas);
                                    insertCommand.Parameters.AddWithValue("@idUsera", idUsera);  // Przypisanie idUsera

                                    insertCommand.ExecuteNonQuery(); // Wykonaj wstawienie
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // MessageBox.Show("Wystąpił błąd podczas zapisywania wizyty: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connection.Close(); // Zamknięcie połączenia
                    }
                }
            }




        }
    }
}
