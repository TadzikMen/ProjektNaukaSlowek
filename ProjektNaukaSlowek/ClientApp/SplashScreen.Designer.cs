namespace ClientApp
{
	partial class SplashScreen
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
			this.components = new System.ComponentModel.Container();
			this.pasekPostepu = new System.Windows.Forms.ProgressBar();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// pasekPostepu
			// 
			this.pasekPostepu.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pasekPostepu.Location = new System.Drawing.Point(131, 190);
			this.pasekPostepu.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
			this.pasekPostepu.Name = "pasekPostepu";
			this.pasekPostepu.Size = new System.Drawing.Size(479, 23);
			this.pasekPostepu.TabIndex = 0;
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 8;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// SplashScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(763, 464);
			this.Controls.Add(this.pasekPostepu);
			this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "SplashScreen";
			this.ShowInTaskbar = false;
			this.Text = "SplashScreen";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ProgressBar pasekPostepu;
		private System.Windows.Forms.Timer timer1;
	}
}