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
            DOAPI api = new DOAPI(this.txtToken.Text);
            this.btnRetrieve.Enabled = false;
            this.btnRetrieve.Text = "Working...";
            this.btnRetrieve.Refresh();

            try
            {
                DomainRecords data = api.retrieveRecords(this.txtDomain.Text.ToString());

                if (data.domain_records.Count() == 0)
                {
                    MessageBox.Show("There are no \"A\" records for this domain!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                this.cbxUpdate.Enabled = true;
                foreach (Record record in data.domain_records)
                {
                    if (record.type != "A")
                        continue;
                    this.cbxUpdate.Items.Add(record);
                }

            }
            catch (System.Net.WebException execption)
            {
                MessageBox.Show("An error occured, check your DigitalOcean token and connection and try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.btnRetrieve.Text = "Retrieve";
            this.btnRetrieve.Enabled = true;
            this.btnRetrieve.Refresh();

        }

        /// <summary>
        /// Load the application settings to populate the Console form.
        /// </summary>
        private void loadConsoleSettings()
        {
            this.txtQueryInterval.Text = ServiceSettings.config()["queryInterval"];
            this.txtLastUpdatedAt.Text = ServiceSettings.config()["queryLast"];
            this.txtCurrentAddress.Text = ServiceSettings.config()["currentAddress"];
            this.txtToken.Text = ServiceSettings.config()["doToken"];
            this.txtDomain.Text = ServiceSettings.config()["doDomain"];
        }

        /// <summary>
        /// Saves the application settings.
        /// </summary>
        private void saveConsoleSettings()
        {

            // Convert text to interger value and multiple 

            ServiceSettings.set("queryInterval", txtQueryInterval.Text);
            ServiceSettings.set("doToken", this.txtToken.Text);
            ServiceSettings.set("doDomain", this.txtDomain.Text);

            if (this.cbxUpdate.Enabled)
            {
                // Update the domain record name and ID.
                ServiceSettings.set("doRecordName", this.cbxUpdate.SelectedItem.ToString());

                // Lookup the Record ID.
                

                // @todo - Get the record ID from the name.
                ServiceSettings.set("doRecordId", "7843632");
            }

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


        /// <summary>
        /// Handles the domain record drop-down selection action.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
