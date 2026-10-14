using System;
using System.Text;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003E8 RID: 1000
	public class HeaderRecord : global::NPOI.HSSF.Record.HeaderFooterBase, global::System.ICloneable
	{
		// Token: 0x060023FC RID: 9212 RVA: 0x0006B6A8 File Offset: 0x000698A8
		public HeaderRecord(string text) : base(text)
		{
		}

		// Token: 0x060023FD RID: 9213 RVA: 0x0006B6B1 File Offset: 0x000698B1
		public HeaderRecord(global::NPOI.HSSF.Record.RecordInputStream in1) : base(in1)
		{
		}

		// Token: 0x060023FE RID: 9214 RVA: 0x0006C580 File Offset: 0x0006A780
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[HEADER]\n");
			stringBuilder.Append("    .header = ").Append(base.Text).Append("\n");
			stringBuilder.Append("[/HEADER]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x1700085A RID: 2138
		// (get) Token: 0x060023FF RID: 9215 RVA: 0x00018AA0 File Offset: 0x00016CA0
		public override short Sid
		{
			get
			{
				return 20;
			}
		}

		// Token: 0x06002400 RID: 9216 RVA: 0x0006C5D0 File Offset: 0x0006A7D0
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.HeaderRecord(base.Text);
		}

		// Token: 0x04000F1B RID: 3867
		public const short sid = 20;
	}
}
