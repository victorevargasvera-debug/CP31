using System;
using System.IO;
using System.Text;
using NPOI.Util;

namespace NPOI.DDF
{
	// Token: 0x02000534 RID: 1332
	public class EscherBSERecord : global::NPOI.DDF.EscherRecord
	{
		// Token: 0x060031F9 RID: 12793 RVA: 0x00097964 File Offset: 0x00095B64
		public override int FillFields(byte[] data, int offset, global::NPOI.DDF.IEscherRecordFactory recordFactory)
		{
			int num = base.ReadHeader(data, offset);
			int num2 = offset + 8;
			this.field_1_blipTypeWin32 = data[num2];
			this.field_2_blipTypeMacOS = data[num2 + 1];
			this.field_3_uid = new byte[16];
			global::System.Array.Copy(data, num2 + 2, this.field_3_uid, 0, 16);
			this.field_4_tag = global::NPOI.Util.LittleEndian.GetShort(data, num2 + 18);
			this.field_5_size = global::NPOI.Util.LittleEndian.GetInt(data, num2 + 20);
			this.field_6_ref = global::NPOI.Util.LittleEndian.GetInt(data, num2 + 24);
			this.field_7_offset = global::NPOI.Util.LittleEndian.GetInt(data, num2 + 28);
			this.field_8_usage = data[num2 + 32];
			this.field_9_name = data[num2 + 33];
			this.field_10_unused2 = data[num2 + 34];
			this.field_11_unused3 = data[num2 + 35];
			num -= 36;
			int num3 = 0;
			if (num > 0)
			{
				this.field_12_blipRecord = (global::NPOI.DDF.EscherBlipRecord)recordFactory.CreateRecord(data, num2 + 36);
				num3 = this.field_12_blipRecord.FillFields(data, num2 + 36, recordFactory);
			}
			num2 += 36 + num3;
			num -= num3;
			this._remainingData = new byte[num];
			global::System.Array.Copy(data, num2, this._remainingData, 0, num);
			return num + 8 + 36 + ((this.field_12_blipRecord == null) ? 0 : this.field_12_blipRecord.RecordSize);
		}

		// Token: 0x060031FA RID: 12794 RVA: 0x00097A98 File Offset: 0x00095C98
		public override int Serialize(int offset, byte[] data, global::NPOI.DDF.EscherSerializationListener listener)
		{
			listener.BeforeRecordSerialize(offset, this.RecordId, this);
			if (this._remainingData == null)
			{
				this._remainingData = new byte[0];
			}
			global::NPOI.Util.LittleEndian.PutShort(data, offset, this.Options);
			global::NPOI.Util.LittleEndian.PutShort(data, offset + 2, this.RecordId);
			int num = (this.field_12_blipRecord == null) ? 0 : this.field_12_blipRecord.RecordSize;
			int value = this._remainingData.Length + 36 + num;
			global::NPOI.Util.LittleEndian.PutInt(data, offset + 4, value);
			data[offset + 8] = this.field_1_blipTypeWin32;
			data[offset + 9] = this.field_2_blipTypeMacOS;
			for (int i = 0; i < 16; i++)
			{
				data[offset + 10 + i] = this.field_3_uid[i];
			}
			global::NPOI.Util.LittleEndian.PutShort(data, offset + 26, this.field_4_tag);
			global::NPOI.Util.LittleEndian.PutInt(data, offset + 28, this.field_5_size);
			global::NPOI.Util.LittleEndian.PutInt(data, offset + 32, this.field_6_ref);
			global::NPOI.Util.LittleEndian.PutInt(data, offset + 36, this.field_7_offset);
			data[offset + 40] = this.field_8_usage;
			data[offset + 41] = this.field_9_name;
			data[offset + 42] = this.field_10_unused2;
			data[offset + 43] = this.field_11_unused3;
			int num2 = 0;
			if (this.field_12_blipRecord != null)
			{
				num2 = this.field_12_blipRecord.Serialize(offset + 44, data);
			}
			global::System.Array.Copy(this._remainingData, 0, data, offset + 44 + num2, this._remainingData.Length);
			int num3 = offset + 8 + 36 + this._remainingData.Length + num2;
			listener.AfterRecordSerialize(num3, this.RecordId, num3 - offset, this);
			return num3 - offset;
		}

		// Token: 0x17000D02 RID: 3330
		// (get) Token: 0x060031FB RID: 12795 RVA: 0x00097C18 File Offset: 0x00095E18
		public override int RecordSize
		{
			get
			{
				int num = 0;
				if (this.field_12_blipRecord != null)
				{
					num = this.field_12_blipRecord.RecordSize;
				}
				int num2 = 0;
				if (this._remainingData != null)
				{
					num2 = this._remainingData.Length;
				}
				return 44 + num + num2;
			}
		}

		// Token: 0x17000D03 RID: 3331
		// (get) Token: 0x060031FC RID: 12796 RVA: 0x00097C54 File Offset: 0x00095E54
		public override string RecordName
		{
			get
			{
				return "BSE";
			}
		}

		// Token: 0x17000D04 RID: 3332
		// (get) Token: 0x060031FD RID: 12797 RVA: 0x00097C5B File Offset: 0x00095E5B
		// (set) Token: 0x060031FE RID: 12798 RVA: 0x00097C63 File Offset: 0x00095E63
		public byte BlipTypeWin32
		{
			get
			{
				return this.field_1_blipTypeWin32;
			}
			set
			{
				this.field_1_blipTypeWin32 = value;
			}
		}

		// Token: 0x17000D05 RID: 3333
		// (get) Token: 0x060031FF RID: 12799 RVA: 0x00097C6C File Offset: 0x00095E6C
		// (set) Token: 0x06003200 RID: 12800 RVA: 0x00097C74 File Offset: 0x00095E74
		public byte BlipTypeMacOS
		{
			get
			{
				return this.field_2_blipTypeMacOS;
			}
			set
			{
				this.field_2_blipTypeMacOS = value;
			}
		}

		// Token: 0x17000D06 RID: 3334
		// (get) Token: 0x06003201 RID: 12801 RVA: 0x00097C7D File Offset: 0x00095E7D
		// (set) Token: 0x06003202 RID: 12802 RVA: 0x00097C85 File Offset: 0x00095E85
		public byte[] UID
		{
			get
			{
				return this.field_3_uid;
			}
			set
			{
				if (value == null || value.Length != 16)
				{
					throw new global::System.ArgumentException("uid must be byte[16]");
				}
				global::System.Array.Copy(value, 0, this.field_3_uid, 0, this.field_3_uid.Length);
			}
		}

		// Token: 0x17000D07 RID: 3335
		// (get) Token: 0x06003203 RID: 12803 RVA: 0x00097CB2 File Offset: 0x00095EB2
		// (set) Token: 0x06003204 RID: 12804 RVA: 0x00097CBA File Offset: 0x00095EBA
		public short Tag
		{
			get
			{
				return this.field_4_tag;
			}
			set
			{
				this.field_4_tag = value;
			}
		}

		// Token: 0x17000D08 RID: 3336
		// (get) Token: 0x06003205 RID: 12805 RVA: 0x00097CC3 File Offset: 0x00095EC3
		// (set) Token: 0x06003206 RID: 12806 RVA: 0x00097CCB File Offset: 0x00095ECB
		public int Size
		{
			get
			{
				return this.field_5_size;
			}
			set
			{
				this.field_5_size = value;
			}
		}

		// Token: 0x17000D09 RID: 3337
		// (get) Token: 0x06003207 RID: 12807 RVA: 0x00097CD4 File Offset: 0x00095ED4
		// (set) Token: 0x06003208 RID: 12808 RVA: 0x00097CDC File Offset: 0x00095EDC
		public int Ref
		{
			get
			{
				return this.field_6_ref;
			}
			set
			{
				this.field_6_ref = value;
			}
		}

		// Token: 0x17000D0A RID: 3338
		// (get) Token: 0x06003209 RID: 12809 RVA: 0x00097CE5 File Offset: 0x00095EE5
		// (set) Token: 0x0600320A RID: 12810 RVA: 0x00097CED File Offset: 0x00095EED
		public int Offset
		{
			get
			{
				return this.field_7_offset;
			}
			set
			{
				this.field_7_offset = value;
			}
		}

		// Token: 0x17000D0B RID: 3339
		// (get) Token: 0x0600320B RID: 12811 RVA: 0x00097CF6 File Offset: 0x00095EF6
		// (set) Token: 0x0600320C RID: 12812 RVA: 0x00097CFE File Offset: 0x00095EFE
		public byte Usage
		{
			get
			{
				return this.field_8_usage;
			}
			set
			{
				this.field_8_usage = value;
			}
		}

		// Token: 0x17000D0C RID: 3340
		// (get) Token: 0x0600320D RID: 12813 RVA: 0x00097D07 File Offset: 0x00095F07
		// (set) Token: 0x0600320E RID: 12814 RVA: 0x00097D0F File Offset: 0x00095F0F
		public byte Name
		{
			get
			{
				return this.field_9_name;
			}
			set
			{
				this.field_9_name = value;
			}
		}

		// Token: 0x17000D0D RID: 3341
		// (get) Token: 0x0600320F RID: 12815 RVA: 0x00097D18 File Offset: 0x00095F18
		// (set) Token: 0x06003210 RID: 12816 RVA: 0x00097D20 File Offset: 0x00095F20
		public byte Unused2
		{
			get
			{
				return this.field_10_unused2;
			}
			set
			{
				this.field_10_unused2 = value;
			}
		}

		// Token: 0x17000D0E RID: 3342
		// (get) Token: 0x06003211 RID: 12817 RVA: 0x00097D29 File Offset: 0x00095F29
		// (set) Token: 0x06003212 RID: 12818 RVA: 0x00097D31 File Offset: 0x00095F31
		public byte Unused3
		{
			get
			{
				return this.field_11_unused3;
			}
			set
			{
				this.field_11_unused3 = value;
			}
		}

		// Token: 0x17000D0F RID: 3343
		// (get) Token: 0x06003213 RID: 12819 RVA: 0x00097D3A File Offset: 0x00095F3A
		// (set) Token: 0x06003214 RID: 12820 RVA: 0x00097D42 File Offset: 0x00095F42
		public global::NPOI.DDF.EscherBlipRecord BlipRecord
		{
			get
			{
				return this.field_12_blipRecord;
			}
			set
			{
				this.field_12_blipRecord = value;
			}
		}

		// Token: 0x17000D10 RID: 3344
		// (get) Token: 0x06003215 RID: 12821 RVA: 0x00097D4B File Offset: 0x00095F4B
		// (set) Token: 0x06003216 RID: 12822 RVA: 0x00097D53 File Offset: 0x00095F53
		public byte[] RemainingData
		{
			get
			{
				return this._remainingData;
			}
			set
			{
				if (value == null)
				{
					this._remainingData = new byte[0];
					return;
				}
				this._remainingData = new byte[value.Length];
				if (value.Length != 0)
				{
					global::System.Array.Copy(value, this._remainingData, value.Length);
				}
			}
		}

		// Token: 0x06003217 RID: 12823 RVA: 0x00097D88 File Offset: 0x00095F88
		public override string ToString()
		{
			string newLine = global::System.Environment.NewLine;
			string result;
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream())
			{
				string text;
				try
				{
					global::NPOI.Util.HexDump.Dump(this._remainingData, 0L, memoryStream, 0);
					text = global::System.Text.Encoding.UTF8.GetString(memoryStream.ToArray());
				}
				catch (global::System.Exception ex)
				{
					text = ex.ToString();
				}
				result = string.Concat(new string[]
				{
					base.GetType().Name,
					":",
					newLine,
					"  RecordId: 0x",
					global::NPOI.Util.HexDump.ToHex(-4089),
					newLine,
					"  Version: 0x",
					global::NPOI.Util.HexDump.ToHex(this.Version),
					"\n  Instance: 0x",
					global::NPOI.Util.HexDump.ToHex(this.Instance),
					"\n  BlipTypeWin32: ",
					this.field_1_blipTypeWin32.ToString(),
					newLine,
					"  BlipTypeMacOS: ",
					this.field_2_blipTypeMacOS.ToString(),
					newLine,
					"  SUID: ",
					global::NPOI.Util.HexDump.ToHex(this.field_3_uid),
					newLine,
					"  Tag: ",
					this.field_4_tag.ToString(),
					newLine,
					"  Size: ",
					this.field_5_size.ToString(),
					newLine,
					"  Ref: ",
					this.field_6_ref.ToString(),
					newLine,
					"  Offset: ",
					this.field_7_offset.ToString(),
					newLine,
					"  Usage: ",
					this.field_8_usage.ToString(),
					newLine,
					"  Name: ",
					this.field_9_name.ToString(),
					newLine,
					"  Unused2: ",
					this.field_10_unused2.ToString(),
					newLine,
					"  Unused3: ",
					this.field_11_unused3.ToString(),
					newLine,
					"  blipRecord: ",
					(this.field_12_blipRecord == null) ? "null" : this.field_12_blipRecord.ToString(),
					newLine,
					"  Extra Data:",
					newLine,
					text
				});
			}
			return result;
		}

		// Token: 0x06003218 RID: 12824 RVA: 0x00097FF8 File Offset: 0x000961F8
		public override string ToXml(string tab)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(tab).Append(base.FormatXmlRecordHeader(base.GetType().Name, global::NPOI.Util.HexDump.ToHex(this.RecordId), global::NPOI.Util.HexDump.ToHex(this.Version), global::NPOI.Util.HexDump.ToHex(this.Instance))).Append(tab).Append("\t").Append("<BlipTypeWin32>").Append(this.field_1_blipTypeWin32).Append("</BlipTypeWin32>\n").Append(tab).Append("\t").Append("<BlipTypeMacOS>").Append(this.field_2_blipTypeMacOS).Append("</BlipTypeMacOS>\n").Append(tab).Append("\t").Append("<SUID>").Append((this.field_3_uid == null) ? "" : global::NPOI.Util.HexDump.ToHex(this.field_3_uid)).Append("</SUID>\n").Append(tab).Append("\t").Append("<Tag>").Append(this.field_4_tag).Append("</Tag>\n").Append(tab).Append("\t").Append("<Size>").Append(this.field_5_size).Append("</Size>\n").Append(tab).Append("\t").Append("<Ref>").Append(this.field_6_ref).Append("</Ref>\n").Append(tab).Append("\t").Append("<Offset>").Append(this.field_7_offset).Append("</Offset>\n").Append(tab).Append("\t").Append("<Usage>").Append(this.field_8_usage).Append("</Usage>\n").Append(tab).Append("\t").Append("<Name>").Append(this.field_9_name).Append("</Name>\n").Append(tab).Append("\t").Append("<Unused2>").Append(this.field_10_unused2).Append("</Unused2>\n").Append(tab).Append("\t").Append("<Unused3>").Append(this.field_11_unused3).Append("</Unused3>\n");
			stringBuilder.Append(tab).Append("</").Append(base.GetType().Name).Append(">\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06003219 RID: 12825 RVA: 0x00098294 File Offset: 0x00096494
		public string GetBlipType(byte b)
		{
			switch (b)
			{
			case 0:
				return " ERROR";
			case 1:
				return " UNKNOWN";
			case 2:
				return " EMF";
			case 3:
				return " WMF";
			case 4:
				return " PICT";
			case 5:
				return " JPEG";
			case 6:
				return " PNG";
			case 7:
				return " DIB";
			default:
				if (b < 32)
				{
					return " NotKnown";
				}
				return " Client";
			}
		}

		// Token: 0x0400164C RID: 5708
		public const short RECORD_ID = -4089;

		// Token: 0x0400164D RID: 5709
		public const string RECORD_DESCRIPTION = "MsofbtBSE";

		// Token: 0x0400164E RID: 5710
		public const byte BT_ERROR = 0;

		// Token: 0x0400164F RID: 5711
		public const byte BT_UNKNOWN = 1;

		// Token: 0x04001650 RID: 5712
		public const byte BT_EMF = 2;

		// Token: 0x04001651 RID: 5713
		public const byte BT_WMF = 3;

		// Token: 0x04001652 RID: 5714
		public const byte BT_PICT = 4;

		// Token: 0x04001653 RID: 5715
		public const byte BT_JPEG = 5;

		// Token: 0x04001654 RID: 5716
		public const byte BT_PNG = 6;

		// Token: 0x04001655 RID: 5717
		public const byte BT_DIB = 7;

		// Token: 0x04001656 RID: 5718
		private byte field_1_blipTypeWin32;

		// Token: 0x04001657 RID: 5719
		private byte field_2_blipTypeMacOS;

		// Token: 0x04001658 RID: 5720
		private byte[] field_3_uid = new byte[16];

		// Token: 0x04001659 RID: 5721
		private short field_4_tag;

		// Token: 0x0400165A RID: 5722
		private int field_5_size;

		// Token: 0x0400165B RID: 5723
		private int field_6_ref;

		// Token: 0x0400165C RID: 5724
		private int field_7_offset;

		// Token: 0x0400165D RID: 5725
		private byte field_8_usage;

		// Token: 0x0400165E RID: 5726
		private byte field_9_name;

		// Token: 0x0400165F RID: 5727
		private byte field_10_unused2;

		// Token: 0x04001660 RID: 5728
		private byte field_11_unused3;

		// Token: 0x04001661 RID: 5729
		private global::NPOI.DDF.EscherBlipRecord field_12_blipRecord;

		// Token: 0x04001662 RID: 5730
		private byte[] _remainingData = new byte[0];
	}
}
