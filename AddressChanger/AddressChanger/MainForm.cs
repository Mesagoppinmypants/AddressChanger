using System;
using System.IO;
using System.Windows.Forms;

namespace AddressChanger
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            string swgDir = Properties.Settings.Default.swgDirectory;
            string newAddress = newAddressTextBox.Text;
            bool multipleInstances = multipleInstancesCheckBox.Checked;
            if (Directory.Exists(swgDir))
            {
                StreamWriter configWriter = new StreamWriter(swgDir + @"\user.cfg");
                configWriter.Write("[SwgClient]\r\n");
                configWriter.Write("allowMultipleInstances=" + multipleInstances + "\r\n\r\n");
                configWriter.Write("[Station]\r\n");
                configWriter.Write("subscriptionFeatures=1\r\n");
                configWriter.Write("gameFeatures=65535\r\n\r\n");
                configWriter.Write("[ClientGame]\r\n");
                configWriter.Write("loginServerAddress=" + newAddress);
                configWriter.Close();
                getCurrentAddress();
            }
            else
                MessageBox.Show("Please enter a valid SWG game directory.", "Invalid Directory");
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            getCurrentAddress();
        }

        private void getCurrentAddress()
        {
            if (File.Exists(Properties.Settings.Default.swgDirectory + @"\user.cfg"))
            {
                string currentAddress;
                StreamReader userConfig = new StreamReader(Properties.Settings.Default.swgDirectory + @"\user.cfg");
                while ((currentAddress = userConfig.ReadLine()) != null)
                {
                    if (currentAddress.Contains("loginServerAddress"))
                        currentAddressTextBox.Text = currentAddress.Replace("loginServerAddress=", "");
                }
                userConfig.Close();
            }
        }
    }
}
