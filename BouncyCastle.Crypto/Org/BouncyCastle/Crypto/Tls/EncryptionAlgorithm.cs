using System;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200032E RID: 814
	public abstract class EncryptionAlgorithm
	{
		// Token: 0x04000D1E RID: 3358
		public const int NULL = 0;

		// Token: 0x04000D1F RID: 3359
		public const int RC4_40 = 1;

		// Token: 0x04000D20 RID: 3360
		public const int RC4_128 = 2;

		// Token: 0x04000D21 RID: 3361
		public const int RC2_CBC_40 = 3;

		// Token: 0x04000D22 RID: 3362
		public const int IDEA_CBC = 4;

		// Token: 0x04000D23 RID: 3363
		public const int DES40_CBC = 5;

		// Token: 0x04000D24 RID: 3364
		public const int DES_CBC = 6;

		// Token: 0x04000D25 RID: 3365
		public const int cls_3DES_EDE_CBC = 7;

		// Token: 0x04000D26 RID: 3366
		public const int AES_128_CBC = 8;

		// Token: 0x04000D27 RID: 3367
		public const int AES_256_CBC = 9;

		// Token: 0x04000D28 RID: 3368
		public const int AES_128_GCM = 10;

		// Token: 0x04000D29 RID: 3369
		public const int AES_256_GCM = 11;

		// Token: 0x04000D2A RID: 3370
		public const int CAMELLIA_128_CBC = 12;

		// Token: 0x04000D2B RID: 3371
		public const int CAMELLIA_256_CBC = 13;

		// Token: 0x04000D2C RID: 3372
		public const int SEED_CBC = 14;

		// Token: 0x04000D2D RID: 3373
		public const int AES_128_CCM = 15;

		// Token: 0x04000D2E RID: 3374
		public const int AES_128_CCM_8 = 16;

		// Token: 0x04000D2F RID: 3375
		public const int AES_256_CCM = 17;

		// Token: 0x04000D30 RID: 3376
		public const int AES_256_CCM_8 = 18;

		// Token: 0x04000D31 RID: 3377
		public const int CAMELLIA_128_GCM = 19;

		// Token: 0x04000D32 RID: 3378
		public const int CAMELLIA_256_GCM = 20;

		// Token: 0x04000D33 RID: 3379
		public const int CHACHA20_POLY1305 = 21;

		// Token: 0x04000D34 RID: 3380
		public const int AES_128_OCB_TAGLEN96 = 103;

		// Token: 0x04000D35 RID: 3381
		public const int AES_256_OCB_TAGLEN96 = 104;
	}
}
