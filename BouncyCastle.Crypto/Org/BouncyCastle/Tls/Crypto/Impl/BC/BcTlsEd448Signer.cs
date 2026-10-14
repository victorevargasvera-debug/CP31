using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Signers;

namespace Org.BouncyCastle.Tls.Crypto.Impl.BC
{
	// Token: 0x0200017B RID: 379
	public class BcTlsEd448Signer : global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsSigner
	{
		// Token: 0x06000E99 RID: 3737 RVA: 0x00035EEA File Offset: 0x000340EA
		public BcTlsEd448Signer(global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsCrypto crypto, global::Org.BouncyCastle.Crypto.Parameters.Ed448PrivateKeyParameters privateKey) : base(crypto, privateKey)
		{
		}

		// Token: 0x06000E9A RID: 3738 RVA: 0x00035EF4 File Offset: 0x000340F4
		public override byte[] GenerateRawSignature(global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm algorithm, byte[] hash)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06000E9B RID: 3739 RVA: 0x00035EFC File Offset: 0x000340FC
		public override global::Org.BouncyCastle.Tls.Crypto.TlsStreamSigner GetStreamSigner(global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm algorithm)
		{
			if (algorithm == null || global::Org.BouncyCastle.Tls.SignatureScheme.From(algorithm) != 2056)
			{
				throw new global::System.InvalidOperationException("Invalid algorithm: " + ((algorithm != null) ? algorithm.ToString() : null));
			}
			global::Org.BouncyCastle.Crypto.Signers.Ed448Signer ed448Signer = new global::Org.BouncyCastle.Crypto.Signers.Ed448Signer(global::Org.BouncyCastle.Tls.TlsUtilities.EmptyBytes);
			ed448Signer.Init(true, this.m_privateKey);
			return new global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsStreamSigner(ed448Signer);
		}
	}
}
