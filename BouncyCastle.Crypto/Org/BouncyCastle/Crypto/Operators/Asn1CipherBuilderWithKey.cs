using System;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Cms;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Operators
{
	// Token: 0x0200041C RID: 1052
	public class Asn1CipherBuilderWithKey : global::Org.BouncyCastle.Crypto.ICipherBuilderWithKey, global::Org.BouncyCastle.Crypto.ICipherBuilder
	{
		// Token: 0x060028EC RID: 10476 RVA: 0x000ADCAC File Offset: 0x000ABEAC
		public Asn1CipherBuilderWithKey(global::Org.BouncyCastle.Asn1.DerObjectIdentifier encryptionOID, int keySize, global::Org.BouncyCastle.Security.SecureRandom random)
		{
			if (random == null)
			{
				random = new global::Org.BouncyCastle.Security.SecureRandom();
			}
			global::Org.BouncyCastle.Crypto.CipherKeyGenerator keyGen = global::Org.BouncyCastle.Crypto.Utilities.CipherKeyGeneratorFactory.CreateKeyGenerator(encryptionOID, random);
			this.encKey = new global::Org.BouncyCastle.Crypto.Parameters.KeyParameter(keyGen.GenerateKey());
			this.algorithmIdentifier = global::Org.BouncyCastle.Crypto.Utilities.AlgorithmIdentifierFactory.GenerateEncryptionAlgID(encryptionOID, this.encKey.GetKey().Length * 8, random);
		}

		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x060028ED RID: 10477 RVA: 0x000ADCFE File Offset: 0x000ABEFE
		public object AlgorithmDetails
		{
			get
			{
				return this.algorithmIdentifier;
			}
		}

		// Token: 0x060028EE RID: 10478 RVA: 0x000ADD06 File Offset: 0x000ABF06
		public int GetMaxOutputSize(int inputLen)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x060028EF RID: 10479 RVA: 0x000ADD10 File Offset: 0x000ABF10
		public global::Org.BouncyCastle.Crypto.ICipher BuildCipher(global::System.IO.Stream stream)
		{
			object cipher = global::Org.BouncyCastle.Cms.EnvelopedDataHelper.CreateContentCipher(true, this.encKey, this.algorithmIdentifier);
			if (cipher is global::Org.BouncyCastle.Crypto.IStreamCipher)
			{
				cipher = new global::Org.BouncyCastle.Crypto.BufferedStreamCipher((global::Org.BouncyCastle.Crypto.IStreamCipher)cipher);
			}
			if (stream == null)
			{
				stream = new global::System.IO.MemoryStream();
			}
			return new global::Org.BouncyCastle.Crypto.Operators.BufferedCipherWrapper((global::Org.BouncyCastle.Crypto.IBufferedCipher)cipher, stream);
		}

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x060028F0 RID: 10480 RVA: 0x000ADD5A File Offset: 0x000ABF5A
		public global::Org.BouncyCastle.Crypto.ICipherParameters Key
		{
			get
			{
				return this.encKey;
			}
		}

		// Token: 0x04001096 RID: 4246
		private readonly global::Org.BouncyCastle.Crypto.Parameters.KeyParameter encKey;

		// Token: 0x04001097 RID: 4247
		private global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier algorithmIdentifier;
	}
}
