using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record.PivotTable
{
	// Token: 0x02000449 RID: 1097
	public class StreamIDRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x0600289B RID: 10395 RVA: 0x0007A4EB File Offset: 0x000786EB
		public StreamIDRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.idstm = (int)in1.ReadShort();
		}

		// Token: 0x0600289C RID: 10396 RVA: 0x0007A4FF File Offset: 0x000786FF
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort(this.idstm);
		}

		// Token: 0x17000A0E RID: 2574
		// (get) Token: 0x0600289D RID: 10397 RVA: 0x00016A02 File Offset: 0x00014C02
		protected override int DataSize
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x17000A0F RID: 2575
		// (get) Token: 0x0600289E RID: 10398 RVA: 0x0007A50D File Offset: 0x0007870D
		public override short Sid
		{
			get
			{
				return 213;
			}
		}

		// Token: 0x0600289F RID: 10399 RVA: 0x0007A514 File Offset: 0x00078714
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[SXIDSTM]\n");
			stringBuilder.Append("    .idstm      =").Append(global::NPOI.Util.HexDump.ShortToHex(this.idstm)).Append('\n');
			stringBuilder.Append("[/SXIDSTM]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x0400115B RID: 4443
		public const short sid = 213;

		// Token: 0x0400115C RID: 4444
		private int idstm;
	}
}
