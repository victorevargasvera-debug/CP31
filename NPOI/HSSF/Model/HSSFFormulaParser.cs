using System;
using NPOI.HSSF.UserModel;
using NPOI.SS.Formula;
using NPOI.SS.Formula.PTG;

namespace NPOI.HSSF.Model
{
	// Token: 0x02000331 RID: 817
	public class HSSFFormulaParser
	{
		// Token: 0x06001735 RID: 5941 RVA: 0x000453C6 File Offset: 0x000435C6
		private static global::NPOI.SS.Formula.IFormulaParsingWorkbook CreateParsingWorkbook(global::NPOI.HSSF.UserModel.HSSFWorkbook book)
		{
			return global::NPOI.HSSF.UserModel.HSSFEvaluationWorkbook.Create(book);
		}

		// Token: 0x06001736 RID: 5942 RVA: 0x0000253E File Offset: 0x0000073E
		private HSSFFormulaParser()
		{
		}

		// Token: 0x06001737 RID: 5943 RVA: 0x000453CE File Offset: 0x000435CE
		public static global::NPOI.SS.Formula.PTG.Ptg[] Parse(string formula, global::NPOI.HSSF.UserModel.HSSFWorkbook workbook)
		{
			return global::NPOI.HSSF.Model.HSSFFormulaParser.Parse(formula, workbook, global::NPOI.SS.Formula.FormulaType.Cell);
		}

		// Token: 0x06001738 RID: 5944 RVA: 0x000453D8 File Offset: 0x000435D8
		public static global::NPOI.SS.Formula.PTG.Ptg[] Parse(string formula, global::NPOI.HSSF.UserModel.HSSFWorkbook workbook, global::NPOI.SS.Formula.FormulaType formulaType)
		{
			return global::NPOI.SS.Formula.FormulaParser.Parse(formula, global::NPOI.HSSF.Model.HSSFFormulaParser.CreateParsingWorkbook(workbook), formulaType, -1);
		}

		// Token: 0x06001739 RID: 5945 RVA: 0x000453E8 File Offset: 0x000435E8
		public static global::NPOI.SS.Formula.PTG.Ptg[] Parse(string formula, global::NPOI.HSSF.UserModel.HSSFWorkbook workbook, global::NPOI.SS.Formula.FormulaType formulaType, int sheetIndex)
		{
			return global::NPOI.SS.Formula.FormulaParser.Parse(formula, global::NPOI.HSSF.Model.HSSFFormulaParser.CreateParsingWorkbook(workbook), formulaType, sheetIndex, -1);
		}

		// Token: 0x0600173A RID: 5946 RVA: 0x000453F9 File Offset: 0x000435F9
		public static string ToFormulaString(global::NPOI.HSSF.UserModel.HSSFWorkbook book, global::NPOI.SS.Formula.PTG.Ptg[] ptgs)
		{
			return global::NPOI.SS.Formula.FormulaRenderer.ToFormulaString(global::NPOI.HSSF.UserModel.HSSFEvaluationWorkbook.Create(book), ptgs);
		}
	}
}
