using System;
using System.IO;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Pkcs
{
	// Token: 0x020001B2 RID: 434
	public class Pkcs8EncryptedPrivateKeyInfoBuilder
	{
		// Token: 0x06001076 RID: 4214 RVA: 0x00042B50 File Offset: 0x00040D50
		public Pkcs8EncryptedPrivateKeyInfoBuilder(byte[] privateKeyInfo) : this(global::Org.BouncyCastle.Asn1.Pkcs.PrivateKeyInfo.GetInstance(privateKeyInfo))
		{
		}

		// Token: 0x06001077 RID: 4215 RVA: 0x00042B5E File Offset: 0x00040D5E
		public Pkcs8EncryptedPrivateKeyInfoBuilder(global::Org.BouncyCastle.Asn1.Pkcs.PrivateKeyInfo privateKeyInfo)
		{
			this.privateKeyInfo = privateKeyInfo;
		}

		// Token: 0x06001078 RID: 4216 RVA: 0x00042B70 File Offset: 0x00040D70
		public global::Org.BouncyCastle.Pkcs.Pkcs8EncryptedPrivateKeyInfo Build(global::Org.BouncyCastle.Crypto.ICipherBuilder encryptor)
		{
			global::Org.BouncyCastle.Pkcs.Pkcs8EncryptedPrivateKeyInfo result;
			try
			{
				global::System.IO.MemoryStream bOut = new global::Org.BouncyCastle.Utilities.IO.MemoryOutputStream();
				global::Org.BouncyCastle.Crypto.ICipher cipher = encryptor.BuildCipher(bOut);
				byte[] keyData = this.privateKeyInfo.GetEncoded();
				global::System.IO.Stream stream = cipher.Stream;
				stream.Write(keyData, 0, keyData.Length);
				global::Org.BouncyCastle.Utilities.Platform.Dispose(stream);
				result = new global::Org.BouncyCastle.Pkcs.Pkcs8EncryptedPrivateKeyInfo(new global::Org.BouncyCastle.Asn1.Pkcs.EncryptedPrivateKeyInfo((global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier)encryptor.AlgorithmDetails, bOut.ToArray()));
			}
			catch (global::System.IO.IOException)
			{
				throw new global::System.InvalidOperationException("cannot encode privateKeyInfo");
			}
			return result;
		}

		// Token: 0x040008B5 RID: 2229
		private global::Org.BouncyCastle.Asn1.Pkcs.PrivateKeyInfo privateKeyInfo;
	}
}
