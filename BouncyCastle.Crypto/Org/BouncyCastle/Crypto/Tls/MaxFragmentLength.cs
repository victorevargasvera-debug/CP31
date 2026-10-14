using System;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200033A RID: 826
	public abstract class MaxFragmentLength
	{
		// Token: 0x06002237 RID: 8759 RVA: 0x000977E8 File Offset: 0x000959E8
		public static bool IsValid(byte maxFragmentLength)
		{
			return maxFragmentLength >= 1 && maxFragmentLength <= 4;
		}

		// Token: 0x04000DA1 RID: 3489
		public const byte pow2_9 = 1;

		// Token: 0x04000DA2 RID: 3490
		public const byte pow2_10 = 2;

		// Token: 0x04000DA3 RID: 3491
		public const byte pow2_11 = 3;

		// Token: 0x04000DA4 RID: 3492
		public const byte pow2_12 = 4;
	}
}
