namespace DentalClinic
{
    partial class LogowanieUz
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
            this.Wroc = new System.Windows.Forms.Button();
            this.Zaloguj = new System.Windows.Forms.Button();
            this.Register = new System.Windows.Forms.LinkLabel();
            this.Login = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Wroc
            // 
            this.Wroc.Location = new System.Drawing.Point(594, 525);
            this.Wroc.Name = "Wroc";
            this.Wroc.Size = new System.Drawing.Size(109, 30);
            this.Wroc.TabIndex = 0;
            this.Wroc.Text = "Wróć";
            this.Wroc.UseVisualStyleBackColor = true;
            this.Wroc.Click += new System.EventHandler(this.Wroc_Click);
            // 
            // Zaloguj
            // 
            this.Zaloguj.Location = new System.Drawing.Point(814, 525);
            this.Zaloguj.Name = "Zaloguj";
            this.Zaloguj.Size = new System.Drawing.Size(109, 30);
            this.Zaloguj.TabIndex = 1;
            this.Zaloguj.Text = "Zaloguj";
            this.Zaloguj.UseVisualStyleBackColor = true;
            this.Zaloguj.Click += new System.EventHandler(this.Zaloguj_Click);
            // 
            // Register
            // 
            this.Register.AutoSize = true;
            this.Register.Location = new System.Drawing.Point(836, 572);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(83, 16);
            this.Register.TabIndex = 2;
            this.Register.TabStop = true;
            this.Register.Text = "Zarejstruj się";
            this.Register.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Register_LinkClicked);
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(594, 363);
            this.Login.MinimumSize = new System.Drawing.Size(329, 40);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(329, 22);
            this.Login.TabIndex = 3;
            this.Login.TextChanged += new System.EventHandler(this.Login_TextChanged);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(594, 426);
            this.Password.MinimumSize = new System.Drawing.Size(329, 40);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(329, 22);
            this.Password.TabIndex = 4;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(-1, 813);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1500, 53);
            this.panel2.TabIndex = 5;
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
            // LogowanieUz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1491, 859);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.Zaloguj);
            this.Controls.Add(this.Wroc);
            this.Name = "LogowanieUz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogowanieUz";
            this.Load += new System.EventHandler(this.LogowanieUz_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Wroc;
        private System.Windows.Forms.Button Zaloguj;
        private System.Windows.Forms.LinkLabel Register;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
    }
}