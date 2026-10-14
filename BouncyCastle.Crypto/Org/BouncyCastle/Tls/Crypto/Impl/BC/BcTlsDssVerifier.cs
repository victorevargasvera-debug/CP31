using System;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Signers;

namespace Org.BouncyCastle.Tls.Crypto.Impl.BC
{
	// Token: 0x02000172 RID: 370
	public abstract class BcTlsDssVerifier : global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsVerifier
	{
		// Token: 0x06000E76 RID: 3702 RVA: 0x000359B0 File Offset: 0x00033BB0
		protected BcTlsDssVerifier(global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsCrypto crypto, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter publicKey) : base(crypto, publicKey)
		{
		}

		// Token: 0x06000E77 RID: 3703
		protected abstract global::Org.BouncyCastle.Crypto.IDsa CreateDsaImpl(int cryptoHashAlgorithm);

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x06000E78 RID: 3704
		protected abstract short SignatureAlgorithm { get; }

		// Token: 0x06000E79 RID: 3705 RVA: 0x000359BC File Offset: 0x00033BBC
		public override bool VerifyRawSignature(global::Org.BouncyCastle.Tls.DigitallySigned signedParams, byte[] hash)
		{
			global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm algorithm = signedParams.Algorithm;
			if (algorithm != null && algorithm.Signature != this.SignatureAlgorithm)
			{
				string str = "Invalid algorithm: ";
				global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm signatureAndHashAlgorithm = algorithm;
				throw new global::System.InvalidOperationException(str + ((signatureAndHashAlgorithm != null) ? signatureAndHashAlgorithm.ToString() : null));
			}
			int cryptoHashAlgorithm = (algorithm == null) ? 2 : global::Org.BouncyCastle.Tls.Crypto.TlsCryptoUtilities.GetHash(algorithm.Hash);
			global::Org.BouncyCastle.Crypto.ISigner signer = new global::Org.BouncyCastle.Crypto.Signers.DsaDigestSigner(this.CreateDsaImpl(cryptoHashAlgorithm), new global::Org.BouncyCastle.Crypto.Digests.NullDigest());
			signer.Init(false, this.m_publicKey);
			if (algorithm == null)
			{
				signer.BlockUpdate(hash, 16, 20);
			}
			else
			{
				signer.BlockUpdate(hash, 0, hash.Length);
			}
			return signer.VerifySignature(signedParams.Signature);
		}
	}
}
