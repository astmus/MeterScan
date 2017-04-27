using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using Symbol.MT2000.Utils;

namespace MeterShopScan
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [MTAThread]
        static void Main()
        {
			SystemMonitor.Start();
            Application.Run(new Form1());
			SystemMonitor.Stop();
        }
    }
}