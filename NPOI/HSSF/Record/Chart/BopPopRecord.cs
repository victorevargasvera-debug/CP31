using System;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x0200046D RID: 1133
	public class BopPopRecord : global::NPOI.HSSF.Record.RowDataRecord
	{
		// Token: 0x06002A17 RID: 10775 RVA: 0x0006144D File Offset: 0x0005F64D
		public BopPopRecord(global::NPOI.HSSF.Record.RecordInputStream ris) : base(ris)
		{
		}

		// Token: 0x17000A87 RID: 2695
		// (get) Token: 0x06002A18 RID: 10776 RVA: 0x00061456 File Offset: 0x0005F656
		protected override int DataSize
		{
			get
			{
				return base.DataSize;
			}
		}

		// Token: 0x06002A19 RID: 10777 RVA: 0x0006145E File Offset: 0x0005F65E
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			base.Serialize(out1);
		}

		// Token: 0x17000A88 RID: 2696
		// (get) Token: 0x06002A1A RID: 10778 RVA: 0x0007E7BD File Offset: 0x0007C9BD
		public override short Sid
		{
			get
			{
				return 4193;
			}
		}

		// Token: 0x04001237 RID: 4663
		public const short sid = 4193;
	}
}
