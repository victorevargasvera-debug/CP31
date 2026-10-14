using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001CD RID: 461
	public class Poisson : global::NPOI.SS.Formula.Functions.Fixed3ArgFunction
	{
		// Token: 0x06000C23 RID: 3107 RVA: 0x00021222 File Offset: 0x0001F422
		private bool IsDefaultResult(double x, double mean)
		{
			return x == 0.0 && mean == 0.0;
		}

		// Token: 0x06000C24 RID: 3108 RVA: 0x0002123F File Offset: 0x0001F43F
		private bool CheckArgument(double aDouble)
		{
			global::NPOI.SS.Formula.Functions.NumericFunction.CheckValue(aDouble);
			if (aDouble < 0.0)
			{
				throw new global::NPOI.SS.Formula.Eval.EvaluationException(global::NPOI.SS.Formula.Eval.ErrorEval.NUM_ERROR);
			}
			return true;
		}

		// Token: 0x06000C25 RID: 3109 RVA: 0x0002125F File Offset: 0x0001F45F
		private double probability(int k, double lambda)
		{
			return global::System.Math.Pow(lambda, (double)k) * global::System.Math.Exp(-lambda) / (double)this.Factorial(k);
		}

		// Token: 0x06000C26 RID: 3110 RVA: 0x0002127C File Offset: 0x0001F47C
		private double cumulativeProbability(int x, double lambda)
		{
			double num = 0.0;
			for (int i = 0; i <= x; i++)
			{
				num += this.probability(i, lambda);
			}
			return num;
		}

		// Token: 0x06000C27 RID: 3111 RVA: 0x000212AB File Offset: 0x0001F4AB
		public long Factorial(int n)
		{
			if (n < 0 || n > 20)
			{
				throw new global::System.ArgumentException("Valid argument should be in the range [0..20]");
			}
			return this.FACTORIALS[n];
		}

		// Token: 0x06000C28 RID: 3112 RVA: 0x000212CC File Offset: 0x0001F4CC
		public override global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval arg0, global::NPOI.SS.Formula.Eval.ValueEval arg1, global::NPOI.SS.Formula.Eval.ValueEval arg2)
		{
			bool booleanValue = ((global::NPOI.SS.Formula.Eval.BoolEval)arg2).BooleanValue;
			double num = 0.0;
			try
			{
				double num2 = global::NPOI.SS.Formula.Functions.NumericFunction.SingleOperandEvaluate(arg0, srcRowIndex, srcColumnIndex);
				double num3 = global::NPOI.SS.Formula.Functions.NumericFunction.SingleOperandEvaluate(arg1, srcRowIndex, srcColumnIndex);
				if (this.IsDefaultResult(num2, num3))
				{
					return new global::NPOI.SS.Formula.Eval.NumberEval(1.0);
				}
				this.CheckArgument(num2);
				this.CheckArgument(num3);
				if (booleanValue)
				{
					num = this.cumulativeProbability((int)num2, num3);
				}
				else
				{
					num = this.probability((int)num2, num3);
				}
				global::NPOI.SS.Formula.Functions.NumericFunction.CheckValue(num);
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
			{
				return ex.GetErrorEval();
			}
			return new global::NPOI.SS.Formula.Eval.NumberEval(num);
		}

		// Token: 0x040005B0 RID: 1456
		private const double DEFAULT_RETURN_RESULT = 1.0;

		// Token: 0x040005B1 RID: 1457
		private long[] FACTORIALS = new long[]
		{
			1L,
			1L,
			2L,
			6L,
			24L,
			120L,
			720L,
			5040L,
			40320L,
			362880L,
			3628800L,
			39916800L,
			479001600L,
			6227020800L,
			87178291200L,
			1307674368000L,
			20922789888000L,
			355687428096000L,
			6402373705728000L,
			121645100408832000L,
			2432902008176640000L
		};
	}
}
