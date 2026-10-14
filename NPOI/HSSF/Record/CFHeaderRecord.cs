using System;
using NPOI.SS.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003B5 RID: 949
	public class CFHeaderRecord : global::NPOI.HSSF.Record.CFHeaderBase, global::System.ICloneable
	{
		// Token: 0x060020EC RID: 8428 RVA: 0x00064918 File Offset: 0x00062B18
		public CFHeaderRecord()
		{
			base.CreateEmpty();
		}

		// Token: 0x060020ED RID: 8429 RVA: 0x00064926 File Offset: 0x00062B26
		public CFHeaderRecord(global::NPOI.SS.Util.CellRangeAddress[] regions, int nRules) : base(regions, nRules)
		{
		}

		// Token: 0x060020EE RID: 8430 RVA: 0x00064930 File Offset: 0x00062B30
		public CFHeaderRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			base.Read(in1);
		}

		// Token: 0x17000733 RID: 1843
		// (get) Token: 0x060020EF RID: 8431 RVA: 0x0006493F File Offset: 0x00062B3F
		protected override string RecordName
		{
			get
			{
				return "CFHEADER";
			}
		}

		// Token: 0x17000734 RID: 1844
		// (get) Token: 0x060020F0 RID: 8432 RVA: 0x00064946 File Offset: 0x00062B46
		public override short Sid
		{
			get
			{
				return global::NPOI.HSSF.Record.CFHeaderRecord.sid;
			}
		}

		// Token: 0x060020F1 RID: 8433 RVA: 0x00064950 File Offset: 0x00062B50
		public override object Clone()
		{
			global::NPOI.HSSF.Record.CFHeaderRecord result = new global::NPOI.HSSF.Record.CFHeaderRecord();
			base.CopyTo(result);
			return result;
		}

		// Token: 0x04000CD1 RID: 3281
		public static short sid = 432;
	}
}
