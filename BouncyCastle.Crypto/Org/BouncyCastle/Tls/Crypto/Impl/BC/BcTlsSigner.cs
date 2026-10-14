using System;
using Org.BouncyCastle.Crypto;

namespace Org.BouncyCastle.Tls.Crypto.Impl.BC
{
	// Token: 0x02000186 RID: 390
	public abstract class BcTlsSigner : global::Org.BouncyCastle.Tls.Crypto.TlsSigner
	{
		// Token: 0x06000ECA RID: 3786 RVA: 0x00036AFC File Offset: 0x00034CFC
		protected BcTlsSigner(global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsCrypto crypto, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey)
		{
			if (crypto == null)
			{
				throw new global::System.ArgumentNullException("crypto");
			}
			if (privateKey == null)
			{
				throw new global::System.ArgumentNullException("privateKey");
			}
			if (!privateKey.IsPrivate)
			{
				throw new global::System.ArgumentException("must be private", "privateKey");
			}
			this.m_crypto = crypto;
			this.m_privateKey = privateKey;
		}

		// Token: 0x06000ECB RID: 3787
		public abstract byte[] GenerateRawSignature(global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm algorithm, byte[] hash);

		// Token: 0x06000ECC RID: 3788 RVA: 0x00036B51 File Offset: 0x00034D51
		public virtual global::Org.BouncyCastle.Tls.Crypto.TlsStreamSigner GetStreamSigner(global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm algorithm)
		{
			return null;
		}

		// Token: 0x04000837 RID: 2103
		protected readonly global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsCrypto m_crypto;

		// Token: 0x04000838 RID: 2104
		protected readonly global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter m_privateKey;
	}
}
