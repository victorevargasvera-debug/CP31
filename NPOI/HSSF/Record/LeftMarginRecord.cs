using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003F2 RID: 1010
	public class LeftMarginRecord : global::NPOI.HSSF.Record.StandardRecord, global::NPOI.HSSF.Record.IMargin, global::System.ICloneable
	{
		// Token: 0x06002478 RID: 9336 RVA: 0x0005FE49 File Offset: 0x0005E049
		public LeftMarginRecord()
		{
		}

		// Token: 0x06002479 RID: 9337 RVA: 0x0006DB1B File Offset: 0x0006BD1B
		public LeftMarginRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_margin = in1.ReadDouble();
		}

		// Token: 0x0600247A RID: 9338 RVA: 0x0006DB30 File Offset: 0x0006BD30
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[LeftMargin]\n");
			stringBuilder.Append("    .margin               = ").Append(" (").Append(this.Margin).Append(" )\n");
			stringBuilder.Append("[/LeftMargin]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x0600247B RID: 9339 RVA: 0x0006DB8A File Offset: 0x0006BD8A
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteDouble(this.field_1_margin);
		}

		// Token: 0x17000889 RID: 2185
		// (get) Token: 0x0600247C RID: 9340 RVA: 0x00017DF4 File Offset: 0x00015FF4
		protected override int DataSize
		{
			get
			{
				return 8;
			}
		}

		// Token: 0x1700088A RID: 2186
		// (get) Token: 0x0600247D RID: 9341 RVA: 0x0006DB98 File Offset: 0x0006BD98
		public override short Sid
		{
			get
			{
				return 38;
			}
		}

		// Token: 0x1700088B RID: 2187
		// (get) Token: 0x0600247E RID: 9342 RVA: 0x0006DB9C File Offset: 0x0006BD9C
		// (set) Token: 0x0600247F RID: 9343 RVA: 0x0006DBA4 File Offset: 0x0006BDA4
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

		// Token: 0x06002480 RID: 9344 RVA: 0x0006DBAD File Offset: 0x0006BDAD
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.LeftMarginRecord
			{
				field_1_margin = this.field_1_margin
			};
		}

		// Token: 0x04000F53 RID: 3923
		public const short sid = 38;

		// Token: 0x04000F54 RID: 3924
		private double field_1_margin;
	}
}
