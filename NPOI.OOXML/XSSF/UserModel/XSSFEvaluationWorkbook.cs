using System;
using NPOI.SS.Formula;
using NPOI.SS.Formula.PTG;
using NPOI.SS.UserModel;

namespace NPOI.XSSF.UserModel
{
	// Token: 0x02000080 RID: 128
	public class XSSFEvaluationWorkbook : global::NPOI.XSSF.UserModel.BaseXSSFEvaluationWorkbook
	{
		// Token: 0x060006B7 RID: 1719 RVA: 0x00017478 File Offset: 0x00015678
		public static global::NPOI.XSSF.UserModel.XSSFEvaluationWorkbook Create(global::NPOI.SS.UserModel.IWorkbook book)
		{
			if (book == null)
			{
				return null;
			}
			return new global::NPOI.XSSF.UserModel.XSSFEvaluationWorkbook(book as global::NPOI.XSSF.UserModel.XSSFWorkbook);
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x0001748A File Offset: 0x0001568A
		protected XSSFEvaluationWorkbook(global::NPOI.XSSF.UserModel.XSSFWorkbook book) : base(book)
		{
		}

		// Token: 0x060006B9 RID: 1721 RVA: 0x00017493 File Offset: 0x00015693
		public override void ClearAllCachedResultValues()
		{
			base.ClearAllCachedResultValues();
			this._sheetCache = null;
		}

		// Token: 0x060006BA RID: 1722 RVA: 0x000174A4 File Offset: 0x000156A4
		public override int GetSheetIndex(global::NPOI.SS.Formula.IEvaluationSheet evalSheet)
		{
			global::NPOI.XSSF.UserModel.XSSFSheet xssfsheet = ((global::NPOI.XSSF.UserModel.XSSFEvaluationSheet)evalSheet).GetXSSFSheet();
			return this._uBook.GetSheetIndex(xssfsheet);
		}

		// Token: 0x060006BB RID: 1723 RVA: 0x000174CC File Offset: 0x000156CC
		public override global::NPOI.SS.Formula.IEvaluationSheet GetSheet(int sheetIndex)
		{
			if (this._sheetCache == null)
			{
				int numberOfSheets = this._uBook.NumberOfSheets;
				this._sheetCache = new global::NPOI.XSSF.UserModel.XSSFEvaluationSheet[numberOfSheets];
				for (int i = 0; i < numberOfSheets; i++)
				{
					this._sheetCache[i] = new global::NPOI.XSSF.UserModel.XSSFEvaluationSheet(this._uBook.GetSheetAt(i));
				}
			}
			if (sheetIndex < 0 || sheetIndex >= this._sheetCache.Length)
			{
				this._uBook.GetSheetAt(sheetIndex);
			}
			return this._sheetCache[sheetIndex];
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x00017544 File Offset: 0x00015744
		public override global::NPOI.SS.Formula.PTG.Ptg[] GetFormulaTokens(global::NPOI.SS.Formula.IEvaluationCell evalCell)
		{
			global::NPOI.XSSF.UserModel.XSSFCell xssfcell = ((global::NPOI.XSSF.UserModel.XSSFEvaluationCell)evalCell).GetXSSFCell();
			int sheetIndex = this._uBook.GetSheetIndex(xssfcell.Sheet);
			int rowIndex = xssfcell.RowIndex;
			return global::NPOI.SS.Formula.FormulaParser.Parse(xssfcell.GetCellFormula(this), this, global::NPOI.SS.Formula.FormulaType.Cell, sheetIndex, rowIndex);
		}

		// Token: 0x040002D8 RID: 728
		private global::NPOI.XSSF.UserModel.XSSFEvaluationSheet[] _sheetCache;
	}
}
