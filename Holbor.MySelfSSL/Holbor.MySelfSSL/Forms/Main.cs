using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Holbor.MySelfSSL.Forms
{
    public partial class Main : Form
    {
        public static Forms.Status statusForm;

        public Main()
        {
            InitializeComponent();
        }

        private void Init(object sender, EventArgs e)
        {
            var certificates = Certificate.GetAll(true);

            comboBoxCertificateAuthorities.Items.AddRange(certificates);
        }

        private async void CreateCertificateAuthority(object sender, EventArgs e)
        {
            try
            {
                statusForm = new Status();
                statusForm.ChangeLoadingText("Creating certificate...");

                string certificateAuthoritySubject = "MySelfSSL Root Development CA";

                Task createCertificateTask = new Task(() => Certificate.CreateCertificate("CN=test1", certificateAuthoritySubject));
                
                // Start the task
                createCertificateTask
                    .Start();

                // Finally
                #pragma warning disable CS4014
                createCertificateTask
                    .ContinueWith(t =>
                    {
                        Invoke((MethodInvoker)delegate
                        {
                            statusForm.Close();
                        });
                    });
                #pragma warning restore CS4014

                statusForm.ShowDialog(this);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Format error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
