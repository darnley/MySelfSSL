using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Prng;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Pkcs;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.X509;
using X509Certificate2 = System.Security.Cryptography.X509Certificates.X509Certificate2;
using X509KeyStorageFlags = System.Security.Cryptography.X509Certificates.X509KeyStorageFlags;
using X509ContentType = System.Security.Cryptography.X509Certificates.X509ContentType;
using System.Security.Cryptography.X509Certificates;
using Org.BouncyCastle.Crypto.Operators;

namespace Holbor.MySelfSSL
{
    /// <summary>
    /// Manipulate X509 certificates
    /// </summary>
    static class Certificate
    {
        /// <summary>
        /// Create a new certificate and certificate of Certificate Authority (CA)
        /// </summary>
        /// <param name="issuedSubject"></param>
        /// <param name="issuerSubject"></param>
        public static void CreateCertificate(string subjectName, X509Certificate2 issuerCertificate, string[] subjectAlternativeNames, KeyPurposeID[] usages)
        {
            // Search for existent certificate with provided name
            X509Certificate2 certificate = FindCertificateBySubject(subjectName, false); 

            // If not found a certificate with provided name
            if (certificate == null)
            {
                // Issue a certificate with provided parameters
                certificate = IssueCertificate(subjectName, issuerCertificate, subjectAlternativeNames, usages);

                // Add the certificate to the computer
                AddCertToStore(certificate, StoreName.My, StoreLocation.LocalMachine);
            }
            else
            {
                throw new ArgumentException("A certificate with this Common Name (CN) already exists.\nPlease choose another Common Name (CN) for better identification.");
            }
        }

        /// <summary>
        /// Create a certificate for Certificate Authority (CA)
        /// </summary>
        /// <param name="subjectName">Certificate Authority Subject DN</param>
        /// <param name="subjectAlternativeNames">The Subject Alternative Names (SAN)</param>
        /// <param name="usages">The purpose of that certificate</param>
        /// <returns></returns>
        public static void CreateCACertificate(string subjectName, string[] subjectAlternativeNames, KeyPurposeID[] usages)
        {
            // Search for existent certificate with provided name
            X509Certificate2 certificateCA = FindCertificateBySubject(subjectName, true);

            // If not found a certificate with provided name
            if (certificateCA == null)
            {
                // Issue a certificate with provided parameters
                certificateCA = CreateCertificateAuthorityCertificate(subjectName, null, null);

                // Add the certificate to the computer
                AddCertToStore(certificateCA, StoreName.Root, StoreLocation.LocalMachine);
            } else
            {
                throw new ArgumentException("A certificate with this Common Name (CN) already exists.\nPlease choose another Common Name (CN) for better identification.");
            }
        }

        /// <summary>
        /// Load an existent certificate by full path
        /// </summary>
        /// <param name="issuerFileName">Full path to the certificate</param>
        /// <param name="password">Exportation password to the certificate</param>
        /// <returns>The certificate</returns>
        private static X509Certificate2 LoadCertificate(string issuerFileName, string password)
        {
            // We need to pass 'Exportable', otherwise we can't get the private key.
            var issuerCertificate = new X509Certificate2(issuerFileName, password, X509KeyStorageFlags.Exportable);

            return issuerCertificate;
        }

        /// <summary>
        /// Create a new certificate based on a existent issuer
        /// </summary>
        /// <param name="subjectName">Self-Signed Certificate Subject DN</param>
        /// <param name="issuerCertificate">The issuer certificate</param>
        /// <param name="subjectAlternativeNames">The Subject Alternative Names (SAN). It is required if you want to use the certificate for web</param>
        /// <param name="usages">The purpose of that certificate</param>
        /// <returns></returns>
        private static X509Certificate2 IssueCertificate(string subjectName, X509Certificate2 issuerCertificate, string[] subjectAlternativeNames, KeyPurposeID[] usages)
        {
            // It's self-signed, so these are the same.
            var issuerName = issuerCertificate.Subject.Substring(3, issuerCertificate.Subject.Length-3);

            var random = GetSecureRandom();
            var subjectKeyPair = GenerateKeyPair(random, 2048);

            var issuerKeyPair = DotNetUtilities.GetKeyPair(issuerCertificate.PrivateKey);

            var serialNumber = GenerateSerialNumber(random);
            var issuerSerialNumber = new BigInteger(issuerCertificate.GetSerialNumber());

            const bool isCertificateAuthority = false;
            var certificate = GenerateCertificate(random, subjectName, subjectKeyPair, serialNumber,
                                                  subjectAlternativeNames, issuerName, issuerKeyPair,
                                                  issuerSerialNumber, isCertificateAuthority,
                                                  usages);
            return ConvertCertificate(certificate, subjectKeyPair, random);
        }
        

        /// <summary>
        /// Create a certificate for Certificate Authority (CA)
        /// </summary>
        /// <param name="subjectName">Certificate Authority Subject DN</param>
        /// <param name="subjectAlternativeNames">The Subject Alternative Names (SAN)</param>
        /// <param name="usages">The purpose of that certificate</param>
        /// <returns></returns>
        private static X509Certificate2 CreateCertificateAuthorityCertificate(string subjectName, string[] subjectAlternativeNames, KeyPurposeID[] usages)
        {
            // It's self-signed, so these are the same.
            var issuerName = subjectName;

            var random = GetSecureRandom();
            var subjectKeyPair = GenerateKeyPair(random, 2048);

            // It's self-signed, so these are the same.
            var issuerKeyPair = subjectKeyPair;

            var serialNumber = GenerateSerialNumber(random);
            var issuerSerialNumber = serialNumber; // Self-signed, so it's the same serial number.

            const bool isCertificateAuthority = true;
            var certificate = GenerateCertificate(random, subjectName, subjectKeyPair, serialNumber,
                                                  subjectAlternativeNames, issuerName, issuerKeyPair,
                                                  issuerSerialNumber, isCertificateAuthority,
                                                  usages);
            return ConvertCertificate(certificate, subjectKeyPair, random);
        }

        /// <summary>
        /// Create a new certificate without an Certificate Authority (CA)
        /// </summary>
        /// <param name="subjectName">The certificate Subject DN</param>
        /// <param name="subjectAlternativeNames">The Subject Alternative Names (SAN). It is required if you want to use that for web.</param>
        /// <param name="usages">The purpose of that certificate</param>
        /// <returns></returns>
        private static X509Certificate2 CreateSelfSignedCertificate(string subjectName, string[] subjectAlternativeNames, KeyPurposeID[] usages)
        {
            // It's self-signed, so these are the same.
            var issuerName = subjectName;

            var random = GetSecureRandom();
            var subjectKeyPair = GenerateKeyPair(random, 2048);

            // It's self-signed, so these are the same.
            var issuerKeyPair = subjectKeyPair;

            var serialNumber = GenerateSerialNumber(random);
            var issuerSerialNumber = serialNumber; // Self-signed, so it's the same serial number.

            const bool isCertificateAuthority = false;
            var certificate = GenerateCertificate(random, subjectName, subjectKeyPair, serialNumber,
                                                  subjectAlternativeNames, issuerName, issuerKeyPair,
                                                  issuerSerialNumber, isCertificateAuthority,
                                                  usages);
            return ConvertCertificate(certificate, subjectKeyPair, random);
        }

        /// <summary>
        /// Generate a new secure random string
        /// </summary>
        /// <returns>Random string</returns>
        private static SecureRandom GetSecureRandom()
        {
            // Since we're on Windows, we'll use the CryptoAPI one (on the assumption
            // that it might have access to better sources of entropy than the built-in
            // Bouncy Castle ones):
            var randomGenerator = new CryptoApiRandomGenerator();
            var random = new SecureRandom(randomGenerator);
            return random;
        }

        /// <summary>
        /// Generate a new generic certificate
        /// </summary>
        /// <param name="random">The random string</param>
        /// <param name="subjectName">The certificate Subject DN</param>
        /// <param name="subjectKeyPair">The certificate key pair (public and private key)</param>
        /// <param name="subjectSerialNumber">The certificate serial number</param>
        /// <param name="subjectAlternativeNames">The certificate Subject Alternative Names (SAN)</param>
        /// <param name="issuerName">The issuer's name of that certificate</param>
        /// <param name="issuerKeyPair">The issuer's key pair of that certificate</param>
        /// <param name="issuerSerialNumber">The issuer's serial number of that certificate</param>
        /// <param name="isCertificateAuthority">Is it a certificate authority?</param>
        /// <param name="usages">The purpose of that certificate</param>
        /// <returns>The certificate</returns>
        private static Org.BouncyCastle.X509.X509Certificate GenerateCertificate(SecureRandom random,
                                                           string subjectName,
                                                           AsymmetricCipherKeyPair subjectKeyPair,
                                                           BigInteger subjectSerialNumber,
                                                           string[] subjectAlternativeNames,
                                                           string issuerName,
                                                           AsymmetricCipherKeyPair issuerKeyPair,
                                                           BigInteger issuerSerialNumber,
                                                           bool isCertificateAuthority,
                                                           KeyPurposeID[] usages)
        {
            var certificateGenerator = new X509V3CertificateGenerator();

            certificateGenerator.SetSerialNumber(subjectSerialNumber);

            // Set the signature algorithm. This is used to generate the thumbprint which is then signed
            // with the issuer's private key. We'll use SHA-256, which is (currently) considered fairly strong.
            const string signatureAlgorithm = "SHA256WithRSA";

            // Not needed if Generate used with an ISignatureFactory
            // certificateGenerator.SetSignatureAlgorithm(signatureAlgorithm);

            var issuerDN = new X509Name(string.Format("CN={0}", issuerName));
            certificateGenerator.SetIssuerDN(issuerDN);

            // Note: The subject can be omitted if you specify a subject alternative name (SAN).
            var subjectDN = new X509Name(string.Format("CN={0}", subjectName));
            certificateGenerator.SetSubjectDN(subjectDN);

            // Our certificate needs valid from/to values.
            var notBefore = DateTime.UtcNow;
            var notAfter = notBefore.AddYears(2);

            certificateGenerator.SetNotBefore(notBefore);
            certificateGenerator.SetNotAfter(notAfter);

            // The subject's public key goes in the certificate.
            certificateGenerator.SetPublicKey(subjectKeyPair.Public);

            AddAuthorityKeyIdentifier(certificateGenerator, issuerDN, issuerKeyPair, issuerSerialNumber);
            AddSubjectKeyIdentifier(certificateGenerator, subjectKeyPair);
            AddBasicConstraints(certificateGenerator, isCertificateAuthority);

            if (usages != null && usages.Any())
                AddExtendedKeyUsage(certificateGenerator, usages);

            if (subjectAlternativeNames != null && subjectAlternativeNames.Any())
                AddSubjectAlternativeNames(certificateGenerator, subjectAlternativeNames);

            ISignatureFactory signatureFactory = new Asn1SignatureFactory(signatureAlgorithm, issuerKeyPair.Private, random);

            // The certificate is signed with the issuer's private key.
            var certificate = certificateGenerator.Generate(signatureFactory);
            return certificate;
        }

        /// <summary>
        /// The certificate needs a serial number. This is used for revocation,
        /// and usually should be an incrementing index (which makes it easier to revoke a range of certificates).
        /// Since we don't have anywhere to store the incrementing index, we can just use a random number.
        /// </summary>
        /// <param name="random"></param>
        /// <returns></returns>
        private static BigInteger GenerateSerialNumber(SecureRandom random)
        {
            var serialNumber =
                BigIntegers.CreateRandomInRange(
                    BigInteger.One, BigInteger.ValueOf(Int64.MaxValue), random);
            return serialNumber;
        }

        /// <summary>
        /// Generate a key pair.
        /// </summary>
        /// <param name="random">The random number generator.</param>
        /// <param name="strength">The key length in bits. For RSA, 2048 bits should be considered the minimum acceptable these days.</param>
        /// <returns></returns>
        private static AsymmetricCipherKeyPair GenerateKeyPair(SecureRandom random, int strength)
        {
            var keyGenerationParameters = new KeyGenerationParameters(random, strength);

            var keyPairGenerator = new RsaKeyPairGenerator();
            keyPairGenerator.Init(keyGenerationParameters);
            var subjectKeyPair = keyPairGenerator.GenerateKeyPair();
            return subjectKeyPair;
        }

        /// <summary>
        /// Add the Authority Key Identifier. According to http://www.alvestrand.no/objectid/2.5.29.35.html, this
        /// identifies the public key to be used to verify the signature on this certificate.
        /// In a certificate chain, this corresponds to the "Subject Key Identifier" on the *issuer* certificate.
        /// The Bouncy Castle documentation, at http://www.bouncycastle.org/wiki/display/JA1/X.509+Public+Key+Certificate+and+Certification+Request+Generation,
        /// shows how to create this from the issuing certificate. Since we're creating a self-signed certificate, we have to do this slightly differently.
        /// </summary>
        /// <param name="certificateGenerator"></param>
        /// <param name="issuerDN"></param>
        /// <param name="issuerKeyPair"></param>
        /// <param name="issuerSerialNumber"></param>
        private static void AddAuthorityKeyIdentifier(X509V3CertificateGenerator certificateGenerator,
                                                      X509Name issuerDN,
                                                      AsymmetricCipherKeyPair issuerKeyPair,
                                                      BigInteger issuerSerialNumber)
        {
            var authorityKeyIdentifierExtension =
                new AuthorityKeyIdentifier(
                    SubjectPublicKeyInfoFactory.CreateSubjectPublicKeyInfo(issuerKeyPair.Public),
                    new GeneralNames(new GeneralName(issuerDN)),
                    issuerSerialNumber);
            certificateGenerator.AddExtension(
                X509Extensions.AuthorityKeyIdentifier.Id, false, authorityKeyIdentifierExtension);
        }

        /// <summary>
        /// Add the "Subject Alternative Names" extension. Note that you have to repeat
        /// the value from the "Subject Name" property.
        /// </summary>
        /// <param name="certificateGenerator"></param>
        /// <param name="subjectAlternativeNames"></param>
        private static void AddSubjectAlternativeNames(X509V3CertificateGenerator certificateGenerator,
                                                       IEnumerable<string> subjectAlternativeNames)
        {
            var subjectAlternativeNamesExtension =
                new DerSequence(
                    subjectAlternativeNames.Select(name => new GeneralName(GeneralName.DnsName, name))
                                           .ToArray<Asn1Encodable>());

            certificateGenerator.AddExtension(
                X509Extensions.SubjectAlternativeName.Id, false, subjectAlternativeNamesExtension);
        }

        /// <summary>
        /// Add the "Extended Key Usage" extension, specifying (for example) "server authentication".
        /// </summary>
        /// <param name="certificateGenerator"></param>
        /// <param name="usages"></param>
        private static void AddExtendedKeyUsage(X509V3CertificateGenerator certificateGenerator, KeyPurposeID[] usages)
        {
            certificateGenerator.AddExtension(
                X509Extensions.ExtendedKeyUsage.Id, false, new ExtendedKeyUsage(usages));
        }

        /// <summary>
        /// Add the "Basic Constraints" extension.
        /// </summary>
        /// <param name="certificateGenerator"></param>
        /// <param name="isCertificateAuthority"></param>
        private static void AddBasicConstraints(X509V3CertificateGenerator certificateGenerator,
                                                bool isCertificateAuthority)
        {
            certificateGenerator.AddExtension(
                X509Extensions.BasicConstraints.Id, true, new BasicConstraints(isCertificateAuthority));
        }

        /// <summary>
        /// Add the Subject Key Identifier.
        /// </summary>
        /// <param name="certificateGenerator"></param>
        /// <param name="subjectKeyPair"></param>
        private static void AddSubjectKeyIdentifier(X509V3CertificateGenerator certificateGenerator,
                                                    AsymmetricCipherKeyPair subjectKeyPair)
        {
            var subjectKeyIdentifierExtension =
                new SubjectKeyIdentifier(
                    SubjectPublicKeyInfoFactory.CreateSubjectPublicKeyInfo(subjectKeyPair.Public));
            certificateGenerator.AddExtension(
                X509Extensions.SubjectKeyIdentifier.Id, false, subjectKeyIdentifierExtension);
        }

        /// <summary>
        /// Convert from X509Certificate to X509Certificate2
        /// </summary>
        /// <param name="certificate">The X509Certificate certificate</param>
        /// <param name="subjectKeyPair">The X509Certificate key pair</param>
        /// <param name="random">An random secure string</param>
        /// <returns>The X509Certificate2 certificate</returns>
        private static X509Certificate2 ConvertCertificate(Org.BouncyCastle.X509.X509Certificate certificate,
                                                           AsymmetricCipherKeyPair subjectKeyPair,
                                                           SecureRandom random)
        {
            // Now to convert the Bouncy Castle certificate to a .NET certificate.
            // See http://web.archive.org/web/20100504192226/http://www.fkollmann.de/v2/post/Creating-certificates-using-BouncyCastle.aspx
            var store = new Pkcs12Store();

            // What Bouncy Castle calls "alias" is the same as what Windows terms the "friendly name".
            string friendlyName = certificate.SubjectDN.ToString().Substring(3, certificate.SubjectDN.ToString().Length-3);

            // Add the certificate.
            var certificateEntry = new X509CertificateEntry(certificate);
            store.SetCertificateEntry(friendlyName, certificateEntry);

            // Add the private key.
            store.SetKeyEntry(friendlyName, new AsymmetricKeyEntry(subjectKeyPair.Private), new[] { certificateEntry });

            // Convert it to an X509Certificate2 object by saving/loading it from a MemoryStream.
            // It needs a password. Since we'll remove this later, it doesn't particularly matter what we use.
            const string password = "password";
            var stream = new MemoryStream();
            store.Save(stream, password.ToCharArray(), random);

            var convertedCertificate =
                new X509Certificate2(stream.ToArray(),
                                     password,
                                     X509KeyStorageFlags.PersistKeySet | X509KeyStorageFlags.Exportable);
            return convertedCertificate;
        }

        /// <summary>
        /// Get all certificates with "MySelfSSL" prefix
        /// </summary>
        /// <param name="isCertificateAuthority"></param>
        /// <returns>Found certificates</returns>
        public static X509Certificate2[] GetAll(bool isCertificateAuthority = false)
        {
            X509Certificate2[] certs;
            X509Store certStore;

            if (isCertificateAuthority)
            {
                // Get certificates from Certificate Authorities store root
                certStore = new X509Store(StoreName.Root, StoreLocation.LocalMachine);
            }
            else
            {
                // Get certificates from Personal certificates root
                certStore = new X509Store(StoreName.My, StoreLocation.CurrentUser);
            }
            
            // Load the certificate list
            certStore.Open(OpenFlags.ReadOnly);

            // Search for certificates with "MySelfSSL" prefix
            certs = certStore.Certificates.OfType<X509Certificate2>().Where(x => x.Subject.StartsWith("CN=MySelfSSL")).OrderBy(y => y.NotBefore).ToArray();

            // Close the certificate list
            certStore.Close();

            // If found any certificate
            if (certs.Count() > 0)
            {
                return certs;
            }

            return null;
        }

        /// <summary>
        /// Delete a provided certificate
        /// </summary>
        /// <param name="certificateToDelete">The certificate to delete</param>
        /// <param name="isCertificateAuthority">Is it an Certificate Authority?</param>
        public static void DeleteCertificate(X509Certificate2 certificateToDelete, bool isCertificateAuthority = false)
        {
            X509Store certStore;

            if (isCertificateAuthority)
            {
                // Get certificates from Certificate Authorities store root
                certStore = new X509Store(StoreName.Root, StoreLocation.LocalMachine);
            }
            else
            {
                // Get certificates from Personal certificates root
                certStore = new X509Store(StoreName.My, StoreLocation.LocalMachine);
            }

            // Load the certificate list with WRITE permission (BE CAREFUL!)
            certStore.Open(OpenFlags.ReadWrite);

            // Remove the certificate from list
            certStore.Remove(certificateToDelete);

            // Close the certificate list
            certStore.Close();
        }

        /// <summary>
        /// Convert the certificate data to string with lines
        /// </summary>
        /// <param name="certificate">The certificate</param>
        /// <returns>The certificate as string</returns>
        public static string CertificateToString(object certificate)
        {
            return string.Join(", ", certificate);
        }

        /// <summary>
        /// Find an existent certificate by yours subject
        /// </summary>
        /// <param name="certificateSubject">The certificate subject</param>
        /// <param name="isCertificateAuthority">Is it a Certificate Authority?</param>
        /// <returns>The first found certificate</returns>
        public static X509Certificate2 FindCertificateBySubject(string certificateSubject, bool isCertificateAuthority = false)
        {
            X509Certificate2 cert;
            X509Store certStore;

            if (isCertificateAuthority)
            {
                // Get certificates from Certificate Authorities store root
                certStore = new X509Store(StoreName.Root, StoreLocation.LocalMachine);
            } else
            {
                // Get certificates from Personal certificates root
                certStore = new X509Store(StoreName.My, StoreLocation.LocalMachine);
            }

            // Load the certificate list
            certStore.Open(OpenFlags.ReadOnly);

            // Search for certificates with the provided subject
            cert = certStore.Certificates.OfType<X509Certificate2>().FirstOrDefault(x => x.Subject.Equals("CN=" + certificateSubject));

            // Close the certificate list
            certStore.Close();

            if (cert != null)
            {
                return cert;
            }

            return null;
        }
        
        /// <summary>
        /// Create a new file with the certificate
        /// </summary>
        /// <param name="certificate">The certificate</param>
        /// <param name="outputFileName">The output file name</param>
        private static void WriteCertificate(X509Certificate2 certificate, string outputFileName)
        {
            // This password is the one attached to the PFX file. Use 'null' for no password.
            const string password = "password";
            var bytes = certificate.Export(X509ContentType.Pfx, password);
            File.WriteAllBytes(outputFileName, bytes);
        }

        /// <summary>
        /// Store the certificate on computer
        /// </summary>
        /// <param name="certificate"></param>
        /// <param name="storeName"></param>
        /// <param name="storeLocation"></param>
        /// <returns>Is certificate successfully stored?</returns>
        public static bool AddCertToStore(X509Certificate2 certificate, StoreName storeName, StoreLocation storeLocation)
        {
            try
            {
                // Load the store
                X509Store store = new X509Store(storeName, storeLocation);

                // Open the store with WRITE permission
                store.Open(OpenFlags.ReadWrite);

                // Add a new certificate to the store
                store.Add(certificate);

                // Close the store
                store.Close();

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
