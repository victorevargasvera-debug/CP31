using System;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x02000472 RID: 1138
	public class CrtMlFrtContinueRecord : global::NPOI.HSSF.Record.RowDataRecord
	{
		// Token: 0x06002A55 RID: 10837 RVA: 0x0006144D File Offset: 0x0005F64D
		public CrtMlFrtContinueRecord(global::NPOI.HSSF.Record.RecordInputStream ris) : base(ris)
		{
		}

		// Token: 0x17000AA1 RID: 2721
		// (get) Token: 0x06002A56 RID: 10838 RVA: 0x00061456 File Offset: 0x0005F656
		protected override int DataSize
		{
			get
			{
				return base.DataSize;
			}
		}

		// Token: 0x06002A57 RID: 10839 RVA: 0x0006145E File Offset: 0x0005F65E
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			base.Serialize(out1);
		}

		// Token: 0x17000AA2 RID: 2722
		// (get) Token: 0x06002A58 RID: 10840 RVA: 0x0007F026 File Offset: 0x0007D226
		public override short Sid
		{
			get
			{
				return 2207;
			}
		}

		// Token: 0x0400124C RID: 4684
		public const short sid = 2207;
	}
}
