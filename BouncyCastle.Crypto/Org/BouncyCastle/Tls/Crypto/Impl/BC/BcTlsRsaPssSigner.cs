using System;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Signers;

namespace Org.BouncyCastle.Tls.Crypto.Impl.BC
{
	// Token: 0x02000181 RID: 385
	public class BcTlsRsaPssSigner : global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsSigner
	{
		// Token: 0x06000EB2 RID: 3762 RVA: 0x000361E0 File Offset: 0x000343E0
		public BcTlsRsaPssSigner(global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsCrypto crypto, global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters privateKey, int signatureScheme) : base(crypto, privateKey)
		{
			if (!global::Org.BouncyCastle.Tls.SignatureScheme.IsRsaPss(signatureScheme))
			{
				throw new global::System.ArgumentException("signatureScheme");
			}
			this.m_signatureScheme = signatureScheme;
		}

		// Token: 0x06000EB3 RID: 3763 RVA: 0x00036204 File Offset: 0x00034404
		public override byte[] GenerateRawSignature(global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm algorithm, byte[] hash)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06000EB4 RID: 3764 RVA: 0x0003620C File Offset: 0x0003440C
		public override global::Org.BouncyCastle.Tls.Crypto.TlsStreamSigner GetStreamSigner(global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm algorithm)
		{
			if (algorithm == null || global::Org.BouncyCastle.Tls.SignatureScheme.From(algorithm) != this.m_signatureScheme)
			{
				throw new global::System.InvalidOperationException("Invalid algorithm: " + ((algorithm != null) ? algorithm.ToString() : null));
			}
			int cryptoHashAlgorithm = global::Org.BouncyCastle.Tls.SignatureScheme.GetCryptoHashAlgorithm(this.m_signatureScheme);
			global::Org.BouncyCastle.Crypto.IDigest digest = this.m_crypto.CreateDigest(cryptoHashAlgorithm);
			global::Org.BouncyCastle.Crypto.Signers.PssSigner pssSigner = new global::Org.BouncyCastle.Crypto.Signers.PssSigner(new global::Org.BouncyCastle.Crypto.Engines.RsaBlindedEngine(), digest, digest.GetDigestSize());
			pssSigner.Init(true, new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom(this.m_privateKey, this.m_crypto.SecureRandom));
			return new global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsStreamSigner(pssSigner);
		}

		// Token: 0x04000832 RID: 2098
		private readonly int m_signatureScheme;
	}
}
