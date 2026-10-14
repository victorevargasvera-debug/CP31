using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x02000196 RID: 406
	public class Hlookup : global::NPOI.SS.Formula.Functions.Function
	{
		// Token: 0x06000B4E RID: 2894 RVA: 0x0001E780 File Offset: 0x0001C980
		public global::NPOI.SS.Formula.Eval.ValueEval Evaluate(global::NPOI.SS.Formula.Eval.ValueEval[] args, int srcCellRow, int srcCellCol)
		{
			global::NPOI.SS.Formula.Eval.ValueEval rangeLookupArg = null;
			int num = args.Length;
			if (num != 3)
			{
				if (num != 4)
				{
					return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
				}
				rangeLookupArg = args[3];
			}
			global::NPOI.SS.Formula.Eval.ValueEval result;
			try
			{
				global::NPOI.SS.Formula.Eval.ValueEval singleValue = global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(args[0], srcCellRow, srcCellCol);
				global::NPOI.SS.Formula.Eval.AreaEval tableArray = global::NPOI.SS.Formula.Functions.LookupUtils.ResolveTableArrayArg(args[1]);
				bool isRangeLookup = global::NPOI.SS.Formula.Functions.LookupUtils.ResolveRangeLookupArg(rangeLookupArg, srcCellRow, srcCellCol);
				int index = global::NPOI.SS.Formula.Functions.LookupUtils.LookupIndexOfValue(singleValue, global::NPOI.SS.Formula.Functions.LookupUtils.CreateRowVector(tableArray, 0), isRangeLookup);
				int rowIndex = global::NPOI.SS.Formula.Functions.LookupUtils.ResolveRowOrColIndexArg(args[2], srcCellRow, srcCellCol);
				result = this.CreateResultColumnVector(tableArray, rowIndex).GetItem(index);
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
			{
				result = ex.GetErrorEval();
			}
			return result;
		}

		// Token: 0x06000B4F RID: 2895 RVA: 0x0001E810 File Offset: 0x0001CA10
		private global::NPOI.SS.Formula.Functions.ValueVector CreateResultColumnVector(global::NPOI.SS.Formula.Eval.AreaEval tableArray, int rowIndex)
		{
			if (rowIndex >= tableArray.Height)
			{
				throw global::NPOI.SS.Formula.Eval.EvaluationException.InvalidRef();
			}
			return global::NPOI.SS.Formula.Functions.LookupUtils.CreateRowVector(tableArray, rowIndex);
		}
	}
}
