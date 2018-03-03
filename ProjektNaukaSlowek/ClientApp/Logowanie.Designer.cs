namespace ClientApp
{
    partial class Logowanie
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Logowanie));
			this.Wroc = new System.Windows.Forms.Button();
			this.ZalogujSie = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.Login2 = new System.Windows.Forms.TextBox();
			this.Haslo2 = new System.Windows.Forms.TextBox();
			this.PrzypomnienieHasla = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();
			// 
			// Wroc
			// 
			this.Wroc.BackColor = System.Drawing.SystemColors.Info;
			this.Wroc.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Wroc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.Wroc.ForeColor = System.Drawing.SystemColors.ActiveBorder;
			this.Wroc.Location = new System.Drawing.Point(475, 499);
			this.Wroc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Wroc.Name = "Wroc";
			this.Wroc.Size = new System.Drawing.Size(144, 76);
			this.Wroc.TabIndex = 0;
			this.Wroc.Text = "Wróć";
			this.Wroc.UseVisualStyleBackColor = false;
			this.Wroc.Click += new System.EventHandler(this.Wroc_Click);
			// 
			// ZalogujSie
			// 
			this.ZalogujSie.BackColor = System.Drawing.SystemColors.Info;
			this.ZalogujSie.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ZalogujSie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.ZalogujSie.ForeColor = System.Drawing.SystemColors.ActiveBorder;
			this.ZalogujSie.Location = new System.Drawing.Point(836, 499);
			this.ZalogujSie.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ZalogujSie.Name = "ZalogujSie";
			this.ZalogujSie.Size = new System.Drawing.Size(144, 76);
			this.ZalogujSie.TabIndex = 1;
			this.ZalogujSie.Text = "Zaloguj się";
			this.ZalogujSie.UseVisualStyleBackColor = false;
			this.ZalogujSie.Click += new System.EventHandler(this.ZalogujSie_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label1.Location = new System.Drawing.Point(502, 230);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 31);
			this.label1.TabIndex = 2;
			this.label1.Text = "Login:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label2.Location = new System.Drawing.Point(506, 323);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(92, 31);
			this.label2.TabIndex = 3;
			this.label2.Text = "Haslo:";
			// 
			// Login2
			// 
			this.Login2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.Login2.Location = new System.Drawing.Point(776, 230);
			this.Login2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Login2.Name = "Login2";
			this.Login2.Size = new System.Drawing.Size(179, 30);
			this.Login2.TabIndex = 4;
			// 
			// Haslo2
			// 
			this.Haslo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.Haslo2.Location = new System.Drawing.Point(776, 323);
			this.Haslo2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Haslo2.Name = "Haslo2";
			this.Haslo2.Size = new System.Drawing.Size(179, 30);
			this.Haslo2.TabIndex = 5;
			this.Haslo2.UseSystemPasswordChar = true;
			// 
			// PrzypomnienieHasla
			// 
			this.PrzypomnienieHasla.AutoSize = true;
			this.PrzypomnienieHasla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.PrzypomnienieHasla.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.PrzypomnienieHasla.LinkColor = System.Drawing.Color.Blue;
			this.PrzypomnienieHasla.Location = new System.Drawing.Point(626, 420);
			this.PrzypomnienieHasla.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.PrzypomnienieHasla.Name = "PrzypomnienieHasla";
			this.PrzypomnienieHasla.Size = new System.Drawing.Size(187, 25);
			this.PrzypomnienieHasla.TabIndex = 6;
			this.PrzypomnienieHasla.TabStop = true;
			this.PrzypomnienieHasla.Text = "Zapomniałeś hasła?";
			this.PrzypomnienieHasla.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.PrzypomnienieHasla_LinkClicked);
			// 
			// Logowanie
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(1028, 605);
			this.Controls.Add(this.PrzypomnienieHasla);
			this.Controls.Add(this.Haslo2);
			this.Controls.Add(this.Login2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ZalogujSie);
			this.Controls.Add(this.Wroc);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "Logowanie";
			this.Text = "Logowanie";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Wroc;
        private System.Windows.Forms.Button ZalogujSie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Login2;
        private System.Windows.Forms.TextBox Haslo2;
        private System.Windows.Forms.LinkLabel PrzypomnienieHasla;
    }
}