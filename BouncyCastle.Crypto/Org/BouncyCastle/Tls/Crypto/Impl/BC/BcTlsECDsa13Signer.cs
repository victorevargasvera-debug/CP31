using System;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Signers;

namespace Org.BouncyCastle.Tls.Crypto.Impl.BC
{
	// Token: 0x02000175 RID: 373
	public class BcTlsECDsa13Signer : global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsSigner
	{
		// Token: 0x06000E89 RID: 3721 RVA: 0x00035C3F File Offset: 0x00033E3F
		public BcTlsECDsa13Signer(global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsCrypto crypto, global::Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters privateKey, int signatureScheme) : base(crypto, privateKey)
		{
			if (!global::Org.BouncyCastle.Tls.SignatureScheme.IsECDsa(signatureScheme))
			{
				throw new global::System.ArgumentException("signatureScheme");
			}
			this.m_signatureScheme = signatureScheme;
		}

		// Token: 0x06000E8A RID: 3722 RVA: 0x00035C64 File Offset: 0x00033E64
		public override byte[] GenerateRawSignature(global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm algorithm, byte[] hash)
		{
			if (algorithm == null || global::Org.BouncyCastle.Tls.SignatureScheme.From(algorithm) != this.m_signatureScheme)
			{
				throw new global::System.InvalidOperationException("Invalid algorithm: " + ((algorithm != null) ? algorithm.ToString() : null));
			}
			int cryptoHashAlgorithm = global::Org.BouncyCastle.Tls.SignatureScheme.GetCryptoHashAlgorithm(this.m_signatureScheme);
			global::Org.BouncyCastle.Crypto.ISigner signer = new global::Org.BouncyCastle.Crypto.Signers.DsaDigestSigner(new global::Org.BouncyCastle.Crypto.Signers.ECDsaSigner(new global::Org.BouncyCastle.Crypto.Signers.HMacDsaKCalculator(this.m_crypto.CreateDigest(cryptoHashAlgorithm))), new global::Org.BouncyCastle.Crypto.Digests.NullDigest());
			signer.Init(true, new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom(this.m_privateKey, this.m_crypto.SecureRandom));
			signer.BlockUpdate(hash, 0, hash.Length);
			byte[] result;
			try
			{
				result = signer.GenerateSignature();
			}
			catch (global::Org.BouncyCastle.Crypto.CryptoException e)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80, e);
			}
			return result;
		}

		// Token: 0x04000829 RID: 2089
		private readonly int m_signatureScheme;
	}
}
