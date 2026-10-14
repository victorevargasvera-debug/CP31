using System;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x0200048A RID: 1162
	public class SerParentRecord : global::NPOI.HSSF.Record.RowDataRecord
	{
		// Token: 0x06002AEC RID: 10988 RVA: 0x0006144D File Offset: 0x0005F64D
		public SerParentRecord(global::NPOI.HSSF.Record.RecordInputStream ris) : base(ris)
		{
		}

		// Token: 0x17000AE0 RID: 2784
		// (get) Token: 0x06002AED RID: 10989 RVA: 0x00061456 File Offset: 0x0005F656
		protected override int DataSize
		{
			get
			{
				return base.DataSize;
			}
		}

		// Token: 0x06002AEE RID: 10990 RVA: 0x0006145E File Offset: 0x0005F65E
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			base.Serialize(out1);
		}

		// Token: 0x17000AE1 RID: 2785
		// (get) Token: 0x06002AEF RID: 10991 RVA: 0x0007FCC8 File Offset: 0x0007DEC8
		public override short Sid
		{
			get
			{
				return 4170;
			}
		}

		// Token: 0x0400128A RID: 4746
		public const short sid = 4170;
	}
}
