using System;
using Microsoft.IdentityModel.Logging;
using Newtonsoft.Json;

namespace Microsoft.IdentityModel.Tokens
{
	// Token: 0x02000033 RID: 51
	public abstract class SecurityKey
	{
		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000140 RID: 320
		public abstract int KeySize { get; }

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000141 RID: 321 RVA: 0x00006B42 File Offset: 0x00004D42
		// (set) Token: 0x06000142 RID: 322 RVA: 0x00006B4A File Offset: 0x00004D4A
		[global::Newtonsoft.Json.JsonIgnore]
		public virtual string KeyId { get; set; }

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000143 RID: 323 RVA: 0x00006B53 File Offset: 0x00004D53
		// (set) Token: 0x06000144 RID: 324 RVA: 0x00006B5B File Offset: 0x00004D5B
		[global::Newtonsoft.Json.JsonIgnore]
		public global::Microsoft.IdentityModel.Tokens.CryptoProviderFactory CryptoProviderFactory
		{
			get
			{
				return this._cryptoProviderFactory;
			}
			set
			{
				if (value == null)
				{
					throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("value");
				}
				this._cryptoProviderFactory = value;
			}
		}

		// Token: 0x0400014E RID: 334
		private global::Microsoft.IdentityModel.Tokens.CryptoProviderFactory _cryptoProviderFactory = new global::Microsoft.IdentityModel.Tokens.CryptoProviderFactory(global::Microsoft.IdentityModel.Tokens.CryptoProviderFactory.Default);
	}
}
