using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MeterScan
{
	public partial class ConfigureWiFiNetwork : Form
	{
		public ConfigureWiFiNetwork()
		{
			InitializeComponent();
		}

		private void OnClearButtonClickAction()
		{
			ssid.Text = "000.000.000.000";
			password.Text = "00000";
		}

		private void OnCloseButtonClickAction()
		{
			barcode21.EnableScanner = false;
			this.Close();
		}

		private void clear_Click(object sender, EventArgs e)
		{
			OnClearButtonClickAction();			
		}	

		private void close_Click(object sender, EventArgs e)
		{
			OnCloseButtonClickAction();			
		}

		private void barcode21_OnScan(Symbol.Barcode2.ScanDataCollection scanDataCollection)
		{

		}

		private void barcode21_OnStatus(Symbol.Barcode2.StatusData statusData)
		{
			Logger.Instance.LogTrace("ConfigureWiFiNetwork barcode21_OnStatus state = " + statusData.State.ToString());
		}

		private void ConfigureWiFiNetwork_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Alt)
				OnClearButtonClickAction();
			if (e.Control)
				OnCloseButtonClickAction();
		}
		
	}
}