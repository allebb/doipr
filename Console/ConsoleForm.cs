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

namespace Console
{
    public partial class ConsoleForm : Form
    {
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
            this.txtQueryInterval.Text = DOIPR.Service.Properties.Settings.Default.queryInterval.ToString();
            this.txtLastUpdatedAt.Text = DOIPR.Service.Properties.Settings.Default.queryLast.ToString();
            this.txtServiceStatus.Text = "Stopped!";
            this.txtToken.Text = DOIPR.Service.Properties.Settings.Default.token.ToString();
            this.txtDomain.Text = DOIPR.Service.Properties.Settings.Default.domain.ToString();
        }

        /// <summary>
        /// Saves the application settings.
        /// </summary>
        private void saveConsoleSettings()
        {
            DOIPR.Service.Properties.Settings.Default.queryInterval = this.txtQueryInterval.Text;
            DOIPR.Service.Properties.Settings.Default.queryLast = this.txtLastUpdatedAt.Text;
            DOIPR.Service.Properties.Settings.token = this.txtToken.Text;
            DOIPR.Service.Properties.Settings.domain = this.txtDomain.Text;
            DOIPR.Service.Properties.Settings.Save();
        }
    }
}
