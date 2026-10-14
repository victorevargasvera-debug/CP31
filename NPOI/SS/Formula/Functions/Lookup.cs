using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001A6 RID: 422
	public class Lookup : global::NPOI.SS.Formula.Functions.Function
	{
		// Token: 0x06000B83 RID: 2947 RVA: 0x0001F278 File Offset: 0x0001D478
		public global::NPOI.SS.Formula.Eval.ValueEval Evaluate(global::NPOI.SS.Formula.Eval.ValueEval[] args, int srcCellRow, int srcCellCol)
		{
			int num = args.Length;
			if (num == 2)
			{
				throw new global::System.Exception("Two arg version of LOOKUP not supported yet");
			}
			if (num != 3)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
			global::NPOI.SS.Formula.Eval.ValueEval result;
			try
			{
				global::NPOI.SS.Formula.Eval.ValueEval singleValue = global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(args[0], srcCellRow, srcCellCol);
				global::NPOI.SS.Formula.Eval.AreaEval ae = global::NPOI.SS.Formula.Functions.LookupUtils.ResolveTableArrayArg(args[1]);
				global::NPOI.SS.Formula.Eval.AreaEval ae2 = global::NPOI.SS.Formula.Functions.LookupUtils.ResolveTableArrayArg(args[2]);
				global::NPOI.SS.Formula.Functions.ValueVector valueVector = global::NPOI.SS.Formula.Functions.Lookup.CreateVector(ae);
				global::NPOI.SS.Formula.Functions.ValueVector valueVector2 = global::NPOI.SS.Formula.Functions.Lookup.CreateVector(ae2);
				if (valueVector.Size > valueVector2.Size)
				{
					throw new global::System.Exception("Lookup vector and result vector of differing sizes not supported yet");
				}
				int index = global::NPOI.SS.Formula.Functions.LookupUtils.LookupIndexOfValue(singleValue, valueVector, true);
				result = valueVector2.GetItem(index);
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
			{
				result = ex.GetErrorEval();
			}
			return result;
		}

		// Token: 0x06000B84 RID: 2948 RVA: 0x0001F318 File Offset: 0x0001D518
		private static global::NPOI.SS.Formula.Functions.ValueVector CreateVector(global::NPOI.SS.Formula.Eval.AreaEval ae)
		{
			global::NPOI.SS.Formula.Functions.ValueVector valueVector = global::NPOI.SS.Formula.Functions.LookupUtils.CreateVector(ae);
			if (valueVector != null)
			{
				return valueVector;
			}
			throw new global::System.InvalidOperationException("non-vector lookup or result areas not supported yet");
		}
	}
}
