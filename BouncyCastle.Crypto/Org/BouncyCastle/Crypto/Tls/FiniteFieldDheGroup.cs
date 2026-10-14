using System;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000331 RID: 817
	public abstract class FiniteFieldDheGroup
	{
		// Token: 0x06002222 RID: 8738 RVA: 0x00097540 File Offset: 0x00095740
		public static bool IsValid(byte group)
		{
			return group >= 0 && group <= 4;
		}

		// Token: 0x04000D5D RID: 3421
		public const byte ffdhe2432 = 0;

		// Token: 0x04000D5E RID: 3422
		public const byte ffdhe3072 = 1;

		// Token: 0x04000D5F RID: 3423
		public const byte ffdhe4096 = 2;

		// Token: 0x04000D60 RID: 3424
		public const byte ffdhe6144 = 3;

		// Token: 0x04000D61 RID: 3425
		public const byte ffdhe8192 = 4;
	}
}
