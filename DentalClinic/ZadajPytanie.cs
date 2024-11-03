using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalClinic
{
    public partial class ZadajPytanie : Form
    {
        public ZadajPytanie()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ImieINazwisko_TextChanged(object sender, EventArgs e)
        {

        }

        private void Telefon_TextChanged(object sender, EventArgs e)
        {

        }

        private void Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void Wiadomosc_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Pobranie danych z pól tekstowych
            string imieINazwisko = ImieINazwisko.Text.Trim();
            string email = Email.Text.Trim();
            string telefon = Telefon.Text.Trim();
            string wiadomosc = Wiadomosc.Text.Trim();

            // Walidacja pól
            if (string.IsNullOrEmpty(imieINazwisko) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(telefon) || string.IsNullOrEmpty(wiadomosc))
            {
                MessageBox.Show("Wszystkie pola muszą być wypełnione!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Walidacja numeru telefonu: musi zaczynać się od +48 i mieć 12 znaków
            if (!telefon.StartsWith("+48") || telefon.Length != 12)
            {
                MessageBox.Show("Numer telefonu musi zaczynać się od +48 i mieć 12 znaków (np. +48123456789).", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Walidacja formatu adresu e-mail za pomocą wyrażenia regularnego
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(email, emailPattern))
            {
                MessageBox.Show("Adres e-mail musi być w formacie nazwa@nazwa.nazwa.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Walidacja pola Wiadomosc: nie może być puste
            if (string.IsNullOrEmpty(wiadomosc))
            {
                MessageBox.Show("Pole wiadomość nie może zostać puste.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Jeśli wszystkie walidacje się powiodły, zapisz wiadomość w bazie
            BD_wiadomosc.SQLiteDatabaseConnection dbConnection = new BD_wiadomosc.SQLiteDatabaseConnection();
            dbConnection.SaveMessage(imieINazwisko, email, telefon, wiadomosc);

            // Potwierdzenie zapisania wiadomości i wyczyszczenie pól tekstowych
            MessageBox.Show("Wiadomość została pomyślnie wysłana.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ImieINazwisko.Clear();
            Email.Clear();
            Telefon.Clear();
            Wiadomosc.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GlownaStr glownaForm = new GlownaStr();
            glownaForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ONas onasForm = new ONas();
            onasForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DlaczegoMy dlaczegoForm = new DlaczegoMy();
            dlaczegoForm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Cennik cennikForm = new Cennik();
            cennikForm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Kontakt kontaktForm = new Kontakt();
            kontaktForm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
