using System;
using System.Text;
using System.Text.RegularExpressions;
using NPOI.OpenXmlFormats.Spreadsheet;
using NPOI.SS.UserModel;
using NPOI.Util;

namespace NPOI.XSSF.UserModel
{
	// Token: 0x0200007A RID: 122
	public class XSSFDataValidationConstraint : global::NPOI.SS.UserModel.IDataValidationConstraint
	{
		// Token: 0x060005F7 RID: 1527 RVA: 0x0001634A File Offset: 0x0001454A
		public XSSFDataValidationConstraint(string[] explicitListOfValues)
		{
			if (explicitListOfValues == null || explicitListOfValues.Length == 0)
			{
				throw new global::System.ArgumentException("List validation with explicit values must specify at least one value");
			}
			this.validationType = 3;
			this.ExplicitListValues = explicitListOfValues;
			this.Validate();
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x00016386 File Offset: 0x00014586
		public XSSFDataValidationConstraint(int validationType, string formula1)
		{
			this.Formula1 = formula1;
			this.validationType = validationType;
			this.Validate();
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x000163B0 File Offset: 0x000145B0
		public XSSFDataValidationConstraint(int validationType, int operator1, string formula1)
		{
			this.Formula1 = formula1;
			this.validationType = validationType;
			this.operator1 = operator1;
			this.Validate();
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x000163E4 File Offset: 0x000145E4
		public XSSFDataValidationConstraint(int validationType, int operator1, string formula1, string formula2)
		{
			this.Formula1 = formula1;
			this.Formula2 = formula2;
			this.validationType = validationType;
			this.operator1 = operator1;
			this.Validate();
			if (3 == validationType && formula1 != null && formula1.StartsWith(global::NPOI.XSSF.UserModel.XSSFDataValidationConstraint.QUOTE) && formula1.EndsWith(global::NPOI.XSSF.UserModel.XSSFDataValidationConstraint.QUOTE))
			{
				string input = formula1.Substring(1, formula1.Length - 2);
				this.explicitListOfValues = global::NPOI.XSSF.UserModel.XSSFDataValidationConstraint.LIST_SPLIT_REGEX.Split(input);
			}
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x060005FB RID: 1531 RVA: 0x0001646A File Offset: 0x0001466A
		// (set) Token: 0x060005FC RID: 1532 RVA: 0x00016474 File Offset: 0x00014674
		public string[] ExplicitListValues
		{
			get
			{
				return this.explicitListOfValues;
			}
			set
			{
				this.explicitListOfValues = value;
				if (this.explicitListOfValues != null && this.explicitListOfValues.Length != 0)
				{
					global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(global::NPOI.XSSF.UserModel.XSSFDataValidationConstraint.QUOTE);
					for (int i = 0; i < value.Length; i++)
					{
						string value2 = value[i];
						if (stringBuilder.Length > 1)
						{
							stringBuilder.Append(global::NPOI.XSSF.UserModel.XSSFDataValidationConstraint.LIST_SEPARATOR);
						}
						stringBuilder.Append(value2);
					}
					stringBuilder.Append(global::NPOI.XSSF.UserModel.XSSFDataValidationConstraint.QUOTE);
					this.Formula1 = stringBuilder.ToString();
				}
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x060005FD RID: 1533 RVA: 0x000164EB File Offset: 0x000146EB
		// (set) Token: 0x060005FE RID: 1534 RVA: 0x000164F3 File Offset: 0x000146F3
		public string Formula1
		{
			get
			{
				return this.formula1;
			}
			set
			{
				this.formula1 = global::NPOI.XSSF.UserModel.XSSFDataValidationConstraint.RemoveLeadingEquals(value);
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x060005FF RID: 1535 RVA: 0x00016501 File Offset: 0x00014701
		// (set) Token: 0x06000600 RID: 1536 RVA: 0x00016509 File Offset: 0x00014709
		public string Formula2
		{
			get
			{
				return this.formula2;
			}
			set
			{
				this.formula2 = global::NPOI.XSSF.UserModel.XSSFDataValidationConstraint.RemoveLeadingEquals(value);
			}
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x06000601 RID: 1537 RVA: 0x00016517 File Offset: 0x00014717
		// (set) Token: 0x06000602 RID: 1538 RVA: 0x0001651F File Offset: 0x0001471F
		public int Operator
		{
			get
			{
				return this.operator1;
			}
			set
			{
				this.operator1 = value;
			}
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x00016528 File Offset: 0x00014728
		public int GetValidationType()
		{
			return this.validationType;
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x00016530 File Offset: 0x00014730
		protected static string RemoveLeadingEquals(string formula1)
		{
			if (global::NPOI.XSSF.UserModel.XSSFDataValidationConstraint.IsFormulaEmpty(formula1))
			{
				return formula1;
			}
			if (formula1[0] != '=')
			{
				return formula1;
			}
			return formula1.Substring(1);
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x00016550 File Offset: 0x00014750
		public void Validate()
		{
			if (this.validationType == 0)
			{
				return;
			}
			if (this.validationType == 3)
			{
				if (global::NPOI.XSSF.UserModel.XSSFDataValidationConstraint.IsFormulaEmpty(this.formula1))
				{
					throw new global::System.ArgumentException("A valid formula or a list of values must be specified for list validation.");
				}
			}
			else
			{
				if (global::NPOI.XSSF.UserModel.XSSFDataValidationConstraint.IsFormulaEmpty(this.formula1))
				{
					throw new global::System.ArgumentException("Formula is not specified. Formula is required for all validation types except explicit list validation.");
				}
				if (this.validationType != 7)
				{
					if (this.operator1 == -1)
					{
						throw new global::System.ArgumentException("This validation type requires an operator to be specified.");
					}
					if ((this.operator1 == 0 || this.operator1 == 1) && global::NPOI.XSSF.UserModel.XSSFDataValidationConstraint.IsFormulaEmpty(this.formula2))
					{
						throw new global::System.ArgumentException("Between and not between comparisons require two formulae to be specified.");
					}
				}
			}
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x000165E5 File Offset: 0x000147E5
		protected static bool IsFormulaEmpty(string formula1)
		{
			return formula1 == null || formula1.Trim().Length == 0;
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x000165FC File Offset: 0x000147FC
		public string PrettyPrint()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			global::NPOI.OpenXmlFormats.Spreadsheet.ST_DataValidationType st_DataValidationType = global::NPOI.XSSF.UserModel.XSSFDataValidation.validationTypeMappings[this.validationType];
			global::System.Enum value = global::NPOI.XSSF.UserModel.XSSFDataValidation.operatorTypeMappings[this.operator1];
			stringBuilder.Append(st_DataValidationType);
			stringBuilder.Append(' ');
			if (this.validationType != 0)
			{
				if (this.validationType != 3 && this.validationType != 0 && this.validationType != 7)
				{
					stringBuilder.Append(global::NPOI.XSSF.UserModel.XSSFDataValidationConstraint.LIST_SEPARATOR).Append(value).Append(", ");
				}
				if (this.validationType == 3 && this.explicitListOfValues != null)
				{
					stringBuilder.Append(global::NPOI.XSSF.UserModel.XSSFDataValidationConstraint.QUOTE).Append(global::NPOI.Util.Arrays.AsList<string>(this.explicitListOfValues)).Append(global::NPOI.XSSF.UserModel.XSSFDataValidationConstraint.QUOTE).Append(' ');
				}
				else
				{
					stringBuilder.Append(global::NPOI.XSSF.UserModel.XSSFDataValidationConstraint.QUOTE).Append(this.formula1).Append(global::NPOI.XSSF.UserModel.XSSFDataValidationConstraint.QUOTE).Append(' ');
				}
				if (this.formula2 != null)
				{
					stringBuilder.Append(global::NPOI.XSSF.UserModel.XSSFDataValidationConstraint.QUOTE).Append(this.formula2).Append(global::NPOI.XSSF.UserModel.XSSFDataValidationConstraint.QUOTE).Append(' ');
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x040002C7 RID: 711
		private static string LIST_SEPARATOR = ",";

		// Token: 0x040002C8 RID: 712
		private static global::System.Text.RegularExpressions.Regex LIST_SPLIT_REGEX = new global::System.Text.RegularExpressions.Regex("\\s*" + global::NPOI.XSSF.UserModel.XSSFDataValidationConstraint.LIST_SEPARATOR + "\\s*");

		// Token: 0x040002C9 RID: 713
		private static string QUOTE = "\"";

		// Token: 0x040002CA RID: 714
		private string formula1;

		// Token: 0x040002CB RID: 715
		private string formula2;

		// Token: 0x040002CC RID: 716
		private int validationType = -1;

		// Token: 0x040002CD RID: 717
		private int operator1 = -1;

		// Token: 0x040002CE RID: 718
		private string[] explicitListOfValues;
	}
}
