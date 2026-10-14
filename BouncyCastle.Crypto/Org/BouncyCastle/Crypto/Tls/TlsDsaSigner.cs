using System;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Signers;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000368 RID: 872
	public abstract class TlsDsaSigner : global::Org.BouncyCastle.Crypto.Tls.AbstractTlsSigner
	{
		// Token: 0x06002363 RID: 9059 RVA: 0x0009B484 File Offset: 0x00099684
		public override byte[] GenerateRawSignature(global::Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm algorithm, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey, byte[] hash)
		{
			global::Org.BouncyCastle.Crypto.ISigner signer = this.MakeSigner(algorithm, true, true, new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom(privateKey, this.mContext.SecureRandom));
			if (algorithm == null)
			{
				signer.BlockUpdate(hash, 16, 20);
			}
			else
			{
				signer.BlockUpdate(hash, 0, hash.Length);
			}
			return signer.GenerateSignature();
		}

		// Token: 0x06002364 RID: 9060 RVA: 0x0009B4D0 File Offset: 0x000996D0
		public override bool VerifyRawSignature(global::Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm algorithm, byte[] sigBytes, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter publicKey, byte[] hash)
		{
			global::Org.BouncyCastle.Crypto.ISigner signer = this.MakeSigner(algorithm, true, false, publicKey);
			if (algorithm == null)
			{
				signer.BlockUpdate(hash, 16, 20);
			}
			else
			{
				signer.BlockUpdate(hash, 0, hash.Length);
			}
			return signer.VerifySignature(sigBytes);
		}

		// Token: 0x06002365 RID: 9061 RVA: 0x0009B50D File Offset: 0x0009970D
		public override global::Org.BouncyCastle.Crypto.ISigner CreateSigner(global::Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm algorithm, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey)
		{
			return this.MakeSigner(algorithm, false, true, privateKey);
		}

		// Token: 0x06002366 RID: 9062 RVA: 0x0009B519 File Offset: 0x00099719
		public override global::Org.BouncyCastle.Crypto.ISigner CreateVerifyer(global::Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm algorithm, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter publicKey)
		{
			return this.MakeSigner(algorithm, false, false, publicKey);
		}

		// Token: 0x06002367 RID: 9063 RVA: 0x0009B525 File Offset: 0x00099725
		protected virtual global::Org.BouncyCastle.Crypto.ICipherParameters MakeInitParameters(bool forSigning, global::Org.BouncyCastle.Crypto.ICipherParameters cp)
		{
			return cp;
		}

		// Token: 0x06002368 RID: 9064 RVA: 0x0009B528 File Offset: 0x00099728
		protected virtual global::Org.BouncyCastle.Crypto.ISigner MakeSigner(global::Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm algorithm, bool raw, bool forSigning, global::Org.BouncyCastle.Crypto.ICipherParameters cp)
		{
			if (algorithm != null != global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsTlsV12(this.mContext))
			{
				throw new global::System.InvalidOperationException();
			}
			if (algorithm != null && algorithm.Signature != this.SignatureAlgorithm)
			{
				throw new global::System.InvalidOperationException();
			}
			byte hashAlgorithm = (algorithm == null) ? 2 : algorithm.Hash;
			global::Org.BouncyCastle.Crypto.IDigest digest;
			if (!raw)
			{
				digest = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.CreateHash(hashAlgorithm);
			}
			else
			{
				global::Org.BouncyCastle.Crypto.IDigest digest2 = new global::Org.BouncyCastle.Crypto.Digests.NullDigest();
				digest = digest2;
			}
			global::Org.BouncyCastle.Crypto.IDigest d = digest;
			global::Org.BouncyCastle.Crypto.Signers.DsaDigestSigner dsaDigestSigner = new global::Org.BouncyCastle.Crypto.Signers.DsaDigestSigner(this.CreateDsaImpl(hashAlgorithm), d);
			((global::Org.BouncyCastle.Crypto.ISigner)dsaDigestSigner).Init(forSigning, this.MakeInitParameters(forSigning, cp));
			return dsaDigestSigner;
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x06002369 RID: 9065
		protected abstract byte SignatureAlgorithm { get; }

		// Token: 0x0600236A RID: 9066
		protected abstract global::Org.BouncyCastle.Crypto.IDsa CreateDsaImpl(byte hashAlgorithm);
	}
}
