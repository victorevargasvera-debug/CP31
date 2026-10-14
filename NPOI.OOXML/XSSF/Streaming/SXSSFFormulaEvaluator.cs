using System;
using System.Collections.Generic;
using NPOI.SS.Formula;
using NPOI.SS.Formula.UDF;
using NPOI.SS.UserModel;
using NPOI.Util;
using NPOI.XSSF.UserModel;

namespace NPOI.XSSF.Streaming
{
	// Token: 0x020000CA RID: 202
	public class SXSSFFormulaEvaluator : global::NPOI.XSSF.UserModel.BaseXSSFFormulaEvaluator
	{
		// Token: 0x06000C9E RID: 3230 RVA: 0x0002E013 File Offset: 0x0002C213
		public SXSSFFormulaEvaluator(global::NPOI.XSSF.Streaming.SXSSFWorkbook workbook) : this(workbook, null, null)
		{
		}

		// Token: 0x06000C9F RID: 3231 RVA: 0x0002E01E File Offset: 0x0002C21E
		private SXSSFFormulaEvaluator(global::NPOI.XSSF.Streaming.SXSSFWorkbook workbook, global::NPOI.SS.Formula.IStabilityClassifier stabilityClassifier, global::NPOI.SS.Formula.UDF.UDFFinder udfFinder) : this(workbook, new global::NPOI.SS.Formula.WorkbookEvaluator(global::NPOI.XSSF.Streaming.SXSSFEvaluationWorkbook.Create(workbook), stabilityClassifier, udfFinder))
		{
		}

		// Token: 0x06000CA0 RID: 3232 RVA: 0x0002E034 File Offset: 0x0002C234
		private SXSSFFormulaEvaluator(global::NPOI.XSSF.Streaming.SXSSFWorkbook workbook, global::NPOI.SS.Formula.WorkbookEvaluator bookEvaluator) : base(bookEvaluator)
		{
			this.wb = workbook;
		}

		// Token: 0x06000CA1 RID: 3233 RVA: 0x0002E044 File Offset: 0x0002C244
		public static global::NPOI.XSSF.Streaming.SXSSFFormulaEvaluator Create(global::NPOI.XSSF.Streaming.SXSSFWorkbook workbook, global::NPOI.SS.Formula.IStabilityClassifier stabilityClassifier, global::NPOI.SS.Formula.UDF.UDFFinder udfFinder)
		{
			return new global::NPOI.XSSF.Streaming.SXSSFFormulaEvaluator(workbook, stabilityClassifier, udfFinder);
		}

		// Token: 0x06000CA2 RID: 3234 RVA: 0x0002E04E File Offset: 0x0002C24E
		protected override global::NPOI.SS.Formula.IEvaluationCell ToEvaluationCell(global::NPOI.SS.UserModel.ICell cell)
		{
			if (!(cell is global::NPOI.XSSF.Streaming.SXSSFCell))
			{
				string str = "Unexpected type of cell: ";
				global::System.Type type = cell.GetType();
				throw new global::System.ArgumentException(str + ((type != null) ? type.ToString() : null) + ". Only SXSSFCells can be evaluated.");
			}
			return new global::NPOI.XSSF.Streaming.SXSSFEvaluationCell((global::NPOI.XSSF.Streaming.SXSSFCell)cell);
		}

		// Token: 0x06000CA3 RID: 3235 RVA: 0x0002E08C File Offset: 0x0002C28C
		public static void EvaluateAllFormulaCells(global::NPOI.XSSF.Streaming.SXSSFWorkbook wb, bool skipOutOfWindow)
		{
			global::NPOI.XSSF.Streaming.SXSSFFormulaEvaluator sxssfformulaEvaluator = new global::NPOI.XSSF.Streaming.SXSSFFormulaEvaluator(wb);
			using (global::System.Collections.Generic.IEnumerator<global::NPOI.SS.UserModel.ISheet> enumerator = wb.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (((global::NPOI.XSSF.Streaming.SXSSFSheet)enumerator.Current).AllRowsFlushed)
					{
						throw new global::NPOI.XSSF.Streaming.SheetsFlushedException();
					}
				}
			}
			foreach (global::NPOI.SS.UserModel.ISheet sheet in wb)
			{
				int lastFlushedRowNumber = ((global::NPOI.XSSF.Streaming.SXSSFSheet)sheet).LastFlushedRowNumber;
				if (lastFlushedRowNumber > -1)
				{
					if (!skipOutOfWindow)
					{
						throw new global::NPOI.XSSF.Streaming.RowFlushedException(0);
					}
					global::NPOI.XSSF.Streaming.SXSSFFormulaEvaluator.logger.Log(3, "Rows up to " + lastFlushedRowNumber.ToString() + " have already been flushed, skipping");
				}
				foreach (object obj in sheet)
				{
					foreach (global::NPOI.SS.UserModel.ICell cell in ((global::NPOI.SS.UserModel.IRow)obj))
					{
						if (cell.CellType == global::NPOI.SS.UserModel.CellType.Formula)
						{
							sxssfformulaEvaluator.EvaluateFormulaCell(cell);
						}
					}
				}
			}
		}

		// Token: 0x06000CA4 RID: 3236 RVA: 0x0002E1DC File Offset: 0x0002C3DC
		public override void EvaluateAll()
		{
			global::NPOI.XSSF.Streaming.SXSSFFormulaEvaluator.EvaluateAllFormulaCells((global::NPOI.XSSF.Streaming.SXSSFWorkbook)this.wb, false);
		}

		// Token: 0x040003E9 RID: 1001
		private static global::NPOI.Util.POILogger logger = global::NPOI.Util.POILogFactory.GetLogger(typeof(global::NPOI.XSSF.Streaming.SXSSFFormulaEvaluator));

		// Token: 0x040003EA RID: 1002
		private global::NPOI.SS.UserModel.IWorkbook wb;
	}
}
