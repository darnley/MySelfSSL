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
using MySelfSSL.Security;
using MySelfSSL.Domain;

namespace MySelfSSL
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void CreateCertificate(object sender, EventArgs e)
        {
            string certificateCommonName = textBoxCN.Text;
            string authorityCommonName = textBoxAuthorityCommonName.Text;

            Certificate cert = new Certificate(certificateCommonName);
            CertificateAuthority certAuthority = new CertificateAuthority(authorityCommonName);

            SSL ssl = new SSL(certAuthority, cert);

            ssl.GenerateCACertificate();
            var certOut = ssl.GenerateSelfSignedCertificate();

            SSL.AddCertToStore(certOut, StoreName.My, StoreLocation.LocalMachine);
        }
    }
}
