using System;

namespace NLog.Internal
{
	// Token: 0x02000101 RID: 257
	internal class FileCharacteristics
	{
		// Token: 0x06000CCB RID: 3275 RVA: 0x0001F5DC File Offset: 0x0001D7DC
		public FileCharacteristics(global::System.DateTime creationTimeUtc, global::System.DateTime lastWriteTimeUtc, long fileLength)
		{
			this.CreationTimeUtc = creationTimeUtc;
			this.LastWriteTimeUtc = lastWriteTimeUtc;
			this.FileLength = fileLength;
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x06000CCC RID: 3276 RVA: 0x0001F5F9 File Offset: 0x0001D7F9
		// (set) Token: 0x06000CCD RID: 3277 RVA: 0x0001F601 File Offset: 0x0001D801
		public global::System.DateTime CreationTimeUtc { get; private set; }

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06000CCE RID: 3278 RVA: 0x0001F60A File Offset: 0x0001D80A
		// (set) Token: 0x06000CCF RID: 3279 RVA: 0x0001F612 File Offset: 0x0001D812
		public global::System.DateTime LastWriteTimeUtc { get; private set; }

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06000CD0 RID: 3280 RVA: 0x0001F61B File Offset: 0x0001D81B
		// (set) Token: 0x06000CD1 RID: 3281 RVA: 0x0001F623 File Offset: 0x0001D823
		public long FileLength { get; private set; }
	}
}
