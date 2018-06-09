using System;
using System.Diagnostics;
using System.Reflection;
using System.Security.Principal;
using System.Windows.Forms;

namespace Holbor.MySelfSSL
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

            bool isRunningAsAdministrator = IsRunAsAdministrator();

            if (!isRunningAsAdministrator)
            {
                if (Debugger.IsAttached)
                {
                    throw new AccessViolationException("Run Visual Studio as administrator.");
                }

                RunAsAdministrator();
            }

            if (isRunningAsAdministrator)
            {
                Application.Run(new Forms.Main());
            }
        }

        private static bool IsRunAsAdministrator()
        {
            var wi = WindowsIdentity.GetCurrent();
            var wp = new WindowsPrincipal(wi);

            return wp.IsInRole(WindowsBuiltInRole.Administrator);
        }

        private static void RunAsAdministrator()
        {
            if (!IsRunAsAdministrator())
            {
                var processInfo = new ProcessStartInfo(Assembly.GetExecutingAssembly().CodeBase)
                {
                    // The following properties run the new process as administrator
                    UseShellExecute = true,
                    Verb = "runas"
                };

                // Start the new process
                try
                {
                    Process.Start(processInfo);
                }
                catch (Exception)
                {
                    // The user did not allow the application to run as administrator
                    MessageBox.Show("Sorry, this application must be run as Administrator.");
                }

                // Shut down the current process
                Application.Exit();
            }
        }
    }
}
