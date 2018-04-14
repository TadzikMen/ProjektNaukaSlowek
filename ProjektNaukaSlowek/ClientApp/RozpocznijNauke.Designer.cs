namespace ClientApp
{
    partial class RozpocznijNauke
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RozpocznijNauke));
            this.label1 = new System.Windows.Forms.Label();
            this.btnWroc = new System.Windows.Forms.Button();
            this.cmBxWyborJezyka = new System.Windows.Forms.ComboBox();
            this.cmBxWyborPoziomu = new System.Windows.Forms.ComboBox();
            this.cmBxFormaNauki = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRozpocznij = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(190, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wybierz język:";
            // 
            // btnWroc
            // 
            this.btnWroc.BackColor = System.Drawing.SystemColors.Info;
            this.btnWroc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWroc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWroc.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnWroc.Location = new System.Drawing.Point(329, 535);
            this.btnWroc.Margin = new System.Windows.Forms.Padding(2);
            this.btnWroc.Name = "btnWroc";
            this.btnWroc.Size = new System.Drawing.Size(287, 56);
            this.btnWroc.TabIndex = 1;
            this.btnWroc.Text = "Wróć";
            this.btnWroc.UseVisualStyleBackColor = false;
            this.btnWroc.Click += new System.EventHandler(this.btnWroc_Click);
            // 
            // cmBxWyborJezyka
            // 
            this.cmBxWyborJezyka.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmBxWyborJezyka.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmBxWyborJezyka.FormattingEnabled = true;
            this.cmBxWyborJezyka.Location = new System.Drawing.Point(810, 233);
            this.cmBxWyborJezyka.Margin = new System.Windows.Forms.Padding(2);
            this.cmBxWyborJezyka.Name = "cmBxWyborJezyka";
            this.cmBxWyborJezyka.Size = new System.Drawing.Size(260, 33);
            this.cmBxWyborJezyka.TabIndex = 4;
            // 
            // cmBxWyborPoziomu
            // 
            this.cmBxWyborPoziomu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmBxWyborPoziomu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmBxWyborPoziomu.FormattingEnabled = true;
            this.cmBxWyborPoziomu.Location = new System.Drawing.Point(810, 308);
            this.cmBxWyborPoziomu.Margin = new System.Windows.Forms.Padding(2);
            this.cmBxWyborPoziomu.Name = "cmBxWyborPoziomu";
            this.cmBxWyborPoziomu.Size = new System.Drawing.Size(260, 33);
            this.cmBxWyborPoziomu.TabIndex = 5;
            // 
            // cmBxFormaNauki
            // 
            this.cmBxFormaNauki.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmBxFormaNauki.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmBxFormaNauki.FormattingEnabled = true;
            this.cmBxFormaNauki.Location = new System.Drawing.Point(810, 383);
            this.cmBxFormaNauki.Margin = new System.Windows.Forms.Padding(2);
            this.cmBxFormaNauki.Name = "cmBxFormaNauki";
            this.cmBxFormaNauki.Size = new System.Drawing.Size(260, 33);
            this.cmBxFormaNauki.TabIndex = 6;
            this.cmBxFormaNauki.SelectedIndexChanged += new System.EventHandler(this.cmBxFormaNauki_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(502, 308);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Wybierz poziom:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(502, 379);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(268, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "Wybierz formę nauki:";
            // 
            // btnRozpocznij
            // 
            this.btnRozpocznij.BackColor = System.Drawing.SystemColors.Info;
            this.btnRozpocznij.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRozpocznij.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRozpocznij.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnRozpocznij.Location = new System.Drawing.Point(889, 535);
            this.btnRozpocznij.Margin = new System.Windows.Forms.Padding(2);
            this.btnRozpocznij.Name = "btnRozpocznij";
            this.btnRozpocznij.Size = new System.Drawing.Size(287, 56);
            this.btnRozpocznij.TabIndex = 9;
            this.btnRozpocznij.Text = "Rozpocznij naukę";
            this.btnRozpocznij.UseVisualStyleBackColor = false;
            this.btnRozpocznij.Click += new System.EventHandler(this.btnRozpocznij_Click);
            // 
            // RozpocznijNauke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1090, 609);
            this.Controls.Add(this.btnRozpocznij);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmBxFormaNauki);
            this.Controls.Add(this.cmBxWyborPoziomu);
            this.Controls.Add(this.cmBxWyborJezyka);
            this.Controls.Add(this.btnWroc);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "RozpocznijNauke";
            this.Text = "RozpocznijNauke";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RozpocznijNauke_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnWroc;
        private System.Windows.Forms.ComboBox cmBxWyborJezyka;
        private System.Windows.Forms.ComboBox cmBxWyborPoziomu;
        private System.Windows.Forms.ComboBox cmBxFormaNauki;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRozpocznij;
    }
}