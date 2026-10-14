using System;

namespace NPOI.SS.Util
{
	// Token: 0x02000024 RID: 36
	public class IEEEDouble
	{
		// Token: 0x06000180 RID: 384 RVA: 0x0000715F File Offset: 0x0000535F
		public static int GetBiasedExponent(long rawBits)
		{
			return (int)((rawBits & 9218868437227405312L) >> 52);
		}

		// Token: 0x0400007F RID: 127
		private const long EXPONENT_MASK = 9218868437227405312L;

		// Token: 0x04000080 RID: 128
		private const int EXPONENT_SHIFT = 52;

		// Token: 0x04000081 RID: 129
		public const long FRAC_MASK = 4503599627370495L;

		// Token: 0x04000082 RID: 130
		public const int EXPONENT_BIAS = 1023;

		// Token: 0x04000083 RID: 131
		public const long FRAC_ASSUMED_HIGH_BIT = 4503599627370496L;

		// Token: 0x04000084 RID: 132
		public const int BIASED_EXPONENT_SPECIAL_VALUE = 2047;
	}
}
