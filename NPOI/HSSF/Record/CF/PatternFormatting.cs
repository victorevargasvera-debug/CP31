using System;
using System.Text;
using NPOI.SS.UserModel;
using NPOI.Util;

namespace NPOI.HSSF.Record.CF
{
	// Token: 0x020004C9 RID: 1225
	public class PatternFormatting : global::System.ICloneable
	{
		// Token: 0x06002E4E RID: 11854 RVA: 0x00088B4B File Offset: 0x00086D4B
		public PatternFormatting()
		{
			this.field_15_pattern_style = 0;
			this.field_16_pattern_color_indexes = 0;
		}

		// Token: 0x06002E4F RID: 11855 RVA: 0x00088B61 File Offset: 0x00086D61
		public PatternFormatting(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_15_pattern_style = in1.ReadShort();
			this.field_16_pattern_color_indexes = in1.ReadShort();
		}

		// Token: 0x17000C2F RID: 3119
		// (get) Token: 0x06002E50 RID: 11856 RVA: 0x00018498 File Offset: 0x00016698
		public int DataLength
		{
			get
			{
				return 4;
			}
		}

		// Token: 0x17000C30 RID: 3120
		// (get) Token: 0x06002E51 RID: 11857 RVA: 0x00088B81 File Offset: 0x00086D81
		// (set) Token: 0x06002E52 RID: 11858 RVA: 0x00088B93 File Offset: 0x00086D93
		public global::NPOI.SS.UserModel.FillPattern FillPattern
		{
			get
			{
				return (global::NPOI.SS.UserModel.FillPattern)global::NPOI.HSSF.Record.CF.PatternFormatting.FillPatternStyle.GetShortValue(this.field_15_pattern_style);
			}
			set
			{
				this.field_15_pattern_style = global::NPOI.HSSF.Record.CF.PatternFormatting.FillPatternStyle.SetShortValue(this.field_15_pattern_style, (short)value);
			}
		}

		// Token: 0x17000C31 RID: 3121
		// (get) Token: 0x06002E53 RID: 11859 RVA: 0x00088BAC File Offset: 0x00086DAC
		// (set) Token: 0x06002E54 RID: 11860 RVA: 0x00088BBE File Offset: 0x00086DBE
		public short FillBackgroundColor
		{
			get
			{
				return global::NPOI.HSSF.Record.CF.PatternFormatting.patternBackgroundColorIndex.GetShortValue(this.field_16_pattern_color_indexes);
			}
			set
			{
				this.field_16_pattern_color_indexes = global::NPOI.HSSF.Record.CF.PatternFormatting.patternBackgroundColorIndex.SetShortValue(this.field_16_pattern_color_indexes, value);
			}
		}

		// Token: 0x17000C32 RID: 3122
		// (get) Token: 0x06002E55 RID: 11861 RVA: 0x00088BD7 File Offset: 0x00086DD7
		// (set) Token: 0x06002E56 RID: 11862 RVA: 0x00088BE9 File Offset: 0x00086DE9
		public short FillForegroundColor
		{
			get
			{
				return global::NPOI.HSSF.Record.CF.PatternFormatting.patternColorIndex.GetShortValue(this.field_16_pattern_color_indexes);
			}
			set
			{
				this.field_16_pattern_color_indexes = global::NPOI.HSSF.Record.CF.PatternFormatting.patternColorIndex.SetShortValue(this.field_16_pattern_color_indexes, value);
			}
		}

		// Token: 0x06002E57 RID: 11863 RVA: 0x00088C04 File Offset: 0x00086E04
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("    [Pattern Formatting]\n");
			stringBuilder.Append("          .Fillpattern= ").Append(global::NPOI.Util.StringUtil.ToHexString((int)this.FillPattern)).Append("\n");
			stringBuilder.Append("          .fgcoloridx= ").Append(global::NPOI.Util.StringUtil.ToHexString(this.FillForegroundColor)).Append("\n");
			stringBuilder.Append("          .bgcoloridx= ").Append(global::NPOI.Util.StringUtil.ToHexString(this.FillBackgroundColor)).Append("\n");
			stringBuilder.Append("    [/Pattern Formatting]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002E58 RID: 11864 RVA: 0x00088CA5 File Offset: 0x00086EA5
		public object Clone()
		{
			return new global::NPOI.HSSF.Record.CF.PatternFormatting
			{
				field_15_pattern_style = this.field_15_pattern_style,
				field_16_pattern_color_indexes = this.field_16_pattern_color_indexes
			};
		}

		// Token: 0x06002E59 RID: 11865 RVA: 0x00088CC4 File Offset: 0x00086EC4
		public int Serialize(int offset, byte[] data)
		{
			global::NPOI.Util.LittleEndian.PutShort(data, offset, this.field_15_pattern_style);
			offset += 2;
			global::NPOI.Util.LittleEndian.PutShort(data, offset, this.field_16_pattern_color_indexes);
			offset += 2;
			return 4;
		}

		// Token: 0x06002E5A RID: 11866 RVA: 0x00088CEB File Offset: 0x00086EEB
		public void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this.field_15_pattern_style);
			out1.WriteShort((int)this.field_16_pattern_color_indexes);
		}

		// Token: 0x04001451 RID: 5201
		private short field_15_pattern_style;

		// Token: 0x04001452 RID: 5202
		private static global::NPOI.Util.BitField FillPatternStyle = global::NPOI.Util.BitFieldFactory.GetInstance(64512);

		// Token: 0x04001453 RID: 5203
		private short field_16_pattern_color_indexes;

		// Token: 0x04001454 RID: 5204
		private static global::NPOI.Util.BitField patternColorIndex = global::NPOI.Util.BitFieldFactory.GetInstance(127);

		// Token: 0x04001455 RID: 5205
		private static global::NPOI.Util.BitField patternBackgroundColorIndex = global::NPOI.Util.BitFieldFactory.GetInstance(16256);
	}
}
