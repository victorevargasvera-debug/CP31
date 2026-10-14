using System;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x020002FB RID: 763
	public abstract class AbstractTlsSigner : global::Org.BouncyCastle.Crypto.Tls.TlsSigner
	{
		// Token: 0x060020B8 RID: 8376 RVA: 0x00091D1A File Offset: 0x0008FF1A
		public virtual void Init(global::Org.BouncyCastle.Crypto.Tls.TlsContext context)
		{
			this.mContext = context;
		}

		// Token: 0x060020B9 RID: 8377 RVA: 0x00091D23 File Offset: 0x0008FF23
		public virtual byte[] GenerateRawSignature(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey, byte[] md5AndSha1)
		{
			return this.GenerateRawSignature(null, privateKey, md5AndSha1);
		}

		// Token: 0x060020BA RID: 8378
		public abstract byte[] GenerateRawSignature(global::Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm algorithm, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey, byte[] hash);

		// Token: 0x060020BB RID: 8379 RVA: 0x00091D2E File Offset: 0x0008FF2E
		public virtual bool VerifyRawSignature(byte[] sigBytes, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter publicKey, byte[] md5AndSha1)
		{
			return this.VerifyRawSignature(null, sigBytes, publicKey, md5AndSha1);
		}

		// Token: 0x060020BC RID: 8380
		public abstract bool VerifyRawSignature(global::Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm algorithm, byte[] sigBytes, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter publicKey, byte[] hash);

		// Token: 0x060020BD RID: 8381 RVA: 0x00091D3A File Offset: 0x0008FF3A
		public virtual global::Org.BouncyCastle.Crypto.ISigner CreateSigner(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey)
		{
			return this.CreateSigner(null, privateKey);
		}

		// Token: 0x060020BE RID: 8382
		public abstract global::Org.BouncyCastle.Crypto.ISigner CreateSigner(global::Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm algorithm, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey);

		// Token: 0x060020BF RID: 8383 RVA: 0x00091D44 File Offset: 0x0008FF44
		public virtual global::Org.BouncyCastle.Crypto.ISigner CreateVerifyer(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter publicKey)
		{
			return this.CreateVerifyer(null, publicKey);
		}

		// Token: 0x060020C0 RID: 8384
		public abstract global::Org.BouncyCastle.Crypto.ISigner CreateVerifyer(global::Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm algorithm, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter publicKey);

		// Token: 0x060020C1 RID: 8385
		public abstract bool IsValidPublicKey(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter publicKey);

		// Token: 0x04000B63 RID: 2915
		protected global::Org.BouncyCastle.Crypto.Tls.TlsContext mContext;
	}
}
