using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record.PivotTable
{
	// Token: 0x02000446 RID: 1094
	public class DataItemRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x0600288C RID: 10380 RVA: 0x00079F3C File Offset: 0x0007813C
		public DataItemRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.isxvdData = in1.ReadUShort();
			this.iiftab = in1.ReadUShort();
			this.df = in1.ReadUShort();
			this.isxvd = in1.ReadUShort();
			this.isxvi = in1.ReadUShort();
			this.ifmt = in1.ReadUShort();
			this.name = in1.ReadString();
		}

		// Token: 0x0600288D RID: 10381 RVA: 0x00079FA4 File Offset: 0x000781A4
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort(this.isxvdData);
			out1.WriteShort(this.iiftab);
			out1.WriteShort(this.df);
			out1.WriteShort(this.isxvd);
			out1.WriteShort(this.isxvi);
			out1.WriteShort(this.ifmt);
			global::NPOI.Util.StringUtil.WriteUnicodeString(out1, this.name);
		}

		// Token: 0x17000A08 RID: 2568
		// (get) Token: 0x0600288E RID: 10382 RVA: 0x0007A005 File Offset: 0x00078205
		protected override int DataSize
		{
			get
			{
				return 12 + global::NPOI.Util.StringUtil.GetEncodedSize(this.name);
			}
		}

		// Token: 0x17000A09 RID: 2569
		// (get) Token: 0x0600288F RID: 10383 RVA: 0x0007A015 File Offset: 0x00078215
		public override short Sid
		{
			get
			{
				return 197;
			}
		}

		// Token: 0x06002890 RID: 10384 RVA: 0x0007A01C File Offset: 0x0007821C
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[SXDI]\n");
			stringBuilder.Append("  .isxvdData = ").Append(global::NPOI.Util.HexDump.ShortToHex(this.isxvdData)).Append("\n");
			stringBuilder.Append("  .iiftab = ").Append(global::NPOI.Util.HexDump.ShortToHex(this.iiftab)).Append("\n");
			stringBuilder.Append("  .df = ").Append(global::NPOI.Util.HexDump.ShortToHex(this.df)).Append("\n");
			stringBuilder.Append("  .isxvd = ").Append(global::NPOI.Util.HexDump.ShortToHex(this.isxvd)).Append("\n");
			stringBuilder.Append("  .isxvi = ").Append(global::NPOI.Util.HexDump.ShortToHex(this.isxvi)).Append("\n");
			stringBuilder.Append("  .ifmt = ").Append(global::NPOI.Util.HexDump.ShortToHex(this.ifmt)).Append("\n");
			stringBuilder.Append("[/SXDI]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x04001147 RID: 4423
		public const short sid = 197;

		// Token: 0x04001148 RID: 4424
		private int isxvdData;

		// Token: 0x04001149 RID: 4425
		private int iiftab;

		// Token: 0x0400114A RID: 4426
		private int df;

		// Token: 0x0400114B RID: 4427
		private int isxvd;

		// Token: 0x0400114C RID: 4428
		private int isxvi;

		// Token: 0x0400114D RID: 4429
		private int ifmt;

		// Token: 0x0400114E RID: 4430
		private string name;
	}
}
