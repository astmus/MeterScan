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

namespace MeterScan
{
    public partial class Form1 : Form
    {
        private WLAN myWlan = null;
        private Timer startTimer = new Timer();
        public Form1()
        {
            InitializeComponent();
            WLAN.Monitor.AdapterPower = true;
            WLAN.Monitor.AccessPoint = true;
            startTimer.Tick += new EventHandler(onFormLoaded);
            startTimer.Interval = 1000;
            startTimer.Enabled = true;
        }

        void onFormLoaded(object sender, EventArgs e)
        {
            startTimer.Enabled = false;
            startTimer.Dispose();
            ConfigureWirellesAdapter();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            setWifiAdapterPower(Adapter.PowerStates.ON);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            setWifiAdapterPower(Adapter.PowerStates.OFF);
        }

        private void ConfigureWirellesAdapter()
        {
            try
            {
                //create a reference to WLAN
                myWlan = new WLAN(FusionAccessType.STATISTICS_MODE);
                label2.Text = myWlan.Adapters[0].PowerState.ToString();

                if (myWlan.Adapters[0].PowerState == Adapter.PowerStates.OFF)
                {
                    if (MessageBox.Show("WiFi adapter is off. Turn it on?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                        setWifiAdapterPower(Adapter.PowerStates.ON);
                }
                myWlan.StatusChanged += new WLAN.StatusChangeHandler(onWlanStatusChanged);
            }
            catch (Symbol.Exceptions.OperationFailureException)
            {
                Symbol.ResourceCoordination.TerminalInfo terminalInfo = new Symbol.ResourceCoordination.TerminalInfo();

                if (((Symbol.ResourceCoordination.WLANTypes)(terminalInfo.ConfigData.WLAN)) == Symbol.ResourceCoordination.WLANTypes.NONE)
                {
                    MessageBox.Show("The configuration of the device doesn't support Fusion. The application will now exit.");
                }
                else
                {
                    MessageBox.Show("Unable to open Fusion. The application will now exit.");
                }

                this.Close();
                return;
            }

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
            if (e.StatusChange == Symbol.Fusion.WLAN.StatusChangeEventArgs.StatusChanges.AdapterPowerON)
            {
                //populate adapter power state in the list
                label2.Text = "ON";
                //listViewFusion.Items[adapterStatusLocation].SubItems[3].Text = adapterPowerState;
            }
            else if (e.StatusChange == Symbol.Fusion.WLAN.StatusChangeEventArgs.StatusChanges.AdapterPowerOFF)
            {
                label2.Text = "OFF";
                //populate adapter power state in the list
                //listViewFusion.Items[adapterStatusLocation].SubItems[3].Text = adapterPowerState;
            }
            else if (e.StatusChange == Symbol.Fusion.WLAN.StatusChangeEventArgs.StatusChanges.AccesspointChanged)
            {
                //populate accesspoint MAC address (BSSID) in the list
                Symbol.Fusion.WLAN.StatusChangeEventArgs.APChangedEventData APData = (Symbol.Fusion.WLAN.StatusChangeEventArgs.APChangedEventData)(e.StatusChangeData);

                if (String.IsNullOrEmpty(APData.BSSID))
                {
                    
                    if (Settings.IsEmpty())
                    {
                        Configure conf = new Configure();
                        conf.Show();                        
                    }
                    else
                    {
                        WLAN lan = new WLAN(FusionAccessType.COMMAND_MODE);
                        Profile p = lan.GetProfileByName(Settings.SSIDName);
                        lan.Dispose();
                        label5.Text = "Not associated";
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

        private void button3_Click(object sender, EventArgs e)
        {
            //barcode21.EnableScanner = false;
            //barcode21.Dispose();
            Application.Exit();
        }

        private void barcode21_OnScan(Symbol.Barcode2.ScanDataCollection scanDataCollection)
        {
            ScanData scanData = scanDataCollection.GetFirst;
            if (scanData.Result == Results.SUCCESS)
            {
                while (listBox1.Items.Count >= 10)
                    listBox1.Items.RemoveAt(0);
                listBox1.Items.Add(scanData.Text + ";" + scanData.Type.ToString());
            }
        }

        private void barcode21_OnStatus(Symbol.Barcode2.StatusData statusData)
        {
            label4.Text = statusData.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        

        private void menuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
                System.Windows.Forms.MessageBox.Show("Command mode is in use", "Error");                
                return;
            }

            //search the profile and connect if found
            Profile myProfile = getProfileByID(profileID, myCommandModeWlan);
            if (myProfile != null)
            {
                Symbol.Fusion.FusionResults result = myProfile.Connect(persistance);

                if (result != Symbol.Fusion.FusionResults.SUCCESS)
                {
                    MessageBox.Show("Failure in connecting to the specified profile. Result = " + result);
                }
            }

            //dispose the created WLAN object
            myCommandModeWlan.Dispose();

        }*/
    }
}