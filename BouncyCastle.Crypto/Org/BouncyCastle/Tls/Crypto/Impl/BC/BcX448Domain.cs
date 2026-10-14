using System;

namespace Org.BouncyCastle.Tls.Crypto.Impl.BC
{
	// Token: 0x02000191 RID: 401
	public class BcX448Domain : global::Org.BouncyCastle.Tls.Crypto.TlsECDomain
	{
		// Token: 0x06000EEB RID: 3819 RVA: 0x00036FD4 File Offset: 0x000351D4
		public BcX448Domain(global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsCrypto crypto)
		{
			this.m_crypto = crypto;
		}

		// Token: 0x06000EEC RID: 3820 RVA: 0x00036FE3 File Offset: 0x000351E3
		public virtual global::Org.BouncyCastle.Tls.Crypto.TlsAgreement CreateECDH()
		{
			return new global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcX448(this.m_crypto);
		}

		// Token: 0x0400084B RID: 2123
		protected readonly global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsCrypto m_crypto;
	}
}
