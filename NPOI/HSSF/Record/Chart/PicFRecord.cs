using System;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x02000482 RID: 1154
	public class PicFRecord : global::NPOI.HSSF.Record.RowDataRecord
	{
		// Token: 0x06002ACC RID: 10956 RVA: 0x0006144D File Offset: 0x0005F64D
		public PicFRecord(global::NPOI.HSSF.Record.RecordInputStream ris) : base(ris)
		{
		}

		// Token: 0x17000AD0 RID: 2768
		// (get) Token: 0x06002ACD RID: 10957 RVA: 0x00061456 File Offset: 0x0005F656
		protected override int DataSize
		{
			get
			{
				return base.DataSize;
			}
		}

		// Token: 0x06002ACE RID: 10958 RVA: 0x0006145E File Offset: 0x0005F65E
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			base.Serialize(out1);
		}

		// Token: 0x17000AD1 RID: 2769
		// (get) Token: 0x06002ACF RID: 10959 RVA: 0x0007FC90 File Offset: 0x0007DE90
		public override short Sid
		{
			get
			{
				return 4156;
			}
		}

		// Token: 0x04001282 RID: 4738
		public const short sid = 4156;
	}
}
