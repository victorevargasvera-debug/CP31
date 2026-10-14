using System;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Agreement.Srp;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Tls.Crypto.Impl.BC
{
	// Token: 0x02000188 RID: 392
	internal sealed class BcTlsSrp6Server : global::Org.BouncyCastle.Tls.Crypto.TlsSrp6Server
	{
		// Token: 0x06000ED0 RID: 3792 RVA: 0x00036BAC File Offset: 0x00034DAC
		internal BcTlsSrp6Server(global::Org.BouncyCastle.Crypto.Agreement.Srp.Srp6Server srp6Server)
		{
			this.m_srp6Server = srp6Server;
		}

		// Token: 0x06000ED1 RID: 3793 RVA: 0x00036BBB File Offset: 0x00034DBB
		public global::Org.BouncyCastle.Math.BigInteger GenerateServerCredentials()
		{
			return this.m_srp6Server.GenerateServerCredentials();
		}

		// Token: 0x06000ED2 RID: 3794 RVA: 0x00036BC8 File Offset: 0x00034DC8
		public global::Org.BouncyCastle.Math.BigInteger CalculateSecret(global::Org.BouncyCastle.Math.BigInteger clientA)
		{
			global::Org.BouncyCastle.Math.BigInteger result;
			try
			{
				result = this.m_srp6Server.CalculateSecret(clientA);
			}
			catch (global::Org.BouncyCastle.Crypto.CryptoException e)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(47, e);
			}
			return result;
		}

		// Token: 0x0400083A RID: 2106
		private readonly global::Org.BouncyCastle.Crypto.Agreement.Srp.Srp6Server m_srp6Server;
	}
}
