using System;
using System.IO;
using Org.BouncyCastle.Tls.Crypto;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x02000104 RID: 260
	public class TlsDheKeyExchange : global::Org.BouncyCastle.Tls.AbstractTlsKeyExchange
	{
		// Token: 0x0600094A RID: 2378 RVA: 0x00025902 File Offset: 0x00023B02
		private static int CheckKeyExchange(int keyExchange)
		{
			if (keyExchange == 3 || keyExchange == 5)
			{
				return keyExchange;
			}
			throw new global::System.ArgumentException("unsupported key exchange algorithm", "keyExchange");
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x0002591D File Offset: 0x00023B1D
		public TlsDheKeyExchange(int keyExchange, global::Org.BouncyCastle.Tls.TlsDHGroupVerifier dhGroupVerifier) : this(keyExchange, dhGroupVerifier, null)
		{
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x00025928 File Offset: 0x00023B28
		public TlsDheKeyExchange(int keyExchange, global::Org.BouncyCastle.Tls.Crypto.TlsDHConfig dhConfig) : this(keyExchange, null, dhConfig)
		{
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x00025933 File Offset: 0x00023B33
		private TlsDheKeyExchange(int keyExchange, global::Org.BouncyCastle.Tls.TlsDHGroupVerifier dhGroupVerifier, global::Org.BouncyCastle.Tls.Crypto.TlsDHConfig dhConfig) : base(global::Org.BouncyCastle.Tls.TlsDheKeyExchange.CheckKeyExchange(keyExchange))
		{
			this.m_dhGroupVerifier = dhGroupVerifier;
			this.m_dhConfig = dhConfig;
		}

		// Token: 0x0600094E RID: 2382 RVA: 0x0002594F File Offset: 0x00023B4F
		public override void SkipServerCredentials()
		{
			throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
		}

		// Token: 0x0600094F RID: 2383 RVA: 0x00025958 File Offset: 0x00023B58
		public override void ProcessServerCredentials(global::Org.BouncyCastle.Tls.TlsCredentials serverCredentials)
		{
			this.m_serverCredentials = global::Org.BouncyCastle.Tls.TlsUtilities.RequireSignerCredentials(serverCredentials);
		}

		// Token: 0x06000950 RID: 2384 RVA: 0x00025966 File Offset: 0x00023B66
		public override void ProcessServerCertificate(global::Org.BouncyCastle.Tls.Certificate serverCertificate)
		{
			this.m_serverCertificate = serverCertificate.GetCertificateAt(0);
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x06000951 RID: 2385 RVA: 0x00025975 File Offset: 0x00023B75
		public override bool RequiresServerKeyExchange
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000952 RID: 2386 RVA: 0x00025978 File Offset: 0x00023B78
		public override byte[] GenerateServerKeyExchange()
		{
			global::Org.BouncyCastle.Tls.DigestInputBuffer digestBuffer = new global::Org.BouncyCastle.Tls.DigestInputBuffer();
			global::Org.BouncyCastle.Tls.TlsDHUtilities.WriteDHConfig(this.m_dhConfig, digestBuffer);
			this.m_agreement = this.m_context.Crypto.CreateDHDomain(this.m_dhConfig).CreateDH();
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteOpaque16(this.m_agreement.GenerateEphemeral(), digestBuffer);
			global::Org.BouncyCastle.Tls.TlsUtilities.GenerateServerKeyExchangeSignature(this.m_context, this.m_serverCredentials, null, digestBuffer);
			return digestBuffer.ToArray();
		}

		// Token: 0x06000953 RID: 2387 RVA: 0x000259E4 File Offset: 0x00023BE4
		public override void ProcessServerKeyExchange(global::System.IO.Stream input)
		{
			global::Org.BouncyCastle.Tls.DigestInputBuffer digestBuffer = new global::Org.BouncyCastle.Tls.DigestInputBuffer();
			global::System.IO.Stream teeIn = new global::Org.BouncyCastle.Utilities.IO.TeeInputStream(input, digestBuffer);
			this.m_dhConfig = global::Org.BouncyCastle.Tls.TlsDHUtilities.ReceiveDHConfig(this.m_context, this.m_dhGroupVerifier, teeIn);
			byte[] y = global::Org.BouncyCastle.Tls.TlsUtilities.ReadOpaque16(teeIn, 1);
			global::Org.BouncyCastle.Tls.TlsUtilities.VerifyServerKeyExchangeSignature(this.m_context, input, this.m_serverCertificate, null, digestBuffer);
			this.m_agreement = this.m_context.Crypto.CreateDHDomain(this.m_dhConfig).CreateDH();
			this.m_agreement.ReceivePeerValue(y);
		}

		// Token: 0x06000954 RID: 2388 RVA: 0x00025A60 File Offset: 0x00023C60
		public override short[] GetClientCertificateTypes()
		{
			return new short[]
			{
				2,
				64,
				1
			};
		}

		// Token: 0x06000955 RID: 2389 RVA: 0x00025A73 File Offset: 0x00023C73
		public override void ProcessClientCredentials(global::Org.BouncyCastle.Tls.TlsCredentials clientCredentials)
		{
			global::Org.BouncyCastle.Tls.TlsUtilities.RequireSignerCredentials(clientCredentials);
		}

		// Token: 0x06000956 RID: 2390 RVA: 0x00025A7C File Offset: 0x00023C7C
		public override void GenerateClientKeyExchange(global::System.IO.Stream output)
		{
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteOpaque16(this.m_agreement.GenerateEphemeral(), output);
		}

		// Token: 0x06000957 RID: 2391 RVA: 0x00025A8F File Offset: 0x00023C8F
		public override void ProcessClientKeyExchange(global::System.IO.Stream input)
		{
			this.m_agreement.ReceivePeerValue(global::Org.BouncyCastle.Tls.TlsUtilities.ReadOpaque16(input, 1));
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x00025AA3 File Offset: 0x00023CA3
		public override global::Org.BouncyCastle.Tls.Crypto.TlsSecret GeneratePreMasterSecret()
		{
			return this.m_agreement.CalculateSecret();
		}

		// Token: 0x040006E4 RID: 1764
		protected global::Org.BouncyCastle.Tls.TlsDHGroupVerifier m_dhGroupVerifier;

		// Token: 0x040006E5 RID: 1765
		protected global::Org.BouncyCastle.Tls.Crypto.TlsDHConfig m_dhConfig;

		// Token: 0x040006E6 RID: 1766
		protected global::Org.BouncyCastle.Tls.TlsCredentialedSigner m_serverCredentials;

		// Token: 0x040006E7 RID: 1767
		protected global::Org.BouncyCastle.Tls.Crypto.TlsCertificate m_serverCertificate;

		// Token: 0x040006E8 RID: 1768
		protected global::Org.BouncyCastle.Tls.Crypto.TlsAgreement m_agreement;
	}
}
