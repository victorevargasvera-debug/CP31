using System;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x02000478 RID: 1144
	public class DropBarRecord : global::NPOI.HSSF.Record.RowDataRecord
	{
		// Token: 0x06002A75 RID: 10869 RVA: 0x0006144D File Offset: 0x0005F64D
		public DropBarRecord(global::NPOI.HSSF.Record.RecordInputStream ris) : base(ris)
		{
		}

		// Token: 0x17000AAD RID: 2733
		// (get) Token: 0x06002A76 RID: 10870 RVA: 0x00061456 File Offset: 0x0005F656
		protected override int DataSize
		{
			get
			{
				return base.DataSize;
			}
		}

		// Token: 0x06002A77 RID: 10871 RVA: 0x0006145E File Offset: 0x0005F65E
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			base.Serialize(out1);
		}

		// Token: 0x17000AAE RID: 2734
		// (get) Token: 0x06002A78 RID: 10872 RVA: 0x0007F2F2 File Offset: 0x0007D4F2
		public override short Sid
		{
			get
			{
				return 4157;
			}
		}

		// Token: 0x0400125E RID: 4702
		public const short sid = 4157;
	}
}
