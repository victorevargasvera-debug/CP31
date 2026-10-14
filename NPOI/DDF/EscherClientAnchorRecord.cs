using System;
using System.Text;
using NPOI.Util;

namespace NPOI.DDF
{
	// Token: 0x02000536 RID: 1334
	public class EscherClientAnchorRecord : global::NPOI.DDF.EscherRecord
	{
		// Token: 0x0600322B RID: 12843 RVA: 0x000986D4 File Offset: 0x000968D4
		public override int FillFields(byte[] data, int offset, global::NPOI.DDF.IEscherRecordFactory recordFactory)
		{
			int num = base.ReadHeader(data, offset);
			int num2 = offset + 8;
			int num3 = 0;
			if (num != 4)
			{
				this.field_1_flag = global::NPOI.Util.LittleEndian.GetShort(data, num2 + num3);
				num3 += 2;
				this.field_2_col1 = global::NPOI.Util.LittleEndian.GetShort(data, num2 + num3);
				num3 += 2;
				this.field_3_dx1 = global::NPOI.Util.LittleEndian.GetShort(data, num2 + num3);
				num3 += 2;
				this.field_4_row1 = global::NPOI.Util.LittleEndian.GetShort(data, num2 + num3);
				num3 += 2;
				if (num >= 18)
				{
					this.field_5_dy1 = global::NPOI.Util.LittleEndian.GetShort(data, num2 + num3);
					num3 += 2;
					this.field_6_col2 = global::NPOI.Util.LittleEndian.GetShort(data, num2 + num3);
					num3 += 2;
					this.field_7_dx2 = global::NPOI.Util.LittleEndian.GetShort(data, num2 + num3);
					num3 += 2;
					this.field_8_row2 = global::NPOI.Util.LittleEndian.GetShort(data, num2 + num3);
					num3 += 2;
					this.field_9_dy2 = global::NPOI.Util.LittleEndian.GetShort(data, num2 + num3);
					num3 += 2;
					this.shortRecord = false;
				}
				else
				{
					this.shortRecord = true;
				}
			}
			num -= num3;
			this.remainingData = new byte[num];
			global::System.Array.Copy(data, num2 + num3, this.remainingData, 0, num);
			return 8 + num3 + num;
		}

		// Token: 0x0600322C RID: 12844 RVA: 0x000987E0 File Offset: 0x000969E0
		public override int Serialize(int offset, byte[] data, global::NPOI.DDF.EscherSerializationListener listener)
		{
			listener.BeforeRecordSerialize(offset, this.RecordId, this);
			if (this.remainingData == null)
			{
				this.remainingData = new byte[0];
			}
			global::NPOI.Util.LittleEndian.PutShort(data, offset, this.Options);
			global::NPOI.Util.LittleEndian.PutShort(data, offset + 2, this.RecordId);
			int value = this.remainingData.Length + (this.shortRecord ? 8 : 18);
			global::NPOI.Util.LittleEndian.PutInt(data, offset + 4, value);
			global::NPOI.Util.LittleEndian.PutShort(data, offset + 8, this.field_1_flag);
			global::NPOI.Util.LittleEndian.PutShort(data, offset + 10, this.field_2_col1);
			global::NPOI.Util.LittleEndian.PutShort(data, offset + 12, this.field_3_dx1);
			global::NPOI.Util.LittleEndian.PutShort(data, offset + 14, this.field_4_row1);
			if (!this.shortRecord)
			{
				global::NPOI.Util.LittleEndian.PutShort(data, offset + 16, this.field_5_dy1);
				global::NPOI.Util.LittleEndian.PutShort(data, offset + 18, this.field_6_col2);
				global::NPOI.Util.LittleEndian.PutShort(data, offset + 20, this.field_7_dx2);
				global::NPOI.Util.LittleEndian.PutShort(data, offset + 22, this.field_8_row2);
				global::NPOI.Util.LittleEndian.PutShort(data, offset + 24, this.field_9_dy2);
			}
			global::System.Array.Copy(this.remainingData, 0, data, offset + (this.shortRecord ? 16 : 26), this.remainingData.Length);
			int num = offset + 8 + (this.shortRecord ? 8 : 18) + this.remainingData.Length;
			listener.AfterRecordSerialize(num, this.RecordId, num - offset, this);
			return num - offset;
		}

		// Token: 0x17000D18 RID: 3352
		// (get) Token: 0x0600322D RID: 12845 RVA: 0x00098937 File Offset: 0x00096B37
		public override int RecordSize
		{
			get
			{
				return 8 + (this.shortRecord ? 8 : 18) + ((this.remainingData == null) ? 0 : this.remainingData.Length);
			}
		}

		// Token: 0x17000D19 RID: 3353
		// (get) Token: 0x0600322E RID: 12846 RVA: 0x0009895C File Offset: 0x00096B5C
		public override short RecordId
		{
			get
			{
				return -4080;
			}
		}

		// Token: 0x17000D1A RID: 3354
		// (get) Token: 0x0600322F RID: 12847 RVA: 0x00098963 File Offset: 0x00096B63
		public override string RecordName
		{
			get
			{
				return "ClientAnchor";
			}
		}

		// Token: 0x06003230 RID: 12848 RVA: 0x0009896C File Offset: 0x00096B6C
		public override string ToString()
		{
			string newLine = global::System.Environment.NewLine;
			string text = global::NPOI.Util.HexDump.Dump(this.remainingData, 0L, 0);
			return string.Concat(new string[]
			{
				base.GetType().Name,
				":",
				newLine,
				"  RecordId: 0x",
				global::NPOI.Util.HexDump.ToHex(-4080),
				newLine,
				"  Version: 0x",
				global::NPOI.Util.HexDump.ToHex(this.Version),
				newLine,
				"  Instance: 0x",
				global::NPOI.Util.HexDump.ToHex(this.Instance),
				newLine,
				"  Flag: ",
				this.field_1_flag.ToString(),
				newLine,
				"  Col1: ",
				this.field_2_col1.ToString(),
				newLine,
				"  DX1: ",
				this.field_3_dx1.ToString(),
				newLine,
				"  Row1: ",
				this.field_4_row1.ToString(),
				newLine,
				"  DY1: ",
				this.field_5_dy1.ToString(),
				newLine,
				"  Col2: ",
				this.field_6_col2.ToString(),
				newLine,
				"  DX2: ",
				this.field_7_dx2.ToString(),
				newLine,
				"  Row2: ",
				this.field_8_row2.ToString(),
				newLine,
				"  DY2: ",
				this.field_9_dy2.ToString(),
				newLine,
				"  Extra Data:",
				newLine,
				text
			});
		}

		// Token: 0x06003231 RID: 12849 RVA: 0x00098B1C File Offset: 0x00096D1C
		public override string ToXml(string tab)
		{
			string value = global::NPOI.Util.HexDump.Dump(this.remainingData, 0L, 0).Trim();
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(tab).Append(base.FormatXmlRecordHeader(base.GetType().Name, global::NPOI.Util.HexDump.ToHex(this.RecordId), global::NPOI.Util.HexDump.ToHex(this.Version), global::NPOI.Util.HexDump.ToHex(this.Instance))).Append(tab).Append("\t").Append("<Flag>").Append(this.field_1_flag).Append("</Flag>\n").Append(tab).Append("\t").Append("<Col1>").Append(this.field_2_col1).Append("</Col1>\n").Append(tab).Append("\t").Append("<DX1>").Append(this.field_3_dx1).Append("</DX1>\n").Append(tab).Append("\t").Append("<Row1>").Append(this.field_4_row1).Append("</Row1>\n").Append(tab).Append("\t").Append("<DY1>").Append(this.field_5_dy1).Append("</DY1>\n").Append(tab).Append("\t").Append("<Col2>").Append(this.field_6_col2).Append("</Col2>\n").Append(tab).Append("\t").Append("<DX2>").Append(this.field_7_dx2).Append("</DX2>\n").Append(tab).Append("\t").Append("<Row2>").Append(this.field_8_row2).Append("</Row2>\n").Append(tab).Append("\t").Append("<DY2>").Append(this.field_9_dy2).Append("</DY2>\n").Append(tab).Append("\t").Append("<ExtraData>").Append(value).Append("</ExtraData>\n");
			stringBuilder.Append(tab).Append("</").Append(base.GetType().Name).Append(">\n");
			return stringBuilder.ToString();
		}

		// Token: 0x17000D1B RID: 3355
		// (get) Token: 0x06003232 RID: 12850 RVA: 0x00098D83 File Offset: 0x00096F83
		// (set) Token: 0x06003233 RID: 12851 RVA: 0x00098D8B File Offset: 0x00096F8B
		public short Flag
		{
			get
			{
				return this.field_1_flag;
			}
			set
			{
				this.field_1_flag = value;
			}
		}

		// Token: 0x17000D1C RID: 3356
		// (get) Token: 0x06003234 RID: 12852 RVA: 0x00098D94 File Offset: 0x00096F94
		// (set) Token: 0x06003235 RID: 12853 RVA: 0x00098D9C File Offset: 0x00096F9C
		public short Col1
		{
			get
			{
				return this.field_2_col1;
			}
			set
			{
				this.field_2_col1 = value;
			}
		}

		// Token: 0x17000D1D RID: 3357
		// (get) Token: 0x06003236 RID: 12854 RVA: 0x00098DA5 File Offset: 0x00096FA5
		// (set) Token: 0x06003237 RID: 12855 RVA: 0x00098DAD File Offset: 0x00096FAD
		public short Dx1
		{
			get
			{
				return this.field_3_dx1;
			}
			set
			{
				this.field_3_dx1 = value;
			}
		}

		// Token: 0x17000D1E RID: 3358
		// (get) Token: 0x06003238 RID: 12856 RVA: 0x00098DB6 File Offset: 0x00096FB6
		// (set) Token: 0x06003239 RID: 12857 RVA: 0x00098DBE File Offset: 0x00096FBE
		public short Row1
		{
			get
			{
				return this.field_4_row1;
			}
			set
			{
				this.field_4_row1 = value;
			}
		}

		// Token: 0x17000D1F RID: 3359
		// (get) Token: 0x0600323A RID: 12858 RVA: 0x00098DC7 File Offset: 0x00096FC7
		// (set) Token: 0x0600323B RID: 12859 RVA: 0x00098DCF File Offset: 0x00096FCF
		public short Dy1
		{
			get
			{
				return this.field_5_dy1;
			}
			set
			{
				this.shortRecord = false;
				this.field_5_dy1 = value;
			}
		}

		// Token: 0x17000D20 RID: 3360
		// (get) Token: 0x0600323C RID: 12860 RVA: 0x00098DDF File Offset: 0x00096FDF
		// (set) Token: 0x0600323D RID: 12861 RVA: 0x00098DE7 File Offset: 0x00096FE7
		public short Col2
		{
			get
			{
				return this.field_6_col2;
			}
			set
			{
				this.shortRecord = false;
				this.field_6_col2 = value;
			}
		}

		// Token: 0x17000D21 RID: 3361
		// (get) Token: 0x0600323E RID: 12862 RVA: 0x00098DF7 File Offset: 0x00096FF7
		// (set) Token: 0x0600323F RID: 12863 RVA: 0x00098DFF File Offset: 0x00096FFF
		public short Dx2
		{
			get
			{
				return this.field_7_dx2;
			}
			set
			{
				this.shortRecord = false;
				this.field_7_dx2 = value;
			}
		}

		// Token: 0x17000D22 RID: 3362
		// (get) Token: 0x06003240 RID: 12864 RVA: 0x00098E0F File Offset: 0x0009700F
		// (set) Token: 0x06003241 RID: 12865 RVA: 0x00098E17 File Offset: 0x00097017
		public short Row2
		{
			get
			{
				return this.field_8_row2;
			}
			set
			{
				this.shortRecord = false;
				this.field_8_row2 = value;
			}
		}

		// Token: 0x17000D23 RID: 3363
		// (get) Token: 0x06003242 RID: 12866 RVA: 0x00098E27 File Offset: 0x00097027
		// (set) Token: 0x06003243 RID: 12867 RVA: 0x00098E2F File Offset: 0x0009702F
		public short Dy2
		{
			get
			{
				return this.field_9_dy2;
			}
			set
			{
				this.field_9_dy2 = value;
			}
		}

		// Token: 0x17000D24 RID: 3364
		// (get) Token: 0x06003244 RID: 12868 RVA: 0x00098E38 File Offset: 0x00097038
		// (set) Token: 0x06003245 RID: 12869 RVA: 0x00098E40 File Offset: 0x00097040
		public byte[] RemainingData
		{
			get
			{
				return this.remainingData;
			}
			set
			{
				if (value == null)
				{
					this.remainingData = new byte[0];
					return;
				}
				this.remainingData = new byte[value.Length];
				if (value.Length != 0)
				{
					global::System.Array.Copy(value, this.remainingData, value.Length);
				}
			}
		}

		// Token: 0x04001669 RID: 5737
		public const short RECORD_ID = -4080;

		// Token: 0x0400166A RID: 5738
		public const string RECORD_DESCRIPTION = "MsofbtClientAnchor";

		// Token: 0x0400166B RID: 5739
		private short field_1_flag;

		// Token: 0x0400166C RID: 5740
		private short field_2_col1;

		// Token: 0x0400166D RID: 5741
		private short field_3_dx1;

		// Token: 0x0400166E RID: 5742
		private short field_4_row1;

		// Token: 0x0400166F RID: 5743
		private short field_5_dy1;

		// Token: 0x04001670 RID: 5744
		private short field_6_col2;

		// Token: 0x04001671 RID: 5745
		private short field_7_dx2;

		// Token: 0x04001672 RID: 5746
		private short field_8_row2;

		// Token: 0x04001673 RID: 5747
		private short field_9_dy2;

		// Token: 0x04001674 RID: 5748
		private byte[] remainingData = new byte[0];

		// Token: 0x04001675 RID: 5749
		private bool shortRecord;
	}
}
