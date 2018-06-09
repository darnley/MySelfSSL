using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;
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

            WindowsPrincipal myPrincipal = new WindowsPrincipal(WindowsIdentity.GetCurrent());
            if (myPrincipal.IsInRole(WindowsBuiltInRole.Administrator) == false)
            {
                //show messagebox - displaying a messange to the user that rights are missing
                MessageBox.Show("You need to run the application using the \"Run as administrator\" option.", "Administrator Right Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Application.Run(new Forms.Main());
            }
            
        }
    }
}
