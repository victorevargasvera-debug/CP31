using System;

namespace Ionic.Zlib
{
	// Token: 0x0200043F RID: 1087
	internal static class ZlibConstants
	{
		// Token: 0x040010D6 RID: 4310
		public const int WindowBitsMax = 15;

		// Token: 0x040010D7 RID: 4311
		public const int WindowBitsDefault = 15;

		// Token: 0x040010D8 RID: 4312
		public const int Z_OK = 0;

		// Token: 0x040010D9 RID: 4313
		public const int Z_STREAM_END = 1;

		// Token: 0x040010DA RID: 4314
		public const int Z_NEED_DICT = 2;

		// Token: 0x040010DB RID: 4315
		public const int Z_STREAM_ERROR = -2;

		// Token: 0x040010DC RID: 4316
		public const int Z_DATA_ERROR = -3;

		// Token: 0x040010DD RID: 4317
		public const int Z_BUF_ERROR = -5;

		// Token: 0x040010DE RID: 4318
		public const int WorkingBufferSizeDefault = 16384;

		// Token: 0x040010DF RID: 4319
		public const int WorkingBufferSizeMin = 1024;
	}
}
