using System;

namespace NPOI.SS.Formula.PTG
{
	// Token: 0x020000F2 RID: 242
	public class SharedFormula
	{
		// Token: 0x0600081D RID: 2077 RVA: 0x00016670 File Offset: 0x00014870
		public SharedFormula(global::NPOI.SS.SpreadsheetVersion ssVersion)
		{
			this._columnWrappingMask = ssVersion.LastColumnIndex;
			this._rowWrappingMask = ssVersion.LastRowIndex;
		}

		// Token: 0x0600081E RID: 2078 RVA: 0x00016690 File Offset: 0x00014890
		public global::NPOI.SS.Formula.PTG.Ptg[] ConvertSharedFormulas(global::NPOI.SS.Formula.PTG.Ptg[] ptgs, int formulaRow, int formulaColumn)
		{
			global::NPOI.SS.Formula.PTG.Ptg[] array = new global::NPOI.SS.Formula.PTG.Ptg[ptgs.Length];
			for (int i = 0; i < ptgs.Length; i++)
			{
				global::NPOI.SS.Formula.PTG.Ptg ptg = ptgs[i];
				byte ptgClass = byte.MaxValue;
				if (!ptg.IsBaseToken)
				{
					ptgClass = ptg.PtgClass;
				}
				if (ptg is global::NPOI.SS.Formula.PTG.RefPtgBase)
				{
					global::NPOI.SS.Formula.PTG.RefPtgBase refPtgBase = (global::NPOI.SS.Formula.PTG.RefPtgBase)ptg;
					ptg = new global::NPOI.SS.Formula.PTG.RefPtg(this.FixupRelativeRow(formulaRow, refPtgBase.Row, refPtgBase.IsRowRelative), this.FixupRelativeColumn(formulaColumn, refPtgBase.Column, refPtgBase.IsColRelative), refPtgBase.IsRowRelative, refPtgBase.IsColRelative);
					ptg.PtgClass = ptgClass;
				}
				else if (ptg is global::NPOI.SS.Formula.PTG.AreaPtgBase)
				{
					global::NPOI.SS.Formula.PTG.AreaPtgBase areaPtgBase = (global::NPOI.SS.Formula.PTG.AreaPtgBase)ptg;
					ptg = new global::NPOI.SS.Formula.PTG.AreaPtg(this.FixupRelativeRow(formulaRow, areaPtgBase.FirstRow, areaPtgBase.IsFirstRowRelative), this.FixupRelativeRow(formulaRow, areaPtgBase.LastRow, areaPtgBase.IsLastRowRelative), this.FixupRelativeColumn(formulaColumn, areaPtgBase.FirstColumn, areaPtgBase.IsFirstColRelative), this.FixupRelativeColumn(formulaColumn, areaPtgBase.LastColumn, areaPtgBase.IsLastColRelative), areaPtgBase.IsFirstRowRelative, areaPtgBase.IsLastRowRelative, areaPtgBase.IsFirstColRelative, areaPtgBase.IsLastColRelative);
					ptg.PtgClass = ptgClass;
				}
				else if (ptg is global::NPOI.SS.Formula.PTG.OperandPtg)
				{
					ptg = ((global::NPOI.SS.Formula.PTG.OperandPtg)ptg).Copy();
				}
				array[i] = ptg;
			}
			return array;
		}

		// Token: 0x0600081F RID: 2079 RVA: 0x000167D8 File Offset: 0x000149D8
		private int FixupRelativeColumn(int currentcolumn, int column, bool relative)
		{
			if (relative)
			{
				return column + currentcolumn & this._columnWrappingMask;
			}
			return column;
		}

		// Token: 0x06000820 RID: 2080 RVA: 0x000167E9 File Offset: 0x000149E9
		private int FixupRelativeRow(int currentrow, int row, bool relative)
		{
			if (relative)
			{
				return row + currentrow & this._rowWrappingMask;
			}
			return row;
		}

		// Token: 0x0400043E RID: 1086
		private int _columnWrappingMask;

		// Token: 0x0400043F RID: 1087
		private int _rowWrappingMask;
	}
}
