using System;
using System.IO;
using Org.BouncyCastle.Tls.Crypto;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x02000103 RID: 259
	public class TlsDHanonKeyExchange : global::Org.BouncyCastle.Tls.AbstractTlsKeyExchange
	{
		// Token: 0x0600093A RID: 2362 RVA: 0x00025794 File Offset: 0x00023994
		private static int CheckKeyExchange(int keyExchange)
		{
			if (keyExchange == 11)
			{
				return keyExchange;
			}
			throw new global::System.ArgumentException("unsupported key exchange algorithm", "keyExchange");
		}

		// Token: 0x0600093B RID: 2363 RVA: 0x000257AC File Offset: 0x000239AC
		public TlsDHanonKeyExchange(int keyExchange, global::Org.BouncyCastle.Tls.TlsDHGroupVerifier dhGroupVerifier) : this(keyExchange, dhGroupVerifier, null)
		{
		}

		// Token: 0x0600093C RID: 2364 RVA: 0x000257B7 File Offset: 0x000239B7
		public TlsDHanonKeyExchange(int keyExchange, global::Org.BouncyCastle.Tls.Crypto.TlsDHConfig dhConfig) : this(keyExchange, null, dhConfig)
		{
		}

		// Token: 0x0600093D RID: 2365 RVA: 0x000257C2 File Offset: 0x000239C2
		private TlsDHanonKeyExchange(int keyExchange, global::Org.BouncyCastle.Tls.TlsDHGroupVerifier dhGroupVerifier, global::Org.BouncyCastle.Tls.Crypto.TlsDHConfig dhConfig) : base(global::Org.BouncyCastle.Tls.TlsDHanonKeyExchange.CheckKeyExchange(keyExchange))
		{
			this.m_dhGroupVerifier = dhGroupVerifier;
			this.m_dhConfig = dhConfig;
		}

		// Token: 0x0600093E RID: 2366 RVA: 0x000257DE File Offset: 0x000239DE
		public override void SkipServerCredentials()
		{
		}

		// Token: 0x0600093F RID: 2367 RVA: 0x000257E0 File Offset: 0x000239E0
		public override void ProcessServerCredentials(global::Org.BouncyCastle.Tls.TlsCredentials serverCredentials)
		{
			throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
		}

		// Token: 0x06000940 RID: 2368 RVA: 0x000257E9 File Offset: 0x000239E9
		public override void ProcessServerCertificate(global::Org.BouncyCastle.Tls.Certificate serverCertificate)
		{
			throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(10);
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x06000941 RID: 2369 RVA: 0x000257F2 File Offset: 0x000239F2
		public override bool RequiresServerKeyExchange
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000942 RID: 2370 RVA: 0x000257F8 File Offset: 0x000239F8
		public override byte[] GenerateServerKeyExchange()
		{
			global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream();
			global::Org.BouncyCastle.Tls.TlsDHUtilities.WriteDHConfig(this.m_dhConfig, buf);
			this.m_agreement = this.m_context.Crypto.CreateDHDomain(this.m_dhConfig).CreateDH();
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteOpaque16(this.m_agreement.GenerateEphemeral(), buf);
			return buf.ToArray();
		}

		// Token: 0x06000943 RID: 2371 RVA: 0x00025850 File Offset: 0x00023A50
		public override void ProcessServerKeyExchange(global::System.IO.Stream input)
		{
			this.m_dhConfig = global::Org.BouncyCastle.Tls.TlsDHUtilities.ReceiveDHConfig(this.m_context, this.m_dhGroupVerifier, input);
			byte[] y = global::Org.BouncyCastle.Tls.TlsUtilities.ReadOpaque16(input, 1);
			this.m_agreement = this.m_context.Crypto.CreateDHDomain(this.m_dhConfig).CreateDH();
			this.m_agreement.ReceivePeerValue(y);
		}

		// Token: 0x06000944 RID: 2372 RVA: 0x000258AA File Offset: 0x00023AAA
		public override short[] GetClientCertificateTypes()
		{
			return null;
		}

		// Token: 0x06000945 RID: 2373 RVA: 0x000258AD File Offset: 0x00023AAD
		public override void ProcessClientCredentials(global::Org.BouncyCastle.Tls.TlsCredentials clientCredentials)
		{
			throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x000258B6 File Offset: 0x00023AB6
		public override void GenerateClientKeyExchange(global::System.IO.Stream output)
		{
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteOpaque16(this.m_agreement.GenerateEphemeral(), output);
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x000258C9 File Offset: 0x00023AC9
		public override void ProcessClientCertificate(global::Org.BouncyCastle.Tls.Certificate clientCertificate)
		{
			throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(10);
		}

		// Token: 0x06000948 RID: 2376 RVA: 0x000258D4 File Offset: 0x00023AD4
		public override void ProcessClientKeyExchange(global::System.IO.Stream input)
		{
			byte[] y = global::Org.BouncyCastle.Tls.TlsUtilities.ReadOpaque16(input, 1);
			this.m_agreement.ReceivePeerValue(y);
		}

		// Token: 0x06000949 RID: 2377 RVA: 0x000258F5 File Offset: 0x00023AF5
		public override global::Org.BouncyCastle.Tls.Crypto.TlsSecret GeneratePreMasterSecret()
		{
			return this.m_agreement.CalculateSecret();
		}

		// Token: 0x040006E1 RID: 1761
		protected global::Org.BouncyCastle.Tls.TlsDHGroupVerifier m_dhGroupVerifier;

		// Token: 0x040006E2 RID: 1762
		protected global::Org.BouncyCastle.Tls.Crypto.TlsDHConfig m_dhConfig;

		// Token: 0x040006E3 RID: 1763
		protected global::Org.BouncyCastle.Tls.Crypto.TlsAgreement m_agreement;
	}
}
