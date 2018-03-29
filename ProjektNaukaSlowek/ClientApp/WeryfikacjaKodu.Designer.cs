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
			this.Wroc = new System.Windows.Forms.Button();
			this.ZmienHaslo = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.NoweHaslo = new System.Windows.Forms.TextBox();
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
			this.Wroc.Size = new System.Drawing.Size(148, 74);
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
			this.ZmienHaslo.Location = new System.Drawing.Point(836, 499);
			this.ZmienHaslo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ZmienHaslo.Name = "ZmienHaslo";
			this.ZmienHaslo.Size = new System.Drawing.Size(148, 74);
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
			this.label2.Location = new System.Drawing.Point(506, 235);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(164, 31);
			this.label2.TabIndex = 4;
			this.label2.Text = "Nowe hasło:";
			// 
			// NoweHaslo
			// 
			this.NoweHaslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.NoweHaslo.Location = new System.Drawing.Point(851, 235);
			this.NoweHaslo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.NoweHaslo.Name = "NoweHaslo";
			this.NoweHaslo.Size = new System.Drawing.Size(104, 30);
			this.NoweHaslo.TabIndex = 5;
			// 
			// WeryfikacjaKodu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(1028, 609);
			this.Controls.Add(this.NoweHaslo);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.ZmienHaslo);
			this.Controls.Add(this.Wroc);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.MaximizeBox = false;
			this.Name = "WeryfikacjaKodu";
			this.Text = "Weryfikacja kodu";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Wroc;
        private System.Windows.Forms.Button ZmienHaslo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NoweHaslo;
    }
}