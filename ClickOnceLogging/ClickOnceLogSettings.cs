using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.Win32;

namespace ClickOnceLogging
{
    class ClickOnceLogSettings
    {
        //This is where the values go for the ClickOnce logging, in HKEY_Current_User.
        private static string ClickOnceLoggingSubKeyName =
          @"Software\Classes\Software\Microsoft\Windows\CurrentVersion\Deployment";

        /// <summary>
        ///This is the registry value name for the log file path. 
        ///The value should be the fully-qualified path and file name of the log file.
        /// </summary>
        private static string rkName_LogFilePath = "LogFilePath";

        /// <summary>
        /// This is the registry value name for the logging level. 
        /// The value should be = 1 if you want verbose logging. 
        /// To turn off verbose logging, you can delete the entry or set it to 0.
        /// </summary>
        private static string rkName_LogVerbosityLevel = "LogVerbosityLevel";

        /// <summary>
        /// Fully-qualified path and name of the log file.
        /// </summary>
        public string LogFileLocation { get; set; }

        /// <summary>
        /// Set to true if doing verbose logging.
        /// </summary>
        public bool VerboseLogging { get; set; }

        private ClickOnceLogSettings()
        { /* NOP */ }

        /// <summary>
        /// Create a new instance of this class and get the value for the registry entries (if found).
        /// </summary>
        /// <returns>An instance of this class.</returns>
        public static ClickOnceLogSettings Create()
        {
            ClickOnceLogSettings ls = new ClickOnceLogSettings();

            //open the Deployment sub-key.
            RegistryKey rk = Registry.CurrentUser.OpenSubKey(ClickOnceLoggingSubKeyName);

            //get the values currently saved (if they exist) and set the fields on the screen accordingly
            string logLevel = rk.GetValue(rkName_LogVerbosityLevel, String.Empty).ToString();
            ls.VerboseLogging = String.Equals(logLevel, "1", StringComparison.Ordinal);
            ls.LogFileLocation = rk.GetValue(rkName_LogFilePath, String.Empty).ToString();
            return ls;
        }

        /// <summary>
        /// Save the values to the registry.
        /// </summary>
        /// <returns></returns>
        public void Save()
        {
            //Open the Deployment sub-key.
            RegistryKey rk = Registry.CurrentUser.OpenSubKey(ClickOnceLoggingSubKeyName, true);
            //Set the values associated with that sub-key.
            if (this.VerboseLogging)
                rk.SetValue(rkName_LogVerbosityLevel, "1");
            else
            {
                //check to make sure the [value] exists before trying to delete it 
                object chkVal = rk.GetValue(rkName_LogVerbosityLevel);
                if (chkVal != null)
                {
                    rk.DeleteValue(rkName_LogVerbosityLevel);
                }
            }

            if (this.LogFileLocation.Length == 0)
            {
                //check to make sure the [value] exists before trying to delete it 
                //Note: If you set the values to string.Empty instead of deleting it,
                //  it will crash the dfsvc.exe service.
                object chkPath = rk.GetValue(rkName_LogFilePath);
                if (chkPath != null)
                    rk.DeleteValue(rkName_LogFilePath);
            }
            else
            {
                rk.SetValue(rkName_LogFilePath, this.LogFileLocation);
                string logFolder = Path.GetDirectoryName(this.LogFileLocation);
                if (!Directory.Exists(logFolder))
                    Directory.CreateDirectory(logFolder);
            }
        }
    }
}
