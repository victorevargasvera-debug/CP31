using System;
using System.Globalization;
using System.Text;
using NPOI.HSSF.Model;
using NPOI.HSSF.Record;
using NPOI.SS.Formula;
using NPOI.SS.Formula.PTG;
using NPOI.SS.UserModel;
using NPOI.SS.Util;

namespace NPOI.HSSF.UserModel
{
	// Token: 0x0200035B RID: 859
	public class DVConstraint : global::NPOI.SS.UserModel.IDataValidationConstraint
	{
		// Token: 0x06001980 RID: 6528 RVA: 0x0004E2C8 File Offset: 0x0004C4C8
		private DVConstraint(int validationType, int comparisonOperator, string formulaA, string formulaB, double value1, double value2, string[] excplicitListValues)
		{
			this._validationType = validationType;
			this._operator = comparisonOperator;
			this._formula1 = formulaA;
			this._formula2 = formulaB;
			this._value1 = value1;
			this._value2 = value2;
			this._explicitListValues = ((excplicitListValues == null) ? null : ((string[])excplicitListValues.Clone()));
		}

		// Token: 0x06001981 RID: 6529 RVA: 0x0004E321 File Offset: 0x0004C521
		private DVConstraint(string listFormula, string[] excplicitListValues) : this(3, 0, listFormula, null, double.NaN, double.NaN, excplicitListValues)
		{
		}

		// Token: 0x06001982 RID: 6530 RVA: 0x0004E340 File Offset: 0x0004C540
		public static global::NPOI.HSSF.UserModel.DVConstraint CreateNumericConstraint(int validationType, int comparisonOperator, string expr1, string expr2)
		{
			switch (validationType)
			{
			case 0:
				if (expr1 != null || expr2 != null)
				{
					throw new global::System.ArgumentException("expr1 and expr2 must be null for validation type 'any'");
				}
				goto IL_68;
			case 1:
			case 2:
			case 6:
				if (expr1 == null)
				{
					throw new global::System.ArgumentException("expr1 must be supplied");
				}
				global::NPOI.SS.UserModel.OperatorType.ValidateSecondArg(comparisonOperator, expr2);
				goto IL_68;
			}
			throw new global::System.ArgumentException("Validation Type (" + validationType.ToString() + ") not supported with this method");
			IL_68:
			string formulaFromTextExpression = global::NPOI.HSSF.UserModel.DVConstraint.GetFormulaFromTextExpression(expr1);
			double value = (formulaFromTextExpression == null) ? global::NPOI.HSSF.UserModel.DVConstraint.ConvertNumber(expr1) : double.NaN;
			string formulaFromTextExpression2 = global::NPOI.HSSF.UserModel.DVConstraint.GetFormulaFromTextExpression(expr2);
			double value2 = (formulaFromTextExpression2 == null) ? global::NPOI.HSSF.UserModel.DVConstraint.ConvertNumber(expr2) : double.NaN;
			return new global::NPOI.HSSF.UserModel.DVConstraint(validationType, comparisonOperator, formulaFromTextExpression, formulaFromTextExpression2, value, value2, null);
		}

		// Token: 0x06001983 RID: 6531 RVA: 0x0004E3F9 File Offset: 0x0004C5F9
		public static global::NPOI.HSSF.UserModel.DVConstraint CreateFormulaListConstraint(string listFormula)
		{
			return new global::NPOI.HSSF.UserModel.DVConstraint(listFormula, null);
		}

		// Token: 0x06001984 RID: 6532 RVA: 0x0004E402 File Offset: 0x0004C602
		public static global::NPOI.HSSF.UserModel.DVConstraint CreateExplicitListConstraint(string[] explicitListValues)
		{
			return new global::NPOI.HSSF.UserModel.DVConstraint(null, explicitListValues);
		}

		// Token: 0x06001985 RID: 6533 RVA: 0x0004E40C File Offset: 0x0004C60C
		public static global::NPOI.HSSF.UserModel.DVConstraint CreateTimeConstraint(int comparisonOperator, string expr1, string expr2)
		{
			if (expr1 == null)
			{
				throw new global::System.ArgumentException("expr1 must be supplied");
			}
			global::NPOI.SS.UserModel.OperatorType.ValidateSecondArg(comparisonOperator, expr1);
			string formulaFromTextExpression = global::NPOI.HSSF.UserModel.DVConstraint.GetFormulaFromTextExpression(expr1);
			double value = (formulaFromTextExpression == null) ? global::NPOI.HSSF.UserModel.DVConstraint.ConvertTime(expr1) : double.NaN;
			string formulaFromTextExpression2 = global::NPOI.HSSF.UserModel.DVConstraint.GetFormulaFromTextExpression(expr2);
			double value2 = (formulaFromTextExpression2 == null) ? global::NPOI.HSSF.UserModel.DVConstraint.ConvertTime(expr2) : double.NaN;
			return new global::NPOI.HSSF.UserModel.DVConstraint(5, comparisonOperator, formulaFromTextExpression, formulaFromTextExpression2, value, value2, null);
		}

		// Token: 0x06001986 RID: 6534 RVA: 0x0004E474 File Offset: 0x0004C674
		public static global::NPOI.HSSF.UserModel.DVConstraint CreateDateConstraint(int comparisonOperator, string expr1, string expr2, string dateFormat)
		{
			if (expr1 == null)
			{
				throw new global::System.ArgumentException("expr1 must be supplied");
			}
			global::NPOI.SS.UserModel.OperatorType.ValidateSecondArg(comparisonOperator, expr2);
			global::NPOI.SS.Util.SimpleDateFormat dateFormat2 = (dateFormat == null) ? null : new global::NPOI.SS.Util.SimpleDateFormat(dateFormat);
			string formulaFromTextExpression = global::NPOI.HSSF.UserModel.DVConstraint.GetFormulaFromTextExpression(expr1);
			double value = (formulaFromTextExpression == null) ? global::NPOI.HSSF.UserModel.DVConstraint.ConvertDate(expr1, dateFormat2) : double.NaN;
			string formulaFromTextExpression2 = global::NPOI.HSSF.UserModel.DVConstraint.GetFormulaFromTextExpression(expr2);
			double value2 = (formulaFromTextExpression2 == null) ? global::NPOI.HSSF.UserModel.DVConstraint.ConvertDate(expr2, dateFormat2) : double.NaN;
			return new global::NPOI.HSSF.UserModel.DVConstraint(4, comparisonOperator, formulaFromTextExpression, formulaFromTextExpression2, value, value2, null);
		}

		// Token: 0x06001987 RID: 6535 RVA: 0x0004E4EB File Offset: 0x0004C6EB
		private static string GetFormulaFromTextExpression(string textExpr)
		{
			if (textExpr == null)
			{
				return null;
			}
			if (textExpr.Length < 1)
			{
				throw new global::System.ArgumentException("Empty string is not a valid formula/value expression");
			}
			if (textExpr[0] == '=')
			{
				return textExpr.Substring(1);
			}
			return null;
		}

		// Token: 0x06001988 RID: 6536 RVA: 0x0004E51C File Offset: 0x0004C71C
		private static double ConvertNumber(string numberStr)
		{
			if (numberStr == null)
			{
				return double.NaN;
			}
			double result;
			try
			{
				result = double.Parse(numberStr, global::System.Globalization.CultureInfo.CurrentCulture);
			}
			catch (global::System.FormatException)
			{
				throw new global::System.InvalidOperationException("The supplied text '" + numberStr + "' could not be parsed as a number");
			}
			return result;
		}

		// Token: 0x06001989 RID: 6537 RVA: 0x0004E570 File Offset: 0x0004C770
		private static double ConvertTime(string timeStr)
		{
			if (timeStr == null)
			{
				return double.NaN;
			}
			return global::NPOI.SS.UserModel.DateUtil.ConvertTime(timeStr);
		}

		// Token: 0x0600198A RID: 6538 RVA: 0x0004E588 File Offset: 0x0004C788
		private static double ConvertDate(string dateStr, global::NPOI.SS.Util.SimpleDateFormat dateFormat)
		{
			if (dateStr == null)
			{
				return double.NaN;
			}
			global::System.DateTime date;
			if (dateFormat == null)
			{
				date = global::NPOI.SS.UserModel.DateUtil.ParseYYYYMMDDDate(dateStr);
			}
			else
			{
				try
				{
					date = global::System.DateTime.Parse(dateStr, global::System.Globalization.CultureInfo.CurrentCulture);
				}
				catch (global::System.FormatException innerException)
				{
					throw new global::System.InvalidOperationException(string.Concat(new string[]
					{
						"Failed to parse date '",
						dateStr,
						"' using specified format '",
						(dateFormat != null) ? dateFormat.ToString() : null,
						"'"
					}), innerException);
				}
			}
			return global::NPOI.SS.UserModel.DateUtil.GetExcelDate(date);
		}

		// Token: 0x0600198B RID: 6539 RVA: 0x0004E614 File Offset: 0x0004C814
		public static global::NPOI.HSSF.UserModel.DVConstraint CreateCustomFormulaConstraint(string formula)
		{
			if (formula == null)
			{
				throw new global::System.ArgumentException("formula must be supplied");
			}
			return new global::NPOI.HSSF.UserModel.DVConstraint(7, 0, formula, null, double.NaN, double.NaN, null);
		}

		// Token: 0x0600198C RID: 6540 RVA: 0x0004E640 File Offset: 0x0004C840
		public int GetValidationType()
		{
			return this._validationType;
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x0600198D RID: 6541 RVA: 0x0004E648 File Offset: 0x0004C848
		public bool IsListValidationType
		{
			get
			{
				return this._validationType == 3;
			}
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x0600198E RID: 6542 RVA: 0x0004E653 File Offset: 0x0004C853
		public bool IsExplicitList
		{
			get
			{
				return this._validationType == 3 && this._explicitListValues != null;
			}
		}

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x0600198F RID: 6543 RVA: 0x0004E669 File Offset: 0x0004C869
		// (set) Token: 0x06001990 RID: 6544 RVA: 0x0004E671 File Offset: 0x0004C871
		public int Operator
		{
			get
			{
				return this._operator;
			}
			set
			{
				this._operator = value;
			}
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x06001991 RID: 6545 RVA: 0x0004E67A File Offset: 0x0004C87A
		// (set) Token: 0x06001992 RID: 6546 RVA: 0x0004E682 File Offset: 0x0004C882
		public string[] ExplicitListValues
		{
			get
			{
				return this._explicitListValues;
			}
			set
			{
				if (this._validationType != 3)
				{
					throw new global::System.InvalidOperationException("Cannot setExplicitListValues on non-list constraint");
				}
				this._formula1 = null;
				this._explicitListValues = value;
			}
		}

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x06001993 RID: 6547 RVA: 0x0004E6A6 File Offset: 0x0004C8A6
		// (set) Token: 0x06001994 RID: 6548 RVA: 0x0004E6AE File Offset: 0x0004C8AE
		public string Formula1
		{
			get
			{
				return this._formula1;
			}
			set
			{
				this._value1 = double.NaN;
				this._explicitListValues = null;
				this._formula1 = value;
			}
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x06001995 RID: 6549 RVA: 0x0004E6CD File Offset: 0x0004C8CD
		// (set) Token: 0x06001996 RID: 6550 RVA: 0x0004E6D5 File Offset: 0x0004C8D5
		public string Formula2
		{
			get
			{
				return this._formula2;
			}
			set
			{
				this._value2 = double.NaN;
				this._formula2 = value;
			}
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x06001997 RID: 6551 RVA: 0x0004E6ED File Offset: 0x0004C8ED
		// (set) Token: 0x06001998 RID: 6552 RVA: 0x0004E6F5 File Offset: 0x0004C8F5
		public double Value1
		{
			get
			{
				return this._value1;
			}
			set
			{
				this._formula1 = null;
				this._value1 = value;
			}
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x06001999 RID: 6553 RVA: 0x0004E705 File Offset: 0x0004C905
		// (set) Token: 0x0600199A RID: 6554 RVA: 0x0004E70D File Offset: 0x0004C90D
		public double Value2
		{
			get
			{
				return this._value2;
			}
			set
			{
				this._formula2 = null;
				this._value2 = value;
			}
		}

		// Token: 0x0600199B RID: 6555 RVA: 0x0004E720 File Offset: 0x0004C920
		public global::NPOI.HSSF.UserModel.DVConstraint.FormulaPair CreateFormulas(global::NPOI.HSSF.UserModel.HSSFSheet sheet)
		{
			global::NPOI.SS.Formula.PTG.Ptg[] formula;
			global::NPOI.SS.Formula.PTG.Ptg[] formula2;
			if (this.IsListValidationType)
			{
				formula = this.CreateListFormula(sheet);
				formula2 = global::NPOI.SS.Formula.PTG.Ptg.EMPTY_PTG_ARRAY;
			}
			else
			{
				formula = global::NPOI.HSSF.UserModel.DVConstraint.ConvertDoubleFormula(this._formula1, this._value1, sheet);
				formula2 = global::NPOI.HSSF.UserModel.DVConstraint.ConvertDoubleFormula(this._formula2, this._value2, sheet);
			}
			return new global::NPOI.HSSF.UserModel.DVConstraint.FormulaPair(formula, formula2);
		}

		// Token: 0x0600199C RID: 6556 RVA: 0x0004E774 File Offset: 0x0004C974
		private global::NPOI.SS.Formula.PTG.Ptg[] CreateListFormula(global::NPOI.HSSF.UserModel.HSSFSheet sheet)
		{
			if (this._explicitListValues == null)
			{
				global::NPOI.SS.UserModel.IWorkbook workbook = sheet.Workbook;
				return global::NPOI.HSSF.Model.HSSFFormulaParser.Parse(this._formula1, (global::NPOI.HSSF.UserModel.HSSFWorkbook)workbook, global::NPOI.SS.Formula.FormulaType.DataValidationList, workbook.GetSheetIndex(sheet));
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(this._explicitListValues.Length * 16);
			for (int i = 0; i < this._explicitListValues.Length; i++)
			{
				if (i > 0)
				{
					stringBuilder.Append('\0');
				}
				stringBuilder.Append(this._explicitListValues[i]);
			}
			return new global::NPOI.SS.Formula.PTG.Ptg[]
			{
				new global::NPOI.SS.Formula.PTG.StringPtg(stringBuilder.ToString())
			};
		}

		// Token: 0x0600199D RID: 6557 RVA: 0x0004E800 File Offset: 0x0004CA00
		private static global::NPOI.SS.Formula.PTG.Ptg[] ConvertDoubleFormula(string formula, double value, global::NPOI.HSSF.UserModel.HSSFSheet sheet)
		{
			if (formula == null)
			{
				if (double.IsNaN(value))
				{
					return global::NPOI.SS.Formula.PTG.Ptg.EMPTY_PTG_ARRAY;
				}
				return new global::NPOI.SS.Formula.PTG.Ptg[]
				{
					new global::NPOI.SS.Formula.PTG.NumberPtg(value)
				};
			}
			else
			{
				if (!double.IsNaN(value))
				{
					throw new global::System.InvalidOperationException("Both formula and value cannot be present");
				}
				global::NPOI.SS.UserModel.IWorkbook workbook = sheet.Workbook;
				return global::NPOI.HSSF.Model.HSSFFormulaParser.Parse(formula, (global::NPOI.HSSF.UserModel.HSSFWorkbook)workbook, global::NPOI.SS.Formula.FormulaType.Cell, workbook.GetSheetIndex(sheet));
			}
		}

		// Token: 0x0600199E RID: 6558 RVA: 0x0004E85C File Offset: 0x0004CA5C
		internal static global::NPOI.HSSF.UserModel.DVConstraint CreateDVConstraint(global::NPOI.HSSF.Record.DVRecord dvRecord, global::NPOI.SS.Formula.IFormulaRenderingWorkbook book)
		{
			switch (dvRecord.DataType)
			{
			case 0:
				return new global::NPOI.HSSF.UserModel.DVConstraint(0, dvRecord.ConditionOperator, null, null, double.NaN, double.NaN, null);
			case 1:
			case 2:
			case 4:
			case 5:
			case 6:
			{
				global::NPOI.HSSF.UserModel.DVConstraint.FormulaValuePair formulaValuePair = global::NPOI.HSSF.UserModel.DVConstraint.toFormulaString(dvRecord.Formula1, book);
				global::NPOI.HSSF.UserModel.DVConstraint.FormulaValuePair formulaValuePair2 = global::NPOI.HSSF.UserModel.DVConstraint.toFormulaString(dvRecord.Formula2, book);
				return new global::NPOI.HSSF.UserModel.DVConstraint(dvRecord.DataType, dvRecord.ConditionOperator, formulaValuePair.formula(), formulaValuePair2.formula(), formulaValuePair.Value, formulaValuePair2.Value, null);
			}
			case 3:
				if (dvRecord.ListExplicitFormula)
				{
					string text = global::NPOI.HSSF.UserModel.DVConstraint.toFormulaString(dvRecord.Formula1, book).AsString();
					if (text.StartsWith("\""))
					{
						text = text.Substring(1);
					}
					if (text.EndsWith("\""))
					{
						text = text.Substring(0, text.Length - 1);
					}
					return global::NPOI.HSSF.UserModel.DVConstraint.CreateExplicitListConstraint(text.Split("\0".ToCharArray()));
				}
				return global::NPOI.HSSF.UserModel.DVConstraint.CreateFormulaListConstraint(global::NPOI.HSSF.UserModel.DVConstraint.toFormulaString(dvRecord.Formula1, book).AsString());
			case 7:
				return global::NPOI.HSSF.UserModel.DVConstraint.CreateCustomFormulaConstraint(global::NPOI.HSSF.UserModel.DVConstraint.toFormulaString(dvRecord.Formula1, book).AsString());
			default:
				throw new global::System.InvalidOperationException(string.Format("validationType={0}", dvRecord.DataType));
			}
		}

		// Token: 0x0600199F RID: 6559 RVA: 0x0004E9AC File Offset: 0x0004CBAC
		private static global::NPOI.HSSF.UserModel.DVConstraint.FormulaValuePair toFormulaString(global::NPOI.SS.Formula.PTG.Ptg[] ptgs, global::NPOI.SS.Formula.IFormulaRenderingWorkbook book)
		{
			global::NPOI.HSSF.UserModel.DVConstraint.FormulaValuePair formulaValuePair = new global::NPOI.HSSF.UserModel.DVConstraint.FormulaValuePair();
			if (ptgs != null && ptgs.Length != 0)
			{
				string text = global::NPOI.SS.Formula.FormulaRenderer.ToFormulaString(book, ptgs);
				if (ptgs.Length == 1 && ptgs[0].GetType() == typeof(global::NPOI.SS.Formula.PTG.NumberPtg))
				{
					formulaValuePair._value = text;
				}
				else
				{
					formulaValuePair._formula = text;
				}
			}
			return formulaValuePair;
		}

		// Token: 0x04000AEB RID: 2795
		private int _validationType;

		// Token: 0x04000AEC RID: 2796
		private int _operator;

		// Token: 0x04000AED RID: 2797
		private string[] _explicitListValues;

		// Token: 0x04000AEE RID: 2798
		private string _formula1;

		// Token: 0x04000AEF RID: 2799
		private string _formula2;

		// Token: 0x04000AF0 RID: 2800
		private double _value1;

		// Token: 0x04000AF1 RID: 2801
		private double _value2;

		// Token: 0x020005FB RID: 1531
		public class FormulaPair
		{
			// Token: 0x06003600 RID: 13824 RVA: 0x000A5509 File Offset: 0x000A3709
			public FormulaPair(global::NPOI.SS.Formula.PTG.Ptg[] formula1, global::NPOI.SS.Formula.PTG.Ptg[] formula2)
			{
				this._formula1 = ((formula1 == null) ? null : ((global::NPOI.SS.Formula.PTG.Ptg[])formula1.Clone()));
				this._formula2 = ((formula2 == null) ? null : ((global::NPOI.SS.Formula.PTG.Ptg[])formula2.Clone()));
			}

			// Token: 0x17000DF5 RID: 3573
			// (get) Token: 0x06003601 RID: 13825 RVA: 0x000A553F File Offset: 0x000A373F
			public global::NPOI.SS.Formula.PTG.Ptg[] Formula1
			{
				get
				{
					return this._formula1;
				}
			}

			// Token: 0x17000DF6 RID: 3574
			// (get) Token: 0x06003602 RID: 13826 RVA: 0x000A5547 File Offset: 0x000A3747
			public global::NPOI.SS.Formula.PTG.Ptg[] Formula2
			{
				get
				{
					return this._formula2;
				}
			}

			// Token: 0x04001A25 RID: 6693
			private global::NPOI.SS.Formula.PTG.Ptg[] _formula1;

			// Token: 0x04001A26 RID: 6694
			private global::NPOI.SS.Formula.PTG.Ptg[] _formula2;
		}

		// Token: 0x020005FC RID: 1532
		private class FormulaValuePair
		{
			// Token: 0x06003603 RID: 13827 RVA: 0x000A554F File Offset: 0x000A374F
			public string formula()
			{
				return this._formula;
			}

			// Token: 0x17000DF7 RID: 3575
			// (get) Token: 0x06003604 RID: 13828 RVA: 0x000A5557 File Offset: 0x000A3757
			public double Value
			{
				get
				{
					if (this._value == null)
					{
						return double.NaN;
					}
					return double.Parse(this._value);
				}
			}

			// Token: 0x06003605 RID: 13829 RVA: 0x000A5576 File Offset: 0x000A3776
			public string AsString()
			{
				if (this._formula != null)
				{
					return this._formula;
				}
				if (this._value != null)
				{
					return this._value;
				}
				return null;
			}

			// Token: 0x04001A27 RID: 6695
			internal string _formula;

			// Token: 0x04001A28 RID: 6696
			internal string _value;
		}
	}
}
