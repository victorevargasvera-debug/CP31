using System;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x02000473 RID: 1139
	public class DataLabExtContentsRecord : global::NPOI.HSSF.Record.RowDataRecord
	{
		// Token: 0x06002A59 RID: 10841 RVA: 0x0006144D File Offset: 0x0005F64D
		public DataLabExtContentsRecord(global::NPOI.HSSF.Record.RecordInputStream ris) : base(ris)
		{
		}

		// Token: 0x17000AA3 RID: 2723
		// (get) Token: 0x06002A5A RID: 10842 RVA: 0x00061456 File Offset: 0x0005F656
		protected override int DataSize
		{
			get
			{
				return base.DataSize;
			}
		}

		// Token: 0x06002A5B RID: 10843 RVA: 0x0006145E File Offset: 0x0005F65E
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			base.Serialize(out1);
		}

		// Token: 0x17000AA4 RID: 2724
		// (get) Token: 0x06002A5C RID: 10844 RVA: 0x0007F02D File Offset: 0x0007D22D
		public override short Sid
		{
			get
			{
				return 2155;
			}
		}

		// Token: 0x0400124D RID: 4685
		public const short sid = 2155;
	}
}
