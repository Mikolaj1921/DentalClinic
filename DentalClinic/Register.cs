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


    }
}
