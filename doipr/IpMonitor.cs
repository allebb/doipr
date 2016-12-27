using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace doipr
{
    public class IpMonitor
    {

        /// <summary>
        /// Instance IP address storage.
        /// </summary>
        private string address;

        /// <summary>
        /// Instantiate a new instance of this class and detect the current public IP address automatically.
        /// </summary>
        public IpMonitor()
        {
            this.detect();
        }

        /// <summary>
        /// Instantiate a new instance of this class with a specified IP address. 
        /// </summary>
        /// <param name="address"></param>
        public IpMonitor(string address)
        {
            this.address = address;
        }

        /// <summary>
        /// Retrieve the current public IP address.
        /// </summary>
        /// <returns></returns>
        public void detect()
        {
            using (var webClient = new System.Net.WebClient())
            {
                string json = webClient.DownloadString("https://api.ipify.org/?format=json");
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                IpAddress oRootObject = new IpAddress();
                oRootObject = serializer.Deserialize<IpAddress>(json);
                this.address = oRootObject.ip;
            }
        }

        /// <summary>
        /// Helper method to test if a specified IP address matches the currently detected IP address.
        /// </summary>
        /// <param name="comparedAddress">The IP address to compare against.</param>
        /// <returns></returns>
        public bool compare(string comparedAddress)
        {
            return (this.address == comparedAddress);
        }

        /// <summary>
        /// Returns the last detected IP address.
        /// </summary>
        /// <returns></returns>
        public string get()
        {
            return this.address;
        }

    }

    public class IpAddress
    {
        /// <summary>
        /// The resolved public IP address for the current internet connection.
        /// </summary>
        public string ip { get; set; }
    }
}
