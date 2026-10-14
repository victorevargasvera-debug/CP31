using System;
using System.Text;
using NPOI.Util;

namespace NPOI.DDF
{
	// Token: 0x0200054C RID: 1356
	public class EscherSpRecord : global::NPOI.DDF.EscherRecord
	{
		// Token: 0x06003338 RID: 13112 RVA: 0x000A00C0 File Offset: 0x0009E2C0
		public override int FillFields(byte[] data, int offset, global::NPOI.DDF.IEscherRecordFactory recordFactory)
		{
			base.ReadHeader(data, offset);
			int num = offset + 8;
			int num2 = 0;
			this.field_1_shapeId = global::NPOI.Util.LittleEndian.GetInt(data, num + num2);
			num2 += 4;
			this.field_2_flags = global::NPOI.Util.LittleEndian.GetInt(data, num + num2);
			num2 += 4;
			return this.RecordSize;
		}

		// Token: 0x06003339 RID: 13113 RVA: 0x000A0108 File Offset: 0x0009E308
		public override int Serialize(int offset, byte[] data, global::NPOI.DDF.EscherSerializationListener listener)
		{
			listener.BeforeRecordSerialize(offset, this.RecordId, this);
			global::NPOI.Util.LittleEndian.PutShort(data, offset, this.Options);
			global::NPOI.Util.LittleEndian.PutShort(data, offset + 2, this.RecordId);
			int value = 8;
			global::NPOI.Util.LittleEndian.PutInt(data, offset + 4, value);
			global::NPOI.Util.LittleEndian.PutInt(data, offset + 8, this.field_1_shapeId);
			global::NPOI.Util.LittleEndian.PutInt(data, offset + 12, this.field_2_flags);
			listener.AfterRecordSerialize(offset + this.RecordSize, this.RecordId, this.RecordSize, this);
			return 16;
		}

		// Token: 0x17000D77 RID: 3447
		// (get) Token: 0x0600333A RID: 13114 RVA: 0x0002C0F8 File Offset: 0x0002A2F8
		public override int RecordSize
		{
			get
			{
				return 16;
			}
		}

		// Token: 0x17000D78 RID: 3448
		// (get) Token: 0x0600333B RID: 13115 RVA: 0x000A0187 File Offset: 0x0009E387
		public override short RecordId
		{
			get
			{
				return -4086;
			}
		}

		// Token: 0x17000D79 RID: 3449
		// (get) Token: 0x0600333C RID: 13116 RVA: 0x000A018E File Offset: 0x0009E38E
		public override string RecordName
		{
			get
			{
				return "Sp";
			}
		}

		// Token: 0x0600333D RID: 13117 RVA: 0x000A0198 File Offset: 0x0009E398
		public override string ToString()
		{
			string newLine = global::System.Environment.NewLine;
			return string.Concat(new string[]
			{
				base.GetType().Name,
				":",
				newLine,
				"  RecordId: 0x",
				global::NPOI.Util.HexDump.ToHex(-4086),
				newLine,
				"  Version: 0x",
				global::NPOI.Util.HexDump.ToHex(this.Version),
				newLine,
				"  ShapeType: 0x",
				global::NPOI.Util.HexDump.ToHex(this.ShapeType),
				newLine,
				"  ShapeId: ",
				this.field_1_shapeId.ToString(),
				newLine,
				"  Flags: ",
				this.DecodeFlags(this.field_2_flags),
				" (0x",
				global::NPOI.Util.HexDump.ToHex(this.field_2_flags),
				")",
				newLine
			});
		}

		// Token: 0x0600333E RID: 13118 RVA: 0x000A0280 File Offset: 0x0009E480
		public override string ToXml(string tab)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(tab).Append(base.FormatXmlRecordHeader(base.GetType().Name, global::NPOI.Util.HexDump.ToHex(this.RecordId), global::NPOI.Util.HexDump.ToHex(this.Version), global::NPOI.Util.HexDump.ToHex(this.Instance))).Append(tab).Append("\t").Append("<ShapeType>0x").Append(global::NPOI.Util.HexDump.ToHex(this.ShapeType)).Append("</ShapeType>\n").Append(tab).Append("\t").Append("<ShapeId>").Append(this.field_1_shapeId).Append("</ShapeId>\n").Append(tab).Append("\t").Append("<Flags>").Append(this.DecodeFlags(this.field_2_flags) + " (0x" + global::NPOI.Util.HexDump.ToHex(this.field_2_flags) + ")").Append("</Flags>\n");
			stringBuilder.Append(tab).Append("</").Append(base.GetType().Name).Append(">\n");
			return stringBuilder.ToString();
		}

		// Token: 0x0600333F RID: 13119 RVA: 0x000A03B4 File Offset: 0x0009E5B4
		private string DecodeFlags(int flags)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(((flags & 1) != 0) ? "|GROUP" : "");
			stringBuilder.Append(((flags & 2) != 0) ? "|CHILD" : "");
			stringBuilder.Append(((flags & 4) != 0) ? "|PATRIARCH" : "");
			stringBuilder.Append(((flags & 8) != 0) ? "|DELETED" : "");
			stringBuilder.Append(((flags & 16) != 0) ? "|OLESHAPE" : "");
			stringBuilder.Append(((flags & 32) != 0) ? "|HAVEMASTER" : "");
			stringBuilder.Append(((flags & 64) != 0) ? "|FLIPHORIZ" : "");
			stringBuilder.Append(((flags & 128) != 0) ? "|FLIPVERT" : "");
			stringBuilder.Append(((flags & 256) != 0) ? "|CONNECTOR" : "");
			stringBuilder.Append(((flags & 512) != 0) ? "|HAVEANCHOR" : "");
			stringBuilder.Append(((flags & 1024) != 0) ? "|BACKGROUND" : "");
			stringBuilder.Append(((flags & 2048) != 0) ? "|HASSHAPETYPE" : "");
			if (stringBuilder.Length > 0)
			{
				stringBuilder.Remove(0, 1);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x17000D7A RID: 3450
		// (get) Token: 0x06003340 RID: 13120 RVA: 0x000A0516 File Offset: 0x0009E716
		// (set) Token: 0x06003341 RID: 13121 RVA: 0x000A051E File Offset: 0x0009E71E
		public int ShapeId
		{
			get
			{
				return this.field_1_shapeId;
			}
			set
			{
				this.field_1_shapeId = value;
			}
		}

		// Token: 0x17000D7B RID: 3451
		// (get) Token: 0x06003342 RID: 13122 RVA: 0x000A0527 File Offset: 0x0009E727
		// (set) Token: 0x06003343 RID: 13123 RVA: 0x000A052F File Offset: 0x0009E72F
		public int Flags
		{
			get
			{
				return this.field_2_flags;
			}
			set
			{
				this.field_2_flags = value;
			}
		}

		// Token: 0x17000D7C RID: 3452
		// (get) Token: 0x06003344 RID: 13124 RVA: 0x000A0538 File Offset: 0x0009E738
		// (set) Token: 0x06003345 RID: 13125 RVA: 0x000A0540 File Offset: 0x0009E740
		public short ShapeType
		{
			get
			{
				return this.Instance;
			}
			set
			{
				this.Instance = value;
			}
		}

		// Token: 0x04001804 RID: 6148
		public const short RECORD_ID = -4086;

		// Token: 0x04001805 RID: 6149
		public const string RECORD_DESCRIPTION = "MsofbtSp";

		// Token: 0x04001806 RID: 6150
		public const int FLAG_GROUP = 1;

		// Token: 0x04001807 RID: 6151
		public const int FLAG_CHILD = 2;

		// Token: 0x04001808 RID: 6152
		public const int FLAG_PATRIARCH = 4;

		// Token: 0x04001809 RID: 6153
		public const int FLAG_DELETED = 8;

		// Token: 0x0400180A RID: 6154
		public const int FLAG_OLESHAPE = 16;

		// Token: 0x0400180B RID: 6155
		public const int FLAG_HAVEMASTER = 32;

		// Token: 0x0400180C RID: 6156
		public const int FLAG_FLIPHORIZ = 64;

		// Token: 0x0400180D RID: 6157
		public const int FLAG_FLIPVERT = 128;

		// Token: 0x0400180E RID: 6158
		public const int FLAG_CONNECTOR = 256;

		// Token: 0x0400180F RID: 6159
		public const int FLAG_HAVEANCHOR = 512;

		// Token: 0x04001810 RID: 6160
		public const int FLAG_BACKGROUND = 1024;

		// Token: 0x04001811 RID: 6161
		public const int FLAG_HASSHAPETYPE = 2048;

		// Token: 0x04001812 RID: 6162
		private int field_1_shapeId;

		// Token: 0x04001813 RID: 6163
		private int field_2_flags;
	}
}
