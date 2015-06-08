using System;
using System.Globalization;
using System.Windows.Forms;

namespace APMeter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.TopMost = Properties.Settings.Default.ShowTop;
        }

        private void pictureBoxSettings_Click(object sender, EventArgs e)
        {
            //Settings:
            //Properties.Settings.Default.PathToGame;
            //Properties.Settings.Default.ShowTop;

            var settingsForm = new SettingsForm();
            settingsForm.ShowDialog();

            this.TopMost = Properties.Settings.Default.ShowTop;
        }

        private void buttonCount_Click(object sender, EventArgs e)
        {
            try
            {
                var apMeter = new APMeter(Properties.Settings.Default.PathToGame);
                int count = apMeter.CountAp();

                var format = (NumberFormatInfo) CultureInfo.InvariantCulture.NumberFormat.Clone();
                format.NumberGroupSeparator = " ";
                format.NumberDecimalSeparator = ",";

                string strCount = count.ToString();
                if (count > 100)
                {
                    strCount = count.ToString("0,0", format);
                }

                textBoxApCount.Text = strCount;
            }
            catch (Exception)
            {
                textBoxApCount.Text = "Error";
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            try
            {
                var apMeter = new APMeter(Properties.Settings.Default.PathToGame);
                textBoxApCount.Text = String.Empty;
                apMeter.ClearLog();
            }
            catch (Exception)
            {
                textBoxApCount.Text = "Error";
            }
        }


    }
}
