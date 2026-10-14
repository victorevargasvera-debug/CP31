using System;
using NPOI.HSSF.Record;

namespace NPOI.HSSF.EventUserModel
{
	// Token: 0x02000345 RID: 837
	public abstract class AbortableHSSFListener : global::NPOI.HSSF.EventUserModel.IHSSFListener
	{
		// Token: 0x0600190A RID: 6410 RVA: 0x00019A7F File Offset: 0x00017C7F
		public virtual void ProcessRecord(global::NPOI.HSSF.Record.Record record)
		{
		}

		// Token: 0x0600190B RID: 6411
		public abstract short AbortableProcessRecord(global::NPOI.HSSF.Record.Record record);
	}
}
