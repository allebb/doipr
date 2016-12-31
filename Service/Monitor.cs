using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;

namespace DOIPR.Service
{
    public partial class Monitor : ServiceBase
    {

        /// <summary>
        /// Default state of the service worker.
        /// </summary>
        private bool running = true;

        /// <summary>
        /// Default monitor interval (in milliseconds).
        /// </summary>
        private int interval = 30000;

        /// <summary>
        /// The last known public address.
        /// </summary>
        private string lastAddress;

        /// <summary>
        /// An instance of the IP Monitor class.
        /// </summary>
        protected IpMonitor publicAddress = new IpMonitor();

        /// <summary>
        /// Constructor
        /// </summary>
        public Monitor()
        {
            InitializeComponent();

            while (true)
            {
                this.monitor();
            }
        }

        /// <summary>
        /// Handles the service "start" condition.
        /// </summary>
        /// <param name="args"></param>
        protected override void OnStart(string[] args)
        {
            this.running = true;
        }

        /// <summary>
        /// Handles the service "stop" condition.
        /// </summary>
        protected override void OnStop()
        {
            this.running = false;
        }

        /// <summary>
        /// The main monitor loop/thread sleep method.
        /// </summary>
        private void monitor()
        {
            this.process();
            Thread.Sleep(this.interval);
        }

        /// <summary>
        /// Worker invoker
        /// </summary>
        private void process()
        {

            if (!this.running)
                return;

            DOAPI doer = new DOAPI(ServiceSettings.config()["doToken"]);
            doer.retrieveRecords(ServiceSettings.config()["doDomain"]);

            // Resolve the current public IP address.
            this.publicAddress.detect();

            // Update and trigger a DO API request if the address has since changed.
            if (!this.publicAddress.compare(ServiceSettings.config()["currentAddress"]))
            {
                Logger.PushMessage("Test", "New IP address detected (" + publicAddress.get() + "), updating the DigitalOcean API.");

                // Invoke an DigitalOcean DNS Update.
                this.pushIpUpdateToDigitalOcean(this.lastAddress);
            }
        }

        /// <summary>
        /// Push DNS updates to a DigtalOcean DNS record.
        /// </summary>
        /// <param name="ipAddress"></param>
        protected void pushIpUpdateToDigitalOcean(string ipAddress)
        {
            if (!true)
            {
                Logger.PushMessage("Test", "Unable to update DigitalOcean API - Check your API credentials and try again!");
                return;
            }
            ServiceSettings.set("currentAddress", ipAddress);
        }
    }
}
