#define not_scaner
using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Symbol.Fusion.WLAN;
using Symbol.Fusion;
using Symbol.Exceptions;
using Symbol.Barcode2;
using System.Net.Sockets;
using System.Net;
using Microsoft.Win32;
using MeterShopScan.Controls;
using MeterShopScan.Properties;



namespace MeterShopScan
{	
    public partial class Form1 : Form
    {	        
        private Timer startTimer;
        public Form1()
        {
			Logger.Instance.LogTrace("Application Start");
            InitializeComponent();
            WLAN.Monitor.AdapterPower = true;
            WLAN.Monitor.AccessPoint = true;			
        }	

        void onFormLoaded(object sender, EventArgs e)
        {
			Logger.Instance.LogTrace("MainForm onFormLoaded");
            startTimer.Enabled = false;
            startTimer.Dispose();			
			CheckTcpServerConnection();			
        }

        private void button1_Click(object sender, EventArgs e)
        {
			ConfigureWiFiNetwork form = new ConfigureWiFiNetwork();
			form.Show();
            //setWifiAdapterPower(Adapter.PowerStates.ON);
        }

        private void button2_Click(object sender, EventArgs e)
        {
			ConfigureTcpConnection form = new ConfigureTcpConnection();
			form.Show();
            //setWifiAdapterPower(Adapter.PowerStates.OFF);
        }

        private void CheckTcpServerConnection()
        {
			Logger.Instance.LogTrace("MainForm CheckTcpServerConnection");
#if not_scaner
			if (Settings.Instance.SSID == null || Settings.Instance.WiFiPassword == null)
			{
				ConfigureWiFiNetwork form = new ConfigureWiFiNetwork();
				form.Show();
				return;
			}
			
			if (Settings.Instance.TcpIpAddress == null || Settings.Instance.TcpPort == null)
			{
				ConfigureTcpConnection form = new ConfigureTcpConnection();
				form.Show();
				return;
			}			
#else
            try
            {
                //create a reference to WLAN
                myWlan = new WLAN(FusionAccessType.STATISTICS_MODE);
                label2.Text = myWlan.Adapters[0].PowerState.ToString();

                if (myWlan.Adapters[0].PowerState == Adapter.PowerStates.OFF)
					setWifiAdapterPower(Adapter.PowerStates.ON);
                myWlan.StatusChanged += new WLAN.StatusChangeHandler(onWlanStatusChanged);
            }
            catch (Symbol.Exceptions.OperationFailureException)
            {
                Symbol.ResourceCoordination.TerminalInfo terminalInfo = new Symbol.ResourceCoordination.TerminalInfo();

                if (((Symbol.ResourceCoordination.WLANTypes)(terminalInfo.ConfigData.WLAN)) == Symbol.ResourceCoordination.WLANTypes.NONE)
                {
                    CustomMessageBox.Show("The configuration of the device doesn't support Fusion. The application will now exit.");
                }
                else
                {
                    CustomMessageBox.Show("Unable to open Fusion. The application will now exit.");
                }

                this.Close();
                return;
            }

#endif
            //The variable to hold the management state. 
            //Initialize it to Fusion.
            /*Symbol.Fusion.WLAN.WLAN_MANAGEMENT_STATE managementState = WLAN_MANAGEMENT_STATE.WLAN_MANAGEMENT_FUSION_STATE;

            try
            {
                //Get the current state form the device.
                managementState = myWlan.Adapters[0].WLANManagement;
            }
            catch
            {
                //In case of any failure, just continue.
            }

            //Only if the current management state is WZC, skip performing any profile - related operations.
            if (!((managementState == WLAN_MANAGEMENT_STATE.WLAN_MANAGEMENT_WZC_STATE) || (managementState == WLAN_MANAGEMENT_STATE.WLAN_MANAGEMENT_WZC_STATE_REBOOT_IN_FUSION_STATE)))
            {
                createSampleProfiles();
                try
                {
                    //refresh profile list so that newly created profiles will be visible
                    myWlan.Profiles.Refresh();
                }
                catch (OperationFailureException)
                {
                    // This is just to allow the application to continue even if the profile enumeration fails fails with OperationFailureException.
                }
            }*/
        }

        void onWlanStatusChanged(object sender, StatusChangeEventArgs e)
        {
			Logger.Instance.LogTrace("MainForm onWlanStatusChanged Status = " + e.StatusChange.ToString());
            if (e.StatusChange == Symbol.Fusion.WLAN.StatusChangeEventArgs.StatusChanges.AdapterPowerON)
                label2.Text = "ON";
            else if (e.StatusChange == Symbol.Fusion.WLAN.StatusChangeEventArgs.StatusChanges.AdapterPowerOFF)
                label2.Text = "OFF";
            else if (e.StatusChange == Symbol.Fusion.WLAN.StatusChangeEventArgs.StatusChanges.AccesspointChanged)
            {
                //populate accesspoint MAC address (BSSID) in the list
                Symbol.Fusion.WLAN.StatusChangeEventArgs.APChangedEventData APData = (Symbol.Fusion.WLAN.StatusChangeEventArgs.APChangedEventData)(e.StatusChangeData);

                if (String.IsNullOrEmpty(APData.BSSID))
                {
					if (Settings.Instance.SSID == null || Settings.Instance.WiFiPassword == null)
					{
						ConfigureWiFiNetwork wifiCong = new ConfigureWiFiNetwork();
						wifiCong.Show();
					}
					else
					{
						WLAN lan = new WLAN(FusionAccessType.COMMAND_MODE);
						Profile wifiProfile = lan.GetProfileByName(Settings.Instance.SSID);
						Activity.Show("Please wait. Connect to WiFi network.");
						var res = wifiProfile.Connect(true);
						Activity.Hide();
						if (res != Symbol.Fusion.FusionResults.SUCCESS)
						{
							ConfigureWiFiNetwork wifiCong = new ConfigureWiFiNetwork();
							wifiCong.Show();
						}
					}					                   
                }
                else
                    label5.Text = "Connected";
            }
        }

        private void setWifiAdapterPower(Adapter.PowerStates state)
        {
            WLAN editWlan = new WLAN(FusionAccessType.COMMAND_MODE);
            editWlan.Adapters[0].PowerState = state;
            editWlan.Dispose();
            editWlan = null;
        }                    

		private void button5_Click_1(object sender, EventArgs e)
		{
			try
			{
				TcpClient client = new TcpClient("192.168.123.1", 3128);
				CustomMessageBox.Show("Connection to 192.168.123.1 is Ok");
			}
			catch (Exception ex)
			{
				CustomMessageBox.Show("Connection to 192.168.123.1 is not established");
			}
		}

		private void Form1_Activated(object sender, EventArgs e)
		{
			Logger.Instance.LogTrace("Form1_Activated");
			startTimer = new Timer();
			startTimer.Tick += new EventHandler(onFormLoaded);
			startTimer.Interval = 1000;
			startTimer.Enabled = true;
		}

		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			Logger.Instance.LogTrace("Form1 KeyDown keyCode = "+e.KeyCode.ToString()+" keyValue = "+e.KeyValue);
			if (e.Control)
				Application.Exit();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			//Settings.Instance.Clear();
		}

		Timer r;
		private void button4_Click(object sender, EventArgs e)
		{
			Activity.Show("Connecting o wifi network");
			r = new Timer();
			r.Interval = 2000;
			r.Tick += new EventHandler(r_Tick);
			r.Enabled = true;
		}

		void r_Tick(object sender, EventArgs e)
		{
			r.Enabled = false;
			r.Dispose();
			Activity.Hide();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			var res = CustomMessageBox.Show("Press ok or cancel", CustomMessageBoxButtons.OkCancel,Resources.exclamation);
			label3.Text = res.ToString();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			Form2 r = new Form2();
			r.Show();
		}						

		/* private void connectToProfile(string profileID, bool persistance)
        {
            //Create a WLAN object in COMMAND_MODE
            WLAN myCommandModeWlan = null;
            try
            {
                myCommandModeWlan = new WLAN(FusionAccessType.COMMAND_MODE);
            }
            catch (Symbol.Exceptions.OperationFailureException)
            {
                CustomMessageBox.Show("Command mode is in use", "Error");                
                return;
            }

            //search the profile and connect if found
            Profile myProfile = getProfileByID(profileID, myCommandModeWlan);
            if (myProfile != null)
            {
                Symbol.Fusion.FusionResults result = myProfile.Connect(persistance);

                if (result != Symbol.Fusion.FusionResults.SUCCESS)
                {
                    CustomMessageBox.Show("Failure in connecting to the specified profile. Result = " + result);
                }
            }
            //dispose the created WLAN object
            myCommandModeWlan.Dispose();
        }*/
    }
}