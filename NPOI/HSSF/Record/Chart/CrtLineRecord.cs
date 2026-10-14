using System;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x02000471 RID: 1137
	public class CrtLineRecord : global::NPOI.HSSF.Record.RowDataRecord
	{
		// Token: 0x06002A51 RID: 10833 RVA: 0x0006144D File Offset: 0x0005F64D
		public CrtLineRecord(global::NPOI.HSSF.Record.RecordInputStream ris) : base(ris)
		{
		}

		// Token: 0x17000A9F RID: 2719
		// (get) Token: 0x06002A52 RID: 10834 RVA: 0x00061456 File Offset: 0x0005F656
		protected override int DataSize
		{
			get
			{
				return base.DataSize;
			}
		}

		// Token: 0x06002A53 RID: 10835 RVA: 0x0006145E File Offset: 0x0005F65E
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			base.Serialize(out1);
		}

		// Token: 0x17000AA0 RID: 2720
		// (get) Token: 0x06002A54 RID: 10836 RVA: 0x0007F01F File Offset: 0x0007D21F
		public override short Sid
		{
			get
			{
				return 4124;
			}
		}

		// Token: 0x0400124B RID: 4683
		public const short sid = 4124;
	}
}
