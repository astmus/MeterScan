﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Symbol.Barcode2;
using Symbol.Fusion.WLAN;
using Symbol.Fusion;
using MeterShopScan.Properties;

namespace MeterShopScan
{
	public partial class ConfigureWiFiNetwork : Form
	{
		public ConfigureWiFiNetwork()
		{
			InitializeComponent();
			ssid.Text = Settings.Instance.SSID;
			password.Text = Settings.Instance.WiFiPassword;
		}

		private void OnClearButtonClickAction()
		{
			ssid.Text = "ssidundef";
			password.Text = "passundef";
		}

		private void OnCloseButtonClickAction()
		{
			Logger.Instance.LogTrace("ConfigureWiFiNetwork OnCloseButtonClickAction");
#if SCANER
			barcode21.EnableScanner = false;
#else
			Settings.Instance.SSID = "aria";
			Settings.Instance.WiFiPassword = "qwe123qwe";
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
				Logger.Instance.LogDebug("ConfigureWiFiNetwork scannedData = " + connectData);
				var splitted = connectData.Split(new char[] { ';' });
				ssid.Text = splitted[0];
				password.Text = splitted[1];
				Logger.Instance.LogDebug("ConfigureTcpConnection ssid = " + ssid + " password = " + password);
				ConfigureWiFiProfile(ssid.Text, password.Text);
			}
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

		private void ConfigureWiFiProfile(string SSID, string Password)
		{
			WLAN wlan = null;
			try
			{
				wlan = new WLAN(FusionAccessType.COMMAND_MODE);
				Profile already = wlan.GetProfileByName(SSID);
				if (already != null)
					if (CustomMessageBox.Show("Profile with name '" + already.Name + "' already exists. It will be rewrited?",CustomMessageBoxButtons.YesNo, Resources.exclamation) == DialogResult.No)
						return;
					else
						wlan.Profiles.DeleteProfile(already);

				//prepare profile data and create it
				InfrastructureProfileData profileData = new InfrastructureProfileData(SSID, SSID);
				profileData.Encryption.PassPhrase = Password;				
				#warning Change country before release
				profileData.CountryCode = "UA";
				profileData.IPSettings.AddressingMode = IPSettings.AddressingModes.DHCP;
				profileData.Encryption.EncryptionType = Encryption.EncryptionTypes.TKIP;
				profileData.SecurityType = WLANSecurityType.SECURITY_WPA_PERSONAL;

				Profile wifiProfile = wlan.Profiles.CreateInfrastructureProfile(profileData);

				
				this.Refresh();
				var res = wifiProfile.Connect(true);
				if (res != Symbol.Fusion.FusionResults.SUCCESS)
				{
					ssid.Text = Settings.Instance.SSID;
					password.Text = Settings.Instance.WiFiPassword;
					CustomMessageBox.Show("Failure in connecting to the specified profile. Result = " + res);
					this.Close();
				}
				else
					CustomMessageBox.Show("Connection success");
			}
			catch
			{
				return;
			}
			finally
			{
				wlan.Dispose();
				wlan = null;
			}
		}
		
	}
}