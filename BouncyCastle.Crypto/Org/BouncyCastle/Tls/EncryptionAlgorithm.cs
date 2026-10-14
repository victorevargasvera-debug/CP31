using System;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000C5 RID: 197
	public abstract class EncryptionAlgorithm
	{
		// Token: 0x0400051F RID: 1311
		public const int NULL = 0;

		// Token: 0x04000520 RID: 1312
		public const int RC4_40 = 1;

		// Token: 0x04000521 RID: 1313
		public const int RC4_128 = 2;

		// Token: 0x04000522 RID: 1314
		public const int RC2_CBC_40 = 3;

		// Token: 0x04000523 RID: 1315
		public const int IDEA_CBC = 4;

		// Token: 0x04000524 RID: 1316
		public const int DES40_CBC = 5;

		// Token: 0x04000525 RID: 1317
		public const int DES_CBC = 6;

		// Token: 0x04000526 RID: 1318
		public const int cls_3DES_EDE_CBC = 7;

		// Token: 0x04000527 RID: 1319
		public const int AES_128_CBC = 8;

		// Token: 0x04000528 RID: 1320
		public const int AES_256_CBC = 9;

		// Token: 0x04000529 RID: 1321
		public const int AES_128_GCM = 10;

		// Token: 0x0400052A RID: 1322
		public const int AES_256_GCM = 11;

		// Token: 0x0400052B RID: 1323
		public const int CAMELLIA_128_CBC = 12;

		// Token: 0x0400052C RID: 1324
		public const int CAMELLIA_256_CBC = 13;

		// Token: 0x0400052D RID: 1325
		public const int SEED_CBC = 14;

		// Token: 0x0400052E RID: 1326
		public const int AES_128_CCM = 15;

		// Token: 0x0400052F RID: 1327
		public const int AES_128_CCM_8 = 16;

		// Token: 0x04000530 RID: 1328
		public const int AES_256_CCM = 17;

		// Token: 0x04000531 RID: 1329
		public const int AES_256_CCM_8 = 18;

		// Token: 0x04000532 RID: 1330
		public const int CAMELLIA_128_GCM = 19;

		// Token: 0x04000533 RID: 1331
		public const int CAMELLIA_256_GCM = 20;

		// Token: 0x04000534 RID: 1332
		public const int CHACHA20_POLY1305 = 21;

		// Token: 0x04000535 RID: 1333
		public const int ARIA_128_CBC = 22;

		// Token: 0x04000536 RID: 1334
		public const int ARIA_256_CBC = 23;

		// Token: 0x04000537 RID: 1335
		public const int ARIA_128_GCM = 24;

		// Token: 0x04000538 RID: 1336
		public const int ARIA_256_GCM = 25;

		// Token: 0x04000539 RID: 1337
		public const int SM4_CCM = 26;

		// Token: 0x0400053A RID: 1338
		public const int SM4_GCM = 27;

		// Token: 0x0400053B RID: 1339
		public const int SM4_CBC = 28;
	}
}
