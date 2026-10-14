using System;

namespace NPOI.DDF
{
	// Token: 0x02000545 RID: 1349
	public interface IEscherRecordFactory
	{
		// Token: 0x06003304 RID: 13060
		global::NPOI.DDF.EscherRecord CreateRecord(byte[] data, int offset);
	}
}
