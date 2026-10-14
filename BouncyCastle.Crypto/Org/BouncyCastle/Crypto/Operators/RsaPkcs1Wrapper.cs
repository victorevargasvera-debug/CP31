using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto.Encodings;
using Org.BouncyCastle.Crypto.Engines;

namespace Org.BouncyCastle.Crypto.Operators
{
	// Token: 0x02000424 RID: 1060
	internal class RsaPkcs1Wrapper : global::Org.BouncyCastle.Crypto.IKeyWrapper, global::Org.BouncyCastle.Crypto.IKeyUnwrapper
	{
		// Token: 0x0600290F RID: 10511 RVA: 0x000AE28C File Offset: 0x000AC48C
		public RsaPkcs1Wrapper(bool forWrapping, global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			this.algId = new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.RsaEncryption, global::Org.BouncyCastle.Asn1.DerNull.Instance);
			this.engine = new global::Org.BouncyCastle.Crypto.Encodings.Pkcs1Encoding(new global::Org.BouncyCastle.Crypto.Engines.RsaBlindedEngine());
			this.engine.Init(forWrapping, parameters);
		}

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x06002910 RID: 10512 RVA: 0x000AE2C6 File Offset: 0x000AC4C6
		public object AlgorithmDetails
		{
			get
			{
				return this.algId;
			}
		}

		// Token: 0x06002911 RID: 10513 RVA: 0x000AE2CE File Offset: 0x000AC4CE
		public global::Org.BouncyCastle.Crypto.IBlockResult Unwrap(byte[] cipherText, int offset, int length)
		{
			return new global::Org.BouncyCastle.Crypto.SimpleBlockResult(this.engine.ProcessBlock(cipherText, offset, length));
		}

		// Token: 0x06002912 RID: 10514 RVA: 0x000AE2E3 File Offset: 0x000AC4E3
		public global::Org.BouncyCastle.Crypto.IBlockResult Wrap(byte[] keyData)
		{
			return new global::Org.BouncyCastle.Crypto.SimpleBlockResult(this.engine.ProcessBlock(keyData, 0, keyData.Length));
		}

		// Token: 0x040010A2 RID: 4258
		private readonly global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier algId;

		// Token: 0x040010A3 RID: 4259
		private readonly global::Org.BouncyCastle.Crypto.IAsymmetricBlockCipher engine;
	}
}
