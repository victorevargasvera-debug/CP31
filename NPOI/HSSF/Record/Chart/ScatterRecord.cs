using System;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x02000486 RID: 1158
	public class ScatterRecord : global::NPOI.HSSF.Record.RowDataRecord
	{
		// Token: 0x06002ADC RID: 10972 RVA: 0x0006144D File Offset: 0x0005F64D
		public ScatterRecord(global::NPOI.HSSF.Record.RecordInputStream ris) : base(ris)
		{
		}

		// Token: 0x17000AD8 RID: 2776
		// (get) Token: 0x06002ADD RID: 10973 RVA: 0x00061456 File Offset: 0x0005F656
		protected override int DataSize
		{
			get
			{
				return base.DataSize;
			}
		}

		// Token: 0x06002ADE RID: 10974 RVA: 0x0006145E File Offset: 0x0005F65E
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			base.Serialize(out1);
		}

		// Token: 0x17000AD9 RID: 2777
		// (get) Token: 0x06002ADF RID: 10975 RVA: 0x0007FCAC File Offset: 0x0007DEAC
		public override short Sid
		{
			get
			{
				return 4123;
			}
		}

		// Token: 0x04001286 RID: 4742
		public const short sid = 4123;
	}
}
