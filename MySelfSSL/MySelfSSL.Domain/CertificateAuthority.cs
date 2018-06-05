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
    public class CertificateAuthority
    {
        public string Name { get; private set; }
        public string NameWithoutCN { get; private set; }
        public AsymmetricCipherKeyPair KeyPair { get; private set; }
        public X509Certificate2 Certificate { get; private set; }

        public CertificateAuthority()
        {
        }

        public CertificateAuthority(string issuerName)
        {
            this.Initialize(issuerName);
        }

        private void Initialize(string issuerName)
        {
            this.Name = string.Format("CN=MySelfSSL {0}", issuerName);
            this.NameWithoutCN = string.Format("MySelfSSL {0}", issuerName);
        }

        public void SetKeyPair(AsymmetricCipherKeyPair newKeyPair)
        {
            this.KeyPair = newKeyPair;
        }

        public void SetCertificate(X509Certificate2 createdCertificate)
        {
            this.Certificate = createdCertificate;

            this.Initialize(createdCertificate.FriendlyName.Replace("MySelfSSL ", ""));

            RSACryptoServiceProvider key = (RSACryptoServiceProvider)createdCertificate.PrivateKey;
            RSAParameters rsaparam = key.ExportParameters(true);

            this.SetKeyPair(DotNetUtilities.GetRsaKeyPair(rsaparam));
        }
    }
}
