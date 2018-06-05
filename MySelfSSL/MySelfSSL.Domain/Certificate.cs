using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MySelfSSL.Domain
{
    public class Certificate
    {
        public string SubjectName { get; private set; }
        public string SubjectNameWithoutCN { get; private set; }
        public AsymmetricCipherKeyPair KeyPair { get; private set; }
        public X509Certificate2 CertificateEncode { get; private set; }

        public Certificate()
        {
        }

        public Certificate(string issuerName)
        {
            this.Initialize(issuerName);
        }

        private void Initialize(string issuerName)
        {
            this.SubjectName = string.Format("CN={0}", issuerName);
            this.SubjectNameWithoutCN = string.Format("{0}", issuerName);
        }

        public void SetKeyPair(AsymmetricCipherKeyPair newKeyPair)
        {
            this.KeyPair = newKeyPair;
        }

        public void SetCertificate(X509Certificate2 createdCertificate)
        {
            this.CertificateEncode = createdCertificate;

            this.Initialize(createdCertificate.FriendlyName);

            RSACryptoServiceProvider key = (RSACryptoServiceProvider)createdCertificate.PrivateKey;
            RSAParameters rsaparam = key.ExportParameters(true);

            this.SetKeyPair(DotNetUtilities.GetRsaKeyPair(rsaparam));
        }
    }
}
