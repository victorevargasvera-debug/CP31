using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003BB RID: 955
	public class CodepageRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x06002177 RID: 8567 RVA: 0x0005FE49 File Offset: 0x0005E049
		public CodepageRecord()
		{
		}

		// Token: 0x06002178 RID: 8568 RVA: 0x000663B5 File Offset: 0x000645B5
		public CodepageRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_codepage = in1.ReadShort();
		}

		// Token: 0x1700076D RID: 1901
		// (get) Token: 0x06002179 RID: 8569 RVA: 0x000663C9 File Offset: 0x000645C9
		// (set) Token: 0x0600217A RID: 8570 RVA: 0x000663D1 File Offset: 0x000645D1
		public short Codepage
		{
			get
			{
				return this.field_1_codepage;
			}
			set
			{
				this.field_1_codepage = value;
			}
		}

		// Token: 0x0600217B RID: 8571 RVA: 0x000663DC File Offset: 0x000645DC
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[CODEPAGE]\n");
			stringBuilder.Append("    .codepage        = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.Codepage)).Append("\n");
			stringBuilder.Append("[/CODEPAGE]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x0600217C RID: 8572 RVA: 0x00066431 File Offset: 0x00064631
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this.Codepage);
		}

		// Token: 0x1700076E RID: 1902
		// (get) Token: 0x0600217D RID: 8573 RVA: 0x00016A02 File Offset: 0x00014C02
		protected override int DataSize
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x1700076F RID: 1903
		// (get) Token: 0x0600217E RID: 8574 RVA: 0x0006643F File Offset: 0x0006463F
		public override short Sid
		{
			get
			{
				return 66;
			}
		}

		// Token: 0x04000D26 RID: 3366
		public const short sid = 66;

		// Token: 0x04000D27 RID: 3367
		private short field_1_codepage;

		// Token: 0x04000D28 RID: 3368
		public const short CODEPAGE = 1200;
	}
}
