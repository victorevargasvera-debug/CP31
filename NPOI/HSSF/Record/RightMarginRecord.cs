using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x02000416 RID: 1046
	public class RightMarginRecord : global::NPOI.HSSF.Record.StandardRecord, global::NPOI.HSSF.Record.IMargin
	{
		// Token: 0x06002632 RID: 9778 RVA: 0x0005FE49 File Offset: 0x0005E049
		public RightMarginRecord()
		{
		}

		// Token: 0x06002633 RID: 9779 RVA: 0x00073357 File Offset: 0x00071557
		public RightMarginRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_margin = in1.ReadDouble();
		}

		// Token: 0x06002634 RID: 9780 RVA: 0x0007336C File Offset: 0x0007156C
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[RightMargin]\n");
			stringBuilder.Append("    .margin               = ").Append(" (").Append(this.Margin).Append(" )\n");
			stringBuilder.Append("[/RightMargin]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x17000924 RID: 2340
		// (get) Token: 0x06002635 RID: 9781 RVA: 0x000733C6 File Offset: 0x000715C6
		public override short Sid
		{
			get
			{
				return 39;
			}
		}

		// Token: 0x06002636 RID: 9782 RVA: 0x000733CA File Offset: 0x000715CA
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteDouble(this.field_1_margin);
		}

		// Token: 0x17000925 RID: 2341
		// (get) Token: 0x06002637 RID: 9783 RVA: 0x00017DF4 File Offset: 0x00015FF4
		protected override int DataSize
		{
			get
			{
				return 8;
			}
		}

		// Token: 0x17000926 RID: 2342
		// (get) Token: 0x06002638 RID: 9784 RVA: 0x000733D8 File Offset: 0x000715D8
		// (set) Token: 0x06002639 RID: 9785 RVA: 0x000733E0 File Offset: 0x000715E0
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

		// Token: 0x0600263A RID: 9786 RVA: 0x000733E9 File Offset: 0x000715E9
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.RightMarginRecord
			{
				field_1_margin = this.field_1_margin
			};
		}

		// Token: 0x04000FFF RID: 4095
		public const short sid = 39;

		// Token: 0x04001000 RID: 4096
		private double field_1_margin;
	}
}
