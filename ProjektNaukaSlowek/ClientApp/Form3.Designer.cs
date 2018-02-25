namespace ClientApp
{
    partial class Form3
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
            this.ZalogujSie = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Login2 = new System.Windows.Forms.TextBox();
            this.Haslo2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Wroc
            // 
            this.Wroc.Location = new System.Drawing.Point(48, 260);
            this.Wroc.Name = "Wroc";
            this.Wroc.Size = new System.Drawing.Size(102, 50);
            this.Wroc.TabIndex = 0;
            this.Wroc.Text = "Wróć";
            this.Wroc.UseVisualStyleBackColor = true;
            this.Wroc.Click += new System.EventHandler(this.Wroc_Click);
            // 
            // ZalogujSie
            // 
            this.ZalogujSie.Location = new System.Drawing.Point(181, 260);
            this.ZalogujSie.Name = "ZalogujSie";
            this.ZalogujSie.Size = new System.Drawing.Size(101, 49);
            this.ZalogujSie.TabIndex = 1;
            this.ZalogujSie.Text = "Zaloguj się";
            this.ZalogujSie.UseVisualStyleBackColor = true;
            this.ZalogujSie.Click += new System.EventHandler(this.ZalogujSie_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Haslo";
            // 
            // Login2
            // 
            this.Login2.Location = new System.Drawing.Point(181, 60);
            this.Login2.Name = "Login2";
            this.Login2.Size = new System.Drawing.Size(100, 22);
            this.Login2.TabIndex = 4;
            // 
            // Haslo2
            // 
            this.Haslo2.Location = new System.Drawing.Point(181, 134);
            this.Haslo2.Name = "Haslo2";
            this.Haslo2.Size = new System.Drawing.Size(100, 22);
            this.Haslo2.TabIndex = 5;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 348);
            this.Controls.Add(this.Haslo2);
            this.Controls.Add(this.Login2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ZalogujSie);
            this.Controls.Add(this.Wroc);
            this.Name = "Form3";
            this.Text = "Form3";
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
    }
}