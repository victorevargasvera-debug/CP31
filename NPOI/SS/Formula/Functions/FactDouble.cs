using System;
using System.Collections.Generic;
using NPOI.SS.Formula.Eval;
using NPOI.Util;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x0200013E RID: 318
	public class FactDouble : global::NPOI.SS.Formula.Functions.Fixed1ArgFunction, global::NPOI.SS.Formula.Functions.FreeRefFunction
	{
		// Token: 0x06000A3A RID: 2618 RVA: 0x0001B010 File Offset: 0x00019210
		public override global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval numberVE)
		{
			int num;
			try
			{
				num = global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToInt(numberVE);
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
			if (num < 0)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.NUM_ERROR;
			}
			return new global::NPOI.SS.Formula.Eval.NumberEval((double)global::NPOI.SS.Formula.Functions.FactDouble.factorial(num).LongValue());
		}

		// Token: 0x06000A3B RID: 2619 RVA: 0x0001B05C File Offset: 0x0001925C
		public static global::NPOI.Util.BigInteger factorial(int n)
		{
			if (n == 0 || n < 0)
			{
				return global::NPOI.Util.BigInteger.One;
			}
			if (global::NPOI.SS.Formula.Functions.FactDouble.cache.ContainsKey(n))
			{
				return global::NPOI.SS.Formula.Functions.FactDouble.cache[n];
			}
			global::NPOI.Util.BigInteger bigInteger = global::NPOI.Util.BigInteger.ValueOf((long)n).Multiply(global::NPOI.SS.Formula.Functions.FactDouble.factorial(n - 2));
			global::NPOI.SS.Formula.Functions.FactDouble.cache.Add(n, bigInteger);
			return bigInteger;
		}

		// Token: 0x06000A3C RID: 2620 RVA: 0x00019F68 File Offset: 0x00018168
		public global::NPOI.SS.Formula.Eval.ValueEval Evaluate(global::NPOI.SS.Formula.Eval.ValueEval[] args, global::NPOI.SS.Formula.OperationEvaluationContext ec)
		{
			if (args.Length != 1)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
			return this.Evaluate(ec.RowIndex, ec.ColumnIndex, args[0]);
		}

		// Token: 0x04000517 RID: 1303
		public static global::NPOI.SS.Formula.Functions.FreeRefFunction instance = new global::NPOI.SS.Formula.Functions.FactDouble();

		// Token: 0x04000518 RID: 1304
		private static global::System.Collections.Generic.Dictionary<int, global::NPOI.Util.BigInteger> cache = new global::System.Collections.Generic.Dictionary<int, global::NPOI.Util.BigInteger>();
	}
}
