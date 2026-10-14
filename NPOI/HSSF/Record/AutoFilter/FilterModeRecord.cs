using System;
using NPOI.Util;

namespace NPOI.HSSF.Record.AutoFilter
{
	// Token: 0x02000456 RID: 1110
	public class FilterModeRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x06002918 RID: 10520 RVA: 0x0005FE49 File Offset: 0x0005E049
		public FilterModeRecord()
		{
		}

		// Token: 0x06002919 RID: 10521 RVA: 0x0005FE49 File Offset: 0x0005E049
		public FilterModeRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
		}

		// Token: 0x17000A26 RID: 2598
		// (get) Token: 0x0600291A RID: 10522 RVA: 0x0007C22D File Offset: 0x0007A42D
		public override short Sid
		{
			get
			{
				return 155;
			}
		}

		// Token: 0x17000A27 RID: 2599
		// (get) Token: 0x0600291B RID: 10523 RVA: 0x00006EB4 File Offset: 0x000050B4
		protected override int DataSize
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x0600291C RID: 10524 RVA: 0x00019A7F File Offset: 0x00017C7F
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
		}

		// Token: 0x0600291D RID: 10525 RVA: 0x0007C234 File Offset: 0x0007A434
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.AutoFilter.FilterModeRecord();
		}

		// Token: 0x040011A9 RID: 4521
		public const short sid = 155;
	}
}
