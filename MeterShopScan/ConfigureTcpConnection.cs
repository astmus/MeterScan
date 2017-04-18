using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using Symbol.Barcode2;

namespace MeterShopScan
{
	public partial class ConfigureTcpConnection : Form
	{
		public ConfigureTcpConnection()
		{
			InitializeComponent();
			ipaddress.Text = Settings.Instance.TcpIpAddress;
			port.Text = Settings.Instance.TcpPort;
		}

		private void OnClearButtonClickAction()
		{
			ipaddress.Text = "000.000.000.000";
			port.Text = "00000";
		}

		private void OnCloseButtonClickAction()
		{
			Logger.Instance.LogTrace("ConfigureTcpConnection OnCloseButtonClickAction");
#if SCANER
			barcode21.EnableScanner = false;
#else
			Settings.Instance.TcpIpAddress = "192.168.0.1";
			Settings.Instance.TcpPort = "3311";
#endif
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
			ScanData scanData = scanDataCollection.GetFirst;
			if (scanData.Result == Results.SUCCESS)
			{

				string connectData = scanData.Text;
				var splitted = connectData.Split(new char[] { ';' });
				ipaddress.Text = splitted[0];
				port.Text = splitted[1];
				PingTcpServer(ipaddress.Text, int.Parse(port.Text));
			}
		}

		private void PingTcpServer(string IpAddres, int port)
		{
			try
			{
				TcpClient client = new TcpClient(IpAddres, port);
				Settings.Instance.TcpIpAddress = IpAddres;
				Settings.Instance.TcpPort = port.ToString();
				MessageBox.Show("Connection Ok");
				this.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Connection is not established");
			}
		}

		private void barcode21_OnStatus(Symbol.Barcode2.StatusData statusData)
		{
			Logger.Instance.LogTrace("ConfigureTcpConnection barcode21_OnStatus state = " + statusData.State.ToString());
		}

		private void ConfigureTcpConnection_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Alt)
				OnClearButtonClickAction();
			if (e.Control)
				OnCloseButtonClickAction();
		}
	}
}