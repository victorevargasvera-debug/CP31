using System;

namespace NPOI.XSSF.Util
{
	// Token: 0x0200005A RID: 90
	public class NumericRanges
	{
		// Token: 0x0600040E RID: 1038 RVA: 0x00010510 File Offset: 0x0000E710
		public static long[] GetOverlappingRange(long[] range1, long[] range2)
		{
			int overlappingType = global::NPOI.XSSF.Util.NumericRanges.GetOverlappingType(range1, range2);
			if (overlappingType == 0)
			{
				return new long[]
				{
					range2[0],
					range1[1]
				};
			}
			if (overlappingType == 1)
			{
				return new long[]
				{
					range1[0],
					range2[1]
				};
			}
			if (overlappingType == 3)
			{
				return range1;
			}
			if (overlappingType == 2)
			{
				return range2;
			}
			return new long[]
			{
				-1L,
				-1L
			};
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x00010570 File Offset: 0x0000E770
		public static int GetOverlappingType(long[] range1, long[] range2)
		{
			long num = range1[0];
			long num2 = range1[1];
			long num3 = range2[0];
			long num4 = range2[1];
			if (num >= num3 && num2 <= num4)
			{
				return 3;
			}
			if (num3 >= num && num4 <= num2)
			{
				return 2;
			}
			if (num3 >= num && num3 <= num2 && num4 >= num2)
			{
				return 0;
			}
			if (num >= num3 && num <= num4 && num2 >= num4)
			{
				return 1;
			}
			return -1;
		}

		// Token: 0x04000251 RID: 593
		public const int NO_OVERLAPS = -1;

		// Token: 0x04000252 RID: 594
		public const int OVERLAPS_1_MINOR = 0;

		// Token: 0x04000253 RID: 595
		public const int OVERLAPS_2_MINOR = 1;

		// Token: 0x04000254 RID: 596
		public const int OVERLAPS_1_WRAPS = 2;

		// Token: 0x04000255 RID: 597
		public const int OVERLAPS_2_WRAPS = 3;
	}
}
