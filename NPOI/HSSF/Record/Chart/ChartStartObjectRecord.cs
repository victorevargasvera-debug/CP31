using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x020004A7 RID: 1191
	public class ChartStartObjectRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x06002C57 RID: 11351 RVA: 0x00083CC0 File Offset: 0x00081EC0
		public ChartStartObjectRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.rt = in1.ReadShort();
			this.grbitFrt = in1.ReadShort();
			this.iObjectKind = in1.ReadShort();
			this.iObjectContext = in1.ReadShort();
			this.iObjectInstance1 = in1.ReadShort();
			this.iObjectInstance2 = in1.ReadShort();
		}

		// Token: 0x17000B74 RID: 2932
		// (get) Token: 0x06002C58 RID: 11352 RVA: 0x000184AD File Offset: 0x000166AD
		protected override int DataSize
		{
			get
			{
				return 12;
			}
		}

		// Token: 0x17000B75 RID: 2933
		// (get) Token: 0x06002C59 RID: 11353 RVA: 0x00083D1B File Offset: 0x00081F1B
		public override short Sid
		{
			get
			{
				return 2132;
			}
		}

		// Token: 0x06002C5A RID: 11354 RVA: 0x00083D24 File Offset: 0x00081F24
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this.rt);
			out1.WriteShort((int)this.grbitFrt);
			out1.WriteShort((int)this.iObjectKind);
			out1.WriteShort((int)this.iObjectContext);
			out1.WriteShort((int)this.iObjectInstance1);
			out1.WriteShort((int)this.iObjectInstance2);
		}

		// Token: 0x06002C5B RID: 11355 RVA: 0x00083D7C File Offset: 0x00081F7C
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[STARTOBJECT]\n");
			stringBuilder.Append("    .rt              =").Append(global::NPOI.Util.HexDump.ShortToHex((int)this.rt)).Append('\n');
			stringBuilder.Append("    .grbitFrt        =").Append(global::NPOI.Util.HexDump.ShortToHex((int)this.grbitFrt)).Append('\n');
			stringBuilder.Append("    .iObjectKind     =").Append(global::NPOI.Util.HexDump.ShortToHex((int)this.iObjectKind)).Append('\n');
			stringBuilder.Append("    .iObjectContext  =").Append(global::NPOI.Util.HexDump.ShortToHex((int)this.iObjectContext)).Append('\n');
			stringBuilder.Append("    .iObjectInstance1=").Append(global::NPOI.Util.HexDump.ShortToHex((int)this.iObjectInstance1)).Append('\n');
			stringBuilder.Append("    .iObjectInstance2=").Append(global::NPOI.Util.HexDump.ShortToHex((int)this.iObjectInstance2)).Append('\n');
			stringBuilder.Append("[/STARTOBJECT]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x04001359 RID: 4953
		public const short sid = 2132;

		// Token: 0x0400135A RID: 4954
		private short rt;

		// Token: 0x0400135B RID: 4955
		private short grbitFrt;

		// Token: 0x0400135C RID: 4956
		private short iObjectKind;

		// Token: 0x0400135D RID: 4957
		private short iObjectContext;

		// Token: 0x0400135E RID: 4958
		private short iObjectInstance1;

		// Token: 0x0400135F RID: 4959
		private short iObjectInstance2;
	}
}
