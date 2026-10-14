using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x02000464 RID: 1124
	public class AttachedLabelRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x0600298E RID: 10638 RVA: 0x0007D19C File Offset: 0x0007B39C
		public AttachedLabelRecord()
		{
		}

		// Token: 0x0600298F RID: 10639 RVA: 0x0007D1FC File Offset: 0x0007B3FC
		public AttachedLabelRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_formatFlags = in1.ReadShort();
		}

		// Token: 0x06002990 RID: 10640 RVA: 0x0007D268 File Offset: 0x0007B468
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[ATTACHEDLABEL]\n");
			stringBuilder.Append("    .formatFlags          = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.FormatFlags)).Append(" (").Append(this.FormatFlags).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("         .showActual               = ").Append(this.IsShowActual).Append('\n');
			stringBuilder.Append("         .showPercent              = ").Append(this.IsShowPercent).Append('\n');
			stringBuilder.Append("         .labelAsPercentage        = ").Append(this.IsLabelAsPercentage).Append('\n');
			stringBuilder.Append("         .smoothedLine             = ").Append(this.IsSmoothedLine).Append('\n');
			stringBuilder.Append("         .showLabel                = ").Append(this.IsShowLabel).Append('\n');
			stringBuilder.Append("         .showBubbleSizes          = ").Append(this.IsShowBubbleSizes).Append('\n');
			stringBuilder.Append("[/ATTACHEDLABEL]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002991 RID: 10641 RVA: 0x0007D39C File Offset: 0x0007B59C
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this.field_1_formatFlags);
		}

		// Token: 0x17000A4D RID: 2637
		// (get) Token: 0x06002992 RID: 10642 RVA: 0x00016A02 File Offset: 0x00014C02
		protected override int DataSize
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x17000A4E RID: 2638
		// (get) Token: 0x06002993 RID: 10643 RVA: 0x0007D3AA File Offset: 0x0007B5AA
		public override short Sid
		{
			get
			{
				return 4108;
			}
		}

		// Token: 0x06002994 RID: 10644 RVA: 0x0007D3B1 File Offset: 0x0007B5B1
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.Chart.AttachedLabelRecord
			{
				field_1_formatFlags = this.field_1_formatFlags
			};
		}

		// Token: 0x17000A4F RID: 2639
		// (get) Token: 0x06002995 RID: 10645 RVA: 0x0007D3C4 File Offset: 0x0007B5C4
		// (set) Token: 0x06002996 RID: 10646 RVA: 0x0007D3CC File Offset: 0x0007B5CC
		public short FormatFlags
		{
			get
			{
				return this.field_1_formatFlags;
			}
			set
			{
				this.field_1_formatFlags = value;
			}
		}

		// Token: 0x17000A50 RID: 2640
		// (get) Token: 0x06002997 RID: 10647 RVA: 0x0007D3D5 File Offset: 0x0007B5D5
		// (set) Token: 0x06002998 RID: 10648 RVA: 0x0007D3E8 File Offset: 0x0007B5E8
		public bool IsShowActual
		{
			get
			{
				return this.showActual.IsSet((int)this.field_1_formatFlags);
			}
			set
			{
				this.field_1_formatFlags = this.showActual.SetShortBoolean(this.field_1_formatFlags, value);
			}
		}

		// Token: 0x17000A51 RID: 2641
		// (get) Token: 0x06002999 RID: 10649 RVA: 0x0007D402 File Offset: 0x0007B602
		// (set) Token: 0x0600299A RID: 10650 RVA: 0x0007D415 File Offset: 0x0007B615
		public bool IsShowPercent
		{
			get
			{
				return this.showPercent.IsSet((int)this.field_1_formatFlags);
			}
			set
			{
				this.field_1_formatFlags = this.showPercent.SetShortBoolean(this.field_1_formatFlags, value);
			}
		}

		// Token: 0x17000A52 RID: 2642
		// (get) Token: 0x0600299B RID: 10651 RVA: 0x0007D42F File Offset: 0x0007B62F
		// (set) Token: 0x0600299C RID: 10652 RVA: 0x0007D442 File Offset: 0x0007B642
		public bool IsLabelAsPercentage
		{
			get
			{
				return this.labelAsPercentage.IsSet((int)this.field_1_formatFlags);
			}
			set
			{
				this.field_1_formatFlags = this.labelAsPercentage.SetShortBoolean(this.field_1_formatFlags, value);
			}
		}

		// Token: 0x17000A53 RID: 2643
		// (get) Token: 0x0600299D RID: 10653 RVA: 0x0007D45C File Offset: 0x0007B65C
		// (set) Token: 0x0600299E RID: 10654 RVA: 0x0007D46F File Offset: 0x0007B66F
		public bool IsSmoothedLine
		{
			get
			{
				return this.smoothedLine.IsSet((int)this.field_1_formatFlags);
			}
			set
			{
				this.field_1_formatFlags = this.smoothedLine.SetShortBoolean(this.field_1_formatFlags, value);
			}
		}

		// Token: 0x17000A54 RID: 2644
		// (get) Token: 0x0600299F RID: 10655 RVA: 0x0007D489 File Offset: 0x0007B689
		// (set) Token: 0x060029A0 RID: 10656 RVA: 0x0007D49C File Offset: 0x0007B69C
		public bool IsShowLabel
		{
			get
			{
				return this.showLabel.IsSet((int)this.field_1_formatFlags);
			}
			set
			{
				this.field_1_formatFlags = this.showLabel.SetShortBoolean(this.field_1_formatFlags, value);
			}
		}

		// Token: 0x17000A55 RID: 2645
		// (get) Token: 0x060029A1 RID: 10657 RVA: 0x0007D4B6 File Offset: 0x0007B6B6
		// (set) Token: 0x060029A2 RID: 10658 RVA: 0x0007D4C9 File Offset: 0x0007B6C9
		public bool IsShowBubbleSizes
		{
			get
			{
				return this.showBubbleSizes.IsSet((int)this.field_1_formatFlags);
			}
			set
			{
				this.field_1_formatFlags = this.showBubbleSizes.SetShortBoolean(this.field_1_formatFlags, value);
			}
		}

		// Token: 0x040011F7 RID: 4599
		public const short sid = 4108;

		// Token: 0x040011F8 RID: 4600
		private short field_1_formatFlags;

		// Token: 0x040011F9 RID: 4601
		private global::NPOI.Util.BitField showActual = global::NPOI.Util.BitFieldFactory.GetInstance(1);

		// Token: 0x040011FA RID: 4602
		private global::NPOI.Util.BitField showPercent = global::NPOI.Util.BitFieldFactory.GetInstance(2);

		// Token: 0x040011FB RID: 4603
		private global::NPOI.Util.BitField labelAsPercentage = global::NPOI.Util.BitFieldFactory.GetInstance(4);

		// Token: 0x040011FC RID: 4604
		private global::NPOI.Util.BitField smoothedLine = global::NPOI.Util.BitFieldFactory.GetInstance(8);

		// Token: 0x040011FD RID: 4605
		private global::NPOI.Util.BitField showLabel = global::NPOI.Util.BitFieldFactory.GetInstance(16);

		// Token: 0x040011FE RID: 4606
		private global::NPOI.Util.BitField showBubbleSizes = global::NPOI.Util.BitFieldFactory.GetInstance(32);
	}
}
