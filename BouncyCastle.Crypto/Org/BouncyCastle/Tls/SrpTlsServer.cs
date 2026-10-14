using System;
using System.Collections;
using Org.BouncyCastle.Tls.Crypto;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000F2 RID: 242
	public class SrpTlsServer : global::Org.BouncyCastle.Tls.AbstractTlsServer
	{
		// Token: 0x060008CB RID: 2251 RVA: 0x0002383A File Offset: 0x00021A3A
		public SrpTlsServer(global::Org.BouncyCastle.Tls.Crypto.TlsCrypto crypto, global::Org.BouncyCastle.Tls.TlsSrpIdentityManager srpIdentityManager) : base(crypto)
		{
			this.m_srpIdentityManager = srpIdentityManager;
		}

		// Token: 0x060008CC RID: 2252 RVA: 0x0002384A File Offset: 0x00021A4A
		protected virtual global::Org.BouncyCastle.Tls.TlsCredentialedSigner GetDsaSignerCredentials()
		{
			throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
		}

		// Token: 0x060008CD RID: 2253 RVA: 0x00023853 File Offset: 0x00021A53
		protected virtual global::Org.BouncyCastle.Tls.TlsCredentialedSigner GetRsaSignerCredentials()
		{
			throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
		}

		// Token: 0x060008CE RID: 2254 RVA: 0x0002385C File Offset: 0x00021A5C
		protected override global::Org.BouncyCastle.Tls.ProtocolVersion[] GetSupportedVersions()
		{
			return global::Org.BouncyCastle.Tls.ProtocolVersion.TLSv12.DownTo(global::Org.BouncyCastle.Tls.ProtocolVersion.TLSv10);
		}

		// Token: 0x060008CF RID: 2255 RVA: 0x0002386D File Offset: 0x00021A6D
		protected override int[] GetSupportedCipherSuites()
		{
			return global::Org.BouncyCastle.Tls.TlsUtilities.GetSupportedCipherSuites(this.Crypto, global::Org.BouncyCastle.Tls.SrpTlsServer.DefaultCipherSuites);
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x0002387F File Offset: 0x00021A7F
		public override void ProcessClientExtensions(global::System.Collections.IDictionary clientExtensions)
		{
			base.ProcessClientExtensions(clientExtensions);
			this.m_srpIdentity = global::Org.BouncyCastle.Tls.TlsSrpUtilities.GetSrpExtension(clientExtensions);
		}

		// Token: 0x060008D1 RID: 2257 RVA: 0x00023894 File Offset: 0x00021A94
		public override int GetSelectedCipherSuite()
		{
			int selectedCipherSuite = base.GetSelectedCipherSuite();
			if (global::Org.BouncyCastle.Tls.TlsSrpUtilities.IsSrpCipherSuite(selectedCipherSuite))
			{
				if (this.m_srpIdentity != null)
				{
					this.m_srpLoginParameters = this.m_srpIdentityManager.GetLoginParameters(this.m_srpIdentity);
				}
				if (this.m_srpLoginParameters == null)
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(115);
				}
			}
			return selectedCipherSuite;
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x000238D4 File Offset: 0x00021AD4
		public override global::Org.BouncyCastle.Tls.TlsCredentials GetCredentials()
		{
			switch (this.m_context.SecurityParameters.KeyExchangeAlgorithm)
			{
			case 21:
				return null;
			case 22:
				return this.GetDsaSignerCredentials();
			case 23:
				return this.GetRsaSignerCredentials();
			default:
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
		}

		// Token: 0x060008D3 RID: 2259 RVA: 0x00023920 File Offset: 0x00021B20
		public override global::Org.BouncyCastle.Tls.TlsSrpLoginParameters GetSrpLoginParameters()
		{
			return this.m_srpLoginParameters;
		}

		// Token: 0x040006C3 RID: 1731
		private static readonly int[] DefaultCipherSuites = new int[]
		{
			49186,
			49183,
			49185,
			49182,
			49184,
			49181
		};

		// Token: 0x040006C4 RID: 1732
		protected readonly global::Org.BouncyCastle.Tls.TlsSrpIdentityManager m_srpIdentityManager;

		// Token: 0x040006C5 RID: 1733
		protected byte[] m_srpIdentity;

		// Token: 0x040006C6 RID: 1734
		protected global::Org.BouncyCastle.Tls.TlsSrpLoginParameters m_srpLoginParameters;
	}
}
