using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001BB RID: 443
	public class Npv : global::NPOI.SS.Formula.Functions.Function
	{
		// Token: 0x06000BF2 RID: 3058 RVA: 0x00020C38 File Offset: 0x0001EE38
		[global::System.Obsolete]
		public global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval arg0, global::NPOI.SS.Formula.Eval.ValueEval arg1)
		{
			double num2;
			try
			{
				double rate = global::NPOI.SS.Formula.Functions.NumericFunction.SingleOperandEvaluate(arg0, srcRowIndex, srcColumnIndex);
				double num = global::NPOI.SS.Formula.Functions.NumericFunction.SingleOperandEvaluate(arg1, srcRowIndex, srcColumnIndex);
				num2 = global::NPOI.SS.Formula.Functions.Npv.Evaluate(rate, new double[]
				{
					num
				});
				global::NPOI.SS.Formula.Functions.NumericFunction.CheckValue(num2);
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
			{
				return ex.GetErrorEval();
			}
			return new global::NPOI.SS.Formula.Eval.NumberEval(num2);
		}

		// Token: 0x06000BF3 RID: 3059 RVA: 0x00020C90 File Offset: 0x0001EE90
		[global::System.Obsolete]
		public global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval arg0, global::NPOI.SS.Formula.Eval.ValueEval arg1, global::NPOI.SS.Formula.Eval.ValueEval arg2)
		{
			double num3;
			try
			{
				double rate = global::NPOI.SS.Formula.Functions.NumericFunction.SingleOperandEvaluate(arg0, srcRowIndex, srcColumnIndex);
				double num = global::NPOI.SS.Formula.Functions.NumericFunction.SingleOperandEvaluate(arg1, srcRowIndex, srcColumnIndex);
				double num2 = global::NPOI.SS.Formula.Functions.NumericFunction.SingleOperandEvaluate(arg2, srcRowIndex, srcColumnIndex);
				num3 = global::NPOI.SS.Formula.Functions.Npv.Evaluate(rate, new double[]
				{
					num,
					num2
				});
				global::NPOI.SS.Formula.Functions.NumericFunction.CheckValue(num3);
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
			{
				return ex.GetErrorEval();
			}
			return new global::NPOI.SS.Formula.Eval.NumberEval(num3);
		}

		// Token: 0x06000BF4 RID: 3060 RVA: 0x00020CF8 File Offset: 0x0001EEF8
		[global::System.Obsolete]
		public global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval arg0, global::NPOI.SS.Formula.Eval.ValueEval arg1, global::NPOI.SS.Formula.Eval.ValueEval arg2, global::NPOI.SS.Formula.Eval.ValueEval arg3)
		{
			double num4;
			try
			{
				double rate = global::NPOI.SS.Formula.Functions.NumericFunction.SingleOperandEvaluate(arg0, srcRowIndex, srcColumnIndex);
				double num = global::NPOI.SS.Formula.Functions.NumericFunction.SingleOperandEvaluate(arg1, srcRowIndex, srcColumnIndex);
				double num2 = global::NPOI.SS.Formula.Functions.NumericFunction.SingleOperandEvaluate(arg2, srcRowIndex, srcColumnIndex);
				double num3 = global::NPOI.SS.Formula.Functions.NumericFunction.SingleOperandEvaluate(arg3, srcRowIndex, srcColumnIndex);
				num4 = global::NPOI.SS.Formula.Functions.Npv.Evaluate(rate, new double[]
				{
					num,
					num2,
					num3
				});
				global::NPOI.SS.Formula.Functions.NumericFunction.CheckValue(num4);
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
			{
				return ex.GetErrorEval();
			}
			return new global::NPOI.SS.Formula.Eval.NumberEval(num4);
		}

		// Token: 0x06000BF5 RID: 3061 RVA: 0x00020D70 File Offset: 0x0001EF70
		public global::NPOI.SS.Formula.Eval.ValueEval Evaluate(global::NPOI.SS.Formula.Eval.ValueEval[] args, int srcRowIndex, int srcColumnIndex)
		{
			if (args.Length < 2)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
			global::NPOI.SS.Formula.Eval.ValueEval result;
			try
			{
				double r = global::NPOI.SS.Formula.Functions.NumericFunction.SingleOperandEvaluate(args[0], srcRowIndex, srcColumnIndex);
				global::NPOI.SS.Formula.Eval.ValueEval[] array = new global::NPOI.SS.Formula.Eval.ValueEval[args.Length - 1];
				global::System.Array.Copy(args, 1, array, 0, array.Length);
				double[] cfs = global::NPOI.SS.Formula.Functions.AggregateFunction.ValueCollector.CollectValues(array);
				double num = global::NPOI.SS.Formula.Functions.FinanceLib.npv(r, cfs);
				global::NPOI.SS.Formula.Functions.NumericFunction.CheckValue(num);
				result = new global::NPOI.SS.Formula.Eval.NumberEval(num);
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
			{
				result = ex.GetErrorEval();
			}
			return result;
		}

		// Token: 0x06000BF6 RID: 3062 RVA: 0x00020DE0 File Offset: 0x0001EFE0
		private static double Evaluate(double rate, params double[] ds)
		{
			double num = 0.0;
			for (int i = 0; i < ds.Length; i++)
			{
				num += ds[i] / global::System.Math.Pow(rate + 1.0, (double)i);
			}
			return num;
		}
	}
}
