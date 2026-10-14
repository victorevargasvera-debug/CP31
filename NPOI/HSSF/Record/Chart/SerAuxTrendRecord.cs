using System;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x02000488 RID: 1160
	public class SerAuxTrendRecord : global::NPOI.HSSF.Record.RowDataRecord
	{
		// Token: 0x06002AE4 RID: 10980 RVA: 0x0006144D File Offset: 0x0005F64D
		public SerAuxTrendRecord(global::NPOI.HSSF.Record.RecordInputStream ris) : base(ris)
		{
		}

		// Token: 0x17000ADC RID: 2780
		// (get) Token: 0x06002AE5 RID: 10981 RVA: 0x00061456 File Offset: 0x0005F656
		protected override int DataSize
		{
			get
			{
				return base.DataSize;
			}
		}

		// Token: 0x06002AE6 RID: 10982 RVA: 0x0006145E File Offset: 0x0005F65E
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			base.Serialize(out1);
		}

		// Token: 0x17000ADD RID: 2781
		// (get) Token: 0x06002AE7 RID: 10983 RVA: 0x0007FCBA File Offset: 0x0007DEBA
		public override short Sid
		{
			get
			{
				return 4171;
			}
		}

		// Token: 0x04001288 RID: 4744
		public const short sid = 4171;
	}
}
