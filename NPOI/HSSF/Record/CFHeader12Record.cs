using System;
using NPOI.HSSF.Record.Common;
using NPOI.SS.Util;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x02000393 RID: 915
	public class CFHeader12Record : global::NPOI.HSSF.Record.CFHeaderBase, global::NPOI.HSSF.Record.Common.IFutureRecord, global::System.ICloneable
	{
		// Token: 0x06001F29 RID: 7977 RVA: 0x0005FD3F File Offset: 0x0005DF3F
		public CFHeader12Record()
		{
			base.CreateEmpty();
			this.futureHeader = new global::NPOI.HSSF.Record.Common.FtrHeader();
			this.futureHeader.RecordType = global::NPOI.HSSF.Record.CFHeader12Record.sid;
		}

		// Token: 0x06001F2A RID: 7978 RVA: 0x0005FD68 File Offset: 0x0005DF68
		public CFHeader12Record(global::NPOI.SS.Util.CellRangeAddress[] regions, int nRules) : base(regions, nRules)
		{
			this.futureHeader = new global::NPOI.HSSF.Record.Common.FtrHeader();
			this.futureHeader.RecordType = global::NPOI.HSSF.Record.CFHeader12Record.sid;
		}

		// Token: 0x06001F2B RID: 7979 RVA: 0x0005FD8D File Offset: 0x0005DF8D
		public CFHeader12Record(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.futureHeader = new global::NPOI.HSSF.Record.Common.FtrHeader(in1);
			base.Read(in1);
		}

		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x06001F2C RID: 7980 RVA: 0x0005FDA8 File Offset: 0x0005DFA8
		protected override string RecordName
		{
			get
			{
				return "CFHEADER12";
			}
		}

		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x06001F2D RID: 7981 RVA: 0x0005FDAF File Offset: 0x0005DFAF
		protected override int DataSize
		{
			get
			{
				return global::NPOI.HSSF.Record.Common.FtrHeader.GetDataSize() + base.DataSize;
			}
		}

		// Token: 0x06001F2E RID: 7982 RVA: 0x0005FDBD File Offset: 0x0005DFBD
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			this.futureHeader.AssociatedRange = base.EnclosingCellRange;
			this.futureHeader.Serialize(out1);
			base.Serialize(out1);
		}

		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x06001F2F RID: 7983 RVA: 0x0005FDE3 File Offset: 0x0005DFE3
		public override short Sid
		{
			get
			{
				return global::NPOI.HSSF.Record.CFHeader12Record.sid;
			}
		}

		// Token: 0x06001F30 RID: 7984 RVA: 0x0005FDEA File Offset: 0x0005DFEA
		public short GetFutureRecordType()
		{
			return this.futureHeader.RecordType;
		}

		// Token: 0x06001F31 RID: 7985 RVA: 0x0005FDF7 File Offset: 0x0005DFF7
		public global::NPOI.HSSF.Record.Common.FtrHeader GetFutureHeader()
		{
			return this.futureHeader;
		}

		// Token: 0x06001F32 RID: 7986 RVA: 0x0005FDFF File Offset: 0x0005DFFF
		public global::NPOI.SS.Util.CellRangeAddress GetAssociatedRange()
		{
			return this.futureHeader.AssociatedRange;
		}

		// Token: 0x06001F33 RID: 7987 RVA: 0x0005FE0C File Offset: 0x0005E00C
		public override object Clone()
		{
			global::NPOI.HSSF.Record.CFHeader12Record cfheader12Record = new global::NPOI.HSSF.Record.CFHeader12Record();
			cfheader12Record.futureHeader = (global::NPOI.HSSF.Record.Common.FtrHeader)this.futureHeader.Clone();
			base.CopyTo(cfheader12Record);
			return cfheader12Record;
		}

		// Token: 0x04000BCD RID: 3021
		public static short sid = 2169;

		// Token: 0x04000BCE RID: 3022
		private global::NPOI.HSSF.Record.Common.FtrHeader futureHeader;
	}
}
