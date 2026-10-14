using System;
using System.Collections.Generic;
using NPOI.OpenXmlFormats.Spreadsheet;
using NPOI.SS.UserModel;

namespace NPOI.XSSF.UserModel.Helpers
{
	// Token: 0x020000AC RID: 172
	public class XSSFIgnoredErrorHelper
	{
		// Token: 0x06000B11 RID: 2833 RVA: 0x00029918 File Offset: 0x00027B18
		public static bool IsSet(global::NPOI.SS.UserModel.IgnoredErrorType errorType, global::NPOI.OpenXmlFormats.Spreadsheet.CT_IgnoredError error)
		{
			switch (errorType)
			{
			case global::NPOI.SS.UserModel.IgnoredErrorType.CalculatedColumn:
				return error.calculatedColumn;
			case global::NPOI.SS.UserModel.IgnoredErrorType.EmptyCellReference:
				return error.emptyCellReference;
			case global::NPOI.SS.UserModel.IgnoredErrorType.EvaluationError:
				return error.evalError;
			case global::NPOI.SS.UserModel.IgnoredErrorType.Formula:
				return error.formula;
			case global::NPOI.SS.UserModel.IgnoredErrorType.FormulaRange:
				return error.formulaRange;
			case global::NPOI.SS.UserModel.IgnoredErrorType.ListDataValidation:
				return error.listDataValidation;
			case global::NPOI.SS.UserModel.IgnoredErrorType.NumberStoredAsText:
				return error.numberStoredAsText;
			case global::NPOI.SS.UserModel.IgnoredErrorType.TwoDigitTextYear:
				return error.twoDigitTextYear;
			case global::NPOI.SS.UserModel.IgnoredErrorType.UnlockedFormula:
				return error.unlockedFormula;
			default:
				throw new global::System.InvalidOperationException();
			}
		}

		// Token: 0x06000B12 RID: 2834 RVA: 0x00029998 File Offset: 0x00027B98
		public static void Set(global::NPOI.SS.UserModel.IgnoredErrorType errorType, global::NPOI.OpenXmlFormats.Spreadsheet.CT_IgnoredError error)
		{
			switch (errorType)
			{
			case global::NPOI.SS.UserModel.IgnoredErrorType.CalculatedColumn:
				error.calculatedColumn = true;
				return;
			case global::NPOI.SS.UserModel.IgnoredErrorType.EmptyCellReference:
				error.emptyCellReference = true;
				return;
			case global::NPOI.SS.UserModel.IgnoredErrorType.EvaluationError:
				error.evalError = true;
				return;
			case global::NPOI.SS.UserModel.IgnoredErrorType.Formula:
				error.formula = true;
				return;
			case global::NPOI.SS.UserModel.IgnoredErrorType.FormulaRange:
				error.formulaRange = true;
				return;
			case global::NPOI.SS.UserModel.IgnoredErrorType.ListDataValidation:
				error.listDataValidation = true;
				return;
			case global::NPOI.SS.UserModel.IgnoredErrorType.NumberStoredAsText:
				error.numberStoredAsText = true;
				return;
			case global::NPOI.SS.UserModel.IgnoredErrorType.TwoDigitTextYear:
				error.twoDigitTextYear = true;
				return;
			case global::NPOI.SS.UserModel.IgnoredErrorType.UnlockedFormula:
				error.unlockedFormula = true;
				return;
			default:
				throw new global::System.InvalidOperationException();
			}
		}

		// Token: 0x06000B13 RID: 2835 RVA: 0x00029A20 File Offset: 0x00027C20
		public static void AddIgnoredErrors(global::NPOI.OpenXmlFormats.Spreadsheet.CT_IgnoredError err, string ref1, params global::NPOI.SS.UserModel.IgnoredErrorType[] ignoredErrorTypes)
		{
			err.sqref.Clear();
			err.sqref.Add(ref1);
			for (int i = 0; i < ignoredErrorTypes.Length; i++)
			{
				global::NPOI.XSSF.UserModel.Helpers.XSSFIgnoredErrorHelper.Set(ignoredErrorTypes[i], err);
			}
		}

		// Token: 0x06000B14 RID: 2836 RVA: 0x00029A60 File Offset: 0x00027C60
		public static global::System.Collections.Generic.ISet<global::NPOI.SS.UserModel.IgnoredErrorType> GetErrorTypes(global::NPOI.OpenXmlFormats.Spreadsheet.CT_IgnoredError err)
		{
			global::System.Collections.Generic.ISet<global::NPOI.SS.UserModel.IgnoredErrorType> set = new global::System.Collections.Generic.HashSet<global::NPOI.SS.UserModel.IgnoredErrorType>();
			foreach (global::NPOI.SS.UserModel.IgnoredErrorType ignoredErrorType in global::NPOI.SS.UserModel.IgnoredErrorTypeValues.Values)
			{
				if (global::NPOI.XSSF.UserModel.Helpers.XSSFIgnoredErrorHelper.IsSet(ignoredErrorType, err))
				{
					set.Add(ignoredErrorType);
				}
			}
			return set;
		}
	}
}
