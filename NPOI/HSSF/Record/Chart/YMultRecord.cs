using System;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x02000491 RID: 1169
	public class YMultRecord : global::NPOI.HSSF.Record.RowDataRecord
	{
		// Token: 0x06002B2E RID: 11054 RVA: 0x0006144D File Offset: 0x0005F64D
		public YMultRecord(global::NPOI.HSSF.Record.RecordInputStream ris) : base(ris)
		{
		}

		// Token: 0x17000AFA RID: 2810
		// (get) Token: 0x06002B2F RID: 11055 RVA: 0x00061456 File Offset: 0x0005F656
		protected override int DataSize
		{
			get
			{
				return base.DataSize;
			}
		}

		// Token: 0x06002B30 RID: 11056 RVA: 0x0006145E File Offset: 0x0005F65E
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			base.Serialize(out1);
		}

		// Token: 0x17000AFB RID: 2811
		// (get) Token: 0x06002B31 RID: 11057 RVA: 0x0008040C File Offset: 0x0007E60C
		public override short Sid
		{
			get
			{
				return 2135;
			}
		}

		// Token: 0x040012A3 RID: 4771
		public const short sid = 2135;
	}
}
