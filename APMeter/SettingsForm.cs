using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace APMeter
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            this.textBoxPathToGame.Text = Properties.Settings.Default.PathToGame;
            this.checkBoxShowTop.Checked = Properties.Settings.Default.ShowTop;

            // Assembly Version
            this.labelVersion.Text = String.Format("ver. {0}", Application.ProductVersion);
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Save Settings
            Properties.Settings.Default.PathToGame = textBoxPathToGame.Text;
            Properties.Settings.Default.ShowTop = this.checkBoxShowTop.Checked;

            Properties.Settings.Default.Save();

        }

        private void buttonCount_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = folderBrowserDialogGame.ShowDialog();

            folderBrowserDialogGame.Description = "Путь к игре";

            if (dialogresult == DialogResult.OK)
            {
                 textBoxPathToGame.Text = folderBrowserDialogGame.SelectedPath;
            }
        }

    }
}
