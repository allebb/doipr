using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DOIPR.Service;
using System.ServiceProcess;


namespace Console
{
    public partial class ConsoleForm : Form
    {

        const string SERVICENAME = "DigitalOcean IP Update Client";

        public ConsoleForm()
        {
            InitializeComponent();
            this.loadConsoleSettings();
        }

        /// <summary>
        /// Saves the form details.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            this.saveConsoleSettings();
        }

        /// <summary>
        /// Handles the API request to retrieve the A records when the "Retrieve" button is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRetrieve_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Load the application settings to populate the Console form.
        /// </summary>
        private void loadConsoleSettings()
        {
            this.txtQueryInterval.Text = (DOIPR.Service.Properties.Settings.Default.queryInterval / 1000 / 60).ToString();
            //this.txtLastUpdatedAt.Text = DOIPR.Service.Properties.Settings.Default.queryLast.ToString();
            //this.txtServiceStatus.Text = this.getServiceStatus();
            this.txtToken.Text = DOIPR.Service.Properties.Settings.Default.token.ToString();
            this.txtDomain.Text = DOIPR.Service.Properties.Settings.Default.domain.ToString();
        }

        /// <summary>
        /// Saves the application settings.
        /// </summary>
        private void saveConsoleSettings()
        {
            DOIPR.Service.Properties.Settings.Default.queryInterval = Convert.ToInt32(txtQueryInterval.Text);
            DOIPR.Service.Properties.Settings.Default.queryLast = this.txtLastUpdatedAt.Text;
            DOIPR.Service.Properties.Settings.Default.token = this.txtToken.Text;
            DOIPR.Service.Properties.Settings.Default.domain = this.txtDomain.Text;
            DOIPR.Service.Properties.Settings.Default.Save();

            MessageBox.Show("Your settings have been saved successfully!", "Settings", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        /// <summary>
        /// Retrieves the current service status.
        /// </summary>
        /// <returns></returns>
        private string getServiceStatus()
        {
            ServiceController sc = new ServiceController(SERVICENAME);

            switch (sc.Status)
            {
                case ServiceControllerStatus.Running:
                    return "Running...";
                case ServiceControllerStatus.Stopped:
                    return "Stopped!";
                case ServiceControllerStatus.Paused:
                    return "Paused";
                case ServiceControllerStatus.StopPending:
                    return "Stopping...";
                case ServiceControllerStatus.StartPending:
                    return "Starting...";
                default:
                    return "Status Changing";
            }
        }
    }
}
