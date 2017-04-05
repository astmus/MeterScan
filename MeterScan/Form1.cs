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
            catch (OperationFailureException)
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

                if (((APData.BSSID == "") || (APData.BSSID == null)))
                {
                    //listViewFusion.Items[adapterStatusLocation].SubItems[3].Text = adapterPowerState + ", Not associated";
                }
                else
                {
                    //listViewFusion.Items[adapterStatusLocation].SubItems[3].Text = adapterPowerState + ", " + APData.BSSID;
                }

                try
                {
                    //populate ESSID in the list
                    //listViewFusion.Items[essidLocation].SubItems[3].Text = "";
                    //listViewFusion.Items[essidLocation].SubItems[3].Text = APData.Adapter.ESSID;
                }
                catch
                {
                }
                try
                {
                    //populate profile name in the list
                    //listViewFusion.Items[profileNameLocation].SubItems[3].Text = "";
                    //listViewFusion.Items[profileNameLocation].SubItems[3].Text = APData.Adapter.ActiveProfile.Name;
                }
                catch
                {
                }
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
            Application.Exit();
        }
    }
}