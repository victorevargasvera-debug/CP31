using System;
using System.Text;
using NPOI.Util;

namespace NPOI.DDF
{
	// Token: 0x0200054B RID: 1355
	public class EscherSplitMenuColorsRecord : global::NPOI.DDF.EscherRecord
	{
		// Token: 0x06003328 RID: 13096 RVA: 0x0009FCD8 File Offset: 0x0009DED8
		public override int FillFields(byte[] data, int offset, global::NPOI.DDF.IEscherRecordFactory recordFactory)
		{
			int num = base.ReadHeader(data, offset);
			int num2 = offset + 8;
			int num3 = 0;
			this.field_1_color1 = global::NPOI.Util.LittleEndian.GetInt(data, num2 + num3);
			num3 += 4;
			this.field_2_color2 = global::NPOI.Util.LittleEndian.GetInt(data, num2 + num3);
			num3 += 4;
			this.field_3_color3 = global::NPOI.Util.LittleEndian.GetInt(data, num2 + num3);
			num3 += 4;
			this.field_4_color4 = global::NPOI.Util.LittleEndian.GetInt(data, num2 + num3);
			num3 += 4;
			num -= num3;
			if (num != 0)
			{
				throw new global::NPOI.Util.RecordFormatException("Expecting no remaining data but got " + num.ToString() + " byte(s).");
			}
			return 8 + num3 + num;
		}

		// Token: 0x06003329 RID: 13097 RVA: 0x0009FD68 File Offset: 0x0009DF68
		public override int Serialize(int offset, byte[] data, global::NPOI.DDF.EscherSerializationListener listener)
		{
			listener.BeforeRecordSerialize(offset, this.RecordId, this);
			global::NPOI.Util.LittleEndian.PutShort(data, offset, this.Options);
			int num = offset + 2;
			global::NPOI.Util.LittleEndian.PutShort(data, num, this.RecordId);
			num += 2;
			int value = this.RecordSize - 8;
			global::NPOI.Util.LittleEndian.PutInt(data, num, value);
			num += 4;
			global::NPOI.Util.LittleEndian.PutInt(data, num, this.field_1_color1);
			num += 4;
			global::NPOI.Util.LittleEndian.PutInt(data, num, this.field_2_color2);
			num += 4;
			global::NPOI.Util.LittleEndian.PutInt(data, num, this.field_3_color3);
			num += 4;
			global::NPOI.Util.LittleEndian.PutInt(data, num, this.field_4_color4);
			num += 4;
			listener.AfterRecordSerialize(num, this.RecordId, num - offset, this);
			return this.RecordSize;
		}

		// Token: 0x17000D70 RID: 3440
		// (get) Token: 0x0600332A RID: 13098 RVA: 0x0006ECB3 File Offset: 0x0006CEB3
		public override int RecordSize
		{
			get
			{
				return 24;
			}
		}

		// Token: 0x17000D71 RID: 3441
		// (get) Token: 0x0600332B RID: 13099 RVA: 0x0009FE17 File Offset: 0x0009E017
		public override short RecordId
		{
			get
			{
				return -3810;
			}
		}

		// Token: 0x17000D72 RID: 3442
		// (get) Token: 0x0600332C RID: 13100 RVA: 0x0009FE1E File Offset: 0x0009E01E
		public override string RecordName
		{
			get
			{
				return "SplitMenuColors";
			}
		}

		// Token: 0x0600332D RID: 13101 RVA: 0x0009FE28 File Offset: 0x0009E028
		public override string ToString()
		{
			string newLine = global::System.Environment.NewLine;
			return string.Concat(new string[]
			{
				base.GetType().Name,
				":",
				newLine,
				"  RecordId: 0x",
				global::NPOI.Util.HexDump.ToHex(-3810),
				newLine,
				"  Version: 0x",
				global::NPOI.Util.HexDump.ToHex(this.Version),
				newLine,
				"  Instance: 0x",
				global::NPOI.Util.HexDump.ToHex(this.Instance),
				newLine,
				"  Color1: 0x",
				global::NPOI.Util.HexDump.ToHex(this.field_1_color1),
				newLine,
				"  Color2: 0x",
				global::NPOI.Util.HexDump.ToHex(this.field_2_color2),
				newLine,
				"  Color3: 0x",
				global::NPOI.Util.HexDump.ToHex(this.field_3_color3),
				newLine,
				"  Color4: 0x",
				global::NPOI.Util.HexDump.ToHex(this.field_4_color4),
				newLine
			});
		}

		// Token: 0x0600332E RID: 13102 RVA: 0x0009FF28 File Offset: 0x0009E128
		public override string ToXml(string tab)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(tab).Append(base.FormatXmlRecordHeader(base.GetType().Name, global::NPOI.Util.HexDump.ToHex(this.RecordId), global::NPOI.Util.HexDump.ToHex(this.Version), global::NPOI.Util.HexDump.ToHex(this.Instance))).Append(tab).Append("\t").Append("<Color1>0x").Append(global::NPOI.Util.HexDump.ToHex(this.field_1_color1)).Append("</Color1>\n").Append(tab).Append("\t").Append("<Color2>0x").Append(global::NPOI.Util.HexDump.ToHex(this.field_2_color2)).Append("</Color2>\n").Append(tab).Append("\t").Append("<Color3>0x").Append(global::NPOI.Util.HexDump.ToHex(this.field_3_color3)).Append("</Color3>\n").Append(tab).Append("\t").Append("<Color4>0x").Append(global::NPOI.Util.HexDump.ToHex(this.field_4_color4)).Append("</Color4>\n");
			stringBuilder.Append(tab).Append("</").Append(base.GetType().Name).Append(">\n");
			return stringBuilder.ToString();
		}

		// Token: 0x17000D73 RID: 3443
		// (get) Token: 0x0600332F RID: 13103 RVA: 0x000A007A File Offset: 0x0009E27A
		// (set) Token: 0x06003330 RID: 13104 RVA: 0x000A0082 File Offset: 0x0009E282
		public int Color1
		{
			get
			{
				return this.field_1_color1;
			}
			set
			{
				this.field_1_color1 = value;
			}
		}

		// Token: 0x17000D74 RID: 3444
		// (get) Token: 0x06003331 RID: 13105 RVA: 0x000A008B File Offset: 0x0009E28B
		// (set) Token: 0x06003332 RID: 13106 RVA: 0x000A0093 File Offset: 0x0009E293
		public int Color2
		{
			get
			{
				return this.field_2_color2;
			}
			set
			{
				this.field_2_color2 = value;
			}
		}

		// Token: 0x17000D75 RID: 3445
		// (get) Token: 0x06003333 RID: 13107 RVA: 0x000A009C File Offset: 0x0009E29C
		// (set) Token: 0x06003334 RID: 13108 RVA: 0x000A00A4 File Offset: 0x0009E2A4
		public int Color3
		{
			get
			{
				return this.field_3_color3;
			}
			set
			{
				this.field_3_color3 = value;
			}
		}

		// Token: 0x17000D76 RID: 3446
		// (get) Token: 0x06003335 RID: 13109 RVA: 0x000A00AD File Offset: 0x0009E2AD
		// (set) Token: 0x06003336 RID: 13110 RVA: 0x000A00B5 File Offset: 0x0009E2B5
		public int Color4
		{
			get
			{
				return this.field_4_color4;
			}
			set
			{
				this.field_4_color4 = value;
			}
		}

		// Token: 0x040017FE RID: 6142
		public const short RECORD_ID = -3810;

		// Token: 0x040017FF RID: 6143
		public const string RECORD_DESCRIPTION = "MsofbtSplitMenuColors";

		// Token: 0x04001800 RID: 6144
		private int field_1_color1;

		// Token: 0x04001801 RID: 6145
		private int field_2_color2;

		// Token: 0x04001802 RID: 6146
		private int field_3_color3;

		// Token: 0x04001803 RID: 6147
		private int field_4_color4;
	}
}
