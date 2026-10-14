using System;
using System.IO;
using Org.BouncyCastle.Tls.Crypto;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x0200010A RID: 266
	public class TlsECDheKeyExchange : global::Org.BouncyCastle.Tls.AbstractTlsKeyExchange
	{
		// Token: 0x0600098C RID: 2444 RVA: 0x000260CF File Offset: 0x000242CF
		private static int CheckKeyExchange(int keyExchange)
		{
			if (keyExchange == 17 || keyExchange == 19)
			{
				return keyExchange;
			}
			throw new global::System.ArgumentException("unsupported key exchange algorithm", "keyExchange");
		}

		// Token: 0x0600098D RID: 2445 RVA: 0x000260EC File Offset: 0x000242EC
		public TlsECDheKeyExchange(int keyExchange) : this(keyExchange, null)
		{
		}

		// Token: 0x0600098E RID: 2446 RVA: 0x000260F6 File Offset: 0x000242F6
		public TlsECDheKeyExchange(int keyExchange, global::Org.BouncyCastle.Tls.Crypto.TlsECConfig ecConfig) : base(global::Org.BouncyCastle.Tls.TlsECDheKeyExchange.CheckKeyExchange(keyExchange))
		{
			this.m_ecConfig = ecConfig;
		}

		// Token: 0x0600098F RID: 2447 RVA: 0x0002610B File Offset: 0x0002430B
		public override void SkipServerCredentials()
		{
			throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
		}

		// Token: 0x06000990 RID: 2448 RVA: 0x00026114 File Offset: 0x00024314
		public override void ProcessServerCredentials(global::Org.BouncyCastle.Tls.TlsCredentials serverCredentials)
		{
			this.m_serverCredentials = global::Org.BouncyCastle.Tls.TlsUtilities.RequireSignerCredentials(serverCredentials);
		}

		// Token: 0x06000991 RID: 2449 RVA: 0x00026122 File Offset: 0x00024322
		public override void ProcessServerCertificate(global::Org.BouncyCastle.Tls.Certificate serverCertificate)
		{
			this.m_serverCertificate = serverCertificate.GetCertificateAt(0);
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x06000992 RID: 2450 RVA: 0x00026131 File Offset: 0x00024331
		public override bool RequiresServerKeyExchange
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000993 RID: 2451 RVA: 0x00026134 File Offset: 0x00024334
		public override byte[] GenerateServerKeyExchange()
		{
			global::Org.BouncyCastle.Tls.DigestInputBuffer digestBuffer = new global::Org.BouncyCastle.Tls.DigestInputBuffer();
			global::Org.BouncyCastle.Tls.TlsEccUtilities.WriteECConfig(this.m_ecConfig, digestBuffer);
			this.m_agreement = this.m_context.Crypto.CreateECDomain(this.m_ecConfig).CreateECDH();
			this.GenerateEphemeral(digestBuffer);
			global::Org.BouncyCastle.Tls.TlsUtilities.GenerateServerKeyExchangeSignature(this.m_context, this.m_serverCredentials, null, digestBuffer);
			return digestBuffer.ToArray();
		}

		// Token: 0x06000994 RID: 2452 RVA: 0x00026194 File Offset: 0x00024394
		public override void ProcessServerKeyExchange(global::System.IO.Stream input)
		{
			global::Org.BouncyCastle.Tls.DigestInputBuffer digestBuffer = new global::Org.BouncyCastle.Tls.DigestInputBuffer();
			global::System.IO.Stream teeIn = new global::Org.BouncyCastle.Utilities.IO.TeeInputStream(input, digestBuffer);
			this.m_ecConfig = global::Org.BouncyCastle.Tls.TlsEccUtilities.ReceiveECDHConfig(this.m_context, teeIn);
			byte[] point = global::Org.BouncyCastle.Tls.TlsUtilities.ReadOpaque8(teeIn, 1);
			global::Org.BouncyCastle.Tls.TlsUtilities.VerifyServerKeyExchangeSignature(this.m_context, input, this.m_serverCertificate, null, digestBuffer);
			this.m_agreement = this.m_context.Crypto.CreateECDomain(this.m_ecConfig).CreateECDH();
			this.ProcessEphemeral(point);
		}

		// Token: 0x06000995 RID: 2453 RVA: 0x00026205 File Offset: 0x00024405
		public override short[] GetClientCertificateTypes()
		{
			return new short[]
			{
				2,
				64,
				1
			};
		}

		// Token: 0x06000996 RID: 2454 RVA: 0x00026218 File Offset: 0x00024418
		public override void ProcessClientCredentials(global::Org.BouncyCastle.Tls.TlsCredentials clientCredentials)
		{
			global::Org.BouncyCastle.Tls.TlsUtilities.RequireSignerCredentials(clientCredentials);
		}

		// Token: 0x06000997 RID: 2455 RVA: 0x00026221 File Offset: 0x00024421
		public override void GenerateClientKeyExchange(global::System.IO.Stream output)
		{
			this.GenerateEphemeral(output);
		}

		// Token: 0x06000998 RID: 2456 RVA: 0x0002622C File Offset: 0x0002442C
		public override void ProcessClientKeyExchange(global::System.IO.Stream input)
		{
			byte[] point = global::Org.BouncyCastle.Tls.TlsUtilities.ReadOpaque8(input, 1);
			this.ProcessEphemeral(point);
		}

		// Token: 0x06000999 RID: 2457 RVA: 0x00026248 File Offset: 0x00024448
		public override global::Org.BouncyCastle.Tls.Crypto.TlsSecret GeneratePreMasterSecret()
		{
			return this.m_agreement.CalculateSecret();
		}

		// Token: 0x0600099A RID: 2458 RVA: 0x00026255 File Offset: 0x00024455
		protected virtual void GenerateEphemeral(global::System.IO.Stream output)
		{
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteOpaque8(this.m_agreement.GenerateEphemeral(), output);
		}

		// Token: 0x0600099B RID: 2459 RVA: 0x00026268 File Offset: 0x00024468
		protected virtual void ProcessEphemeral(byte[] point)
		{
			global::Org.BouncyCastle.Tls.TlsEccUtilities.CheckPointEncoding(this.m_ecConfig.NamedGroup, point);
			this.m_agreement.ReceivePeerValue(point);
		}

		// Token: 0x040006ED RID: 1773
		protected global::Org.BouncyCastle.Tls.Crypto.TlsECConfig m_ecConfig;

		// Token: 0x040006EE RID: 1774
		protected global::Org.BouncyCastle.Tls.TlsCredentialedSigner m_serverCredentials;

		// Token: 0x040006EF RID: 1775
		protected global::Org.BouncyCastle.Tls.Crypto.TlsCertificate m_serverCertificate;

		// Token: 0x040006F0 RID: 1776
		protected global::Org.BouncyCastle.Tls.Crypto.TlsAgreement m_agreement;
	}
}
