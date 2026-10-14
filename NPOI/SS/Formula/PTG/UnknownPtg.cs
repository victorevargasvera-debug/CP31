using System;
using NPOI.HSSF.Record;
using NPOI.Util;

namespace NPOI.SS.Formula.PTG
{
	// Token: 0x0200012E RID: 302
	public class UnknownPtg : global::NPOI.SS.Formula.PTG.Ptg
	{
		// Token: 0x060009EC RID: 2540 RVA: 0x00019A70 File Offset: 0x00017C70
		public UnknownPtg()
		{
		}

		// Token: 0x060009ED RID: 2541 RVA: 0x00019A70 File Offset: 0x00017C70
		public UnknownPtg(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x060009EE RID: 2542 RVA: 0x00008875 File Offset: 0x00006A75
		public override bool IsBaseToken
		{
			get
			{
				return true;
			}
		}

		// Token: 0x060009EF RID: 2543 RVA: 0x00019A7F File Offset: 0x00017C7F
		public override void Write(global::NPOI.Util.ILittleEndianOutput out1)
		{
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x060009F0 RID: 2544 RVA: 0x00019A81 File Offset: 0x00017C81
		public override int Size
		{
			get
			{
				return (int)this.size;
			}
		}

		// Token: 0x060009F1 RID: 2545 RVA: 0x00019A89 File Offset: 0x00017C89
		public override string ToFormulaString()
		{
			return "UNKNOWN";
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x060009F2 RID: 2546 RVA: 0x000162C8 File Offset: 0x000144C8
		public override byte DefaultOperandClass
		{
			get
			{
				return 32;
			}
		}

		// Token: 0x060009F3 RID: 2547 RVA: 0x00019A90 File Offset: 0x00017C90
		public override object Clone()
		{
			return new global::NPOI.SS.Formula.PTG.UnknownPtg();
		}

		// Token: 0x04000501 RID: 1281
		private short size = 1;
	}
}
