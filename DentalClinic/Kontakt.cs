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
    public partial class Kontakt : Form
    {
        public Kontakt()
        {
            InitializeComponent();
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
    }
}
