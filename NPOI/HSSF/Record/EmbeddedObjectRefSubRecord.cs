using System;
using System.Globalization;
using System.IO;
using System.Text;
using NPOI.SS.Formula.PTG;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x02000427 RID: 1063
	public class EmbeddedObjectRefSubRecord : global::NPOI.HSSF.Record.SubRecord, global::System.ICloneable
	{
		// Token: 0x0600270E RID: 9998 RVA: 0x00075410 File Offset: 0x00073610
		public EmbeddedObjectRefSubRecord()
		{
			this.field_2_unknownFormulaData = new byte[]
			{
				2,
				108,
				106,
				22,
				1
			};
			this.field_6_unknown = global::NPOI.HSSF.Record.EmbeddedObjectRefSubRecord.EMPTY_BYTE_ARRAY;
			this.field_4_ole_classname = null;
			this.field_4_unknownByte = null;
		}

		// Token: 0x0600270F RID: 9999 RVA: 0x00075450 File Offset: 0x00073650
		public EmbeddedObjectRefSubRecord(global::NPOI.Util.ILittleEndianInput in1, int size)
		{
			int num = (int)in1.ReadShort();
			int num2 = size - 2;
			int num3 = num2 - num;
			int num4 = in1.ReadUShort();
			num2 -= 2;
			this.field_1_unknown_int = in1.ReadInt();
			num2 -= 4;
			byte[] formulaRawBytes = global::NPOI.HSSF.Record.EmbeddedObjectRefSubRecord.ReadRawData(in1, num4);
			num2 -= num4;
			this.field_2_refPtg = global::NPOI.HSSF.Record.EmbeddedObjectRefSubRecord.ReadRefPtg(formulaRawBytes);
			if (this.field_2_refPtg == null)
			{
				this.field_2_unknownFormulaData = formulaRawBytes;
			}
			else
			{
				this.field_2_unknownFormulaData = null;
			}
			int num6;
			if (num2 >= num3 + 3)
			{
				int num5 = in1.ReadByte();
				num6 = 1;
				if (num5 != 3)
				{
					throw new global::NPOI.Util.RecordFormatException("Expected byte 0x03 here");
				}
				int num7 = in1.ReadUShort();
				num6 += 2;
				if (num7 > 0)
				{
					this.field_3_unicode_flag = ((in1.ReadByte() & 1) != 0);
					num6++;
					if (this.field_3_unicode_flag)
					{
						this.field_4_ole_classname = global::NPOI.Util.StringUtil.ReadUnicodeLE(in1, num7);
						num6 += num7 * 2;
					}
					else
					{
						this.field_4_ole_classname = global::NPOI.Util.StringUtil.ReadCompressedUnicode(in1, num7);
						num6 += num7;
					}
				}
				else
				{
					this.field_4_ole_classname = "";
				}
			}
			else
			{
				this.field_4_ole_classname = null;
				num6 = 0;
			}
			num2 -= num6;
			if ((num6 + num4) % 2 != 0)
			{
				int num8 = in1.ReadByte();
				num2--;
				if (this.field_2_refPtg != null && this.field_4_ole_classname == null)
				{
					this.field_4_unknownByte = new byte?((byte)num8);
				}
			}
			int num9 = num2 - num3;
			if (num9 > 0)
			{
				global::NPOI.HSSF.Record.EmbeddedObjectRefSubRecord.logger.Log(7, "Discarding " + num9.ToString() + " unexpected padding bytes ");
				global::NPOI.HSSF.Record.EmbeddedObjectRefSubRecord.ReadRawData(in1, num9);
				num2 -= num9;
			}
			if (num3 >= 4)
			{
				this.field_5_stream_id = new int?(in1.ReadInt());
				num2 -= 4;
			}
			else
			{
				this.field_5_stream_id = null;
			}
			this.field_6_unknown = global::NPOI.HSSF.Record.EmbeddedObjectRefSubRecord.ReadRawData(in1, num2);
		}

		// Token: 0x17000977 RID: 2423
		// (get) Token: 0x06002710 RID: 10000 RVA: 0x00016AA5 File Offset: 0x00014CA5
		public override short Sid
		{
			get
			{
				return 9;
			}
		}

		// Token: 0x06002711 RID: 10001 RVA: 0x00075600 File Offset: 0x00073800
		private static global::NPOI.SS.Formula.PTG.Ptg ReadRefPtg(byte[] formulaRawBytes)
		{
			global::NPOI.SS.Formula.PTG.Ptg result;
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(formulaRawBytes))
			{
				global::NPOI.Util.ILittleEndianInput littleEndianInput = new global::NPOI.Util.LittleEndianInputStream(memoryStream);
				byte b = (byte)littleEndianInput.ReadByte();
				if (b <= 37)
				{
					if (b == 36)
					{
						return new global::NPOI.SS.Formula.PTG.RefPtg(littleEndianInput);
					}
					if (b == 37)
					{
						return new global::NPOI.SS.Formula.PTG.AreaPtg(littleEndianInput);
					}
				}
				else
				{
					if (b == 58)
					{
						return new global::NPOI.SS.Formula.PTG.Ref3DPtg(littleEndianInput);
					}
					if (b == 59)
					{
						return new global::NPOI.SS.Formula.PTG.Area3DPtg(littleEndianInput);
					}
				}
				result = null;
			}
			return result;
		}

		// Token: 0x06002712 RID: 10002 RVA: 0x00075684 File Offset: 0x00073884
		private static byte[] ReadRawData(global::NPOI.Util.ILittleEndianInput in1, int size)
		{
			if (size < 0)
			{
				throw new global::System.ArgumentException("Negative size (" + size.ToString() + ")");
			}
			if (size == 0)
			{
				return global::NPOI.HSSF.Record.EmbeddedObjectRefSubRecord.EMPTY_BYTE_ARRAY;
			}
			byte[] array = new byte[size];
			in1.ReadFully(array);
			return array;
		}

		// Token: 0x06002713 RID: 10003 RVA: 0x000756CC File Offset: 0x000738CC
		private int GetStreamIDOffset(int formulaSize)
		{
			int num = 6;
			num += formulaSize;
			if (this.field_4_ole_classname != null)
			{
				num += 3;
				int length = this.field_4_ole_classname.Length;
				if (length > 0)
				{
					num++;
					if (this.field_3_unicode_flag)
					{
						num += length * 2;
					}
					else
					{
						num += length;
					}
				}
			}
			if (num % 2 != 0)
			{
				num++;
			}
			return num;
		}

		// Token: 0x06002714 RID: 10004 RVA: 0x00075724 File Offset: 0x00073924
		private int GetDataSize(int idOffset)
		{
			int num = 2 + idOffset;
			if (this.field_5_stream_id != null)
			{
				num += 4;
			}
			return num + this.field_6_unknown.Length;
		}

		// Token: 0x17000978 RID: 2424
		// (get) Token: 0x06002715 RID: 10005 RVA: 0x00075750 File Offset: 0x00073950
		public override int DataSize
		{
			get
			{
				int formulaSize = (this.field_2_refPtg == null) ? this.field_2_unknownFormulaData.Length : this.field_2_refPtg.Size;
				int streamIDOffset = this.GetStreamIDOffset(formulaSize);
				return this.GetDataSize(streamIDOffset);
			}
		}

		// Token: 0x06002716 RID: 10006 RVA: 0x0007578C File Offset: 0x0007398C
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			int num = (this.field_2_refPtg == null) ? this.field_2_unknownFormulaData.Length : this.field_2_refPtg.Size;
			int streamIDOffset = this.GetStreamIDOffset(num);
			int dataSize = this.GetDataSize(streamIDOffset);
			out1.WriteShort(9);
			out1.WriteShort(dataSize);
			out1.WriteShort(streamIDOffset);
			out1.WriteShort(num);
			out1.WriteInt(this.field_1_unknown_int);
			int num2 = 12;
			if (this.field_2_refPtg == null)
			{
				out1.Write(this.field_2_unknownFormulaData);
			}
			else
			{
				this.field_2_refPtg.Write(out1);
			}
			num2 += num;
			if (this.field_4_ole_classname != null)
			{
				out1.WriteByte(3);
				num2++;
				int length = this.field_4_ole_classname.Length;
				out1.WriteShort(length);
				num2 += 2;
				if (length > 0)
				{
					out1.WriteByte(this.field_3_unicode_flag ? 1 : 0);
					num2++;
					if (this.field_3_unicode_flag)
					{
						global::NPOI.Util.StringUtil.PutUnicodeLE(this.field_4_ole_classname, out1);
						num2 += length * 2;
					}
					else
					{
						global::NPOI.Util.StringUtil.PutCompressedUnicode(this.field_4_ole_classname, out1);
						num2 += length;
					}
				}
			}
			int num3 = streamIDOffset - (num2 - 6);
			if (num3 != 0)
			{
				if (num3 != 1)
				{
					throw new global::System.InvalidOperationException(string.Concat(new string[]
					{
						"Bad padding calculation (",
						streamIDOffset.ToString(),
						", ",
						num2.ToString(),
						")"
					}));
				}
				out1.WriteByte((int)((this.field_4_unknownByte == null) ? 0 : global::System.Convert.ToByte(this.field_4_unknownByte, global::System.Globalization.CultureInfo.InvariantCulture)));
				num2++;
			}
			if (this.field_5_stream_id != null)
			{
				out1.WriteInt(global::System.Convert.ToInt32(this.field_5_stream_id, global::System.Globalization.CultureInfo.InvariantCulture));
				num2 += 4;
			}
			out1.Write(this.field_6_unknown);
		}

		// Token: 0x17000979 RID: 2425
		// (get) Token: 0x06002717 RID: 10007 RVA: 0x00075949 File Offset: 0x00073B49
		public int? StreamId
		{
			get
			{
				return this.field_5_stream_id;
			}
		}

		// Token: 0x1700097A RID: 2426
		// (get) Token: 0x06002718 RID: 10008 RVA: 0x00075951 File Offset: 0x00073B51
		// (set) Token: 0x06002719 RID: 10009 RVA: 0x00075959 File Offset: 0x00073B59
		public string OLEClassName
		{
			get
			{
				return this.field_4_ole_classname;
			}
			set
			{
				this.field_4_ole_classname = value;
			}
		}

		// Token: 0x1700097B RID: 2427
		// (get) Token: 0x0600271A RID: 10010 RVA: 0x00075962 File Offset: 0x00073B62
		// (set) Token: 0x0600271B RID: 10011 RVA: 0x0007596A File Offset: 0x00073B6A
		public byte[] ObjectData
		{
			get
			{
				return this.field_6_unknown;
			}
			set
			{
				this.field_6_unknown = value;
			}
		}

		// Token: 0x0600271C RID: 10012 RVA: 0x00075974 File Offset: 0x00073B74
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[ftPictFmla]\n");
			stringBuilder.Append("    .f2unknown     = ").Append(global::NPOI.Util.HexDump.IntToHex(this.field_1_unknown_int)).Append("\n");
			if (this.field_2_refPtg == null)
			{
				stringBuilder.Append("    .f3unknown     = ").Append(global::NPOI.Util.HexDump.ToHex(this.field_2_unknownFormulaData)).Append("\n");
			}
			else
			{
				stringBuilder.Append("    .formula       = ").Append(this.field_2_refPtg.ToString()).Append("\n");
			}
			if (this.field_4_ole_classname != null)
			{
				stringBuilder.Append("    .unicodeFlag   = ").Append(this.field_3_unicode_flag).Append("\n");
				stringBuilder.Append("    .oleClassname  = ").Append(this.field_4_ole_classname).Append("\n");
			}
			if (this.field_4_unknownByte != null)
			{
				stringBuilder.Append("    .f4unknown   = ").Append(global::NPOI.Util.HexDump.ByteToHex((int)global::System.Convert.ToByte(this.field_4_unknownByte, global::System.Globalization.CultureInfo.InvariantCulture))).Append("\n");
			}
			if (this.field_5_stream_id != null)
			{
				stringBuilder.Append("    .streamId      = ").Append(global::NPOI.Util.HexDump.IntToHex(global::System.Convert.ToInt32(this.field_5_stream_id, global::System.Globalization.CultureInfo.InvariantCulture))).Append("\n");
			}
			if (this.field_6_unknown.Length != 0)
			{
				stringBuilder.Append("    .f7unknown     = ").Append(global::NPOI.Util.HexDump.ToHex(this.field_6_unknown)).Append("\n");
			}
			stringBuilder.Append("[/ftPictFmla]");
			return stringBuilder.ToString();
		}

		// Token: 0x0600271D RID: 10013 RVA: 0x0000F20C File Offset: 0x0000D40C
		public override object Clone()
		{
			return this;
		}

		// Token: 0x0600271E RID: 10014 RVA: 0x00075B1E File Offset: 0x00073D1E
		public void SetUnknownFormulaData(byte[] formularData)
		{
			this.field_2_unknownFormulaData = formularData;
		}

		// Token: 0x0600271F RID: 10015 RVA: 0x00075B27 File Offset: 0x00073D27
		public void SetStorageId(int storageId)
		{
			this.field_5_stream_id = new int?(storageId);
		}

		// Token: 0x04001075 RID: 4213
		private static global::NPOI.Util.POILogger logger = global::NPOI.Util.POILogFactory.GetLogger(typeof(global::NPOI.HSSF.Record.EmbeddedObjectRefSubRecord));

		// Token: 0x04001076 RID: 4214
		public const short sid = 9;

		// Token: 0x04001077 RID: 4215
		private static byte[] EMPTY_BYTE_ARRAY = new byte[0];

		// Token: 0x04001078 RID: 4216
		private int field_1_unknown_int;

		// Token: 0x04001079 RID: 4217
		private global::NPOI.SS.Formula.PTG.Ptg field_2_refPtg;

		// Token: 0x0400107A RID: 4218
		private byte[] field_2_unknownFormulaData;

		// Token: 0x0400107B RID: 4219
		public bool field_3_unicode_flag;

		// Token: 0x0400107C RID: 4220
		private string field_4_ole_classname;

		// Token: 0x0400107D RID: 4221
		private byte? field_4_unknownByte;

		// Token: 0x0400107E RID: 4222
		private int? field_5_stream_id;

		// Token: 0x0400107F RID: 4223
		private byte[] field_6_unknown;
	}
}
