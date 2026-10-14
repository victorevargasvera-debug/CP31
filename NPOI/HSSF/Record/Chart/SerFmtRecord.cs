using System;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x02000489 RID: 1161
	public class SerFmtRecord : global::NPOI.HSSF.Record.RowDataRecord
	{
		// Token: 0x06002AE8 RID: 10984 RVA: 0x0006144D File Offset: 0x0005F64D
		public SerFmtRecord(global::NPOI.HSSF.Record.RecordInputStream ris) : base(ris)
		{
		}

		// Token: 0x17000ADE RID: 2782
		// (get) Token: 0x06002AE9 RID: 10985 RVA: 0x00061456 File Offset: 0x0005F656
		protected override int DataSize
		{
			get
			{
				return base.DataSize;
			}
		}

		// Token: 0x06002AEA RID: 10986 RVA: 0x0006145E File Offset: 0x0005F65E
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			base.Serialize(out1);
		}

		// Token: 0x17000ADF RID: 2783
		// (get) Token: 0x06002AEB RID: 10987 RVA: 0x0007FCC1 File Offset: 0x0007DEC1
		public override short Sid
		{
			get
			{
				return 4189;
			}
		}

		// Token: 0x04001289 RID: 4745
		public const short sid = 4189;
	}
}
