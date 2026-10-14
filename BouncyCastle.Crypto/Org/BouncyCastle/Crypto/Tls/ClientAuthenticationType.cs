using System;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200030F RID: 783
	public abstract class ClientAuthenticationType
	{
		// Token: 0x04000CB2 RID: 3250
		public const byte anonymous = 0;

		// Token: 0x04000CB3 RID: 3251
		public const byte certificate_based = 1;

		// Token: 0x04000CB4 RID: 3252
		public const byte psk = 2;
	}
}
