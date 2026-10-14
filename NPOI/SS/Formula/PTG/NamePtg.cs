using System;
using NPOI.Util;

namespace NPOI.SS.Formula.PTG
{
	// Token: 0x02000116 RID: 278
	[global::System.Serializable]
	public class NamePtg : global::NPOI.SS.Formula.PTG.OperandPtg, global::NPOI.SS.Formula.WorkbookDependentFormula
	{
		// Token: 0x06000934 RID: 2356 RVA: 0x00018886 File Offset: 0x00016A86
		public NamePtg(int nameIndex)
		{
			this.field_1_label_index = 1 + nameIndex;
		}

		// Token: 0x06000935 RID: 2357 RVA: 0x00018897 File Offset: 0x00016A97
		public NamePtg(global::NPOI.Util.ILittleEndianInput in1)
		{
			this.field_1_label_index = (int)in1.ReadShort();
			this.field_2_zero = in1.ReadShort();
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x06000936 RID: 2358 RVA: 0x000188B7 File Offset: 0x00016AB7
		public int Index
		{
			get
			{
				return this.field_1_label_index - 1;
			}
		}

		// Token: 0x06000937 RID: 2359 RVA: 0x000188C1 File Offset: 0x00016AC1
		public override void Write(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteByte((int)(35 + base.PtgClass));
			out1.WriteShort(this.field_1_label_index);
			out1.WriteShort((int)this.field_2_zero);
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06000938 RID: 2360 RVA: 0x000181D5 File Offset: 0x000163D5
		public override int Size
		{
			get
			{
				return 5;
			}
		}

		// Token: 0x06000939 RID: 2361 RVA: 0x000188EA File Offset: 0x00016AEA
		public string ToFormulaString(global::NPOI.SS.Formula.IFormulaRenderingWorkbook book)
		{
			return book.GetNameText(this);
		}

		// Token: 0x0600093A RID: 2362 RVA: 0x00016D1A File Offset: 0x00014F1A
		public override string ToFormulaString()
		{
			throw new global::System.NotImplementedException("3D references need a workbook to determine formula text");
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x0600093B RID: 2363 RVA: 0x00006EB4 File Offset: 0x000050B4
		public override byte DefaultOperandClass
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x040004BA RID: 1210
		public const short sid = 35;

		// Token: 0x040004BB RID: 1211
		private const int SIZE = 5;

		// Token: 0x040004BC RID: 1212
		private int field_1_label_index;

		// Token: 0x040004BD RID: 1213
		private short field_2_zero;
	}
}
