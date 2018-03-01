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
            this.ZatwierdzDane = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            // ZatwierdzDane
            // 
            this.ZatwierdzDane.BackColor = System.Drawing.SystemColors.Info;
            this.ZatwierdzDane.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ZatwierdzDane.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.ZatwierdzDane.Location = new System.Drawing.Point(1115, 614);
            this.ZatwierdzDane.Name = "ZatwierdzDane";
            this.ZatwierdzDane.Size = new System.Drawing.Size(193, 94);
            this.ZatwierdzDane.TabIndex = 6;
            this.ZatwierdzDane.Text = "Zatwierdź Dane";
            this.ZatwierdzDane.UseVisualStyleBackColor = false;
            this.ZatwierdzDane.Click += new System.EventHandler(this.ZatwierdzDane_Click);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox3.Location = new System.Drawing.Point(1144, 397);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(129, 36);
            this.textBox3.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(674, 397);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 39);
            this.label1.TabIndex = 8;
            this.label1.Text = "Email:";
            // 
            // PrzypomnienieHasla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1391, 749);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.ZatwierdzDane);
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
        private System.Windows.Forms.Button ZatwierdzDane;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
    }
}