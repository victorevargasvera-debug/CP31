using System;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000339 RID: 825
	public abstract class MacAlgorithm
	{
		// Token: 0x04000D99 RID: 3481
		public const int cls_null = 0;

		// Token: 0x04000D9A RID: 3482
		public const int md5 = 1;

		// Token: 0x04000D9B RID: 3483
		public const int sha = 2;

		// Token: 0x04000D9C RID: 3484
		public const int hmac_md5 = 1;

		// Token: 0x04000D9D RID: 3485
		public const int hmac_sha1 = 2;

		// Token: 0x04000D9E RID: 3486
		public const int hmac_sha256 = 3;

		// Token: 0x04000D9F RID: 3487
		public const int hmac_sha384 = 4;

		// Token: 0x04000DA0 RID: 3488
		public const int hmac_sha512 = 5;
	}
}
