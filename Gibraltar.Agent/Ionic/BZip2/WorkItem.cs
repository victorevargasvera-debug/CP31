using System;
using System.IO;

namespace Ionic.BZip2
{
	// Token: 0x02000446 RID: 1094
	internal class WorkItem
	{
		// Token: 0x17000DA9 RID: 3497
		// (get) Token: 0x06002F7F RID: 12159 RVA: 0x000A8FAC File Offset: 0x000A71AC
		// (set) Token: 0x06002F80 RID: 12160 RVA: 0x000A8FB4 File Offset: 0x000A71B4
		public global::Ionic.BZip2.BZip2Compressor Compressor { get; private set; }

		// Token: 0x06002F81 RID: 12161 RVA: 0x000A8FC0 File Offset: 0x000A71C0
		public WorkItem(int ix, int blockSize)
		{
			this.ms = new global::System.IO.MemoryStream();
			this.bw = new global::Ionic.BZip2.BitWriter(this.ms);
			this.Compressor = new global::Ionic.BZip2.BZip2Compressor(this.bw, blockSize);
			this.index = ix;
		}

		// Token: 0x04001131 RID: 4401
		public int index;

		// Token: 0x04001133 RID: 4403
		public global::System.IO.MemoryStream ms;

		// Token: 0x04001134 RID: 4404
		public int ordinal;

		// Token: 0x04001135 RID: 4405
		public global::Ionic.BZip2.BitWriter bw;
	}
}
