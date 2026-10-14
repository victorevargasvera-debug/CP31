using System;
using System.Collections.Generic;
using NPOI.DDF;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003D1 RID: 977
	internal class RecordSizeListener : global::NPOI.DDF.EscherSerializationListener
	{
		// Token: 0x0600226F RID: 8815 RVA: 0x0006807F File Offset: 0x0006627F
		public RecordSizeListener(global::System.Collections.Generic.IList<int> spEndingOffsets, global::NPOI.DDF.EscherRecord e)
		{
			this.spEndingOffsets = spEndingOffsets;
			this.record = e;
		}

		// Token: 0x06002270 RID: 8816 RVA: 0x00019A7F File Offset: 0x00017C7F
		void global::NPOI.DDF.EscherSerializationListener.BeforeRecordSerialize(int offset, short recordId, global::NPOI.DDF.EscherRecord record)
		{
		}

		// Token: 0x06002271 RID: 8817 RVA: 0x00068095 File Offset: 0x00066295
		void global::NPOI.DDF.EscherSerializationListener.AfterRecordSerialize(int offset, short recordId, int size, global::NPOI.DDF.EscherRecord record)
		{
			if (recordId == -4079 || recordId == -4083)
			{
				this.spEndingOffsets.Add(offset);
			}
		}

		// Token: 0x04000D88 RID: 3464
		private global::System.Collections.Generic.IList<int> spEndingOffsets;

		// Token: 0x04000D89 RID: 3465
		private global::NPOI.DDF.EscherRecord record;
	}
}
