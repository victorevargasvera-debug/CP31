using System;

namespace Org.BouncyCastle.Utilities.Zlib
{
	// Token: 0x02000043 RID: 67
	public sealed class JZlib
	{
		// Token: 0x06000308 RID: 776 RVA: 0x00012256 File Offset: 0x00010456
		public static string version()
		{
			return "1.0.7";
		}

		// Token: 0x040001F9 RID: 505
		private const string _version = "1.0.7";

		// Token: 0x040001FA RID: 506
		public const int Z_NO_COMPRESSION = 0;

		// Token: 0x040001FB RID: 507
		public const int Z_BEST_SPEED = 1;

		// Token: 0x040001FC RID: 508
		public const int Z_BEST_COMPRESSION = 9;

		// Token: 0x040001FD RID: 509
		public const int Z_DEFAULT_COMPRESSION = -1;

		// Token: 0x040001FE RID: 510
		public const int Z_FILTERED = 1;

		// Token: 0x040001FF RID: 511
		public const int Z_HUFFMAN_ONLY = 2;

		// Token: 0x04000200 RID: 512
		public const int Z_DEFAULT_STRATEGY = 0;

		// Token: 0x04000201 RID: 513
		public const int Z_NO_FLUSH = 0;

		// Token: 0x04000202 RID: 514
		public const int Z_PARTIAL_FLUSH = 1;

		// Token: 0x04000203 RID: 515
		public const int Z_SYNC_FLUSH = 2;

		// Token: 0x04000204 RID: 516
		public const int Z_FULL_FLUSH = 3;

		// Token: 0x04000205 RID: 517
		public const int Z_FINISH = 4;

		// Token: 0x04000206 RID: 518
		public const int Z_OK = 0;

		// Token: 0x04000207 RID: 519
		public const int Z_STREAM_END = 1;

		// Token: 0x04000208 RID: 520
		public const int Z_NEED_DICT = 2;

		// Token: 0x04000209 RID: 521
		public const int Z_ERRNO = -1;

		// Token: 0x0400020A RID: 522
		public const int Z_STREAM_ERROR = -2;

		// Token: 0x0400020B RID: 523
		public const int Z_DATA_ERROR = -3;

		// Token: 0x0400020C RID: 524
		public const int Z_MEM_ERROR = -4;

		// Token: 0x0400020D RID: 525
		public const int Z_BUF_ERROR = -5;

		// Token: 0x0400020E RID: 526
		public const int Z_VERSION_ERROR = -6;
	}
}
