using System;
using NPOI.OpenXmlFormats.Spreadsheet;
using NPOI.SS.UserModel;
using NPOI.SS.Util;

namespace NPOI.XSSF.UserModel
{
	// Token: 0x0200007B RID: 123
	public class XSSFDataValidationHelper : global::NPOI.SS.UserModel.IDataValidationHelper
	{
		// Token: 0x06000609 RID: 1545 RVA: 0x00002FA4 File Offset: 0x000011A4
		public XSSFDataValidationHelper(global::NPOI.XSSF.UserModel.XSSFSheet xssfSheet)
		{
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x0001675F File Offset: 0x0001495F
		public global::NPOI.SS.UserModel.IDataValidationConstraint CreateDateConstraint(int operatorType, string formula1, string formula2, string dateFormat)
		{
			return new global::NPOI.XSSF.UserModel.XSSFDataValidationConstraint(4, operatorType, formula1, formula2);
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x0001676A File Offset: 0x0001496A
		public global::NPOI.SS.UserModel.IDataValidationConstraint CreateDecimalConstraint(int operatorType, string formula1, string formula2)
		{
			return new global::NPOI.XSSF.UserModel.XSSFDataValidationConstraint(2, operatorType, formula1, formula2);
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x00016775 File Offset: 0x00014975
		public global::NPOI.SS.UserModel.IDataValidationConstraint CreateExplicitListConstraint(string[] listOfValues)
		{
			return new global::NPOI.XSSF.UserModel.XSSFDataValidationConstraint(listOfValues);
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x0001677D File Offset: 0x0001497D
		public global::NPOI.SS.UserModel.IDataValidationConstraint CreateFormulaListConstraint(string listFormula)
		{
			return new global::NPOI.XSSF.UserModel.XSSFDataValidationConstraint(3, listFormula);
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x00016786 File Offset: 0x00014986
		public global::NPOI.SS.UserModel.IDataValidationConstraint CreateNumericConstraint(int validationType, int operatorType, string formula1, string formula2)
		{
			if (validationType == 1)
			{
				return this.CreateintConstraint(operatorType, formula1, formula2);
			}
			if (validationType == 2)
			{
				return this.CreateDecimalConstraint(operatorType, formula1, formula2);
			}
			if (validationType == 6)
			{
				return this.CreateTextLengthConstraint(operatorType, formula1, formula2);
			}
			return null;
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x000167B6 File Offset: 0x000149B6
		public global::NPOI.SS.UserModel.IDataValidationConstraint CreateintConstraint(int operatorType, string formula1, string formula2)
		{
			return new global::NPOI.XSSF.UserModel.XSSFDataValidationConstraint(1, operatorType, formula1, formula2);
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x000167C1 File Offset: 0x000149C1
		public global::NPOI.SS.UserModel.IDataValidationConstraint CreateTextLengthConstraint(int operatorType, string formula1, string formula2)
		{
			return new global::NPOI.XSSF.UserModel.XSSFDataValidationConstraint(6, operatorType, formula1, formula2);
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x000167CC File Offset: 0x000149CC
		public global::NPOI.SS.UserModel.IDataValidationConstraint CreateTimeConstraint(int operatorType, string formula1, string formula2)
		{
			return new global::NPOI.XSSF.UserModel.XSSFDataValidationConstraint(5, operatorType, formula1, formula2);
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x000167D7 File Offset: 0x000149D7
		public global::NPOI.SS.UserModel.IDataValidationConstraint CreateCustomConstraint(string formula)
		{
			return new global::NPOI.XSSF.UserModel.XSSFDataValidationConstraint(7, formula);
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x000167E0 File Offset: 0x000149E0
		public global::NPOI.SS.UserModel.IDataValidation CreateValidation(global::NPOI.SS.UserModel.IDataValidationConstraint constraint, global::NPOI.SS.Util.CellRangeAddressList cellRangeAddressList)
		{
			global::NPOI.XSSF.UserModel.XSSFDataValidationConstraint constraint2 = (global::NPOI.XSSF.UserModel.XSSFDataValidationConstraint)constraint;
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataValidation ct_DataValidation = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataValidation();
			int validationType = constraint.GetValidationType();
			switch (validationType)
			{
			case 0:
				ct_DataValidation.type = global::NPOI.OpenXmlFormats.Spreadsheet.ST_DataValidationType.none;
				break;
			case 1:
				ct_DataValidation.type = global::NPOI.OpenXmlFormats.Spreadsheet.ST_DataValidationType.whole;
				break;
			case 2:
				ct_DataValidation.type = global::NPOI.OpenXmlFormats.Spreadsheet.ST_DataValidationType.@decimal;
				break;
			case 3:
				ct_DataValidation.type = global::NPOI.OpenXmlFormats.Spreadsheet.ST_DataValidationType.list;
				ct_DataValidation.formula1 = constraint.Formula1;
				break;
			case 4:
				ct_DataValidation.type = global::NPOI.OpenXmlFormats.Spreadsheet.ST_DataValidationType.date;
				break;
			case 5:
				ct_DataValidation.type = global::NPOI.OpenXmlFormats.Spreadsheet.ST_DataValidationType.time;
				break;
			case 6:
				ct_DataValidation.type = global::NPOI.OpenXmlFormats.Spreadsheet.ST_DataValidationType.textLength;
				break;
			case 7:
				ct_DataValidation.type = global::NPOI.OpenXmlFormats.Spreadsheet.ST_DataValidationType.custom;
				break;
			default:
				ct_DataValidation.type = global::NPOI.OpenXmlFormats.Spreadsheet.ST_DataValidationType.none;
				break;
			}
			if (validationType != 0 && validationType != 3)
			{
				ct_DataValidation.@operator = global::NPOI.OpenXmlFormats.Spreadsheet.ST_DataValidationOperator.between;
				if (global::NPOI.XSSF.UserModel.XSSFDataValidation.operatorTypeMappings.ContainsKey(constraint.Operator))
				{
					ct_DataValidation.@operator = global::NPOI.XSSF.UserModel.XSSFDataValidation.operatorTypeMappings[constraint.Operator];
				}
				if (constraint.Formula1 != null)
				{
					ct_DataValidation.formula1 = constraint.Formula1;
				}
				if (constraint.Formula2 != null)
				{
					ct_DataValidation.formula2 = constraint.Formula2;
				}
			}
			global::NPOI.SS.Util.CellRangeAddress[] cellRangeAddresses = cellRangeAddressList.CellRangeAddresses;
			string text = string.Empty;
			foreach (global::NPOI.SS.Util.CellRangeAddress cellRangeAddress in cellRangeAddresses)
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
			ct_DataValidation.sqref = text;
			ct_DataValidation.allowBlank = true;
			ct_DataValidation.errorStyle = global::NPOI.OpenXmlFormats.Spreadsheet.ST_DataValidationErrorStyle.stop;
			return new global::NPOI.XSSF.UserModel.XSSFDataValidation(constraint2, cellRangeAddressList, ct_DataValidation);
		}
	}
}
