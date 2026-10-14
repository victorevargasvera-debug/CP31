using System;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x0200047E RID: 1150
	public class GelFrameRecord : global::NPOI.HSSF.Record.RowDataRecord
	{
		// Token: 0x06002AA5 RID: 10917 RVA: 0x0006144D File Offset: 0x0005F64D
		public GelFrameRecord(global::NPOI.HSSF.Record.RecordInputStream ris) : base(ris)
		{
		}

		// Token: 0x17000AC0 RID: 2752
		// (get) Token: 0x06002AA6 RID: 10918 RVA: 0x00061456 File Offset: 0x0005F656
		protected override int DataSize
		{
			get
			{
				return base.DataSize;
			}
		}

		// Token: 0x06002AA7 RID: 10919 RVA: 0x0006145E File Offset: 0x0005F65E
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			base.Serialize(out1);
		}

		// Token: 0x17000AC1 RID: 2753
		// (get) Token: 0x06002AA8 RID: 10920 RVA: 0x0007F8A0 File Offset: 0x0007DAA0
		public override short Sid
		{
			get
			{
				return 4198;
			}
		}

		// Token: 0x0400126E RID: 4718
		public const short sid = 4198;
	}
}
