using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x02000474 RID: 1140
	public class DataLabExtRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x06002A5D RID: 10845 RVA: 0x0007F034 File Offset: 0x0007D234
		public DataLabExtRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.rt = (int)in1.ReadShort();
			this.grbitFrt = (int)in1.ReadShort();
			in1.ReadFully(this.unused);
		}

		// Token: 0x17000AA5 RID: 2725
		// (get) Token: 0x06002A5E RID: 10846 RVA: 0x000184AD File Offset: 0x000166AD
		protected override int DataSize
		{
			get
			{
				return 12;
			}
		}

		// Token: 0x17000AA6 RID: 2726
		// (get) Token: 0x06002A5F RID: 10847 RVA: 0x0007F06C File Offset: 0x0007D26C
		public override short Sid
		{
			get
			{
				return 2154;
			}
		}

		// Token: 0x06002A60 RID: 10848 RVA: 0x0007F073 File Offset: 0x0007D273
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort(this.rt);
			out1.WriteShort(this.grbitFrt);
			out1.Write(this.unused);
		}

		// Token: 0x06002A61 RID: 10849 RVA: 0x0007F09C File Offset: 0x0007D29C
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[DATALABEXT]\n");
			stringBuilder.Append("    .rt      =").Append(global::NPOI.Util.HexDump.ShortToHex(this.rt)).Append('\n');
			stringBuilder.Append("    .grbitFrt=").Append(global::NPOI.Util.HexDump.ShortToHex(this.grbitFrt)).Append('\n');
			stringBuilder.Append("    .unused  =").Append(global::NPOI.Util.HexDump.ToHex(this.unused)).Append('\n');
			stringBuilder.Append("[/DATALABEXT]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x0400124E RID: 4686
		public const short sid = 2154;

		// Token: 0x0400124F RID: 4687
		private int rt;

		// Token: 0x04001250 RID: 4688
		private int grbitFrt;

		// Token: 0x04001251 RID: 4689
		private byte[] unused = new byte[8];
	}
}
