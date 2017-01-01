using System.Collections.Generic;
using Microsoft.Win32;

namespace DOIPR.Service
{

    public class ServiceSettings
    {

        /// <summary>
        /// The registry subkey to read/write the settings to/from.
        /// </summary>
        const string REGKEY = @"SOFTWARE\DOIPR";


        /// <summary>
        /// Retrieve the application settings from the settings datastore.
        /// </summary>
        /// <returns></returns>
        public static Dictionary<string, string> config()
        {

            RegistryKey rk = Registry.LocalMachine.OpenSubKey(REGKEY, true);
            if (rk == null)
            {
                rk = Registry.LocalMachine.CreateSubKey(REGKEY);
            }

            string[] keys = new string[]{
                "queryInterval",
                "queryLast",
                "doToken",
                "doDomain",
                "doRecordId",
                "doRecordName",
                "currentAddress"
            };

            Dictionary<string, string> settings = new Dictionary<string, string>();
            foreach (string setting in keys)
            {

                // Crete the key if it does not exist.
                if (rk.GetValue(setting) == null)
                {
                    set(setting, "");
                }

                // Get the value from the Registry
                string value = rk.GetValue(setting).ToString();

                // Add the key/value to our settings dictionary.
                settings.Add(setting, value);
            }      
            return settings;
        }

        /// <summary>
        /// Create/Update a setting to the datastore.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public static void set(string key, string value)
        {
            RegistryKey rk = Registry.LocalMachine.OpenSubKey(REGKEY, true);
            rk.SetValue(key, value);
        }

    }
}
