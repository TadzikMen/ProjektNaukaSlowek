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
            this.Logowanie = new System.Windows.Forms.Button();
            this.Rejestracja = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Logowanie
            // 
            this.Logowanie.Location = new System.Drawing.Point(79, 52);
            this.Logowanie.Name = "Logowanie";
            this.Logowanie.Size = new System.Drawing.Size(126, 50);
            this.Logowanie.TabIndex = 0;
            this.Logowanie.Text = "Logowanie";
            this.Logowanie.UseVisualStyleBackColor = true;
            this.Logowanie.Click += new System.EventHandler(this.Logowanie_Click);
            // 
            // Rejestracja
            // 
            this.Rejestracja.Location = new System.Drawing.Point(79, 153);
            this.Rejestracja.Name = "Rejestracja";
            this.Rejestracja.Size = new System.Drawing.Size(126, 49);
            this.Rejestracja.TabIndex = 1;
            this.Rejestracja.Text = "Rejestracja";
            this.Rejestracja.UseVisualStyleBackColor = true;
            this.Rejestracja.Click += new System.EventHandler(this.Rejestracja_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.Rejestracja);
            this.Controls.Add(this.Logowanie);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Logowanie;
        private System.Windows.Forms.Button Rejestracja;
    }
}

