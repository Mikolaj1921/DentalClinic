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

        private void Plec_SelectedIndexChanged(object sender, EventArgs e)
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

        private void Haslo_TextChanged(object sender, EventArgs e)
        {
        }

        private void ZapiszDane_Click(object sender, EventArgs e)
        {
        }

        private void UsunKonto_Click(object sender, EventArgs e)
        {
        }

        private void LoadVisitHistory()
        {
            string connectionString = @"Data Source=C:\Users\halin\Desktop\DentalClinic\DataBase\DentalClinic.db;Version=3;";
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT NazwiskoPacjenta, ImiePacjenta, WiekPacjenta, NrTelKlienta, MailKlienta, PlecP, ImieLekarza, DataICzas, StatusWizyty FROM Wizyty WHERE IdUsera = @IdUsera";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdUsera", loggedUserId);

                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        WizytyHistoria.DataSource = dataTable;

                        // Dodanie kolumny z przyciskiem "Oceń"
                        DataGridViewButtonColumn ocenColumn = new DataGridViewButtonColumn();
                        ocenColumn.Name = "Oceń";
                        ocenColumn.Text = "Oceń";
                        ocenColumn.UseColumnTextForButtonValue = true;
                        WizytyHistoria.Columns.Add(ocenColumn);

                        // Zablokowanie edycji wszystkich komórek, oprócz przycisku "Oceń"
                        foreach (DataGridViewColumn column in WizytyHistoria.Columns)
                        {
                            if (column.Name != "Oceń")
                            {
                                column.ReadOnly = true; // Tylko przycisk "Oceń" będzie aktywny
                            }
                        }

                        // Ukrywanie przycisku "Oceń" w przypadku, gdy status wizyty nie jest "Ukończony"
                        foreach (DataGridViewRow row in WizytyHistoria.Rows)
                        {
                            if (row.Cells["StatusWizyty"].Value != null)
                            {
                                var status = row.Cells["StatusWizyty"].Value.ToString();
                                var ocenButton = row.Cells["Oceń"] as DataGridViewButtonCell;

                                if (ocenButton != null) // Upewniamy się, że komórka "Oceń" to przycisk
                                {
                                    if (status != "Ukończony")
                                    {
                                        ocenButton.ReadOnly = true;  // Zablokowanie przycisku
                                    }
                                    else
                                    {
                                        ocenButton.ReadOnly = false;  // Aktywowanie przycisku
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
                        // Możesz dodać kod do uruchomienia formularza oceny wizyty
                        MessageBox.Show($"Ocena wizyty o ID: {visitId}");
                    }
                    else
                    {
                        MessageBox.Show("Nie można ocenić wizyty, ponieważ nie jest ona ukończona.");
                    }
                }
            }
        }

        private void TwojProfil_Load(object sender, EventArgs e)
        {
            LoadVisitHistory();
        }
    }
}
