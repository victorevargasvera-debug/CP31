using System;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Agreement.Srp;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Tls.Crypto.Impl.BC
{
	// Token: 0x02000187 RID: 391
	internal sealed class BcTlsSrp6Client : global::Org.BouncyCastle.Tls.Crypto.TlsSrp6Client
	{
		// Token: 0x06000ECD RID: 3789 RVA: 0x00036B54 File Offset: 0x00034D54
		internal BcTlsSrp6Client(global::Org.BouncyCastle.Crypto.Agreement.Srp.Srp6Client srpClient)
		{
			this.m_srp6Client = srpClient;
		}

		// Token: 0x06000ECE RID: 3790 RVA: 0x00036B64 File Offset: 0x00034D64
		public global::Org.BouncyCastle.Math.BigInteger CalculateSecret(global::Org.BouncyCastle.Math.BigInteger serverB)
		{
			global::Org.BouncyCastle.Math.BigInteger result;
			try
			{
				result = this.m_srp6Client.CalculateSecret(serverB);
			}
			catch (global::Org.BouncyCastle.Crypto.CryptoException e)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(47, e);
			}
			return result;
		}

		// Token: 0x06000ECF RID: 3791 RVA: 0x00036B9C File Offset: 0x00034D9C
		public global::Org.BouncyCastle.Math.BigInteger GenerateClientCredentials(byte[] srpSalt, byte[] identity, byte[] password)
		{
			return this.m_srp6Client.GenerateClientCredentials(srpSalt, identity, password);
		}

		// Token: 0x04000839 RID: 2105
		private readonly global::Org.BouncyCastle.Crypto.Agreement.Srp.Srp6Client m_srp6Client;
	}
}
