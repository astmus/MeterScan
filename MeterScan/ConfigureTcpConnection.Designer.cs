namespace MeterScan
{
	partial class ConfigureTcpConnection
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
			this.label1 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.ipaddress = new System.Windows.Forms.Label();
			this.port = new System.Windows.Forms.Label();
			this.clear = new System.Windows.Forms.Button();
			this.close = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(57)))), ((int)(((byte)(156)))));
			this.label1.Location = new System.Drawing.Point(4, 4);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(311, 30);
			this.label1.Text = "Configure connection to server";
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
			this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(57)))), ((int)(((byte)(156)))));
			this.label11.Location = new System.Drawing.Point(4, 34);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(311, 52);
			this.label11.Text = "Now scan barcode with tcp data connect";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(57)))), ((int)(((byte)(156)))));
			this.label2.Location = new System.Drawing.Point(4, 96);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(134, 30);
			this.label2.Text = "IP address";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(57)))), ((int)(((byte)(156)))));
			this.label3.Location = new System.Drawing.Point(3, 126);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(135, 30);
			this.label3.Text = "Port number";
			// 
			// ipaddress
			// 
			this.ipaddress.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
			this.ipaddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(57)))), ((int)(((byte)(156)))));
			this.ipaddress.Location = new System.Drawing.Point(136, 96);
			this.ipaddress.Name = "ipaddress";
			this.ipaddress.Size = new System.Drawing.Size(179, 30);
			this.ipaddress.Text = "000.000.000.000";
			// 
			// port
			// 
			this.port.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(222)))), ((int)(((byte)(239)))));
			this.port.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
			this.port.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(57)))), ((int)(((byte)(156)))));
			this.port.Location = new System.Drawing.Point(136, 126);
			this.port.Name = "port";
			this.port.Size = new System.Drawing.Size(134, 30);
			this.port.Text = "00000";
			// 
			// clear
			// 
			this.clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(222)))), ((int)(((byte)(239)))));
			this.clear.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
			this.clear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(57)))), ((int)(((byte)(156)))));
			this.clear.Location = new System.Drawing.Point(0, 170);
			this.clear.Name = "clear";
			this.clear.Size = new System.Drawing.Size(115, 45);
			this.clear.TabIndex = 1;
			this.clear.Text = "clear";
			this.clear.Click += new System.EventHandler(this.clear_Click);
			// 
			// close
			// 
			this.close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(222)))), ((int)(((byte)(239)))));
			this.close.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
			this.close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(57)))), ((int)(((byte)(156)))));
			this.close.Location = new System.Drawing.Point(203, 170);
			this.close.Name = "close";
			this.close.Size = new System.Drawing.Size(115, 45);
			this.close.TabIndex = 2;
			this.close.Text = "close";
			this.close.Click += new System.EventHandler(this.close_Click);
			// 
			// ConfigureTcpConnection
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(222)))), ((int)(((byte)(239)))));
			this.ClientSize = new System.Drawing.Size(318, 215);
			this.Controls.Add(this.close);
			this.Controls.Add(this.clear);
			this.Controls.Add(this.port);
			this.Controls.Add(this.ipaddress);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "ConfigureTcpConnection";
			this.Text = "ConfigureTcpConnection";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label ipaddress;
		private System.Windows.Forms.Label port;
		private System.Windows.Forms.Button clear;
		private System.Windows.Forms.Button close;
	}
}