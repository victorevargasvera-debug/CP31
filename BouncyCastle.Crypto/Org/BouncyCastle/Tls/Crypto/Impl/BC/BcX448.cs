using System;
using Org.BouncyCastle.Math.EC.Rfc7748;

namespace Org.BouncyCastle.Tls.Crypto.Impl.BC
{
	// Token: 0x02000190 RID: 400
	public class BcX448 : global::Org.BouncyCastle.Tls.Crypto.TlsAgreement
	{
		// Token: 0x06000EE7 RID: 3815 RVA: 0x00036EC8 File Offset: 0x000350C8
		public BcX448(global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsCrypto crypto)
		{
			this.m_crypto = crypto;
		}

		// Token: 0x06000EE8 RID: 3816 RVA: 0x00036EF4 File Offset: 0x000350F4
		public virtual byte[] GenerateEphemeral()
		{
			this.m_crypto.SecureRandom.NextBytes(this.m_privateKey);
			byte[] publicKey = new byte[56];
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448.ScalarMultBase(this.m_privateKey, 0, publicKey, 0);
			return publicKey;
		}

		// Token: 0x06000EE9 RID: 3817 RVA: 0x00036F2E File Offset: 0x0003512E
		public virtual void ReceivePeerValue(byte[] peerValue)
		{
			if (peerValue == null || peerValue.Length != 56)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(47);
			}
			global::System.Array.Copy(peerValue, 0, this.m_peerPublicKey, 0, 56);
		}

		// Token: 0x06000EEA RID: 3818 RVA: 0x00036F54 File Offset: 0x00035154
		public virtual global::Org.BouncyCastle.Tls.Crypto.TlsSecret CalculateSecret()
		{
			global::Org.BouncyCastle.Tls.Crypto.TlsSecret result;
			try
			{
				byte[] secret = new byte[56];
				if (!global::Org.BouncyCastle.Math.EC.Rfc7748.X448.CalculateAgreement(this.m_privateKey, 0, this.m_peerPublicKey, 0, secret, 0))
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(40);
				}
				result = this.m_crypto.AdoptLocalSecret(secret);
			}
			finally
			{
				global::System.Array.Clear(this.m_privateKey, 0, this.m_privateKey.Length);
				global::System.Array.Clear(this.m_peerPublicKey, 0, this.m_peerPublicKey.Length);
			}
			return result;
		}

		// Token: 0x04000848 RID: 2120
		protected readonly global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsCrypto m_crypto;

		// Token: 0x04000849 RID: 2121
		protected readonly byte[] m_privateKey = new byte[56];

		// Token: 0x0400084A RID: 2122
		protected readonly byte[] m_peerPublicKey = new byte[56];
	}
}
