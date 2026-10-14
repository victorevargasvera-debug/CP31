using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.X509;

namespace Org.BouncyCastle.Crypto.Operators
{
	// Token: 0x02000421 RID: 1057
	public class Asn1KeyUnwrapper : global::Org.BouncyCastle.Crypto.IKeyUnwrapper
	{
		// Token: 0x06002905 RID: 10501 RVA: 0x000ADFA7 File Offset: 0x000AC1A7
		public Asn1KeyUnwrapper(string algorithm, global::Org.BouncyCastle.Crypto.ICipherParameters key)
		{
			this.algorithm = algorithm;
			this.wrapper = global::Org.BouncyCastle.Crypto.Operators.KeyWrapperUtil.UnwrapperForName(algorithm, key);
		}

		// Token: 0x06002906 RID: 10502 RVA: 0x000ADFC3 File Offset: 0x000AC1C3
		public Asn1KeyUnwrapper(global::Org.BouncyCastle.Asn1.DerObjectIdentifier algorithm, global::Org.BouncyCastle.Crypto.ICipherParameters key) : this(algorithm, null, key)
		{
		}

		// Token: 0x06002907 RID: 10503 RVA: 0x000ADFD0 File Offset: 0x000AC1D0
		public Asn1KeyUnwrapper(global::Org.BouncyCastle.Asn1.DerObjectIdentifier algorithm, global::Org.BouncyCastle.Asn1.Asn1Encodable parameters, global::Org.BouncyCastle.Crypto.ICipherParameters key)
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
				this.wrapper = (global::Org.BouncyCastle.Crypto.IKeyUnwrapper)provider.CreateWrapper(false, key);
				return;
			}
			if (algorithm.Equals(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.RsaEncryption))
			{
				global::Org.BouncyCastle.Asn1.Pkcs.RsaesOaepParameters oaepParams2 = global::Org.BouncyCastle.Asn1.Pkcs.RsaesOaepParameters.GetInstance(parameters);
				if (oaepParams2.MaskGenAlgorithm.Algorithm.Equals(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdMgf1))
				{
					global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier digAlg2 = global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier.GetInstance(oaepParams2.MaskGenAlgorithm.Parameters);
					new global::Org.BouncyCastle.Crypto.Operators.RsaOaepWrapperProvider(oaepParams2.HashAlgorithm.Algorithm, digAlg2.Algorithm);
				}
				else
				{
					new global::Org.BouncyCastle.Crypto.Operators.RsaOaepWrapperProvider(oaepParams2.HashAlgorithm.Algorithm, oaepParams2.MaskGenAlgorithm.Algorithm);
				}
				this.wrapper = new global::Org.BouncyCastle.Crypto.Operators.RsaPkcs1Wrapper(false, key);
				return;
			}
			throw new global::System.ArgumentException("unknown algorithm: " + algorithm.Id);
		}

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x06002908 RID: 10504 RVA: 0x000AE10A File Offset: 0x000AC30A
		public object AlgorithmDetails
		{
			get
			{
				return this.wrapper.AlgorithmDetails;
			}
		}

		// Token: 0x06002909 RID: 10505 RVA: 0x000AE117 File Offset: 0x000AC317
		public global::Org.BouncyCastle.Crypto.IBlockResult Unwrap(byte[] keyData, int offSet, int length)
		{
			return this.wrapper.Unwrap(keyData, offSet, length);
		}

		// Token: 0x0400109F RID: 4255
		private string algorithm;

		// Token: 0x040010A0 RID: 4256
		private global::Org.BouncyCastle.Crypto.IKeyUnwrapper wrapper;
	}
}
