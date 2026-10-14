using System;
using Org.BouncyCastle.Crypto;

namespace Org.BouncyCastle.Tls.Crypto.Impl.BC
{
	// Token: 0x0200018C RID: 396
	public abstract class BcTlsVerifier : global::Org.BouncyCastle.Tls.Crypto.TlsVerifier
	{
		// Token: 0x06000EDB RID: 3803 RVA: 0x00036CB4 File Offset: 0x00034EB4
		protected BcTlsVerifier(global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsCrypto crypto, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter publicKey)
		{
			if (crypto == null)
			{
				throw new global::System.ArgumentNullException("crypto");
			}
			if (publicKey == null)
			{
				throw new global::System.ArgumentNullException("publicKey");
			}
			if (publicKey.IsPrivate)
			{
				throw new global::System.ArgumentException("must be public", "publicKey");
			}
			this.m_crypto = crypto;
			this.m_publicKey = publicKey;
		}

		// Token: 0x06000EDC RID: 3804 RVA: 0x00036D09 File Offset: 0x00034F09
		public virtual global::Org.BouncyCastle.Tls.Crypto.TlsStreamVerifier GetStreamVerifier(global::Org.BouncyCastle.Tls.DigitallySigned signature)
		{
			return null;
		}

		// Token: 0x06000EDD RID: 3805
		public abstract bool VerifyRawSignature(global::Org.BouncyCastle.Tls.DigitallySigned signature, byte[] hash);

		// Token: 0x0400083F RID: 2111
		protected readonly global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsCrypto m_crypto;

		// Token: 0x04000840 RID: 2112
		protected readonly global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter m_publicKey;
	}
}
