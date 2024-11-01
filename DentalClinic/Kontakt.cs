using System;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace DentalClinic
{
    public partial class Kontakt : Form
    {
        // Prostokąty dla klikalnych linków
        private Rectangle emailLinkRect1;
        private Rectangle emailLinkRect2;
        private Rectangle emailLinkRect3;
        private Rectangle emailLinkRect4;

        public Kontakt()
        {
            InitializeComponent();
            this.tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            this.tableLayoutPanel1.MouseClick += tableLayoutPanel1_MouseClick;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Cennik cennikForm = new Cennik();
            cennikForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DlaczegoMy dlaczegoMyForm = new DlaczegoMy();
            dlaczegoMyForm.ShowDialog();
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

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            // Ustawienia czcionki
            Font boldFont = new Font("Arial", 10, FontStyle.Bold);
            Font regularFont = new Font("Arial", 9);
            Font italicFont = new Font("Arial", 9, FontStyle.Italic);
            Font largeBoldFont = new Font("Arial", 12, FontStyle.Bold);

            // Ustawienia pędzla
            Brush textBrush = Brushes.Black;

            // Kolumna 1 - Informacje o firmie (X = 50)
            e.Graphics.DrawString("Estetika Cierplikowski &\nDelmaczyński\nSp. Komandytowa", boldFont, textBrush, new PointF(50, 10));
            e.Graphics.DrawString("Al. W. Witosa 15B, 35-115 Rzeszów", regularFont, textBrush, new PointF(50, 60));
            e.Graphics.DrawString("NIP: 813 35 79 517", italicFont, textBrush, new PointF(50, 80));
            e.Graphics.DrawString("Biuro / Dyrektor:", boldFont, textBrush, new PointF(50, 100));
            e.Graphics.DrawString("Magdalena Delmaczyńska", regularFont, textBrush, new PointF(50, 120));

            // Ustawienie obszaru linku dla "estetika@estetika.com.pl"
            emailLinkRect1 = new Rectangle(50, 140, 200, 20);
            e.Graphics.DrawString("estetika@estetika.com.pl", regularFont, Brushes.Blue, emailLinkRect1.Location);

            e.Graphics.DrawString("Manager:", boldFont, textBrush, new PointF(50, 160));
            e.Graphics.DrawString("Natalia Nowak", regularFont, textBrush, new PointF(50, 180));
            e.Graphics.DrawString("tel.: 690 909 180", regularFont, textBrush, new PointF(50, 200));

            // Ustawienie obszaru linku dla "biuro@estetika.com.pl"
            emailLinkRect2 = new Rectangle(50, 220, 200, 20);
            e.Graphics.DrawString("biuro@estetika.com.pl", regularFont, Brushes.Blue, emailLinkRect2.Location);

            // Kolumna 2 - Rejestracja (X = 450)
            e.Graphics.DrawString("Rejestracja / umawianie wizyt", boldFont, textBrush, new PointF(450, 10));
            e.Graphics.DrawString("tel.: 17 850 43 85", largeBoldFont, textBrush, new PointF(450, 30));

            // Ustawienie obszaru linku dla "rejestracja@estetika.com.pl"
            emailLinkRect3 = new Rectangle(450, 60, 200, 20);
            e.Graphics.DrawString("rejestracja@estetika.com.pl", regularFont, Brushes.Blue, emailLinkRect3.Location);

            e.Graphics.DrawString("Jesteśmy do Twojej dyspozycji:", regularFont, textBrush, new PointF(450, 80));
            e.Graphics.DrawString("Pon-pt: 8:00-20:00", regularFont, textBrush, new PointF(450, 100));
            e.Graphics.DrawString("Sob: 8:00-14:00", regularFont, textBrush, new PointF(450, 120));

            // Kolumna 3 - Opiekun Pacjenta (X = 850)
            e.Graphics.DrawString("Opiekun Pacjenta", boldFont, textBrush, new PointF(850, 10));
            e.Graphics.DrawString("Dagmara Planeta", regularFont, textBrush, new PointF(850, 30));
            e.Graphics.DrawString("tel.: 690 002 940", regularFont, textBrush, new PointF(850, 50));

            // Ustawienie obszaru linku dla "opiekunpaczjenta@estetika.com.pl"
            emailLinkRect4 = new Rectangle(850, 70, 250, 20);
            e.Graphics.DrawString("opiekunpaczjenta@estetika.com.pl", regularFont, Brushes.Blue, emailLinkRect4.Location);

            e.Graphics.DrawString("Elżbieta Łyszczek", regularFont, textBrush, new PointF(850, 90));
            e.Graphics.DrawString("tel.: 690 903 890", regularFont, textBrush, new PointF(850, 110));
            e.Graphics.DrawString("opiekun@estetika.com.pl", regularFont, Brushes.Blue, new PointF(850, 130));

            // Zwolnienie zasobów czcionek po zakończeniu
            boldFont.Dispose();
            regularFont.Dispose();
            italicFont.Dispose();
            largeBoldFont.Dispose();
        }

        private void tableLayoutPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            // Sprawdzenie, czy kliknięto w obszar linków e-mail
            if (emailLinkRect1.Contains(e.Location))
            {
                System.Diagnostics.Process.Start("mailto:estetika@estetika.com.pl");
            }
            else if (emailLinkRect2.Contains(e.Location))
            {
                System.Diagnostics.Process.Start("mailto:biuro@estetika.com.pl");
            }
            else if (emailLinkRect3.Contains(e.Location))
            {
                System.Diagnostics.Process.Start("mailto:rejestracja@estetika.com.pl");
            }
            else if (emailLinkRect4.Contains(e.Location))
            {
                System.Diagnostics.Process.Start("mailto:opiekunpaczjenta@estetika.com.pl");
            }
        }




        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            // URL strony, którą chcesz otworzyć
            string url = "https://www.twojastrona.com";

            try
            {
                // Otwiera domyślną przeglądarkę internetową z podanym URL-em
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true // Umożliwia otwarcie w domyślnej przeglądarce
                });
            }
            catch (Exception ex)
            {
                // Obsługa błędów, np. gdy przeglądarka nie jest dostępna
                MessageBox.Show("Nie można otworzyć strony: " + ex.Message);
            }
        }



        private void webBrowser1_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
