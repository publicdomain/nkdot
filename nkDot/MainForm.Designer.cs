
namespace nkDot
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.dotPictureBox = new System.Windows.Forms.PictureBox();
			this.dotTimer = new System.Windows.Forms.Timer(this.components);
			this.runTimer = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dotPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// dotPictureBox
			// 
			this.dotPictureBox.BackColor = System.Drawing.Color.White;
			this.dotPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dotPictureBox.Location = new System.Drawing.Point(0, 0);
			this.dotPictureBox.Name = "dotPictureBox";
			this.dotPictureBox.Size = new System.Drawing.Size(624, 442);
			this.dotPictureBox.TabIndex = 0;
			this.dotPictureBox.TabStop = false;
			this.dotPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.OnDotPictureBoxPaint);
			// 
			// dotTimer
			// 
			this.dotTimer.Interval = 250;
			this.dotTimer.Tick += new System.EventHandler(this.OnDotTimerTick);
			// 
			// runTimer
			// 
			this.runTimer.Tick += new System.EventHandler(this.OnRunTimerTick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(624, 442);
			this.Controls.Add(this.dotPictureBox);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "nkDot";
			this.Load += new System.EventHandler(this.OnMainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.dotPictureBox)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Timer runTimer;
		private System.Windows.Forms.Timer dotTimer;
		private System.Windows.Forms.PictureBox dotPictureBox;
	}
}
