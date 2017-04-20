namespace MeterShopScan.Controls
{
	partial class Activity
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.messageLabel = new System.Windows.Forms.Label();
			this.animatedPicture1 = new MeterShopScan.Controls.AnimatedPicture();
			this.SuspendLayout();
			// 
			// messageLabel
			// 
			this.messageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.messageLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(222)))), ((int)(((byte)(239)))));
			this.messageLabel.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
			this.messageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(57)))), ((int)(((byte)(156)))));
			this.messageLabel.Location = new System.Drawing.Point(0, 60);
			this.messageLabel.Name = "messageLabel";
			this.messageLabel.Size = new System.Drawing.Size(250, 69);
			this.messageLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// animatedPicture1
			// 
			this.animatedPicture1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(222)))), ((int)(((byte)(239)))));
			this.animatedPicture1.Location = new System.Drawing.Point(94, 3);
			this.animatedPicture1.Name = "animatedPicture1";
			this.animatedPicture1.Size = new System.Drawing.Size(50, 50);
			this.animatedPicture1.TabIndex = 5;
			// 
			// Activity
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.Color.Maroon;
			this.Controls.Add(this.animatedPicture1);
			this.Controls.Add(this.messageLabel);
			this.Name = "Activity";
			this.Size = new System.Drawing.Size(250, 130);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label messageLabel;
		private AnimatedPicture animatedPicture1;
	}
}
