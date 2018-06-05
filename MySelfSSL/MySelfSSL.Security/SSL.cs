using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Prng;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.X509;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Pkcs;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.OpenSsl;
using Org.BouncyCastle.Crypto.Parameters;
using MySelfSSL.Domain;
using System.Security.Cryptography;

namespace MySelfSSL.Security
{
    public class SSL
    {
        private SecureRandom Random;
        public CertificateAuthority CertificateAuthorityInformations { get; private set; }
        public Certificate CertificateInformations { get; private set; }
        public int KeyStrength { get; private set; }

        public SSL(CertificateAuthority ca, Certificate certificate, int keyStrength = 2048)
        {
            this.Random = new SecureRandom(new CryptoApiRandomGenerator());
            this.CertificateInformations = certificate;
            this.KeyStrength = keyStrength;

            var existingCertificate = this.GetCertificate(ca.NameWithoutCN);

            if(existingCertificate != null)
            {
                this.CertificateAuthorityInformations = new CertificateAuthority();
                this.CertificateAuthorityInformations.SetCertificate(existingCertificate);
            } else
            {
                this.CertificateAuthorityInformations = ca;
            }
        }

        public X509Certificate2 GetCertificate(string certificateFriendlyName)
        {
            X509Store store = new X509Store(StoreName.Root, StoreLocation.LocalMachine);

            store.Open(OpenFlags.ReadOnly);

            X509Certificate2 cert = store.Certificates.OfType<X509Certificate2>()
                .FirstOrDefault(x => x.FriendlyName == certificateFriendlyName);

            store.Close();

            return cert;
        }

        /// <summary>
        /// Create a self-signed certificate
        /// </summary>
        /// <param name="subjectName">Subject name (can be the hostname)</param>
        /// <param name="issuerName">Issuer name (CA)</param>
        /// <param name="issuerPrivateKey">Self-generated private key</param>
        /// <param name="keyStrength">Strength of private key</param>
        /// <returns>The certificate</returns>
        public X509Certificate2 GenerateSelfSignedCertificate(List<string> subjectAlternativeNames = null)
        {
            // Subject Public Key
            this.CertificateInformations.SetKeyPair(this.GenerateKeyPair());

            var certificateGenerator = this.GenerateGenericCertificate(this.CertificateInformations.SubjectName, this.CertificateAuthorityInformations.Name, DateTime.Now.AddYears(10), this.CertificateAuthorityInformations.KeyPair);

            // selfsign certificate
            var certificate = certificateGenerator.Generate(this.CertificateAuthorityInformations.KeyPair.Private, this.Random);

            if (true)
            {
                var san = new Asn1Encodable[]
                {
                    new GeneralName(GeneralName.DnsName, "localhost")
                };

                var subjectAlternativeNamesExtension = new DerSequence(san);
                certificateGenerator.AddExtension(X509Extensions.SubjectAlternativeName.Id, true, subjectAlternativeNamesExtension);
            }

            // correcponding private key
            PrivateKeyInfo info = PrivateKeyInfoFactory.CreatePrivateKeyInfo(this.CertificateAuthorityInformations.KeyPair.Private);

            // merge into X509Certificate2
            var x509 = new X509Certificate2(certificate.GetEncoded());

            var seq = (Asn1Sequence)Asn1Object.FromByteArray(info.ParsePrivateKey().GetDerEncoded());

            if (seq.Count != 9)
                throw new PemException("malformed sequence in RSA private key");

            var rsa = new RsaPrivateKeyStructure(seq);
            RsaPrivateCrtKeyParameters rsaparams = new RsaPrivateCrtKeyParameters(
                rsa.Modulus, rsa.PublicExponent, rsa.PrivateExponent, rsa.Prime1, rsa.Prime2, rsa.Exponent1, rsa.Exponent2, rsa.Coefficient);

            x509.PrivateKey = DotNetUtilities.ToRSA(rsaparams);
            x509.FriendlyName = this.CertificateInformations.SubjectNameWithoutCN;

            this.CertificateInformations.SetCertificate(x509);

            // Add CA certificate to Root store
            AddCertToStore(x509, StoreName.My, StoreLocation.LocalMachine);

            return x509;
        }

        /// <summary>
        /// Create a Certificate Authority
        /// </summary>
        /// <param name="subjectName">CA name</param>
        /// <param name="keyStrength">Strength of private key</param>
        /// <returns></returns>
        public X509Certificate2 GenerateCACertificate()
        {
            X509Certificate2 x509;

            if (this.CertificateAuthorityInformations.Certificate == null)
            {
                // Subject Public Key
                this.CertificateAuthorityInformations.SetKeyPair(this.GenerateKeyPair());

                var certificateGenerator = this.GenerateGenericCertificate(this.CertificateAuthorityInformations.Name, this.CertificateAuthorityInformations.Name, DateTime.Now.AddYears(10), this.CertificateAuthorityInformations.KeyPair);

                // selfsign certificate
                var certificate = certificateGenerator.Generate(this.CertificateAuthorityInformations.KeyPair.Private, this.Random);

                // correcponding private key
                PrivateKeyInfo info = PrivateKeyInfoFactory.CreatePrivateKeyInfo(this.CertificateAuthorityInformations.KeyPair.Private);

                // merge into X509Certificate2
                x509 = new X509Certificate2(certificate.GetEncoded());

                var seq = (Asn1Sequence)Asn1Object.FromByteArray(info.ParsePrivateKey().GetDerEncoded());

                if (seq.Count != 9)
                    throw new PemException("malformed sequence in RSA private key");

                var rsa = new RsaPrivateKeyStructure(seq);
                RsaPrivateCrtKeyParameters rsaparams = new RsaPrivateCrtKeyParameters(
                    rsa.Modulus, rsa.PublicExponent, rsa.PrivateExponent, rsa.Prime1, rsa.Prime2, rsa.Exponent1, rsa.Exponent2, rsa.Coefficient);

                x509.PrivateKey = DotNetUtilities.ToRSA(rsaparams);
                x509.FriendlyName = this.CertificateAuthorityInformations.NameWithoutCN;

                // Add CA certificate to Root store
                AddCertToStore(x509, StoreName.Root, StoreLocation.LocalMachine);
            } else
            {
                x509 = this.CertificateAuthorityInformations.Certificate;
            }

            return x509;
        }

        public static bool AddCertToStore(X509Certificate2 cert, StoreName st, StoreLocation sl)
        {
            bool bRet = false;

            try
            {
                X509Store store = new X509Store(st, sl);
                store.Open(OpenFlags.ReadWrite);
                store.Add(cert);

                store.Close();
            }
            catch
            {

            }

            return bRet;
        }

        private X509V3CertificateGenerator GenerateGenericCertificate(string subject, string issuer, DateTime validUntil, AsymmetricCipherKeyPair keyPair)
        {
            // The Certificate Generator
            X509V3CertificateGenerator certificateGenerator = new X509V3CertificateGenerator();

            // Serial Number
            BigInteger serialNumber = BigIntegers.CreateRandomInRange(BigInteger.One, BigInteger.ValueOf(Int64.MaxValue), this.Random);
            certificateGenerator.SetSerialNumber(serialNumber);

            // Signature Algorithm
            const string signatureAlgorithm = "SHA256WithRSA";
            certificateGenerator.SetSignatureAlgorithm(signatureAlgorithm);

            // Issuer and Subject Name
            var subjectDN = new X509Name(subject);
            var issuerDN = new X509Name(issuer);
            certificateGenerator.SetIssuerDN(issuerDN);
            certificateGenerator.SetSubjectDN(subjectDN);

            // Valid For
            var notBefore = DateTime.UtcNow.Date;
            var notAfter = validUntil;

            certificateGenerator.SetNotBefore(notBefore);
            certificateGenerator.SetNotAfter(notAfter);

            certificateGenerator.SetPublicKey(keyPair.Public);

            return certificateGenerator;
        }

        /// <summary>
        /// Generate a new random key pair (public and private key)
        /// </summary>
        /// <returns>The keys</returns>
        private AsymmetricCipherKeyPair GenerateKeyPair()
        {
            try
            {
                KeyGenerationParameters keyGenerationParameters = new KeyGenerationParameters(this.Random, this.KeyStrength);
                RsaKeyPairGenerator keyPairGenerator = new RsaKeyPairGenerator();

                keyPairGenerator.Init(keyGenerationParameters);

                AsymmetricCipherKeyPair subjectKeyPair = keyPairGenerator.GenerateKeyPair();

                return subjectKeyPair;
            } catch (Exception ex)
            {
                return null;
            }
        }
    }
}
