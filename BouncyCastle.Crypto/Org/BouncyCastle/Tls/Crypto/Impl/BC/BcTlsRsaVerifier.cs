using System;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Encodings;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Signers;

namespace Org.BouncyCastle.Tls.Crypto.Impl.BC
{
	// Token: 0x02000184 RID: 388
	public class BcTlsRsaVerifier : global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsVerifier
	{
		// Token: 0x06000EBA RID: 3770 RVA: 0x00036434 File Offset: 0x00034634
		public BcTlsRsaVerifier(global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsCrypto crypto, global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters publicKey) : base(crypto, publicKey)
		{
		}

		// Token: 0x06000EBB RID: 3771 RVA: 0x00036440 File Offset: 0x00034640
		public override bool VerifyRawSignature(global::Org.BouncyCastle.Tls.DigitallySigned signedParams, byte[] hash)
		{
			global::Org.BouncyCastle.Crypto.IDigest nullDigest = new global::Org.BouncyCastle.Crypto.Digests.NullDigest();
			global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm algorithm = signedParams.Algorithm;
			global::Org.BouncyCastle.Crypto.ISigner signer;
			if (algorithm != null)
			{
				if (algorithm.Signature != 1)
				{
					string str = "Invalid algorithm: ";
					global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm signatureAndHashAlgorithm = algorithm;
					throw new global::System.InvalidOperationException(str + ((signatureAndHashAlgorithm != null) ? signatureAndHashAlgorithm.ToString() : null));
				}
				signer = new global::Org.BouncyCastle.Crypto.Signers.RsaDigestSigner(nullDigest, global::Org.BouncyCastle.Tls.TlsUtilities.GetOidForHashAlgorithm(algorithm.Hash));
			}
			else
			{
				signer = new global::Org.BouncyCastle.Crypto.Signers.GenericSigner(new global::Org.BouncyCastle.Crypto.Encodings.Pkcs1Encoding(new global::Org.BouncyCastle.Crypto.Engines.RsaBlindedEngine()), nullDigest);
			}
			signer.Init(false, this.m_publicKey);
			signer.BlockUpdate(hash, 0, hash.Length);
			return signer.VerifySignature(signedParams.Signature);
		}
	}
}
