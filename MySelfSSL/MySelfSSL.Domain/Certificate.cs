using Org.BouncyCastle.Crypto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySelfSSL.Domain
{
    public class Certificate
    {
        public string SubjectName { get; private set; }
        public string SubjectNameWithoutCN { get; private set; }
        public AsymmetricCipherKeyPair KeyPair { get; private set; }

        public Certificate(string subjectName)
        {
            this.SubjectName = string.Format("CN={0}", subjectName);
            this.SubjectNameWithoutCN = subjectName;
        }

        public void SetKeyPair(AsymmetricCipherKeyPair newKeyPair)
        {
            this.KeyPair = newKeyPair;
        }
    }
}
