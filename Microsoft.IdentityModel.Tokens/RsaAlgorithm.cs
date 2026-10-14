using System;
using System.Security.Cryptography;

namespace Microsoft.IdentityModel.Tokens
{
	// Token: 0x02000048 RID: 72
	internal class RsaAlgorithm
	{
		// Token: 0x06000213 RID: 531 RVA: 0x00007B5F File Offset: 0x00005D5F
		public RsaAlgorithm(global::System.Security.Cryptography.RSACryptoServiceProvider rsaCryptoServiceProvider)
		{
			this.RsaCryptoServiceProvider = rsaCryptoServiceProvider;
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00007B6E File Offset: 0x00005D6E
		public RsaAlgorithm(global::Microsoft.IdentityModel.Tokens.RSACryptoServiceProviderProxy rsaCryptoServiceProviderProxy)
		{
			this.RsaCryptoServiceProviderProxy = rsaCryptoServiceProviderProxy;
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00007B7D File Offset: 0x00005D7D
		public RsaAlgorithm(global::Microsoft.IdentityModel.Tokens.RsaCngAdapter rsaCngAdapter)
		{
			this.RsaCngAdapter = rsaCngAdapter;
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000216 RID: 534 RVA: 0x00007B8C File Offset: 0x00005D8C
		// (set) Token: 0x06000217 RID: 535 RVA: 0x00007B94 File Offset: 0x00005D94
		public global::System.Security.Cryptography.RSACryptoServiceProvider RsaCryptoServiceProvider { get; private set; }

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000218 RID: 536 RVA: 0x00007B9D File Offset: 0x00005D9D
		// (set) Token: 0x06000219 RID: 537 RVA: 0x00007BA5 File Offset: 0x00005DA5
		public global::Microsoft.IdentityModel.Tokens.RSACryptoServiceProviderProxy RsaCryptoServiceProviderProxy { get; private set; }

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x0600021A RID: 538 RVA: 0x00007BAE File Offset: 0x00005DAE
		// (set) Token: 0x0600021B RID: 539 RVA: 0x00007BB6 File Offset: 0x00005DB6
		public global::Microsoft.IdentityModel.Tokens.RsaCngAdapter RsaCngAdapter { get; private set; }

		// Token: 0x04000196 RID: 406
		public bool ShouldDispose;
	}
}
