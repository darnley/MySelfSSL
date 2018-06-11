using Org.BouncyCastle.Asn1.X509;
using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Holbor.MySelfSSL.Front
{
    public partial class Main : Form
    {
        public static Status statusForm;

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
            X509Certificate2[] certificates = Certificate.GetAll(true);

            // Clear the Certificate Authority list
            comboBoxCertificateAuthorities.Items.Clear();

            // If found any certificate
            if (certificates != null)
            {
                // Add certificates to the combobox
                comboBoxCertificateAuthorities.Items.AddRange(certificates);
            }

            // If added more than 0 certificates
            if (comboBoxCertificateAuthorities.Items.Count > 0)
            {
                // Keep the first certificate selected
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

                            if (!t.IsFaulted)
                            {
                                ShowCertificateSuccessDialog();
                            }
                            else
                            {
                                AggregateException exception = t.Exception;
                                ShowCertificateErrorDialog(exception.InnerException.Message);
                            }
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
                            EnableOrDisableCertificateFields();
                            
                            if (!t.IsFaulted)
                            {
                                ShowCertificateSuccessDialog(true);
                            } else
                            {
                                AggregateException exception = t.Exception;
                                ShowCertificateErrorDialog(exception.InnerException.Message);
                            }
                        });
                    });
#pragma warning restore CS4014

                statusForm.ShowDialog(this);
            }
            catch (ArgumentException ex)
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

        private void ShowCertificateErrorDialog(string message = "There was an error creating the certificate.", string title = "Certificate Creation Error")
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                if (listBoxSAN.Items.Count == 0 || listBoxSAN.SelectedIndex == -1)
                {
                    buttonRemoveSAN.Enabled = false;
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
                buttonShowInformationCA.Enabled = true;
                buttonDeleteCA.Enabled = true;
            }
            else
            {
                groupBoxSelfSignedCertificate.Enabled = false;
                buttonShowInformationCA.Enabled = false;
                buttonDeleteCA.Enabled = false;
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

                if (listBoxSANCA.Items.Count == 0 || listBoxSANCA.SelectedIndex == -1)
                {
                    buttonRemoveSANCA.Enabled = false;
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

        private void CheckForUpdates(object sender, EventArgs e)
        {
            MySelfSSL.Update.InstallUpdateSyncWithInfo();
        }

        private void OnTypeInSAN(object sender, EventArgs e)
        {
            if (textBoxSAN.TextLength > 0)
            {
                buttonAddSAN.Enabled = true;
            }
            else
            {
                buttonAddSAN.Enabled = false;
            }
        }

        private void OnClickInASAN(object sender, EventArgs e)
        {
            if (listBoxSAN.SelectedIndex != -1)
            {
                buttonRemoveSAN.Enabled = true;
            } else
            {
                buttonRemoveSAN.Enabled = false;
            }
        }

        private void OnTypeInSANCA(object sender, EventArgs e)
        {
            if (textBoxSANCA.TextLength > 0)
            {
                buttonAddSANCA.Enabled = true;
            }
            else
            {
                buttonAddSANCA.Enabled = false;
            }
        }

        private void OnClickInASANCA(object sender, EventArgs e)
        {
            if (listBoxSANCA.SelectedIndex != -1)
            {
                buttonRemoveSANCA.Enabled = true;
            }
            else
            {
                buttonRemoveSANCA.Enabled = false;
            }
        }

        private void ShowInformationAboutSelectedCA(object sender, EventArgs e)
        {
            MessageBox.Show(Certificate.CertificateToString(comboBoxCertificateAuthorities.SelectedItem), "Certificate Authority Information");
        }

        private void DeleteSelectedCA(object sender, EventArgs e)
        {
            if (comboBoxCertificateAuthorities.SelectedIndex != -1)
            {
                DialogResult dialogResult = MessageBox.Show("BE SURE OF WHAT YOU ARE DOING!\n\nAre you sure you want to delete this Certification Authority (CA)?\nOther certificates that have been created based on it WILL BE INVALIDATED.", "Delete Certificate", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    X509Certificate2 certificateToDelete = (X509Certificate2)comboBoxCertificateAuthorities.SelectedItem;

                    Certificate.DeleteCertificate(certificateToDelete, true);

                    LoadCertificateAuthorities();
                    EnableOrDisableCertificateFields();
                }
            }
        }
    }
}
