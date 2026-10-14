using System;
using System.IO;
using Org.BouncyCastle.Tls.Crypto;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x02000109 RID: 265
	public class TlsECDHanonKeyExchange : global::Org.BouncyCastle.Tls.AbstractTlsKeyExchange
	{
		// Token: 0x0600097B RID: 2427 RVA: 0x00025F63 File Offset: 0x00024163
		private static int CheckKeyExchange(int keyExchange)
		{
			if (keyExchange == 20)
			{
				return keyExchange;
			}
			throw new global::System.ArgumentException("unsupported key exchange algorithm", "keyExchange");
		}

		// Token: 0x0600097C RID: 2428 RVA: 0x00025F7B File Offset: 0x0002417B
		public TlsECDHanonKeyExchange(int keyExchange) : this(keyExchange, null)
		{
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x00025F85 File Offset: 0x00024185
		public TlsECDHanonKeyExchange(int keyExchange, global::Org.BouncyCastle.Tls.Crypto.TlsECConfig ecConfig) : base(global::Org.BouncyCastle.Tls.TlsECDHanonKeyExchange.CheckKeyExchange(keyExchange))
		{
			this.m_ecConfig = ecConfig;
		}

		// Token: 0x0600097E RID: 2430 RVA: 0x00025F9A File Offset: 0x0002419A
		public override void SkipServerCredentials()
		{
		}

		// Token: 0x0600097F RID: 2431 RVA: 0x00025F9C File Offset: 0x0002419C
		public override void ProcessServerCredentials(global::Org.BouncyCastle.Tls.TlsCredentials serverCredentials)
		{
			throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
		}

		// Token: 0x06000980 RID: 2432 RVA: 0x00025FA5 File Offset: 0x000241A5
		public override void ProcessServerCertificate(global::Org.BouncyCastle.Tls.Certificate serverCertificate)
		{
			throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(10);
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x06000981 RID: 2433 RVA: 0x00025FAE File Offset: 0x000241AE
		public override bool RequiresServerKeyExchange
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x00025FB4 File Offset: 0x000241B4
		public override byte[] GenerateServerKeyExchange()
		{
			global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream();
			global::Org.BouncyCastle.Tls.TlsEccUtilities.WriteECConfig(this.m_ecConfig, buf);
			this.m_agreement = this.m_context.Crypto.CreateECDomain(this.m_ecConfig).CreateECDH();
			this.GenerateEphemeral(buf);
			return buf.ToArray();
		}

		// Token: 0x06000983 RID: 2435 RVA: 0x00026004 File Offset: 0x00024204
		public override void ProcessServerKeyExchange(global::System.IO.Stream input)
		{
			this.m_ecConfig = global::Org.BouncyCastle.Tls.TlsEccUtilities.ReceiveECDHConfig(this.m_context, input);
			byte[] point = global::Org.BouncyCastle.Tls.TlsUtilities.ReadOpaque8(input, 1);
			this.m_agreement = this.m_context.Crypto.CreateECDomain(this.m_ecConfig).CreateECDH();
			this.ProcessEphemeral(point);
		}

		// Token: 0x06000984 RID: 2436 RVA: 0x00026053 File Offset: 0x00024253
		public override short[] GetClientCertificateTypes()
		{
			return null;
		}

		// Token: 0x06000985 RID: 2437 RVA: 0x00026056 File Offset: 0x00024256
		public override void ProcessClientCredentials(global::Org.BouncyCastle.Tls.TlsCredentials clientCredentials)
		{
			throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
		}

		// Token: 0x06000986 RID: 2438 RVA: 0x0002605F File Offset: 0x0002425F
		public override void GenerateClientKeyExchange(global::System.IO.Stream output)
		{
			this.GenerateEphemeral(output);
		}

		// Token: 0x06000987 RID: 2439 RVA: 0x00026068 File Offset: 0x00024268
		public override void ProcessClientCertificate(global::Org.BouncyCastle.Tls.Certificate clientCertificate)
		{
			throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(10);
		}

		// Token: 0x06000988 RID: 2440 RVA: 0x00026074 File Offset: 0x00024274
		public override void ProcessClientKeyExchange(global::System.IO.Stream input)
		{
			byte[] point = global::Org.BouncyCastle.Tls.TlsUtilities.ReadOpaque8(input, 1);
			this.ProcessEphemeral(point);
		}

		// Token: 0x06000989 RID: 2441 RVA: 0x00026090 File Offset: 0x00024290
		public override global::Org.BouncyCastle.Tls.Crypto.TlsSecret GeneratePreMasterSecret()
		{
			return this.m_agreement.CalculateSecret();
		}

		// Token: 0x0600098A RID: 2442 RVA: 0x0002609D File Offset: 0x0002429D
		protected virtual void GenerateEphemeral(global::System.IO.Stream output)
		{
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteOpaque8(this.m_agreement.GenerateEphemeral(), output);
		}

		// Token: 0x0600098B RID: 2443 RVA: 0x000260B0 File Offset: 0x000242B0
		protected virtual void ProcessEphemeral(byte[] point)
		{
			global::Org.BouncyCastle.Tls.TlsEccUtilities.CheckPointEncoding(this.m_ecConfig.NamedGroup, point);
			this.m_agreement.ReceivePeerValue(point);
		}

		// Token: 0x040006EB RID: 1771
		protected global::Org.BouncyCastle.Tls.Crypto.TlsECConfig m_ecConfig;

		// Token: 0x040006EC RID: 1772
		protected global::Org.BouncyCastle.Tls.Crypto.TlsAgreement m_agreement;
	}
}
