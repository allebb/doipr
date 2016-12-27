﻿using System;
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

namespace doipr
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
            this.ticker();
            Thread.Sleep(this.interval);
        }

        /// <summary>
        /// Worker invoker
        /// </summary>
        private void ticker()
        {
            if (this.running)
            {
                this.publicAddress.detect();

                if (this.publicAddress.compare("127.0.0.1"))
                {
                    string text = "IP Address, still the same: " + this.publicAddress.get() + System.Environment.NewLine;
                    File.AppendAllText(@"C:\Users\Public\WriteText.txt", text);
                }
                else
                {
                    Logger.PushMessage("Test", "New IP address detected (" + publicAddress.get() + "), updating the DigitalOcean API.");
                }              
            }
        }
    }
}
