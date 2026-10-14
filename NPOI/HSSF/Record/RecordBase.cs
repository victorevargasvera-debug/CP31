using System;

namespace NPOI.HSSF.Record
{
	// Token: 0x0200040E RID: 1038
	public abstract class RecordBase
	{
		// Token: 0x060025D9 RID: 9689
		public abstract int Serialize(int offset, byte[] data);

		// Token: 0x17000912 RID: 2322
		// (get) Token: 0x060025DA RID: 9690
		public abstract int RecordSize { get; }
	}
}
