using System;
using NPOI.OpenXmlFormats.Spreadsheet;
using NPOI.SS.Formula;
using NPOI.SS.Formula.PTG;
using NPOI.SS.UserModel;

namespace NPOI.XSSF.UserModel.Helpers
{
	// Token: 0x020000AB RID: 171
	public class XSSFFormulaUtils
	{
		// Token: 0x06000B0C RID: 2828 RVA: 0x00029646 File Offset: 0x00027846
		public XSSFFormulaUtils(global::NPOI.XSSF.UserModel.XSSFWorkbook wb)
		{
			this._wb = wb;
			this._fpwb = global::NPOI.XSSF.UserModel.XSSFEvaluationWorkbook.Create(this._wb);
		}

		// Token: 0x06000B0D RID: 2829 RVA: 0x00029668 File Offset: 0x00027868
		public void UpdateSheetName(int sheetIndex, string oldName, string newName)
		{
			int numberOfNames = this._wb.NumberOfNames;
			foreach (global::NPOI.SS.UserModel.IName name in this._wb.GetAllNames())
			{
				if (name.SheetIndex == -1 || name.SheetIndex == sheetIndex)
				{
					this.UpdateName(name, oldName, newName);
				}
			}
			foreach (global::NPOI.SS.UserModel.ISheet sheet in this._wb)
			{
				foreach (object obj in sheet)
				{
					foreach (global::NPOI.SS.UserModel.ICell cell in ((global::NPOI.SS.UserModel.IRow)obj))
					{
						if (cell.CellType == global::NPOI.SS.UserModel.CellType.Formula)
						{
							this.UpdateFormula((global::NPOI.XSSF.UserModel.XSSFCell)cell, oldName, newName);
						}
					}
				}
			}
		}

		// Token: 0x06000B0E RID: 2830 RVA: 0x0002979C File Offset: 0x0002799C
		private void UpdateFormula(global::NPOI.XSSF.UserModel.XSSFCell cell, string oldName, string newName)
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellFormula f = cell.GetCTCell().f;
			if (f != null)
			{
				string value = f.Value;
				if (value != null && value.Length > 0)
				{
					int sheetIndex = this._wb.GetSheetIndex(cell.Sheet);
					global::NPOI.SS.Formula.PTG.Ptg[] array = global::NPOI.SS.Formula.FormulaParser.Parse(value, this._fpwb, global::NPOI.SS.Formula.FormulaType.Cell, sheetIndex, -1);
					foreach (global::NPOI.SS.Formula.PTG.Ptg ptg in array)
					{
						this.UpdatePtg(ptg, oldName, newName);
					}
					string value2 = global::NPOI.SS.Formula.FormulaRenderer.ToFormulaString(this._fpwb, array);
					if (!value.Equals(value2))
					{
						f.Value = value2;
					}
				}
			}
		}

		// Token: 0x06000B0F RID: 2831 RVA: 0x00029834 File Offset: 0x00027A34
		private void UpdateName(global::NPOI.SS.UserModel.IName name, string oldName, string newName)
		{
			string refersToFormula = name.RefersToFormula;
			if (refersToFormula != null)
			{
				int sheetIndex = name.SheetIndex;
				global::NPOI.SS.Formula.PTG.Ptg[] array = global::NPOI.SS.Formula.FormulaParser.Parse(refersToFormula, this._fpwb, global::NPOI.SS.Formula.FormulaType.NamedRange, sheetIndex, -1);
				foreach (global::NPOI.SS.Formula.PTG.Ptg ptg in array)
				{
					this.UpdatePtg(ptg, oldName, newName);
				}
				string text = global::NPOI.SS.Formula.FormulaRenderer.ToFormulaString(this._fpwb, array);
				if (!refersToFormula.Equals(text))
				{
					name.RefersToFormula = text;
				}
			}
		}

		// Token: 0x06000B10 RID: 2832 RVA: 0x000298A8 File Offset: 0x00027AA8
		private void UpdatePtg(global::NPOI.SS.Formula.PTG.Ptg ptg, string oldName, string newName)
		{
			if (ptg is global::NPOI.SS.Formula.PTG.Pxg)
			{
				global::NPOI.SS.Formula.PTG.Pxg pxg = (global::NPOI.SS.Formula.PTG.Pxg)ptg;
				if (pxg.ExternalWorkbookNumber < 1)
				{
					if (pxg.SheetName != null && pxg.SheetName.Equals(oldName))
					{
						pxg.SheetName = newName;
					}
					if (pxg is global::NPOI.SS.Formula.PTG.Pxg3D)
					{
						global::NPOI.SS.Formula.PTG.Pxg3D pxg3D = (global::NPOI.SS.Formula.PTG.Pxg3D)pxg;
						if (pxg3D.LastSheetName != null && pxg3D.LastSheetName.Equals(oldName))
						{
							pxg3D.LastSheetName = newName;
						}
					}
				}
			}
		}

		// Token: 0x040003A9 RID: 937
		private global::NPOI.XSSF.UserModel.XSSFWorkbook _wb;

		// Token: 0x040003AA RID: 938
		private global::NPOI.XSSF.UserModel.XSSFEvaluationWorkbook _fpwb;
	}
}
