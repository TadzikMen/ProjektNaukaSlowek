namespace ClientApp
{
	partial class Fiszki
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.tbxNrPoziomu = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.btnTlumacz = new System.Windows.Forms.Button();
			this.btnWroc = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
			this.textBox1.Enabled = false;
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.textBox1.Location = new System.Drawing.Point(34, 168);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(303, 29);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "Wpisz słówko (na przykład \"Dzień Dobry\")";
			// 
			// tbxNrPoziomu
			// 
			this.tbxNrPoziomu.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.tbxNrPoziomu.Enabled = false;
			this.tbxNrPoziomu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.tbxNrPoziomu.Location = new System.Drawing.Point(211, 12);
			this.tbxNrPoziomu.Multiline = true;
			this.tbxNrPoziomu.Name = "tbxNrPoziomu";
			this.tbxNrPoziomu.ReadOnly = true;
			this.tbxNrPoziomu.Size = new System.Drawing.Size(250, 83);
			this.tbxNrPoziomu.TabIndex = 1;
			// 
			// textBox2
			// 
			this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.textBox2.Location = new System.Drawing.Point(34, 253);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(230, 26);
			this.textBox2.TabIndex = 2;
			// 
			// textBox3
			// 
			this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.textBox3.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.textBox3.Location = new System.Drawing.Point(368, 253);
			this.textBox3.Multiline = true;
			this.textBox3.Name = "textBox3";
			this.textBox3.ReadOnly = true;
			this.textBox3.Size = new System.Drawing.Size(230, 26);
			this.textBox3.TabIndex = 3;
			// 
			// textBox4
			// 
			this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox4.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.textBox4.Enabled = false;
			this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.textBox4.Location = new System.Drawing.Point(34, 227);
			this.textBox4.Multiline = true;
			this.textBox4.Name = "textBox4";
			this.textBox4.ReadOnly = true;
			this.textBox4.Size = new System.Drawing.Size(108, 20);
			this.textBox4.TabIndex = 4;
			this.textBox4.Text = "Słówko po polsku:";
			// 
			// textBox5
			// 
			this.textBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox5.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.textBox5.Enabled = false;
			this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.textBox5.Location = new System.Drawing.Point(368, 227);
			this.textBox5.Multiline = true;
			this.textBox5.Name = "textBox5";
			this.textBox5.ReadOnly = true;
			this.textBox5.Size = new System.Drawing.Size(78, 20);
			this.textBox5.TabIndex = 5;
			this.textBox5.Text = "Tłumaczenie:";
			// 
			// btnTlumacz
			// 
			this.btnTlumacz.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnTlumacz.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnTlumacz.Location = new System.Drawing.Point(270, 245);
			this.btnTlumacz.Name = "btnTlumacz";
			this.btnTlumacz.Size = new System.Drawing.Size(92, 42);
			this.btnTlumacz.TabIndex = 6;
			this.btnTlumacz.Text = "Tłumacz";
			this.btnTlumacz.UseVisualStyleBackColor = true;
			this.btnTlumacz.Click += new System.EventHandler(this.btnTlumacz_Click);
			// 
			// btnWroc
			// 
			this.btnWroc.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnWroc.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnWroc.Location = new System.Drawing.Point(34, 413);
			this.btnWroc.Name = "btnWroc";
			this.btnWroc.Size = new System.Drawing.Size(94, 41);
			this.btnWroc.TabIndex = 7;
			this.btnWroc.Text = "Wróć";
			this.btnWroc.UseVisualStyleBackColor = true;
			this.btnWroc.Click += new System.EventHandler(this.btnWroc_Click);
			// 
			// Fiszki
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(636, 481);
			this.Controls.Add(this.btnWroc);
			this.Controls.Add(this.btnTlumacz);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.tbxNrPoziomu);
			this.Controls.Add(this.textBox1);
			this.Name = "Fiszki";
			this.Text = "Fiszki";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox tbxNrPoziomu;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Button btnTlumacz;
		private System.Windows.Forms.Button btnWroc;
	}
}