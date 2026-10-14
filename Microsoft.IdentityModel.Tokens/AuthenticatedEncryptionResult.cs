using System;

namespace Microsoft.IdentityModel.Tokens
{
	// Token: 0x0200000C RID: 12
	public class AuthenticatedEncryptionResult
	{
		// Token: 0x06000060 RID: 96 RVA: 0x00004368 File Offset: 0x00002568
		public AuthenticatedEncryptionResult(global::Microsoft.IdentityModel.Tokens.SecurityKey key, byte[] ciphertext, byte[] iv, byte[] authenticationTag)
		{
			this.Key = key;
			this.Ciphertext = ciphertext;
			this.IV = iv;
			this.AuthenticationTag = authenticationTag;
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000061 RID: 97 RVA: 0x0000438D File Offset: 0x0000258D
		// (set) Token: 0x06000062 RID: 98 RVA: 0x00004395 File Offset: 0x00002595
		public global::Microsoft.IdentityModel.Tokens.SecurityKey Key { get; private set; }

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000063 RID: 99 RVA: 0x0000439E File Offset: 0x0000259E
		// (set) Token: 0x06000064 RID: 100 RVA: 0x000043A6 File Offset: 0x000025A6
		public byte[] Ciphertext { get; private set; }

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000065 RID: 101 RVA: 0x000043AF File Offset: 0x000025AF
		// (set) Token: 0x06000066 RID: 102 RVA: 0x000043B7 File Offset: 0x000025B7
		public byte[] IV { get; private set; }

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000067 RID: 103 RVA: 0x000043C0 File Offset: 0x000025C0
		// (set) Token: 0x06000068 RID: 104 RVA: 0x000043C8 File Offset: 0x000025C8
		public byte[] AuthenticationTag { get; private set; }
	}
}
