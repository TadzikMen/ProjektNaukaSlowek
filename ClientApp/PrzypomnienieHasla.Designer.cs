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
            this.Email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PrzeslijKod = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.KodWeryfikacyjny = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(626, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(705, 39);
            this.label3.TabIndex = 3;
            this.label3.Text = "Podaj email wprowadzony podczas rejestracji";
            // 
            // Wroc
            // 
            this.Wroc.BackColor = System.Drawing.SystemColors.Info;
            this.Wroc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Wroc.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Wroc.Location = new System.Drawing.Point(633, 614);
            this.Wroc.Name = "Wroc";
            this.Wroc.Size = new System.Drawing.Size(193, 94);
            this.Wroc.TabIndex = 5;
            this.Wroc.Text = "Wróć";
            this.Wroc.UseVisualStyleBackColor = false;
            this.Wroc.Click += new System.EventHandler(this.Wroc_Click);
            // 
            // WeryfikujKod
            // 
            this.WeryfikujKod.BackColor = System.Drawing.SystemColors.Info;
            this.WeryfikujKod.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WeryfikujKod.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.WeryfikujKod.Location = new System.Drawing.Point(1115, 614);
            this.WeryfikujKod.Name = "WeryfikujKod";
            this.WeryfikujKod.Size = new System.Drawing.Size(193, 94);
            this.WeryfikujKod.TabIndex = 6;
            this.WeryfikujKod.Text = "Weryfikuj kod";
            this.WeryfikujKod.UseVisualStyleBackColor = false;
            this.WeryfikujKod.Click += new System.EventHandler(this.WeryfikujKod_Click);
            // 
            // Email
            // 
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Email.Location = new System.Drawing.Point(1068, 299);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(356, 36);
            this.Email.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(678, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 39);
            this.label1.TabIndex = 8;
            this.label1.Text = "Email:";
            // 
            // PrzeslijKod
            // 
            this.PrzeslijKod.BackColor = System.Drawing.SystemColors.Info;
            this.PrzeslijKod.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PrzeslijKod.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.PrzeslijKod.Location = new System.Drawing.Point(1109, 374);
            this.PrzeslijKod.Name = "PrzeslijKod";
            this.PrzeslijKod.Size = new System.Drawing.Size(199, 90);
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
            this.label2.Location = new System.Drawing.Point(682, 492);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 39);
            this.label2.TabIndex = 10;
            this.label2.Text = "Kod weryfikujący: ";
            // 
            // KodWeryfikacyjny
            // 
            this.KodWeryfikacyjny.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KodWeryfikacyjny.Location = new System.Drawing.Point(1068, 492);
            this.KodWeryfikacyjny.Name = "KodWeryfikacyjny";
            this.KodWeryfikacyjny.Size = new System.Drawing.Size(356, 36);
            this.KodWeryfikacyjny.TabIndex = 11;
            // 
            // PrzypomnienieHasla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1436, 763);
            this.Controls.Add(this.KodWeryfikacyjny);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PrzeslijKod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.WeryfikujKod);
            this.Controls.Add(this.Wroc);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PrzeslijKod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox KodWeryfikacyjny;
    }
}