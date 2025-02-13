﻿using System;
using System.Windows.Forms;
using WinFormsDashboardApp.UI.WinForm;

namespace WinFormsDashboardApp
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Dashboard());
            Application.Run(new DashboardColored());
        }
    }
}
