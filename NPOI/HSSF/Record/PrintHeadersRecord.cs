using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x02000407 RID: 1031
	public class PrintHeadersRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x06002574 RID: 9588 RVA: 0x0005FE49 File Offset: 0x0005E049
		public PrintHeadersRecord()
		{
		}

		// Token: 0x06002575 RID: 9589 RVA: 0x00070935 File Offset: 0x0006EB35
		public PrintHeadersRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_print_headers = in1.ReadShort();
		}

		// Token: 0x170008EA RID: 2282
		// (get) Token: 0x06002576 RID: 9590 RVA: 0x00070949 File Offset: 0x0006EB49
		// (set) Token: 0x06002577 RID: 9591 RVA: 0x00070954 File Offset: 0x0006EB54
		public bool PrintHeaders
		{
			get
			{
				return this.field_1_print_headers == 1;
			}
			set
			{
				this.field_1_print_headers = (value ? 1 : 0);
			}
		}

		// Token: 0x06002578 RID: 9592 RVA: 0x00070964 File Offset: 0x0006EB64
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[PRINTHEADERS]\n");
			stringBuilder.Append("    .printheaders   = ").Append(this.PrintHeaders).Append("\n");
			stringBuilder.Append("[/PRINTHEADERS]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002579 RID: 9593 RVA: 0x000709B4 File Offset: 0x0006EBB4
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this.field_1_print_headers);
		}

		// Token: 0x170008EB RID: 2283
		// (get) Token: 0x0600257A RID: 9594 RVA: 0x00016A02 File Offset: 0x00014C02
		protected override int DataSize
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x170008EC RID: 2284
		// (get) Token: 0x0600257B RID: 9595 RVA: 0x000709C2 File Offset: 0x0006EBC2
		public override short Sid
		{
			get
			{
				return 42;
			}
		}

		// Token: 0x0600257C RID: 9596 RVA: 0x000709C6 File Offset: 0x0006EBC6
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.PrintHeadersRecord
			{
				field_1_print_headers = this.field_1_print_headers
			};
		}

		// Token: 0x04000FBD RID: 4029
		public const short sid = 42;

		// Token: 0x04000FBE RID: 4030
		private short field_1_print_headers;
	}
}
