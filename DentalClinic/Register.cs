using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalClinic
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void Wroc_Click(object sender, EventArgs e)
        {
            LogowanieUz logowanieForm = new LogowanieUz();

            // Otwórz nowe okno
            logowanieForm.ShowDialog();

            // Ukryj bieżące okno zamiast zamykać
            this.Close(); 
        }

        private void Login_TextChanged(object sender, EventArgs e)
        {

        }

        private void Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void Imie_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nazwisko_TextChanged(object sender, EventArgs e)
        {

        }

        private void Wiek_TextChanged(object sender, EventArgs e)
        {

        }

        private void Plec_TextChanged(object sender, EventArgs e)
        {

        }

        private void PhoneNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void Zaloguj_Click(object sender, EventArgs e)
        {
            // Pobranie danych z pól tekstowych na formularzu
            string imie = Imie.Text.Trim();
            string nazwisko = Nazwisko.Text.Trim();
            string phoneNum = PhoneNum.Text.Trim();
            int wiek;
            string plec = Plec.Text.Trim();
            string userName = Login.Text.Trim();
            string email = Email.Text.Trim();
            string password = Password.Text.Trim();

            // Sprawdzenie, czy wszystkie pola są wypełnione
            if (string.IsNullOrWhiteSpace(imie) || string.IsNullOrWhiteSpace(nazwisko) ||
                string.IsNullOrWhiteSpace(phoneNum) || string.IsNullOrWhiteSpace(plec) ||
                string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Wszystkie pola muszą być wypełnione!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Sprawdzenie formatu numeru telefonu
            if (!IsPhoneNumberValid(phoneNum))
            {
                MessageBox.Show("Numer telefonu musi zaczynać się od +48 i mieć 12 znaków (np. +48123456789).", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Sprawdzenie formatu adresu email
            if (!IsEmailValid(email))
            {
                MessageBox.Show("Adres e-mail musi być w formacie nazwa@nazwa.nazwa.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Sprawdzenie formatu wieku
            if (!int.TryParse(Wiek.Text, out wiek))
            {
                MessageBox.Show("Wiek musi być liczbą.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Utworzenie instancji klasy SQLiteDatabaseConnection i dodanie użytkownika
            BD.SQLiteDatabaseConnection dbConnection = new BD.SQLiteDatabaseConnection();
            try
            {
                dbConnection.AddUser(imie, nazwisko, phoneNum, wiek, plec, userName, email, password);
                MessageBox.Show("Rejestracja zakończona pomyślnie!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas rejestracji: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Metoda do walidacji numeru telefonu
        private bool IsPhoneNumberValid(string phoneNum)
        {
            return phoneNum.StartsWith("+48") && phoneNum.Length == 12;
        }

        // Metoda do walidacji adresu email
        private bool IsEmailValid(string email)
        {
            return email.Contains("@") && email.IndexOf("@") < email.Length - 1 &&
                   email.IndexOf(".", email.IndexOf("@")) > email.IndexOf("@") + 1;
        }


        private void Plec_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GlownaStr glownaForm = new GlownaStr();
            glownaForm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
