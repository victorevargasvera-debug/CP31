using System;

namespace NPOI.HSSF.EventUserModel.DummyRecord
{
	// Token: 0x0200034F RID: 847
	public class LastCellOfRowDummyRecord : global::NPOI.HSSF.EventUserModel.DummyRecord.DummyRecordBase
	{
		// Token: 0x06001934 RID: 6452 RVA: 0x0004D7FD File Offset: 0x0004B9FD
		public LastCellOfRowDummyRecord(int row, int lastColumnNumber)
		{
			this.row = row;
			this.lastColumnNumber = lastColumnNumber;
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x06001935 RID: 6453 RVA: 0x0004D813 File Offset: 0x0004BA13
		public int Row
		{
			get
			{
				return this.row;
			}
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x06001936 RID: 6454 RVA: 0x0004D81B File Offset: 0x0004BA1B
		public int LastColumnNumber
		{
			get
			{
				return this.lastColumnNumber;
			}
		}

		// Token: 0x04000A0D RID: 2573
		private int row;

		// Token: 0x04000A0E RID: 2574
		private int lastColumnNumber;
	}
}
