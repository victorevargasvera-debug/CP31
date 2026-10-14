using System;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Signers;

namespace Org.BouncyCastle.Tls.Crypto.Impl.BC
{
	// Token: 0x02000182 RID: 386
	public class BcTlsRsaPssVerifier : global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsVerifier
	{
		// Token: 0x06000EB5 RID: 3765 RVA: 0x00036293 File Offset: 0x00034493
		public BcTlsRsaPssVerifier(global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsCrypto crypto, global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters publicKey, int signatureScheme) : base(crypto, publicKey)
		{
			if (!global::Org.BouncyCastle.Tls.SignatureScheme.IsRsaPss(signatureScheme))
			{
				throw new global::System.ArgumentException("signatureScheme");
			}
			this.m_signatureScheme = signatureScheme;
		}

		// Token: 0x06000EB6 RID: 3766 RVA: 0x000362B7 File Offset: 0x000344B7
		public override bool VerifyRawSignature(global::Org.BouncyCastle.Tls.DigitallySigned signature, byte[] hash)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06000EB7 RID: 3767 RVA: 0x000362C0 File Offset: 0x000344C0
		public override global::Org.BouncyCastle.Tls.Crypto.TlsStreamVerifier GetStreamVerifier(global::Org.BouncyCastle.Tls.DigitallySigned signature)
		{
			global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm algorithm = signature.Algorithm;
			if (algorithm == null || global::Org.BouncyCastle.Tls.SignatureScheme.From(algorithm) != this.m_signatureScheme)
			{
				string str = "Invalid algorithm: ";
				global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm signatureAndHashAlgorithm = algorithm;
				throw new global::System.InvalidOperationException(str + ((signatureAndHashAlgorithm != null) ? signatureAndHashAlgorithm.ToString() : null));
			}
			int cryptoHashAlgorithm = global::Org.BouncyCastle.Tls.SignatureScheme.GetCryptoHashAlgorithm(this.m_signatureScheme);
			global::Org.BouncyCastle.Crypto.IDigest digest = this.m_crypto.CreateDigest(cryptoHashAlgorithm);
			global::Org.BouncyCastle.Crypto.Signers.PssSigner pssSigner = new global::Org.BouncyCastle.Crypto.Signers.PssSigner(new global::Org.BouncyCastle.Crypto.Engines.RsaEngine(), digest, digest.GetDigestSize());
			pssSigner.Init(false, this.m_publicKey);
			return new global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsStreamVerifier(pssSigner, signature.Signature);
		}

		// Token: 0x04000833 RID: 2099
		private readonly int m_signatureScheme;
	}
}
