using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalClinic
{
    public partial class TwojProfil : Form
    {
        private int loggedUserId;

        public TwojProfil(int userId)
        {
            InitializeComponent();
            loggedUserId = userId;

            // Ładowanie danych użytkownika i historii wizyt
            LoadUserData();
            LoadVisitHistory();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Kontakt kontaktForm = new Kontakt();
            kontaktForm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Cennik cennikForm = new Cennik();
            cennikForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DlaczegoMy dlaczegoForm = new DlaczegoMy();
            dlaczegoForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ONas onasForm = new ONas();
            onasForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GlownaStr glownaForm = new GlownaStr();
            glownaForm.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }

        private void ImieUz_TextChanged(object sender, EventArgs e)
        {
        }

        private void NazwiskoUz_TextChanged(object sender, EventArgs e)
        {
        }

        private void Wiek_TextChanged(object sender, EventArgs e)
        {
        }

        private void NrTelefonu_TextChanged(object sender, EventArgs e)
        {
        }

        private void Email_TextChanged(object sender, EventArgs e)
        {
        }

        private void UserName_TextChanged(object sender, EventArgs e)
        {
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
        }

        private void ZapiszDane_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=C:\Users\halin\Desktop\DentalClinic\DataBase\DentalClinic.db;Version=3;";
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE Uzytkownicy SET Imie = @Imie, Nazwisko = @Nazwisko, Wiek = @Wiek, Telephone = @Telephone, Email = @Email, UserName = @UserName, Password = @Password WHERE Id = @Id";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Imie", ImieUz.Text);
                    cmd.Parameters.AddWithValue("@Nazwisko", NazwiskoUz.Text);
                    cmd.Parameters.AddWithValue("@Wiek", Wiek.Text);
                    cmd.Parameters.AddWithValue("@Telephone", NrTelefonu.Text);
                    cmd.Parameters.AddWithValue("@Email", Email.Text);
                    cmd.Parameters.AddWithValue("@UserName", UserName.Text);
                    cmd.Parameters.AddWithValue("@Password", Haslo.Text);
                    cmd.Parameters.AddWithValue("@Id", loggedUserId);

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Dane zostały zaktualizowane.");
                    }
                    else
                    {
                        MessageBox.Show("Wystąpił błąd podczas aktualizacji danych.");
                    }
                }
            }
        }

        private void UsunKonto_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Czy na pewno chcesz usunąć swoje konto?", "Potwierdzenie usunięcia", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                string connectionString = @"Data Source=C:\Users\halin\Desktop\DentalClinic\DataBase\DentalClinic.db;Version=3;";
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM Uzytkownicy WHERE Id = @Id";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", loggedUserId);

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Konto zostało usunięte.");
                            this.Close(); // Zamyka aplikację po usunięciu konta
                        }
                        else
                        {
                            MessageBox.Show("Wystąpił błąd podczas usuwania konta.");
                        }
                    }
                }
            }
        }

        private void LoadUserData()
        {
            string connectionString = @"Data Source=C:\Users\halin\Desktop\DentalClinic\DataBase\DentalClinic.db;Version=3;";
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Imie, Nazwisko, Wiek, Telephone, Email, UserName, Password FROM Uzytkownicy WHERE Id = @Id";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", loggedUserId);
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            ImieUz.Text = reader["Imie"].ToString();
                            NazwiskoUz.Text = reader["Nazwisko"].ToString();
                            Wiek.Text = reader["Wiek"].ToString();
                            NrTelefonu.Text = reader["Telephone"].ToString();
                            Email.Text = reader["Email"].ToString();
                            UserName.Text = reader["UserName"].ToString();
                            Haslo.Text = reader["Password"].ToString();

                        }
                    }
                }
            }
        }


        private void LoadVisitHistory()
        {
            string connectionString = @"Data Source=C:\Users\halin\Desktop\DentalClinic\DataBase\DentalClinic.db;Version=3;";
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT Id, NazwiskoPacjenta, ImiePacjenta, WiekPacjenta, NrTelKlienta, MailKlienta, PlecP, ImieLekarza, DataICzas, StatusWizyty FROM Wizyty WHERE IdUsera = @IdUsera";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdUsera", loggedUserId);

                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        WizytyHistoria.DataSource = dataTable;
                        WizytyHistoria.RowHeadersVisible = false; // aby ukryć pole po lewej stronie tabeli(puste)


                        WizytyHistoria.Columns["id"].Visible = false;

                        // Sprawdzenie, czy kolumna "Oceń" już istnieje
                        if (!WizytyHistoria.Columns.Contains("Oceń"))
                        {
                            DataGridViewButtonColumn ocenColumn = new DataGridViewButtonColumn();
                            ocenColumn.Name = "Oceń";
                            ocenColumn.Text = "Oceń";
                            ocenColumn.UseColumnTextForButtonValue = true;
                            WizytyHistoria.Columns.Add(ocenColumn);

                        }

                        foreach (DataGridViewColumn column in WizytyHistoria.Columns)
                        {
                            if (column.Name != "Oceń")
                            {
                                column.ReadOnly = true;
                            }
                        }

                        foreach (DataGridViewRow row in WizytyHistoria.Rows)
                        {
                            if (row.Cells["StatusWizyty"].Value != null)
                            {
                                var status = row.Cells["StatusWizyty"].Value.ToString();
                                var ocenButton = row.Cells["Oceń"] as DataGridViewButtonCell;

                                if (ocenButton != null)
                                {
                                    if (status != "Ukończony")
                                    {
                                        ocenButton.ReadOnly = true;
                                    }
                                    else
                                    {
                                        ocenButton.ReadOnly = false;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }


        private void WizytyHistoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Sprawdzamy, czy kliknięto w przycisk "Oceń"
            if (e.RowIndex >= 0 && e.ColumnIndex == WizytyHistoria.Columns["Oceń"].Index)
            {
                var row = WizytyHistoria.Rows[e.RowIndex];

                // Sprawdzamy, czy komórka "StatusWizyty" nie jest null
                if (row.Cells["StatusWizyty"].Value != null)
                {
                    string statusWizyty = row.Cells["StatusWizyty"].Value.ToString();

                    // Jeśli status to "Ukończony", pokazujemy okno oceny
                    if (statusWizyty == "Ukończony")
                    {
                        int visitId = Convert.ToInt32(row.Cells["Id"].Value);
                        // Uruchamiamy formularz oceny wizyty
                        comment commForm = new comment(visitId);
                        commForm.ShowDialog();

                        
                    }
                    else
                    {
                        MessageBox.Show("Nie można ocenić wizyty, ponieważ nie jest ona ukończona lub została już oceniona wcześniej.");
                    }
                }
            }
        }

        private void TwojProfil_Load(object sender, EventArgs e)
        {
            LoadVisitHistory();
            LoadUserData();
            
        }

        private void Haslo_TextChanged(object sender, EventArgs e)
        {
        }

        private void ZadajPytanie_Click(object sender, EventArgs e)
        {
            ZadajPytanie zadajForm = new ZadajPytanie();
            zadajForm.ShowDialog();
        }
    }
}
