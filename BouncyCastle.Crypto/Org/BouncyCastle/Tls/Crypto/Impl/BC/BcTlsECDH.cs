using System;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;

namespace Org.BouncyCastle.Tls.Crypto.Impl.BC
{
	// Token: 0x02000173 RID: 371
	public class BcTlsECDH : global::Org.BouncyCastle.Tls.Crypto.TlsAgreement
	{
		// Token: 0x06000E7A RID: 3706 RVA: 0x00035A56 File Offset: 0x00033C56
		public BcTlsECDH(global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsECDomain domain)
		{
			this.m_domain = domain;
		}

		// Token: 0x06000E7B RID: 3707 RVA: 0x00035A65 File Offset: 0x00033C65
		public virtual byte[] GenerateEphemeral()
		{
			this.m_localKeyPair = this.m_domain.GenerateKeyPair();
			return this.m_domain.EncodePublicKey((global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters)this.m_localKeyPair.Public);
		}

		// Token: 0x06000E7C RID: 3708 RVA: 0x00035A93 File Offset: 0x00033C93
		public virtual void ReceivePeerValue(byte[] peerValue)
		{
			this.m_peerPublicKey = this.m_domain.DecodePublicKey(peerValue);
		}

		// Token: 0x06000E7D RID: 3709 RVA: 0x00035AA7 File Offset: 0x00033CA7
		public virtual global::Org.BouncyCastle.Tls.Crypto.TlsSecret CalculateSecret()
		{
			return this.m_domain.CalculateECDHAgreement((global::Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters)this.m_localKeyPair.Private, this.m_peerPublicKey);
		}

		// Token: 0x04000823 RID: 2083
		protected readonly global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsECDomain m_domain;

		// Token: 0x04000824 RID: 2084
		protected global::Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair m_localKeyPair;

		// Token: 0x04000825 RID: 2085
		protected global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters m_peerPublicKey;
	}
}
