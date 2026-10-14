using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x02000406 RID: 1030
	public class PrintGridlinesRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x0600256B RID: 9579 RVA: 0x0005FE49 File Offset: 0x0005E049
		public PrintGridlinesRecord()
		{
		}

		// Token: 0x0600256C RID: 9580 RVA: 0x0007088A File Offset: 0x0006EA8A
		public PrintGridlinesRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_print_gridlines = in1.ReadShort();
		}

		// Token: 0x170008E7 RID: 2279
		// (get) Token: 0x0600256D RID: 9581 RVA: 0x0007089E File Offset: 0x0006EA9E
		// (set) Token: 0x0600256E RID: 9582 RVA: 0x000708A9 File Offset: 0x0006EAA9
		public bool PrintGridlines
		{
			get
			{
				return this.field_1_print_gridlines == 1;
			}
			set
			{
				if (value)
				{
					this.field_1_print_gridlines = 1;
					return;
				}
				this.field_1_print_gridlines = 0;
			}
		}

		// Token: 0x0600256F RID: 9583 RVA: 0x000708C0 File Offset: 0x0006EAC0
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[PRINTGRIDLINES]\n");
			stringBuilder.Append("    .printgridlines = ").Append(this.PrintGridlines).Append("\n");
			stringBuilder.Append("[/PRINTGRIDLINES]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002570 RID: 9584 RVA: 0x00070910 File Offset: 0x0006EB10
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this.field_1_print_gridlines);
		}

		// Token: 0x170008E8 RID: 2280
		// (get) Token: 0x06002571 RID: 9585 RVA: 0x00016A02 File Offset: 0x00014C02
		protected override int DataSize
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x170008E9 RID: 2281
		// (get) Token: 0x06002572 RID: 9586 RVA: 0x0007091E File Offset: 0x0006EB1E
		public override short Sid
		{
			get
			{
				return 43;
			}
		}

		// Token: 0x06002573 RID: 9587 RVA: 0x00070922 File Offset: 0x0006EB22
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.PrintGridlinesRecord
			{
				field_1_print_gridlines = this.field_1_print_gridlines
			};
		}

		// Token: 0x04000FBB RID: 4027
		public const short sid = 43;

		// Token: 0x04000FBC RID: 4028
		private short field_1_print_gridlines;
	}
}
