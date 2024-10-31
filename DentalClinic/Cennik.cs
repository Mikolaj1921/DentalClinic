using System;
using System.Drawing;
using System.Windows.Forms;

namespace DentalClinic
{
    public partial class Cennik : Form
    {
        public Cennik()
        {
            InitializeComponent();
        }

        

        private void label1_Click(object sender, EventArgs e)
        {
            GlownaStr glownaForm = new GlownaStr();
            glownaForm.ShowDialog();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            GlownaStr glownaForm = new GlownaStr();
            glownaForm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Kontakt kontaktForm = new Kontakt();
            kontaktForm.ShowDialog();
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
    }
}
