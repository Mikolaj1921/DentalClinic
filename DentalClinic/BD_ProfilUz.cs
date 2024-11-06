using System;
using System.Data;
using System.Data.SQLite;

namespace DentalClinic
{
    internal class BD_ProfilUz
    {
        public class SQLiteDatabaseConnection
        {
            private string connectionString = @"Data Source=C:\Users\halin\Desktop\DentalClinic\DataBase\DentalClinic.db;Version=3;";

            public SQLiteConnection GetConnection()
            {
                return new SQLiteConnection(connectionString);
            }
        }

        private SQLiteDatabaseConnection dbConnection = new SQLiteDatabaseConnection();

        // 1. Pobieranie danych użytkownika na podstawie jego id
        public DataTable GetUserProfile(int userId)
        {
            using (SQLiteConnection conn = dbConnection.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM Uzytkownicy WHERE id = @UserId";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                    {
                        DataTable userProfile = new DataTable();
                        adapter.Fill(userProfile);
                        return userProfile;
                    }
                }
            }
        }

        // 2. Aktualizowanie danych użytkownika
        public bool UpdateUserProfile(int userId, string userName, string email, string telephone, string imie, string nazwisko, int wiek, string plec)
        {
            using (SQLiteConnection conn = dbConnection.GetConnection())
            {
                conn.Open();
                string query = @"UPDATE Uzytkownicy SET 
                                    UserName = @UserName, 
                                    Email = @Email, 
                                    Telephone = @Telephone, 
                                    Imie = @Imie, 
                                    Nazwisko = @Nazwisko, 
                                    Wiek = @Wiek, 
                                    Plec = @Plec 
                                 WHERE id = @UserId";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserName", userName);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Telephone", telephone);
                    cmd.Parameters.AddWithValue("@Imie", imie);
                    cmd.Parameters.AddWithValue("@Nazwisko", nazwisko);
                    cmd.Parameters.AddWithValue("@Wiek", wiek);
                    cmd.Parameters.AddWithValue("@Plec", plec);
                    cmd.Parameters.AddWithValue("@UserId", userId);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0; // Zwraca true, jeśli aktualizacja się powiodła
                }
            }
        }

        // 3. Usuwanie konta użytkownika
        public bool DeleteUserAccount(int userId)
        {
            using (SQLiteConnection conn = dbConnection.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM Uzytkownicy WHERE id = @UserId";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0; // Zwraca true, jeśli usunięcie się powiodło
                }
            }
        }

        // 4. Pobieranie historii wizyt użytkownika
        public DataTable GetUserVisits(int userId)
        {
            using (SQLiteConnection conn = dbConnection.GetConnection())
            {
                conn.Open();
                string query = @"SELECT 
                                    id, 
                                    ImieLekarza, 
                                    ImiePacjenta, 
                                    NazwiskoPacjenta, 
                                    dataIczas, 
                                    OpisProblemu, 
                                    NrTelKlienta, 
                                    MailKlienta, 
                                    WiekPacjenta, 
                                    PlecP 
                                 FROM Wizyty 
                                 WHERE IdUsera = @UserId";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                    {
                        DataTable visitHistory = new DataTable();
                        adapter.Fill(visitHistory);
                        return visitHistory;
                    }
                }
            }
        }
    }
}
