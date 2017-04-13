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
	public partial class ConfigureTcpConnection : Form
	{
		public ConfigureTcpConnection()
		{
			InitializeComponent();			
		}

		private void clear_Click(object sender, EventArgs e)
		{
			ipaddress.Text = "000.000.000.000";
			port.Text = "00000";
		}

		private void close_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}