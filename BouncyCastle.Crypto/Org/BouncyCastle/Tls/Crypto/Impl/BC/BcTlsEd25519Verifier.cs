using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Signers;

namespace Org.BouncyCastle.Tls.Crypto.Impl.BC
{
	// Token: 0x0200017A RID: 378
	public class BcTlsEd25519Verifier : global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsVerifier
	{
		// Token: 0x06000E96 RID: 3734 RVA: 0x00035E79 File Offset: 0x00034079
		public BcTlsEd25519Verifier(global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsCrypto crypto, global::Org.BouncyCastle.Crypto.Parameters.Ed25519PublicKeyParameters publicKey) : base(crypto, publicKey)
		{
		}

		// Token: 0x06000E97 RID: 3735 RVA: 0x00035E83 File Offset: 0x00034083
		public override bool VerifyRawSignature(global::Org.BouncyCastle.Tls.DigitallySigned signature, byte[] hash)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06000E98 RID: 3736 RVA: 0x00035E8C File Offset: 0x0003408C
		public override global::Org.BouncyCastle.Tls.Crypto.TlsStreamVerifier GetStreamVerifier(global::Org.BouncyCastle.Tls.DigitallySigned signature)
		{
			global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm algorithm = signature.Algorithm;
			if (algorithm == null || global::Org.BouncyCastle.Tls.SignatureScheme.From(algorithm) != 2055)
			{
				string str = "Invalid algorithm: ";
				global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm signatureAndHashAlgorithm = algorithm;
				throw new global::System.InvalidOperationException(str + ((signatureAndHashAlgorithm != null) ? signatureAndHashAlgorithm.ToString() : null));
			}
			global::Org.BouncyCastle.Crypto.Signers.Ed25519Signer ed25519Signer = new global::Org.BouncyCastle.Crypto.Signers.Ed25519Signer();
			ed25519Signer.Init(false, this.m_publicKey);
			return new global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsStreamVerifier(ed25519Signer, signature.Signature);
		}
	}
}
