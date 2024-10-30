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
            this.SuspendLayout();
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(973, 578);
            this.Password.MinimumSize = new System.Drawing.Size(329, 30);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(329, 30);
            this.Password.TabIndex = 9;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(973, 458);
            this.Login.MinimumSize = new System.Drawing.Size(329, 30);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(329, 30);
            this.Login.TabIndex = 8;
            this.Login.TextChanged += new System.EventHandler(this.Login_TextChanged);
            // 
            // Zaloguj
            // 
            this.Zaloguj.Location = new System.Drawing.Point(1193, 678);
            this.Zaloguj.Name = "Zaloguj";
            this.Zaloguj.Size = new System.Drawing.Size(109, 30);
            this.Zaloguj.TabIndex = 6;
            this.Zaloguj.Text = "Zaloguj";
            this.Zaloguj.UseVisualStyleBackColor = true;
            this.Zaloguj.Click += new System.EventHandler(this.Zaloguj_Click);
            // 
            // Wroc
            // 
            this.Wroc.Location = new System.Drawing.Point(973, 678);
            this.Wroc.Name = "Wroc";
            this.Wroc.Size = new System.Drawing.Size(109, 30);
            this.Wroc.TabIndex = 5;
            this.Wroc.Text = "Wróć";
            this.Wroc.UseVisualStyleBackColor = true;
            this.Wroc.Click += new System.EventHandler(this.Wroc_Click);
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(973, 518);
            this.Email.MinimumSize = new System.Drawing.Size(329, 30);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(329, 30);
            this.Email.TabIndex = 10;
            this.Email.TextChanged += new System.EventHandler(this.Email_TextChanged);
            // 
            // PhoneNum
            // 
            this.PhoneNum.Location = new System.Drawing.Point(973, 398);
            this.PhoneNum.MinimumSize = new System.Drawing.Size(329, 30);
            this.PhoneNum.Name = "PhoneNum";
            this.PhoneNum.Size = new System.Drawing.Size(329, 30);
            this.PhoneNum.TabIndex = 11;
            this.PhoneNum.TextChanged += new System.EventHandler(this.PhoneNum_TextChanged);
            // 
            // Imie
            // 
            this.Imie.Location = new System.Drawing.Point(973, 148);
            this.Imie.MaximumSize = new System.Drawing.Size(329, 30);
            this.Imie.MinimumSize = new System.Drawing.Size(329, 30);
            this.Imie.Name = "Imie";
            this.Imie.Size = new System.Drawing.Size(329, 30);
            this.Imie.TabIndex = 12;
            this.Imie.TextChanged += new System.EventHandler(this.Imie_TextChanged);
            // 
            // Nazwisko
            // 
            this.Nazwisko.Location = new System.Drawing.Point(973, 208);
            this.Nazwisko.MaximumSize = new System.Drawing.Size(329, 30);
            this.Nazwisko.MinimumSize = new System.Drawing.Size(329, 30);
            this.Nazwisko.Name = "Nazwisko";
            this.Nazwisko.Size = new System.Drawing.Size(329, 30);
            this.Nazwisko.TabIndex = 13;
            this.Nazwisko.TextChanged += new System.EventHandler(this.Nazwisko_TextChanged);
            // 
            // Wiek
            // 
            this.Wiek.Location = new System.Drawing.Point(973, 268);
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
            this.Plec.Location = new System.Drawing.Point(973, 328);
            this.Plec.MaximumSize = new System.Drawing.Size(329, 45);
            this.Plec.MinimumSize = new System.Drawing.Size(329, 45);
            this.Plec.Name = "Plec";
            this.Plec.Size = new System.Drawing.Size(329, 38);
            this.Plec.TabIndex = 17;
            this.Plec.SelectedIndexChanged += new System.EventHandler(this.Plec_SelectedIndexChanged);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1491, 859);
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
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
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
    }
}