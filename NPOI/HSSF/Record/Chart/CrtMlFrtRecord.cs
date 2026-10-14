using System;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x02000496 RID: 1174
	public class CrtMlFrtRecord : global::NPOI.HSSF.Record.RowDataRecord
	{
		// Token: 0x06002B8E RID: 11150 RVA: 0x0006144D File Offset: 0x0005F64D
		public CrtMlFrtRecord(global::NPOI.HSSF.Record.RecordInputStream ris) : base(ris)
		{
		}

		// Token: 0x17000B25 RID: 2853
		// (get) Token: 0x06002B8F RID: 11151 RVA: 0x00061456 File Offset: 0x0005F656
		protected override int DataSize
		{
			get
			{
				return base.DataSize;
			}
		}

		// Token: 0x06002B90 RID: 11152 RVA: 0x0006145E File Offset: 0x0005F65E
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			base.Serialize(out1);
		}

		// Token: 0x17000B26 RID: 2854
		// (get) Token: 0x06002B91 RID: 11153 RVA: 0x00081881 File Offset: 0x0007FA81
		public override short Sid
		{
			get
			{
				return 2206;
			}
		}

		// Token: 0x040012DB RID: 4827
		public const short sid = 2206;
	}
}
