using System;
using System.Globalization;
using NPOI.SS.Formula.Eval;
using NPOI.SS.Formula.Functions;
using NPOI.SS.Formula.PTG;
using NPOI.SS.Util;
using NPOI.Util;

namespace NPOI.SS.Formula
{
	// Token: 0x020000D6 RID: 214
	public class OperationEvaluationContext
	{
		// Token: 0x06000720 RID: 1824 RVA: 0x00012716 File Offset: 0x00010916
		public OperationEvaluationContext(global::NPOI.SS.Formula.WorkbookEvaluator bookEvaluator, global::NPOI.SS.Formula.IEvaluationWorkbook workbook, int sheetIndex, int srcRowNum, int srcColNum, global::NPOI.SS.Formula.EvaluationTracker tracker)
		{
			this._bookEvaluator = bookEvaluator;
			this._workbook = workbook;
			this._sheetIndex = sheetIndex;
			this._rowIndex = srcRowNum;
			this._columnIndex = srcColNum;
			this._tracker = tracker;
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x0001274B File Offset: 0x0001094B
		public global::NPOI.SS.Formula.IEvaluationWorkbook GetWorkbook()
		{
			return this._workbook;
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x06000722 RID: 1826 RVA: 0x00012753 File Offset: 0x00010953
		public int RowIndex
		{
			get
			{
				return this._rowIndex;
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x06000723 RID: 1827 RVA: 0x0001275B File Offset: 0x0001095B
		public int ColumnIndex
		{
			get
			{
				return this._columnIndex;
			}
		}

		// Token: 0x06000724 RID: 1828 RVA: 0x00012763 File Offset: 0x00010963
		private global::NPOI.SS.Formula.SheetRangeEvaluator CreateExternSheetRefEvaluator(global::NPOI.SS.Formula.IExternSheetReferenceToken ptg)
		{
			return this.CreateExternSheetRefEvaluator(ptg.ExternSheetIndex);
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x00012774 File Offset: 0x00010974
		private global::NPOI.SS.Formula.SheetRangeEvaluator CreateExternSheetRefEvaluator(string firstSheetName, string lastSheetName, int externalWorkbookNumber)
		{
			global::NPOI.SS.Formula.ExternalSheet externalSheet = this._workbook.GetExternalSheet(firstSheetName, lastSheetName, externalWorkbookNumber);
			return this.CreateExternSheetRefEvaluator(externalSheet);
		}

		// Token: 0x06000726 RID: 1830 RVA: 0x00012798 File Offset: 0x00010998
		private global::NPOI.SS.Formula.SheetRangeEvaluator CreateExternSheetRefEvaluator(int externSheetIndex)
		{
			global::NPOI.SS.Formula.ExternalSheet externalSheet = this._workbook.GetExternalSheet(externSheetIndex);
			return this.CreateExternSheetRefEvaluator(externalSheet);
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x000127BC File Offset: 0x000109BC
		private global::NPOI.SS.Formula.SheetRangeEvaluator CreateExternSheetRefEvaluator(global::NPOI.SS.Formula.ExternalSheet externalSheet)
		{
			int num = -1;
			global::NPOI.SS.Formula.WorkbookEvaluator workbookEvaluator;
			int num2;
			if (externalSheet == null || externalSheet.WorkbookName == null)
			{
				workbookEvaluator = this._bookEvaluator;
				if (externalSheet == null)
				{
					num2 = 0;
				}
				else
				{
					num2 = this._workbook.GetSheetIndex(externalSheet.SheetName);
				}
				if (externalSheet is global::NPOI.SS.Formula.ExternalSheetRange)
				{
					string lastSheetName = ((global::NPOI.SS.Formula.ExternalSheetRange)externalSheet).LastSheetName;
					num = this._workbook.GetSheetIndex(lastSheetName);
				}
			}
			else
			{
				string workbookName = externalSheet.WorkbookName;
				try
				{
					workbookEvaluator = this._bookEvaluator.GetOtherWorkbookEvaluator(workbookName);
				}
				catch (global::NPOI.SS.Formula.WorkbookNotFoundException ex)
				{
					throw new global::NPOI.Util.RuntimeException(ex.Message, ex);
				}
				num2 = workbookEvaluator.GetSheetIndex(externalSheet.SheetName);
				if (externalSheet is global::NPOI.SS.Formula.ExternalSheetRange)
				{
					string lastSheetName2 = ((global::NPOI.SS.Formula.ExternalSheetRange)externalSheet).LastSheetName;
					num = workbookEvaluator.GetSheetIndex(lastSheetName2);
				}
				if (num2 < 0)
				{
					throw new global::System.Exception(string.Concat(new string[]
					{
						"Invalid sheet name '",
						externalSheet.SheetName,
						"' in bool '",
						workbookName,
						"'."
					}));
				}
			}
			if (num == -1)
			{
				num = num2;
			}
			global::NPOI.SS.Formula.SheetRefEvaluator[] array = new global::NPOI.SS.Formula.SheetRefEvaluator[num - num2 + 1];
			for (int i = 0; i < array.Length; i++)
			{
				int sheetIndex = i + num2;
				array[i] = new global::NPOI.SS.Formula.SheetRefEvaluator(workbookEvaluator, this._tracker, sheetIndex);
			}
			return new global::NPOI.SS.Formula.SheetRangeEvaluator(num2, num, array);
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x00012904 File Offset: 0x00010B04
		private global::NPOI.SS.Formula.SheetRefEvaluator CreateExternSheetRefEvaluator(string workbookName, string sheetName)
		{
			global::NPOI.SS.Formula.WorkbookEvaluator workbookEvaluator;
			if (workbookName == null)
			{
				workbookEvaluator = this._bookEvaluator;
			}
			else
			{
				if (sheetName == null)
				{
					throw new global::System.ArgumentException("sheetName must not be null if workbookName is provided");
				}
				try
				{
					workbookEvaluator = this._bookEvaluator.GetOtherWorkbookEvaluator(workbookName);
				}
				catch (global::NPOI.SS.Formula.WorkbookNotFoundException)
				{
					return null;
				}
			}
			int num = (sheetName == null) ? this._sheetIndex : workbookEvaluator.GetSheetIndex(sheetName);
			if (num < 0)
			{
				return null;
			}
			return new global::NPOI.SS.Formula.SheetRefEvaluator(workbookEvaluator, this._tracker, num);
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x00012978 File Offset: 0x00010B78
		public global::NPOI.SS.Formula.SheetRangeEvaluator GetRefEvaluatorForCurrentSheet()
		{
			global::NPOI.SS.Formula.SheetRefEvaluator sheetEvaluator = new global::NPOI.SS.Formula.SheetRefEvaluator(this._bookEvaluator, this._tracker, this._sheetIndex);
			return new global::NPOI.SS.Formula.SheetRangeEvaluator(this._sheetIndex, sheetEvaluator);
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x000129AC File Offset: 0x00010BAC
		public global::NPOI.SS.Formula.Eval.ValueEval GetDynamicReference(string workbookName, string sheetName, string refStrPart1, string refStrPart2, bool isA1Style)
		{
			if (!isA1Style)
			{
				throw new global::System.Exception("R1C1 style not supported yet");
			}
			global::NPOI.SS.Formula.SheetRefEvaluator sheetRefEvaluator = this.CreateExternSheetRefEvaluator(workbookName, sheetName);
			if (sheetRefEvaluator == null)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.REF_INVALID;
			}
			global::NPOI.SS.Formula.SheetRangeEvaluator sheetRangeEvaluator = new global::NPOI.SS.Formula.SheetRangeEvaluator(this._sheetIndex, sheetRefEvaluator);
			global::NPOI.SS.SpreadsheetVersion spreadsheetVersion = ((global::NPOI.SS.Formula.IFormulaParsingWorkbook)this._workbook).GetSpreadsheetVersion();
			global::NPOI.SS.Util.NameType nameType = global::NPOI.SS.Formula.OperationEvaluationContext.ClassifyCellReference(refStrPart1, spreadsheetVersion);
			if (nameType == global::NPOI.SS.Util.NameType.BadCellOrNamedRange)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.REF_INVALID;
			}
			if (nameType != global::NPOI.SS.Util.NameType.NamedRange)
			{
				if (refStrPart2 == null)
				{
					if (nameType == global::NPOI.SS.Util.NameType.Cell)
					{
						global::NPOI.SS.Util.CellReference cellReference = new global::NPOI.SS.Util.CellReference(refStrPart1);
						return new global::NPOI.SS.Formula.LazyRefEval(cellReference.Row, (int)cellReference.Col, sheetRangeEvaluator);
					}
					if (nameType - global::NPOI.SS.Util.NameType.Column <= 1)
					{
						return global::NPOI.SS.Formula.Eval.ErrorEval.REF_INVALID;
					}
					throw new global::System.InvalidOperationException("Unexpected reference classification of '" + refStrPart1 + "'.");
				}
				else
				{
					global::NPOI.SS.Util.NameType nameType2 = global::NPOI.SS.Formula.OperationEvaluationContext.ClassifyCellReference(refStrPart1, spreadsheetVersion);
					if (nameType2 == global::NPOI.SS.Util.NameType.BadCellOrNamedRange)
					{
						return global::NPOI.SS.Formula.Eval.ErrorEval.REF_INVALID;
					}
					if (nameType2 == global::NPOI.SS.Util.NameType.NamedRange)
					{
						throw new global::System.Exception("Cannot Evaluate '" + refStrPart1 + "'. Indirect Evaluation of defined names not supported yet");
					}
					if (nameType2 != nameType)
					{
						return global::NPOI.SS.Formula.Eval.ErrorEval.REF_INVALID;
					}
					int firstRowIndex;
					int firstColumnIndex;
					int lastRowIndex;
					int lastColumnIndex;
					switch (nameType)
					{
					case global::NPOI.SS.Util.NameType.Cell:
					{
						global::NPOI.SS.Util.CellReference cellReference2 = new global::NPOI.SS.Util.CellReference(refStrPart1);
						firstRowIndex = cellReference2.Row;
						firstColumnIndex = (int)cellReference2.Col;
						global::NPOI.SS.Util.CellReference cellReference3 = new global::NPOI.SS.Util.CellReference(refStrPart2);
						lastRowIndex = cellReference3.Row;
						lastColumnIndex = (int)cellReference3.Col;
						goto IL_228;
					}
					case global::NPOI.SS.Util.NameType.Column:
						firstRowIndex = 0;
						if (nameType2.Equals(global::NPOI.SS.Util.NameType.Column))
						{
							lastRowIndex = spreadsheetVersion.LastRowIndex;
							firstColumnIndex = global::NPOI.SS.Formula.OperationEvaluationContext.ParseRowRef(refStrPart1);
							lastColumnIndex = global::NPOI.SS.Formula.OperationEvaluationContext.ParseRowRef(refStrPart2);
							goto IL_228;
						}
						lastRowIndex = spreadsheetVersion.LastRowIndex;
						firstColumnIndex = global::NPOI.SS.Formula.OperationEvaluationContext.ParseColRef(refStrPart1);
						lastColumnIndex = global::NPOI.SS.Formula.OperationEvaluationContext.ParseColRef(refStrPart2);
						goto IL_228;
					case global::NPOI.SS.Util.NameType.Row:
						firstColumnIndex = 0;
						if (nameType2.Equals(global::NPOI.SS.Util.NameType.Row))
						{
							firstRowIndex = global::NPOI.SS.Formula.OperationEvaluationContext.ParseColRef(refStrPart1);
							lastRowIndex = global::NPOI.SS.Formula.OperationEvaluationContext.ParseColRef(refStrPart2);
							lastColumnIndex = spreadsheetVersion.LastColumnIndex;
							goto IL_228;
						}
						lastColumnIndex = spreadsheetVersion.LastColumnIndex;
						firstRowIndex = global::NPOI.SS.Formula.OperationEvaluationContext.ParseRowRef(refStrPart1);
						lastRowIndex = global::NPOI.SS.Formula.OperationEvaluationContext.ParseRowRef(refStrPart2);
						goto IL_228;
					}
					throw new global::System.InvalidOperationException("Unexpected reference classification of '" + refStrPart1 + "'.");
					IL_228:
					return new global::NPOI.SS.Formula.LazyAreaEval(firstRowIndex, firstColumnIndex, lastRowIndex, lastColumnIndex, sheetRangeEvaluator);
				}
			}
			else
			{
				global::NPOI.SS.Formula.IEvaluationName name = ((global::NPOI.SS.Formula.IFormulaParsingWorkbook)this._workbook).GetName(refStrPart1, this._sheetIndex);
				if (!name.IsRange)
				{
					throw new global::System.Exception("Specified name '" + refStrPart1 + "' is not a range as expected.");
				}
				return this._bookEvaluator.EvaluateNameFormula(name.NameDefinition, this);
			}
		}

		// Token: 0x0600072B RID: 1835 RVA: 0x00012BEF File Offset: 0x00010DEF
		private static int ParseRowRef(string refStrPart)
		{
			return global::NPOI.SS.Util.CellReference.ConvertColStringToIndex(refStrPart);
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x00012BF7 File Offset: 0x00010DF7
		private static int ParseColRef(string refStrPart)
		{
			return int.Parse(refStrPart, global::System.Globalization.CultureInfo.InvariantCulture) - 1;
		}

		// Token: 0x0600072D RID: 1837 RVA: 0x00012C06 File Offset: 0x00010E06
		private static global::NPOI.SS.Util.NameType ClassifyCellReference(string str, global::NPOI.SS.SpreadsheetVersion ssVersion)
		{
			if (str.Length < 1)
			{
				return global::NPOI.SS.Util.NameType.BadCellOrNamedRange;
			}
			return global::NPOI.SS.Util.CellReference.ClassifyCellReference(str, ssVersion);
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x00012C1A File Offset: 0x00010E1A
		public global::NPOI.SS.Formula.Functions.FreeRefFunction FindUserDefinedFunction(string functionName)
		{
			return this._bookEvaluator.FindUserDefinedFunction(functionName);
		}

		// Token: 0x0600072F RID: 1839 RVA: 0x00012C28 File Offset: 0x00010E28
		public global::NPOI.SS.Formula.Eval.ValueEval GetRefEval(int rowIndex, int columnIndex)
		{
			global::NPOI.SS.Formula.SheetRangeEvaluator refEvaluatorForCurrentSheet = this.GetRefEvaluatorForCurrentSheet();
			return new global::NPOI.SS.Formula.LazyRefEval(rowIndex, columnIndex, refEvaluatorForCurrentSheet);
		}

		// Token: 0x06000730 RID: 1840 RVA: 0x00012C44 File Offset: 0x00010E44
		public global::NPOI.SS.Formula.Eval.ValueEval GetRef3DEval(global::NPOI.SS.Formula.PTG.Ref3DPtg rptg)
		{
			global::NPOI.SS.Formula.SheetRangeEvaluator sre = this.CreateExternSheetRefEvaluator(rptg.ExternSheetIndex);
			return new global::NPOI.SS.Formula.LazyRefEval(rptg.Row, rptg.Column, sre);
		}

		// Token: 0x06000731 RID: 1841 RVA: 0x00012C70 File Offset: 0x00010E70
		public global::NPOI.SS.Formula.Eval.ValueEval GetRef3DEval(global::NPOI.SS.Formula.PTG.Ref3DPxg rptg)
		{
			global::NPOI.SS.Formula.SheetRangeEvaluator sre = this.CreateExternSheetRefEvaluator(rptg.SheetName, rptg.LastSheetName, rptg.ExternalWorkbookNumber);
			return new global::NPOI.SS.Formula.LazyRefEval(rptg.Row, rptg.Column, sre);
		}

		// Token: 0x06000732 RID: 1842 RVA: 0x00012CA8 File Offset: 0x00010EA8
		public global::NPOI.SS.Formula.Eval.ValueEval GetAreaEval(int firstRowIndex, int firstColumnIndex, int lastRowIndex, int lastColumnIndex)
		{
			global::NPOI.SS.Formula.SheetRangeEvaluator refEvaluatorForCurrentSheet = this.GetRefEvaluatorForCurrentSheet();
			return new global::NPOI.SS.Formula.LazyAreaEval(firstRowIndex, firstColumnIndex, lastRowIndex, lastColumnIndex, refEvaluatorForCurrentSheet);
		}

		// Token: 0x06000733 RID: 1843 RVA: 0x00012CC8 File Offset: 0x00010EC8
		public global::NPOI.SS.Formula.Eval.ValueEval GetArea3DEval(global::NPOI.SS.Formula.PTG.Area3DPtg aptg)
		{
			global::NPOI.SS.Formula.SheetRangeEvaluator evaluator = this.CreateExternSheetRefEvaluator(aptg.ExternSheetIndex);
			return new global::NPOI.SS.Formula.LazyAreaEval(aptg.FirstRow, aptg.FirstColumn, aptg.LastRow, aptg.LastColumn, evaluator);
		}

		// Token: 0x06000734 RID: 1844 RVA: 0x00012D00 File Offset: 0x00010F00
		public global::NPOI.SS.Formula.Eval.ValueEval GetArea3DEval(global::NPOI.SS.Formula.PTG.Area3DPxg aptg)
		{
			global::NPOI.SS.Formula.SheetRangeEvaluator evaluator = this.CreateExternSheetRefEvaluator(aptg.SheetName, aptg.LastSheetName, aptg.ExternalWorkbookNumber);
			return new global::NPOI.SS.Formula.LazyAreaEval(aptg.FirstRow, aptg.FirstColumn, aptg.LastRow, aptg.LastColumn, evaluator);
		}

		// Token: 0x06000735 RID: 1845 RVA: 0x00012D44 File Offset: 0x00010F44
		public global::NPOI.SS.Formula.Eval.ValueEval GetNameXEval(global::NPOI.SS.Formula.PTG.NameXPtg nameXPtg)
		{
			global::NPOI.SS.Formula.ExternalSheet externalSheet = this._workbook.GetExternalSheet(nameXPtg.SheetRefIndex);
			if (externalSheet == null || externalSheet.WorkbookName == null)
			{
				return this.GetLocalNameXEval(nameXPtg);
			}
			string workbookName = externalSheet.WorkbookName;
			global::NPOI.SS.Formula.ExternalName externalName = this._workbook.GetExternalName(nameXPtg.SheetRefIndex, nameXPtg.NameIndex);
			return this.GetExternalNameXEval(externalName, workbookName);
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x00012DA0 File Offset: 0x00010FA0
		public global::NPOI.SS.Formula.Eval.ValueEval GetNameXEval(global::NPOI.SS.Formula.PTG.NameXPxg nameXPxg)
		{
			global::NPOI.SS.Formula.ExternalSheet externalSheet = this._workbook.GetExternalSheet(nameXPxg.SheetName, null, nameXPxg.ExternalWorkbookNumber);
			if (externalSheet == null || externalSheet.WorkbookName == null)
			{
				return this.GetLocalNameXEval(nameXPxg);
			}
			string workbookName = externalSheet.WorkbookName;
			global::NPOI.SS.Formula.ExternalName externalName = this._workbook.GetExternalName(nameXPxg.NameName, nameXPxg.SheetName, nameXPxg.ExternalWorkbookNumber);
			return this.GetExternalNameXEval(externalName, workbookName);
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x00012E08 File Offset: 0x00011008
		private global::NPOI.SS.Formula.Eval.ValueEval GetLocalNameXEval(global::NPOI.SS.Formula.PTG.NameXPxg nameXPxg)
		{
			int sheetIndex = -1;
			if (nameXPxg.SheetName != null)
			{
				sheetIndex = this._workbook.GetSheetIndex(nameXPxg.SheetName);
			}
			string nameName = nameXPxg.NameName;
			global::NPOI.SS.Formula.IEvaluationName name = this._workbook.GetName(nameName, sheetIndex);
			if (name != null)
			{
				return new global::NPOI.SS.Formula.Eval.ExternalNameEval(name);
			}
			return new global::NPOI.SS.Formula.Eval.FunctionNameEval(nameName);
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x00012E58 File Offset: 0x00011058
		private global::NPOI.SS.Formula.Eval.ValueEval GetLocalNameXEval(global::NPOI.SS.Formula.PTG.NameXPtg nameXPtg)
		{
			string text = this._workbook.ResolveNameXText(nameXPtg);
			int num = text.IndexOf('!');
			global::NPOI.SS.Formula.IEvaluationName name2;
			if (num > -1)
			{
				string sheetName = text.Substring(0, num);
				string name = text.Substring(num + 1);
				name2 = this._workbook.GetName(name, this._workbook.GetSheetIndex(sheetName));
			}
			else
			{
				name2 = this._workbook.GetName(text, -1);
			}
			if (name2 != null)
			{
				return new global::NPOI.SS.Formula.Eval.ExternalNameEval(name2);
			}
			return new global::NPOI.SS.Formula.Eval.FunctionNameEval(text);
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x06000739 RID: 1849 RVA: 0x00012ECF File Offset: 0x000110CF
		public int SheetIndex
		{
			get
			{
				return this._sheetIndex;
			}
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x00012ED8 File Offset: 0x000110D8
		private global::NPOI.SS.Formula.Eval.ValueEval GetExternalNameXEval(global::NPOI.SS.Formula.ExternalName externName, string workbookName)
		{
			global::NPOI.SS.Formula.Eval.ValueEval ref_INVALID;
			try
			{
				global::NPOI.SS.Formula.WorkbookEvaluator otherWorkbookEvaluator = this._bookEvaluator.GetOtherWorkbookEvaluator(workbookName);
				global::NPOI.SS.Formula.IEvaluationName name = otherWorkbookEvaluator.GetName(externName.Name, externName.Ix - 1);
				if (name != null && name.HasFormula)
				{
					if (name.NameDefinition.Length > 1)
					{
						throw new global::System.Exception("Complex name formulas not supported yet");
					}
					global::NPOI.SS.Formula.OperationEvaluationContext operationEvaluationContext = new global::NPOI.SS.Formula.OperationEvaluationContext(otherWorkbookEvaluator, otherWorkbookEvaluator.Workbook, -1, -1, -1, this._tracker);
					global::NPOI.SS.Formula.PTG.Ptg ptg = name.NameDefinition[0];
					if (ptg is global::NPOI.SS.Formula.PTG.Ref3DPtg)
					{
						global::NPOI.SS.Formula.PTG.Ref3DPtg rptg = (global::NPOI.SS.Formula.PTG.Ref3DPtg)ptg;
						return operationEvaluationContext.GetRef3DEval(rptg);
					}
					if (ptg is global::NPOI.SS.Formula.PTG.Ref3DPxg)
					{
						global::NPOI.SS.Formula.PTG.Ref3DPxg rptg2 = (global::NPOI.SS.Formula.PTG.Ref3DPxg)ptg;
						return operationEvaluationContext.GetRef3DEval(rptg2);
					}
					if (ptg is global::NPOI.SS.Formula.PTG.Area3DPtg)
					{
						global::NPOI.SS.Formula.PTG.Area3DPtg aptg = (global::NPOI.SS.Formula.PTG.Area3DPtg)ptg;
						return operationEvaluationContext.GetArea3DEval(aptg);
					}
					if (ptg is global::NPOI.SS.Formula.PTG.Area3DPxg)
					{
						global::NPOI.SS.Formula.PTG.Area3DPxg aptg2 = (global::NPOI.SS.Formula.PTG.Area3DPxg)ptg;
						return operationEvaluationContext.GetArea3DEval(aptg2);
					}
				}
				ref_INVALID = global::NPOI.SS.Formula.Eval.ErrorEval.REF_INVALID;
			}
			catch (global::NPOI.SS.Formula.WorkbookNotFoundException)
			{
				ref_INVALID = global::NPOI.SS.Formula.Eval.ErrorEval.REF_INVALID;
			}
			return ref_INVALID;
		}

		// Token: 0x040003D3 RID: 979
		public static readonly global::NPOI.SS.Formula.Functions.FreeRefFunction UDF = global::NPOI.SS.Formula.UserDefinedFunction.instance;

		// Token: 0x040003D4 RID: 980
		private global::NPOI.SS.Formula.IEvaluationWorkbook _workbook;

		// Token: 0x040003D5 RID: 981
		private int _sheetIndex;

		// Token: 0x040003D6 RID: 982
		private int _rowIndex;

		// Token: 0x040003D7 RID: 983
		private int _columnIndex;

		// Token: 0x040003D8 RID: 984
		private global::NPOI.SS.Formula.EvaluationTracker _tracker;

		// Token: 0x040003D9 RID: 985
		private global::NPOI.SS.Formula.WorkbookEvaluator _bookEvaluator;
	}
}
