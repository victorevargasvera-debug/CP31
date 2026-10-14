using System;
using System.IO;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Pkcs
{
	// Token: 0x020001B1 RID: 433
	public class Pkcs8EncryptedPrivateKeyInfo
	{
		// Token: 0x0600106F RID: 4207 RVA: 0x00042A30 File Offset: 0x00040C30
		private static global::Org.BouncyCastle.Asn1.Pkcs.EncryptedPrivateKeyInfo parseBytes(byte[] pkcs8Encoding)
		{
			global::Org.BouncyCastle.Asn1.Pkcs.EncryptedPrivateKeyInfo instance;
			try
			{
				instance = global::Org.BouncyCastle.Asn1.Pkcs.EncryptedPrivateKeyInfo.GetInstance(pkcs8Encoding);
			}
			catch (global::System.ArgumentException e)
			{
				throw new global::Org.BouncyCastle.Pkcs.PkcsIOException("malformed data: " + e.Message, e);
			}
			catch (global::System.Exception e2)
			{
				throw new global::Org.BouncyCastle.Pkcs.PkcsIOException("malformed data: " + e2.Message, e2);
			}
			return instance;
		}

		// Token: 0x06001070 RID: 4208 RVA: 0x00042A94 File Offset: 0x00040C94
		public Pkcs8EncryptedPrivateKeyInfo(global::Org.BouncyCastle.Asn1.Pkcs.EncryptedPrivateKeyInfo encryptedPrivateKeyInfo)
		{
			this.encryptedPrivateKeyInfo = encryptedPrivateKeyInfo;
		}

		// Token: 0x06001071 RID: 4209 RVA: 0x00042AA3 File Offset: 0x00040CA3
		public Pkcs8EncryptedPrivateKeyInfo(byte[] encryptedPrivateKeyInfo) : this(global::Org.BouncyCastle.Pkcs.Pkcs8EncryptedPrivateKeyInfo.parseBytes(encryptedPrivateKeyInfo))
		{
		}

		// Token: 0x06001072 RID: 4210 RVA: 0x00042AB1 File Offset: 0x00040CB1
		public global::Org.BouncyCastle.Asn1.Pkcs.EncryptedPrivateKeyInfo ToAsn1Structure()
		{
			return this.encryptedPrivateKeyInfo;
		}

		// Token: 0x06001073 RID: 4211 RVA: 0x00042AB9 File Offset: 0x00040CB9
		public byte[] GetEncryptedData()
		{
			return this.encryptedPrivateKeyInfo.GetEncryptedData();
		}

		// Token: 0x06001074 RID: 4212 RVA: 0x00042AC6 File Offset: 0x00040CC6
		public byte[] GetEncoded()
		{
			return this.encryptedPrivateKeyInfo.GetEncoded();
		}

		// Token: 0x06001075 RID: 4213 RVA: 0x00042AD4 File Offset: 0x00040CD4
		public global::Org.BouncyCastle.Asn1.Pkcs.PrivateKeyInfo DecryptPrivateKeyInfo(global::Org.BouncyCastle.Crypto.IDecryptorBuilderProvider inputDecryptorProvider)
		{
			global::Org.BouncyCastle.Asn1.Pkcs.PrivateKeyInfo instance;
			try
			{
				global::Org.BouncyCastle.Crypto.ICipher cipher = inputDecryptorProvider.CreateDecryptorBuilder(this.encryptedPrivateKeyInfo.EncryptionAlgorithm).BuildCipher(new global::Org.BouncyCastle.Utilities.IO.MemoryInputStream(this.encryptedPrivateKeyInfo.GetEncryptedData()));
				global::System.IO.Stream strm = cipher.Stream;
				object obj = global::Org.BouncyCastle.Utilities.IO.Streams.ReadAll(cipher.Stream);
				global::Org.BouncyCastle.Utilities.Platform.Dispose(strm);
				instance = global::Org.BouncyCastle.Asn1.Pkcs.PrivateKeyInfo.GetInstance(obj);
			}
			catch (global::System.Exception e)
			{
				throw new global::Org.BouncyCastle.Pkcs.PkcsException("unable to read encrypted data: " + e.Message, e);
			}
			return instance;
		}

		// Token: 0x040008B4 RID: 2228
		private global::Org.BouncyCastle.Asn1.Pkcs.EncryptedPrivateKeyInfo encryptedPrivateKeyInfo;
	}
}
