using System;
using System.Collections.Generic;
using System.Linq;
using NPOI.SS.Formula.Eval;
using NPOI.Util;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001E2 RID: 482
	public class Subtotal : global::NPOI.SS.Formula.Functions.Function
	{
		// Token: 0x06000C64 RID: 3172 RVA: 0x00021BB4 File Offset: 0x0001FDB4
		private static global::NPOI.SS.Formula.Functions.Function FindFunction(int functionCode)
		{
			switch (functionCode)
			{
			case 1:
				return global::NPOI.SS.Formula.Functions.AggregateFunction.SubtotalInstance(global::NPOI.SS.Formula.Functions.AggregateFunction.AVERAGE);
			case 2:
				return global::NPOI.SS.Formula.Functions.Count.SubtotalInstance();
			case 3:
				return global::NPOI.SS.Formula.Functions.Counta.SubtotalInstance();
			case 4:
				return global::NPOI.SS.Formula.Functions.AggregateFunction.SubtotalInstance(global::NPOI.SS.Formula.Functions.AggregateFunction.MAX);
			case 5:
				return global::NPOI.SS.Formula.Functions.AggregateFunction.SubtotalInstance(global::NPOI.SS.Formula.Functions.AggregateFunction.MIN);
			case 6:
				return global::NPOI.SS.Formula.Functions.AggregateFunction.SubtotalInstance(global::NPOI.SS.Formula.Functions.AggregateFunction.PRODUCT);
			case 7:
				return global::NPOI.SS.Formula.Functions.AggregateFunction.SubtotalInstance(global::NPOI.SS.Formula.Functions.AggregateFunction.STDEV);
			case 8:
				throw new global::NPOI.SS.Formula.Eval.NotImplementedFunctionException("STDEVP");
			case 9:
				return global::NPOI.SS.Formula.Functions.AggregateFunction.SubtotalInstance(global::NPOI.SS.Formula.Functions.AggregateFunction.SUM);
			case 10:
				throw new global::NPOI.SS.Formula.Eval.NotImplementedFunctionException("VAR");
			case 11:
				throw new global::NPOI.SS.Formula.Eval.NotImplementedFunctionException("VARP");
			default:
				if (functionCode > 100 && functionCode < 112)
				{
					throw new global::System.NotImplementedException("SUBTOTAL - with 'exclude hidden values' option");
				}
				throw global::NPOI.SS.Formula.Eval.EvaluationException.InvalidValue();
			}
		}

		// Token: 0x06000C65 RID: 3173 RVA: 0x00021C80 File Offset: 0x0001FE80
		public global::NPOI.SS.Formula.Eval.ValueEval Evaluate(global::NPOI.SS.Formula.Eval.ValueEval[] args, int srcRowIndex, int srcColumnIndex)
		{
			if (args.Length - 1 < 1)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
			global::NPOI.SS.Formula.Functions.Function function;
			try
			{
				function = global::NPOI.SS.Formula.Functions.Subtotal.FindFunction(global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToInt(global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(args[0], srcRowIndex, srcColumnIndex)));
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
			{
				return ex.GetErrorEval();
			}
			global::System.Collections.Generic.IList<global::NPOI.SS.Formula.Eval.ValueEval> list = new global::System.Collections.Generic.List<global::NPOI.SS.Formula.Eval.ValueEval>(global::NPOI.Util.Arrays.AsList<global::NPOI.SS.Formula.Eval.ValueEval>(args).GetRange(1, args.Length - 1));
			global::System.Collections.Generic.IEnumerator<global::NPOI.SS.Formula.Eval.ValueEval> enumerator = list.GetEnumerator();
			global::System.Collections.Generic.IList<global::NPOI.SS.Formula.Eval.ValueEval> list2 = new global::System.Collections.Generic.List<global::NPOI.SS.Formula.Eval.ValueEval>();
			while (enumerator.MoveNext())
			{
				global::NPOI.SS.Formula.Eval.ValueEval valueEval = enumerator.Current;
				if (valueEval is global::NPOI.SS.Formula.LazyRefEval && ((global::NPOI.SS.Formula.LazyRefEval)valueEval).IsSubTotal)
				{
					list2.Add(valueEval);
				}
			}
			foreach (global::NPOI.SS.Formula.Eval.ValueEval item in list2)
			{
				list.Remove(item);
			}
			return function.Evaluate(list.ToArray<global::NPOI.SS.Formula.Eval.ValueEval>(), srcRowIndex, srcColumnIndex);
		}
	}
}
