using System;
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
using System.Net.Sockets;

namespace MeterScan
{
    public partial class Configure : Form
    {
        bool isWifiScan = true;

        public Configure()
        {
            InitializeComponent();
            statusBar1.Text = "Scaner status = initialize";
        }       

        private void barcode21_OnScan(ScanDataCollection scanDataCollection)
        {
            ScanData scanData = scanDataCollection.GetFirst;
            if (scanData.Result == Results.SUCCESS)
            {

                string connectData = scanData.Text;
                var splitted = connectData.Split(new char[] { ';' });
                if (splitted.Length < 2)
                {
                    MessageBox.Show("Wrong WiFi network connection data");
                    return;
                }

                if (isWifiScan)
                {               
                    label5.Text = splitted[0];
                    label6.Text = splitted[1];
                    ConfigureWiFiProfile(label5.Text, label6.Text);
                    isWifiScan = false;
                }
                else
                {
                    label8.Text = splitted[0];
                    label7.Text = splitted[1];
                    this.Refresh();
                    PingTcpServer(label8.Text, int.Parse(label7.Text));
                }
            }
        }

        private void PingTcpServer(string IpAddres, int port)
        {
            try
            {
                TcpClient client = new TcpClient(IpAddres, port);
                MessageBox.Show("Connection Ok");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection is not established");
            }
        }

        private void barcode21_OnStatus(Symbol.Barcode2.StatusData statusData)
        {
            statusBar1.Text = "Scaner status = " + statusData.State.ToString();
        }

        private void ConfigureWiFiProfile(string SSID, string Password)
        {
            WLAN wlan = null;
            try
            {
                wlan = new WLAN(FusionAccessType.COMMAND_MODE);
                Profile already = wlan.GetProfileByName(SSID);
                if (already != null)
                    if (MessageBox.Show("Profile with name " + already + "already exists. It will be rewrited?", "Warning", MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation,MessageBoxDefaultButton.Button1) == DialogResult.No)
                        return;
                    else
                        wlan.Profiles.DeleteProfile(already);

                //prepare profile data and create it
                InfrastructureProfileData profileData = new InfrastructureProfileData(SSID, SSID);
                profileData.Encryption.PassPhrase = Password;
                profileData.CountryCode = "UA";
                profileData.IPSettings.AddressingMode = IPSettings.AddressingModes.DHCP;
                profileData.Encryption.EncryptionType = Encryption.EncryptionTypes.TKIP;
                profileData.SecurityType = WLANSecurityType.SECURITY_WPA_PERSONAL;

                Profile wifiProfile = wlan.Profiles.CreateInfrastructureProfile(profileData);

                statusBar1.Text = "Connect to WiFi";
                this.Refresh();
                var res = wifiProfile.Connect(true);
                if (res != Symbol.Fusion.FusionResults.SUCCESS)
                    MessageBox.Show("Failure in connecting to the specified profile. Result = " + res);
                else
                    MessageBox.Show("Connection success");                 
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

        private void button2_Click(object sender, EventArgs e)
        {
            barcode21.EnableScanner = false;
            this.Close();
        }
    }
}