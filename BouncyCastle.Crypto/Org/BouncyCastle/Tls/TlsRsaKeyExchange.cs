using System;
using System.IO;
using Org.BouncyCastle.Tls.Crypto;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x0200011D RID: 285
	public class TlsRsaKeyExchange : global::Org.BouncyCastle.Tls.AbstractTlsKeyExchange
	{
		// Token: 0x06000B0B RID: 2827 RVA: 0x00029AD1 File Offset: 0x00027CD1
		private static int CheckKeyExchange(int keyExchange)
		{
			if (keyExchange == 1)
			{
				return keyExchange;
			}
			throw new global::System.ArgumentException("unsupported key exchange algorithm", "keyExchange");
		}

		// Token: 0x06000B0C RID: 2828 RVA: 0x00029AE8 File Offset: 0x00027CE8
		public TlsRsaKeyExchange(int keyExchange) : base(global::Org.BouncyCastle.Tls.TlsRsaKeyExchange.CheckKeyExchange(keyExchange))
		{
		}

		// Token: 0x06000B0D RID: 2829 RVA: 0x00029AF6 File Offset: 0x00027CF6
		public override void SkipServerCredentials()
		{
			throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
		}

		// Token: 0x06000B0E RID: 2830 RVA: 0x00029AFF File Offset: 0x00027CFF
		public override void ProcessServerCredentials(global::Org.BouncyCastle.Tls.TlsCredentials serverCredentials)
		{
			this.m_serverCredentials = global::Org.BouncyCastle.Tls.TlsUtilities.RequireDecryptorCredentials(serverCredentials);
		}

		// Token: 0x06000B0F RID: 2831 RVA: 0x00029B0D File Offset: 0x00027D0D
		public override void ProcessServerCertificate(global::Org.BouncyCastle.Tls.Certificate serverCertificate)
		{
			this.m_serverEncryptor = serverCertificate.GetCertificateAt(0).CreateEncryptor(3);
		}

		// Token: 0x06000B10 RID: 2832 RVA: 0x00029B22 File Offset: 0x00027D22
		public override short[] GetClientCertificateTypes()
		{
			return new short[]
			{
				1,
				2,
				64
			};
		}

		// Token: 0x06000B11 RID: 2833 RVA: 0x00029B35 File Offset: 0x00027D35
		public override void ProcessClientCredentials(global::Org.BouncyCastle.Tls.TlsCredentials clientCredentials)
		{
			global::Org.BouncyCastle.Tls.TlsUtilities.RequireSignerCredentials(clientCredentials);
		}

		// Token: 0x06000B12 RID: 2834 RVA: 0x00029B3E File Offset: 0x00027D3E
		public override void GenerateClientKeyExchange(global::System.IO.Stream output)
		{
			this.m_preMasterSecret = global::Org.BouncyCastle.Tls.TlsUtilities.GenerateEncryptedPreMasterSecret(this.m_context, this.m_serverEncryptor, output);
		}

		// Token: 0x06000B13 RID: 2835 RVA: 0x00029B58 File Offset: 0x00027D58
		public override void ProcessClientKeyExchange(global::System.IO.Stream input)
		{
			byte[] encryptedPreMasterSecret = global::Org.BouncyCastle.Tls.TlsUtilities.ReadEncryptedPms(this.m_context, input);
			this.m_preMasterSecret = this.m_serverCredentials.Decrypt(new global::Org.BouncyCastle.Tls.Crypto.TlsCryptoParameters(this.m_context), encryptedPreMasterSecret);
		}

		// Token: 0x06000B14 RID: 2836 RVA: 0x00029B8F File Offset: 0x00027D8F
		public override global::Org.BouncyCastle.Tls.Crypto.TlsSecret GeneratePreMasterSecret()
		{
			global::Org.BouncyCastle.Tls.Crypto.TlsSecret preMasterSecret = this.m_preMasterSecret;
			this.m_preMasterSecret = null;
			return preMasterSecret;
		}

		// Token: 0x04000739 RID: 1849
		protected global::Org.BouncyCastle.Tls.TlsCredentialedDecryptor m_serverCredentials;

		// Token: 0x0400073A RID: 1850
		protected global::Org.BouncyCastle.Tls.Crypto.TlsEncryptor m_serverEncryptor;

		// Token: 0x0400073B RID: 1851
		protected global::Org.BouncyCastle.Tls.Crypto.TlsSecret m_preMasterSecret;
	}
}
