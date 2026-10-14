using System;

namespace Ionic.Zlib
{
	// Token: 0x02000430 RID: 1072
	internal class WorkItem
	{
		// Token: 0x06002E93 RID: 11923 RVA: 0x000A237C File Offset: 0x000A057C
		public WorkItem(int size, global::Ionic.Zlib.CompressionLevel compressLevel, global::Ionic.Zlib.CompressionStrategy strategy, int ix)
		{
			this.buffer = new byte[size];
			int num = size + (size / 32768 + 1) * 5 * 2;
			this.compressed = new byte[num];
			this.compressor = new global::Ionic.Zlib.ZlibCodec();
			this.compressor.InitializeDeflate(compressLevel, false);
			this.compressor.OutputBuffer = this.compressed;
			this.compressor.InputBuffer = this.buffer;
			this.index = ix;
		}

		// Token: 0x0400104E RID: 4174
		public byte[] buffer;

		// Token: 0x0400104F RID: 4175
		public byte[] compressed;

		// Token: 0x04001050 RID: 4176
		public int crc;

		// Token: 0x04001051 RID: 4177
		public int index;

		// Token: 0x04001052 RID: 4178
		public int ordinal;

		// Token: 0x04001053 RID: 4179
		public int inputBytesAvailable;

		// Token: 0x04001054 RID: 4180
		public int compressedBytesAvailable;

		// Token: 0x04001055 RID: 4181
		public global::Ionic.Zlib.ZlibCodec compressor;
	}
}
