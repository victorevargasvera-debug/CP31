using System;
using System.IO;
using Org.BouncyCastle.Tls.Crypto;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x02000106 RID: 262
	public class TlsDHKeyExchange : global::Org.BouncyCastle.Tls.AbstractTlsKeyExchange
	{
		// Token: 0x0600095A RID: 2394 RVA: 0x00025AB0 File Offset: 0x00023CB0
		private static int CheckKeyExchange(int keyExchange)
		{
			if (keyExchange == 7 || keyExchange == 9)
			{
				return keyExchange;
			}
			throw new global::System.ArgumentException("unsupported key exchange algorithm", "keyExchange");
		}

		// Token: 0x0600095B RID: 2395 RVA: 0x00025ACC File Offset: 0x00023CCC
		public TlsDHKeyExchange(int keyExchange) : base(global::Org.BouncyCastle.Tls.TlsDHKeyExchange.CheckKeyExchange(keyExchange))
		{
		}

		// Token: 0x0600095C RID: 2396 RVA: 0x00025ADA File Offset: 0x00023CDA
		public override void SkipServerCredentials()
		{
			throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
		}

		// Token: 0x0600095D RID: 2397 RVA: 0x00025AE3 File Offset: 0x00023CE3
		public override void ProcessServerCredentials(global::Org.BouncyCastle.Tls.TlsCredentials serverCredentials)
		{
			this.m_agreementCredentials = global::Org.BouncyCastle.Tls.TlsUtilities.RequireAgreementCredentials(serverCredentials);
		}

		// Token: 0x0600095E RID: 2398 RVA: 0x00025AF1 File Offset: 0x00023CF1
		public override void ProcessServerCertificate(global::Org.BouncyCastle.Tls.Certificate serverCertificate)
		{
			this.m_dhPeerCertificate = serverCertificate.GetCertificateAt(0).CheckUsageInRole(1);
		}

		// Token: 0x0600095F RID: 2399 RVA: 0x00025B06 File Offset: 0x00023D06
		public override short[] GetClientCertificateTypes()
		{
			return new short[]
			{
				4,
				3
			};
		}

		// Token: 0x06000960 RID: 2400 RVA: 0x00025B16 File Offset: 0x00023D16
		public override void SkipClientCredentials()
		{
			throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(10);
		}

		// Token: 0x06000961 RID: 2401 RVA: 0x00025B1F File Offset: 0x00023D1F
		public override void ProcessClientCredentials(global::Org.BouncyCastle.Tls.TlsCredentials clientCredentials)
		{
			this.m_agreementCredentials = global::Org.BouncyCastle.Tls.TlsUtilities.RequireAgreementCredentials(clientCredentials);
		}

		// Token: 0x06000962 RID: 2402 RVA: 0x00025B2D File Offset: 0x00023D2D
		public override void GenerateClientKeyExchange(global::System.IO.Stream output)
		{
		}

		// Token: 0x06000963 RID: 2403 RVA: 0x00025B2F File Offset: 0x00023D2F
		public override void ProcessClientCertificate(global::Org.BouncyCastle.Tls.Certificate clientCertificate)
		{
			this.m_dhPeerCertificate = clientCertificate.GetCertificateAt(0).CheckUsageInRole(1);
		}

		// Token: 0x06000964 RID: 2404 RVA: 0x00025B44 File Offset: 0x00023D44
		public override void ProcessClientKeyExchange(global::System.IO.Stream input)
		{
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x06000965 RID: 2405 RVA: 0x00025B46 File Offset: 0x00023D46
		public override bool RequiresCertificateVerify
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000966 RID: 2406 RVA: 0x00025B49 File Offset: 0x00023D49
		public override global::Org.BouncyCastle.Tls.Crypto.TlsSecret GeneratePreMasterSecret()
		{
			return this.m_agreementCredentials.GenerateAgreement(this.m_dhPeerCertificate);
		}

		// Token: 0x040006E9 RID: 1769
		protected global::Org.BouncyCastle.Tls.TlsCredentialedAgreement m_agreementCredentials;

		// Token: 0x040006EA RID: 1770
		protected global::Org.BouncyCastle.Tls.Crypto.TlsCertificate m_dhPeerCertificate;
	}
}
