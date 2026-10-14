using System;
using NPOI.HSSF.Record;
using NPOI.Util;

namespace NPOI.HSSF.EventUserModel.DummyRecord
{
	// Token: 0x0200034E RID: 846
	public abstract class DummyRecordBase : global::NPOI.HSSF.Record.Record
	{
		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x06001931 RID: 6449 RVA: 0x00017C13 File Offset: 0x00015E13
		public override short Sid
		{
			get
			{
				return -1;
			}
		}

		// Token: 0x06001932 RID: 6450 RVA: 0x0004D7F1 File Offset: 0x0004B9F1
		public override int Serialize(int offset, byte[] data)
		{
			throw new global::NPOI.Util.RecordFormatException("Cannot serialize a dummy record");
		}

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x06001933 RID: 6451 RVA: 0x0004D7F1 File Offset: 0x0004B9F1
		public override int RecordSize
		{
			get
			{
				throw new global::NPOI.Util.RecordFormatException("Cannot serialize a dummy record");
			}
		}
	}
}
