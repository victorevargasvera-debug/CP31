using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.X509;

namespace Org.BouncyCastle.Crypto.Operators
{
	// Token: 0x02000420 RID: 1056
	public class Asn1KeyWrapper : global::Org.BouncyCastle.Crypto.IKeyWrapper
	{
		// Token: 0x060028FE RID: 10494 RVA: 0x000ADE6C File Offset: 0x000AC06C
		public Asn1KeyWrapper(string algorithm, global::Org.BouncyCastle.X509.X509Certificate cert)
		{
			this.algorithm = algorithm;
			this.wrapper = global::Org.BouncyCastle.Crypto.Operators.KeyWrapperUtil.WrapperForName(algorithm, cert.GetPublicKey());
		}

		// Token: 0x060028FF RID: 10495 RVA: 0x000ADE8D File Offset: 0x000AC08D
		public Asn1KeyWrapper(global::Org.BouncyCastle.Asn1.DerObjectIdentifier algorithm, global::Org.BouncyCastle.X509.X509Certificate cert) : this(algorithm, cert.GetPublicKey())
		{
		}

		// Token: 0x06002900 RID: 10496 RVA: 0x000ADE9C File Offset: 0x000AC09C
		public Asn1KeyWrapper(global::Org.BouncyCastle.Asn1.DerObjectIdentifier algorithm, global::Org.BouncyCastle.Crypto.ICipherParameters key) : this(algorithm, null, key)
		{
		}

		// Token: 0x06002901 RID: 10497 RVA: 0x000ADEA7 File Offset: 0x000AC0A7
		public Asn1KeyWrapper(global::Org.BouncyCastle.Asn1.DerObjectIdentifier algorithm, global::Org.BouncyCastle.Asn1.Asn1Encodable parameters, global::Org.BouncyCastle.X509.X509Certificate cert) : this(algorithm, parameters, cert.GetPublicKey())
		{
		}

		// Token: 0x06002902 RID: 10498 RVA: 0x000ADEB8 File Offset: 0x000AC0B8
		public Asn1KeyWrapper(global::Org.BouncyCastle.Asn1.DerObjectIdentifier algorithm, global::Org.BouncyCastle.Asn1.Asn1Encodable parameters, global::Org.BouncyCastle.Crypto.ICipherParameters key)
		{
			this.algorithm = algorithm.Id;
			if (algorithm.Equals(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdRsaesOaep))
			{
				global::Org.BouncyCastle.Asn1.Pkcs.RsaesOaepParameters oaepParams = global::Org.BouncyCastle.Asn1.Pkcs.RsaesOaepParameters.GetInstance(parameters);
				global::Org.BouncyCastle.Crypto.Operators.WrapperProvider provider;
				if (oaepParams.MaskGenAlgorithm.Algorithm.Equals(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdMgf1))
				{
					global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier digAlg = global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier.GetInstance(oaepParams.MaskGenAlgorithm.Parameters);
					provider = new global::Org.BouncyCastle.Crypto.Operators.RsaOaepWrapperProvider(oaepParams.HashAlgorithm.Algorithm, digAlg.Algorithm);
				}
				else
				{
					provider = new global::Org.BouncyCastle.Crypto.Operators.RsaOaepWrapperProvider(oaepParams.HashAlgorithm.Algorithm, oaepParams.MaskGenAlgorithm.Algorithm);
				}
				this.wrapper = (global::Org.BouncyCastle.Crypto.IKeyWrapper)provider.CreateWrapper(true, key);
				return;
			}
			if (algorithm.Equals(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.RsaEncryption))
			{
				this.wrapper = new global::Org.BouncyCastle.Crypto.Operators.RsaPkcs1Wrapper(true, key);
				return;
			}
			throw new global::System.ArgumentException("unknown algorithm: " + algorithm.Id);
		}

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x06002903 RID: 10499 RVA: 0x000ADF8C File Offset: 0x000AC18C
		public object AlgorithmDetails
		{
			get
			{
				return this.wrapper.AlgorithmDetails;
			}
		}

		// Token: 0x06002904 RID: 10500 RVA: 0x000ADF99 File Offset: 0x000AC199
		public global::Org.BouncyCastle.Crypto.IBlockResult Wrap(byte[] keyData)
		{
			return this.wrapper.Wrap(keyData);
		}

		// Token: 0x0400109D RID: 4253
		private string algorithm;

		// Token: 0x0400109E RID: 4254
		private global::Org.BouncyCastle.Crypto.IKeyWrapper wrapper;
	}
}
