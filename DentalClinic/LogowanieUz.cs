using System;
using System.Data;
//using System.Data.OleDb;
using System.Data.SQLite;
using System.Windows.Forms;

namespace DentalClinic
{
    public partial class LogowanieUz : Form
    {
        // Zmienne do przechowywania danych logowania
        private string username;
        private string password;

        public LogowanieUz()
        {
            InitializeComponent();
        }

        private void LogowanieUz_Load(object sender, EventArgs e)
        {
            // Możesz zainicjować coś przy ładowaniu formularza, jeśli to konieczne  
        }

        private void Wroc_Click(object sender, EventArgs e)
        {
            this.Close(); // Zamknij okno logowania
        }

        private void Register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register regForm = new Register();
            regForm.ShowDialog(); // Otwórz formularz rejestracji jako modalny 
            this.Close(); // Zamknij okno logowania
        }



        private bool AuthenticateUser(string username, string password)
        {
            // Użycie SQLiteConnection z podanym ciągiem połączenia
            using (SQLiteConnection connection = new SQLiteConnection(@"Data Source=C:\Users\halin\Desktop\DentalClinic\DataBase\DentalClinic.db;Version=3;"))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM Uzytkownicy WHERE UserName = @UserName AND Password = @Password";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserName", username);
                        command.Parameters.AddWithValue("@Password", password);

                        int count = Convert.ToInt32(command.ExecuteScalar()); // Zwróci liczbę dopasowanych użytkowników

                        return count > 0; // Zwróci true, jeśli użytkownik istnieje
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wystąpił błąd podczas weryfikacji: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        private void Login_TextChanged(object sender, EventArgs e)
        {
            // Uaktualnij zmienną username przy każdej zmianie w polu logowania
            username = Login.Text; // Zakładając, że masz TextBox o nazwie txtUsername
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            // Uaktualnij zmienną password przy każdej zmianie w polu hasła
            password = Password.Text; // Zakładając, że masz TextBox o nazwie txtPassword
        }

        private void Zaloguj_Click(object sender, EventArgs e)
        {
            // Sprawdź, czy dane logowania zostały wprowadzone
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Proszę wprowadzić nazwę użytkownika i hasło.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (AuthenticateUser(username, password))
            {
                // Jeśli użytkownik jest zweryfikowany, otwórz główne okno
                WizytaOmow wizForm = new WizytaOmow();
                wizForm.Show();
            }
            else
            {
                MessageBox.Show("Niepoprawna nazwa użytkownika lub hasło.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void button3_Click(object sender, EventArgs e)
        {
            ONas onasForm = new ONas();
            onasForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DlaczegoMy dlaczegoMyForm = new DlaczegoMy();
            dlaczegoMyForm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
