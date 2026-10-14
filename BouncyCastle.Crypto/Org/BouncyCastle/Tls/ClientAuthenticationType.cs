using System;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000A3 RID: 163
	public abstract class ClientAuthenticationType
	{
		// Token: 0x040004A2 RID: 1186
		public const short anonymous = 0;

		// Token: 0x040004A3 RID: 1187
		public const short certificate_based = 1;

		// Token: 0x040004A4 RID: 1188
		public const short psk = 2;
	}
}
