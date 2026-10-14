using System;
using System.Collections.Generic;
using NPOI.DDF;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003D0 RID: 976
	internal class SerializationListener : global::NPOI.DDF.EscherSerializationListener
	{
		// Token: 0x0600226C RID: 8812 RVA: 0x00068037 File Offset: 0x00066237
		public SerializationListener(global::System.Collections.Generic.IList<int> spEndingOffsets, global::System.Collections.Generic.IList<global::NPOI.DDF.EscherRecord> records, global::NPOI.DDF.EscherRecord e)
		{
			this.spEndingOffsets = spEndingOffsets;
			this.records = records;
			this.record = e;
		}

		// Token: 0x0600226D RID: 8813 RVA: 0x00019A7F File Offset: 0x00017C7F
		void global::NPOI.DDF.EscherSerializationListener.BeforeRecordSerialize(int offset, short recordId, global::NPOI.DDF.EscherRecord record)
		{
		}

		// Token: 0x0600226E RID: 8814 RVA: 0x00068054 File Offset: 0x00066254
		void global::NPOI.DDF.EscherSerializationListener.AfterRecordSerialize(int offset, short recordId, int size, global::NPOI.DDF.EscherRecord record)
		{
			if (recordId == -4079 || recordId == -4083)
			{
				this.spEndingOffsets.Add(offset);
				this.records.Add(record);
			}
		}

		// Token: 0x04000D85 RID: 3461
		private global::System.Collections.Generic.IList<int> spEndingOffsets;

		// Token: 0x04000D86 RID: 3462
		private global::System.Collections.Generic.IList<global::NPOI.DDF.EscherRecord> records;

		// Token: 0x04000D87 RID: 3463
		private global::NPOI.DDF.EscherRecord record;
	}
}
