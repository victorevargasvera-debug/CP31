using System;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x0200047D RID: 1149
	public class FrtFontListRecord : global::NPOI.HSSF.Record.RowDataRecord
	{
		// Token: 0x06002AA1 RID: 10913 RVA: 0x0006144D File Offset: 0x0005F64D
		public FrtFontListRecord(global::NPOI.HSSF.Record.RecordInputStream ris) : base(ris)
		{
		}

		// Token: 0x17000ABE RID: 2750
		// (get) Token: 0x06002AA2 RID: 10914 RVA: 0x00061456 File Offset: 0x0005F656
		protected override int DataSize
		{
			get
			{
				return base.DataSize;
			}
		}

		// Token: 0x06002AA3 RID: 10915 RVA: 0x0006145E File Offset: 0x0005F65E
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			base.Serialize(out1);
		}

		// Token: 0x17000ABF RID: 2751
		// (get) Token: 0x06002AA4 RID: 10916 RVA: 0x0007F899 File Offset: 0x0007DA99
		public override short Sid
		{
			get
			{
				return 2138;
			}
		}

		// Token: 0x0400126D RID: 4717
		public const short sid = 2138;
	}
}
