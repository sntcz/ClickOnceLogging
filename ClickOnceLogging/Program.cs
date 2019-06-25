using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ClickOnceLogging
{
    // https://robindotnet.wordpress.com/2010/05/31/enhanced-logging-in-clickonce-deployment/
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}
