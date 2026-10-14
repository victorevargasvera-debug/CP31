using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x020004B9 RID: 1209
	public class SeriesLabelsRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x06002D39 RID: 11577 RVA: 0x00085DC4 File Offset: 0x00083FC4
		public SeriesLabelsRecord()
		{
		}

		// Token: 0x06002D3A RID: 11578 RVA: 0x00085E24 File Offset: 0x00084024
		public SeriesLabelsRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_formatFlags = in1.ReadShort();
		}

		// Token: 0x06002D3B RID: 11579 RVA: 0x00085E90 File Offset: 0x00084090
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

		// Token: 0x06002D3C RID: 11580 RVA: 0x00085FC4 File Offset: 0x000841C4
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this.field_1_formatFlags);
		}

		// Token: 0x17000BC8 RID: 3016
		// (get) Token: 0x06002D3D RID: 11581 RVA: 0x00016A02 File Offset: 0x00014C02
		protected override int DataSize
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x17000BC9 RID: 3017
		// (get) Token: 0x06002D3E RID: 11582 RVA: 0x00085FD2 File Offset: 0x000841D2
		public override short Sid
		{
			get
			{
				return global::NPOI.HSSF.Record.Chart.SeriesLabelsRecord.sid;
			}
		}

		// Token: 0x06002D3F RID: 11583 RVA: 0x00085FD9 File Offset: 0x000841D9
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.Chart.SeriesLabelsRecord
			{
				field_1_formatFlags = this.field_1_formatFlags
			};
		}

		// Token: 0x17000BCA RID: 3018
		// (get) Token: 0x06002D40 RID: 11584 RVA: 0x00085FEC File Offset: 0x000841EC
		// (set) Token: 0x06002D41 RID: 11585 RVA: 0x00085FF4 File Offset: 0x000841F4
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

		// Token: 0x17000BCB RID: 3019
		// (get) Token: 0x06002D42 RID: 11586 RVA: 0x00085FFD File Offset: 0x000841FD
		// (set) Token: 0x06002D43 RID: 11587 RVA: 0x00086010 File Offset: 0x00084210
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

		// Token: 0x17000BCC RID: 3020
		// (get) Token: 0x06002D44 RID: 11588 RVA: 0x0008602A File Offset: 0x0008422A
		// (set) Token: 0x06002D45 RID: 11589 RVA: 0x0008603D File Offset: 0x0008423D
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

		// Token: 0x17000BCD RID: 3021
		// (get) Token: 0x06002D46 RID: 11590 RVA: 0x00086057 File Offset: 0x00084257
		// (set) Token: 0x06002D47 RID: 11591 RVA: 0x0008606A File Offset: 0x0008426A
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

		// Token: 0x17000BCE RID: 3022
		// (get) Token: 0x06002D48 RID: 11592 RVA: 0x00086084 File Offset: 0x00084284
		// (set) Token: 0x06002D49 RID: 11593 RVA: 0x00086097 File Offset: 0x00084297
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

		// Token: 0x17000BCF RID: 3023
		// (get) Token: 0x06002D4A RID: 11594 RVA: 0x000860B1 File Offset: 0x000842B1
		// (set) Token: 0x06002D4B RID: 11595 RVA: 0x000860C4 File Offset: 0x000842C4
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

		// Token: 0x17000BD0 RID: 3024
		// (get) Token: 0x06002D4C RID: 11596 RVA: 0x000860DE File Offset: 0x000842DE
		// (set) Token: 0x06002D4D RID: 11597 RVA: 0x000860F1 File Offset: 0x000842F1
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

		// Token: 0x040013CD RID: 5069
		public static short sid = 4108;

		// Token: 0x040013CE RID: 5070
		private short field_1_formatFlags;

		// Token: 0x040013CF RID: 5071
		private global::NPOI.Util.BitField showActual = global::NPOI.Util.BitFieldFactory.GetInstance(1);

		// Token: 0x040013D0 RID: 5072
		private global::NPOI.Util.BitField showPercent = global::NPOI.Util.BitFieldFactory.GetInstance(2);

		// Token: 0x040013D1 RID: 5073
		private global::NPOI.Util.BitField labelAsPercentage = global::NPOI.Util.BitFieldFactory.GetInstance(4);

		// Token: 0x040013D2 RID: 5074
		private global::NPOI.Util.BitField smoothedLine = global::NPOI.Util.BitFieldFactory.GetInstance(8);

		// Token: 0x040013D3 RID: 5075
		private global::NPOI.Util.BitField showLabel = global::NPOI.Util.BitFieldFactory.GetInstance(16);

		// Token: 0x040013D4 RID: 5076
		private global::NPOI.Util.BitField showBubbleSizes = global::NPOI.Util.BitFieldFactory.GetInstance(32);
	}
}
