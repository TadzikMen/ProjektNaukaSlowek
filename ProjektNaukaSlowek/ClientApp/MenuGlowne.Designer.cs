namespace ClientApp
{
    partial class MenuGlowne
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuGlowne));
			this.Logowanie = new System.Windows.Forms.Button();
			this.Rejestracja = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Logowanie
			// 
			this.Logowanie.AutoSize = true;
			this.Logowanie.BackColor = System.Drawing.SystemColors.Info;
			this.Logowanie.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Logowanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Logowanie.ForeColor = System.Drawing.SystemColors.ActiveBorder;
			this.Logowanie.Location = new System.Drawing.Point(632, 297);
			this.Logowanie.Margin = new System.Windows.Forms.Padding(75, 81, 75, 81);
			this.Logowanie.MaximumSize = new System.Drawing.Size(450, 488);
			this.Logowanie.MinimumSize = new System.Drawing.Size(75, 81);
			this.Logowanie.Name = "Logowanie";
			this.Logowanie.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
			this.Logowanie.Size = new System.Drawing.Size(354, 113);
			this.Logowanie.TabIndex = 0;
			this.Logowanie.Text = "Logowanie";
			this.Logowanie.UseVisualStyleBackColor = false;
			this.Logowanie.Click += new System.EventHandler(this.Logowanie_Click);
			// 
			// Rejestracja
			// 
			this.Rejestracja.AutoSize = true;
			this.Rejestracja.BackColor = System.Drawing.SystemColors.Info;
			this.Rejestracja.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Rejestracja.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.Rejestracja.ForeColor = System.Drawing.SystemColors.ActiveBorder;
			this.Rejestracja.Location = new System.Drawing.Point(632, 442);
			this.Rejestracja.Margin = new System.Windows.Forms.Padding(15, 16, 15, 16);
			this.Rejestracja.Name = "Rejestracja";
			this.Rejestracja.Size = new System.Drawing.Size(354, 105);
			this.Rejestracja.TabIndex = 1;
			this.Rejestracja.Text = "Rejestracja";
			this.Rejestracja.UseVisualStyleBackColor = false;
			this.Rejestracja.Click += new System.EventHandler(this.Rejestracja_Click);
			// 
			// MenuGlowne
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(1028, 609);
			this.Controls.Add(this.Rejestracja);
			this.Controls.Add(this.Logowanie);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.MaximizeBox = false;
			this.Name = "MenuGlowne";
			this.Text = "MenuGłówne";
			this.TransparencyKey = System.Drawing.Color.White;
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Rejestracja;
        private System.Windows.Forms.Button Logowanie;
    }
}

