using System;

namespace Ionic.BZip2
{
	// Token: 0x02000065 RID: 101
	internal static class BZip2
	{
		// Token: 0x0600050C RID: 1292 RVA: 0x0001F9A0 File Offset: 0x0001DBA0
		internal static T[][] InitRectangularArray<T>(int d1, int d2)
		{
			T[][] array = new T[d1][];
			for (int i = 0; i < d1; i++)
			{
				array[i] = new T[d2];
			}
			return array;
		}

		// Token: 0x04000380 RID: 896
		public static readonly int BlockSizeMultiple = 100000;

		// Token: 0x04000381 RID: 897
		public static readonly int MinBlockSize = 1;

		// Token: 0x04000382 RID: 898
		public static readonly int MaxBlockSize = 9;

		// Token: 0x04000383 RID: 899
		public static readonly int MaxAlphaSize = 258;

		// Token: 0x04000384 RID: 900
		public static readonly int MaxCodeLength = 23;

		// Token: 0x04000385 RID: 901
		public static readonly char RUNA = '\0';

		// Token: 0x04000386 RID: 902
		public static readonly char RUNB = '\u0001';

		// Token: 0x04000387 RID: 903
		public static readonly int NGroups = 6;

		// Token: 0x04000388 RID: 904
		public static readonly int G_SIZE = 50;

		// Token: 0x04000389 RID: 905
		public static readonly int N_ITERS = 4;

		// Token: 0x0400038A RID: 906
		public static readonly int MaxSelectors = 2 + 900000 / global::Ionic.BZip2.BZip2.G_SIZE;

		// Token: 0x0400038B RID: 907
		public static readonly int NUM_OVERSHOOT_BYTES = 20;

		// Token: 0x0400038C RID: 908
		internal static readonly int QSORT_STACK_SIZE = 1000;
	}
}
