using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003AF RID: 943
	public class BottomMarginRecord : global::NPOI.HSSF.Record.StandardRecord, global::NPOI.HSSF.Record.IMargin, global::System.ICloneable
	{
		// Token: 0x060020A7 RID: 8359 RVA: 0x0005FE49 File Offset: 0x0005E049
		public BottomMarginRecord()
		{
		}

		// Token: 0x060020A8 RID: 8360 RVA: 0x0006425F File Offset: 0x0006245F
		public BottomMarginRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_margin = in1.ReadDouble();
		}

		// Token: 0x060020A9 RID: 8361 RVA: 0x00064274 File Offset: 0x00062474
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[BottomMargin]\n");
			stringBuilder.Append("    .margin               = ").Append(" (").Append(this.Margin).Append(" )\n");
			stringBuilder.Append("[/BottomMargin]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x060020AA RID: 8362 RVA: 0x000642CE File Offset: 0x000624CE
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteDouble(this.field_1_margin);
		}

		// Token: 0x1700071B RID: 1819
		// (get) Token: 0x060020AB RID: 8363 RVA: 0x00017DF4 File Offset: 0x00015FF4
		protected override int DataSize
		{
			get
			{
				return 8;
			}
		}

		// Token: 0x1700071C RID: 1820
		// (get) Token: 0x060020AC RID: 8364 RVA: 0x000642DC File Offset: 0x000624DC
		public override short Sid
		{
			get
			{
				return 41;
			}
		}

		// Token: 0x1700071D RID: 1821
		// (get) Token: 0x060020AD RID: 8365 RVA: 0x000642E0 File Offset: 0x000624E0
		// (set) Token: 0x060020AE RID: 8366 RVA: 0x000642E8 File Offset: 0x000624E8
		public double Margin
		{
			get
			{
				return this.field_1_margin;
			}
			set
			{
				this.field_1_margin = value;
			}
		}

		// Token: 0x060020AF RID: 8367 RVA: 0x000642F1 File Offset: 0x000624F1
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.BottomMarginRecord
			{
				field_1_margin = this.field_1_margin
			};
		}

		// Token: 0x04000CBE RID: 3262
		public const short sid = 41;

		// Token: 0x04000CBF RID: 3263
		private double field_1_margin;
	}
}
