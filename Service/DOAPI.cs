using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace DOIPR.Service
{
    public class DOAPI
    {

        const string recordsEndpoint = "https://api.digitalocean.com/v2/domains/{0}/records";

        private string token;

        public DOAPI(string token)
        {
            this.token = token;
        }

        /// <summary>
        /// Query and return the A records for the given domain.
        /// </summary>
        /// <returns></returns>
        public DomainRecords retrieveRecords(string domain)
        {

            using (var webClient = new System.Net.WebClient())
            {
                JavaScriptSerializer serializer = new JavaScriptSerializer();

                webClient.Headers.Set("Content-Type", "application/json");
                webClient.Headers.Set("Authorization", "Bearer " + this.token);

                string json = webClient.DownloadString(string.Format(recordsEndpoint, domain));

                DomainRecords records = new System.Web.Script.Serialization.JavaScriptSerializer().Deserialize<DomainRecords>(json);
                return records;
            }

        }

    }

    public class DomainRecords
    {
        /// <summary>
        /// The DNS Record entities.
        /// </summary>
        public List<Record> domain_records { get; set; }

    }

    public class Record
    {

        /// <summary>
        /// The DigitalOcean record ID (used to push updates)
        /// </summary>
        public int id;

        /// <summary>
        /// The DigitalOcean record name.
        /// </summary>
        public string name;

        /// <summary>
        /// The record "data" aka. the current IP address for the record.
        /// </summary>
        public string data;

        /// <summary>
        /// The record type.
        /// </summary>
        public string type;

        /// <summary>
        /// ToString() override for enabling easy combobox population.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.name;
        }
    }
}
