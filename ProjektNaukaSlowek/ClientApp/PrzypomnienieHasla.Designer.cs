namespace ClientApp
{
    partial class PrzypomnienieHasla
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrzypomnienieHasla));
			this.label3 = new System.Windows.Forms.Label();
			this.Wroc = new System.Windows.Forms.Button();
			this.WeryfikujKod = new System.Windows.Forms.Button();
			this.tbxEmail = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.PrzeslijKod = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.tbxKodWeryfikacyjny = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label3.Location = new System.Drawing.Point(470, 153);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(561, 31);
			this.label3.TabIndex = 3;
			this.label3.Text = "Podaj email wprowadzony podczas rejestracji";
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
			this.Wroc.Size = new System.Drawing.Size(145, 76);
			this.Wroc.TabIndex = 5;
			this.Wroc.Text = "Wróć";
			this.Wroc.UseVisualStyleBackColor = false;
			this.Wroc.Click += new System.EventHandler(this.Wroc_Click);
			// 
			// WeryfikujKod
			// 
			this.WeryfikujKod.BackColor = System.Drawing.SystemColors.Info;
			this.WeryfikujKod.Cursor = System.Windows.Forms.Cursors.Hand;
			this.WeryfikujKod.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.WeryfikujKod.ForeColor = System.Drawing.SystemColors.ActiveBorder;
			this.WeryfikujKod.Location = new System.Drawing.Point(836, 499);
			this.WeryfikujKod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.WeryfikujKod.Name = "WeryfikujKod";
			this.WeryfikujKod.Size = new System.Drawing.Size(145, 76);
			this.WeryfikujKod.TabIndex = 6;
			this.WeryfikujKod.Text = "Weryfikuj kod";
			this.WeryfikujKod.UseVisualStyleBackColor = false;
			this.WeryfikujKod.Click += new System.EventHandler(this.WeryfikujKod_Click);
			// 
			// tbxEmail
			// 
			this.tbxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.tbxEmail.Location = new System.Drawing.Point(801, 243);
			this.tbxEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.tbxEmail.Name = "tbxEmail";
			this.tbxEmail.Size = new System.Drawing.Size(268, 30);
			this.tbxEmail.TabIndex = 7;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label1.Location = new System.Drawing.Point(508, 240);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(89, 31);
			this.label1.TabIndex = 8;
			this.label1.Text = "Email:";
			// 
			// PrzeslijKod
			// 
			this.PrzeslijKod.BackColor = System.Drawing.SystemColors.Info;
			this.PrzeslijKod.Cursor = System.Windows.Forms.Cursors.Hand;
			this.PrzeslijKod.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.PrzeslijKod.ForeColor = System.Drawing.SystemColors.ActiveBorder;
			this.PrzeslijKod.Location = new System.Drawing.Point(832, 304);
			this.PrzeslijKod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.PrzeslijKod.Name = "PrzeslijKod";
			this.PrzeslijKod.Size = new System.Drawing.Size(149, 73);
			this.PrzeslijKod.TabIndex = 9;
			this.PrzeslijKod.Text = "Prześlij kod weryfikacyjny";
			this.PrzeslijKod.UseVisualStyleBackColor = false;
			this.PrzeslijKod.Click += new System.EventHandler(this.PrzeslijKod_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label2.Location = new System.Drawing.Point(512, 400);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(234, 31);
			this.label2.TabIndex = 10;
			this.label2.Text = "Kod weryfikujący: ";
			// 
			// tbxKodWeryfikacyjny
			// 
			this.tbxKodWeryfikacyjny.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.tbxKodWeryfikacyjny.Location = new System.Drawing.Point(801, 400);
			this.tbxKodWeryfikacyjny.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.tbxKodWeryfikacyjny.Name = "tbxKodWeryfikacyjny";
			this.tbxKodWeryfikacyjny.Size = new System.Drawing.Size(268, 30);
			this.tbxKodWeryfikacyjny.TabIndex = 11;
			// 
			// PrzypomnienieHasla
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(1028, 609);
			this.Controls.Add(this.tbxKodWeryfikacyjny);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.PrzeslijKod);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbxEmail);
			this.Controls.Add(this.WeryfikujKod);
			this.Controls.Add(this.Wroc);
			this.Controls.Add(this.label3);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "PrzypomnienieHasla";
			this.Text = "Przypomnienie hasła";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Wroc;
        private System.Windows.Forms.Button WeryfikujKod;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PrzeslijKod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxKodWeryfikacyjny;
    }
}