using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace DentalClinic
{
    public partial class comment : Form
    {
        private long visitId; // Id wizyty ,potrzebny do aktualizacji statusu wizyty

        public comment(long visitId)
        {
            InitializeComponent();
            this.visitId = visitId;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Ciąg połączenia do bazy danych SQLite
        private string connectionString = @"Data Source=C:\Users\halin\Desktop\DentalClinic\DataBase\DentalClinic.db;Version=3;";

        // Metoda nawiązująca połączenie z bazą danych
        public SQLiteConnection GetConnection()
        {
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            return connection;
        }

        private void Zapisz_Click(object sender, EventArgs e)
        {
            // Pobierz tekst z richTextBox1
            string commentText = richTextBox1.Text;

            // Sprawdzenie, czy komentarz nie jest pusty
            if (string.IsNullOrWhiteSpace(commentText))
            {
                MessageBox.Show("Proszę wprowadzić komentarz przed zapisaniem.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Zatrzymanie, jeśli komentarz jest pusty
            }

            // Połączenie z bazą danych
            using (var connection = GetConnection())
            {
                connection.Open();

                // Transakcja – zapis komentarza i aktualizacja statusu w jednym kroku
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Zapytanie SQL do dodania komentarza do tabeli Oceny
                        string insertCommentQuery = "INSERT INTO Oceny (comment) VALUES (@comment)";

                        using (var insertCommand = new SQLiteCommand(insertCommentQuery, connection, transaction))
                        {
                            insertCommand.Parameters.AddWithValue("@comment", commentText);
                            insertCommand.ExecuteNonQuery(); // Zapisz komentarz
                        }

                        // Zapytanie SQL do aktualizacji statusu wizyty na "Ukończona i oceniona"
                        string updateStatusQuery = "UPDATE Wizyty SET StatusWizyty = @status WHERE id = @visitId";

                        using (var updateCommand = new SQLiteCommand(updateStatusQuery, connection, transaction))
                        {
                            updateCommand.Parameters.AddWithValue("@status", "Ukończona i oceniona");
                            updateCommand.Parameters.AddWithValue("@visitId", visitId);
                            updateCommand.ExecuteNonQuery(); // Aktualizuj status wizyty
                        }

                        // Zatwierdzenie transakcji
                        transaction.Commit();
                        MessageBox.Show("Komentarz został wysłany do administracji, dziękujemy uprzejmie!");
                        this.Close(); // Zamknięcie formularza po zapisaniu
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback(); // Cofnięcie transakcji w razie błędu
                        MessageBox.Show($"Wystąpił błąd podczas zapisywania komentarza");
                    }
                }
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e){}
    }
}
