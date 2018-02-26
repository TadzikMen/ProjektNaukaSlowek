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
			this.Zarejestruj.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Zarejestruj.Location = new System.Drawing.Point(164, 327);
			this.Zarejestruj.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Zarejestruj.Name = "Zarejestruj";
			this.Zarejestruj.Size = new System.Drawing.Size(76, 44);
			this.Zarejestruj.TabIndex = 0;
			this.Zarejestruj.Text = "Zarejestruj";
			this.Zarejestruj.UseVisualStyleBackColor = true;
			this.Zarejestruj.Click += new System.EventHandler(this.Zarejestruj_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(38, 73);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(36, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Login:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(38, 116);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Imię:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(38, 166);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Nazwisko:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(38, 209);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(35, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "Email:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(40, 258);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(39, 13);
			this.label5.TabIndex = 5;
			this.label5.Text = "Hasło:";
			// 
			// Login
			// 
			this.Login.Location = new System.Drawing.Point(166, 69);
			this.Login.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Login.Name = "Login";
			this.Login.Size = new System.Drawing.Size(76, 20);
			this.Login.TabIndex = 6;
			// 
			// Imie
			// 
			this.Imie.Location = new System.Drawing.Point(166, 111);
			this.Imie.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Imie.Name = "Imie";
			this.Imie.Size = new System.Drawing.Size(76, 20);
			this.Imie.TabIndex = 7;
			// 
			// Nazwisko
			// 
			this.Nazwisko.Location = new System.Drawing.Point(166, 166);
			this.Nazwisko.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Nazwisko.Name = "Nazwisko";
			this.Nazwisko.Size = new System.Drawing.Size(76, 20);
			this.Nazwisko.TabIndex = 8;
			// 
			// Email
			// 
			this.Email.Location = new System.Drawing.Point(166, 209);
			this.Email.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Email.Name = "Email";
			this.Email.Size = new System.Drawing.Size(76, 20);
			this.Email.TabIndex = 9;
			// 
			// Haslo
			// 
			this.Haslo.Location = new System.Drawing.Point(166, 258);
			this.Haslo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Haslo.Name = "Haslo";
			this.Haslo.Size = new System.Drawing.Size(76, 20);
			this.Haslo.TabIndex = 10;
			this.Haslo.UseSystemPasswordChar = true;
			// 
			// Wróć
			// 
			this.Wróć.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Wróć.Location = new System.Drawing.Point(40, 327);
			this.Wróć.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Wróć.Name = "Wróć";
			this.Wróć.Size = new System.Drawing.Size(76, 44);
			this.Wróć.TabIndex = 11;
			this.Wróć.Text = "Wróć";
			this.Wróć.UseVisualStyleBackColor = true;
			this.Wróć.Click += new System.EventHandler(this.Wróć_Click);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(318, 418);
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
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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