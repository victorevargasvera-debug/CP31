using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x020004A3 RID: 1187
	public class ChartEndObjectRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x06002C34 RID: 11316 RVA: 0x00083410 File Offset: 0x00081610
		public ChartEndObjectRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.rt = in1.ReadShort();
			this.grbitFrt = in1.ReadShort();
			this.iObjectKind = in1.ReadShort();
			this.reserved = new byte[6];
			if (in1.Available() != 0)
			{
				in1.ReadFully(this.reserved);
			}
		}

		// Token: 0x17000B68 RID: 2920
		// (get) Token: 0x06002C35 RID: 11317 RVA: 0x000184AD File Offset: 0x000166AD
		protected override int DataSize
		{
			get
			{
				return 12;
			}
		}

		// Token: 0x17000B69 RID: 2921
		// (get) Token: 0x06002C36 RID: 11318 RVA: 0x00083467 File Offset: 0x00081667
		public override short Sid
		{
			get
			{
				return 2133;
			}
		}

		// Token: 0x06002C37 RID: 11319 RVA: 0x0008346E File Offset: 0x0008166E
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this.rt);
			out1.WriteShort((int)this.grbitFrt);
			out1.WriteShort((int)this.iObjectKind);
			out1.Write(this.reserved);
		}

		// Token: 0x06002C38 RID: 11320 RVA: 0x000834A0 File Offset: 0x000816A0
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[ENDOBJECT]\n");
			stringBuilder.Append("    .rt         =").Append(global::NPOI.Util.HexDump.ShortToHex((int)this.rt)).Append('\n');
			stringBuilder.Append("    .grbitFrt   =").Append(global::NPOI.Util.HexDump.ShortToHex((int)this.grbitFrt)).Append('\n');
			stringBuilder.Append("    .iObjectKind=").Append(global::NPOI.Util.HexDump.ShortToHex((int)this.iObjectKind)).Append('\n');
			stringBuilder.Append("    .unused     =").Append(global::NPOI.Util.HexDump.ToHex(this.reserved)).Append('\n');
			stringBuilder.Append("[/ENDOBJECT]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x04001342 RID: 4930
		public const short sid = 2133;

		// Token: 0x04001343 RID: 4931
		private short rt;

		// Token: 0x04001344 RID: 4932
		private short grbitFrt;

		// Token: 0x04001345 RID: 4933
		private short iObjectKind;

		// Token: 0x04001346 RID: 4934
		private byte[] reserved;
	}
}
