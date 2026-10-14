using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x0200039E RID: 926
	public class OldSheetRecord
	{
		// Token: 0x06001FE5 RID: 8165 RVA: 0x00061F38 File Offset: 0x00060138
		public OldSheetRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_position_of_BOF = in1.ReadInt();
			this.field_2_visibility = in1.ReadUByte();
			this.field_3_type = in1.ReadUByte();
			int num = in1.ReadUByte();
			this.field_5_sheetname = new byte[num];
			in1.Read(this.field_5_sheetname, 0, num);
		}

		// Token: 0x06001FE6 RID: 8166 RVA: 0x00061F91 File Offset: 0x00060191
		public void SetCodePage(global::NPOI.HSSF.Record.CodepageRecord codepage)
		{
			this.codepage = codepage;
		}

		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x06001FE7 RID: 8167 RVA: 0x00061F9A File Offset: 0x0006019A
		public short Sid
		{
			get
			{
				return 133;
			}
		}

		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x06001FE8 RID: 8168 RVA: 0x00061FA1 File Offset: 0x000601A1
		public int PositionOfBof
		{
			get
			{
				return this.field_1_position_of_BOF;
			}
		}

		// Token: 0x170006DA RID: 1754
		// (get) Token: 0x06001FE9 RID: 8169 RVA: 0x00061FA9 File Offset: 0x000601A9
		public string Sheetname
		{
			get
			{
				return global::NPOI.HSSF.Record.OldStringRecord.GetString(this.field_5_sheetname, this.codepage);
			}
		}

		// Token: 0x06001FEA RID: 8170 RVA: 0x00061FBC File Offset: 0x000601BC
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[BOUNDSHEET]\n");
			stringBuilder.Append("    .bof        = ").Append(global::NPOI.Util.HexDump.IntToHex(this.PositionOfBof)).Append("\n");
			stringBuilder.Append("    .visibility = ").Append(global::NPOI.Util.HexDump.ShortToHex(this.field_2_visibility)).Append("\n");
			stringBuilder.Append("    .type       = ").Append(global::NPOI.Util.HexDump.ByteToHex(this.field_3_type)).Append("\n");
			stringBuilder.Append("    .sheetname  = ").Append(this.Sheetname).Append("\n");
			stringBuilder.Append("[/BOUNDSHEET]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x04000C58 RID: 3160
		public const short sid = 133;

		// Token: 0x04000C59 RID: 3161
		private int field_1_position_of_BOF;

		// Token: 0x04000C5A RID: 3162
		private int field_2_visibility;

		// Token: 0x04000C5B RID: 3163
		private int field_3_type;

		// Token: 0x04000C5C RID: 3164
		private byte[] field_5_sheetname;

		// Token: 0x04000C5D RID: 3165
		private global::NPOI.HSSF.Record.CodepageRecord codepage;
	}
}
