using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003F0 RID: 1008
	public class LabelRecord : global::NPOI.HSSF.Record.Record, global::NPOI.HSSF.Record.CellValueRecordInterface, global::System.ICloneable
	{
		// Token: 0x0600245D RID: 9309 RVA: 0x0004D7E9 File Offset: 0x0004B9E9
		public LabelRecord()
		{
		}

		// Token: 0x0600245E RID: 9310 RVA: 0x0006D7E0 File Offset: 0x0006B9E0
		public LabelRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_row = in1.ReadUShort();
			this.field_2_column = in1.ReadUShort();
			this.field_3_xf_index = in1.ReadShort();
			this.field_4_string_len = in1.ReadShort();
			this.field_5_unicode_flag = (byte)in1.ReadByte();
			if (this.field_4_string_len > 0)
			{
				if (this.IsUncompressedUnicode)
				{
					this.field_6_value = in1.ReadUnicodeLEString((int)this.field_4_string_len);
				}
				else
				{
					this.field_6_value = in1.ReadCompressedUnicode((int)this.field_4_string_len);
				}
			}
			else
			{
				this.field_6_value = "";
			}
			if (in1.Remaining > 0)
			{
				global::NPOI.HSSF.Record.LabelRecord.logger.Log(3, "LabelRecord data remains: " + in1.Remaining.ToString() + " : " + global::NPOI.Util.HexDump.ToHex(in1.ReadRemainder()));
			}
		}

		// Token: 0x1700087D RID: 2173
		// (get) Token: 0x0600245F RID: 9311 RVA: 0x0006D8B0 File Offset: 0x0006BAB0
		// (set) Token: 0x06002460 RID: 9312 RVA: 0x0006D8B8 File Offset: 0x0006BAB8
		public int Row
		{
			get
			{
				return this.field_1_row;
			}
			set
			{
				throw new global::System.NotSupportedException("Use LabelSST instead");
			}
		}

		// Token: 0x1700087E RID: 2174
		// (get) Token: 0x06002461 RID: 9313 RVA: 0x0006D8C4 File Offset: 0x0006BAC4
		// (set) Token: 0x06002462 RID: 9314 RVA: 0x0006D8B8 File Offset: 0x0006BAB8
		public int Column
		{
			get
			{
				return this.field_2_column;
			}
			set
			{
				throw new global::System.NotSupportedException("Use LabelSST instead");
			}
		}

		// Token: 0x1700087F RID: 2175
		// (get) Token: 0x06002463 RID: 9315 RVA: 0x0006D8CC File Offset: 0x0006BACC
		// (set) Token: 0x06002464 RID: 9316 RVA: 0x0006D8B8 File Offset: 0x0006BAB8
		public short XFIndex
		{
			get
			{
				return this.field_3_xf_index;
			}
			set
			{
				throw new global::System.NotSupportedException("Use LabelSST instead");
			}
		}

		// Token: 0x17000880 RID: 2176
		// (get) Token: 0x06002465 RID: 9317 RVA: 0x0006D8D4 File Offset: 0x0006BAD4
		public short StringLength
		{
			get
			{
				return this.field_4_string_len;
			}
		}

		// Token: 0x17000881 RID: 2177
		// (get) Token: 0x06002466 RID: 9318 RVA: 0x0006D8DC File Offset: 0x0006BADC
		public bool IsUncompressedUnicode
		{
			get
			{
				return (this.field_5_unicode_flag & 1) > 0;
			}
		}

		// Token: 0x17000882 RID: 2178
		// (get) Token: 0x06002467 RID: 9319 RVA: 0x0006D8E9 File Offset: 0x0006BAE9
		public string Value
		{
			get
			{
				return this.field_6_value;
			}
		}

		// Token: 0x06002468 RID: 9320 RVA: 0x0006D8F1 File Offset: 0x0006BAF1
		public override int Serialize(int offset, byte[] data)
		{
			throw new global::NPOI.Util.RecordFormatException("Label Records are supported Read ONLY...Convert to LabelSST");
		}

		// Token: 0x17000883 RID: 2179
		// (get) Token: 0x06002469 RID: 9321 RVA: 0x0006D8FD File Offset: 0x0006BAFD
		public override int RecordSize
		{
			get
			{
				throw new global::NPOI.Util.RecordFormatException("Label Records are supported READ ONLY...convert to LabelSST");
			}
		}

		// Token: 0x17000884 RID: 2180
		// (get) Token: 0x0600246A RID: 9322 RVA: 0x0006D909 File Offset: 0x0006BB09
		public override short Sid
		{
			get
			{
				return 516;
			}
		}

		// Token: 0x0600246B RID: 9323 RVA: 0x0006D910 File Offset: 0x0006BB10
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[LABEL]\n");
			stringBuilder.Append("    .row            = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.Row)).Append("\n");
			stringBuilder.Append("    .column         = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.Column)).Append("\n");
			stringBuilder.Append("    .xfindex        = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.XFIndex)).Append("\n");
			stringBuilder.Append("    .string_len       = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.field_4_string_len)).Append("\n");
			stringBuilder.Append("    .unicode_flag       = ").Append(global::NPOI.Util.StringUtil.ToHexString((short)this.field_5_unicode_flag)).Append("\n");
			stringBuilder.Append("    .value       = ").Append(this.Value).Append("\n");
			stringBuilder.Append("[/LABEL]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x0600246C RID: 9324 RVA: 0x0006DA20 File Offset: 0x0006BC20
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.LabelRecord
			{
				field_1_row = this.field_1_row,
				field_2_column = this.field_2_column,
				field_3_xf_index = this.field_3_xf_index,
				field_4_string_len = this.field_4_string_len,
				field_5_unicode_flag = this.field_5_unicode_flag,
				field_6_value = this.field_6_value
			};
		}

		// Token: 0x04000F49 RID: 3913
		private static global::NPOI.Util.POILogger logger = global::NPOI.Util.POILogFactory.GetLogger(typeof(global::NPOI.HSSF.Record.LabelRecord));

		// Token: 0x04000F4A RID: 3914
		public const short sid = 516;

		// Token: 0x04000F4B RID: 3915
		private int field_1_row;

		// Token: 0x04000F4C RID: 3916
		private int field_2_column;

		// Token: 0x04000F4D RID: 3917
		private short field_3_xf_index;

		// Token: 0x04000F4E RID: 3918
		private short field_4_string_len;

		// Token: 0x04000F4F RID: 3919
		private byte field_5_unicode_flag;

		// Token: 0x04000F50 RID: 3920
		private string field_6_value;
	}
}
