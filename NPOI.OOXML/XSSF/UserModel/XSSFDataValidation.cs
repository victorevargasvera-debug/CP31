using System;
using System.Collections.Generic;
using System.Text;
using NPOI.OpenXmlFormats.Spreadsheet;
using NPOI.SS.UserModel;
using NPOI.SS.Util;

namespace NPOI.XSSF.UserModel
{
	// Token: 0x02000079 RID: 121
	public class XSSFDataValidation : global::NPOI.SS.UserModel.IDataValidation
	{
		// Token: 0x060005DF RID: 1503 RVA: 0x00015F7C File Offset: 0x0001417C
		static XSSFDataValidation()
		{
			global::NPOI.XSSF.UserModel.XSSFDataValidation.errorStyleMappings[2] = global::NPOI.OpenXmlFormats.Spreadsheet.ST_DataValidationErrorStyle.information;
			global::NPOI.XSSF.UserModel.XSSFDataValidation.errorStyleMappings[0] = global::NPOI.OpenXmlFormats.Spreadsheet.ST_DataValidationErrorStyle.stop;
			global::NPOI.XSSF.UserModel.XSSFDataValidation.errorStyleMappings[1] = global::NPOI.OpenXmlFormats.Spreadsheet.ST_DataValidationErrorStyle.warning;
			global::NPOI.XSSF.UserModel.XSSFDataValidation.operatorTypeMappings[0] = global::NPOI.OpenXmlFormats.Spreadsheet.ST_DataValidationOperator.between;
			global::NPOI.XSSF.UserModel.XSSFDataValidation.operatorTypeMappings[1] = global::NPOI.OpenXmlFormats.Spreadsheet.ST_DataValidationOperator.notBetween;
			global::NPOI.XSSF.UserModel.XSSFDataValidation.operatorTypeMappings[2] = global::NPOI.OpenXmlFormats.Spreadsheet.ST_DataValidationOperator.equal;
			global::NPOI.XSSF.UserModel.XSSFDataValidation.operatorTypeMappings[3] = global::NPOI.OpenXmlFormats.Spreadsheet.ST_DataValidationOperator.notEqual;
			global::NPOI.XSSF.UserModel.XSSFDataValidation.operatorTypeMappings[4] = global::NPOI.OpenXmlFormats.Spreadsheet.ST_DataValidationOperator.greaterThan;
			global::NPOI.XSSF.UserModel.XSSFDataValidation.operatorTypeMappings[6] = global::NPOI.OpenXmlFormats.Spreadsheet.ST_DataValidationOperator.greaterThanOrEqual;
			global::NPOI.XSSF.UserModel.XSSFDataValidation.operatorTypeMappings[5] = global::NPOI.OpenXmlFormats.Spreadsheet.ST_DataValidationOperator.lessThan;
			global::NPOI.XSSF.UserModel.XSSFDataValidation.operatorTypeMappings[7] = global::NPOI.OpenXmlFormats.Spreadsheet.ST_DataValidationOperator.lessThanOrEqual;
			foreach (global::System.Collections.Generic.KeyValuePair<int, global::NPOI.OpenXmlFormats.Spreadsheet.ST_DataValidationOperator> keyValuePair in global::NPOI.XSSF.UserModel.XSSFDataValidation.operatorTypeMappings)
			{
				global::NPOI.XSSF.UserModel.XSSFDataValidation.operatorTypeReverseMappings[keyValuePair.Value] = keyValuePair.Key;
			}
			global::NPOI.XSSF.UserModel.XSSFDataValidation.validationTypeMappings[7] = global::NPOI.OpenXmlFormats.Spreadsheet.ST_DataValidationType.custom;
			global::NPOI.XSSF.UserModel.XSSFDataValidation.validationTypeMappings[4] = global::NPOI.OpenXmlFormats.Spreadsheet.ST_DataValidationType.date;
			global::NPOI.XSSF.UserModel.XSSFDataValidation.validationTypeMappings[2] = global::NPOI.OpenXmlFormats.Spreadsheet.ST_DataValidationType.@decimal;
			global::NPOI.XSSF.UserModel.XSSFDataValidation.validationTypeMappings[3] = global::NPOI.OpenXmlFormats.Spreadsheet.ST_DataValidationType.list;
			global::NPOI.XSSF.UserModel.XSSFDataValidation.validationTypeMappings[0] = global::NPOI.OpenXmlFormats.Spreadsheet.ST_DataValidationType.none;
			global::NPOI.XSSF.UserModel.XSSFDataValidation.validationTypeMappings[6] = global::NPOI.OpenXmlFormats.Spreadsheet.ST_DataValidationType.textLength;
			global::NPOI.XSSF.UserModel.XSSFDataValidation.validationTypeMappings[5] = global::NPOI.OpenXmlFormats.Spreadsheet.ST_DataValidationType.time;
			global::NPOI.XSSF.UserModel.XSSFDataValidation.validationTypeMappings[1] = global::NPOI.OpenXmlFormats.Spreadsheet.ST_DataValidationType.whole;
			foreach (global::System.Collections.Generic.KeyValuePair<int, global::NPOI.OpenXmlFormats.Spreadsheet.ST_DataValidationType> keyValuePair2 in global::NPOI.XSSF.UserModel.XSSFDataValidation.validationTypeMappings)
			{
				global::NPOI.XSSF.UserModel.XSSFDataValidation.validationTypeReverseMappings[keyValuePair2.Value] = keyValuePair2.Key;
			}
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x00016148 File Offset: 0x00014348
		public XSSFDataValidation(global::NPOI.SS.Util.CellRangeAddressList regions, global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataValidation ctDataValidation) : this(global::NPOI.XSSF.UserModel.XSSFDataValidation.GetConstraint(ctDataValidation), regions, ctDataValidation)
		{
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x00016158 File Offset: 0x00014358
		public XSSFDataValidation(global::NPOI.XSSF.UserModel.XSSFDataValidationConstraint constraint, global::NPOI.SS.Util.CellRangeAddressList regions, global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataValidation ctDataValidation)
		{
			this.validationConstraint = constraint;
			this.ctDdataValidation = ctDataValidation;
			this.regions = regions;
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x00016175 File Offset: 0x00014375
		internal global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataValidation GetCTDataValidation()
		{
			return this.ctDdataValidation;
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x0001617D File Offset: 0x0001437D
		public void CreateErrorBox(string title, string text)
		{
			this.ctDdataValidation.errorTitle = title;
			this.ctDdataValidation.error = text;
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x00016197 File Offset: 0x00014397
		public void CreatePromptBox(string title, string text)
		{
			this.ctDdataValidation.promptTitle = title;
			this.ctDdataValidation.prompt = text;
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x060005E5 RID: 1509 RVA: 0x000161B1 File Offset: 0x000143B1
		// (set) Token: 0x060005E6 RID: 1510 RVA: 0x000161BE File Offset: 0x000143BE
		public bool EmptyCellAllowed
		{
			get
			{
				return this.ctDdataValidation.allowBlank;
			}
			set
			{
				this.ctDdataValidation.allowBlank = value;
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x060005E7 RID: 1511 RVA: 0x000161CC File Offset: 0x000143CC
		public string ErrorBoxText
		{
			get
			{
				return this.ctDdataValidation.error;
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x060005E8 RID: 1512 RVA: 0x000161D9 File Offset: 0x000143D9
		public string ErrorBoxTitle
		{
			get
			{
				return this.ctDdataValidation.errorTitle;
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x060005E9 RID: 1513 RVA: 0x000161E6 File Offset: 0x000143E6
		// (set) Token: 0x060005EA RID: 1514 RVA: 0x000161F3 File Offset: 0x000143F3
		public int ErrorStyle
		{
			get
			{
				return (int)this.ctDdataValidation.errorStyle;
			}
			set
			{
				this.ctDdataValidation.errorStyle = global::NPOI.XSSF.UserModel.XSSFDataValidation.errorStyleMappings[value];
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x060005EB RID: 1515 RVA: 0x0001620B File Offset: 0x0001440B
		public string PromptBoxText
		{
			get
			{
				return this.ctDdataValidation.prompt;
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x060005EC RID: 1516 RVA: 0x00016218 File Offset: 0x00014418
		public string PromptBoxTitle
		{
			get
			{
				return this.ctDdataValidation.promptTitle;
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x060005ED RID: 1517 RVA: 0x00016225 File Offset: 0x00014425
		// (set) Token: 0x060005EE RID: 1518 RVA: 0x00016232 File Offset: 0x00014432
		public bool ShowErrorBox
		{
			get
			{
				return this.ctDdataValidation.showErrorMessage;
			}
			set
			{
				this.ctDdataValidation.showErrorMessage = value;
			}
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x060005EF RID: 1519 RVA: 0x00016240 File Offset: 0x00014440
		// (set) Token: 0x060005F0 RID: 1520 RVA: 0x0001624D File Offset: 0x0001444D
		public bool ShowPromptBox
		{
			get
			{
				return this.ctDdataValidation.showInputMessage;
			}
			set
			{
				this.ctDdataValidation.showInputMessage = value;
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x060005F1 RID: 1521 RVA: 0x0001625B File Offset: 0x0001445B
		// (set) Token: 0x060005F2 RID: 1522 RVA: 0x0001626B File Offset: 0x0001446B
		public bool SuppressDropDownArrow
		{
			get
			{
				return !this.ctDdataValidation.showDropDown;
			}
			set
			{
				if (this.validationConstraint.GetValidationType() == 3)
				{
					this.ctDdataValidation.showDropDown = !value;
				}
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x060005F3 RID: 1523 RVA: 0x0001628A File Offset: 0x0001448A
		public global::NPOI.SS.UserModel.IDataValidationConstraint ValidationConstraint
		{
			get
			{
				return this.validationConstraint;
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x060005F4 RID: 1524 RVA: 0x00016292 File Offset: 0x00014492
		public global::NPOI.SS.Util.CellRangeAddressList Regions
		{
			get
			{
				return this.regions;
			}
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x0001629C File Offset: 0x0001449C
		public string PrettyPrint()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			foreach (global::NPOI.SS.Util.CellRangeAddress cellRangeAddress in this.regions.CellRangeAddresses)
			{
				stringBuilder.Append(cellRangeAddress.FormatAsString());
			}
			stringBuilder.Append(" => ");
			stringBuilder.Append(this.validationConstraint.PrettyPrint());
			return stringBuilder.ToString();
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x00016300 File Offset: 0x00014500
		private static global::NPOI.XSSF.UserModel.XSSFDataValidationConstraint GetConstraint(global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataValidation ctDataValidation)
		{
			string formula = ctDataValidation.formula1;
			string formula2 = ctDataValidation.formula2;
			global::NPOI.OpenXmlFormats.Spreadsheet.ST_DataValidationOperator @operator = ctDataValidation.@operator;
			global::NPOI.OpenXmlFormats.Spreadsheet.ST_DataValidationType type = ctDataValidation.type;
			int validationType = global::NPOI.XSSF.UserModel.XSSFDataValidation.validationTypeReverseMappings[type];
			int operator2 = global::NPOI.XSSF.UserModel.XSSFDataValidation.operatorTypeReverseMappings[@operator];
			return new global::NPOI.XSSF.UserModel.XSSFDataValidationConstraint(validationType, operator2, formula, formula2);
		}

		// Token: 0x040002BF RID: 703
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataValidation ctDdataValidation;

		// Token: 0x040002C0 RID: 704
		private global::NPOI.XSSF.UserModel.XSSFDataValidationConstraint validationConstraint;

		// Token: 0x040002C1 RID: 705
		private global::NPOI.SS.Util.CellRangeAddressList regions;

		// Token: 0x040002C2 RID: 706
		internal static global::System.Collections.Generic.Dictionary<int, global::NPOI.OpenXmlFormats.Spreadsheet.ST_DataValidationOperator> operatorTypeMappings = new global::System.Collections.Generic.Dictionary<int, global::NPOI.OpenXmlFormats.Spreadsheet.ST_DataValidationOperator>();

		// Token: 0x040002C3 RID: 707
		internal static global::System.Collections.Generic.Dictionary<global::NPOI.OpenXmlFormats.Spreadsheet.ST_DataValidationOperator, int> operatorTypeReverseMappings = new global::System.Collections.Generic.Dictionary<global::NPOI.OpenXmlFormats.Spreadsheet.ST_DataValidationOperator, int>();

		// Token: 0x040002C4 RID: 708
		internal static global::System.Collections.Generic.Dictionary<int, global::NPOI.OpenXmlFormats.Spreadsheet.ST_DataValidationType> validationTypeMappings = new global::System.Collections.Generic.Dictionary<int, global::NPOI.OpenXmlFormats.Spreadsheet.ST_DataValidationType>();

		// Token: 0x040002C5 RID: 709
		internal static global::System.Collections.Generic.Dictionary<global::NPOI.OpenXmlFormats.Spreadsheet.ST_DataValidationType, int> validationTypeReverseMappings = new global::System.Collections.Generic.Dictionary<global::NPOI.OpenXmlFormats.Spreadsheet.ST_DataValidationType, int>();

		// Token: 0x040002C6 RID: 710
		internal static global::System.Collections.Generic.Dictionary<int, global::NPOI.OpenXmlFormats.Spreadsheet.ST_DataValidationErrorStyle> errorStyleMappings = new global::System.Collections.Generic.Dictionary<int, global::NPOI.OpenXmlFormats.Spreadsheet.ST_DataValidationErrorStyle>();
	}
}
