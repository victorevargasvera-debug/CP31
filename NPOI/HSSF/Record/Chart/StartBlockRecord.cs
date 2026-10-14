using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x0200048E RID: 1166
	public class StartBlockRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x17000AF0 RID: 2800
		// (get) Token: 0x06002B12 RID: 11026 RVA: 0x00080133 File Offset: 0x0007E333
		// (set) Token: 0x06002B13 RID: 11027 RVA: 0x0008013B File Offset: 0x0007E33B
		public global::NPOI.HSSF.Record.Chart.ObjectKind ObjectKind { get; set; }

		// Token: 0x17000AF1 RID: 2801
		// (get) Token: 0x06002B14 RID: 11028 RVA: 0x00080144 File Offset: 0x0007E344
		// (set) Token: 0x06002B15 RID: 11029 RVA: 0x0008014C File Offset: 0x0007E34C
		public short ObjectContext { get; set; }

		// Token: 0x17000AF2 RID: 2802
		// (get) Token: 0x06002B16 RID: 11030 RVA: 0x00080155 File Offset: 0x0007E355
		// (set) Token: 0x06002B17 RID: 11031 RVA: 0x0008015D File Offset: 0x0007E35D
		public short ObjectInstance1 { get; set; }

		// Token: 0x17000AF3 RID: 2803
		// (get) Token: 0x06002B18 RID: 11032 RVA: 0x00080166 File Offset: 0x0007E366
		// (set) Token: 0x06002B19 RID: 11033 RVA: 0x0008016E File Offset: 0x0007E36E
		public short ObjectInstance2 { get; set; }

		// Token: 0x06002B1A RID: 11034 RVA: 0x00080177 File Offset: 0x0007E377
		public StartBlockRecord()
		{
			this.rt = global::NPOI.HSSF.Record.Chart.StartBlockRecord.sid;
			this.grbitFrt = 0;
		}

		// Token: 0x06002B1B RID: 11035 RVA: 0x00080194 File Offset: 0x0007E394
		public StartBlockRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.rt = in1.ReadShort();
			this.grbitFrt = in1.ReadShort();
			this.ObjectKind = (global::NPOI.HSSF.Record.Chart.ObjectKind)in1.ReadShort();
			this.ObjectContext = in1.ReadShort();
			this.ObjectInstance1 = in1.ReadShort();
			this.ObjectInstance2 = in1.ReadShort();
		}

		// Token: 0x17000AF4 RID: 2804
		// (get) Token: 0x06002B1C RID: 11036 RVA: 0x000184AD File Offset: 0x000166AD
		protected override int DataSize
		{
			get
			{
				return 12;
			}
		}

		// Token: 0x17000AF5 RID: 2805
		// (get) Token: 0x06002B1D RID: 11037 RVA: 0x000801EF File Offset: 0x0007E3EF
		public override short Sid
		{
			get
			{
				return global::NPOI.HSSF.Record.Chart.StartBlockRecord.sid;
			}
		}

		// Token: 0x06002B1E RID: 11038 RVA: 0x000801F8 File Offset: 0x0007E3F8
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this.rt);
			out1.WriteShort((int)this.grbitFrt);
			out1.WriteShort((int)this.ObjectKind);
			out1.WriteShort((int)this.ObjectContext);
			out1.WriteShort((int)this.ObjectInstance1);
			out1.WriteShort((int)this.ObjectInstance2);
		}

		// Token: 0x06002B1F RID: 11039 RVA: 0x00080250 File Offset: 0x0007E450
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[STARTBLOCK]\n");
			stringBuilder.Append("    .rt              =").Append(global::NPOI.Util.HexDump.ShortToHex((int)this.rt)).Append('\n');
			stringBuilder.Append("    .grbitFrt        =").Append(global::NPOI.Util.HexDump.ShortToHex((int)this.grbitFrt)).Append('\n');
			stringBuilder.Append("    .iObjectKind     =").Append(global::NPOI.Util.HexDump.ShortToHex((int)this.ObjectKind)).Append('\n');
			stringBuilder.Append("    .iObjectContext  =").Append(global::NPOI.Util.HexDump.ShortToHex((int)this.ObjectContext)).Append('\n');
			stringBuilder.Append("    .iObjectInstance1=").Append(global::NPOI.Util.HexDump.ShortToHex((int)this.ObjectInstance1)).Append('\n');
			stringBuilder.Append("    .iObjectInstance2=").Append(global::NPOI.Util.HexDump.ShortToHex((int)this.ObjectInstance2)).Append('\n');
			stringBuilder.Append("[/STARTBLOCK]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002B20 RID: 11040 RVA: 0x00080354 File Offset: 0x0007E554
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.Chart.StartBlockRecord
			{
				rt = this.rt,
				grbitFrt = this.grbitFrt,
				ObjectKind = this.ObjectKind,
				ObjectContext = this.ObjectContext,
				ObjectInstance1 = this.ObjectInstance1,
				ObjectInstance2 = this.ObjectInstance2
			};
		}

		// Token: 0x06002B21 RID: 11041 RVA: 0x000803AE File Offset: 0x0007E5AE
		public static global::NPOI.HSSF.Record.Chart.StartBlockRecord CreateStartBlock(global::NPOI.HSSF.Record.Chart.ObjectKind objectKind)
		{
			return global::NPOI.HSSF.Record.Chart.StartBlockRecord.CreateStartBlock(objectKind, 0, 0, 0);
		}

		// Token: 0x06002B22 RID: 11042 RVA: 0x000803B9 File Offset: 0x0007E5B9
		public static global::NPOI.HSSF.Record.Chart.StartBlockRecord CreateStartBlock(global::NPOI.HSSF.Record.Chart.ObjectKind objectKind, short objectContext)
		{
			return global::NPOI.HSSF.Record.Chart.StartBlockRecord.CreateStartBlock(objectKind, objectContext, 0, 0);
		}

		// Token: 0x06002B23 RID: 11043 RVA: 0x000803C4 File Offset: 0x0007E5C4
		public static global::NPOI.HSSF.Record.Chart.StartBlockRecord CreateStartBlock(global::NPOI.HSSF.Record.Chart.ObjectKind objectKind, short objectContext, short objectInstance1)
		{
			return global::NPOI.HSSF.Record.Chart.StartBlockRecord.CreateStartBlock(objectKind, objectContext, objectInstance1, 0);
		}

		// Token: 0x06002B24 RID: 11044 RVA: 0x000803CF File Offset: 0x0007E5CF
		public static global::NPOI.HSSF.Record.Chart.StartBlockRecord CreateStartBlock(global::NPOI.HSSF.Record.Chart.ObjectKind objectKind, short objectContext, short objectInstance1, short objectInstance2)
		{
			return new global::NPOI.HSSF.Record.Chart.StartBlockRecord
			{
				ObjectKind = objectKind,
				ObjectContext = objectContext,
				ObjectInstance1 = objectInstance1,
				ObjectInstance2 = objectInstance2
			};
		}

		// Token: 0x0400129A RID: 4762
		public static short sid = 2130;

		// Token: 0x0400129B RID: 4763
		private short rt;

		// Token: 0x0400129C RID: 4764
		private short grbitFrt;
	}
}
