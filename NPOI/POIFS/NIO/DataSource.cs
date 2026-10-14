using System;
using System.IO;
using NPOI.Util;

namespace NPOI.POIFS.NIO
{
	// Token: 0x020002C4 RID: 708
	public abstract class DataSource
	{
		// Token: 0x06001394 RID: 5012
		public abstract global::NPOI.Util.ByteBuffer Read(int length, long position);

		// Token: 0x06001395 RID: 5013
		public abstract void Write(global::NPOI.Util.ByteBuffer src, long position);

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06001396 RID: 5014
		public abstract long Size { get; }

		// Token: 0x06001397 RID: 5015
		public abstract void Close();

		// Token: 0x06001398 RID: 5016
		public abstract void CopyTo(global::System.IO.Stream stream);
	}
}
