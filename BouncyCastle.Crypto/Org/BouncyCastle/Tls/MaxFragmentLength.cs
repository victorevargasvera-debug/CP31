using System;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000D5 RID: 213
	public abstract class MaxFragmentLength
	{
		// Token: 0x060007A9 RID: 1961 RVA: 0x000207F3 File Offset: 0x0001E9F3
		public static bool IsValid(short maxFragmentLength)
		{
			return maxFragmentLength >= 1 && maxFragmentLength <= 4;
		}

		// Token: 0x040005BC RID: 1468
		public const short pow2_9 = 1;

		// Token: 0x040005BD RID: 1469
		public const short pow2_10 = 2;

		// Token: 0x040005BE RID: 1470
		public const short pow2_11 = 3;

		// Token: 0x040005BF RID: 1471
		public const short pow2_12 = 4;
	}
}
