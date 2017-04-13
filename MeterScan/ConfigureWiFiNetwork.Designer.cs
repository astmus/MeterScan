namespace MeterScan
{
	partial class ConfigureWiFiNetwork
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
			this.ssid = new System.Windows.Forms.Label();
			this.password = new System.Windows.Forms.Label();
			this.clear = new System.Windows.Forms.Button();
			this.close = new System.Windows.Forms.Button();
			this.barcode21 = new Symbol.Barcode2.Design.Barcode2();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(57)))), ((int)(((byte)(156)))));
			this.label1.Location = new System.Drawing.Point(4, 4);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(311, 30);
			this.label1.Text = "Configure WiFi network";
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
			this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(57)))), ((int)(((byte)(156)))));
			this.label11.Location = new System.Drawing.Point(4, 34);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(311, 52);
			this.label11.Text = "Now scan barcode with WiFi data connect";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(57)))), ((int)(((byte)(156)))));
			this.label2.Location = new System.Drawing.Point(4, 96);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(134, 30);
			this.label2.Text = "SSID";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(57)))), ((int)(((byte)(156)))));
			this.label3.Location = new System.Drawing.Point(3, 126);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(135, 30);
			this.label3.Text = "Password";
			// 
			// ssid
			// 
			this.ssid.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
			this.ssid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(57)))), ((int)(((byte)(156)))));
			this.ssid.Location = new System.Drawing.Point(136, 96);
			this.ssid.Name = "ssid";
			this.ssid.Size = new System.Drawing.Size(179, 30);
			this.ssid.Text = "empty";
			// 
			// password
			// 
			this.password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(222)))), ((int)(((byte)(239)))));
			this.password.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
			this.password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(57)))), ((int)(((byte)(156)))));
			this.password.Location = new System.Drawing.Point(136, 126);
			this.password.Name = "password";
			this.password.Size = new System.Drawing.Size(134, 30);
			this.password.Text = "empty";
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
			// barcode21
			// 
			this.barcode21.Config.DecoderParameters.CODABAR = Symbol.Barcode2.Design.DisabledEnabled.Default;
			this.barcode21.Config.DecoderParameters.CODABARParams.ClsiEditing = false;
			this.barcode21.Config.DecoderParameters.CODABARParams.NotisEditing = false;
			this.barcode21.Config.DecoderParameters.CODABARParams.Redundancy = true;
			this.barcode21.Config.DecoderParameters.CODE128 = Symbol.Barcode2.Design.DisabledEnabled.Default;
			this.barcode21.Config.DecoderParameters.CODE128Params.EAN128 = true;
			this.barcode21.Config.DecoderParameters.CODE128Params.ISBT128 = true;
			this.barcode21.Config.DecoderParameters.CODE128Params.Other128 = true;
			this.barcode21.Config.DecoderParameters.CODE128Params.Redundancy = false;
			this.barcode21.Config.DecoderParameters.CODE39 = Symbol.Barcode2.Design.DisabledEnabled.Default;
			this.barcode21.Config.DecoderParameters.CODE39Params.Code32Prefix = false;
			this.barcode21.Config.DecoderParameters.CODE39Params.Concatenation = false;
			this.barcode21.Config.DecoderParameters.CODE39Params.ConvertToCode32 = false;
			this.barcode21.Config.DecoderParameters.CODE39Params.FullAscii = false;
			this.barcode21.Config.DecoderParameters.CODE39Params.Redundancy = false;
			this.barcode21.Config.DecoderParameters.CODE39Params.ReportCheckDigit = false;
			this.barcode21.Config.DecoderParameters.CODE39Params.VerifyCheckDigit = false;
			this.barcode21.Config.DecoderParameters.CODE93 = Symbol.Barcode2.Design.DisabledEnabled.Default;
			this.barcode21.Config.DecoderParameters.CODE93Params.Redundancy = false;
			this.barcode21.Config.DecoderParameters.D2OF5 = Symbol.Barcode2.Design.DisabledEnabled.Default;
			this.barcode21.Config.DecoderParameters.D2OF5Params.Redundancy = true;
			this.barcode21.Config.DecoderParameters.EAN13 = Symbol.Barcode2.Design.DisabledEnabled.Default;
			this.barcode21.Config.DecoderParameters.EAN8 = Symbol.Barcode2.Design.DisabledEnabled.Default;
			this.barcode21.Config.DecoderParameters.EAN8Params.ConvertToEAN13 = false;
			this.barcode21.Config.DecoderParameters.I2OF5 = Symbol.Barcode2.Design.DisabledEnabled.Default;
			this.barcode21.Config.DecoderParameters.I2OF5Params.ConvertToEAN13 = false;
			this.barcode21.Config.DecoderParameters.I2OF5Params.Redundancy = true;
			this.barcode21.Config.DecoderParameters.I2OF5Params.ReportCheckDigit = false;
			this.barcode21.Config.DecoderParameters.I2OF5Params.VerifyCheckDigit = Symbol.Barcode2.Design.I2OF5.CheckDigitSchemes.Default;
			this.barcode21.Config.DecoderParameters.KOREAN_3OF5 = Symbol.Barcode2.Design.DisabledEnabled.Default;
			this.barcode21.Config.DecoderParameters.KOREAN_3OF5Params.Redundancy = true;
			this.barcode21.Config.DecoderParameters.MSI = Symbol.Barcode2.Design.DisabledEnabled.Default;
			this.barcode21.Config.DecoderParameters.MSIParams.CheckDigitCount = Symbol.Barcode2.Design.CheckDigitCounts.Default;
			this.barcode21.Config.DecoderParameters.MSIParams.CheckDigitScheme = Symbol.Barcode2.Design.CheckDigitSchemes.Default;
			this.barcode21.Config.DecoderParameters.MSIParams.Redundancy = true;
			this.barcode21.Config.DecoderParameters.MSIParams.ReportCheckDigit = false;
			this.barcode21.Config.DecoderParameters.UPCA = Symbol.Barcode2.Design.DisabledEnabled.Default;
			this.barcode21.Config.DecoderParameters.UPCAParams.Preamble = Symbol.Barcode2.Design.Preambles.Default;
			this.barcode21.Config.DecoderParameters.UPCAParams.ReportCheckDigit = true;
			this.barcode21.Config.DecoderParameters.UPCE0 = Symbol.Barcode2.Design.DisabledEnabled.Default;
			this.barcode21.Config.DecoderParameters.UPCE0Params.ConvertToUPCA = false;
			this.barcode21.Config.DecoderParameters.UPCE0Params.Preamble = Symbol.Barcode2.Design.Preambles.Default;
			this.barcode21.Config.DecoderParameters.UPCE0Params.ReportCheckDigit = false;
			this.barcode21.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.AimDuration = -1;
			this.barcode21.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.AimMode = Symbol.Barcode2.Design.AIM_MODE.AIM_MODE_DEFAULT;
			this.barcode21.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.AimType = Symbol.Barcode2.Design.AIM_TYPE.AIM_TYPE_DEFAULT;
			this.barcode21.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.BeamTimer = -1;
			this.barcode21.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.DPMMode = Symbol.Barcode2.Design.DPM_MODE.DPM_MODE_DEFAULT;
			this.barcode21.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.FocusMode = Symbol.Barcode2.Design.FOCUS_MODE.FOCUS_MODE_DEFAULT;
			this.barcode21.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.FocusPosition = Symbol.Barcode2.Design.FOCUS_POSITION.FOCUS_POSITION_DEFAULT;
			this.barcode21.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.IlluminationMode = Symbol.Barcode2.Design.ILLUMINATION_MODE.ILLUMINATION_DEFAULT;
			this.barcode21.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.ImageCaptureTimeout = -1;
			this.barcode21.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.ImageCompressionTimeout = -1;
			this.barcode21.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.Inverse1DMode = Symbol.Barcode2.Design.INVERSE1D_MODE.INVERSE_DEFAULT;
			this.barcode21.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.LinearSecurityLevel = Symbol.Barcode2.Design.LINEAR_SECURITY_LEVEL.SECURITY_DEFAULT;
			this.barcode21.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.PicklistMode = Symbol.Barcode2.Design.PICKLIST_MODE.PICKLIST_DEFAULT;
			this.barcode21.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.PointerTimer = -1;
			this.barcode21.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.PoorQuality1DMode = Symbol.Barcode2.Design.DisabledEnabled.Default;
			this.barcode21.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.VFFeedback = Symbol.Barcode2.Design.VIEWFINDER_FEEDBACK.VIEWFINDER_FEEDBACK_DEFAULT;
			this.barcode21.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.VFFeedbackTime = -1;
			this.barcode21.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.VFMode = Symbol.Barcode2.Design.VIEWFINDER_MODE.VIEWFINDER_MODE_DEFAULT;
			this.barcode21.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.VFPosition.Bottom = 0;
			this.barcode21.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.VFPosition.Left = 0;
			this.barcode21.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.VFPosition.Right = 0;
			this.barcode21.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.VFPosition.Top = 0;
			this.barcode21.Config.ReaderParameters.ReaderSpecific.LaserSpecific.AimDuration = -1;
			this.barcode21.Config.ReaderParameters.ReaderSpecific.LaserSpecific.AimMode = Symbol.Barcode2.Design.AIM_MODE.AIM_MODE_DEFAULT;
			this.barcode21.Config.ReaderParameters.ReaderSpecific.LaserSpecific.AimType = Symbol.Barcode2.Design.AIM_TYPE.AIM_TYPE_DEFAULT;
			this.barcode21.Config.ReaderParameters.ReaderSpecific.LaserSpecific.BeamTimer = -1;
			this.barcode21.Config.ReaderParameters.ReaderSpecific.LaserSpecific.BeamWidth = Symbol.Barcode2.Design.BEAM_WIDTH.DEFAULT;
			this.barcode21.Config.ReaderParameters.ReaderSpecific.LaserSpecific.BidirRedundancy = Symbol.Barcode2.Design.DisabledEnabled.Default;
			this.barcode21.Config.ReaderParameters.ReaderSpecific.LaserSpecific.ControlScanLed = Symbol.Barcode2.Design.DisabledEnabled.Default;
			this.barcode21.Config.ReaderParameters.ReaderSpecific.LaserSpecific.DBPMode = Symbol.Barcode2.Design.DBP_MODE.DBP_DEFAULT;
			this.barcode21.Config.ReaderParameters.ReaderSpecific.LaserSpecific.KlasseEinsEnable = Symbol.Barcode2.Design.DisabledEnabled.Default;
			this.barcode21.Config.ReaderParameters.ReaderSpecific.LaserSpecific.LinearSecurityLevel = Symbol.Barcode2.Design.LINEAR_SECURITY_LEVEL.SECURITY_DEFAULT;
			this.barcode21.Config.ReaderParameters.ReaderSpecific.LaserSpecific.PointerTimer = -1;
			this.barcode21.Config.ReaderParameters.ReaderSpecific.LaserSpecific.RasterHeight = -1;
			this.barcode21.Config.ReaderParameters.ReaderSpecific.LaserSpecific.RasterMode = Symbol.Barcode2.Design.RASTER_MODE.RASTER_MODE_DEFAULT;
			this.barcode21.Config.ReaderParameters.ReaderSpecific.LaserSpecific.ScanLedLogicLevel = Symbol.Barcode2.Design.DisabledEnabled.Default;
			this.barcode21.Config.ScanParameters.BeepFrequency = 2670;
			this.barcode21.Config.ScanParameters.BeepTime = 200;
			this.barcode21.Config.ScanParameters.CodeIdType = Symbol.Barcode2.Design.CodeIdTypes.Default;
			this.barcode21.Config.ScanParameters.LedTime = 3000;
			this.barcode21.Config.ScanParameters.ScanType = Symbol.Barcode2.Design.SCANTYPES.Default;
			this.barcode21.Config.ScanParameters.WaveFile = "";
			this.barcode21.DeviceType = Symbol.Barcode2.DEVICETYPES.FIRSTAVAILABLE;
			this.barcode21.EnableScanner = true;
			this.barcode21.OnScan += new Symbol.Barcode2.Design.Barcode2.OnScanEventHandler(this.barcode21_OnScan);
			this.barcode21.OnStatus += new Symbol.Barcode2.Design.Barcode2.OnStatusEventHandler(this.barcode21_OnStatus);
			// 
			// ConfigureWiFiNetwork
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(222)))), ((int)(((byte)(239)))));
			this.ClientSize = new System.Drawing.Size(318, 215);
			this.Controls.Add(this.close);
			this.Controls.Add(this.clear);
			this.Controls.Add(this.password);
			this.Controls.Add(this.ssid);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "ConfigureWiFiNetwork";
			this.Text = "ConfigureWiFiNetwork";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ConfigureWiFiNetwork_KeyDown);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label ssid;
		private System.Windows.Forms.Label password;
		private System.Windows.Forms.Button clear;
		private System.Windows.Forms.Button close;
		private Symbol.Barcode2.Design.Barcode2 barcode21;
	}
}