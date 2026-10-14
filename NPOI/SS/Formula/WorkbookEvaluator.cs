using System;
using System.Collections.Generic;
using System.Diagnostics;
using NPOI.SS.Formula.Atp;
using NPOI.SS.Formula.Eval;
using NPOI.SS.Formula.Functions;
using NPOI.SS.Formula.PTG;
using NPOI.SS.Formula.UDF;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using NPOI.Util;

namespace NPOI.SS.Formula
{
	// Token: 0x020000E1 RID: 225
	public class WorkbookEvaluator
	{
		// Token: 0x06000782 RID: 1922 RVA: 0x00014400 File Offset: 0x00012600
		public WorkbookEvaluator(global::NPOI.SS.Formula.IEvaluationWorkbook workbook, global::NPOI.SS.Formula.IStabilityClassifier stabilityClassifier, global::NPOI.SS.Formula.UDF.UDFFinder udfFinder) : this(workbook, null, stabilityClassifier, udfFinder)
		{
		}

		// Token: 0x06000783 RID: 1923 RVA: 0x0001440C File Offset: 0x0001260C
		public WorkbookEvaluator(global::NPOI.SS.Formula.IEvaluationWorkbook workbook, global::NPOI.SS.Formula.IEvaluationListener evaluationListener, global::NPOI.SS.Formula.IStabilityClassifier stabilityClassifier, global::NPOI.SS.Formula.UDF.UDFFinder udfFinder)
		{
			this._workbook = workbook;
			this._evaluationListener = evaluationListener;
			this._cache = new global::NPOI.SS.Formula.EvaluationCache(evaluationListener);
			this._sheetIndexesBySheet = new global::System.Collections.Generic.Dictionary<global::NPOI.SS.Formula.IEvaluationSheet, int>();
			this._sheetIndexesByName = new global::System.Collections.Generic.Dictionary<string, int>();
			this._collaboratingWorkbookEnvironment = global::NPOI.SS.Formula.CollaboratingWorkbooksEnvironment.EMPTY;
			this._workbookIx = 0;
			this._stabilityClassifier = stabilityClassifier;
			global::NPOI.SS.Formula.UDF.AggregatingUDFFinder aggregatingUDFFinder = (workbook == null) ? null : ((global::NPOI.SS.Formula.UDF.AggregatingUDFFinder)workbook.GetUDFFinder());
			if (aggregatingUDFFinder != null && udfFinder != null)
			{
				aggregatingUDFFinder.Add(udfFinder);
			}
			this._udfFinder = aggregatingUDFFinder;
		}

		// Token: 0x06000784 RID: 1924 RVA: 0x000144A7 File Offset: 0x000126A7
		public string GetSheetName(int sheetIndex)
		{
			return this._workbook.GetSheetName(sheetIndex);
		}

		// Token: 0x06000785 RID: 1925 RVA: 0x000144B5 File Offset: 0x000126B5
		public global::NPOI.SS.Formula.WorkbookEvaluator GetOtherWorkbookEvaluator(string workbookName)
		{
			return this._collaboratingWorkbookEnvironment.GetWorkbookEvaluator(workbookName);
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x06000786 RID: 1926 RVA: 0x000144C3 File Offset: 0x000126C3
		internal global::NPOI.SS.Formula.IEvaluationWorkbook Workbook
		{
			get
			{
				return this._workbook;
			}
		}

		// Token: 0x06000787 RID: 1927 RVA: 0x000144CB File Offset: 0x000126CB
		internal global::NPOI.SS.Formula.IEvaluationSheet GetSheet(int sheetIndex)
		{
			return this._workbook.GetSheet(sheetIndex);
		}

		// Token: 0x06000788 RID: 1928 RVA: 0x000144D9 File Offset: 0x000126D9
		internal global::NPOI.SS.Formula.IEvaluationName GetName(string name, int sheetIndex)
		{
			return this._workbook.GetName(name, sheetIndex);
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x00006EB4 File Offset: 0x000050B4
		private static bool IsDebugLogEnabled()
		{
			return false;
		}

		// Token: 0x0600078A RID: 1930 RVA: 0x00008875 File Offset: 0x00006A75
		private static bool IsInfoLogEnabled()
		{
			return true;
		}

		// Token: 0x0600078B RID: 1931 RVA: 0x000144E8 File Offset: 0x000126E8
		private static void LogDebug(string s)
		{
			global::NPOI.SS.Formula.WorkbookEvaluator.IsDebugLogEnabled();
		}

		// Token: 0x0600078C RID: 1932 RVA: 0x000144F0 File Offset: 0x000126F0
		private static void LogInfo(string s)
		{
			if (global::NPOI.SS.Formula.WorkbookEvaluator.IsInfoLogEnabled())
			{
				global::System.Diagnostics.Trace.WriteLine(s);
			}
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x000144FF File Offset: 0x000126FF
		public void AttachToEnvironment(global::NPOI.SS.Formula.CollaboratingWorkbooksEnvironment collaboratingWorkbooksEnvironment, global::NPOI.SS.Formula.EvaluationCache cache, int workbookIx)
		{
			this._collaboratingWorkbookEnvironment = collaboratingWorkbooksEnvironment;
			this._cache = cache;
			this._workbookIx = workbookIx;
		}

		// Token: 0x0600078E RID: 1934 RVA: 0x00014516 File Offset: 0x00012716
		public global::NPOI.SS.Formula.CollaboratingWorkbooksEnvironment GetEnvironment()
		{
			return this._collaboratingWorkbookEnvironment;
		}

		// Token: 0x0600078F RID: 1935 RVA: 0x0001451E File Offset: 0x0001271E
		public void DetachFromEnvironment()
		{
			this._collaboratingWorkbookEnvironment = global::NPOI.SS.Formula.CollaboratingWorkbooksEnvironment.EMPTY;
			this._cache = new global::NPOI.SS.Formula.EvaluationCache(this._evaluationListener);
			this._workbookIx = 0;
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x00014543 File Offset: 0x00012743
		public global::NPOI.SS.Formula.IEvaluationListener GetEvaluationListener()
		{
			return this._evaluationListener;
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x0001454B File Offset: 0x0001274B
		public void ClearAllCachedResultValues()
		{
			this._cache.Clear();
			this._sheetIndexesBySheet.Clear();
			this._workbook.ClearAllCachedResultValues();
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x00014570 File Offset: 0x00012770
		public void NotifyUpdateCell(global::NPOI.SS.Formula.IEvaluationCell cell)
		{
			int sheetIndex = this.GetSheetIndex(cell.Sheet);
			this._cache.NotifyUpdateCell(this._workbookIx, sheetIndex, cell);
		}

		// Token: 0x06000793 RID: 1939 RVA: 0x000145A0 File Offset: 0x000127A0
		public void NotifyDeleteCell(global::NPOI.SS.Formula.IEvaluationCell cell)
		{
			int sheetIndex = this.GetSheetIndex(cell.Sheet);
			this._cache.NotifyDeleteCell(this._workbookIx, sheetIndex, cell);
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x000145D0 File Offset: 0x000127D0
		public int GetSheetIndex(global::NPOI.SS.Formula.IEvaluationSheet sheet)
		{
			int num = int.MinValue;
			if (this._sheetIndexesBySheet.ContainsKey(sheet))
			{
				num = this._sheetIndexesBySheet[sheet];
			}
			if (num == -2147483648)
			{
				int sheetIndex = this._workbook.GetSheetIndex(sheet);
				if (sheetIndex < 0)
				{
					throw new global::System.Exception("Specified sheet from a different book");
				}
				num = sheetIndex;
				this._sheetIndexesBySheet[sheet] = num;
			}
			return num;
		}

		// Token: 0x06000795 RID: 1941 RVA: 0x00014630 File Offset: 0x00012830
		internal int GetSheetIndexByExternIndex(int externSheetIndex)
		{
			return this._workbook.ConvertFromExternSheetIndex(externSheetIndex);
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x00014640 File Offset: 0x00012840
		public int GetSheetIndex(string sheetName)
		{
			int num;
			if (this._sheetIndexesByName.ContainsKey(sheetName))
			{
				num = this._sheetIndexesByName[sheetName];
			}
			else
			{
				int sheetIndex = this._workbook.GetSheetIndex(sheetName);
				if (sheetIndex < 0)
				{
					return -1;
				}
				num = sheetIndex;
				this._sheetIndexesByName[sheetName] = num;
			}
			return num;
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x00014690 File Offset: 0x00012890
		public global::NPOI.SS.Formula.Eval.ValueEval Evaluate(global::NPOI.SS.Formula.IEvaluationCell srcCell)
		{
			int sheetIndex = this.GetSheetIndex(srcCell.Sheet);
			return this.EvaluateAny(srcCell, sheetIndex, srcCell.RowIndex, srcCell.ColumnIndex, new global::NPOI.SS.Formula.EvaluationTracker(this._cache));
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x000146CC File Offset: 0x000128CC
		private global::NPOI.SS.Formula.Eval.ValueEval EvaluateAny(global::NPOI.SS.Formula.IEvaluationCell srcCell, int sheetIndex, int rowIndex, int columnIndex, global::NPOI.SS.Formula.EvaluationTracker tracker)
		{
			bool flag = this._stabilityClassifier == null || !this._stabilityClassifier.IsCellFinal(sheetIndex, rowIndex, columnIndex);
			if (srcCell == null || srcCell.CellType != global::NPOI.SS.UserModel.CellType.Formula)
			{
				global::NPOI.SS.Formula.Eval.ValueEval valueEval = global::NPOI.SS.Formula.WorkbookEvaluator.GetValueFromNonFormulaCell(srcCell);
				if (flag)
				{
					tracker.AcceptPlainValueDependency(this._workbookIx, sheetIndex, rowIndex, columnIndex, valueEval);
				}
				return valueEval;
			}
			global::NPOI.SS.Formula.FormulaCellCacheEntry orCreateFormulaCellEntry = this._cache.GetOrCreateFormulaCellEntry(srcCell);
			if (flag || orCreateFormulaCellEntry.IsInputSensitive)
			{
				tracker.AcceptFormulaDependency(orCreateFormulaCellEntry);
			}
			global::NPOI.SS.Formula.IEvaluationListener evaluationListener = this._evaluationListener;
			if (orCreateFormulaCellEntry.GetValue() == null)
			{
				if (!tracker.StartEvaluate(orCreateFormulaCellEntry))
				{
					return global::NPOI.SS.Formula.Eval.ErrorEval.CIRCULAR_REF_ERROR;
				}
				global::NPOI.SS.Formula.OperationEvaluationContext ec = new global::NPOI.SS.Formula.OperationEvaluationContext(this, this._workbook, sheetIndex, rowIndex, columnIndex, tracker);
				global::NPOI.SS.Formula.Eval.ValueEval valueEval;
				try
				{
					global::NPOI.SS.Formula.PTG.Ptg[] formulaTokens = this._workbook.GetFormulaTokens(srcCell);
					if (evaluationListener == null)
					{
						valueEval = this.EvaluateFormula(ec, formulaTokens);
					}
					else
					{
						evaluationListener.OnStartEvaluate(srcCell, orCreateFormulaCellEntry);
						valueEval = this.EvaluateFormula(ec, formulaTokens);
						evaluationListener.OnEndEvaluate(orCreateFormulaCellEntry, valueEval);
					}
					tracker.UpdateCacheResult(valueEval);
					goto IL_1E7;
				}
				catch (global::System.NotImplementedException inner)
				{
					throw this.AddExceptionInfo(inner, sheetIndex, rowIndex, columnIndex);
				}
				catch (global::NPOI.Util.RuntimeException ex)
				{
					if (ex.InnerException is global::NPOI.SS.Formula.WorkbookNotFoundException && this._ignoreMissingWorkbooks)
					{
						global::NPOI.SS.Formula.WorkbookEvaluator.LogInfo(ex.InnerException.Message + " - Continuing with cached value!");
						switch (srcCell.CachedFormulaResultType)
						{
						case global::NPOI.SS.UserModel.CellType.Numeric:
							valueEval = new global::NPOI.SS.Formula.Eval.NumberEval(srcCell.NumericCellValue);
							goto IL_1C2;
						case global::NPOI.SS.UserModel.CellType.String:
							valueEval = new global::NPOI.SS.Formula.Eval.StringEval(srcCell.StringCellValue);
							goto IL_1C2;
						case global::NPOI.SS.UserModel.CellType.Blank:
							valueEval = global::NPOI.SS.Formula.Eval.BlankEval.instance;
							goto IL_1C2;
						case global::NPOI.SS.UserModel.CellType.Boolean:
							valueEval = global::NPOI.SS.Formula.Eval.BoolEval.ValueOf(srcCell.BooleanCellValue);
							goto IL_1C2;
						case global::NPOI.SS.UserModel.CellType.Error:
							valueEval = global::NPOI.SS.Formula.Eval.ErrorEval.ValueOf(srcCell.ErrorCellValue);
							goto IL_1C2;
						}
						throw new global::NPOI.Util.RuntimeException("Unexpected cell type '" + srcCell.CellType.ToString() + "' found!");
						IL_1C2:
						goto IL_1E7;
					}
					throw ex;
				}
				finally
				{
					tracker.EndEvaluate(orCreateFormulaCellEntry);
				}
				goto IL_1CD;
				IL_1E7:
				if (global::NPOI.SS.Formula.WorkbookEvaluator.IsDebugLogEnabled())
				{
					string sheetName = this.GetSheetName(sheetIndex);
					global::NPOI.SS.Util.CellReference cellReference = new global::NPOI.SS.Util.CellReference(rowIndex, columnIndex);
					string[] array = new string[6];
					array[0] = "Evaluated ";
					array[1] = sheetName;
					array[2] = "!";
					array[3] = cellReference.FormatAsString();
					array[4] = " To ";
					int num = 5;
					global::NPOI.SS.Formula.Eval.ValueEval value = orCreateFormulaCellEntry.GetValue();
					array[num] = ((value != null) ? value.ToString() : null);
					global::NPOI.SS.Formula.WorkbookEvaluator.LogDebug(string.Concat(array));
				}
				return valueEval;
			}
			IL_1CD:
			if (evaluationListener != null)
			{
				evaluationListener.OnCacheHit(sheetIndex, rowIndex, columnIndex, orCreateFormulaCellEntry.GetValue());
			}
			return orCreateFormulaCellEntry.GetValue();
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x00014974 File Offset: 0x00012B74
		private global::System.NotImplementedException AddExceptionInfo(global::System.NotImplementedException inner, int sheetIndex, int rowIndex, int columnIndex)
		{
			global::System.NotImplementedException result;
			try
			{
				global::NPOI.SS.Util.CellReference cellReference = new global::NPOI.SS.Util.CellReference(this._workbook.GetSheetName(sheetIndex), rowIndex, columnIndex, false, false);
				result = new global::System.NotImplementedException("Error evaluating cell " + cellReference.FormatAsString(), inner);
			}
			catch (global::System.Exception)
			{
				result = inner;
			}
			return result;
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x000149C8 File Offset: 0x00012BC8
		internal static global::NPOI.SS.Formula.Eval.ValueEval GetValueFromNonFormulaCell(global::NPOI.SS.Formula.IEvaluationCell cell)
		{
			if (cell == null)
			{
				return global::NPOI.SS.Formula.Eval.BlankEval.instance;
			}
			global::NPOI.SS.UserModel.CellType cellType = cell.CellType;
			switch (cellType)
			{
			case global::NPOI.SS.UserModel.CellType.Numeric:
				return new global::NPOI.SS.Formula.Eval.NumberEval(cell.NumericCellValue);
			case global::NPOI.SS.UserModel.CellType.String:
				return new global::NPOI.SS.Formula.Eval.StringEval(cell.StringCellValue);
			case global::NPOI.SS.UserModel.CellType.Blank:
				return global::NPOI.SS.Formula.Eval.BlankEval.instance;
			case global::NPOI.SS.UserModel.CellType.Boolean:
				return global::NPOI.SS.Formula.Eval.BoolEval.ValueOf(cell.BooleanCellValue);
			case global::NPOI.SS.UserModel.CellType.Error:
				return global::NPOI.SS.Formula.Eval.ErrorEval.ValueOf(cell.ErrorCellValue);
			}
			throw new global::System.Exception("Unexpected cell type (" + cellType.ToString() + ")");
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x00014A5C File Offset: 0x00012C5C
		public global::NPOI.SS.Formula.Eval.ValueEval EvaluateFormula(global::NPOI.SS.Formula.OperationEvaluationContext ec, global::NPOI.SS.Formula.PTG.Ptg[] ptgs)
		{
			string text = "";
			if (this.dbgEvaluationOutputForNextEval)
			{
				this.dbgEvaluationOutputIndent = 1;
				this.dbgEvaluationOutputForNextEval = false;
			}
			if (this.dbgEvaluationOutputIndent > 0)
			{
				text = "                                                                                                    ";
				text = text.Substring(0, global::System.Math.Min(text.Length, this.dbgEvaluationOutputIndent * 2));
				this.EVAL_LOG.Log(5, string.Concat(new string[]
				{
					text,
					"- evaluateFormula('",
					ec.GetRefEvaluatorForCurrentSheet().SheetNameRange,
					"'/",
					new global::NPOI.SS.Util.CellReference(ec.RowIndex, ec.ColumnIndex).FormatAsString(),
					"): ",
					global::NPOI.Util.Arrays.ToString(ptgs).Replace("\\Qorg.apache.poi.ss.formula.ptg.\\E", "")
				}));
				this.dbgEvaluationOutputIndent++;
			}
			global::System.Collections.Generic.Stack<global::NPOI.SS.Formula.Eval.ValueEval> stack = new global::System.Collections.Generic.Stack<global::NPOI.SS.Formula.Eval.ValueEval>();
			int i = 0;
			int num = ptgs.Length;
			while (i < num)
			{
				global::NPOI.SS.Formula.PTG.Ptg ptg = ptgs[i];
				if (this.dbgEvaluationOutputIndent > 0)
				{
					this.EVAL_LOG.Log(3, string.Concat(new string[]
					{
						text,
						"  * ptg ",
						i.ToString(),
						": ",
						ptg.ToString()
					}));
				}
				if (!(ptg is global::NPOI.SS.Formula.PTG.AttrPtg))
				{
					goto IL_323;
				}
				global::NPOI.SS.Formula.PTG.AttrPtg attrPtg = (global::NPOI.SS.Formula.PTG.AttrPtg)ptg;
				if (attrPtg.IsSum)
				{
					ptg = global::NPOI.SS.Formula.PTG.FuncVarPtg.SUM;
				}
				if (attrPtg.IsOptimizedChoose)
				{
					global::NPOI.SS.Formula.Eval.ValueEval arg = stack.Pop();
					int[] jumpTable = attrPtg.JumpTable;
					int num2 = jumpTable.Length;
					int num4;
					try
					{
						int num3 = global::NPOI.SS.Formula.Functions.Choose.EvaluateFirstArg(arg, ec.RowIndex, ec.ColumnIndex);
						if (num3 < 1 || num3 > num2)
						{
							stack.Push(global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID);
							num4 = attrPtg.ChooseFuncOffset + 4;
						}
						else
						{
							num4 = jumpTable[num3 - 1];
						}
					}
					catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
					{
						stack.Push(ex.GetErrorEval());
						num4 = attrPtg.ChooseFuncOffset + 4;
					}
					num4 -= num2 * 2 + 2;
					i += global::NPOI.SS.Formula.WorkbookEvaluator.CountTokensToBeSkipped(ptgs, i, num4);
				}
				else if (attrPtg.IsOptimizedIf)
				{
					global::NPOI.SS.Formula.Eval.ValueEval arg2 = stack.Pop();
					bool flag;
					try
					{
						flag = global::NPOI.SS.Formula.Functions.IfFunc.EvaluateFirstArg(arg2, ec.RowIndex, ec.ColumnIndex);
					}
					catch (global::NPOI.SS.Formula.Eval.EvaluationException ex2)
					{
						stack.Push(ex2.GetErrorEval());
						int distInBytes = (int)attrPtg.Data;
						i += global::NPOI.SS.Formula.WorkbookEvaluator.CountTokensToBeSkipped(ptgs, i, distInBytes);
						attrPtg = (global::NPOI.SS.Formula.PTG.AttrPtg)ptgs[i];
						distInBytes = (int)(attrPtg.Data + 1);
						i += global::NPOI.SS.Formula.WorkbookEvaluator.CountTokensToBeSkipped(ptgs, i, distInBytes);
						goto IL_3F7;
					}
					if (!flag)
					{
						int data = (int)attrPtg.Data;
						i += global::NPOI.SS.Formula.WorkbookEvaluator.CountTokensToBeSkipped(ptgs, i, data);
						global::NPOI.SS.Formula.PTG.Ptg ptg2 = ptgs[i + 1];
						if (ptgs[i] is global::NPOI.SS.Formula.PTG.AttrPtg && ptg2 is global::NPOI.SS.Formula.PTG.FuncVarPtg && ((global::NPOI.SS.Formula.PTG.FuncVarPtg)ptg2).FunctionIndex == 1)
						{
							i++;
							stack.Push(global::NPOI.SS.Formula.Eval.BoolEval.FALSE);
						}
					}
				}
				else
				{
					if (!attrPtg.IsSkip)
					{
						goto IL_323;
					}
					int distInBytes2 = (int)(attrPtg.Data + 1);
					i += global::NPOI.SS.Formula.WorkbookEvaluator.CountTokensToBeSkipped(ptgs, i, distInBytes2);
					if (stack.Peek() == global::NPOI.SS.Formula.Eval.MissingArgEval.instance)
					{
						stack.Pop();
						stack.Push(global::NPOI.SS.Formula.Eval.BlankEval.instance);
					}
				}
				IL_3F7:
				i++;
				continue;
				IL_323:
				if (ptg is global::NPOI.SS.Formula.PTG.ControlPtg || ptg is global::NPOI.SS.Formula.PTG.MemFuncPtg || ptg is global::NPOI.SS.Formula.PTG.MemAreaPtg || ptg is global::NPOI.SS.Formula.PTG.MemErrPtg)
				{
					goto IL_3F7;
				}
				global::NPOI.SS.Formula.Eval.ValueEval valueEval2;
				if (ptg is global::NPOI.SS.Formula.PTG.OperationPtg)
				{
					global::NPOI.SS.Formula.PTG.OperationPtg operationPtg = (global::NPOI.SS.Formula.PTG.OperationPtg)ptg;
					if (operationPtg is global::NPOI.SS.Formula.PTG.UnionPtg)
					{
						goto IL_3F7;
					}
					int numberOfOperands = operationPtg.NumberOfOperands;
					global::NPOI.SS.Formula.Eval.ValueEval[] array = new global::NPOI.SS.Formula.Eval.ValueEval[numberOfOperands];
					for (int j = numberOfOperands - 1; j >= 0; j--)
					{
						global::NPOI.SS.Formula.Eval.ValueEval valueEval = stack.Pop();
						array[j] = valueEval;
					}
					valueEval2 = global::NPOI.SS.Formula.OperationEvaluatorFactory.Evaluate(operationPtg, array, ec);
				}
				else
				{
					valueEval2 = this.GetEvalForPtg(ptg, ec);
				}
				if (valueEval2 == null)
				{
					throw new global::System.Exception("Evaluation result must not be null");
				}
				stack.Push(valueEval2);
				if (this.dbgEvaluationOutputIndent > 0)
				{
					this.EVAL_LOG.Log(3, text + "    = " + valueEval2.ToString());
					goto IL_3F7;
				}
				goto IL_3F7;
			}
			global::NPOI.SS.Formula.Eval.ValueEval evaluationResult = stack.Pop();
			if (stack.Count != 0)
			{
				throw new global::System.InvalidOperationException("evaluation stack not empty");
			}
			global::NPOI.SS.Formula.Eval.ValueEval valueEval3 = global::NPOI.SS.Formula.WorkbookEvaluator.DereferenceResult(evaluationResult, ec.RowIndex, ec.ColumnIndex);
			if (this.dbgEvaluationOutputIndent > 0)
			{
				this.EVAL_LOG.Log(3, string.Concat(new string[]
				{
					text,
					"finshed eval of ",
					new global::NPOI.SS.Util.CellReference(ec.RowIndex, ec.ColumnIndex).FormatAsString(),
					": ",
					valueEval3.ToString()
				}));
				this.dbgEvaluationOutputIndent--;
				if (this.dbgEvaluationOutputIndent == 1)
				{
					this.dbgEvaluationOutputIndent = -1;
				}
			}
			return valueEval3;
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x00014F30 File Offset: 0x00013130
		private static int CountTokensToBeSkipped(global::NPOI.SS.Formula.PTG.Ptg[] ptgs, int startIndex, int distInBytes)
		{
			int num = distInBytes;
			int num2 = startIndex;
			while (num != 0)
			{
				num2++;
				num -= ptgs[num2].Size;
				if (num < 0)
				{
					throw new global::System.Exception("Bad skip distance (wrong token size calculation).");
				}
				if (num2 >= ptgs.Length)
				{
					throw new global::System.Exception("Skip distance too far (ran out of formula tokens).");
				}
			}
			return num2 - startIndex;
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x00014F78 File Offset: 0x00013178
		public static global::NPOI.SS.Formula.Eval.ValueEval DereferenceResult(global::NPOI.SS.Formula.Eval.ValueEval evaluationResult, int srcRowNum, int srcColNum)
		{
			global::NPOI.SS.Formula.Eval.ValueEval singleValue;
			try
			{
				singleValue = global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(evaluationResult, srcRowNum, srcColNum);
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
			{
				return ex.GetErrorEval();
			}
			if (singleValue == global::NPOI.SS.Formula.Eval.BlankEval.instance)
			{
				return global::NPOI.SS.Formula.Eval.NumberEval.ZERO;
			}
			return singleValue;
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x00014FBC File Offset: 0x000131BC
		private global::NPOI.SS.Formula.Eval.ValueEval GetEvalForPtg(global::NPOI.SS.Formula.PTG.Ptg ptg, global::NPOI.SS.Formula.OperationEvaluationContext ec)
		{
			if (ptg is global::NPOI.SS.Formula.PTG.NamePtg)
			{
				global::NPOI.SS.Formula.PTG.NamePtg namePtg = (global::NPOI.SS.Formula.PTG.NamePtg)ptg;
				global::NPOI.SS.Formula.IEvaluationName name = this._workbook.GetName(namePtg);
				return this.GetEvalForNameRecord(name, ec);
			}
			if (ptg is global::NPOI.SS.Formula.PTG.NameXPtg)
			{
				return this.ProcessNameEval(ec.GetNameXEval((global::NPOI.SS.Formula.PTG.NameXPtg)ptg), ec);
			}
			if (ptg is global::NPOI.SS.Formula.PTG.NameXPxg)
			{
				return this.ProcessNameEval(ec.GetNameXEval((global::NPOI.SS.Formula.PTG.NameXPxg)ptg), ec);
			}
			if (ptg is global::NPOI.SS.Formula.PTG.IntPtg)
			{
				return new global::NPOI.SS.Formula.Eval.NumberEval((double)((global::NPOI.SS.Formula.PTG.IntPtg)ptg).Value);
			}
			if (ptg is global::NPOI.SS.Formula.PTG.NumberPtg)
			{
				return new global::NPOI.SS.Formula.Eval.NumberEval(((global::NPOI.SS.Formula.PTG.NumberPtg)ptg).Value);
			}
			if (ptg is global::NPOI.SS.Formula.PTG.StringPtg)
			{
				return new global::NPOI.SS.Formula.Eval.StringEval(((global::NPOI.SS.Formula.PTG.StringPtg)ptg).Value);
			}
			if (ptg is global::NPOI.SS.Formula.PTG.BoolPtg)
			{
				return global::NPOI.SS.Formula.Eval.BoolEval.ValueOf(((global::NPOI.SS.Formula.PTG.BoolPtg)ptg).Value);
			}
			if (ptg is global::NPOI.SS.Formula.PTG.ErrPtg)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.ValueOf(((global::NPOI.SS.Formula.PTG.ErrPtg)ptg).ErrorCode);
			}
			if (ptg is global::NPOI.SS.Formula.PTG.MissingArgPtg)
			{
				return global::NPOI.SS.Formula.Eval.MissingArgEval.instance;
			}
			if (ptg is global::NPOI.SS.Formula.PTG.AreaErrPtg || ptg is global::NPOI.SS.Formula.PTG.RefErrorPtg || ptg is global::NPOI.SS.Formula.PTG.DeletedArea3DPtg || ptg is global::NPOI.SS.Formula.PTG.DeletedRef3DPtg)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.REF_INVALID;
			}
			if (ptg is global::NPOI.SS.Formula.PTG.Ref3DPtg)
			{
				return ec.GetRef3DEval((global::NPOI.SS.Formula.PTG.Ref3DPtg)ptg);
			}
			if (ptg is global::NPOI.SS.Formula.PTG.Ref3DPxg)
			{
				return ec.GetRef3DEval((global::NPOI.SS.Formula.PTG.Ref3DPxg)ptg);
			}
			if (ptg is global::NPOI.SS.Formula.PTG.Area3DPtg)
			{
				return ec.GetArea3DEval((global::NPOI.SS.Formula.PTG.Area3DPtg)ptg);
			}
			if (ptg is global::NPOI.SS.Formula.PTG.Area3DPxg)
			{
				return ec.GetArea3DEval((global::NPOI.SS.Formula.PTG.Area3DPxg)ptg);
			}
			if (ptg is global::NPOI.SS.Formula.PTG.RefPtg)
			{
				global::NPOI.SS.Formula.PTG.RefPtg refPtg = (global::NPOI.SS.Formula.PTG.RefPtg)ptg;
				return ec.GetRefEval(refPtg.Row, refPtg.Column);
			}
			if (ptg is global::NPOI.SS.Formula.PTG.AreaPtg)
			{
				global::NPOI.SS.Formula.PTG.AreaPtg areaPtg = (global::NPOI.SS.Formula.PTG.AreaPtg)ptg;
				return ec.GetAreaEval(areaPtg.FirstRow, areaPtg.FirstColumn, areaPtg.LastRow, areaPtg.LastColumn);
			}
			if (ptg is global::NPOI.SS.Formula.PTG.UnknownPtg)
			{
				throw new global::NPOI.Util.RuntimeException("UnknownPtg not allowed");
			}
			if (ptg is global::NPOI.SS.Formula.PTG.ExpPtg)
			{
				throw new global::NPOI.Util.RuntimeException("ExpPtg currently not supported");
			}
			throw new global::NPOI.Util.RuntimeException("Unexpected ptg class (" + ptg.GetType().Name + ")");
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x000151C4 File Offset: 0x000133C4
		private global::NPOI.SS.Formula.Eval.ValueEval ProcessNameEval(global::NPOI.SS.Formula.Eval.ValueEval eval, global::NPOI.SS.Formula.OperationEvaluationContext ec)
		{
			if (eval is global::NPOI.SS.Formula.Eval.ExternalNameEval)
			{
				global::NPOI.SS.Formula.IEvaluationName name = ((global::NPOI.SS.Formula.Eval.ExternalNameEval)eval).Name;
				return this.GetEvalForNameRecord(name, ec);
			}
			return eval;
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x000151F0 File Offset: 0x000133F0
		private global::NPOI.SS.Formula.Eval.ValueEval GetEvalForNameRecord(global::NPOI.SS.Formula.IEvaluationName nameRecord, global::NPOI.SS.Formula.OperationEvaluationContext ec)
		{
			if (nameRecord.IsFunctionName)
			{
				return new global::NPOI.SS.Formula.Eval.FunctionNameEval(nameRecord.NameText);
			}
			if (nameRecord.HasFormula)
			{
				return this.EvaluateNameFormula(nameRecord.NameDefinition, ec);
			}
			throw new global::System.Exception("Don't now how to Evalate name '" + nameRecord.NameText + "'");
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x00015241 File Offset: 0x00013441
		internal global::NPOI.SS.Formula.Eval.ValueEval EvaluateNameFormula(global::NPOI.SS.Formula.PTG.Ptg[] ptgs, global::NPOI.SS.Formula.OperationEvaluationContext ec)
		{
			if (ptgs.Length == 1)
			{
				return this.GetEvalForPtg(ptgs[0], ec);
			}
			return this.EvaluateFormula(ec, ptgs);
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x0001525C File Offset: 0x0001345C
		public global::NPOI.SS.Formula.Eval.ValueEval EvaluateReference(global::NPOI.SS.Formula.IEvaluationSheet sheet, int sheetIndex, int rowIndex, int columnIndex, global::NPOI.SS.Formula.EvaluationTracker tracker)
		{
			global::NPOI.SS.Formula.IEvaluationCell cell = sheet.GetCell(rowIndex, columnIndex);
			return this.EvaluateAny(cell, sheetIndex, rowIndex, columnIndex, tracker);
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x00015280 File Offset: 0x00013480
		public global::NPOI.SS.Formula.Functions.FreeRefFunction FindUserDefinedFunction(string functionName)
		{
			return this._udfFinder.FindFunction(functionName);
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x060007A4 RID: 1956 RVA: 0x0001528E File Offset: 0x0001348E
		// (set) Token: 0x060007A5 RID: 1957 RVA: 0x00015296 File Offset: 0x00013496
		public bool IgnoreMissingWorkbooks
		{
			get
			{
				return this._ignoreMissingWorkbooks;
			}
			set
			{
				this._ignoreMissingWorkbooks = value;
			}
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x0001529F File Offset: 0x0001349F
		public static global::System.Collections.Generic.IList<string> GetSupportedFunctionNames()
		{
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			list.AddRange(global::NPOI.SS.Formula.Eval.FunctionEval.GetSupportedFunctionNames());
			list.AddRange(global::NPOI.SS.Formula.Atp.AnalysisToolPak.GetSupportedFunctionNames());
			return list.AsReadOnly();
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x000152C1 File Offset: 0x000134C1
		public static global::System.Collections.Generic.IList<string> GetNotSupportedFunctionNames()
		{
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			list.AddRange(global::NPOI.SS.Formula.Eval.FunctionEval.GetNotSupportedFunctionNames());
			list.AddRange(global::NPOI.SS.Formula.Atp.AnalysisToolPak.GetNotSupportedFunctionNames());
			return list.AsReadOnly();
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x000152E3 File Offset: 0x000134E3
		public static void RegisterFunction(string name, global::NPOI.SS.Formula.Functions.FreeRefFunction func)
		{
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.RegisterFunction(name, func);
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x000152EC File Offset: 0x000134EC
		public static void RegisterFunction(string name, global::NPOI.SS.Formula.Functions.Function func)
		{
			global::NPOI.SS.Formula.Eval.FunctionEval.RegisterFunction(name, func);
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x060007AA RID: 1962 RVA: 0x000152F5 File Offset: 0x000134F5
		// (set) Token: 0x060007AB RID: 1963 RVA: 0x000152FD File Offset: 0x000134FD
		public bool DebugEvaluationOutputForNextEval
		{
			get
			{
				return this.dbgEvaluationOutputForNextEval;
			}
			set
			{
				this.dbgEvaluationOutputForNextEval = value;
			}
		}

		// Token: 0x040003F8 RID: 1016
		private global::NPOI.SS.Formula.IEvaluationWorkbook _workbook;

		// Token: 0x040003F9 RID: 1017
		private global::NPOI.SS.Formula.EvaluationCache _cache;

		// Token: 0x040003FA RID: 1018
		private int _workbookIx;

		// Token: 0x040003FB RID: 1019
		private global::NPOI.SS.Formula.IEvaluationListener _evaluationListener;

		// Token: 0x040003FC RID: 1020
		private global::System.Collections.Generic.Dictionary<global::NPOI.SS.Formula.IEvaluationSheet, int> _sheetIndexesBySheet;

		// Token: 0x040003FD RID: 1021
		private global::System.Collections.Generic.Dictionary<string, int> _sheetIndexesByName;

		// Token: 0x040003FE RID: 1022
		private global::NPOI.SS.Formula.CollaboratingWorkbooksEnvironment _collaboratingWorkbookEnvironment;

		// Token: 0x040003FF RID: 1023
		private global::NPOI.SS.Formula.IStabilityClassifier _stabilityClassifier;

		// Token: 0x04000400 RID: 1024
		private global::NPOI.SS.Formula.UDF.UDFFinder _udfFinder;

		// Token: 0x04000401 RID: 1025
		private bool _ignoreMissingWorkbooks;

		// Token: 0x04000402 RID: 1026
		private bool dbgEvaluationOutputForNextEval;

		// Token: 0x04000403 RID: 1027
		private global::NPOI.Util.POILogger EVAL_LOG = global::NPOI.Util.POILogFactory.GetLogger("POI.FormulaEval");

		// Token: 0x04000404 RID: 1028
		private int dbgEvaluationOutputIndent = -1;
	}
}
