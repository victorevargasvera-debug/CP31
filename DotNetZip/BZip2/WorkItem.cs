using System;
using System.IO;

namespace Ionic.BZip2
{
	// Token: 0x02000067 RID: 103
	internal class WorkItem
	{
		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06000523 RID: 1315 RVA: 0x0001FE31 File Offset: 0x0001E031
		// (set) Token: 0x06000524 RID: 1316 RVA: 0x0001FE39 File Offset: 0x0001E039
		public global::Ionic.BZip2.BZip2Compressor Compressor { get; private set; }

		// Token: 0x06000525 RID: 1317 RVA: 0x0001FE42 File Offset: 0x0001E042
		public WorkItem(int ix, int blockSize)
		{
			this.ms = new global::System.IO.MemoryStream();
			this.bw = new global::Ionic.BZip2.BitWriter(this.ms);
			this.Compressor = new global::Ionic.BZip2.BZip2Compressor(this.bw, blockSize);
			this.index = ix;
		}

		// Token: 0x04000395 RID: 917
		public int index;

		// Token: 0x04000397 RID: 919
		public global::System.IO.MemoryStream ms;

		// Token: 0x04000398 RID: 920
		public int ordinal;

		// Token: 0x04000399 RID: 921
		public global::Ionic.BZip2.BitWriter bw;
	}
}
