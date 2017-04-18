namespace MeterShopScan
{
    partial class Form1
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
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.button5 = new System.Windows.Forms.Button();
			this.keyCode = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(4, 3);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(190, 20);
			this.button1.TabIndex = 0;
			this.button1.Text = "WiFi config";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(57)))), ((int)(((byte)(156)))));
			this.label1.Location = new System.Drawing.Point(58, 144);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(136, 27);
			this.label1.Text = "WiFi Status";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(4, 29);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(190, 20);
			this.button2.TabIndex = 1;
			this.button2.Text = "Tcp Config";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(222)))), ((int)(((byte)(239)))));
			this.button3.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
			this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(57)))), ((int)(((byte)(156)))));
			this.button3.Location = new System.Drawing.Point(203, 190);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(115, 45);
			this.button3.TabIndex = 3;
			this.button3.Text = "Exit";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(57)))), ((int)(((byte)(156)))));
			this.label2.Location = new System.Drawing.Point(170, 144);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(98, 27);
			this.label2.Text = "getting..";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(57)))), ((int)(((byte)(156)))));
			this.label5.Location = new System.Drawing.Point(4, 144);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(57, 27);
			this.label5.Text = "label5";
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(4, 55);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(190, 20);
			this.button5.TabIndex = 14;
			this.button5.Text = "tcp connect";
			this.button5.Click += new System.EventHandler(this.button5_Click_1);
			// 
			// keyCode
			// 
			this.keyCode.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
			this.keyCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(57)))), ((int)(((byte)(156)))));
			this.keyCode.Location = new System.Drawing.Point(4, 190);
			this.keyCode.Name = "keyCode";
			this.keyCode.Size = new System.Drawing.Size(136, 27);
			this.keyCode.Text = "Key";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(222)))), ((int)(((byte)(239)))));
			this.ClientSize = new System.Drawing.Size(318, 235);
			this.Controls.Add(this.keyCode);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form1";
			this.Text = "Form1";
			this.Activated += new System.EventHandler(this.Form1_Activated);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Label keyCode;
    }
}

