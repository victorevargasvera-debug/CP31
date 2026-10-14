using System;
using NPOI.SS.Formula;
using NPOI.SS.Formula.UDF;
using NPOI.SS.UserModel;

namespace NPOI.XSSF.UserModel
{
	// Token: 0x02000088 RID: 136
	public class XSSFFormulaEvaluator : global::NPOI.XSSF.UserModel.BaseXSSFFormulaEvaluator
	{
		// Token: 0x0600070E RID: 1806 RVA: 0x000182BE File Offset: 0x000164BE
		public XSSFFormulaEvaluator(global::NPOI.SS.UserModel.IWorkbook workbook) : this(workbook as global::NPOI.XSSF.UserModel.XSSFWorkbook, null, null)
		{
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x000182CE File Offset: 0x000164CE
		public XSSFFormulaEvaluator(global::NPOI.XSSF.UserModel.XSSFWorkbook workbook) : this(workbook, null, null)
		{
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x000182D9 File Offset: 0x000164D9
		private XSSFFormulaEvaluator(global::NPOI.XSSF.UserModel.XSSFWorkbook workbook, global::NPOI.SS.Formula.IStabilityClassifier stabilityClassifier, global::NPOI.SS.Formula.UDF.UDFFinder udfFinder) : this(workbook, new global::NPOI.SS.Formula.WorkbookEvaluator(global::NPOI.XSSF.UserModel.XSSFEvaluationWorkbook.Create(workbook), stabilityClassifier, udfFinder))
		{
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x000182EF File Offset: 0x000164EF
		protected XSSFFormulaEvaluator(global::NPOI.XSSF.UserModel.XSSFWorkbook workbook, global::NPOI.SS.Formula.WorkbookEvaluator bookEvaluator) : base(bookEvaluator)
		{
			this._book = workbook;
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x000182FF File Offset: 0x000164FF
		public static global::NPOI.XSSF.UserModel.XSSFFormulaEvaluator Create(global::NPOI.XSSF.UserModel.XSSFWorkbook workbook, global::NPOI.SS.Formula.IStabilityClassifier stabilityClassifier, global::NPOI.SS.Formula.UDF.UDFFinder udfFinder)
		{
			return new global::NPOI.XSSF.UserModel.XSSFFormulaEvaluator(workbook, stabilityClassifier, udfFinder);
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x00018309 File Offset: 0x00016509
		public static void EvaluateAllFormulaCells(global::NPOI.XSSF.UserModel.XSSFWorkbook wb)
		{
			global::NPOI.SS.Formula.BaseFormulaEvaluator.EvaluateAllFormulaCells(wb);
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x00018311 File Offset: 0x00016511
		public override void EvaluateAll()
		{
			global::NPOI.SS.Formula.BaseFormulaEvaluator.EvaluateAllFormulaCells(this._book, this);
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x0001831F File Offset: 0x0001651F
		protected override global::NPOI.SS.Formula.IEvaluationCell ToEvaluationCell(global::NPOI.SS.UserModel.ICell cell)
		{
			if (!(cell is global::NPOI.XSSF.UserModel.XSSFCell))
			{
				throw new global::System.ArgumentException("Unexpected type of cell: " + cell.GetType().Name + ". Only XSSFCells can be evaluated.");
			}
			return new global::NPOI.XSSF.UserModel.XSSFEvaluationCell((global::NPOI.XSSF.UserModel.XSSFCell)cell);
		}

		// Token: 0x040002E2 RID: 738
		private global::NPOI.XSSF.UserModel.XSSFWorkbook _book;
	}
}
