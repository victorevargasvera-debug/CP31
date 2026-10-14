using System;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Signers;

namespace Org.BouncyCastle.Tls.Crypto.Impl.BC
{
	// Token: 0x02000176 RID: 374
	public class BcTlsECDsa13Verifier : global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsVerifier
	{
		// Token: 0x06000E8B RID: 3723 RVA: 0x00035D18 File Offset: 0x00033F18
		public BcTlsECDsa13Verifier(global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsCrypto crypto, global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters publicKey, int signatureScheme) : base(crypto, publicKey)
		{
			if (!global::Org.BouncyCastle.Tls.SignatureScheme.IsECDsa(signatureScheme))
			{
				throw new global::System.ArgumentException("signatureScheme");
			}
			this.m_signatureScheme = signatureScheme;
		}

		// Token: 0x06000E8C RID: 3724 RVA: 0x00035D3C File Offset: 0x00033F3C
		public override bool VerifyRawSignature(global::Org.BouncyCastle.Tls.DigitallySigned signature, byte[] hash)
		{
			global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm algorithm = signature.Algorithm;
			if (algorithm == null || global::Org.BouncyCastle.Tls.SignatureScheme.From(algorithm) != this.m_signatureScheme)
			{
				string str = "Invalid algorithm: ";
				global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm signatureAndHashAlgorithm = algorithm;
				throw new global::System.InvalidOperationException(str + ((signatureAndHashAlgorithm != null) ? signatureAndHashAlgorithm.ToString() : null));
			}
			int cryptoHashAlgorithm = global::Org.BouncyCastle.Tls.SignatureScheme.GetCryptoHashAlgorithm(this.m_signatureScheme);
			global::Org.BouncyCastle.Crypto.Signers.DsaDigestSigner dsaDigestSigner = new global::Org.BouncyCastle.Crypto.Signers.DsaDigestSigner(new global::Org.BouncyCastle.Crypto.Signers.ECDsaSigner(new global::Org.BouncyCastle.Crypto.Signers.HMacDsaKCalculator(this.m_crypto.CreateDigest(cryptoHashAlgorithm))), new global::Org.BouncyCastle.Crypto.Digests.NullDigest());
			((global::Org.BouncyCastle.Crypto.ISigner)dsaDigestSigner).Init(false, this.m_publicKey);
			((global::Org.BouncyCastle.Crypto.ISigner)dsaDigestSigner).BlockUpdate(hash, 0, hash.Length);
			return ((global::Org.BouncyCastle.Crypto.ISigner)dsaDigestSigner).VerifySignature(signature.Signature);
		}

		// Token: 0x0400082A RID: 2090
		private readonly int m_signatureScheme;
	}
}
