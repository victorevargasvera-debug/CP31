using System;
using System.Text;
using NPOI.Util;

namespace NPOI.DDF
{
	// Token: 0x02000531 RID: 1329
	public class EscherBitmapBlip : global::NPOI.DDF.EscherBlipRecord
	{
		// Token: 0x060031E2 RID: 12770 RVA: 0x00097214 File Offset: 0x00095414
		public override int FillFields(byte[] data, int offset, global::NPOI.DDF.IEscherRecordFactory recordFactory)
		{
			int num = base.ReadHeader(data, offset);
			int num2 = offset + 8;
			this.field_1_UID = new byte[16];
			global::System.Array.Copy(data, num2, this.field_1_UID, 0, 16);
			num2 += 16;
			this.field_2_marker = data[num2];
			num2++;
			this.field_pictureData = new byte[num - 17];
			global::System.Array.Copy(data, num2, this.field_pictureData, 0, this.field_pictureData.Length);
			return num + 8;
		}

		// Token: 0x060031E3 RID: 12771 RVA: 0x00097288 File Offset: 0x00095488
		public override int Serialize(int offset, byte[] data, global::NPOI.DDF.EscherSerializationListener listener)
		{
			listener.BeforeRecordSerialize(offset, this.RecordId, this);
			global::NPOI.Util.LittleEndian.PutShort(data, offset, this.Options);
			global::NPOI.Util.LittleEndian.PutShort(data, offset + 2, this.RecordId);
			global::NPOI.Util.LittleEndian.PutInt(data, offset + 4, this.RecordSize - 8);
			int num = offset + 8;
			global::System.Array.Copy(this.field_1_UID, 0, data, num, 16);
			data[num + 16] = this.field_2_marker;
			global::System.Array.Copy(this.field_pictureData, 0, data, num + 17, this.field_pictureData.Length);
			listener.AfterRecordSerialize(offset + this.RecordSize, this.RecordId, this.RecordSize, this);
			return 25 + this.field_pictureData.Length;
		}

		// Token: 0x17000CFA RID: 3322
		// (get) Token: 0x060031E4 RID: 12772 RVA: 0x0009732F File Offset: 0x0009552F
		public override int RecordSize
		{
			get
			{
				return 25 + this.field_pictureData.Length;
			}
		}

		// Token: 0x17000CFB RID: 3323
		// (get) Token: 0x060031E5 RID: 12773 RVA: 0x0009733C File Offset: 0x0009553C
		// (set) Token: 0x060031E6 RID: 12774 RVA: 0x00097344 File Offset: 0x00095544
		public byte[] UID
		{
			get
			{
				return this.field_1_UID;
			}
			set
			{
				if (value == null || value.Length != 16)
				{
					throw new global::System.ArgumentException("uid must be byte[16]");
				}
				global::System.Array.Copy(this.field_1_UID, 0, this.field_1_UID, 0, 16);
			}
		}

		// Token: 0x17000CFC RID: 3324
		// (get) Token: 0x060031E7 RID: 12775 RVA: 0x00097370 File Offset: 0x00095570
		// (set) Token: 0x060031E8 RID: 12776 RVA: 0x00097378 File Offset: 0x00095578
		public byte Marker
		{
			get
			{
				return this.field_2_marker;
			}
			set
			{
				this.field_2_marker = value;
			}
		}

		// Token: 0x060031E9 RID: 12777 RVA: 0x00097384 File Offset: 0x00095584
		public override string ToString()
		{
			string newLine = global::System.Environment.NewLine;
			string text = global::NPOI.Util.HexDump.Dump(this.field_pictureData, 0L, 0);
			return string.Concat(new string[]
			{
				base.GetType().Name,
				":",
				newLine,
				"  RecordId: 0x",
				global::NPOI.Util.HexDump.ToHex(this.RecordId),
				newLine,
				"  Version: 0x",
				global::NPOI.Util.HexDump.ToHex(this.Version),
				newLine,
				"  Instance: 0x",
				global::NPOI.Util.HexDump.ToHex(this.Instance),
				newLine,
				"  UID: 0x",
				global::NPOI.Util.HexDump.ToHex(this.field_1_UID),
				newLine,
				"  Marker: 0x",
				global::NPOI.Util.HexDump.ToHex(this.field_2_marker),
				newLine,
				"  Extra Data:",
				newLine,
				text
			});
		}

		// Token: 0x060031EA RID: 12778 RVA: 0x0009746C File Offset: 0x0009566C
		public override string ToXml(string tab)
		{
			string value = global::NPOI.Util.HexDump.ToHex(this.field_pictureData);
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(tab).Append(base.FormatXmlRecordHeader(base.GetType().Name, global::NPOI.Util.HexDump.ToHex(this.RecordId), global::NPOI.Util.HexDump.ToHex(this.Version), global::NPOI.Util.HexDump.ToHex(this.Instance))).Append(tab).Append("\t").Append("<UID>0x").Append(global::NPOI.Util.HexDump.ToHex(this.field_1_UID)).Append("</UID>\n").Append(tab).Append("\t").Append("<Marker>0x").Append(global::NPOI.Util.HexDump.ToHex(this.field_2_marker)).Append("</Marker>\n").Append(tab).Append("\t").Append("<ExtraData>").Append(value).Append("</ExtraData>\n");
			stringBuilder.Append(tab).Append("</").Append(base.GetType().Name).Append(">\n");
			return stringBuilder.ToString();
		}

		// Token: 0x04001641 RID: 5697
		public const short RECORD_ID_JPEG = -4067;

		// Token: 0x04001642 RID: 5698
		public const short RECORD_ID_PNG = -4066;

		// Token: 0x04001643 RID: 5699
		public const short RECORD_ID_DIB = -4065;

		// Token: 0x04001644 RID: 5700
		private const int HEADER_SIZE = 8;

		// Token: 0x04001645 RID: 5701
		private byte[] field_1_UID = new byte[16];

		// Token: 0x04001646 RID: 5702
		private byte field_2_marker = byte.MaxValue;
	}
}
