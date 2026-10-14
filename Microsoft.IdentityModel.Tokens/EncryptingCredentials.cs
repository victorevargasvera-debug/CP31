using System;
using Microsoft.IdentityModel.Logging;

namespace Microsoft.IdentityModel.Tokens
{
	// Token: 0x0200000A RID: 10
	public class EncryptingCredentials
	{
		// Token: 0x06000048 RID: 72 RVA: 0x00003B00 File Offset: 0x00001D00
		public EncryptingCredentials(global::Microsoft.IdentityModel.Tokens.SecurityKey key, string alg, string enc)
		{
			if (key == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("key");
			}
			if (string.IsNullOrWhiteSpace(alg))
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("alg");
			}
			if (string.IsNullOrWhiteSpace(enc))
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("enc");
			}
			this.Alg = alg;
			this.Enc = enc;
			this.Key = key;
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000049 RID: 73 RVA: 0x00003B5C File Offset: 0x00001D5C
		// (set) Token: 0x0600004A RID: 74 RVA: 0x00003B64 File Offset: 0x00001D64
		public string Alg { get; private set; }

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600004B RID: 75 RVA: 0x00003B6D File Offset: 0x00001D6D
		// (set) Token: 0x0600004C RID: 76 RVA: 0x00003B75 File Offset: 0x00001D75
		public string Enc { get; private set; }

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600004D RID: 77 RVA: 0x00003B7E File Offset: 0x00001D7E
		// (set) Token: 0x0600004E RID: 78 RVA: 0x00003B86 File Offset: 0x00001D86
		public global::Microsoft.IdentityModel.Tokens.CryptoProviderFactory CryptoProviderFactory { get; set; }

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600004F RID: 79 RVA: 0x00003B8F File Offset: 0x00001D8F
		// (set) Token: 0x06000050 RID: 80 RVA: 0x00003B97 File Offset: 0x00001D97
		public global::Microsoft.IdentityModel.Tokens.SecurityKey Key { get; private set; }
	}
}
