using System;
using Org.BouncyCastle.Crypto.Agreement;
using Org.BouncyCastle.Crypto.Parameters;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000342 RID: 834
	public class PskTlsServer : global::Org.BouncyCastle.Crypto.Tls.AbstractTlsServer
	{
		// Token: 0x06002261 RID: 8801 RVA: 0x00097D99 File Offset: 0x00095F99
		public PskTlsServer(global::Org.BouncyCastle.Crypto.Tls.TlsPskIdentityManager pskIdentityManager) : this(new global::Org.BouncyCastle.Crypto.Tls.DefaultTlsCipherFactory(), pskIdentityManager)
		{
		}

		// Token: 0x06002262 RID: 8802 RVA: 0x00097DA7 File Offset: 0x00095FA7
		public PskTlsServer(global::Org.BouncyCastle.Crypto.Tls.TlsCipherFactory cipherFactory, global::Org.BouncyCastle.Crypto.Tls.TlsPskIdentityManager pskIdentityManager) : base(cipherFactory)
		{
			this.mPskIdentityManager = pskIdentityManager;
		}

		// Token: 0x06002263 RID: 8803 RVA: 0x00097DB7 File Offset: 0x00095FB7
		protected virtual global::Org.BouncyCastle.Crypto.Tls.TlsEncryptionCredentials GetRsaEncryptionCredentials()
		{
			throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
		}

		// Token: 0x06002264 RID: 8804 RVA: 0x00097DC0 File Offset: 0x00095FC0
		protected virtual global::Org.BouncyCastle.Crypto.Parameters.DHParameters GetDHParameters()
		{
			return global::Org.BouncyCastle.Crypto.Agreement.DHStandardGroups.rfc7919_ffdhe2048;
		}

		// Token: 0x06002265 RID: 8805 RVA: 0x00097DC7 File Offset: 0x00095FC7
		protected override int[] GetCipherSuites()
		{
			return new int[]
			{
				49207,
				49205,
				178,
				144
			};
		}

		// Token: 0x06002266 RID: 8806 RVA: 0x00097DDC File Offset: 0x00095FDC
		public override global::Org.BouncyCastle.Crypto.Tls.TlsCredentials GetCredentials()
		{
			int keyExchangeAlgorithm = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetKeyExchangeAlgorithm(this.mSelectedCipherSuite);
			if (keyExchangeAlgorithm - 13 > 1)
			{
				if (keyExchangeAlgorithm == 15)
				{
					return this.GetRsaEncryptionCredentials();
				}
				if (keyExchangeAlgorithm != 24)
				{
					throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
				}
			}
			return null;
		}

		// Token: 0x06002267 RID: 8807 RVA: 0x00097E18 File Offset: 0x00096018
		public override global::Org.BouncyCastle.Crypto.Tls.TlsKeyExchange GetKeyExchange()
		{
			int keyExchangeAlgorithm = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetKeyExchangeAlgorithm(this.mSelectedCipherSuite);
			if (keyExchangeAlgorithm - 13 <= 2 || keyExchangeAlgorithm == 24)
			{
				return this.CreatePskKeyExchange(keyExchangeAlgorithm);
			}
			throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
		}

		// Token: 0x06002268 RID: 8808 RVA: 0x00097E4C File Offset: 0x0009604C
		protected virtual global::Org.BouncyCastle.Crypto.Tls.TlsKeyExchange CreatePskKeyExchange(int keyExchange)
		{
			return new global::Org.BouncyCastle.Crypto.Tls.TlsPskKeyExchange(keyExchange, this.mSupportedSignatureAlgorithms, null, this.mPskIdentityManager, null, this.GetDHParameters(), this.mNamedCurves, this.mClientECPointFormats, this.mServerECPointFormats);
		}

		// Token: 0x04000DD5 RID: 3541
		protected global::Org.BouncyCastle.Crypto.Tls.TlsPskIdentityManager mPskIdentityManager;
	}
}
