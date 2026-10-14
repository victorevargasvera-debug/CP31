using System;
using System.Collections;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200034F RID: 847
	public class SrpTlsServer : global::Org.BouncyCastle.Crypto.Tls.AbstractTlsServer
	{
		// Token: 0x060022C9 RID: 8905 RVA: 0x00098C60 File Offset: 0x00096E60
		public SrpTlsServer(global::Org.BouncyCastle.Crypto.Tls.TlsSrpIdentityManager srpIdentityManager) : this(new global::Org.BouncyCastle.Crypto.Tls.DefaultTlsCipherFactory(), srpIdentityManager)
		{
		}

		// Token: 0x060022CA RID: 8906 RVA: 0x00098C6E File Offset: 0x00096E6E
		public SrpTlsServer(global::Org.BouncyCastle.Crypto.Tls.TlsCipherFactory cipherFactory, global::Org.BouncyCastle.Crypto.Tls.TlsSrpIdentityManager srpIdentityManager) : base(cipherFactory)
		{
			this.mSrpIdentityManager = srpIdentityManager;
		}

		// Token: 0x060022CB RID: 8907 RVA: 0x00098C7E File Offset: 0x00096E7E
		protected virtual global::Org.BouncyCastle.Crypto.Tls.TlsSignerCredentials GetDsaSignerCredentials()
		{
			throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
		}

		// Token: 0x060022CC RID: 8908 RVA: 0x00098C87 File Offset: 0x00096E87
		protected virtual global::Org.BouncyCastle.Crypto.Tls.TlsSignerCredentials GetRsaSignerCredentials()
		{
			throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
		}

		// Token: 0x060022CD RID: 8909 RVA: 0x00098C90 File Offset: 0x00096E90
		protected override int[] GetCipherSuites()
		{
			return new int[]
			{
				49186,
				49183,
				49185,
				49182,
				49184,
				49181
			};
		}

		// Token: 0x060022CE RID: 8910 RVA: 0x00098CA3 File Offset: 0x00096EA3
		public override void ProcessClientExtensions(global::System.Collections.IDictionary clientExtensions)
		{
			base.ProcessClientExtensions(clientExtensions);
			this.mSrpIdentity = global::Org.BouncyCastle.Crypto.Tls.TlsSrpUtilities.GetSrpExtension(clientExtensions);
		}

		// Token: 0x060022CF RID: 8911 RVA: 0x00098CB8 File Offset: 0x00096EB8
		public override int GetSelectedCipherSuite()
		{
			int selectedCipherSuite = base.GetSelectedCipherSuite();
			if (global::Org.BouncyCastle.Crypto.Tls.TlsSrpUtilities.IsSrpCipherSuite(selectedCipherSuite))
			{
				if (this.mSrpIdentity != null)
				{
					this.mLoginParameters = this.mSrpIdentityManager.GetLoginParameters(this.mSrpIdentity);
				}
				if (this.mLoginParameters == null)
				{
					throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(115);
				}
			}
			return selectedCipherSuite;
		}

		// Token: 0x060022D0 RID: 8912 RVA: 0x00098CF8 File Offset: 0x00096EF8
		public override global::Org.BouncyCastle.Crypto.Tls.TlsCredentials GetCredentials()
		{
			switch (global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetKeyExchangeAlgorithm(this.mSelectedCipherSuite))
			{
			case 21:
				return null;
			case 22:
				return this.GetDsaSignerCredentials();
			case 23:
				return this.GetRsaSignerCredentials();
			default:
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
			}
		}

		// Token: 0x060022D1 RID: 8913 RVA: 0x00098D40 File Offset: 0x00096F40
		public override global::Org.BouncyCastle.Crypto.Tls.TlsKeyExchange GetKeyExchange()
		{
			int keyExchangeAlgorithm = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetKeyExchangeAlgorithm(this.mSelectedCipherSuite);
			if (keyExchangeAlgorithm - 21 <= 2)
			{
				return this.CreateSrpKeyExchange(keyExchangeAlgorithm);
			}
			throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
		}

		// Token: 0x060022D2 RID: 8914 RVA: 0x00098D6F File Offset: 0x00096F6F
		protected virtual global::Org.BouncyCastle.Crypto.Tls.TlsKeyExchange CreateSrpKeyExchange(int keyExchange)
		{
			return new global::Org.BouncyCastle.Crypto.Tls.TlsSrpKeyExchange(keyExchange, this.mSupportedSignatureAlgorithms, this.mSrpIdentity, this.mLoginParameters);
		}

		// Token: 0x04000E1B RID: 3611
		protected global::Org.BouncyCastle.Crypto.Tls.TlsSrpIdentityManager mSrpIdentityManager;

		// Token: 0x04000E1C RID: 3612
		protected byte[] mSrpIdentity;

		// Token: 0x04000E1D RID: 3613
		protected global::Org.BouncyCastle.Crypto.Tls.TlsSrpLoginParameters mLoginParameters;
	}
}
