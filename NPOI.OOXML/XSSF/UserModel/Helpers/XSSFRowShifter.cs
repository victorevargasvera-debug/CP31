using System;
using System.Collections.Generic;
using NPOI.OpenXmlFormats.Spreadsheet;
using NPOI.SS.Formula;
using NPOI.SS.Formula.PTG;
using NPOI.SS.UserModel;
using NPOI.SS.UserModel.Helpers;
using NPOI.SS.Util;

namespace NPOI.XSSF.UserModel.Helpers
{
	// Token: 0x020000AE RID: 174
	public class XSSFRowShifter : global::NPOI.SS.UserModel.Helpers.RowShifter
	{
		// Token: 0x06000B1C RID: 2844 RVA: 0x00029E2A File Offset: 0x0002802A
		public XSSFRowShifter(global::NPOI.XSSF.UserModel.XSSFSheet sh) : base(sh)
		{
			this.sheet = sh;
		}

		// Token: 0x06000B1D RID: 2845 RVA: 0x00029E3A File Offset: 0x0002803A
		[global::System.Obsolete("deprecated POI 3.15 beta 2. Use ShiftMergedRegions(int, int, int) instead.")]
		public global::System.Collections.Generic.List<global::NPOI.SS.Util.CellRangeAddress> ShiftMerged(int startRow, int endRow, int n)
		{
			return base.ShiftMergedRegions(startRow, endRow, n);
		}

		// Token: 0x06000B1E RID: 2846 RVA: 0x00029E48 File Offset: 0x00028048
		public override void UpdateNamedRanges(global::NPOI.SS.Formula.FormulaShifter shifter)
		{
			global::NPOI.SS.UserModel.IWorkbook workbook = this.sheet.Workbook;
			global::NPOI.XSSF.UserModel.XSSFEvaluationWorkbook xssfevaluationWorkbook = global::NPOI.XSSF.UserModel.XSSFEvaluationWorkbook.Create(workbook);
			foreach (global::NPOI.SS.UserModel.IName name in workbook.GetAllNames())
			{
				string refersToFormula = name.RefersToFormula;
				int sheetIndex = name.SheetIndex;
				global::NPOI.SS.Formula.PTG.Ptg[] ptgs = global::NPOI.SS.Formula.FormulaParser.Parse(refersToFormula, xssfevaluationWorkbook, global::NPOI.SS.Formula.FormulaType.NamedRange, sheetIndex, -1);
				if (shifter.AdjustFormula(ptgs, sheetIndex))
				{
					string refersToFormula2 = global::NPOI.SS.Formula.FormulaRenderer.ToFormulaString(xssfevaluationWorkbook, ptgs);
					name.RefersToFormula = refersToFormula2;
				}
			}
		}

		// Token: 0x06000B1F RID: 2847 RVA: 0x00029EDC File Offset: 0x000280DC
		public override void UpdateFormulas(global::NPOI.SS.Formula.FormulaShifter shifter)
		{
			this.UpdateSheetFormulas(this.sheet, shifter);
			foreach (global::NPOI.SS.UserModel.ISheet sheet in this.sheet.Workbook)
			{
				global::NPOI.XSSF.UserModel.XSSFSheet xssfsheet = (global::NPOI.XSSF.UserModel.XSSFSheet)sheet;
				if (this.sheet != xssfsheet)
				{
					this.UpdateSheetFormulas(xssfsheet, shifter);
				}
			}
		}

		// Token: 0x06000B20 RID: 2848 RVA: 0x00029F4C File Offset: 0x0002814C
		private void UpdateSheetFormulas(global::NPOI.SS.UserModel.ISheet sh, global::NPOI.SS.Formula.FormulaShifter Shifter)
		{
			foreach (object obj in sh)
			{
				global::NPOI.XSSF.UserModel.XSSFRow row = (global::NPOI.XSSF.UserModel.XSSFRow)((global::NPOI.SS.UserModel.IRow)obj);
				this.UpdateRowFormulas(row, Shifter);
			}
		}

		// Token: 0x06000B21 RID: 2849 RVA: 0x00029FA8 File Offset: 0x000281A8
		public override void UpdateRowFormulas(global::NPOI.SS.UserModel.IRow row, global::NPOI.SS.Formula.FormulaShifter Shifter)
		{
			global::NPOI.XSSF.UserModel.XSSFSheet xssfsheet = (global::NPOI.XSSF.UserModel.XSSFSheet)row.Sheet;
			foreach (global::NPOI.SS.UserModel.ICell cell in row)
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cell ctcell = ((global::NPOI.XSSF.UserModel.XSSFCell)cell).GetCTCell();
				if (ctcell.IsSetF())
				{
					global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellFormula f = ctcell.f;
					string value = f.Value;
					if (value.Length > 0)
					{
						string text = global::NPOI.XSSF.UserModel.Helpers.XSSFRowShifter.ShiftFormula(row, value, Shifter);
						if (text != null)
						{
							f.Value = text;
							if (f.t == global::NPOI.OpenXmlFormats.Spreadsheet.ST_CellFormulaType.shared)
							{
								int si = (int)f.si;
								xssfsheet.GetSharedFormula(si).Value = text;
							}
						}
					}
					if (f.isSetRef())
					{
						string @ref = f.@ref;
						string text2 = global::NPOI.XSSF.UserModel.Helpers.XSSFRowShifter.ShiftFormula(row, @ref, Shifter);
						if (text2 != null)
						{
							f.@ref = text2;
						}
					}
				}
			}
		}

		// Token: 0x06000B22 RID: 2850 RVA: 0x0002A084 File Offset: 0x00028284
		private static string ShiftFormula(global::NPOI.SS.UserModel.IRow row, string formula, global::NPOI.SS.Formula.FormulaShifter Shifter)
		{
			global::NPOI.SS.UserModel.ISheet sheet = row.Sheet;
			global::NPOI.SS.UserModel.IWorkbook workbook = sheet.Workbook;
			int sheetIndex = workbook.GetSheetIndex(sheet);
			global::NPOI.XSSF.UserModel.XSSFEvaluationWorkbook xssfevaluationWorkbook = global::NPOI.XSSF.UserModel.XSSFEvaluationWorkbook.Create(workbook);
			string result;
			try
			{
				global::NPOI.SS.Formula.PTG.Ptg[] ptgs = global::NPOI.SS.Formula.FormulaParser.Parse(formula, xssfevaluationWorkbook, global::NPOI.SS.Formula.FormulaType.Cell, sheetIndex, -1);
				string text = null;
				if (Shifter.AdjustFormula(ptgs, sheetIndex))
				{
					text = global::NPOI.SS.Formula.FormulaRenderer.ToFormulaString(xssfevaluationWorkbook, ptgs);
				}
				result = text;
			}
			catch (global::NPOI.SS.Formula.FormulaParseException arg)
			{
				global::System.Console.WriteLine("Error shifting formula on row {0}, {1}", row.RowNum, arg);
				result = formula;
			}
			return result;
		}

		// Token: 0x06000B23 RID: 2851 RVA: 0x0002A104 File Offset: 0x00028304
		public override void UpdateConditionalFormatting(global::NPOI.SS.Formula.FormulaShifter Shifter)
		{
			global::NPOI.XSSF.UserModel.XSSFSheet xssfsheet = (global::NPOI.XSSF.UserModel.XSSFSheet)this.sheet;
			global::NPOI.XSSF.UserModel.XSSFWorkbook xssfworkbook = xssfsheet.Workbook as global::NPOI.XSSF.UserModel.XSSFWorkbook;
			int sheetIndex = xssfworkbook.GetSheetIndex(this.sheet);
			global::NPOI.XSSF.UserModel.XSSFEvaluationWorkbook xssfevaluationWorkbook = global::NPOI.XSSF.UserModel.XSSFEvaluationWorkbook.Create(xssfworkbook);
			global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_ConditionalFormatting> conditionalFormatting = xssfsheet.GetCTWorksheet().conditionalFormatting;
			int i = conditionalFormatting.Count - 1;
			while (i >= 0)
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_ConditionalFormatting ct_ConditionalFormatting = conditionalFormatting[i];
				global::System.Collections.Generic.List<global::NPOI.SS.Util.CellRangeAddress> list = new global::System.Collections.Generic.List<global::NPOI.SS.Util.CellRangeAddress>();
				string[] array = ct_ConditionalFormatting.sqref.ToString().Split(new char[]
				{
					' '
				});
				for (int j = 0; j < array.Length; j++)
				{
					list.Add(global::NPOI.SS.Util.CellRangeAddress.ValueOf(array[j]));
				}
				bool flag = false;
				global::System.Collections.Generic.List<global::NPOI.SS.Util.CellRangeAddress> list2 = new global::System.Collections.Generic.List<global::NPOI.SS.Util.CellRangeAddress>();
				for (int k = 0; k < list.Count; k++)
				{
					global::NPOI.SS.Util.CellRangeAddress cellRangeAddress = list[k];
					global::NPOI.SS.Util.CellRangeAddress cellRangeAddress2 = global::NPOI.XSSF.UserModel.Helpers.XSSFRowShifter.ShiftRange(Shifter, cellRangeAddress, sheetIndex);
					if (cellRangeAddress2 == null)
					{
						flag = true;
					}
					else
					{
						list2.Add(cellRangeAddress2);
						if (cellRangeAddress2 != cellRangeAddress)
						{
							flag = true;
						}
					}
				}
				if (!flag)
				{
					goto IL_164;
				}
				if (list2.Count != 0)
				{
					string text = string.Empty;
					foreach (global::NPOI.SS.Util.CellRangeAddress cellRangeAddress3 in list2)
					{
						if (text.Length == 0)
						{
							text = cellRangeAddress3.FormatAsString();
						}
						else
						{
							text = text + " " + cellRangeAddress3.FormatAsString();
						}
					}
					ct_ConditionalFormatting.sqref = text;
					goto IL_164;
				}
				conditionalFormatting.RemoveAt(i);
				IL_1E5:
				i--;
				continue;
				IL_164:
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_CfRule ct_CfRule in ct_ConditionalFormatting.cfRule)
				{
					global::System.Collections.Generic.List<string> formula = ct_CfRule.formula;
					for (int l = 0; l < formula.Count; l++)
					{
						global::NPOI.SS.Formula.PTG.Ptg[] ptgs = global::NPOI.SS.Formula.FormulaParser.Parse(formula[l], xssfevaluationWorkbook, global::NPOI.SS.Formula.FormulaType.Cell, sheetIndex, -1);
						if (Shifter.AdjustFormula(ptgs, sheetIndex))
						{
							string value = global::NPOI.SS.Formula.FormulaRenderer.ToFormulaString(xssfevaluationWorkbook, ptgs);
							formula[l] = value;
						}
					}
				}
				goto IL_1E5;
			}
		}

		// Token: 0x06000B24 RID: 2852 RVA: 0x0002A320 File Offset: 0x00028520
		public override void UpdateHyperlinks(global::NPOI.SS.Formula.FormulaShifter shifter)
		{
			int sheetIndex = ((global::NPOI.XSSF.UserModel.XSSFSheet)this.sheet).GetWorkbook().GetSheetIndex(this.sheet);
			foreach (global::NPOI.SS.UserModel.IHyperlink hyperlink in this.sheet.GetHyperlinkList())
			{
				global::NPOI.XSSF.UserModel.XSSFHyperlink xssfhyperlink = hyperlink as global::NPOI.XSSF.UserModel.XSSFHyperlink;
				global::NPOI.SS.Util.CellRangeAddress cellRangeAddress = global::NPOI.SS.Util.CellRangeAddress.ValueOf(xssfhyperlink.CellRef);
				global::NPOI.SS.Util.CellRangeAddress cellRangeAddress2 = global::NPOI.XSSF.UserModel.Helpers.XSSFRowShifter.ShiftRange(shifter, cellRangeAddress, sheetIndex);
				if (cellRangeAddress2 != null && cellRangeAddress2 != cellRangeAddress)
				{
					xssfhyperlink.SetCellReference(cellRangeAddress2.FormatAsString());
				}
			}
		}

		// Token: 0x06000B25 RID: 2853 RVA: 0x0002A3C0 File Offset: 0x000285C0
		private static global::NPOI.SS.Util.CellRangeAddress ShiftRange(global::NPOI.SS.Formula.FormulaShifter Shifter, global::NPOI.SS.Util.CellRangeAddress cra, int currentExternSheetIx)
		{
			global::NPOI.SS.Formula.PTG.AreaPtg areaPtg = new global::NPOI.SS.Formula.PTG.AreaPtg(cra.FirstRow, cra.LastRow, cra.FirstColumn, cra.LastColumn, false, false, false, false);
			global::NPOI.SS.Formula.PTG.Ptg[] array = new global::NPOI.SS.Formula.PTG.Ptg[]
			{
				areaPtg
			};
			if (!Shifter.AdjustFormula(array, currentExternSheetIx))
			{
				return cra;
			}
			global::NPOI.SS.Formula.PTG.Ptg ptg = array[0];
			if (ptg is global::NPOI.SS.Formula.PTG.AreaPtg)
			{
				global::NPOI.SS.Formula.PTG.AreaPtg areaPtg2 = (global::NPOI.SS.Formula.PTG.AreaPtg)ptg;
				return new global::NPOI.SS.Util.CellRangeAddress(areaPtg2.FirstRow, areaPtg2.LastRow, areaPtg2.FirstColumn, areaPtg2.LastColumn);
			}
			if (ptg is global::NPOI.SS.Formula.PTG.AreaErrPtg)
			{
				return null;
			}
			throw new global::System.InvalidOperationException("Unexpected Shifted ptg class (" + ptg.GetType().Name + ")");
		}
	}
}
