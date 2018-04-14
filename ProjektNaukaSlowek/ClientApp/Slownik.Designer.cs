namespace ClientApp
{
    partial class Slownik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Slownik));
            this.lsbxSlownik = new System.Windows.Forms.ListBox();
            this.txbWyszukjaSlowo = new System.Windows.Forms.TextBox();
            this.txbxWyszukajSlowo = new System.Windows.Forms.RichTextBox();
            this.btnWroc = new System.Windows.Forms.Button();
            this.btnSzukajSlowo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsbxSlownik
            // 
            this.lsbxSlownik.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lsbxSlownik.FormattingEnabled = true;
            this.lsbxSlownik.ItemHeight = 29;
            this.lsbxSlownik.Location = new System.Drawing.Point(608, 289);
            this.lsbxSlownik.Name = "lsbxSlownik";
            this.lsbxSlownik.Size = new System.Drawing.Size(864, 410);
            this.lsbxSlownik.TabIndex = 0;
            // 
            // txbWyszukjaSlowo
            // 
            this.txbWyszukjaSlowo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbWyszukjaSlowo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txbWyszukjaSlowo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbWyszukjaSlowo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txbWyszukjaSlowo.Enabled = false;
            this.txbWyszukjaSlowo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txbWyszukjaSlowo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txbWyszukjaSlowo.Location = new System.Drawing.Point(599, 120);
            this.txbWyszukjaSlowo.Margin = new System.Windows.Forms.Padding(4);
            this.txbWyszukjaSlowo.Multiline = true;
            this.txbWyszukjaSlowo.Name = "txbWyszukjaSlowo";
            this.txbWyszukjaSlowo.ReadOnly = true;
            this.txbWyszukjaSlowo.Size = new System.Drawing.Size(279, 43);
            this.txbWyszukjaSlowo.TabIndex = 23;
            this.txbWyszukjaSlowo.Text = "Wyszukaj słowo:";
            // 
            // txbxWyszukajSlowo
            // 
            this.txbxWyszukajSlowo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txbxWyszukajSlowo.Location = new System.Drawing.Point(1091, 124);
            this.txbxWyszukajSlowo.Name = "txbxWyszukajSlowo";
            this.txbxWyszukajSlowo.Size = new System.Drawing.Size(285, 57);
            this.txbxWyszukajSlowo.TabIndex = 24;
            this.txbxWyszukajSlowo.Text = "";
            // 
            // btnWroc
            // 
            this.btnWroc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnWroc.BackColor = System.Drawing.SystemColors.Info;
            this.btnWroc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWroc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWroc.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnWroc.Location = new System.Drawing.Point(762, 769);
            this.btnWroc.Margin = new System.Windows.Forms.Padding(4);
            this.btnWroc.Name = "btnWroc";
            this.btnWroc.Size = new System.Drawing.Size(340, 76);
            this.btnWroc.TabIndex = 25;
            this.btnWroc.Text = "Wróć";
            this.btnWroc.UseVisualStyleBackColor = false;
            // 
            // btnSzukajSlowo
            // 
            this.btnSzukajSlowo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSzukajSlowo.BackColor = System.Drawing.SystemColors.Info;
            this.btnSzukajSlowo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSzukajSlowo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSzukajSlowo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSzukajSlowo.Location = new System.Drawing.Point(823, 186);
            this.btnSzukajSlowo.Margin = new System.Windows.Forms.Padding(4);
            this.btnSzukajSlowo.Name = "btnSzukajSlowo";
            this.btnSzukajSlowo.Size = new System.Drawing.Size(234, 64);
            this.btnSzukajSlowo.TabIndex = 26;
            this.btnSzukajSlowo.Text = "Szukaj";
            this.btnSzukajSlowo.UseVisualStyleBackColor = false;
            // 
            // Slownik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1814, 999);
            this.Controls.Add(this.btnSzukajSlowo);
            this.Controls.Add(this.btnWroc);
            this.Controls.Add(this.txbxWyszukajSlowo);
            this.Controls.Add(this.txbWyszukjaSlowo);
            this.Controls.Add(this.lsbxSlownik);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Slownik";
            this.Text = "Slownik";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsbxSlownik;
        private System.Windows.Forms.TextBox txbWyszukjaSlowo;
        private System.Windows.Forms.RichTextBox txbxWyszukajSlowo;
        private System.Windows.Forms.Button btnWroc;
        private System.Windows.Forms.Button btnSzukajSlowo;
    }
}