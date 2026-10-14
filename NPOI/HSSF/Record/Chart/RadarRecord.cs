using System;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x02000484 RID: 1156
	public class RadarRecord : global::NPOI.HSSF.Record.RowDataRecord
	{
		// Token: 0x06002AD4 RID: 10964 RVA: 0x0006144D File Offset: 0x0005F64D
		public RadarRecord(global::NPOI.HSSF.Record.RecordInputStream ris) : base(ris)
		{
		}

		// Token: 0x17000AD4 RID: 2772
		// (get) Token: 0x06002AD5 RID: 10965 RVA: 0x00061456 File Offset: 0x0005F656
		protected override int DataSize
		{
			get
			{
				return base.DataSize;
			}
		}

		// Token: 0x06002AD6 RID: 10966 RVA: 0x0006145E File Offset: 0x0005F65E
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			base.Serialize(out1);
		}

		// Token: 0x17000AD5 RID: 2773
		// (get) Token: 0x06002AD7 RID: 10967 RVA: 0x0007FC9E File Offset: 0x0007DE9E
		public override short Sid
		{
			get
			{
				return 4158;
			}
		}

		// Token: 0x04001284 RID: 4740
		public const short sid = 4158;
	}
}
