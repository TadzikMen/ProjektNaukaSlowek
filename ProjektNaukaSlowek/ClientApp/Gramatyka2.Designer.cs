﻿namespace ClientApp
{
    partial class Gramatyka2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gramatyka2));
            this.lsbxZadaniaGramatyka = new System.Windows.Forms.ListBox();
            this.btnWroc = new System.Windows.Forms.Button();
            this.btnSprawdz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsbxZadaniaGramatyka
            // 
            this.lsbxZadaniaGramatyka.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lsbxZadaniaGramatyka.FormattingEnabled = true;
            this.lsbxZadaniaGramatyka.ItemHeight = 29;
            this.lsbxZadaniaGramatyka.Location = new System.Drawing.Point(583, 135);
            this.lsbxZadaniaGramatyka.Name = "lsbxZadaniaGramatyka";
            this.lsbxZadaniaGramatyka.Size = new System.Drawing.Size(1097, 671);
            this.lsbxZadaniaGramatyka.TabIndex = 0;
            // 
            // btnWroc
            // 
            this.btnWroc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnWroc.BackColor = System.Drawing.SystemColors.Info;
            this.btnWroc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWroc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWroc.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnWroc.Location = new System.Drawing.Point(415, 850);
            this.btnWroc.Margin = new System.Windows.Forms.Padding(4);
            this.btnWroc.Name = "btnWroc";
            this.btnWroc.Size = new System.Drawing.Size(340, 76);
            this.btnWroc.TabIndex = 20;
            this.btnWroc.Text = "Wróć";
            this.btnWroc.UseVisualStyleBackColor = false;
            // 
            // btnSprawdz
            // 
            this.btnSprawdz.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSprawdz.BackColor = System.Drawing.SystemColors.Info;
            this.btnSprawdz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSprawdz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSprawdz.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSprawdz.Location = new System.Drawing.Point(1285, 850);
            this.btnSprawdz.Margin = new System.Windows.Forms.Padding(4);
            this.btnSprawdz.Name = "btnSprawdz";
            this.btnSprawdz.Size = new System.Drawing.Size(340, 76);
            this.btnSprawdz.TabIndex = 21;
            this.btnSprawdz.Text = "Sprawdź";
            this.btnSprawdz.UseVisualStyleBackColor = false;
            // 
            // Gramatyka2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1839, 1035);
            this.Controls.Add(this.btnSprawdz);
            this.Controls.Add(this.btnWroc);
            this.Controls.Add(this.lsbxZadaniaGramatyka);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Gramatyka2";
            this.Text = "Gramatyka2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lsbxZadaniaGramatyka;
        private System.Windows.Forms.Button btnWroc;
        private System.Windows.Forms.Button btnSprawdz;
    }
}