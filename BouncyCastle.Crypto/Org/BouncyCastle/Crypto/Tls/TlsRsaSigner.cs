using System;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Encodings;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Signers;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000380 RID: 896
	public class TlsRsaSigner : global::Org.BouncyCastle.Crypto.Tls.AbstractTlsSigner
	{
		// Token: 0x0600247D RID: 9341 RVA: 0x0009EAFC File Offset: 0x0009CCFC
		public override byte[] GenerateRawSignature(global::Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm algorithm, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey, byte[] hash)
		{
			global::Org.BouncyCastle.Crypto.ISigner signer = this.MakeSigner(algorithm, true, true, new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom(privateKey, this.mContext.SecureRandom));
			signer.BlockUpdate(hash, 0, hash.Length);
			return signer.GenerateSignature();
		}

		// Token: 0x0600247E RID: 9342 RVA: 0x0009EB28 File Offset: 0x0009CD28
		public override bool VerifyRawSignature(global::Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm algorithm, byte[] sigBytes, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter publicKey, byte[] hash)
		{
			global::Org.BouncyCastle.Crypto.ISigner signer = this.MakeSigner(algorithm, true, false, publicKey);
			signer.BlockUpdate(hash, 0, hash.Length);
			return signer.VerifySignature(sigBytes);
		}

		// Token: 0x0600247F RID: 9343 RVA: 0x0009EB47 File Offset: 0x0009CD47
		public override global::Org.BouncyCastle.Crypto.ISigner CreateSigner(global::Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm algorithm, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey)
		{
			return this.MakeSigner(algorithm, false, true, new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom(privateKey, this.mContext.SecureRandom));
		}

		// Token: 0x06002480 RID: 9344 RVA: 0x0009EB63 File Offset: 0x0009CD63
		public override global::Org.BouncyCastle.Crypto.ISigner CreateVerifyer(global::Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm algorithm, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter publicKey)
		{
			return this.MakeSigner(algorithm, false, false, publicKey);
		}

		// Token: 0x06002481 RID: 9345 RVA: 0x0009EB6F File Offset: 0x0009CD6F
		public override bool IsValidPublicKey(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter publicKey)
		{
			return publicKey is global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters && !publicKey.IsPrivate;
		}

		// Token: 0x06002482 RID: 9346 RVA: 0x0009EB84 File Offset: 0x0009CD84
		protected virtual global::Org.BouncyCastle.Crypto.ISigner MakeSigner(global::Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm algorithm, bool raw, bool forSigning, global::Org.BouncyCastle.Crypto.ICipherParameters cp)
		{
			if (algorithm != null != global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsTlsV12(this.mContext))
			{
				throw new global::System.InvalidOperationException();
			}
			if (algorithm != null && algorithm.Signature != 1)
			{
				throw new global::System.InvalidOperationException();
			}
			global::Org.BouncyCastle.Crypto.IDigest d;
			if (raw)
			{
				d = new global::Org.BouncyCastle.Crypto.Digests.NullDigest();
			}
			else if (algorithm == null)
			{
				d = new global::Org.BouncyCastle.Crypto.Tls.CombinedHash();
			}
			else
			{
				d = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.CreateHash(algorithm.Hash);
			}
			global::Org.BouncyCastle.Crypto.ISigner s;
			if (algorithm != null)
			{
				s = new global::Org.BouncyCastle.Crypto.Signers.RsaDigestSigner(d, global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetOidForHashAlgorithm(algorithm.Hash));
			}
			else
			{
				s = new global::Org.BouncyCastle.Crypto.Signers.GenericSigner(this.CreateRsaImpl(), d);
			}
			s.Init(forSigning, cp);
			return s;
		}

		// Token: 0x06002483 RID: 9347 RVA: 0x0009EC0A File Offset: 0x0009CE0A
		protected virtual global::Org.BouncyCastle.Crypto.IAsymmetricBlockCipher CreateRsaImpl()
		{
			return new global::Org.BouncyCastle.Crypto.Encodings.Pkcs1Encoding(new global::Org.BouncyCastle.Crypto.Engines.RsaBlindedEngine());
		}
	}
}
