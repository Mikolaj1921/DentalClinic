namespace DentalClinic
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Password = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.TextBox();
            this.Zaloguj = new System.Windows.Forms.Button();
            this.Wroc = new System.Windows.Forms.Button();
            this.Email = new System.Windows.Forms.TextBox();
            this.PhoneNum = new System.Windows.Forms.TextBox();
            this.Imie = new System.Windows.Forms.TextBox();
            this.Nazwisko = new System.Windows.Forms.TextBox();
            this.Wiek = new System.Windows.Forms.TextBox();
            this.Plec = new System.Windows.Forms.CheckedListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.LogoGora = new System.Windows.Forms.PictureBox();
            this.button7 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoGora)).BeginInit();
            this.SuspendLayout();
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(607, 623);
            this.Password.MinimumSize = new System.Drawing.Size(329, 30);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(329, 30);
            this.Password.TabIndex = 9;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(607, 503);
            this.Login.MinimumSize = new System.Drawing.Size(329, 30);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(329, 30);
            this.Login.TabIndex = 8;
            this.Login.TextChanged += new System.EventHandler(this.Login_TextChanged);
            // 
            // Zaloguj
            // 
            this.Zaloguj.Location = new System.Drawing.Point(807, 723);
            this.Zaloguj.Name = "Zaloguj";
            this.Zaloguj.Size = new System.Drawing.Size(129, 30);
            this.Zaloguj.TabIndex = 6;
            this.Zaloguj.Text = "Załóż konto";
            this.Zaloguj.UseVisualStyleBackColor = true;
            this.Zaloguj.Click += new System.EventHandler(this.Zaloguj_Click);
            // 
            // Wroc
            // 
            this.Wroc.Location = new System.Drawing.Point(607, 723);
            this.Wroc.Name = "Wroc";
            this.Wroc.Size = new System.Drawing.Size(109, 30);
            this.Wroc.TabIndex = 5;
            this.Wroc.Text = "Wróć";
            this.Wroc.UseVisualStyleBackColor = true;
            this.Wroc.Click += new System.EventHandler(this.Wroc_Click);
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(607, 563);
            this.Email.MinimumSize = new System.Drawing.Size(329, 30);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(329, 30);
            this.Email.TabIndex = 10;
            this.Email.TextChanged += new System.EventHandler(this.Email_TextChanged);
            // 
            // PhoneNum
            // 
            this.PhoneNum.Location = new System.Drawing.Point(607, 443);
            this.PhoneNum.MinimumSize = new System.Drawing.Size(329, 30);
            this.PhoneNum.Name = "PhoneNum";
            this.PhoneNum.Size = new System.Drawing.Size(329, 30);
            this.PhoneNum.TabIndex = 11;
            this.PhoneNum.TextChanged += new System.EventHandler(this.PhoneNum_TextChanged);
            // 
            // Imie
            // 
            this.Imie.Location = new System.Drawing.Point(607, 193);
            this.Imie.MaximumSize = new System.Drawing.Size(329, 30);
            this.Imie.MinimumSize = new System.Drawing.Size(329, 30);
            this.Imie.Name = "Imie";
            this.Imie.Size = new System.Drawing.Size(329, 30);
            this.Imie.TabIndex = 12;
            this.Imie.TextChanged += new System.EventHandler(this.Imie_TextChanged);
            // 
            // Nazwisko
            // 
            this.Nazwisko.Location = new System.Drawing.Point(607, 253);
            this.Nazwisko.MaximumSize = new System.Drawing.Size(329, 30);
            this.Nazwisko.MinimumSize = new System.Drawing.Size(329, 30);
            this.Nazwisko.Name = "Nazwisko";
            this.Nazwisko.Size = new System.Drawing.Size(329, 30);
            this.Nazwisko.TabIndex = 13;
            this.Nazwisko.TextChanged += new System.EventHandler(this.Nazwisko_TextChanged);
            // 
            // Wiek
            // 
            this.Wiek.Location = new System.Drawing.Point(607, 313);
            this.Wiek.MinimumSize = new System.Drawing.Size(329, 30);
            this.Wiek.Name = "Wiek";
            this.Wiek.Size = new System.Drawing.Size(329, 30);
            this.Wiek.TabIndex = 15;
            this.Wiek.TextChanged += new System.EventHandler(this.Wiek_TextChanged);
            // 
            // Plec
            // 
            this.Plec.FormattingEnabled = true;
            this.Plec.Items.AddRange(new object[] {
            "Męszczyzna",
            "Kobieta"});
            this.Plec.Location = new System.Drawing.Point(607, 373);
            this.Plec.MaximumSize = new System.Drawing.Size(329, 45);
            this.Plec.MinimumSize = new System.Drawing.Size(329, 45);
            this.Plec.Name = "Plec";
            this.Plec.Size = new System.Drawing.Size(329, 38);
            this.Plec.TabIndex = 17;
            this.Plec.SelectedIndexChanged += new System.EventHandler(this.Plec_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(-1, 813);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1500, 53);
            this.panel2.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(32, 12);
            this.label2.MaximumSize = new System.Drawing.Size(0, 16);
            this.label2.MinimumSize = new System.Drawing.Size(0, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "estetika © 2024   |    realizacja: MM studio";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.LogoGora);
            this.panel1.Location = new System.Drawing.Point(-1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1500, 156);
            this.panel1.TabIndex = 19;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(45, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 40);
            this.button2.TabIndex = 16;
            this.button2.Text = "Główna";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.Control;
            this.button6.Location = new System.Drawing.Point(962, 43);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(145, 40);
            this.button6.TabIndex = 12;
            this.button6.Text = "Kontakt";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Control;
            this.button5.Location = new System.Drawing.Point(765, 43);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(145, 40);
            this.button5.TabIndex = 11;
            this.button5.Text = "Cennik";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.Location = new System.Drawing.Point(557, 43);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(145, 40);
            this.button4.TabIndex = 10;
            this.button4.Text = "Dlaczego my?";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(397, 43);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 40);
            this.button3.TabIndex = 9;
            this.button3.Text = "O nas";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // LogoGora
            // 
            this.LogoGora.Image = global::DentalClinic.Properties.Resources.estetika_dental_clinic_favicon_color;
            this.LogoGora.InitialImage = null;
            this.LogoGora.Location = new System.Drawing.Point(1298, 23);
            this.LogoGora.Name = "LogoGora";
            this.LogoGora.Size = new System.Drawing.Size(182, 119);
            this.LogoGora.TabIndex = 3;
            this.LogoGora.TabStop = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.Control;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button7.ForeColor = System.Drawing.Color.DimGray;
            this.button7.Location = new System.Drawing.Point(1360, -3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(137, 26);
            this.button7.TabIndex = 20;
            this.button7.Text = "Zamknij";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1491, 859);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Plec);
            this.Controls.Add(this.Wiek);
            this.Controls.Add(this.Nazwisko);
            this.Controls.Add(this.Imie);
            this.Controls.Add(this.PhoneNum);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Zaloguj);
            this.Controls.Add(this.Wroc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoGora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.Button Zaloguj;
        private System.Windows.Forms.Button Wroc;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox PhoneNum;
        private System.Windows.Forms.TextBox Imie;
        private System.Windows.Forms.TextBox Nazwisko;
        private System.Windows.Forms.TextBox Wiek;
        private System.Windows.Forms.CheckedListBox Plec;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox LogoGora;
        private System.Windows.Forms.Button button7;
    }
}