using System;
using System.Text;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003DF RID: 991
	public class FooterRecord : global::NPOI.HSSF.Record.HeaderFooterBase, global::System.ICloneable
	{
		// Token: 0x0600238A RID: 9098 RVA: 0x0006B6A8 File Offset: 0x000698A8
		public FooterRecord(string text) : base(text)
		{
		}

		// Token: 0x0600238B RID: 9099 RVA: 0x0006B6B1 File Offset: 0x000698B1
		public FooterRecord(global::NPOI.HSSF.Record.RecordInputStream in1) : base(in1)
		{
		}

		// Token: 0x0600238C RID: 9100 RVA: 0x0006B6BC File Offset: 0x000698BC
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[FOOTER]\n");
			stringBuilder.Append("    .footer         = ").Append(base.Text).Append("\n");
			stringBuilder.Append("[/FOOTER]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x17000831 RID: 2097
		// (get) Token: 0x0600238D RID: 9101 RVA: 0x0006B70C File Offset: 0x0006990C
		public override short Sid
		{
			get
			{
				return 21;
			}
		}

		// Token: 0x0600238E RID: 9102 RVA: 0x0006B710 File Offset: 0x00069910
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.FooterRecord(base.Text);
		}

		// Token: 0x04000EF6 RID: 3830
		public const short sid = 21;
	}
}
