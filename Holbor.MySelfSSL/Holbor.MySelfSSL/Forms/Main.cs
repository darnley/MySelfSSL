using Org.BouncyCastle.Asn1.X509;
using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
            LoadCertificateAuthorities();
            EnableOrDisableCertificateFields();

            comboBoxCertificateAuthorities.DisplayMember = "FriendlyName";
        }

        private void LoadCertificateAuthorities()
        {
            var certificates = Certificate.GetAll(true);

            comboBoxCertificateAuthorities.Items.Clear();

            if (certificates != null)
            {
                comboBoxCertificateAuthorities.Items.AddRange(certificates);
            }

            if (comboBoxCertificateAuthorities.Items.Count > 0)
            {
                comboBoxCertificateAuthorities.SelectedIndex = 0;
            }
        }

        private void CreateCertificate(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxCommonName.Text))
                {
                    throw new MissingFieldException("Common name is required.");
                }

                if (listBoxSAN.Items.Count == 0)
                {
                    DialogResult result = MessageBox.Show("Do you REALLY want to leave SAN empty? It will be required for web certificates.", "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.No)
                    {
                        return;
                    }
                }

                statusForm = new Status();
                statusForm.ChangeLoadingText("Creating certificate...");

                string certificateSubject = textBoxCommonName.Text;

                if (checkBoxWildcardToCommonName.Checked)
                {
                    certificateSubject = "*" + certificateSubject;
                }

                X509Certificate2 selectedCertificateAuthority = (X509Certificate2)comboBoxCertificateAuthorities.SelectedItem;
                string[] subjectAlternativeNames = listBoxSAN.Items.OfType<string>().ToArray();

                Task createCertificateTask = new Task(() => Certificate.CreateCertificate(certificateSubject, selectedCertificateAuthority, subjectAlternativeNames, new[] { KeyPurposeID.IdKPServerAuth }));

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
                            LoadCertificateAuthorities();
                        });
                    });
#pragma warning restore CS4014

                statusForm.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Format error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreateCertificateAuthority(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(textBoxCommonNameCA.Text))
                {
                    throw new MissingFieldException("Common Name (CN) is required.");
                }

                statusForm = new Status();
                statusForm.ChangeLoadingText("Creating CA certificate...");
                string commonName = String.Format("MySelfSSL {0}", textBoxCommonNameCA.Text);
                string[] subjectAlternativeNames = listBoxSAN.Items.OfType<string>().ToArray();

                Task createCertificateTask = new Task(() => Certificate.CreateCACertificate(commonName, subjectAlternativeNames, null));

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
                            LoadCertificateAuthorities();
                            ShowCertificateSuccessDialog(true);
                        });
                    });
#pragma warning restore CS4014

                statusForm.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Format error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowCertificateSuccessDialog(bool isCertificateAuthorityCertificate = false)
        {
            string message = "Certificate successfully created!";

            if (isCertificateAuthorityCertificate)
            {
                message = "CA " + message;
            }

            MessageBox.Show(message, "Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void RefreshCertificateAuthorities(object sender, EventArgs e)
        {
            LoadCertificateAuthorities();
            EnableOrDisableCertificateFields();
        }

        private void AddSAN(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxSAN.Text))
            {
                listBoxSAN.Items.Add(textBoxSAN.Text);
                textBoxSAN.Focus();
                textBoxSAN.SelectAll();
            }
        }

        private void RemoveSAN(object sender, EventArgs e)
        {
            if (listBoxSAN.SelectedIndex != -1)
            {
                ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(listBoxSAN);
                selectedItems = listBoxSAN.SelectedItems;

                for (int i = selectedItems.Count - 1; i >= 0; i--)
                {
                    listBoxSAN.Items.Remove(selectedItems[i]);
                } 
            }
        }

        private void CertificateAuthoritySizeChanged(object sender, EventArgs e)
        {
            
        }

        private void EnableOrDisableCertificateFields()
        {
            if (comboBoxCertificateAuthorities.Items.Count > 0)
            {
                groupBoxSelfSignedCertificate.Enabled = true;
            }
            else
            {
                groupBoxSelfSignedCertificate.Enabled = false;
                tabControl1.SelectedIndex = 1;
                buttonCreateCertificateCA.Focus();
            }
        }

        private void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OpenAboutWindow(object sender, EventArgs e)
        {
            About aboutWindow = new About();

            aboutWindow.ShowDialog(this);
        }

        private void AddSANCertificateAuthority(object sender, EventArgs e)
        {
            if (listBoxSANCA.Items.Contains(textBoxSANCA.Text))
            {
                MessageBox.Show("This Subject Alternative Name (SAN) alterady exists on this context.", "Already added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!string.IsNullOrWhiteSpace(textBoxSANCA.Text))
            {
                listBoxSANCA.Items.Add(textBoxSANCA.Text);
                textBoxSANCA.Focus();
                textBoxSANCA.SelectAll();
            }
        }

        private void RemoveSANCertificateAuthority(object sender, EventArgs e)
        {
            if (listBoxSANCA.SelectedIndex != -1)
            {
                ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(listBoxSANCA);
                selectedItems = listBoxSANCA.SelectedItems;

                for (int i = selectedItems.Count - 1; i >= 0; i--)
                {
                    listBoxSANCA.Items.Remove(selectedItems[i]);
                }
            }
        }

        private void OnTypeInCommonName(object sender, EventArgs e)
        {
            if (textBoxCommonName.TextLength > 0)
            {
                buttonCreateCertificate.Enabled = true;
            }
            else
            {
                buttonCreateCertificate.Enabled = false;
            }
        }

        private void OnTypeInCommonNameCA(object sender, EventArgs e)
        {
            if (textBoxCommonNameCA.TextLength > 0)
            {
                buttonCreateCertificateCA.Enabled = true;
            } else
            {
                buttonCreateCertificateCA.Enabled = false;
            }
        }

        private void ShowDefaultPasswordInMessageBox(object sender, EventArgs e)
        {
            MessageBox.Show("The default password for MMC exportation is: \n\npassword", "Default password", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void OnClickInCommonName(object sender, EventArgs e)
        {
            if (textBoxCommonName.Text.Equals("MySelfSSL Local Development"))
            {
                textBoxCommonName.SelectAll();
            }
        }
    }
}
