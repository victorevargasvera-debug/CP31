using System;
using NPOI.SS.Formula;
using NPOI.SS.Formula.PTG;
using NPOI.XSSF.UserModel;

namespace NPOI.XSSF.Streaming
{
	// Token: 0x020000C9 RID: 201
	public class SXSSFEvaluationWorkbook : global::NPOI.XSSF.UserModel.BaseXSSFEvaluationWorkbook
	{
		// Token: 0x06000C99 RID: 3225 RVA: 0x0002DF7A File Offset: 0x0002C17A
		public static global::NPOI.XSSF.Streaming.SXSSFEvaluationWorkbook Create(global::NPOI.XSSF.Streaming.SXSSFWorkbook book)
		{
			if (book == null)
			{
				return null;
			}
			return new global::NPOI.XSSF.Streaming.SXSSFEvaluationWorkbook(book);
		}

		// Token: 0x06000C9A RID: 3226 RVA: 0x0002DF87 File Offset: 0x0002C187
		private SXSSFEvaluationWorkbook(global::NPOI.XSSF.Streaming.SXSSFWorkbook book) : base(book.XssfWorkbook)
		{
			this._xBook = book;
		}

		// Token: 0x06000C9B RID: 3227 RVA: 0x0002DF9C File Offset: 0x0002C19C
		public override int GetSheetIndex(global::NPOI.SS.Formula.IEvaluationSheet evalSheet)
		{
			global::NPOI.XSSF.Streaming.SXSSFSheet sxssfsheet = ((global::NPOI.XSSF.Streaming.SXSSFEvaluationSheet)evalSheet).GetSXSSFSheet();
			return this._xBook.GetSheetIndex(sxssfsheet);
		}

		// Token: 0x06000C9C RID: 3228 RVA: 0x0002DFC1 File Offset: 0x0002C1C1
		public override global::NPOI.SS.Formula.IEvaluationSheet GetSheet(int sheetIndex)
		{
			return new global::NPOI.XSSF.Streaming.SXSSFEvaluationSheet(this._xBook.GetSheetAt(sheetIndex) as global::NPOI.XSSF.Streaming.SXSSFSheet);
		}

		// Token: 0x06000C9D RID: 3229 RVA: 0x0002DFDC File Offset: 0x0002C1DC
		public override global::NPOI.SS.Formula.PTG.Ptg[] GetFormulaTokens(global::NPOI.SS.Formula.IEvaluationCell evalCell)
		{
			global::NPOI.XSSF.Streaming.SXSSFCell sxssfcell = ((global::NPOI.XSSF.Streaming.SXSSFEvaluationCell)evalCell).GetSXSSFCell();
			return global::NPOI.SS.Formula.FormulaParser.Parse(sxssfcell.CellFormula, this, global::NPOI.SS.Formula.FormulaType.Cell, this._xBook.GetSheetIndex(sxssfcell.Sheet));
		}

		// Token: 0x040003E8 RID: 1000
		private global::NPOI.XSSF.Streaming.SXSSFWorkbook _xBook;
	}
}
