using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Nist;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto.Encodings;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Operators
{
	// Token: 0x02000426 RID: 1062
	internal class RsaOaepWrapper : global::Org.BouncyCastle.Crypto.IKeyWrapper, global::Org.BouncyCastle.Crypto.IKeyUnwrapper
	{
		// Token: 0x06002915 RID: 10517 RVA: 0x000AE30B File Offset: 0x000AC50B
		public RsaOaepWrapper(bool forWrapping, global::Org.BouncyCastle.Crypto.ICipherParameters parameters, global::Org.BouncyCastle.Asn1.DerObjectIdentifier digestOid) : this(forWrapping, parameters, digestOid, digestOid)
		{
		}

		// Token: 0x06002916 RID: 10518 RVA: 0x000AE318 File Offset: 0x000AC518
		public RsaOaepWrapper(bool forWrapping, global::Org.BouncyCastle.Crypto.ICipherParameters parameters, global::Org.BouncyCastle.Asn1.DerObjectIdentifier digestOid, global::Org.BouncyCastle.Asn1.DerObjectIdentifier mgfOid)
		{
			global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier digestAlgId = new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(digestOid, global::Org.BouncyCastle.Asn1.DerNull.Instance);
			if (mgfOid.Equals(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdShake128) || mgfOid.Equals(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdShake256))
			{
				this.algId = new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdRsaesOaep, new global::Org.BouncyCastle.Asn1.Pkcs.RsaesOaepParameters(digestAlgId, new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(mgfOid), global::Org.BouncyCastle.Asn1.Pkcs.RsaesOaepParameters.DefaultPSourceAlgorithm));
			}
			else
			{
				this.algId = new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdRsaesOaep, new global::Org.BouncyCastle.Asn1.Pkcs.RsaesOaepParameters(digestAlgId, new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdMgf1, new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(mgfOid, global::Org.BouncyCastle.Asn1.DerNull.Instance)), global::Org.BouncyCastle.Asn1.Pkcs.RsaesOaepParameters.DefaultPSourceAlgorithm));
			}
			this.engine = new global::Org.BouncyCastle.Crypto.Encodings.OaepEncoding(new global::Org.BouncyCastle.Crypto.Engines.RsaBlindedEngine(), global::Org.BouncyCastle.Security.DigestUtilities.GetDigest(digestOid), global::Org.BouncyCastle.Security.DigestUtilities.GetDigest(mgfOid), null);
			this.engine.Init(forWrapping, parameters);
		}

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x06002917 RID: 10519 RVA: 0x000AE3D3 File Offset: 0x000AC5D3
		public object AlgorithmDetails
		{
			get
			{
				return this.algId;
			}
		}

		// Token: 0x06002918 RID: 10520 RVA: 0x000AE3DB File Offset: 0x000AC5DB
		public global::Org.BouncyCastle.Crypto.IBlockResult Unwrap(byte[] cipherText, int offset, int length)
		{
			return new global::Org.BouncyCastle.Crypto.SimpleBlockResult(this.engine.ProcessBlock(cipherText, offset, length));
		}

		// Token: 0x06002919 RID: 10521 RVA: 0x000AE3F0 File Offset: 0x000AC5F0
		public global::Org.BouncyCastle.Crypto.IBlockResult Wrap(byte[] keyData)
		{
			return new global::Org.BouncyCastle.Crypto.SimpleBlockResult(this.engine.ProcessBlock(keyData, 0, keyData.Length));
		}

		// Token: 0x040010A4 RID: 4260
		private readonly global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier algId;

		// Token: 0x040010A5 RID: 4261
		private readonly global::Org.BouncyCastle.Crypto.IAsymmetricBlockCipher engine;
	}
}
