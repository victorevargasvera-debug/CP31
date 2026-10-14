using System;

namespace Ionic.BZip2
{
	// Token: 0x02000444 RID: 1092
	internal static class BZip2
	{
		// Token: 0x06002F68 RID: 12136 RVA: 0x000A8A8C File Offset: 0x000A6C8C
		internal static T[][] InitRectangularArray<T>(int d1, int d2)
		{
			T[][] array = new T[d1][];
			for (int i = 0; i < d1; i++)
			{
				array[i] = new T[d2];
			}
			return array;
		}

		// Token: 0x0400111C RID: 4380
		public static readonly int BlockSizeMultiple = 100000;

		// Token: 0x0400111D RID: 4381
		public static readonly int MinBlockSize = 1;

		// Token: 0x0400111E RID: 4382
		public static readonly int MaxBlockSize = 9;

		// Token: 0x0400111F RID: 4383
		public static readonly int MaxAlphaSize = 258;

		// Token: 0x04001120 RID: 4384
		public static readonly int MaxCodeLength = 23;

		// Token: 0x04001121 RID: 4385
		public static readonly char RUNA = '\0';

		// Token: 0x04001122 RID: 4386
		public static readonly char RUNB = '\u0001';

		// Token: 0x04001123 RID: 4387
		public static readonly int NGroups = 6;

		// Token: 0x04001124 RID: 4388
		public static readonly int G_SIZE = 50;

		// Token: 0x04001125 RID: 4389
		public static readonly int N_ITERS = 4;

		// Token: 0x04001126 RID: 4390
		public static readonly int MaxSelectors = 2 + 900000 / global::Ionic.BZip2.BZip2.G_SIZE;

		// Token: 0x04001127 RID: 4391
		public static readonly int NUM_OVERSHOOT_BYTES = 20;

		// Token: 0x04001128 RID: 4392
		internal static readonly int QSORT_STACK_SIZE = 1000;
	}
}
