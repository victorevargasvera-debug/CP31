using System;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x0200048F RID: 1167
	public class SurfRecord : global::NPOI.HSSF.Record.RowDataRecord
	{
		// Token: 0x06002B26 RID: 11046 RVA: 0x0006144D File Offset: 0x0005F64D
		public SurfRecord(global::NPOI.HSSF.Record.RecordInputStream ris) : base(ris)
		{
		}

		// Token: 0x17000AF6 RID: 2806
		// (get) Token: 0x06002B27 RID: 11047 RVA: 0x00061456 File Offset: 0x0005F656
		protected override int DataSize
		{
			get
			{
				return base.DataSize;
			}
		}

		// Token: 0x06002B28 RID: 11048 RVA: 0x0006145E File Offset: 0x0005F65E
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			base.Serialize(out1);
		}

		// Token: 0x17000AF7 RID: 2807
		// (get) Token: 0x06002B29 RID: 11049 RVA: 0x000803FE File Offset: 0x0007E5FE
		public override short Sid
		{
			get
			{
				return 4159;
			}
		}

		// Token: 0x040012A1 RID: 4769
		public const short sid = 4159;
	}
}
