using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalClinic
{
    public partial class GlownaStr : Form
    {
        public GlownaStr()
        {
            InitializeComponent();
        }

        private void GlownaStr_Load(object sender, EventArgs e)
        {
            // Ustawienie tekstu z nową linią
            TekstInfoGora.Text = "Rzeszów, Al. Witosa 15B\r\n\r\ntel.: 17 850 43 85\r\n\r\npon-pt: 8:00-20:00, sob: 8:00-14:00\r\n\r\nestetika@estetika.com.pl";
            Tekst1.Font = new Font(Tekst1.Font, FontStyle.Bold);
            Tekst1.Text = "Dobrze, że tu trafiłaś / eś!";
            label1.Text = "Klinika stomatologiczna Estetika to zespół doświadczonych lekarzy wyspecjalizowanych w poszczególnych dziedzinach stomatologii.\r\n\r\n" +
                "Kompleksową i wielopoziomową opiekę zapewniają profesjonaliści z zakresu stomatologii zachowawczej, estetycznej, ortodoncji, pedodoncji,\r\n" +
                "   protetyki, implantologii i periodontologii, którzy stale rozwijają swoje kompetencje oraz nie boją się sięgać po innowacje i nowoczesne\r\n" +
                "   rozwiązania w stomatologii.\r\n\r\n" +
                "Na 660 m2 powierzchni i w 6 świetnie wyposażonych gabinetach przywracamy pełny i zdrowy uśmiech naszym Pacjentom – i to już od 15 lat!\r\n\r\n" +
                "Właściwa pielęgnacja jak i profesjonalna profilaktyka stomatologiczna mają niebagatelne znaczenie dla zdrowia naszego uśmiechu.\r\n" +
                "Pozwalają one bowiem wyeliminować w całości wszelkie problemy i dolegliwości związane z zębami. Potrzebujesz wizyty u stomatologa?\r\n\r\n" +
                "Mamy na to rozwiązanie!";
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Visible = false;
        }

        private void TekstInfoGora_Click(object sender, EventArgs e)
        {

        }


        private void LogoGora_Click(object sender, EventArgs e)
        {

        }

        private void Tekst1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LogowanieUz logowanieForm = new LogowanieUz();
            logowanieForm.ShowDialog();

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
            DlaczegoMy dlaczegoMyForm = new DlaczegoMy();
            dlaczegoMyForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ONas onasForm = new ONas();
            onasForm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private int loggedUserId;
        private void ProfilUz_Click(object sender, EventArgs e)
        {
            LogowanieUz logowanieForm = new LogowanieUz();
            logowanieForm.SetProfileClicked(true, loggedUserId);  // Ustaw flagę isProfileClicked na true i przekaż ID użytkownika

            logowanieForm.ShowDialog(); // Użycie ShowDialog() zapewnia, że formularz będzie wyświetlany nad innymi

        }

        private void ZadajPytanie_Click(object sender, EventArgs e)
        {
            ZadajPytanie zadajForm = new ZadajPytanie();
            zadajForm.ShowDialog();
        }
    }
}
