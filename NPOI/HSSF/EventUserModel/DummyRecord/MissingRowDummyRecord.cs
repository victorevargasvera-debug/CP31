using System;

namespace NPOI.HSSF.EventUserModel.DummyRecord
{
	// Token: 0x02000351 RID: 849
	public class MissingRowDummyRecord : global::NPOI.HSSF.EventUserModel.DummyRecord.DummyRecordBase
	{
		// Token: 0x0600193A RID: 6458 RVA: 0x0004D849 File Offset: 0x0004BA49
		public MissingRowDummyRecord(int rowNumber)
		{
			this.rowNumber = rowNumber;
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x0600193B RID: 6459 RVA: 0x0004D858 File Offset: 0x0004BA58
		public int RowNumber
		{
			get
			{
				return this.rowNumber;
			}
		}

		// Token: 0x04000A11 RID: 2577
		private int rowNumber;
	}
}
