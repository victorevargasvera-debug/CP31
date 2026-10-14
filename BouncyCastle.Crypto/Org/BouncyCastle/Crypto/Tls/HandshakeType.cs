using System;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000332 RID: 818
	public abstract class HandshakeType
	{
		// Token: 0x04000D62 RID: 3426
		public const byte hello_request = 0;

		// Token: 0x04000D63 RID: 3427
		public const byte client_hello = 1;

		// Token: 0x04000D64 RID: 3428
		public const byte server_hello = 2;

		// Token: 0x04000D65 RID: 3429
		public const byte certificate = 11;

		// Token: 0x04000D66 RID: 3430
		public const byte server_key_exchange = 12;

		// Token: 0x04000D67 RID: 3431
		public const byte certificate_request = 13;

		// Token: 0x04000D68 RID: 3432
		public const byte server_hello_done = 14;

		// Token: 0x04000D69 RID: 3433
		public const byte certificate_verify = 15;

		// Token: 0x04000D6A RID: 3434
		public const byte client_key_exchange = 16;

		// Token: 0x04000D6B RID: 3435
		public const byte finished = 20;

		// Token: 0x04000D6C RID: 3436
		public const byte certificate_url = 21;

		// Token: 0x04000D6D RID: 3437
		public const byte certificate_status = 22;

		// Token: 0x04000D6E RID: 3438
		public const byte hello_verify_request = 3;

		// Token: 0x04000D6F RID: 3439
		public const byte supplemental_data = 23;

		// Token: 0x04000D70 RID: 3440
		public const byte session_ticket = 4;
	}
}
