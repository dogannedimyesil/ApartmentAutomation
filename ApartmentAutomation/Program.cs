﻿using ApartmentAutomation.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartmentAutomation
{
    static class Program
    {
        public static SqlHelper SqlHelper = new SqlHelper();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ApartmenAutomation());
        }
    }
}
