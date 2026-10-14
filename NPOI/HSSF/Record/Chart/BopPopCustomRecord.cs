using System;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x0200046C RID: 1132
	public class BopPopCustomRecord : global::NPOI.HSSF.Record.RowDataRecord
	{
		// Token: 0x06002A13 RID: 10771 RVA: 0x0006144D File Offset: 0x0005F64D
		public BopPopCustomRecord(global::NPOI.HSSF.Record.RecordInputStream ris) : base(ris)
		{
		}

		// Token: 0x17000A85 RID: 2693
		// (get) Token: 0x06002A14 RID: 10772 RVA: 0x00061456 File Offset: 0x0005F656
		protected override int DataSize
		{
			get
			{
				return base.DataSize;
			}
		}

		// Token: 0x06002A15 RID: 10773 RVA: 0x0006145E File Offset: 0x0005F65E
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			base.Serialize(out1);
		}

		// Token: 0x17000A86 RID: 2694
		// (get) Token: 0x06002A16 RID: 10774 RVA: 0x0007E7B6 File Offset: 0x0007C9B6
		public override short Sid
		{
			get
			{
				return 4199;
			}
		}

		// Token: 0x04001236 RID: 4662
		public const short sid = 4199;
	}
}
