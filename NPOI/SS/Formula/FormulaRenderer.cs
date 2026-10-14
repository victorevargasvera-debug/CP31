using System;
using System.Collections;
using NPOI.SS.Formula.PTG;

namespace NPOI.SS.Formula
{
	// Token: 0x020000CA RID: 202
	public class FormulaRenderer
	{
		// Token: 0x060006EB RID: 1771 RVA: 0x00011CE4 File Offset: 0x0000FEE4
		public static string ToFormulaString(global::NPOI.SS.Formula.IFormulaRenderingWorkbook book, global::NPOI.SS.Formula.PTG.Ptg[] ptgs)
		{
			if (ptgs == null || ptgs.Length == 0)
			{
				throw new global::System.ArgumentException("ptgs must not be null");
			}
			global::System.Collections.Stack stack = new global::System.Collections.Stack();
			foreach (global::NPOI.SS.Formula.PTG.Ptg ptg in ptgs)
			{
				if (!(ptg is global::NPOI.SS.Formula.PTG.MemAreaPtg) && !(ptg is global::NPOI.SS.Formula.PTG.MemFuncPtg) && !(ptg is global::NPOI.SS.Formula.PTG.MemErrPtg))
				{
					if (ptg is global::NPOI.SS.Formula.PTG.ParenthesisPtg)
					{
						string str = (string)stack.Pop();
						stack.Push("(" + str + ")");
					}
					else if (ptg is global::NPOI.SS.Formula.PTG.AttrPtg)
					{
						global::NPOI.SS.Formula.PTG.AttrPtg attrPtg = (global::NPOI.SS.Formula.PTG.AttrPtg)ptg;
						if (!attrPtg.IsOptimizedIf && !attrPtg.IsOptimizedChoose && !attrPtg.IsSkip && !attrPtg.IsSpace && !attrPtg.IsSemiVolatile)
						{
							if (!attrPtg.IsSum)
							{
								throw new global::System.Exception("Unexpected tAttr: " + attrPtg.ToString());
							}
							string[] operands = global::NPOI.SS.Formula.FormulaRenderer.GetOperands(stack, attrPtg.NumberOfOperands);
							stack.Push(attrPtg.ToFormulaString(operands));
						}
					}
					else if (ptg is global::NPOI.SS.Formula.WorkbookDependentFormula)
					{
						global::NPOI.SS.Formula.WorkbookDependentFormula workbookDependentFormula = (global::NPOI.SS.Formula.WorkbookDependentFormula)ptg;
						stack.Push(workbookDependentFormula.ToFormulaString(book));
					}
					else if (!(ptg is global::NPOI.SS.Formula.PTG.OperationPtg))
					{
						stack.Push(ptg.ToFormulaString());
					}
					else
					{
						global::NPOI.SS.Formula.PTG.OperationPtg operationPtg = (global::NPOI.SS.Formula.PTG.OperationPtg)ptg;
						string[] operands2 = global::NPOI.SS.Formula.FormulaRenderer.GetOperands(stack, operationPtg.NumberOfOperands);
						stack.Push(operationPtg.ToFormulaString(operands2));
					}
				}
			}
			if (stack.Count == 0)
			{
				throw new global::System.InvalidOperationException("Stack underflow");
			}
			string result = (string)stack.Pop();
			if (stack.Count != 0)
			{
				throw new global::System.InvalidOperationException("too much stuff left on the stack");
			}
			return result;
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x00011E94 File Offset: 0x00010094
		private static string[] GetOperands(global::System.Collections.Stack stack, int nOperands)
		{
			string[] array = new string[nOperands];
			for (int i = nOperands - 1; i >= 0; i--)
			{
				if (stack.Count == 0)
				{
					throw new global::System.InvalidOperationException(string.Concat(new string[]
					{
						"Too few arguments supplied to operation. Expected (",
						nOperands.ToString(),
						") operands but got (",
						(nOperands - i - 1).ToString(),
						")"
					}));
				}
				array[i] = (string)stack.Pop();
			}
			return array;
		}
	}
}
