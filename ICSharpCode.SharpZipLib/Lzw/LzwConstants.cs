using System;

namespace ICSharpCode.SharpZipLib.Lzw
{
	// Token: 0x0200004C RID: 76
	public sealed class LzwConstants
	{
		// Token: 0x060003CB RID: 971 RVA: 0x0001199A File Offset: 0x0000FB9A
		private LzwConstants()
		{
		}

		// Token: 0x0400023F RID: 575
		public const int MAGIC = 8093;

		// Token: 0x04000240 RID: 576
		public const int MAX_BITS = 16;

		// Token: 0x04000241 RID: 577
		public const int BIT_MASK = 31;

		// Token: 0x04000242 RID: 578
		public const int EXTENDED_MASK = 32;

		// Token: 0x04000243 RID: 579
		public const int RESERVED_MASK = 96;

		// Token: 0x04000244 RID: 580
		public const int BLOCK_MODE_MASK = 128;

		// Token: 0x04000245 RID: 581
		public const int HDR_SIZE = 3;

		// Token: 0x04000246 RID: 582
		public const int INIT_BITS = 9;
	}
}
