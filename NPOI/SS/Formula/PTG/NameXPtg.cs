using System;
using NPOI.Util;

namespace NPOI.SS.Formula.PTG
{
	// Token: 0x02000117 RID: 279
	[global::System.Serializable]
	public class NameXPtg : global::NPOI.SS.Formula.PTG.OperandPtg, global::NPOI.SS.Formula.WorkbookDependentFormula
	{
		// Token: 0x0600093C RID: 2364 RVA: 0x000188F3 File Offset: 0x00016AF3
		private NameXPtg(int sheetRefIndex, int nameNumber, int reserved)
		{
			this._sheetRefIndex = sheetRefIndex;
			this._nameNumber = nameNumber;
			this._reserved = reserved;
		}

		// Token: 0x0600093D RID: 2365 RVA: 0x00018910 File Offset: 0x00016B10
		public NameXPtg(int sheetRefIndex, int nameIndex) : this(sheetRefIndex, nameIndex + 1, 0)
		{
		}

		// Token: 0x0600093E RID: 2366 RVA: 0x0001891D File Offset: 0x00016B1D
		public NameXPtg(global::NPOI.Util.ILittleEndianInput in1) : this(in1.ReadUShort(), in1.ReadUShort(), in1.ReadUShort())
		{
		}

		// Token: 0x0600093F RID: 2367 RVA: 0x00018937 File Offset: 0x00016B37
		public override void Write(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteByte((int)(57 + base.PtgClass));
			out1.WriteShort(this._sheetRefIndex);
			out1.WriteShort(this._nameNumber);
			out1.WriteShort(this._reserved);
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x06000940 RID: 2368 RVA: 0x00017F33 File Offset: 0x00016133
		public override int Size
		{
			get
			{
				return 7;
			}
		}

		// Token: 0x06000941 RID: 2369 RVA: 0x0001896C File Offset: 0x00016B6C
		public string ToFormulaString(global::NPOI.SS.Formula.IFormulaRenderingWorkbook book)
		{
			return book.ResolveNameXText(this);
		}

		// Token: 0x06000942 RID: 2370 RVA: 0x00016D1A File Offset: 0x00014F1A
		public override string ToFormulaString()
		{
			throw new global::System.NotImplementedException("3D references need a workbook to determine formula text");
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x06000943 RID: 2371 RVA: 0x000162C8 File Offset: 0x000144C8
		public override byte DefaultOperandClass
		{
			get
			{
				return 32;
			}
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x06000944 RID: 2372 RVA: 0x00018975 File Offset: 0x00016B75
		public int SheetRefIndex
		{
			get
			{
				return this._sheetRefIndex;
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06000945 RID: 2373 RVA: 0x0001897D File Offset: 0x00016B7D
		public int NameIndex
		{
			get
			{
				return this._nameNumber - 1;
			}
		}

		// Token: 0x040004BE RID: 1214
		public const short sid = 57;

		// Token: 0x040004BF RID: 1215
		private const int SIZE = 7;

		// Token: 0x040004C0 RID: 1216
		private int _sheetRefIndex;

		// Token: 0x040004C1 RID: 1217
		private int _nameNumber;

		// Token: 0x040004C2 RID: 1218
		private int _reserved;
	}
}
