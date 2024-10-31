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
    public partial class DlaczegoMy : Form
    {
        public DlaczegoMy()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printPreviewControl1_Click(object sender, EventArgs e)
        {

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

        private void button2_Click_1(object sender, EventArgs e)
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
