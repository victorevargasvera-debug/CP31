using System;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x02000397 RID: 919
	public class ContinueFrt12Record : global::NPOI.HSSF.Record.RowDataRecord
	{
		// Token: 0x06001FA1 RID: 8097 RVA: 0x0006144D File Offset: 0x0005F64D
		public ContinueFrt12Record(global::NPOI.HSSF.Record.RecordInputStream ris) : base(ris)
		{
		}

		// Token: 0x170006B8 RID: 1720
		// (get) Token: 0x06001FA2 RID: 8098 RVA: 0x00061456 File Offset: 0x0005F656
		protected override int DataSize
		{
			get
			{
				return base.DataSize;
			}
		}

		// Token: 0x06001FA3 RID: 8099 RVA: 0x0006145E File Offset: 0x0005F65E
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			base.Serialize(out1);
		}

		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x06001FA4 RID: 8100 RVA: 0x00061467 File Offset: 0x0005F667
		public override short Sid
		{
			get
			{
				return 2175;
			}
		}

		// Token: 0x04000C28 RID: 3112
		public const short sid = 2175;
	}
}
