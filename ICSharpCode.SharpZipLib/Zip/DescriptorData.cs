using System;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x0200002B RID: 43
	public class DescriptorData
	{
		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060001A2 RID: 418 RVA: 0x0000828A File Offset: 0x0000648A
		// (set) Token: 0x060001A3 RID: 419 RVA: 0x00008292 File Offset: 0x00006492
		public long CompressedSize
		{
			get
			{
				return this.compressedSize;
			}
			set
			{
				this.compressedSize = value;
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060001A4 RID: 420 RVA: 0x0000829B File Offset: 0x0000649B
		// (set) Token: 0x060001A5 RID: 421 RVA: 0x000082A3 File Offset: 0x000064A3
		public long Size
		{
			get
			{
				return this.size;
			}
			set
			{
				this.size = value;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060001A6 RID: 422 RVA: 0x000082AC File Offset: 0x000064AC
		// (set) Token: 0x060001A7 RID: 423 RVA: 0x000082B4 File Offset: 0x000064B4
		public long Crc
		{
			get
			{
				return this.crc;
			}
			set
			{
				this.crc = (value & (long)((ulong)-1));
			}
		}

		// Token: 0x040000EA RID: 234
		private long size;

		// Token: 0x040000EB RID: 235
		private long compressedSize;

		// Token: 0x040000EC RID: 236
		private long crc;
	}
}
