using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            if (Directory.Exists(swgDir))
            {
                StreamWriter configWriter = new StreamWriter(swgDir + @"\user.cfg");
            }
            else
                MessageBox.Show("Please enter a valid SWG game directory.", "Invalid Directory");
        }

        private void changeDirButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog swgDirBrowser = new FolderBrowserDialog();
            swgDirBrowser.Description = "Please show us where your SWG game directory is.";
            if (swgDirBrowser.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(swgDirBrowser.SelectedPath + @"\SwgClient_r.exe"))
                {
                    Properties.Settings.Default.swgDirectory = swgDirBrowser.SelectedPath;
                    Properties.Settings.Default.Save();
                    gameDirectoryTextBox.Text = Properties.Settings.Default.swgDirectory;
                }
                else
                    MessageBox.Show("Invalid SWG NGE game directory.", "Invalid Directory");
            }
        }

        private void openDirButton_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(Properties.Settings.Default.swgDirectory))
                Process.Start(Properties.Settings.Default.swgDirectory);
        }
    }
}
