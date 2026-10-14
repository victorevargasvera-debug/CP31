using System;
using System.IO;
using Org.BouncyCastle.Tls.Crypto;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x0200010B RID: 267
	public class TlsECDHKeyExchange : global::Org.BouncyCastle.Tls.AbstractTlsKeyExchange
	{
		// Token: 0x0600099C RID: 2460 RVA: 0x00026287 File Offset: 0x00024487
		private static int CheckKeyExchange(int keyExchange)
		{
			if (keyExchange == 16 || keyExchange == 18)
			{
				return keyExchange;
			}
			throw new global::System.ArgumentException("unsupported key exchange algorithm", "keyExchange");
		}

		// Token: 0x0600099D RID: 2461 RVA: 0x000262A4 File Offset: 0x000244A4
		public TlsECDHKeyExchange(int keyExchange) : base(global::Org.BouncyCastle.Tls.TlsECDHKeyExchange.CheckKeyExchange(keyExchange))
		{
		}

		// Token: 0x0600099E RID: 2462 RVA: 0x000262B2 File Offset: 0x000244B2
		public override void SkipServerCredentials()
		{
			throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
		}

		// Token: 0x0600099F RID: 2463 RVA: 0x000262BB File Offset: 0x000244BB
		public override void ProcessServerCredentials(global::Org.BouncyCastle.Tls.TlsCredentials serverCredentials)
		{
			this.m_agreementCredentials = global::Org.BouncyCastle.Tls.TlsUtilities.RequireAgreementCredentials(serverCredentials);
		}

		// Token: 0x060009A0 RID: 2464 RVA: 0x000262C9 File Offset: 0x000244C9
		public override void ProcessServerCertificate(global::Org.BouncyCastle.Tls.Certificate serverCertificate)
		{
			this.m_ecdhPeerCertificate = serverCertificate.GetCertificateAt(0).CheckUsageInRole(2);
		}

		// Token: 0x060009A1 RID: 2465 RVA: 0x000262DE File Offset: 0x000244DE
		public override short[] GetClientCertificateTypes()
		{
			return new short[]
			{
				66,
				65
			};
		}

		// Token: 0x060009A2 RID: 2466 RVA: 0x000262F0 File Offset: 0x000244F0
		public override void SkipClientCredentials()
		{
			throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(10);
		}

		// Token: 0x060009A3 RID: 2467 RVA: 0x000262F9 File Offset: 0x000244F9
		public override void ProcessClientCredentials(global::Org.BouncyCastle.Tls.TlsCredentials clientCredentials)
		{
			this.m_agreementCredentials = global::Org.BouncyCastle.Tls.TlsUtilities.RequireAgreementCredentials(clientCredentials);
		}

		// Token: 0x060009A4 RID: 2468 RVA: 0x00026307 File Offset: 0x00024507
		public override void GenerateClientKeyExchange(global::System.IO.Stream output)
		{
		}

		// Token: 0x060009A5 RID: 2469 RVA: 0x00026309 File Offset: 0x00024509
		public override void ProcessClientCertificate(global::Org.BouncyCastle.Tls.Certificate clientCertificate)
		{
			this.m_ecdhPeerCertificate = clientCertificate.GetCertificateAt(0).CheckUsageInRole(2);
		}

		// Token: 0x060009A6 RID: 2470 RVA: 0x0002631E File Offset: 0x0002451E
		public override void ProcessClientKeyExchange(global::System.IO.Stream input)
		{
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x060009A7 RID: 2471 RVA: 0x00026320 File Offset: 0x00024520
		public override bool RequiresCertificateVerify
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060009A8 RID: 2472 RVA: 0x00026323 File Offset: 0x00024523
		public override global::Org.BouncyCastle.Tls.Crypto.TlsSecret GeneratePreMasterSecret()
		{
			return this.m_agreementCredentials.GenerateAgreement(this.m_ecdhPeerCertificate);
		}

		// Token: 0x040006F1 RID: 1777
		protected global::Org.BouncyCastle.Tls.TlsCredentialedAgreement m_agreementCredentials;

		// Token: 0x040006F2 RID: 1778
		protected global::Org.BouncyCastle.Tls.Crypto.TlsCertificate m_ecdhPeerCertificate;
	}
}
