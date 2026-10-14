using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x020004A6 RID: 1190
	public class ChartStartBlockRecord : global::NPOI.HSSF.Record.StandardRecord, global::System.ICloneable
	{
		// Token: 0x06002C4F RID: 11343 RVA: 0x0005FE49 File Offset: 0x0005E049
		public ChartStartBlockRecord()
		{
		}

		// Token: 0x06002C50 RID: 11344 RVA: 0x00083A98 File Offset: 0x00081C98
		public ChartStartBlockRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.rt = in1.ReadShort();
			this.grbitFrt = in1.ReadShort();
			this.iObjectKind = in1.ReadShort();
			this.iObjectContext = in1.ReadShort();
			this.iObjectInstance1 = in1.ReadShort();
			this.iObjectInstance2 = in1.ReadShort();
		}

		// Token: 0x17000B72 RID: 2930
		// (get) Token: 0x06002C51 RID: 11345 RVA: 0x000184AD File Offset: 0x000166AD
		protected override int DataSize
		{
			get
			{
				return 12;
			}
		}

		// Token: 0x17000B73 RID: 2931
		// (get) Token: 0x06002C52 RID: 11346 RVA: 0x00083AF3 File Offset: 0x00081CF3
		public override short Sid
		{
			get
			{
				return global::NPOI.HSSF.Record.Chart.ChartStartBlockRecord.sid;
			}
		}

		// Token: 0x06002C53 RID: 11347 RVA: 0x00083AFC File Offset: 0x00081CFC
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this.rt);
			out1.WriteShort((int)this.grbitFrt);
			out1.WriteShort((int)this.iObjectKind);
			out1.WriteShort((int)this.iObjectContext);
			out1.WriteShort((int)this.iObjectInstance1);
			out1.WriteShort((int)this.iObjectInstance2);
		}

		// Token: 0x06002C54 RID: 11348 RVA: 0x00083B54 File Offset: 0x00081D54
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[STARTBLOCK]\n");
			stringBuilder.Append("    .rt              =").Append(global::NPOI.Util.HexDump.ShortToHex((int)this.rt)).Append('\n');
			stringBuilder.Append("    .grbitFrt        =").Append(global::NPOI.Util.HexDump.ShortToHex((int)this.grbitFrt)).Append('\n');
			stringBuilder.Append("    .iObjectKind     =").Append(global::NPOI.Util.HexDump.ShortToHex((int)this.iObjectKind)).Append('\n');
			stringBuilder.Append("    .iObjectContext  =").Append(global::NPOI.Util.HexDump.ShortToHex((int)this.iObjectContext)).Append('\n');
			stringBuilder.Append("    .iObjectInstance1=").Append(global::NPOI.Util.HexDump.ShortToHex((int)this.iObjectInstance1)).Append('\n');
			stringBuilder.Append("    .iObjectInstance2=").Append(global::NPOI.Util.HexDump.ShortToHex((int)this.iObjectInstance2)).Append('\n');
			stringBuilder.Append("[/STARTBLOCK]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002C55 RID: 11349 RVA: 0x00083C58 File Offset: 0x00081E58
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.Chart.ChartStartBlockRecord
			{
				rt = this.rt,
				grbitFrt = this.grbitFrt,
				iObjectKind = this.iObjectKind,
				iObjectContext = this.iObjectContext,
				iObjectInstance1 = this.iObjectInstance1,
				iObjectInstance2 = this.iObjectInstance2
			};
		}

		// Token: 0x04001352 RID: 4946
		public static short sid = 2130;

		// Token: 0x04001353 RID: 4947
		private short rt;

		// Token: 0x04001354 RID: 4948
		private short grbitFrt;

		// Token: 0x04001355 RID: 4949
		private short iObjectKind;

		// Token: 0x04001356 RID: 4950
		private short iObjectContext;

		// Token: 0x04001357 RID: 4951
		private short iObjectInstance1;

		// Token: 0x04001358 RID: 4952
		private short iObjectInstance2;
	}
}
