using System;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000A2 RID: 162
	public abstract class CipherType
	{
		// Token: 0x0400049F RID: 1183
		public const int stream = 0;

		// Token: 0x040004A0 RID: 1184
		public const int block = 1;

		// Token: 0x040004A1 RID: 1185
		public const int aead = 2;
	}
}
