using System;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x02000485 RID: 1157
	public class RichTextStreamRecord : global::NPOI.HSSF.Record.RowDataRecord
	{
		// Token: 0x06002AD8 RID: 10968 RVA: 0x0006144D File Offset: 0x0005F64D
		public RichTextStreamRecord(global::NPOI.HSSF.Record.RecordInputStream ris) : base(ris)
		{
		}

		// Token: 0x17000AD6 RID: 2774
		// (get) Token: 0x06002AD9 RID: 10969 RVA: 0x00061456 File Offset: 0x0005F656
		protected override int DataSize
		{
			get
			{
				return base.DataSize;
			}
		}

		// Token: 0x06002ADA RID: 10970 RVA: 0x0006145E File Offset: 0x0005F65E
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			base.Serialize(out1);
		}

		// Token: 0x17000AD7 RID: 2775
		// (get) Token: 0x06002ADB RID: 10971 RVA: 0x0007FCA5 File Offset: 0x0007DEA5
		public override short Sid
		{
			get
			{
				return 2214;
			}
		}

		// Token: 0x04001285 RID: 4741
		public const short sid = 2214;
	}
}
