using System;
using System.Data;
using System.Windows.Forms;

namespace DentalClinic
{
    public partial class WizytaOmow : Form
    {
        private LogowanieUz logowanieUz;

        public WizytaOmow(LogowanieUz logowanieUz)
        {
            InitializeComponent();
            this.logowanieUz = logowanieUz; // Zapisz referencję do obiektu logowania
        }

        private void WizytaOmow_Load(object sender, EventArgs e)
        {
            // Tworzymy instancję klasy BDwizyty
            BDwizyty.SQLiteDatabaseConnection dbConnection = new BDwizyty.SQLiteDatabaseConnection();
            dbConnection.CheckConnection(); // Sprawdzenie połączenia

            // Pobieranie wizyt z bazy danych
            DataTable wizyty = dbConnection.GetWizyty();

            // Sprawdzenie, czy są jakieś wizyty
            if (wizyty.Rows.Count > 0)
            {
                // Ustawianie DataSource dla DataGridView
                dataGridView1.DataSource = wizyty.DefaultView;

                // Ustawienie widocznych kolumn w DataGridView
                dataGridView1.Columns["ImieLekarza"].HeaderText = "Imię Lekarza";
                dataGridView1.Columns["dataIczas"].HeaderText = "Data i Czas";

                dataGridView1.Columns["ImieLekarza"].ReadOnly = true;
                dataGridView1.Columns["dataIczas"].ReadOnly = true;

                // Dodanie kolumny przycisku
                DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
                buttonColumn.HeaderText = "Szczegóły";
                buttonColumn.Text = "Zarezerwuj wizytę";
                buttonColumn.UseColumnTextForButtonValue = true; // Używaj tekstu jako wartości przycisku
                dataGridView1.Columns.Add(buttonColumn);

                // Opcjonalnie: Ustawienie trybu automatycznego dopasowania kolumn
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                // Jeśli nie ma wizyt, informujemy użytkownika
                MessageBox.Show("Brak wizyt w bazie danych.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns.Count - 1) // Ostatnia kolumna to przycisk
            {
                // Pobranie ID wizyty z wybranego wiersza
                long visitId = Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["id"].Value); // Pobranie ID wizyty

                // Pobranie imienia lekarza i daty i czasu z wiersza
                string imieLekarza = dataGridView1.Rows[e.RowIndex].Cells["ImieLekarza"].Value.ToString();
                string dataIczas = dataGridView1.Rows[e.RowIndex].Cells["dataIczas"].Value.ToString();

                // Tworzenie i otwieranie formularza ZapisWizyty
                ZapisWizyty zapiswizytyForm = new ZapisWizyty(logowanieUz.UserName, visitId); // Przekazywanie UserName i ID wizyty
                zapiswizytyForm.LoadData(imieLekarza, dataIczas , visitId); // Przekazywanie danych do formularza
                zapiswizytyForm.Show(); // Wyświetlenie formularza
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GlownaStr glownaForm = new GlownaStr();
            glownaForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {}

        private void button4_Click(object sender, EventArgs e)
        {}

        private void button5_Click(object sender, EventArgs e)
        {}

        private void button6_Click(object sender, EventArgs e)
        {}

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
