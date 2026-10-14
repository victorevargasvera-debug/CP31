using System;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000314 RID: 788
	public abstract class ContentType
	{
		// Token: 0x04000CC6 RID: 3270
		public const byte change_cipher_spec = 20;

		// Token: 0x04000CC7 RID: 3271
		public const byte alert = 21;

		// Token: 0x04000CC8 RID: 3272
		public const byte handshake = 22;

		// Token: 0x04000CC9 RID: 3273
		public const byte application_data = 23;

		// Token: 0x04000CCA RID: 3274
		public const byte heartbeat = 24;
	}
}
