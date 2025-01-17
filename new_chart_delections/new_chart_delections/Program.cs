﻿using System;
using System.Windows.Forms;

namespace DataLogger
{
    static class Program
    {
        public static Network.Uart Uart = new Network.Uart();
        public static string FileName = "";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            // Get input file.
            if (args != null)
            {
                if (args.Length > 0)
                {
                    FileName = args[0];
                }
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            /* Main gui */
            Application.Run(new Layout.FrmMain());  // active main gui for first run...
        }
    }
}
