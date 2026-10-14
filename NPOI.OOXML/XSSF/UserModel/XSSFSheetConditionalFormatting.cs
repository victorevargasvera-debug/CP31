using System;
using NPOI.OpenXmlFormats.Spreadsheet;
using NPOI.SS;
using NPOI.SS.UserModel;
using NPOI.SS.Util;

namespace NPOI.XSSF.UserModel
{
	// Token: 0x0200009F RID: 159
	public class XSSFSheetConditionalFormatting : global::NPOI.SS.UserModel.ISheetConditionalFormatting
	{
		// Token: 0x06000996 RID: 2454 RVA: 0x00022A82 File Offset: 0x00020C82
		internal XSSFSheetConditionalFormatting(global::NPOI.XSSF.UserModel.XSSFSheet sheet)
		{
			this._sheet = sheet;
		}

		// Token: 0x06000997 RID: 2455 RVA: 0x00022A94 File Offset: 0x00020C94
		public global::NPOI.SS.UserModel.IConditionalFormattingRule CreateConditionalFormattingRule(global::NPOI.SS.UserModel.ComparisonOperator comparisonOperation, string formula1, string formula2)
		{
			global::NPOI.XSSF.UserModel.XSSFConditionalFormattingRule xssfconditionalFormattingRule = new global::NPOI.XSSF.UserModel.XSSFConditionalFormattingRule(this._sheet);
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_CfRule ctcfRule = xssfconditionalFormattingRule.GetCTCfRule();
			ctcfRule.AddFormula(formula1);
			if (formula2 != null)
			{
				ctcfRule.AddFormula(formula2);
			}
			ctcfRule.type = global::NPOI.OpenXmlFormats.Spreadsheet.ST_CfType.cellIs;
			global::NPOI.OpenXmlFormats.Spreadsheet.ST_ConditionalFormattingOperator value;
			switch (comparisonOperation)
			{
			case global::NPOI.SS.UserModel.ComparisonOperator.Between:
				value = global::NPOI.OpenXmlFormats.Spreadsheet.ST_ConditionalFormattingOperator.between;
				break;
			case global::NPOI.SS.UserModel.ComparisonOperator.NotBetween:
				value = global::NPOI.OpenXmlFormats.Spreadsheet.ST_ConditionalFormattingOperator.notBetween;
				break;
			case global::NPOI.SS.UserModel.ComparisonOperator.Equal:
				value = global::NPOI.OpenXmlFormats.Spreadsheet.ST_ConditionalFormattingOperator.equal;
				break;
			case global::NPOI.SS.UserModel.ComparisonOperator.NotEqual:
				value = global::NPOI.OpenXmlFormats.Spreadsheet.ST_ConditionalFormattingOperator.notEqual;
				break;
			case global::NPOI.SS.UserModel.ComparisonOperator.GreaterThan:
				value = global::NPOI.OpenXmlFormats.Spreadsheet.ST_ConditionalFormattingOperator.greaterThan;
				break;
			case global::NPOI.SS.UserModel.ComparisonOperator.LessThan:
				value = global::NPOI.OpenXmlFormats.Spreadsheet.ST_ConditionalFormattingOperator.lessThan;
				break;
			case global::NPOI.SS.UserModel.ComparisonOperator.GreaterThanOrEqual:
				value = global::NPOI.OpenXmlFormats.Spreadsheet.ST_ConditionalFormattingOperator.greaterThanOrEqual;
				break;
			case global::NPOI.SS.UserModel.ComparisonOperator.LessThanOrEqual:
				value = global::NPOI.OpenXmlFormats.Spreadsheet.ST_ConditionalFormattingOperator.lessThanOrEqual;
				break;
			default:
				throw new global::System.ArgumentException("Unknown comparison operator: " + comparisonOperation.ToString());
			}
			ctcfRule.@operator = new global::NPOI.OpenXmlFormats.Spreadsheet.ST_ConditionalFormattingOperator?(value);
			return xssfconditionalFormattingRule;
		}

		// Token: 0x06000998 RID: 2456 RVA: 0x00022B40 File Offset: 0x00020D40
		public global::NPOI.SS.UserModel.IConditionalFormattingRule CreateConditionalFormattingRule(global::NPOI.SS.UserModel.ComparisonOperator comparisonOperation, string formula)
		{
			return this.CreateConditionalFormattingRule(comparisonOperation, formula, null);
		}

		// Token: 0x06000999 RID: 2457 RVA: 0x00022B4B File Offset: 0x00020D4B
		public global::NPOI.SS.UserModel.IConditionalFormattingRule CreateConditionalFormattingRule(string formula)
		{
			global::NPOI.XSSF.UserModel.XSSFConditionalFormattingRule xssfconditionalFormattingRule = new global::NPOI.XSSF.UserModel.XSSFConditionalFormattingRule(this._sheet);
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_CfRule ctcfRule = xssfconditionalFormattingRule.GetCTCfRule();
			ctcfRule.AddFormula(formula);
			ctcfRule.type = global::NPOI.OpenXmlFormats.Spreadsheet.ST_CfType.expression;
			return xssfconditionalFormattingRule;
		}

		// Token: 0x0600099A RID: 2458 RVA: 0x00022B6B File Offset: 0x00020D6B
		public global::NPOI.SS.UserModel.IConditionalFormattingRule CreateConditionalFormattingRule(global::NPOI.SS.UserModel.IconSet iconSet)
		{
			global::NPOI.XSSF.UserModel.XSSFConditionalFormattingRule xssfconditionalFormattingRule = new global::NPOI.XSSF.UserModel.XSSFConditionalFormattingRule(this._sheet);
			xssfconditionalFormattingRule.CreateMultiStateFormatting(iconSet);
			return xssfconditionalFormattingRule;
		}

		// Token: 0x0600099B RID: 2459 RVA: 0x00022B80 File Offset: 0x00020D80
		public global::NPOI.XSSF.UserModel.XSSFConditionalFormattingRule CreateConditionalFormattingRule(global::NPOI.XSSF.UserModel.XSSFColor color)
		{
			global::NPOI.XSSF.UserModel.XSSFConditionalFormattingRule xssfconditionalFormattingRule = new global::NPOI.XSSF.UserModel.XSSFConditionalFormattingRule(this._sheet);
			xssfconditionalFormattingRule.CreateDataBarFormatting(color);
			return xssfconditionalFormattingRule;
		}

		// Token: 0x0600099C RID: 2460 RVA: 0x00022B95 File Offset: 0x00020D95
		public global::NPOI.SS.UserModel.IConditionalFormattingRule CreateConditionalFormattingRule(global::NPOI.SS.UserModel.ExtendedColor color)
		{
			return this.CreateConditionalFormattingRule((global::NPOI.XSSF.UserModel.XSSFColor)color);
		}

		// Token: 0x0600099D RID: 2461 RVA: 0x00022BA3 File Offset: 0x00020DA3
		public global::NPOI.SS.UserModel.IConditionalFormattingRule CreateConditionalFormattingColorScaleRule()
		{
			global::NPOI.XSSF.UserModel.XSSFConditionalFormattingRule xssfconditionalFormattingRule = new global::NPOI.XSSF.UserModel.XSSFConditionalFormattingRule(this._sheet);
			xssfconditionalFormattingRule.CreateColorScaleFormatting();
			return xssfconditionalFormattingRule;
		}

		// Token: 0x0600099E RID: 2462 RVA: 0x00022BB8 File Offset: 0x00020DB8
		public int AddConditionalFormatting(global::NPOI.SS.Util.CellRangeAddress[] regions, global::NPOI.SS.UserModel.IConditionalFormattingRule[] cfRules)
		{
			if (regions == null)
			{
				throw new global::System.ArgumentException("regions must not be null");
			}
			for (int i = 0; i < regions.Length; i++)
			{
				regions[i].Validate(global::NPOI.SS.SpreadsheetVersion.EXCEL2007);
			}
			if (cfRules == null)
			{
				throw new global::System.ArgumentException("cfRules must not be null");
			}
			if (cfRules.Length == 0)
			{
				throw new global::System.ArgumentException("cfRules must not be empty");
			}
			if (cfRules.Length > 3)
			{
				throw new global::System.ArgumentException("Number of rules must not exceed 3");
			}
			global::NPOI.SS.Util.CellRangeAddress[] array = global::NPOI.SS.Util.CellRangeUtil.MergeCellRanges(regions);
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_ConditionalFormatting ct_ConditionalFormatting = this._sheet.GetCTWorksheet().AddNewConditionalFormatting();
			string text = string.Empty;
			foreach (global::NPOI.SS.Util.CellRangeAddress cellRangeAddress in array)
			{
				if (text.Length == 0)
				{
					text = cellRangeAddress.FormatAsString();
				}
				else
				{
					text = text + " " + cellRangeAddress.FormatAsString();
				}
			}
			ct_ConditionalFormatting.sqref = text;
			int num = 1;
			foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_ConditionalFormatting ct_ConditionalFormatting2 in this._sheet.GetCTWorksheet().conditionalFormatting)
			{
				num += ct_ConditionalFormatting2.sizeOfCfRuleArray();
			}
			foreach (global::NPOI.XSSF.UserModel.XSSFConditionalFormattingRule xssfconditionalFormattingRule in cfRules)
			{
				xssfconditionalFormattingRule.GetCTCfRule().priority = num++;
				ct_ConditionalFormatting.AddNewCfRule().Set(xssfconditionalFormattingRule.GetCTCfRule());
			}
			return this._sheet.GetCTWorksheet().SizeOfConditionalFormattingArray() - 1;
		}

		// Token: 0x0600099F RID: 2463 RVA: 0x00022D34 File Offset: 0x00020F34
		public int AddConditionalFormatting(global::NPOI.SS.Util.CellRangeAddress[] regions, global::NPOI.SS.UserModel.IConditionalFormattingRule rule1)
		{
			global::NPOI.XSSF.UserModel.XSSFConditionalFormattingRule[] array;
			if (rule1 != null)
			{
				(array = new global::NPOI.XSSF.UserModel.XSSFConditionalFormattingRule[1])[0] = (global::NPOI.XSSF.UserModel.XSSFConditionalFormattingRule)rule1;
			}
			else
			{
				array = null;
			}
			global::NPOI.SS.UserModel.IConditionalFormattingRule[] cfRules = array;
			return this.AddConditionalFormatting(regions, cfRules);
		}

		// Token: 0x060009A0 RID: 2464 RVA: 0x00022D60 File Offset: 0x00020F60
		public int AddConditionalFormatting(global::NPOI.SS.Util.CellRangeAddress[] regions, global::NPOI.SS.UserModel.IConditionalFormattingRule rule1, global::NPOI.SS.UserModel.IConditionalFormattingRule rule2)
		{
			global::NPOI.SS.UserModel.IConditionalFormattingRule[] array2;
			if (rule1 != null)
			{
				global::NPOI.XSSF.UserModel.XSSFConditionalFormattingRule[] array = new global::NPOI.XSSF.UserModel.XSSFConditionalFormattingRule[2];
				array[0] = (global::NPOI.XSSF.UserModel.XSSFConditionalFormattingRule)rule1;
				array2 = array;
				array[1] = (global::NPOI.XSSF.UserModel.XSSFConditionalFormattingRule)rule2;
			}
			else
			{
				array2 = null;
			}
			global::NPOI.SS.UserModel.IConditionalFormattingRule[] cfRules = array2;
			return this.AddConditionalFormatting(regions, cfRules);
		}

		// Token: 0x060009A1 RID: 2465 RVA: 0x00022D94 File Offset: 0x00020F94
		public int AddConditionalFormatting(global::NPOI.SS.UserModel.IConditionalFormatting cf)
		{
			global::NPOI.XSSF.UserModel.XSSFConditionalFormatting xssfconditionalFormatting = (global::NPOI.XSSF.UserModel.XSSFConditionalFormatting)cf;
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Worksheet ctworksheet = this._sheet.GetCTWorksheet();
			ctworksheet.AddNewConditionalFormatting().Set(xssfconditionalFormatting.GetCTConditionalFormatting());
			return ctworksheet.SizeOfConditionalFormattingArray() - 1;
		}

		// Token: 0x060009A2 RID: 2466 RVA: 0x00022DCC File Offset: 0x00020FCC
		public global::NPOI.SS.UserModel.IConditionalFormatting GetConditionalFormattingAt(int index)
		{
			this.CheckIndex(index);
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_ConditionalFormatting conditionalFormattingArray = this._sheet.GetCTWorksheet().GetConditionalFormattingArray(index);
			return new global::NPOI.XSSF.UserModel.XSSFConditionalFormatting(this._sheet, conditionalFormattingArray);
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x060009A3 RID: 2467 RVA: 0x00022DFE File Offset: 0x00020FFE
		public int NumConditionalFormattings
		{
			get
			{
				return this._sheet.GetCTWorksheet().SizeOfConditionalFormattingArray();
			}
		}

		// Token: 0x060009A4 RID: 2468 RVA: 0x00022E10 File Offset: 0x00021010
		public void RemoveConditionalFormatting(int index)
		{
			this.CheckIndex(index);
			this._sheet.GetCTWorksheet().conditionalFormatting.RemoveAt(index);
		}

		// Token: 0x060009A5 RID: 2469 RVA: 0x00022E30 File Offset: 0x00021030
		private void CheckIndex(int index)
		{
			int numConditionalFormattings = this.NumConditionalFormattings;
			if (index < 0 || index >= numConditionalFormattings)
			{
				throw new global::System.ArgumentException(string.Concat(new string[]
				{
					"Specified CF index ",
					index.ToString(),
					" is outside the allowable range (0..",
					(numConditionalFormattings - 1).ToString(),
					")"
				}));
			}
		}

		// Token: 0x04000361 RID: 865
		protected static string CF_EXT_2009_NS_X14 = "http://schemas.microsoft.com/office/spreadsheetml/2009/9/main";

		// Token: 0x04000362 RID: 866
		private global::NPOI.XSSF.UserModel.XSSFSheet _sheet;
	}
}
