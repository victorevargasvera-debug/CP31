using System;

namespace Org.BouncyCastle.Tls.Crypto.Impl.BC
{
	// Token: 0x0200018F RID: 399
	public class BcX25519Domain : global::Org.BouncyCastle.Tls.Crypto.TlsECDomain
	{
		// Token: 0x06000EE5 RID: 3813 RVA: 0x00036EAC File Offset: 0x000350AC
		public BcX25519Domain(global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsCrypto crypto)
		{
			this.m_crypto = crypto;
		}

		// Token: 0x06000EE6 RID: 3814 RVA: 0x00036EBB File Offset: 0x000350BB
		public virtual global::Org.BouncyCastle.Tls.Crypto.TlsAgreement CreateECDH()
		{
			return new global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcX25519(this.m_crypto);
		}

		// Token: 0x04000847 RID: 2119
		protected readonly global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsCrypto m_crypto;
	}
}
