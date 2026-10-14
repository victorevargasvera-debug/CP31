using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Signers;

namespace Org.BouncyCastle.Tls.Crypto.Impl.BC
{
	// Token: 0x0200017C RID: 380
	public class BcTlsEd448Verifier : global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsVerifier
	{
		// Token: 0x06000E9C RID: 3740 RVA: 0x00035F52 File Offset: 0x00034152
		public BcTlsEd448Verifier(global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsCrypto crypto, global::Org.BouncyCastle.Crypto.Parameters.Ed448PublicKeyParameters publicKey) : base(crypto, publicKey)
		{
		}

		// Token: 0x06000E9D RID: 3741 RVA: 0x00035F5C File Offset: 0x0003415C
		public override bool VerifyRawSignature(global::Org.BouncyCastle.Tls.DigitallySigned signature, byte[] hash)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06000E9E RID: 3742 RVA: 0x00035F64 File Offset: 0x00034164
		public override global::Org.BouncyCastle.Tls.Crypto.TlsStreamVerifier GetStreamVerifier(global::Org.BouncyCastle.Tls.DigitallySigned signature)
		{
			global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm algorithm = signature.Algorithm;
			if (algorithm == null || global::Org.BouncyCastle.Tls.SignatureScheme.From(algorithm) != 2056)
			{
				string str = "Invalid algorithm: ";
				global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm signatureAndHashAlgorithm = algorithm;
				throw new global::System.InvalidOperationException(str + ((signatureAndHashAlgorithm != null) ? signatureAndHashAlgorithm.ToString() : null));
			}
			global::Org.BouncyCastle.Crypto.Signers.Ed448Signer ed448Signer = new global::Org.BouncyCastle.Crypto.Signers.Ed448Signer(global::Org.BouncyCastle.Tls.TlsUtilities.EmptyBytes);
			ed448Signer.Init(false, this.m_publicKey);
			return new global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsStreamVerifier(ed448Signer, signature.Signature);
		}
	}
}
