using System;

namespace ICSharpCode.SharpZipLib.Zip.Compression
{
	// Token: 0x02000034 RID: 52
	public static class DeflaterConstants
	{
		// Token: 0x04000123 RID: 291
		public const bool DEBUGGING = false;

		// Token: 0x04000124 RID: 292
		public const int STORED_BLOCK = 0;

		// Token: 0x04000125 RID: 293
		public const int STATIC_TREES = 1;

		// Token: 0x04000126 RID: 294
		public const int DYN_TREES = 2;

		// Token: 0x04000127 RID: 295
		public const int PRESET_DICT = 32;

		// Token: 0x04000128 RID: 296
		public const int DEFAULT_MEM_LEVEL = 8;

		// Token: 0x04000129 RID: 297
		public const int MAX_MATCH = 258;

		// Token: 0x0400012A RID: 298
		public const int MIN_MATCH = 3;

		// Token: 0x0400012B RID: 299
		public const int MAX_WBITS = 15;

		// Token: 0x0400012C RID: 300
		public const int WSIZE = 32768;

		// Token: 0x0400012D RID: 301
		public const int WMASK = 32767;

		// Token: 0x0400012E RID: 302
		public const int HASH_BITS = 15;

		// Token: 0x0400012F RID: 303
		public const int HASH_SIZE = 32768;

		// Token: 0x04000130 RID: 304
		public const int HASH_MASK = 32767;

		// Token: 0x04000131 RID: 305
		public const int HASH_SHIFT = 5;

		// Token: 0x04000132 RID: 306
		public const int MIN_LOOKAHEAD = 262;

		// Token: 0x04000133 RID: 307
		public const int MAX_DIST = 32506;

		// Token: 0x04000134 RID: 308
		public const int PENDING_BUF_SIZE = 65536;

		// Token: 0x04000135 RID: 309
		public static int MAX_BLOCK_SIZE = global::System.Math.Min(65535, 65531);

		// Token: 0x04000136 RID: 310
		public const int DEFLATE_STORED = 0;

		// Token: 0x04000137 RID: 311
		public const int DEFLATE_FAST = 1;

		// Token: 0x04000138 RID: 312
		public const int DEFLATE_SLOW = 2;

		// Token: 0x04000139 RID: 313
		public static int[] GOOD_LENGTH = new int[]
		{
			0,
			4,
			4,
			4,
			4,
			8,
			8,
			8,
			32,
			32
		};

		// Token: 0x0400013A RID: 314
		public static int[] MAX_LAZY = new int[]
		{
			0,
			4,
			5,
			6,
			4,
			16,
			16,
			32,
			128,
			258
		};

		// Token: 0x0400013B RID: 315
		public static int[] NICE_LENGTH = new int[]
		{
			0,
			8,
			16,
			32,
			16,
			32,
			128,
			128,
			258,
			258
		};

		// Token: 0x0400013C RID: 316
		public static int[] MAX_CHAIN = new int[]
		{
			0,
			4,
			8,
			32,
			16,
			32,
			128,
			256,
			1024,
			4096
		};

		// Token: 0x0400013D RID: 317
		public static int[] COMPR_FUNC = new int[]
		{
			0,
			1,
			1,
			1,
			1,
			2,
			2,
			2,
			2,
			2
		};
	}
}
