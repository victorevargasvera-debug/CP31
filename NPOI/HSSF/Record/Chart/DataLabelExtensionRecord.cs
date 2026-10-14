using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x020004AA RID: 1194
	public class DataLabelExtensionRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x06002C74 RID: 11380 RVA: 0x0008419E File Offset: 0x0008239E
		public DataLabelExtensionRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.rt = (int)in1.ReadShort();
			this.grbitFrt = (int)in1.ReadShort();
			in1.ReadFully(this.unused);
		}

		// Token: 0x17000B7F RID: 2943
		// (get) Token: 0x06002C75 RID: 11381 RVA: 0x000184AD File Offset: 0x000166AD
		protected override int DataSize
		{
			get
			{
				return 12;
			}
		}

		// Token: 0x17000B80 RID: 2944
		// (get) Token: 0x06002C76 RID: 11382 RVA: 0x000841D6 File Offset: 0x000823D6
		public override short Sid
		{
			get
			{
				return global::NPOI.HSSF.Record.Chart.DataLabelExtensionRecord.sid;
			}
		}

		// Token: 0x06002C77 RID: 11383 RVA: 0x000841DD File Offset: 0x000823DD
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort(this.rt);
			out1.WriteShort(this.grbitFrt);
			out1.Write(this.unused);
		}

		// Token: 0x06002C78 RID: 11384 RVA: 0x00084204 File Offset: 0x00082404
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

		// Token: 0x04001367 RID: 4967
		public static short sid = 2154;

		// Token: 0x04001368 RID: 4968
		private int rt;

		// Token: 0x04001369 RID: 4969
		private int grbitFrt;

		// Token: 0x0400136A RID: 4970
		private byte[] unused = new byte[8];
	}
}
