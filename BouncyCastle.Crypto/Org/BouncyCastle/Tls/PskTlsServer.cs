using System;
using Org.BouncyCastle.Tls.Crypto;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000E2 RID: 226
	public class PskTlsServer : global::Org.BouncyCastle.Tls.AbstractTlsServer
	{
		// Token: 0x0600081E RID: 2078 RVA: 0x00021F3D File Offset: 0x0002013D
		public PskTlsServer(global::Org.BouncyCastle.Tls.Crypto.TlsCrypto crypto, global::Org.BouncyCastle.Tls.TlsPskIdentityManager pskIdentityManager) : base(crypto)
		{
			this.m_pskIdentityManager = pskIdentityManager;
		}

		// Token: 0x0600081F RID: 2079 RVA: 0x00021F4D File Offset: 0x0002014D
		protected virtual global::Org.BouncyCastle.Tls.TlsCredentialedDecryptor GetRsaEncryptionCredentials()
		{
			throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
		}

		// Token: 0x06000820 RID: 2080 RVA: 0x00021F56 File Offset: 0x00020156
		protected override global::Org.BouncyCastle.Tls.ProtocolVersion[] GetSupportedVersions()
		{
			return global::Org.BouncyCastle.Tls.ProtocolVersion.TLSv12.DownTo(global::Org.BouncyCastle.Tls.ProtocolVersion.TLSv10);
		}

		// Token: 0x06000821 RID: 2081 RVA: 0x00021F67 File Offset: 0x00020167
		protected override int[] GetSupportedCipherSuites()
		{
			return global::Org.BouncyCastle.Tls.TlsUtilities.GetSupportedCipherSuites(this.Crypto, global::Org.BouncyCastle.Tls.PskTlsServer.DefaultCipherSuites);
		}

		// Token: 0x06000822 RID: 2082 RVA: 0x00021F7C File Offset: 0x0002017C
		public override global::Org.BouncyCastle.Tls.TlsCredentials GetCredentials()
		{
			int keyExchangeAlgorithm = this.m_context.SecurityParameters.KeyExchangeAlgorithm;
			if (keyExchangeAlgorithm - 13 > 1)
			{
				if (keyExchangeAlgorithm == 15)
				{
					return this.GetRsaEncryptionCredentials();
				}
				if (keyExchangeAlgorithm != 24)
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
				}
			}
			return null;
		}

		// Token: 0x06000823 RID: 2083 RVA: 0x00021FBB File Offset: 0x000201BB
		public override global::Org.BouncyCastle.Tls.TlsPskIdentityManager GetPskIdentityManager()
		{
			return this.m_pskIdentityManager;
		}

		// Token: 0x0400062D RID: 1581
		private static readonly int[] DefaultCipherSuites = new int[]
		{
			52396,
			49208,
			49207,
			49206,
			49205,
			52397,
			171,
			170,
			179,
			178,
			145,
			144
		};

		// Token: 0x0400062E RID: 1582
		protected readonly global::Org.BouncyCastle.Tls.TlsPskIdentityManager m_pskIdentityManager;
	}
}
