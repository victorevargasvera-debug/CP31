using System;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x02000490 RID: 1168
	public class TextPropsStreamRecord : global::NPOI.HSSF.Record.RowDataRecord
	{
		// Token: 0x06002B2A RID: 11050 RVA: 0x0006144D File Offset: 0x0005F64D
		public TextPropsStreamRecord(global::NPOI.HSSF.Record.RecordInputStream ris) : base(ris)
		{
		}

		// Token: 0x17000AF8 RID: 2808
		// (get) Token: 0x06002B2B RID: 11051 RVA: 0x00061456 File Offset: 0x0005F656
		protected override int DataSize
		{
			get
			{
				return base.DataSize;
			}
		}

		// Token: 0x06002B2C RID: 11052 RVA: 0x0006145E File Offset: 0x0005F65E
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			base.Serialize(out1);
		}

		// Token: 0x17000AF9 RID: 2809
		// (get) Token: 0x06002B2D RID: 11053 RVA: 0x00080405 File Offset: 0x0007E605
		public override short Sid
		{
			get
			{
				return 2213;
			}
		}

		// Token: 0x040012A2 RID: 4770
		public const short sid = 2213;
	}
}
