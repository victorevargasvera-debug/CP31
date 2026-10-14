using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x02000435 RID: 1077
	public class TopMarginRecord : global::NPOI.HSSF.Record.StandardRecord, global::NPOI.HSSF.Record.IMargin
	{
		// Token: 0x060027CA RID: 10186 RVA: 0x0005FE49 File Offset: 0x0005E049
		public TopMarginRecord()
		{
		}

		// Token: 0x060027CB RID: 10187 RVA: 0x00077F25 File Offset: 0x00076125
		public TopMarginRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_margin = in1.ReadDouble();
		}

		// Token: 0x060027CC RID: 10188 RVA: 0x00077F3C File Offset: 0x0007613C
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[TopMargin]\n");
			stringBuilder.Append("    .margin               = ").Append(" (").Append(this.Margin).Append(" )\n");
			stringBuilder.Append("[/TopMargin]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x060027CD RID: 10189 RVA: 0x00077F96 File Offset: 0x00076196
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteDouble(this.field_1_margin);
		}

		// Token: 0x170009BC RID: 2492
		// (get) Token: 0x060027CE RID: 10190 RVA: 0x00017DF4 File Offset: 0x00015FF4
		protected override int DataSize
		{
			get
			{
				return 8;
			}
		}

		// Token: 0x170009BD RID: 2493
		// (get) Token: 0x060027CF RID: 10191 RVA: 0x00077FA4 File Offset: 0x000761A4
		public override short Sid
		{
			get
			{
				return 40;
			}
		}

		// Token: 0x170009BE RID: 2494
		// (get) Token: 0x060027D0 RID: 10192 RVA: 0x00077FA8 File Offset: 0x000761A8
		// (set) Token: 0x060027D1 RID: 10193 RVA: 0x00077FB0 File Offset: 0x000761B0
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

		// Token: 0x060027D2 RID: 10194 RVA: 0x00077FB9 File Offset: 0x000761B9
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.TopMarginRecord
			{
				field_1_margin = this.field_1_margin
			};
		}

		// Token: 0x040010E3 RID: 4323
		public const short sid = 40;

		// Token: 0x040010E4 RID: 4324
		private double field_1_margin;
	}
}
