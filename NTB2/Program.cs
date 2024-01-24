using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTB2
{
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
            // Add handler for UI thread exceptions
            Application.ThreadException += new ThreadExceptionEventHandler(UIThreadException);

            // Force all WinForms errors to go through handler
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

            // This handler is for catching non-UI thread exceptions
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
            Application.Run(new frmMain());
        }


        static void UIThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            ShowExceptionDetails(e.Exception);
        }

        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            ShowExceptionDetails(e.ExceptionObject as Exception);
            Thread.CurrentThread.Suspend();
        }

        static void ShowExceptionDetails(Exception Ex)
        {
            MessageBox.Show(Ex.Message, Ex.TargetSite.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
