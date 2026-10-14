using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Signers;

namespace Org.BouncyCastle.Tls.Crypto.Impl.BC
{
	// Token: 0x02000179 RID: 377
	public class BcTlsEd25519Signer : global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsSigner
	{
		// Token: 0x06000E93 RID: 3731 RVA: 0x00035E17 File Offset: 0x00034017
		public BcTlsEd25519Signer(global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsCrypto crypto, global::Org.BouncyCastle.Crypto.Parameters.Ed25519PrivateKeyParameters privateKey) : base(crypto, privateKey)
		{
		}

		// Token: 0x06000E94 RID: 3732 RVA: 0x00035E21 File Offset: 0x00034021
		public override byte[] GenerateRawSignature(global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm algorithm, byte[] hash)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06000E95 RID: 3733 RVA: 0x00035E28 File Offset: 0x00034028
		public override global::Org.BouncyCastle.Tls.Crypto.TlsStreamSigner GetStreamSigner(global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm algorithm)
		{
			if (algorithm == null || global::Org.BouncyCastle.Tls.SignatureScheme.From(algorithm) != 2055)
			{
				throw new global::System.InvalidOperationException("Invalid algorithm: " + ((algorithm != null) ? algorithm.ToString() : null));
			}
			global::Org.BouncyCastle.Crypto.Signers.Ed25519Signer ed25519Signer = new global::Org.BouncyCastle.Crypto.Signers.Ed25519Signer();
			ed25519Signer.Init(true, this.m_privateKey);
			return new global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsStreamSigner(ed25519Signer);
		}
	}
}
