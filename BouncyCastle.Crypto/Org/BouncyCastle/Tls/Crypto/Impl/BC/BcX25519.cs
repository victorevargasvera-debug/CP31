using System;
using Org.BouncyCastle.Math.EC.Rfc7748;

namespace Org.BouncyCastle.Tls.Crypto.Impl.BC
{
	// Token: 0x0200018E RID: 398
	public class BcX25519 : global::Org.BouncyCastle.Tls.Crypto.TlsAgreement
	{
		// Token: 0x06000EE1 RID: 3809 RVA: 0x00036DA0 File Offset: 0x00034FA0
		public BcX25519(global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsCrypto crypto)
		{
			this.m_crypto = crypto;
		}

		// Token: 0x06000EE2 RID: 3810 RVA: 0x00036DCC File Offset: 0x00034FCC
		public virtual byte[] GenerateEphemeral()
		{
			this.m_crypto.SecureRandom.NextBytes(this.m_privateKey);
			byte[] publicKey = new byte[32];
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519.ScalarMultBase(this.m_privateKey, 0, publicKey, 0);
			return publicKey;
		}

		// Token: 0x06000EE3 RID: 3811 RVA: 0x00036E06 File Offset: 0x00035006
		public virtual void ReceivePeerValue(byte[] peerValue)
		{
			if (peerValue == null || peerValue.Length != 32)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(47);
			}
			global::System.Array.Copy(peerValue, 0, this.m_peerPublicKey, 0, 32);
		}

		// Token: 0x06000EE4 RID: 3812 RVA: 0x00036E2C File Offset: 0x0003502C
		public virtual global::Org.BouncyCastle.Tls.Crypto.TlsSecret CalculateSecret()
		{
			global::Org.BouncyCastle.Tls.Crypto.TlsSecret result;
			try
			{
				byte[] secret = new byte[32];
				if (!global::Org.BouncyCastle.Math.EC.Rfc7748.X25519.CalculateAgreement(this.m_privateKey, 0, this.m_peerPublicKey, 0, secret, 0))
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

		// Token: 0x04000844 RID: 2116
		protected readonly global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsCrypto m_crypto;

		// Token: 0x04000845 RID: 2117
		protected readonly byte[] m_privateKey = new byte[32];

		// Token: 0x04000846 RID: 2118
		protected readonly byte[] m_peerPublicKey = new byte[32];
	}
}
