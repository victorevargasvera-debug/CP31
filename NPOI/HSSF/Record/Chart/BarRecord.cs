using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x0200049F RID: 1183
	public class BarRecord : global::NPOI.HSSF.Record.StandardRecord, global::System.ICloneable
	{
		// Token: 0x06002C0B RID: 11275 RVA: 0x00082CAF File Offset: 0x00080EAF
		public BarRecord()
		{
		}

		// Token: 0x06002C0C RID: 11276 RVA: 0x00082CE8 File Offset: 0x00080EE8
		public BarRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_barSpace = in1.ReadShort();
			this.field_2_categorySpace = in1.ReadShort();
			this.field_3_formatFlags = in1.ReadShort();
		}

		// Token: 0x06002C0D RID: 11277 RVA: 0x00082D50 File Offset: 0x00080F50
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[BAR]\n");
			stringBuilder.Append("    .barSpace             = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.BarSpace)).Append(" (").Append(this.BarSpace).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .categorySpace        = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.CategorySpace)).Append(" (").Append(this.CategorySpace).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .formatFlags          = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.FormatFlags)).Append(" (").Append(this.FormatFlags).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("         .horizontal               = ").Append(this.IsHorizontal).Append('\n');
			stringBuilder.Append("         .stacked                  = ").Append(this.IsStacked).Append('\n');
			stringBuilder.Append("         .DisplayAsPercentage      = ").Append(this.IsDisplayAsPercentage).Append('\n');
			stringBuilder.Append("         .shadow                   = ").Append(this.IsShadow).Append('\n');
			stringBuilder.Append("[/BAR]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002C0E RID: 11278 RVA: 0x00082EEA File Offset: 0x000810EA
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this.field_1_barSpace);
			out1.WriteShort((int)this.field_2_categorySpace);
			out1.WriteShort((int)this.field_3_formatFlags);
		}

		// Token: 0x17000B59 RID: 2905
		// (get) Token: 0x06002C0F RID: 11279 RVA: 0x00017F5F File Offset: 0x0001615F
		protected override int DataSize
		{
			get
			{
				return 6;
			}
		}

		// Token: 0x17000B5A RID: 2906
		// (get) Token: 0x06002C10 RID: 11280 RVA: 0x00082F10 File Offset: 0x00081110
		public override short Sid
		{
			get
			{
				return 4119;
			}
		}

		// Token: 0x06002C11 RID: 11281 RVA: 0x00082F17 File Offset: 0x00081117
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.Chart.BarRecord
			{
				field_1_barSpace = this.field_1_barSpace,
				field_2_categorySpace = this.field_2_categorySpace,
				field_3_formatFlags = this.field_3_formatFlags
			};
		}

		// Token: 0x17000B5B RID: 2907
		// (get) Token: 0x06002C12 RID: 11282 RVA: 0x00082F42 File Offset: 0x00081142
		// (set) Token: 0x06002C13 RID: 11283 RVA: 0x00082F4A File Offset: 0x0008114A
		public short BarSpace
		{
			get
			{
				return this.field_1_barSpace;
			}
			set
			{
				this.field_1_barSpace = value;
			}
		}

		// Token: 0x17000B5C RID: 2908
		// (get) Token: 0x06002C14 RID: 11284 RVA: 0x00082F53 File Offset: 0x00081153
		// (set) Token: 0x06002C15 RID: 11285 RVA: 0x00082F5B File Offset: 0x0008115B
		public short CategorySpace
		{
			get
			{
				return this.field_2_categorySpace;
			}
			set
			{
				this.field_2_categorySpace = value;
			}
		}

		// Token: 0x17000B5D RID: 2909
		// (get) Token: 0x06002C16 RID: 11286 RVA: 0x00082F64 File Offset: 0x00081164
		// (set) Token: 0x06002C17 RID: 11287 RVA: 0x00082F6C File Offset: 0x0008116C
		public short FormatFlags
		{
			get
			{
				return this.field_3_formatFlags;
			}
			set
			{
				this.field_3_formatFlags = value;
			}
		}

		// Token: 0x17000B5E RID: 2910
		// (get) Token: 0x06002C18 RID: 11288 RVA: 0x00082F75 File Offset: 0x00081175
		// (set) Token: 0x06002C19 RID: 11289 RVA: 0x00082F88 File Offset: 0x00081188
		public bool IsHorizontal
		{
			get
			{
				return this.horizontal.IsSet((int)this.field_3_formatFlags);
			}
			set
			{
				this.field_3_formatFlags = this.horizontal.SetShortBoolean(this.field_3_formatFlags, value);
			}
		}

		// Token: 0x17000B5F RID: 2911
		// (get) Token: 0x06002C1A RID: 11290 RVA: 0x00082FA2 File Offset: 0x000811A2
		// (set) Token: 0x06002C1B RID: 11291 RVA: 0x00082FB5 File Offset: 0x000811B5
		public bool IsStacked
		{
			get
			{
				return this.stacked.IsSet((int)this.field_3_formatFlags);
			}
			set
			{
				this.field_3_formatFlags = this.stacked.SetShortBoolean(this.field_3_formatFlags, value);
			}
		}

		// Token: 0x17000B60 RID: 2912
		// (get) Token: 0x06002C1C RID: 11292 RVA: 0x00082FCF File Offset: 0x000811CF
		// (set) Token: 0x06002C1D RID: 11293 RVA: 0x00082FE2 File Offset: 0x000811E2
		public bool IsDisplayAsPercentage
		{
			get
			{
				return this.DisplayAsPercentage.IsSet((int)this.field_3_formatFlags);
			}
			set
			{
				this.field_3_formatFlags = this.DisplayAsPercentage.SetShortBoolean(this.field_3_formatFlags, value);
			}
		}

		// Token: 0x17000B61 RID: 2913
		// (get) Token: 0x06002C1E RID: 11294 RVA: 0x00082FFC File Offset: 0x000811FC
		// (set) Token: 0x06002C1F RID: 11295 RVA: 0x0008300F File Offset: 0x0008120F
		public bool IsShadow
		{
			get
			{
				return this.shadow.IsSet((int)this.field_3_formatFlags);
			}
			set
			{
				this.field_3_formatFlags = this.shadow.SetShortBoolean(this.field_3_formatFlags, value);
			}
		}

		// Token: 0x0400132C RID: 4908
		public const short sid = 4119;

		// Token: 0x0400132D RID: 4909
		private short field_1_barSpace;

		// Token: 0x0400132E RID: 4910
		private short field_2_categorySpace;

		// Token: 0x0400132F RID: 4911
		private short field_3_formatFlags;

		// Token: 0x04001330 RID: 4912
		private global::NPOI.Util.BitField horizontal = global::NPOI.Util.BitFieldFactory.GetInstance(1);

		// Token: 0x04001331 RID: 4913
		private global::NPOI.Util.BitField stacked = global::NPOI.Util.BitFieldFactory.GetInstance(2);

		// Token: 0x04001332 RID: 4914
		private global::NPOI.Util.BitField DisplayAsPercentage = global::NPOI.Util.BitFieldFactory.GetInstance(4);

		// Token: 0x04001333 RID: 4915
		private global::NPOI.Util.BitField shadow = global::NPOI.Util.BitFieldFactory.GetInstance(8);
	}
}
