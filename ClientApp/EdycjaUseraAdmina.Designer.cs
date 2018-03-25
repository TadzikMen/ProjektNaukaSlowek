namespace ClientApp
{
    partial class EdycjaUseraAdmina
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EdycjaUseraAdmina));
			this.btnWroc = new System.Windows.Forms.Button();
			this.btnZatwierdzZmiany = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txNoweHaslo = new System.Windows.Forms.TextBox();
			this.txStareHaslo = new System.Windows.Forms.TextBox();
			this.txbStaryEmail = new System.Windows.Forms.TextBox();
			this.txbNowyEmail = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnWroc
			// 
			this.btnWroc.BackColor = System.Drawing.SystemColors.Info;
			this.btnWroc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btnWroc.ForeColor = System.Drawing.SystemColors.ActiveBorder;
			this.btnWroc.Location = new System.Drawing.Point(526, 531);
			this.btnWroc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnWroc.Name = "btnWroc";
			this.btnWroc.Size = new System.Drawing.Size(208, 63);
			this.btnWroc.TabIndex = 2;
			this.btnWroc.Text = "Wróć";
			this.btnWroc.UseVisualStyleBackColor = false;
			this.btnWroc.Click += new System.EventHandler(this.btnWroc_Click);
			// 
			// btnZatwierdzZmiany
			// 
			this.btnZatwierdzZmiany.BackColor = System.Drawing.SystemColors.Info;
			this.btnZatwierdzZmiany.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btnZatwierdzZmiany.ForeColor = System.Drawing.SystemColors.ActiveBorder;
			this.btnZatwierdzZmiany.Location = new System.Drawing.Point(897, 529);
			this.btnZatwierdzZmiany.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnZatwierdzZmiany.Name = "btnZatwierdzZmiany";
			this.btnZatwierdzZmiany.Size = new System.Drawing.Size(212, 65);
			this.btnZatwierdzZmiany.TabIndex = 3;
			this.btnZatwierdzZmiany.Text = "Zatwierdź zmiany";
			this.btnZatwierdzZmiany.UseVisualStyleBackColor = false;
			this.btnZatwierdzZmiany.Click += new System.EventHandler(this.btnZatwierdzZmiany_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label1.Location = new System.Drawing.Point(555, 212);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(231, 31);
			this.label1.TabIndex = 4;
			this.label1.Text = "Podaj stare hasło:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label2.Location = new System.Drawing.Point(556, 337);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(229, 31);
			this.label2.TabIndex = 5;
			this.label2.Text = "Podaj stary email:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label3.Location = new System.Drawing.Point(556, 274);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(235, 31);
			this.label3.TabIndex = 6;
			this.label3.Text = "Podaj nowe hasło:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label4.Location = new System.Drawing.Point(551, 407);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(233, 31);
			this.label4.TabIndex = 7;
			this.label4.Text = "Podaj nowy email:";
			// 
			// txNoweHaslo
			// 
			this.txNoweHaslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.txNoweHaslo.Location = new System.Drawing.Point(866, 212);
			this.txNoweHaslo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txNoweHaslo.Name = "txNoweHaslo";
			this.txNoweHaslo.Size = new System.Drawing.Size(162, 30);
			this.txNoweHaslo.TabIndex = 8;
			// 
			// txStareHaslo
			// 
			this.txStareHaslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.txStareHaslo.Location = new System.Drawing.Point(866, 274);
			this.txStareHaslo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txStareHaslo.Name = "txStareHaslo";
			this.txStareHaslo.Size = new System.Drawing.Size(162, 30);
			this.txStareHaslo.TabIndex = 9;
			// 
			// txbStaryEmail
			// 
			this.txbStaryEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.txbStaryEmail.Location = new System.Drawing.Point(866, 337);
			this.txbStaryEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txbStaryEmail.Name = "txbStaryEmail";
			this.txbStaryEmail.Size = new System.Drawing.Size(162, 30);
			this.txbStaryEmail.TabIndex = 10;
			// 
			// txbNowyEmail
			// 
			this.txbNowyEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.txbNowyEmail.Location = new System.Drawing.Point(866, 407);
			this.txbNowyEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txbNowyEmail.Name = "txbNowyEmail";
			this.txbNowyEmail.Size = new System.Drawing.Size(162, 30);
			this.txbNowyEmail.TabIndex = 11;
			// 
			// EdycjaUseraAdmina
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(1028, 609);
			this.Controls.Add(this.txbNowyEmail);
			this.Controls.Add(this.txbStaryEmail);
			this.Controls.Add(this.txStareHaslo);
			this.Controls.Add(this.txNoweHaslo);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnZatwierdzZmiany);
			this.Controls.Add(this.btnWroc);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.MaximizeBox = false;
			this.Name = "EdycjaUseraAdmina";
			this.Text = "EdycjaUseraAdmina";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWroc;
        private System.Windows.Forms.Button btnZatwierdzZmiany;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txNoweHaslo;
        private System.Windows.Forms.TextBox txStareHaslo;
        private System.Windows.Forms.TextBox txbStaryEmail;
        private System.Windows.Forms.TextBox txbNowyEmail;
    }
}