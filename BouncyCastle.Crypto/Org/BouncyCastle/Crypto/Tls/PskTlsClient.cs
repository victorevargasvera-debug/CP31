using System;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000341 RID: 833
	public class PskTlsClient : global::Org.BouncyCastle.Crypto.Tls.AbstractTlsClient
	{
		// Token: 0x0600225A RID: 8794 RVA: 0x00097CD1 File Offset: 0x00095ED1
		public PskTlsClient(global::Org.BouncyCastle.Crypto.Tls.TlsPskIdentity pskIdentity) : this(new global::Org.BouncyCastle.Crypto.Tls.DefaultTlsCipherFactory(), pskIdentity)
		{
		}

		// Token: 0x0600225B RID: 8795 RVA: 0x00097CDF File Offset: 0x00095EDF
		public PskTlsClient(global::Org.BouncyCastle.Crypto.Tls.TlsCipherFactory cipherFactory, global::Org.BouncyCastle.Crypto.Tls.TlsPskIdentity pskIdentity) : this(cipherFactory, new global::Org.BouncyCastle.Crypto.Tls.DefaultTlsDHVerifier(), pskIdentity)
		{
		}

		// Token: 0x0600225C RID: 8796 RVA: 0x00097CEE File Offset: 0x00095EEE
		public PskTlsClient(global::Org.BouncyCastle.Crypto.Tls.TlsCipherFactory cipherFactory, global::Org.BouncyCastle.Crypto.Tls.TlsDHVerifier dhVerifier, global::Org.BouncyCastle.Crypto.Tls.TlsPskIdentity pskIdentity) : base(cipherFactory)
		{
			this.mDHVerifier = dhVerifier;
			this.mPskIdentity = pskIdentity;
		}

		// Token: 0x0600225D RID: 8797 RVA: 0x00097D05 File Offset: 0x00095F05
		public override int[] GetCipherSuites()
		{
			return new int[]
			{
				49207,
				49205
			};
		}

		// Token: 0x0600225E RID: 8798 RVA: 0x00097D20 File Offset: 0x00095F20
		public override global::Org.BouncyCastle.Crypto.Tls.TlsKeyExchange GetKeyExchange()
		{
			int keyExchangeAlgorithm = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetKeyExchangeAlgorithm(this.mSelectedCipherSuite);
			if (keyExchangeAlgorithm - 13 <= 2 || keyExchangeAlgorithm == 24)
			{
				return this.CreatePskKeyExchange(keyExchangeAlgorithm);
			}
			throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
		}

		// Token: 0x0600225F RID: 8799 RVA: 0x00097D54 File Offset: 0x00095F54
		public override global::Org.BouncyCastle.Crypto.Tls.TlsAuthentication GetAuthentication()
		{
			throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
		}

		// Token: 0x06002260 RID: 8800 RVA: 0x00097D60 File Offset: 0x00095F60
		protected virtual global::Org.BouncyCastle.Crypto.Tls.TlsKeyExchange CreatePskKeyExchange(int keyExchange)
		{
			return new global::Org.BouncyCastle.Crypto.Tls.TlsPskKeyExchange(keyExchange, this.mSupportedSignatureAlgorithms, this.mPskIdentity, null, this.mDHVerifier, null, this.mNamedCurves, this.mClientECPointFormats, this.mServerECPointFormats);
		}

		// Token: 0x04000DD3 RID: 3539
		protected global::Org.BouncyCastle.Crypto.Tls.TlsDHVerifier mDHVerifier;

		// Token: 0x04000DD4 RID: 3540
		protected global::Org.BouncyCastle.Crypto.Tls.TlsPskIdentity mPskIdentity;
	}
}
