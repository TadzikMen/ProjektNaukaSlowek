namespace ClientApp
{
    partial class WeryfikacjaKodu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeryfikacjaKodu));
            this.label1 = new System.Windows.Forms.Label();
            this.KodWeryfikacyjny = new System.Windows.Forms.TextBox();
            this.Wroc = new System.Windows.Forms.Button();
            this.ZmienHaslo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.NoweHaslo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(674, 398);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kod weryfikacyjny:";
            // 
            // KodWeryfikacyjny
            // 
            this.KodWeryfikacyjny.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KodWeryfikacyjny.Location = new System.Drawing.Point(1135, 398);
            this.KodWeryfikacyjny.Name = "KodWeryfikacyjny";
            this.KodWeryfikacyjny.Size = new System.Drawing.Size(138, 36);
            this.KodWeryfikacyjny.TabIndex = 1;
            // 
            // Wroc
            // 
            this.Wroc.BackColor = System.Drawing.SystemColors.Info;
            this.Wroc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Wroc.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Wroc.Location = new System.Drawing.Point(633, 614);
            this.Wroc.Name = "Wroc";
            this.Wroc.Size = new System.Drawing.Size(197, 91);
            this.Wroc.TabIndex = 2;
            this.Wroc.Text = "Wróć";
            this.Wroc.UseVisualStyleBackColor = false;
            this.Wroc.Click += new System.EventHandler(this.Wroc_Click);
            // 
            // ZmienHaslo
            // 
            this.ZmienHaslo.BackColor = System.Drawing.SystemColors.Info;
            this.ZmienHaslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ZmienHaslo.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.ZmienHaslo.Location = new System.Drawing.Point(1115, 614);
            this.ZmienHaslo.Name = "ZmienHaslo";
            this.ZmienHaslo.Size = new System.Drawing.Size(197, 91);
            this.ZmienHaslo.TabIndex = 3;
            this.ZmienHaslo.Text = "Zmień hasło";
            this.ZmienHaslo.UseVisualStyleBackColor = false;
            this.ZmienHaslo.Click += new System.EventHandler(this.ZmienHaslo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(674, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 39);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nowe hasło:";
            // 
            // NoweHaslo
            // 
            this.NoweHaslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NoweHaslo.Location = new System.Drawing.Point(1135, 289);
            this.NoweHaslo.Name = "NoweHaslo";
            this.NoweHaslo.Size = new System.Drawing.Size(138, 36);
            this.NoweHaslo.TabIndex = 5;
            // 
            // WeryfikacjaKodu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1537, 828);
            this.Controls.Add(this.NoweHaslo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ZmienHaslo);
            this.Controls.Add(this.Wroc);
            this.Controls.Add(this.KodWeryfikacyjny);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "WeryfikacjaKodu";
            this.Text = "Weryfikacja kodu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox KodWeryfikacyjny;
        private System.Windows.Forms.Button Wroc;
        private System.Windows.Forms.Button ZmienHaslo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NoweHaslo;
    }
}