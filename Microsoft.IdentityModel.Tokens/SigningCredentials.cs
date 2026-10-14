using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.IdentityModel.Logging;

namespace Microsoft.IdentityModel.Tokens
{
	// Token: 0x02000039 RID: 57
	public class SigningCredentials
	{
		// Token: 0x0600017E RID: 382 RVA: 0x00006D40 File Offset: 0x00004F40
		protected SigningCredentials(global::System.Security.Cryptography.X509Certificates.X509Certificate2 certificate)
		{
			if (certificate == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("certificate");
			}
			this.Key = new global::Microsoft.IdentityModel.Tokens.X509SecurityKey(certificate);
			this.Algorithm = "RS256";
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00006D6D File Offset: 0x00004F6D
		protected SigningCredentials(global::System.Security.Cryptography.X509Certificates.X509Certificate2 certificate, string algorithm)
		{
			if (certificate == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("certificate");
			}
			this.Key = new global::Microsoft.IdentityModel.Tokens.X509SecurityKey(certificate);
			this.Algorithm = algorithm;
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00006D96 File Offset: 0x00004F96
		public SigningCredentials(global::Microsoft.IdentityModel.Tokens.SecurityKey key, string algorithm)
		{
			this.Key = key;
			this.Algorithm = algorithm;
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00006DAC File Offset: 0x00004FAC
		public SigningCredentials(global::Microsoft.IdentityModel.Tokens.SecurityKey key, string algorithm, string digest)
		{
			this.Key = key;
			this.Algorithm = algorithm;
			this.Digest = digest;
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000182 RID: 386 RVA: 0x00006DC9 File Offset: 0x00004FC9
		// (set) Token: 0x06000183 RID: 387 RVA: 0x00006DD1 File Offset: 0x00004FD1
		public string Algorithm
		{
			get
			{
				return this._algorithm;
			}
			private set
			{
				if (!string.IsNullOrEmpty(value))
				{
					this._algorithm = value;
					return;
				}
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("algorithm");
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000184 RID: 388 RVA: 0x00006DEF File Offset: 0x00004FEF
		// (set) Token: 0x06000185 RID: 389 RVA: 0x00006DF7 File Offset: 0x00004FF7
		public string Digest
		{
			get
			{
				return this._digest;
			}
			private set
			{
				if (!string.IsNullOrEmpty(value))
				{
					this._digest = value;
					return;
				}
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("digest");
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000186 RID: 390 RVA: 0x00006E15 File Offset: 0x00005015
		// (set) Token: 0x06000187 RID: 391 RVA: 0x00006E1D File Offset: 0x0000501D
		public global::Microsoft.IdentityModel.Tokens.CryptoProviderFactory CryptoProviderFactory { get; set; }

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000188 RID: 392 RVA: 0x00006E26 File Offset: 0x00005026
		// (set) Token: 0x06000189 RID: 393 RVA: 0x00006E2E File Offset: 0x0000502E
		public global::Microsoft.IdentityModel.Tokens.SecurityKey Key
		{
			get
			{
				return this._key;
			}
			private set
			{
				if (value == null)
				{
					throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("key");
				}
				this._key = value;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x0600018A RID: 394 RVA: 0x00006E46 File Offset: 0x00005046
		public string Kid
		{
			get
			{
				return this.Key.KeyId;
			}
		}

		// Token: 0x0400015E RID: 350
		private string _algorithm;

		// Token: 0x0400015F RID: 351
		private string _digest;

		// Token: 0x04000160 RID: 352
		private global::Microsoft.IdentityModel.Tokens.SecurityKey _key;
	}
}
