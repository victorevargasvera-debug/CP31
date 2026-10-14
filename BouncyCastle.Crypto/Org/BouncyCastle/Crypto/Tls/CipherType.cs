using System;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200030E RID: 782
	public abstract class CipherType
	{
		// Token: 0x04000CAF RID: 3247
		public const int stream = 0;

		// Token: 0x04000CB0 RID: 3248
		public const int block = 1;

		// Token: 0x04000CB1 RID: 3249
		public const int aead = 2;
	}
}
