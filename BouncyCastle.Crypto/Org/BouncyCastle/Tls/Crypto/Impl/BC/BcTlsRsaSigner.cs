using System;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Encodings;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Signers;

namespace Org.BouncyCastle.Tls.Crypto.Impl.BC
{
	// Token: 0x02000183 RID: 387
	public class BcTlsRsaSigner : global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsSigner
	{
		// Token: 0x06000EB8 RID: 3768 RVA: 0x00036344 File Offset: 0x00034544
		public BcTlsRsaSigner(global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsCrypto crypto, global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters privateKey, global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters publicKey) : base(crypto, privateKey)
		{
			this.m_publicKey = publicKey;
		}

		// Token: 0x06000EB9 RID: 3769 RVA: 0x00036358 File Offset: 0x00034558
		public override byte[] GenerateRawSignature(global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm algorithm, byte[] hash)
		{
			global::Org.BouncyCastle.Crypto.IDigest nullDigest = new global::Org.BouncyCastle.Crypto.Digests.NullDigest();
			global::Org.BouncyCastle.Crypto.ISigner signer;
			if (algorithm != null)
			{
				if (algorithm.Signature != 1)
				{
					throw new global::System.InvalidOperationException("Invalid algorithm: " + ((algorithm != null) ? algorithm.ToString() : null));
				}
				signer = new global::Org.BouncyCastle.Crypto.Signers.RsaDigestSigner(nullDigest, global::Org.BouncyCastle.Tls.TlsUtilities.GetOidForHashAlgorithm(algorithm.Hash));
			}
			else
			{
				signer = new global::Org.BouncyCastle.Crypto.Signers.GenericSigner(new global::Org.BouncyCastle.Crypto.Encodings.Pkcs1Encoding(new global::Org.BouncyCastle.Crypto.Engines.RsaBlindedEngine()), nullDigest);
			}
			signer.Init(true, new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom(this.m_privateKey, this.m_crypto.SecureRandom));
			signer.BlockUpdate(hash, 0, hash.Length);
			try
			{
				byte[] signature = signer.GenerateSignature();
				signer.Init(false, this.m_publicKey);
				signer.BlockUpdate(hash, 0, hash.Length);
				if (signer.VerifySignature(signature))
				{
					return signature;
				}
			}
			catch (global::Org.BouncyCastle.Crypto.CryptoException e)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80, e);
			}
			throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
		}

		// Token: 0x04000834 RID: 2100
		private readonly global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters m_publicKey;
	}
}
