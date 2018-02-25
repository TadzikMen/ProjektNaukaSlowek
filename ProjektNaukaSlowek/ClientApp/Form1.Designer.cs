namespace ClientApp
{
    partial class Form1
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tbxHaslo = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.tbxLogin = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.btnZaloguj = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.tbxHaslo);
			this.groupBox1.Controls.Add(this.textBox3);
			this.groupBox1.Controls.Add(this.tbxLogin);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Location = new System.Drawing.Point(45, 38);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(281, 155);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Formularz";
			// 
			// tbxHaslo
			// 
			this.tbxHaslo.Location = new System.Drawing.Point(7, 120);
			this.tbxHaslo.Name = "tbxHaslo";
			this.tbxHaslo.Size = new System.Drawing.Size(268, 20);
			this.tbxHaslo.TabIndex = 3;
			this.tbxHaslo.UseSystemPasswordChar = true;
			// 
			// textBox3
			// 
			this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox3.Location = new System.Drawing.Point(7, 93);
			this.textBox3.Name = "textBox3";
			this.textBox3.ReadOnly = true;
			this.textBox3.Size = new System.Drawing.Size(35, 13);
			this.textBox3.TabIndex = 2;
			this.textBox3.Text = "Hasło:";
			// 
			// tbxLogin
			// 
			this.tbxLogin.Location = new System.Drawing.Point(7, 66);
			this.tbxLogin.Name = "tbxLogin";
			this.tbxLogin.Size = new System.Drawing.Size(268, 20);
			this.tbxLogin.TabIndex = 1;
			// 
			// textBox1
			// 
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Location = new System.Drawing.Point(7, 39);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(35, 13);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "Login:";
			// 
			// btnZaloguj
			// 
			this.btnZaloguj.Location = new System.Drawing.Point(45, 213);
			this.btnZaloguj.Name = "btnZaloguj";
			this.btnZaloguj.Size = new System.Drawing.Size(75, 23);
			this.btnZaloguj.TabIndex = 1;
			this.btnZaloguj.Text = "Zaloguj";
			this.btnZaloguj.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(379, 283);
			this.Controls.Add(this.btnZaloguj);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox tbxHaslo;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox tbxLogin;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button btnZaloguj;
	}
}

