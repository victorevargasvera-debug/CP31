using System;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x0200047A RID: 1146
	public class Fbi2Record : global::NPOI.HSSF.Record.RowDataRecord
	{
		// Token: 0x06002A83 RID: 10883 RVA: 0x0006144D File Offset: 0x0005F64D
		public Fbi2Record(global::NPOI.HSSF.Record.RecordInputStream ris) : base(ris)
		{
		}

		// Token: 0x17000AB2 RID: 2738
		// (get) Token: 0x06002A84 RID: 10884 RVA: 0x00061456 File Offset: 0x0005F656
		protected override int DataSize
		{
			get
			{
				return base.DataSize;
			}
		}

		// Token: 0x06002A85 RID: 10885 RVA: 0x0006145E File Offset: 0x0005F65E
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			base.Serialize(out1);
		}

		// Token: 0x17000AB3 RID: 2739
		// (get) Token: 0x06002A86 RID: 10886 RVA: 0x0007F4C2 File Offset: 0x0007D6C2
		public override short Sid
		{
			get
			{
				return 4200;
			}
		}

		// Token: 0x04001264 RID: 4708
		public const short sid = 4200;
	}
}
