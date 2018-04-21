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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.pasekPostepu = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pasekPostepu
            // 
            this.pasekPostepu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pasekPostepu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pasekPostepu.ForeColor = System.Drawing.SystemColors.Info;
            this.pasekPostepu.Location = new System.Drawing.Point(196, 376);
            this.pasekPostepu.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.pasekPostepu.Name = "pasekPostepu";
            this.pasekPostepu.Size = new System.Drawing.Size(639, 38);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1017, 571);
            this.Controls.Add(this.pasekPostepu);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "SplashScreen";
            this.ShowInTaskbar = false;
            this.Text = "SplashScreen";
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ProgressBar pasekPostepu;
		private System.Windows.Forms.Timer timer1;
	}
}