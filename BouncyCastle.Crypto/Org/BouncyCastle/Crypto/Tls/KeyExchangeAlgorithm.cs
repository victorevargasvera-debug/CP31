using System;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000338 RID: 824
	public abstract class KeyExchangeAlgorithm
	{
		// Token: 0x04000D80 RID: 3456
		public const int NULL = 0;

		// Token: 0x04000D81 RID: 3457
		public const int RSA = 1;

		// Token: 0x04000D82 RID: 3458
		public const int RSA_EXPORT = 2;

		// Token: 0x04000D83 RID: 3459
		public const int DHE_DSS = 3;

		// Token: 0x04000D84 RID: 3460
		public const int DHE_DSS_EXPORT = 4;

		// Token: 0x04000D85 RID: 3461
		public const int DHE_RSA = 5;

		// Token: 0x04000D86 RID: 3462
		public const int DHE_RSA_EXPORT = 6;

		// Token: 0x04000D87 RID: 3463
		public const int DH_DSS = 7;

		// Token: 0x04000D88 RID: 3464
		public const int DH_DSS_EXPORT = 8;

		// Token: 0x04000D89 RID: 3465
		public const int DH_RSA = 9;

		// Token: 0x04000D8A RID: 3466
		public const int DH_RSA_EXPORT = 10;

		// Token: 0x04000D8B RID: 3467
		public const int DH_anon = 11;

		// Token: 0x04000D8C RID: 3468
		public const int DH_anon_EXPORT = 12;

		// Token: 0x04000D8D RID: 3469
		public const int PSK = 13;

		// Token: 0x04000D8E RID: 3470
		public const int DHE_PSK = 14;

		// Token: 0x04000D8F RID: 3471
		public const int RSA_PSK = 15;

		// Token: 0x04000D90 RID: 3472
		public const int ECDH_ECDSA = 16;

		// Token: 0x04000D91 RID: 3473
		public const int ECDHE_ECDSA = 17;

		// Token: 0x04000D92 RID: 3474
		public const int ECDH_RSA = 18;

		// Token: 0x04000D93 RID: 3475
		public const int ECDHE_RSA = 19;

		// Token: 0x04000D94 RID: 3476
		public const int ECDH_anon = 20;

		// Token: 0x04000D95 RID: 3477
		public const int SRP = 21;

		// Token: 0x04000D96 RID: 3478
		public const int SRP_DSS = 22;

		// Token: 0x04000D97 RID: 3479
		public const int SRP_RSA = 23;

		// Token: 0x04000D98 RID: 3480
		public const int ECDHE_PSK = 24;
	}
}
