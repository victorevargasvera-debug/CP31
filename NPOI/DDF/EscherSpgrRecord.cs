using System;
using System.Text;
using NPOI.Util;

namespace NPOI.DDF
{
	// Token: 0x0200054A RID: 1354
	public class EscherSpgrRecord : global::NPOI.DDF.EscherRecord
	{
		// Token: 0x06003318 RID: 13080 RVA: 0x0009F918 File Offset: 0x0009DB18
		public override int FillFields(byte[] data, int offset, global::NPOI.DDF.IEscherRecordFactory recordFactory)
		{
			int num = base.ReadHeader(data, offset);
			int num2 = offset + 8;
			int num3 = 0;
			this.field_1_rectX1 = global::NPOI.Util.LittleEndian.GetInt(data, num2 + num3);
			num3 += 4;
			this.field_2_rectY1 = global::NPOI.Util.LittleEndian.GetInt(data, num2 + num3);
			num3 += 4;
			this.field_3_rectX2 = global::NPOI.Util.LittleEndian.GetInt(data, num2 + num3);
			num3 += 4;
			this.field_4_rectY2 = global::NPOI.Util.LittleEndian.GetInt(data, num2 + num3);
			num3 += 4;
			num -= num3;
			if (num != 0)
			{
				throw new global::NPOI.Util.RecordFormatException("Expected no remaining bytes but got " + num.ToString());
			}
			return 8 + num3 + num;
		}

		// Token: 0x06003319 RID: 13081 RVA: 0x0009F9A4 File Offset: 0x0009DBA4
		public override int Serialize(int offset, byte[] data, global::NPOI.DDF.EscherSerializationListener listener)
		{
			listener.BeforeRecordSerialize(offset, this.RecordId, this);
			global::NPOI.Util.LittleEndian.PutShort(data, offset, this.Options);
			global::NPOI.Util.LittleEndian.PutShort(data, offset + 2, this.RecordId);
			int value = 16;
			global::NPOI.Util.LittleEndian.PutInt(data, offset + 4, value);
			global::NPOI.Util.LittleEndian.PutInt(data, offset + 8, this.field_1_rectX1);
			global::NPOI.Util.LittleEndian.PutInt(data, offset + 12, this.field_2_rectY1);
			global::NPOI.Util.LittleEndian.PutInt(data, offset + 16, this.field_3_rectX2);
			global::NPOI.Util.LittleEndian.PutInt(data, offset + 20, this.field_4_rectY2);
			listener.AfterRecordSerialize(offset + this.RecordSize, this.RecordId, offset + this.RecordSize, this);
			return 24;
		}

		// Token: 0x17000D69 RID: 3433
		// (get) Token: 0x0600331A RID: 13082 RVA: 0x0006ECB3 File Offset: 0x0006CEB3
		public override int RecordSize
		{
			get
			{
				return 24;
			}
		}

		// Token: 0x17000D6A RID: 3434
		// (get) Token: 0x0600331B RID: 13083 RVA: 0x0009FA46 File Offset: 0x0009DC46
		public override short RecordId
		{
			get
			{
				return -4087;
			}
		}

		// Token: 0x17000D6B RID: 3435
		// (get) Token: 0x0600331C RID: 13084 RVA: 0x0009FA4D File Offset: 0x0009DC4D
		public override string RecordName
		{
			get
			{
				return "Spgr";
			}
		}

		// Token: 0x0600331D RID: 13085 RVA: 0x0009FA54 File Offset: 0x0009DC54
		public override string ToString()
		{
			string newLine = global::System.Environment.NewLine;
			return string.Concat(new string[]
			{
				base.GetType().Name,
				":",
				newLine,
				"  RecordId: 0x",
				global::NPOI.Util.HexDump.ToHex(-4087),
				newLine,
				"  Version: 0x",
				global::NPOI.Util.HexDump.ToHex(this.Version),
				newLine,
				"  Instance: 0x",
				global::NPOI.Util.HexDump.ToHex(this.Instance),
				newLine,
				"  RectX: ",
				this.field_1_rectX1.ToString(),
				newLine,
				"  RectY: ",
				this.field_2_rectY1.ToString(),
				newLine,
				"  RectWidth: ",
				this.field_3_rectX2.ToString(),
				newLine,
				"  RectHeight: ",
				this.field_4_rectY2.ToString(),
				newLine
			});
		}

		// Token: 0x0600331E RID: 13086 RVA: 0x0009FB54 File Offset: 0x0009DD54
		public override string ToXml(string tab)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(tab).Append(base.FormatXmlRecordHeader(base.GetType().Name, global::NPOI.Util.HexDump.ToHex(this.RecordId), global::NPOI.Util.HexDump.ToHex(this.Version), global::NPOI.Util.HexDump.ToHex(this.Instance))).Append(tab).Append("\t").Append("<RectX>").Append(this.field_1_rectX1).Append("</RectX>\n").Append(tab).Append("\t").Append("<RectY>").Append(this.field_2_rectY1).Append("</RectY>\n").Append(tab).Append("\t").Append("<RectWidth>").Append(this.field_3_rectX2).Append("</RectWidth>\n").Append(tab).Append("\t").Append("<RectHeight>").Append(this.field_4_rectY2).Append("</RectHeight>\n");
			stringBuilder.Append(tab).Append("</").Append(base.GetType().Name).Append(">\n");
			return stringBuilder.ToString();
		}

		// Token: 0x17000D6C RID: 3436
		// (get) Token: 0x0600331F RID: 13087 RVA: 0x0009FC92 File Offset: 0x0009DE92
		// (set) Token: 0x06003320 RID: 13088 RVA: 0x0009FC9A File Offset: 0x0009DE9A
		public int RectX1
		{
			get
			{
				return this.field_1_rectX1;
			}
			set
			{
				this.field_1_rectX1 = value;
			}
		}

		// Token: 0x17000D6D RID: 3437
		// (get) Token: 0x06003321 RID: 13089 RVA: 0x0009FCA3 File Offset: 0x0009DEA3
		// (set) Token: 0x06003322 RID: 13090 RVA: 0x0009FCAB File Offset: 0x0009DEAB
		public int RectX2
		{
			get
			{
				return this.field_3_rectX2;
			}
			set
			{
				this.field_3_rectX2 = value;
			}
		}

		// Token: 0x17000D6E RID: 3438
		// (get) Token: 0x06003323 RID: 13091 RVA: 0x0009FCB4 File Offset: 0x0009DEB4
		// (set) Token: 0x06003324 RID: 13092 RVA: 0x0009FCBC File Offset: 0x0009DEBC
		public int RectY1
		{
			get
			{
				return this.field_2_rectY1;
			}
			set
			{
				this.field_2_rectY1 = value;
			}
		}

		// Token: 0x17000D6F RID: 3439
		// (get) Token: 0x06003325 RID: 13093 RVA: 0x0009FCC5 File Offset: 0x0009DEC5
		// (set) Token: 0x06003326 RID: 13094 RVA: 0x0009FCCD File Offset: 0x0009DECD
		public int RectY2
		{
			get
			{
				return this.field_4_rectY2;
			}
			set
			{
				this.field_4_rectY2 = value;
			}
		}

		// Token: 0x040017F8 RID: 6136
		public const short RECORD_ID = -4087;

		// Token: 0x040017F9 RID: 6137
		public const string RECORD_DESCRIPTION = "MsofbtSpgr";

		// Token: 0x040017FA RID: 6138
		private int field_1_rectX1;

		// Token: 0x040017FB RID: 6139
		private int field_2_rectY1;

		// Token: 0x040017FC RID: 6140
		private int field_3_rectX2;

		// Token: 0x040017FD RID: 6141
		private int field_4_rectY2;
	}
}
