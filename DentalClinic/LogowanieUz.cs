using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;

namespace DentalClinic
{
    public partial class LogowanieUz : Form
    {
        public int UserId { get; set; }
        public string UserName { get; set; }


        // Zmienne do przechowywania danych logowania
        private string username;
        private string password;

        //public string UserName => username;

        // Flaga, która śledzi, czy użytkownik kliknął "Profil Użytkownika"
        private bool isProfileClicked = false;
        private int loggedUserId; // ID zalogowanego użytkownika

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

        private bool AuthenticateUser(string username, string password)
        {
            // Użycie SQLiteConnection z podanym ciągiem połączenia
            using (SQLiteConnection connection = new SQLiteConnection(@"Data Source=C:\Users\halin\Desktop\DentalClinic\DataBase\DentalClinic.db;Version=3;"))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT id FROM Uzytkownicy WHERE UserName = @UserName AND Password = @Password";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserName", username);
                        command.Parameters.AddWithValue("@Password", password);

                        object result = command.ExecuteScalar(); // Zwróci id użytkownika lub null
                        if (result != null)
                        {
                            loggedUserId = Convert.ToInt32(result);
                            return true;
                        }
                        return false; // Zwróci false, jeśli użytkownik nie istnieje
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
            username = Login.Text; // Zakładając, że masz TextBox o nazwie txtUsername
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            password = Password.Text; // Zakładając, że masz TextBox o nazwie txtPassword
        }

        // Metoda wywoływana, gdy użytkownik kliknie na "Profil Użytkownika"
        public void SetProfileClicked(bool isClicked, int userId)
        {
            isProfileClicked = isClicked;  // Ustawienie flagi
            loggedUserId = userId; // Ustawienie ID użytkownika (jeśli dostępne)
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
                // Jeśli użytkownik jest zweryfikowany, pobierz jego UserId z bazy
                int loggedUserId = GetUserId(username);

                // Jeśli użytkownik kliknął Profil, przejdź do TwojProfil
                if (isProfileClicked)
                {
                    // Przekaż UserId do TwojProfil
                    TwojProfil twojProfilForm = new TwojProfil(loggedUserId);
                    twojProfilForm.ShowDialog();
                }
                else
                {
                    // Jeśli nie, przenieś go do UmowWizyte
                    WizytaOmow umowWizyteForm = new WizytaOmow(this);
                    umowWizyteForm.ShowDialog();
                    //umowWizyteForm.BringToFront();
                }

                
            }
            else
            {
                MessageBox.Show("Niepoprawna nazwa użytkownika lub hasło.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetUserId(string username)
        {
            int userId = 0;

            using (SQLiteConnection conn = new SQLiteConnection(@"Data Source=C:\Users\halin\Desktop\DentalClinic\DataBase\DentalClinic.db;Version=3;"))
            {
                conn.Open();
                string query = "SELECT Id FROM Uzytkownicy WHERE UserName = @UserName";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserName", username);

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        userId = Convert.ToInt32(result);
                    }
                }
            }

            return userId;
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            Color colorStart = Color.FromArgb(215, 215, 220);
            Color colorEnd = Color.FromArgb(180, 180, 180);

            // Tworzenie zaokrąglonego prostokąta
            int cornerRadius = 20;
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
            path.AddArc(panel3.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
            path.AddArc(panel3.Width - cornerRadius, panel3.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            path.AddArc(0, panel3.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
            path.CloseFigure();

            panel3.Region = new Region(path);

            // Gradient tła
            using (LinearGradientBrush brush = new LinearGradientBrush(panel3.ClientRectangle, colorStart, colorEnd, LinearGradientMode.Vertical))
            {
                e.Graphics.FillPath(brush, path);
            }
        }

        private void Register_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register registerForm = new Register();
            registerForm.ShowDialog();
            this.Close(); // Zamknij okno logowania
        }


        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
