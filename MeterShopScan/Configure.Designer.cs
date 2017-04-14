namespace MeterShopScan
{
    partial class Configure
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.label1 = new System.Windows.Forms.Label();
            this.barcode21 = new Symbol.Barcode2.Design.Barcode2();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 20);
            this.label1.Text = "Connect to WiFi network";
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
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(19, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 20);
            this.label2.Text = "1. Scan barcode with WiFi settings";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(19, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.Text = "SSID";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(19, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.Text = "Password";
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 191);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(318, 24);
            this.statusBar1.Text = "statusBar1";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(92, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 20);
            this.label5.Text = "unscan";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(92, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(223, 20);
            this.label6.Text = "unscan";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(243, 165);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 20);
            this.button2.TabIndex = 10;
            this.button2.Text = "Close";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(92, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 20);
            this.label7.Text = "unscan";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(92, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(223, 20);
            this.label8.Text = "unscan";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(19, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 20);
            this.label9.Text = "Port";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(19, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 20);
            this.label10.Text = "IP";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(19, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(251, 20);
            this.label11.Text = "2. Scan barcode with tcp data connect";
            // 
            // Configure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(318, 215);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Configure";
            this.Text = "1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Symbol.Barcode2.Design.Barcode2 barcode21;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.StatusBar statusBar1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}