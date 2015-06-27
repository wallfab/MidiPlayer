using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sanford.Multimedia.Midi;
using System.Diagnostics;

namespace MidiPlayer
{
    public partial class Settings : Form
    {

        private frm_Main mainForm;
        private int selectedOutputDevice;
        public Settings()
        {
            InitializeComponent();
        }

        public Settings(frm_Main main, int outputID)
        {
            InitializeComponent();
            this.mainForm = main;
            this.selectedOutputDevice = outputID;
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < OutputDevice.DeviceCount; i++)
            {
                cb_devices.Items.Add(OutputDevice.GetDeviceCapabilities(i).name);
            }
            cb_devices.SelectedIndex = this.selectedOutputDevice;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("OutputDeviceID: " + cb_devices.SelectedIndex);
            mainForm.setOutDevice(cb_devices.SelectedIndex);
            Properties.Settings.Default["outputDeviceId"] = cb_devices.SelectedIndex;
            Properties.Settings.Default.Save();
            Close();
        }
    }
}
