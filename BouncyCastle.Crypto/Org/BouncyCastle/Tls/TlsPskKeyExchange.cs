using System;
using System.IO;
using Org.BouncyCastle.Tls.Crypto;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x0200011C RID: 284
	public class TlsPskKeyExchange : global::Org.BouncyCastle.Tls.AbstractTlsKeyExchange
	{
		// Token: 0x06000AF8 RID: 2808 RVA: 0x00029568 File Offset: 0x00027768
		private static int CheckKeyExchange(int keyExchange)
		{
			if (keyExchange - 13 <= 2 || keyExchange == 24)
			{
				return keyExchange;
			}
			throw new global::System.ArgumentException("unsupported key exchange algorithm", "keyExchange");
		}

		// Token: 0x06000AF9 RID: 2809 RVA: 0x00029587 File Offset: 0x00027787
		public TlsPskKeyExchange(int keyExchange, global::Org.BouncyCastle.Tls.TlsPskIdentity pskIdentity, global::Org.BouncyCastle.Tls.TlsDHGroupVerifier dhGroupVerifier) : this(keyExchange, pskIdentity, null, dhGroupVerifier, null, null)
		{
		}

		// Token: 0x06000AFA RID: 2810 RVA: 0x00029595 File Offset: 0x00027795
		public TlsPskKeyExchange(int keyExchange, global::Org.BouncyCastle.Tls.TlsPskIdentityManager pskIdentityManager, global::Org.BouncyCastle.Tls.Crypto.TlsDHConfig dhConfig, global::Org.BouncyCastle.Tls.Crypto.TlsECConfig ecConfig) : this(keyExchange, null, pskIdentityManager, null, dhConfig, ecConfig)
		{
		}

		// Token: 0x06000AFB RID: 2811 RVA: 0x000295A4 File Offset: 0x000277A4
		private TlsPskKeyExchange(int keyExchange, global::Org.BouncyCastle.Tls.TlsPskIdentity pskIdentity, global::Org.BouncyCastle.Tls.TlsPskIdentityManager pskIdentityManager, global::Org.BouncyCastle.Tls.TlsDHGroupVerifier dhGroupVerifier, global::Org.BouncyCastle.Tls.Crypto.TlsDHConfig dhConfig, global::Org.BouncyCastle.Tls.Crypto.TlsECConfig ecConfig) : base(global::Org.BouncyCastle.Tls.TlsPskKeyExchange.CheckKeyExchange(keyExchange))
		{
			this.m_pskIdentity = pskIdentity;
			this.m_pskIdentityManager = pskIdentityManager;
			this.m_dhGroupVerifier = dhGroupVerifier;
			this.m_dhConfig = dhConfig;
			this.m_ecConfig = ecConfig;
		}

		// Token: 0x06000AFC RID: 2812 RVA: 0x000295D8 File Offset: 0x000277D8
		public override void SkipServerCredentials()
		{
			if (this.m_keyExchange == 15)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
		}

		// Token: 0x06000AFD RID: 2813 RVA: 0x000295EC File Offset: 0x000277EC
		public override void ProcessServerCredentials(global::Org.BouncyCastle.Tls.TlsCredentials serverCredentials)
		{
			if (this.m_keyExchange != 15)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			this.m_serverCredentials = global::Org.BouncyCastle.Tls.TlsUtilities.RequireDecryptorCredentials(serverCredentials);
		}

		// Token: 0x06000AFE RID: 2814 RVA: 0x0002960C File Offset: 0x0002780C
		public override void ProcessServerCertificate(global::Org.BouncyCastle.Tls.Certificate serverCertificate)
		{
			if (this.m_keyExchange != 15)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(10);
			}
			this.m_serverEncryptor = serverCertificate.GetCertificateAt(0).CreateEncryptor(3);
		}

		// Token: 0x06000AFF RID: 2815 RVA: 0x00029634 File Offset: 0x00027834
		public override byte[] GenerateServerKeyExchange()
		{
			this.m_psk_identity_hint = this.m_pskIdentityManager.GetHint();
			if (this.m_psk_identity_hint == null && !this.RequiresServerKeyExchange)
			{
				return null;
			}
			global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream();
			if (this.m_psk_identity_hint == null)
			{
				global::Org.BouncyCastle.Tls.TlsUtilities.WriteOpaque16(global::Org.BouncyCastle.Tls.TlsUtilities.EmptyBytes, buf);
			}
			else
			{
				global::Org.BouncyCastle.Tls.TlsUtilities.WriteOpaque16(this.m_psk_identity_hint, buf);
			}
			if (this.m_keyExchange == 14)
			{
				if (this.m_dhConfig == null)
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
				}
				global::Org.BouncyCastle.Tls.TlsDHUtilities.WriteDHConfig(this.m_dhConfig, buf);
				this.m_agreement = this.m_context.Crypto.CreateDHDomain(this.m_dhConfig).CreateDH();
				this.GenerateEphemeralDH(buf);
			}
			else if (this.m_keyExchange == 24)
			{
				if (this.m_ecConfig == null)
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
				}
				global::Org.BouncyCastle.Tls.TlsEccUtilities.WriteECConfig(this.m_ecConfig, buf);
				this.m_agreement = this.m_context.Crypto.CreateECDomain(this.m_ecConfig).CreateECDH();
				this.GenerateEphemeralECDH(buf);
			}
			return buf.ToArray();
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x06000B00 RID: 2816 RVA: 0x00029730 File Offset: 0x00027930
		public override bool RequiresServerKeyExchange
		{
			get
			{
				int keyExchange = this.m_keyExchange;
				return keyExchange == 14 || keyExchange == 24;
			}
		}

		// Token: 0x06000B01 RID: 2817 RVA: 0x00029754 File Offset: 0x00027954
		public override void ProcessServerKeyExchange(global::System.IO.Stream input)
		{
			this.m_psk_identity_hint = global::Org.BouncyCastle.Tls.TlsUtilities.ReadOpaque16(input);
			if (this.m_keyExchange == 14)
			{
				this.m_dhConfig = global::Org.BouncyCastle.Tls.TlsDHUtilities.ReceiveDHConfig(this.m_context, this.m_dhGroupVerifier, input);
				byte[] y = global::Org.BouncyCastle.Tls.TlsUtilities.ReadOpaque16(input, 1);
				this.m_agreement = this.m_context.Crypto.CreateDHDomain(this.m_dhConfig).CreateDH();
				this.ProcessEphemeralDH(y);
				return;
			}
			if (this.m_keyExchange == 24)
			{
				this.m_ecConfig = global::Org.BouncyCastle.Tls.TlsEccUtilities.ReceiveECDHConfig(this.m_context, input);
				byte[] point = global::Org.BouncyCastle.Tls.TlsUtilities.ReadOpaque8(input, 1);
				this.m_agreement = this.m_context.Crypto.CreateECDomain(this.m_ecConfig).CreateECDH();
				this.ProcessEphemeralECDH(point);
			}
		}

		// Token: 0x06000B02 RID: 2818 RVA: 0x0002980C File Offset: 0x00027A0C
		public override void ProcessClientCredentials(global::Org.BouncyCastle.Tls.TlsCredentials clientCredentials)
		{
			throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
		}

		// Token: 0x06000B03 RID: 2819 RVA: 0x00029818 File Offset: 0x00027A18
		public override void GenerateClientKeyExchange(global::System.IO.Stream output)
		{
			if (this.m_psk_identity_hint == null)
			{
				this.m_pskIdentity.SkipIdentityHint();
			}
			else
			{
				this.m_pskIdentity.NotifyIdentityHint(this.m_psk_identity_hint);
			}
			byte[] psk_identity = this.m_pskIdentity.GetPskIdentity();
			if (psk_identity == null)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			this.m_psk = this.m_pskIdentity.GetPsk();
			if (this.m_psk == null)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteOpaque16(psk_identity, output);
			this.m_context.SecurityParameters.m_pskIdentity = global::Org.BouncyCastle.Utilities.Arrays.Clone(psk_identity);
			if (this.m_keyExchange == 14)
			{
				this.GenerateEphemeralDH(output);
				return;
			}
			if (this.m_keyExchange == 24)
			{
				this.GenerateEphemeralECDH(output);
				return;
			}
			if (this.m_keyExchange == 15)
			{
				this.m_preMasterSecret = global::Org.BouncyCastle.Tls.TlsUtilities.GenerateEncryptedPreMasterSecret(this.m_context, this.m_serverEncryptor, output);
			}
		}

		// Token: 0x06000B04 RID: 2820 RVA: 0x000298E8 File Offset: 0x00027AE8
		public override void ProcessClientKeyExchange(global::System.IO.Stream input)
		{
			byte[] psk_identity = global::Org.BouncyCastle.Tls.TlsUtilities.ReadOpaque16(input);
			this.m_psk = this.m_pskIdentityManager.GetPsk(psk_identity);
			if (this.m_psk == null)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(115);
			}
			this.m_context.SecurityParameters.m_pskIdentity = psk_identity;
			if (this.m_keyExchange == 14)
			{
				byte[] y = global::Org.BouncyCastle.Tls.TlsUtilities.ReadOpaque16(input, 1);
				this.ProcessEphemeralDH(y);
				return;
			}
			if (this.m_keyExchange == 24)
			{
				byte[] point = global::Org.BouncyCastle.Tls.TlsUtilities.ReadOpaque8(input, 1);
				this.ProcessEphemeralECDH(point);
				return;
			}
			if (this.m_keyExchange == 15)
			{
				byte[] encryptedPreMasterSecret = global::Org.BouncyCastle.Tls.TlsUtilities.ReadEncryptedPms(this.m_context, input);
				this.m_preMasterSecret = this.m_serverCredentials.Decrypt(new global::Org.BouncyCastle.Tls.Crypto.TlsCryptoParameters(this.m_context), encryptedPreMasterSecret);
			}
		}

		// Token: 0x06000B05 RID: 2821 RVA: 0x00029998 File Offset: 0x00027B98
		public override global::Org.BouncyCastle.Tls.Crypto.TlsSecret GeneratePreMasterSecret()
		{
			byte[] other_secret = this.GenerateOtherSecret(this.m_psk.Length);
			global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream(4 + other_secret.Length + this.m_psk.Length);
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteOpaque16(other_secret, buf);
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteOpaque16(this.m_psk, buf);
			global::System.Array.Clear(this.m_psk, 0, this.m_psk.Length);
			this.m_psk = null;
			return this.m_context.Crypto.CreateSecret(buf.ToArray());
		}

		// Token: 0x06000B06 RID: 2822 RVA: 0x00029A0C File Offset: 0x00027C0C
		protected virtual void GenerateEphemeralDH(global::System.IO.Stream output)
		{
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteOpaque16(this.m_agreement.GenerateEphemeral(), output);
		}

		// Token: 0x06000B07 RID: 2823 RVA: 0x00029A1F File Offset: 0x00027C1F
		protected virtual void GenerateEphemeralECDH(global::System.IO.Stream output)
		{
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteOpaque8(this.m_agreement.GenerateEphemeral(), output);
		}

		// Token: 0x06000B08 RID: 2824 RVA: 0x00029A34 File Offset: 0x00027C34
		protected virtual byte[] GenerateOtherSecret(int pskLength)
		{
			if (this.m_keyExchange == 13)
			{
				return new byte[pskLength];
			}
			if ((this.m_keyExchange == 14 || this.m_keyExchange == 24) && this.m_agreement != null)
			{
				return this.m_agreement.CalculateSecret().Extract();
			}
			if (this.m_keyExchange == 15 && this.m_preMasterSecret != null)
			{
				return this.m_preMasterSecret.Extract();
			}
			throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
		}

		// Token: 0x06000B09 RID: 2825 RVA: 0x00029AA4 File Offset: 0x00027CA4
		protected virtual void ProcessEphemeralDH(byte[] y)
		{
			this.m_agreement.ReceivePeerValue(y);
		}

		// Token: 0x06000B0A RID: 2826 RVA: 0x00029AB2 File Offset: 0x00027CB2
		protected virtual void ProcessEphemeralECDH(byte[] point)
		{
			global::Org.BouncyCastle.Tls.TlsEccUtilities.CheckPointEncoding(this.m_ecConfig.NamedGroup, point);
			this.m_agreement.ReceivePeerValue(point);
		}

		// Token: 0x0400072E RID: 1838
		protected global::Org.BouncyCastle.Tls.TlsPskIdentity m_pskIdentity;

		// Token: 0x0400072F RID: 1839
		protected global::Org.BouncyCastle.Tls.TlsPskIdentityManager m_pskIdentityManager;

		// Token: 0x04000730 RID: 1840
		protected global::Org.BouncyCastle.Tls.TlsDHGroupVerifier m_dhGroupVerifier;

		// Token: 0x04000731 RID: 1841
		protected byte[] m_psk_identity_hint;

		// Token: 0x04000732 RID: 1842
		protected byte[] m_psk;

		// Token: 0x04000733 RID: 1843
		protected global::Org.BouncyCastle.Tls.Crypto.TlsDHConfig m_dhConfig;

		// Token: 0x04000734 RID: 1844
		protected global::Org.BouncyCastle.Tls.Crypto.TlsECConfig m_ecConfig;

		// Token: 0x04000735 RID: 1845
		protected global::Org.BouncyCastle.Tls.Crypto.TlsAgreement m_agreement;

		// Token: 0x04000736 RID: 1846
		protected global::Org.BouncyCastle.Tls.TlsCredentialedDecryptor m_serverCredentials;

		// Token: 0x04000737 RID: 1847
		protected global::Org.BouncyCastle.Tls.Crypto.TlsEncryptor m_serverEncryptor;

		// Token: 0x04000738 RID: 1848
		protected global::Org.BouncyCastle.Tls.Crypto.TlsSecret m_preMasterSecret;
	}
}
