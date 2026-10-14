using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x0200039D RID: 925
	public class OldLabelRecord : global::NPOI.HSSF.Record.OldCellRecord
	{
		// Token: 0x06001FDC RID: 8156 RVA: 0x00061DF0 File Offset: 0x0005FFF0
		public OldLabelRecord(global::NPOI.HSSF.Record.RecordInputStream in1) : base(in1, in1.Sid == 4)
		{
			if (this.IsBiff2)
			{
				this.field_4_string_len = (short)in1.ReadUByte();
			}
			else
			{
				this.field_4_string_len = in1.ReadShort();
			}
			this.field_5_bytes = new byte[(int)this.field_4_string_len];
			in1.Read(this.field_5_bytes, 0, (int)this.field_4_string_len);
			if (in1.Remaining > 0)
			{
				global::NPOI.HSSF.Record.OldLabelRecord.logger.Log(3, "LabelRecord data remains: " + in1.Remaining.ToString() + " : " + global::NPOI.Util.HexDump.ToHex(in1.ReadRemainder()));
			}
		}

		// Token: 0x06001FDD RID: 8157 RVA: 0x00061E91 File Offset: 0x00060091
		public void SetCodePage(global::NPOI.HSSF.Record.CodepageRecord codepage)
		{
			this.codepage = codepage;
		}

		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x06001FDE RID: 8158 RVA: 0x00061E9A File Offset: 0x0006009A
		public short StringLength
		{
			get
			{
				return this.field_4_string_len;
			}
		}

		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x06001FDF RID: 8159 RVA: 0x00061EA2 File Offset: 0x000600A2
		public string Value
		{
			get
			{
				return global::NPOI.HSSF.Record.OldStringRecord.GetString(this.field_5_bytes, this.codepage);
			}
		}

		// Token: 0x06001FE0 RID: 8160 RVA: 0x00061EB5 File Offset: 0x000600B5
		public int Serialize(int offset, byte[] data)
		{
			throw new global::NPOI.Util.RecordFormatException("Old Label Records are supported READ ONLY");
		}

		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x06001FE1 RID: 8161 RVA: 0x00061EB5 File Offset: 0x000600B5
		public int RecordSize
		{
			get
			{
				throw new global::NPOI.Util.RecordFormatException("Old Label Records are supported READ ONLY");
			}
		}

		// Token: 0x06001FE2 RID: 8162 RVA: 0x00061EC4 File Offset: 0x000600C4
		protected override void AppendValueText(global::System.Text.StringBuilder sb)
		{
			sb.Append("    .string_len= ").Append(global::NPOI.Util.HexDump.ShortToHex((int)this.field_4_string_len)).Append("\n");
			sb.Append("    .value       = ").Append(this.Value).Append("\n");
		}

		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x06001FE3 RID: 8163 RVA: 0x00061F18 File Offset: 0x00060118
		protected override string RecordName
		{
			get
			{
				return "OLD LABEL";
			}
		}

		// Token: 0x04000C52 RID: 3154
		private static global::NPOI.Util.POILogger logger = global::NPOI.Util.POILogFactory.GetLogger(typeof(global::NPOI.HSSF.Record.OldLabelRecord));

		// Token: 0x04000C53 RID: 3155
		public const short biff2_sid = 4;

		// Token: 0x04000C54 RID: 3156
		public const short biff345_sid = 516;

		// Token: 0x04000C55 RID: 3157
		private short field_4_string_len;

		// Token: 0x04000C56 RID: 3158
		private byte[] field_5_bytes;

		// Token: 0x04000C57 RID: 3159
		private global::NPOI.HSSF.Record.CodepageRecord codepage;
	}
}
