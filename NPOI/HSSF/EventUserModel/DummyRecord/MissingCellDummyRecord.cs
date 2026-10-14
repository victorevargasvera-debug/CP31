using System;

namespace NPOI.HSSF.EventUserModel.DummyRecord
{
	// Token: 0x02000350 RID: 848
	public class MissingCellDummyRecord : global::NPOI.HSSF.EventUserModel.DummyRecord.DummyRecordBase
	{
		// Token: 0x06001937 RID: 6455 RVA: 0x0004D823 File Offset: 0x0004BA23
		public MissingCellDummyRecord(int row, int column)
		{
			this.row = row;
			this.column = column;
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x06001938 RID: 6456 RVA: 0x0004D839 File Offset: 0x0004BA39
		public int Row
		{
			get
			{
				return this.row;
			}
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06001939 RID: 6457 RVA: 0x0004D841 File Offset: 0x0004BA41
		public int Column
		{
			get
			{
				return this.column;
			}
		}

		// Token: 0x04000A0F RID: 2575
		private int row;

		// Token: 0x04000A10 RID: 2576
		private int column;
	}
}
