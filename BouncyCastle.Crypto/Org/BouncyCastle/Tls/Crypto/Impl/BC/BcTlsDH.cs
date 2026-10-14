using System;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;

namespace Org.BouncyCastle.Tls.Crypto.Impl.BC
{
	// Token: 0x0200016D RID: 365
	public class BcTlsDH : global::Org.BouncyCastle.Tls.Crypto.TlsAgreement
	{
		// Token: 0x06000E5C RID: 3676 RVA: 0x0003567C File Offset: 0x0003387C
		public BcTlsDH(global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsDHDomain domain)
		{
			this.m_domain = domain;
		}

		// Token: 0x06000E5D RID: 3677 RVA: 0x0003568B File Offset: 0x0003388B
		public virtual byte[] GenerateEphemeral()
		{
			this.m_localKeyPair = this.m_domain.GenerateKeyPair();
			return this.m_domain.EncodePublicKey((global::Org.BouncyCastle.Crypto.Parameters.DHPublicKeyParameters)this.m_localKeyPair.Public);
		}

		// Token: 0x06000E5E RID: 3678 RVA: 0x000356B9 File Offset: 0x000338B9
		public virtual void ReceivePeerValue(byte[] peerValue)
		{
			this.m_peerPublicKey = this.m_domain.DecodePublicKey(peerValue);
		}

		// Token: 0x06000E5F RID: 3679 RVA: 0x000356CD File Offset: 0x000338CD
		public virtual global::Org.BouncyCastle.Tls.Crypto.TlsSecret CalculateSecret()
		{
			return this.m_domain.CalculateDHAgreement((global::Org.BouncyCastle.Crypto.Parameters.DHPrivateKeyParameters)this.m_localKeyPair.Private, this.m_peerPublicKey);
		}

		// Token: 0x0400081D RID: 2077
		protected readonly global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsDHDomain m_domain;

		// Token: 0x0400081E RID: 2078
		protected global::Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair m_localKeyPair;

		// Token: 0x0400081F RID: 2079
		protected global::Org.BouncyCastle.Crypto.Parameters.DHPublicKeyParameters m_peerPublicKey;
	}
}
