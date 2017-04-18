using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Microsoft.Win32;
using System.Drawing;

namespace MeterShopScan
{
    class Settings
    {
		private RegistryKey _rootFolder;
		private RegistryKey _connectionFolder;
		private const string SETTING_REG_KEY = "MeterShopScaner";
		private const string CONNECT_REG_KEY = "Connection";
		private const string SSID_REG_KEY = "SSID";
		private const string WIFI_PASS_REG_KEY = "WiFiPass";
		private const string TCP_PORT_REG_KEY = "TCPPort";
		private const string TCP_IPADDRESS_REG_KEY = "TCPIPAddress";

		private Settings()
		{
			_rootFolder = Registry.CurrentUser.GetWritableKey(SETTING_REG_KEY);
			_connectionFolder = _rootFolder.GetWritableKey(CONNECT_REG_KEY);			
		}

		~Settings()
		{

		}		

		public void Clear()
		{
			_rootFolder.DeleteSubKeyTree(CONNECT_REG_KEY);
			_instance = null;
		}

		private static Settings _instance;
		public static Settings Instance
		{
			get	{ return _instance ?? (_instance = new Settings());	}
		}

		public Color BackColor
		{
			get { return Color.FromArgb(206, 222, 239); }
		}

		public Color ActiveColor
		{
			get { return Color.FromArgb(33, 57, 156); }
		}

		public string SSID
		{
			get { return _connectionFolder.GetValue(SSID_REG_KEY) as string; }
			set { _connectionFolder.SetValue(SSID_REG_KEY,value); }
		}

		public string WiFiPass
		{
			get { return _connectionFolder.GetValue(WIFI_PASS_REG_KEY) as string; }
			set { _connectionFolder.SetValue(WIFI_PASS_REG_KEY,value); }
		}

		public string TcpPort
		{
			get { return _connectionFolder.GetValue(TCP_PORT_REG_KEY) as string; }
			set { _connectionFolder.SetValue(TCP_PORT_REG_KEY,value); }
		}

		public string TcpIpAddress
		{
			get { return _connectionFolder.GetValue(TCP_IPADDRESS_REG_KEY) as string; }
			set { _connectionFolder.SetValue(TCP_IPADDRESS_REG_KEY, value); }
		}
    }

	public static class RexExtension
	{
		public static RegistryKey GetWritableKey(this RegistryKey key, string name)
		{
			key.CreateSubKey(name);
			return key.OpenSubKey(name, true);
		}
	}
}
