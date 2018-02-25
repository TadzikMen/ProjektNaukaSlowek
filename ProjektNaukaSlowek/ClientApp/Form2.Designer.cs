namespace ClientApp
{
    partial class Form2
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
            this.Zarejestruj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.TextBox();
            this.Imie = new System.Windows.Forms.TextBox();
            this.Nazwisko = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.Haslo = new System.Windows.Forms.TextBox();
            this.Wróć = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Zarejestruj
            // 
            this.Zarejestruj.Location = new System.Drawing.Point(219, 403);
            this.Zarejestruj.Name = "Zarejestruj";
            this.Zarejestruj.Size = new System.Drawing.Size(102, 43);
            this.Zarejestruj.TabIndex = 0;
            this.Zarejestruj.Text = "Zarejestruj";
            this.Zarejestruj.UseVisualStyleBackColor = true;
            this.Zarejestruj.Click += new System.EventHandler(this.Zarejestruj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Imię:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nazwisko:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Hasło:";
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(221, 85);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(100, 22);
            this.Login.TabIndex = 6;
            // 
            // Imie
            // 
            this.Imie.Location = new System.Drawing.Point(221, 137);
            this.Imie.Name = "Imie";
            this.Imie.Size = new System.Drawing.Size(100, 22);
            this.Imie.TabIndex = 7;
            // 
            // Nazwisko
            // 
            this.Nazwisko.Location = new System.Drawing.Point(221, 204);
            this.Nazwisko.Name = "Nazwisko";
            this.Nazwisko.Size = new System.Drawing.Size(100, 22);
            this.Nazwisko.TabIndex = 8;
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(221, 257);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(100, 22);
            this.Email.TabIndex = 9;
            // 
            // Haslo
            // 
            this.Haslo.Location = new System.Drawing.Point(221, 318);
            this.Haslo.Name = "Haslo";
            this.Haslo.Size = new System.Drawing.Size(100, 22);
            this.Haslo.TabIndex = 10;
            // 
            // Wróć
            // 
            this.Wróć.Location = new System.Drawing.Point(54, 403);
            this.Wróć.Name = "Wróć";
            this.Wróć.Size = new System.Drawing.Size(96, 43);
            this.Wróć.TabIndex = 11;
            this.Wróć.Text = "Wróć";
            this.Wróć.UseVisualStyleBackColor = true;
            this.Wróć.Click += new System.EventHandler(this.Wróć_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 515);
            this.Controls.Add(this.Wróć);
            this.Controls.Add(this.Haslo);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Nazwisko);
            this.Controls.Add(this.Imie);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Zarejestruj);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Zarejestruj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox Imie;
        private System.Windows.Forms.TextBox Nazwisko;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Haslo;
        private System.Windows.Forms.Button Wróć;
    }
}