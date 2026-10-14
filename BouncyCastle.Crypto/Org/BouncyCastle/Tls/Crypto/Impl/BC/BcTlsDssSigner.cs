using System;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Signers;

namespace Org.BouncyCastle.Tls.Crypto.Impl.BC
{
	// Token: 0x02000171 RID: 369
	public abstract class BcTlsDssSigner : global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsSigner
	{
		// Token: 0x06000E72 RID: 3698 RVA: 0x000358E7 File Offset: 0x00033AE7
		protected BcTlsDssSigner(global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsCrypto crypto, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey) : base(crypto, privateKey)
		{
		}

		// Token: 0x06000E73 RID: 3699
		protected abstract global::Org.BouncyCastle.Crypto.IDsa CreateDsaImpl(int cryptoHashAlgorithm);

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06000E74 RID: 3700
		protected abstract short SignatureAlgorithm { get; }

		// Token: 0x06000E75 RID: 3701 RVA: 0x000358F4 File Offset: 0x00033AF4
		public override byte[] GenerateRawSignature(global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm algorithm, byte[] hash)
		{
			if (algorithm != null && algorithm.Signature != this.SignatureAlgorithm)
			{
				throw new global::System.InvalidOperationException("Invalid algorithm: " + ((algorithm != null) ? algorithm.ToString() : null));
			}
			int cryptoHashAlgorithm = (algorithm == null) ? 2 : global::Org.BouncyCastle.Tls.Crypto.TlsCryptoUtilities.GetHash(algorithm.Hash);
			global::Org.BouncyCastle.Crypto.ISigner signer = new global::Org.BouncyCastle.Crypto.Signers.DsaDigestSigner(this.CreateDsaImpl(cryptoHashAlgorithm), new global::Org.BouncyCastle.Crypto.Digests.NullDigest());
			signer.Init(true, new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom(this.m_privateKey, this.m_crypto.SecureRandom));
			if (algorithm == null)
			{
				signer.BlockUpdate(hash, 16, 20);
			}
			else
			{
				signer.BlockUpdate(hash, 0, hash.Length);
			}
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
	}
}
