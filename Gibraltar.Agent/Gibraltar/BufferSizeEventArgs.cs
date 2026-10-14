using System;

namespace Gibraltar
{
	// Token: 0x020000A4 RID: 164
	internal class BufferSizeEventArgs : global::System.EventArgs
	{
		// Token: 0x060006E2 RID: 1762 RVA: 0x0000C2B0 File Offset: 0x0000A4B0
		public BufferSizeEventArgs(long totalBuffers, int bufferSize)
		{
			this.BufferCount = totalBuffers;
			this.BufferSize = bufferSize;
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x060006E3 RID: 1763 RVA: 0x0000C2C8 File Offset: 0x0000A4C8
		// (set) Token: 0x060006E4 RID: 1764 RVA: 0x0000C2D0 File Offset: 0x0000A4D0
		public long BufferCount { get; private set; }

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x060006E5 RID: 1765 RVA: 0x0000C2DC File Offset: 0x0000A4DC
		// (set) Token: 0x060006E6 RID: 1766 RVA: 0x0000C2E4 File Offset: 0x0000A4E4
		public int BufferSize { get; private set; }

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x060006E7 RID: 1767 RVA: 0x0000C2F0 File Offset: 0x0000A4F0
		public long TotalBufferSize
		{
			get
			{
				return this.BufferCount * (long)this.BufferSize;
			}
		}
	}
}
