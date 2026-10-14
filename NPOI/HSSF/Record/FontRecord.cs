using System;
using System.Text;
using NPOI.SS.UserModel;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003DE RID: 990
	public class FontRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x06002365 RID: 9061 RVA: 0x0005FE49 File Offset: 0x0005E049
		public FontRecord()
		{
		}

		// Token: 0x06002366 RID: 9062 RVA: 0x0006AFA4 File Offset: 0x000691A4
		public FontRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_font_height = in1.ReadShort();
			this.field_2_attributes = in1.ReadShort();
			this.field_3_color_palette_index = in1.ReadShort();
			this.field_4_bold_weight = in1.ReadShort();
			this.field_5_base_sub_script = in1.ReadShort();
			this.field_6_underline = (byte)in1.ReadByte();
			this.field_7_family = (byte)in1.ReadByte();
			this.field_8_charset = (byte)in1.ReadByte();
			this.field_9_zero = (byte)in1.ReadByte();
			int num = (int)((byte)in1.ReadByte());
			int num2 = in1.ReadUByte();
			if (num <= 0)
			{
				this.field_11_font_name = "";
				return;
			}
			if (num2 == 0)
			{
				this.field_11_font_name = in1.ReadCompressedUnicode(num);
				return;
			}
			this.field_11_font_name = in1.ReadUnicodeLEString(num);
		}

		// Token: 0x06002367 RID: 9063 RVA: 0x0006B064 File Offset: 0x00069264
		public void CloneStyleFrom(global::NPOI.HSSF.Record.FontRecord source)
		{
			this.field_1_font_height = source.field_1_font_height;
			this.field_2_attributes = source.field_2_attributes;
			this.field_3_color_palette_index = source.field_3_color_palette_index;
			this.field_4_bold_weight = source.field_4_bold_weight;
			this.field_5_base_sub_script = source.field_5_base_sub_script;
			this.field_6_underline = source.field_6_underline;
			this.field_7_family = source.field_7_family;
			this.field_8_charset = source.field_8_charset;
			this.field_9_zero = source.field_9_zero;
			this.field_11_font_name = source.field_11_font_name;
		}

		// Token: 0x17000822 RID: 2082
		// (get) Token: 0x06002369 RID: 9065 RVA: 0x0006B102 File Offset: 0x00069302
		// (set) Token: 0x06002368 RID: 9064 RVA: 0x0006B0E9 File Offset: 0x000692E9
		public bool IsItalic
		{
			get
			{
				return global::NPOI.HSSF.Record.FontRecord.italic.IsSet((int)this.field_2_attributes);
			}
			set
			{
				this.field_2_attributes = global::NPOI.HSSF.Record.FontRecord.italic.SetShortBoolean(this.field_2_attributes, value);
			}
		}

		// Token: 0x17000823 RID: 2083
		// (get) Token: 0x0600236B RID: 9067 RVA: 0x0006B12D File Offset: 0x0006932D
		// (set) Token: 0x0600236A RID: 9066 RVA: 0x0006B114 File Offset: 0x00069314
		public bool IsStrikeout
		{
			get
			{
				return global::NPOI.HSSF.Record.FontRecord.strikeout.IsSet((int)this.field_2_attributes);
			}
			set
			{
				this.field_2_attributes = global::NPOI.HSSF.Record.FontRecord.strikeout.SetShortBoolean(this.field_2_attributes, value);
			}
		}

		// Token: 0x17000824 RID: 2084
		// (get) Token: 0x0600236D RID: 9069 RVA: 0x0006B158 File Offset: 0x00069358
		// (set) Token: 0x0600236C RID: 9068 RVA: 0x0006B13F File Offset: 0x0006933F
		public bool IsMacoutlined
		{
			get
			{
				return global::NPOI.HSSF.Record.FontRecord.macoutline.IsSet((int)this.field_2_attributes);
			}
			set
			{
				this.field_2_attributes = global::NPOI.HSSF.Record.FontRecord.macoutline.SetShortBoolean(this.field_2_attributes, value);
			}
		}

		// Token: 0x17000825 RID: 2085
		// (get) Token: 0x0600236F RID: 9071 RVA: 0x0006B183 File Offset: 0x00069383
		// (set) Token: 0x0600236E RID: 9070 RVA: 0x0006B16A File Offset: 0x0006936A
		public bool IsMacshadowed
		{
			get
			{
				return global::NPOI.HSSF.Record.FontRecord.macshadow.IsSet((int)this.field_2_attributes);
			}
			set
			{
				this.field_2_attributes = global::NPOI.HSSF.Record.FontRecord.macshadow.SetShortBoolean(this.field_2_attributes, value);
			}
		}

		// Token: 0x17000826 RID: 2086
		// (get) Token: 0x06002370 RID: 9072 RVA: 0x0006B195 File Offset: 0x00069395
		// (set) Token: 0x06002371 RID: 9073 RVA: 0x0006B19D File Offset: 0x0006939D
		public global::NPOI.SS.UserModel.FontUnderlineType Underline
		{
			get
			{
				return (global::NPOI.SS.UserModel.FontUnderlineType)this.field_6_underline;
			}
			set
			{
				this.field_6_underline = (byte)value;
			}
		}

		// Token: 0x17000827 RID: 2087
		// (get) Token: 0x06002373 RID: 9075 RVA: 0x0006B1AF File Offset: 0x000693AF
		// (set) Token: 0x06002372 RID: 9074 RVA: 0x0006B1A6 File Offset: 0x000693A6
		public byte Family
		{
			get
			{
				return this.field_7_family;
			}
			set
			{
				this.field_7_family = value;
			}
		}

		// Token: 0x17000828 RID: 2088
		// (get) Token: 0x06002375 RID: 9077 RVA: 0x0006B1C0 File Offset: 0x000693C0
		// (set) Token: 0x06002374 RID: 9076 RVA: 0x0006B1B7 File Offset: 0x000693B7
		public byte Charset
		{
			get
			{
				return this.field_8_charset;
			}
			set
			{
				this.field_8_charset = value;
			}
		}

		// Token: 0x17000829 RID: 2089
		// (get) Token: 0x06002377 RID: 9079 RVA: 0x0006B1D1 File Offset: 0x000693D1
		// (set) Token: 0x06002376 RID: 9078 RVA: 0x0006B1C8 File Offset: 0x000693C8
		public string FontName
		{
			get
			{
				return this.field_11_font_name;
			}
			set
			{
				this.field_11_font_name = value;
			}
		}

		// Token: 0x1700082A RID: 2090
		// (get) Token: 0x06002378 RID: 9080 RVA: 0x0006B1D9 File Offset: 0x000693D9
		// (set) Token: 0x06002379 RID: 9081 RVA: 0x0006B1E1 File Offset: 0x000693E1
		public short FontHeight
		{
			get
			{
				return this.field_1_font_height;
			}
			set
			{
				this.field_1_font_height = value;
			}
		}

		// Token: 0x1700082B RID: 2091
		// (get) Token: 0x0600237A RID: 9082 RVA: 0x0006B1EA File Offset: 0x000693EA
		// (set) Token: 0x0600237B RID: 9083 RVA: 0x0006B1F2 File Offset: 0x000693F2
		public short Attributes
		{
			get
			{
				return this.field_2_attributes;
			}
			set
			{
				this.field_2_attributes = value;
			}
		}

		// Token: 0x1700082C RID: 2092
		// (get) Token: 0x0600237C RID: 9084 RVA: 0x0006B1FB File Offset: 0x000693FB
		// (set) Token: 0x0600237D RID: 9085 RVA: 0x0006B203 File Offset: 0x00069403
		public short ColorPaletteIndex
		{
			get
			{
				return this.field_3_color_palette_index;
			}
			set
			{
				this.field_3_color_palette_index = value;
			}
		}

		// Token: 0x1700082D RID: 2093
		// (get) Token: 0x0600237E RID: 9086 RVA: 0x0006B20C File Offset: 0x0006940C
		// (set) Token: 0x0600237F RID: 9087 RVA: 0x0006B214 File Offset: 0x00069414
		public short BoldWeight
		{
			get
			{
				return this.field_4_bold_weight;
			}
			set
			{
				this.field_4_bold_weight = value;
			}
		}

		// Token: 0x1700082E RID: 2094
		// (get) Token: 0x06002380 RID: 9088 RVA: 0x0006B21D File Offset: 0x0006941D
		// (set) Token: 0x06002381 RID: 9089 RVA: 0x0006B225 File Offset: 0x00069425
		public global::NPOI.SS.UserModel.FontSuperScript SuperSubScript
		{
			get
			{
				return (global::NPOI.SS.UserModel.FontSuperScript)this.field_5_base_sub_script;
			}
			set
			{
				this.field_5_base_sub_script = (short)value;
			}
		}

		// Token: 0x06002382 RID: 9090 RVA: 0x0006B230 File Offset: 0x00069430
		public bool SameProperties(global::NPOI.HSSF.Record.FontRecord other)
		{
			return this.field_1_font_height == other.field_1_font_height && this.field_2_attributes == other.field_2_attributes && this.field_3_color_palette_index == other.field_3_color_palette_index && this.field_4_bold_weight == other.field_4_bold_weight && this.field_5_base_sub_script == other.field_5_base_sub_script && this.field_6_underline == other.field_6_underline && this.field_7_family == other.field_7_family && this.field_8_charset == other.field_8_charset && this.field_9_zero == other.field_9_zero && this.field_11_font_name.Equals(other.field_11_font_name);
		}

		// Token: 0x06002383 RID: 9091 RVA: 0x0006B2D4 File Offset: 0x000694D4
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[FONT]\n");
			stringBuilder.Append("    .fontheight      = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.FontHeight)).Append("\n");
			stringBuilder.Append("    .attributes      = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.Attributes)).Append("\n");
			stringBuilder.Append("         .italic     = ").Append(this.IsItalic).Append("\n");
			stringBuilder.Append("         .strikout   = ").Append(this.IsStrikeout).Append("\n");
			stringBuilder.Append("         .macoutlined= ").Append(this.IsMacoutlined).Append("\n");
			stringBuilder.Append("         .macshadowed= ").Append(this.IsMacshadowed).Append("\n");
			stringBuilder.Append("    .colorpalette    = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.ColorPaletteIndex)).Append("\n");
			stringBuilder.Append("    .boldweight      = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.BoldWeight)).Append("\n");
			stringBuilder.Append("    .basesubscript  = ").Append(global::NPOI.Util.StringUtil.ToHexString((short)this.SuperSubScript)).Append("\n");
			stringBuilder.Append("    .underline       = ").Append(global::NPOI.Util.StringUtil.ToHexString((short)this.Underline)).Append("\n");
			stringBuilder.Append("    .family          = ").Append(global::NPOI.Util.StringUtil.ToHexString((short)this.Family)).Append("\n");
			stringBuilder.Append("    .charset         = ").Append(global::NPOI.Util.StringUtil.ToHexString((short)this.Charset)).Append("\n");
			stringBuilder.Append("    .fontname        = ").Append(this.FontName).Append("\n");
			stringBuilder.Append("[/FONT]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002384 RID: 9092 RVA: 0x0006B4D8 File Offset: 0x000696D8
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this.FontHeight);
			out1.WriteShort((int)this.Attributes);
			out1.WriteShort((int)this.ColorPaletteIndex);
			out1.WriteShort((int)this.BoldWeight);
			out1.WriteShort((int)this.SuperSubScript);
			out1.WriteByte((int)this.Underline);
			out1.WriteByte((int)this.Family);
			out1.WriteByte((int)this.Charset);
			out1.WriteByte((int)this.field_9_zero);
			int length = this.field_11_font_name.Length;
			out1.WriteByte(length);
			bool flag = global::NPOI.Util.StringUtil.HasMultibyte(this.field_11_font_name);
			out1.WriteByte(flag ? 1 : 0);
			if (length > 0)
			{
				if (flag)
				{
					global::NPOI.Util.StringUtil.PutUnicodeLE(this.field_11_font_name, out1);
					return;
				}
				global::NPOI.Util.StringUtil.PutCompressedUnicode(this.field_11_font_name, out1);
			}
		}

		// Token: 0x1700082F RID: 2095
		// (get) Token: 0x06002385 RID: 9093 RVA: 0x0006B5A0 File Offset: 0x000697A0
		protected override int DataSize
		{
			get
			{
				int num = 16;
				int length = this.field_11_font_name.Length;
				if (length < 1)
				{
					return num;
				}
				bool flag = global::NPOI.Util.StringUtil.HasMultibyte(this.field_11_font_name);
				return num + length * (flag ? 2 : 1);
			}
		}

		// Token: 0x17000830 RID: 2096
		// (get) Token: 0x06002386 RID: 9094 RVA: 0x0006B5D9 File Offset: 0x000697D9
		public override short Sid
		{
			get
			{
				return 49;
			}
		}

		// Token: 0x06002387 RID: 9095 RVA: 0x0006B5E0 File Offset: 0x000697E0
		public override int GetHashCode()
		{
			int num = 31;
			int num2 = 1;
			num2 = num * num2 + ((this.field_11_font_name == null) ? 0 : this.field_11_font_name.GetHashCode());
			num2 = num * num2 + (int)this.field_1_font_height;
			num2 = num * num2 + (int)this.field_2_attributes;
			num2 = num * num2 + (int)this.field_3_color_palette_index;
			num2 = num * num2 + (int)this.field_4_bold_weight;
			num2 = num * num2 + (int)this.field_5_base_sub_script;
			num2 = num * num2 + (int)this.field_6_underline;
			num2 = num * num2 + (int)this.field_7_family;
			num2 = num * num2 + (int)this.field_8_charset;
			return num * num2 + (int)this.field_9_zero;
		}

		// Token: 0x06002388 RID: 9096 RVA: 0x0006B66F File Offset: 0x0006986F
		public override bool Equals(object obj)
		{
			return this == obj;
		}

		// Token: 0x04000EE7 RID: 3815
		public const short sid = 49;

		// Token: 0x04000EE8 RID: 3816
		private short field_1_font_height;

		// Token: 0x04000EE9 RID: 3817
		private short field_2_attributes;

		// Token: 0x04000EEA RID: 3818
		private static global::NPOI.Util.BitField italic = global::NPOI.Util.BitFieldFactory.GetInstance(2);

		// Token: 0x04000EEB RID: 3819
		private static global::NPOI.Util.BitField strikeout = global::NPOI.Util.BitFieldFactory.GetInstance(8);

		// Token: 0x04000EEC RID: 3820
		private static global::NPOI.Util.BitField macoutline = global::NPOI.Util.BitFieldFactory.GetInstance(16);

		// Token: 0x04000EED RID: 3821
		private static global::NPOI.Util.BitField macshadow = global::NPOI.Util.BitFieldFactory.GetInstance(32);

		// Token: 0x04000EEE RID: 3822
		private short field_3_color_palette_index;

		// Token: 0x04000EEF RID: 3823
		private short field_4_bold_weight;

		// Token: 0x04000EF0 RID: 3824
		private short field_5_base_sub_script;

		// Token: 0x04000EF1 RID: 3825
		private byte field_6_underline;

		// Token: 0x04000EF2 RID: 3826
		private byte field_7_family;

		// Token: 0x04000EF3 RID: 3827
		private byte field_8_charset;

		// Token: 0x04000EF4 RID: 3828
		private byte field_9_zero;

		// Token: 0x04000EF5 RID: 3829
		private string field_11_font_name;
	}
}
