using System;
using NPOI.Util;

namespace NPOI.SS.Formula.PTG
{
	// Token: 0x02000113 RID: 275
	public class MemFuncPtg : global::NPOI.SS.Formula.PTG.OperandPtg
	{
		// Token: 0x06000922 RID: 2338 RVA: 0x000187E7 File Offset: 0x000169E7
		public MemFuncPtg(global::NPOI.Util.ILittleEndianInput in1) : this(in1.ReadUShort())
		{
		}

		// Token: 0x06000923 RID: 2339 RVA: 0x000187F5 File Offset: 0x000169F5
		public MemFuncPtg(int subExprLen)
		{
			this.field_1_len_ref_subexpression = subExprLen;
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x06000924 RID: 2340 RVA: 0x000169FF File Offset: 0x00014BFF
		public override int Size
		{
			get
			{
				return 3;
			}
		}

		// Token: 0x06000925 RID: 2341 RVA: 0x00018804 File Offset: 0x00016A04
		public override void Write(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteByte((int)(41 + base.PtgClass));
			out1.WriteShort(this.field_1_len_ref_subexpression);
		}

		// Token: 0x06000926 RID: 2342 RVA: 0x00018757 File Offset: 0x00016957
		public override string ToFormulaString()
		{
			return "";
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x06000927 RID: 2343 RVA: 0x00006EB4 File Offset: 0x000050B4
		public override byte DefaultOperandClass
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x06000928 RID: 2344 RVA: 0x00018821 File Offset: 0x00016A21
		public int NumberOfOperands
		{
			get
			{
				return this.field_1_len_ref_subexpression;
			}
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x06000929 RID: 2345 RVA: 0x00018821 File Offset: 0x00016A21
		public int LenRefSubexpression
		{
			get
			{
				return this.field_1_len_ref_subexpression;
			}
		}

		// Token: 0x040004B3 RID: 1203
		public const byte sid = 41;

		// Token: 0x040004B4 RID: 1204
		private int field_1_len_ref_subexpression;
	}
}
