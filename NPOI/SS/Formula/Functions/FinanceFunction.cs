using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x02000186 RID: 390
	public abstract class FinanceFunction : global::NPOI.SS.Formula.Functions.Function3Arg, global::NPOI.SS.Formula.Functions.Function, global::NPOI.SS.Formula.Functions.Function4Arg
	{
		// Token: 0x06000B27 RID: 2855 RVA: 0x0001E25D File Offset: 0x0001C45D
		public global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval arg0, global::NPOI.SS.Formula.Eval.ValueEval arg1, global::NPOI.SS.Formula.Eval.ValueEval arg2)
		{
			return this.Evaluate(srcRowIndex, srcColumnIndex, arg0, arg1, arg2, global::NPOI.SS.Formula.Functions.FinanceFunction.DEFAULT_ARG3);
		}

		// Token: 0x06000B28 RID: 2856 RVA: 0x0001E271 File Offset: 0x0001C471
		public global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval arg0, global::NPOI.SS.Formula.Eval.ValueEval arg1, global::NPOI.SS.Formula.Eval.ValueEval arg2, global::NPOI.SS.Formula.Eval.ValueEval arg3)
		{
			return this.Evaluate(srcRowIndex, srcColumnIndex, arg0, arg1, arg2, arg3, global::NPOI.SS.Formula.Functions.FinanceFunction.DEFAULT_ARG4);
		}

		// Token: 0x06000B29 RID: 2857 RVA: 0x0001E288 File Offset: 0x0001C488
		public global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval arg0, global::NPOI.SS.Formula.Eval.ValueEval arg1, global::NPOI.SS.Formula.Eval.ValueEval arg2, global::NPOI.SS.Formula.Eval.ValueEval arg3, global::NPOI.SS.Formula.Eval.ValueEval arg4)
		{
			double num2;
			try
			{
				double rate = global::NPOI.SS.Formula.Functions.NumericFunction.SingleOperandEvaluate(arg0, srcRowIndex, srcColumnIndex);
				double arg5 = global::NPOI.SS.Formula.Functions.NumericFunction.SingleOperandEvaluate(arg1, srcRowIndex, srcColumnIndex);
				double arg6 = global::NPOI.SS.Formula.Functions.NumericFunction.SingleOperandEvaluate(arg2, srcRowIndex, srcColumnIndex);
				double arg7 = global::NPOI.SS.Formula.Functions.NumericFunction.SingleOperandEvaluate(arg3, srcRowIndex, srcColumnIndex);
				double num = global::NPOI.SS.Formula.Functions.NumericFunction.SingleOperandEvaluate(arg4, srcRowIndex, srcColumnIndex);
				num2 = this.Evaluate(rate, arg5, arg6, arg7, num != 0.0);
				global::NPOI.SS.Formula.Functions.NumericFunction.CheckValue(num2);
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
			{
				return ex.GetErrorEval();
			}
			return new global::NPOI.SS.Formula.Eval.NumberEval(num2);
		}

		// Token: 0x06000B2A RID: 2858 RVA: 0x0001E310 File Offset: 0x0001C510
		public global::NPOI.SS.Formula.Eval.ValueEval Evaluate(global::NPOI.SS.Formula.Eval.ValueEval[] args, int srcRowIndex, int srcColumnIndex)
		{
			switch (args.Length)
			{
			case 3:
				return this.Evaluate(srcRowIndex, srcColumnIndex, args[0], args[1], args[2], global::NPOI.SS.Formula.Functions.FinanceFunction.DEFAULT_ARG3, global::NPOI.SS.Formula.Functions.FinanceFunction.DEFAULT_ARG4);
			case 4:
			{
				global::NPOI.SS.Formula.Eval.ValueEval valueEval = args[3];
				if (valueEval == global::NPOI.SS.Formula.Eval.MissingArgEval.instance)
				{
					valueEval = global::NPOI.SS.Formula.Functions.FinanceFunction.DEFAULT_ARG3;
				}
				return this.Evaluate(srcRowIndex, srcColumnIndex, args[0], args[1], args[2], valueEval, global::NPOI.SS.Formula.Functions.FinanceFunction.DEFAULT_ARG4);
			}
			case 5:
			{
				global::NPOI.SS.Formula.Eval.ValueEval valueEval = args[3];
				if (valueEval == global::NPOI.SS.Formula.Eval.MissingArgEval.instance)
				{
					valueEval = global::NPOI.SS.Formula.Functions.FinanceFunction.DEFAULT_ARG3;
				}
				global::NPOI.SS.Formula.Eval.ValueEval valueEval2 = args[4];
				if (valueEval2 == global::NPOI.SS.Formula.Eval.MissingArgEval.instance)
				{
					valueEval2 = global::NPOI.SS.Formula.Functions.FinanceFunction.DEFAULT_ARG4;
				}
				return this.Evaluate(srcRowIndex, srcColumnIndex, args[0], args[1], args[2], valueEval, valueEval2);
			}
			default:
				return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
		}

		// Token: 0x06000B2B RID: 2859 RVA: 0x0001E3BC File Offset: 0x0001C5BC
		public double Evaluate(double[] ds)
		{
			double arg = 0.0;
			double num = 0.0;
			switch (ds.Length)
			{
			case 3:
				break;
			case 4:
				arg = ds[3];
				break;
			case 5:
				num = ds[4];
				break;
			default:
				throw new global::System.ArgumentException("Wrong number of arguments");
			}
			return this.Evaluate(ds[0], ds[1], ds[2], arg, num != 0.0);
		}

		// Token: 0x06000B2C RID: 2860
		public abstract double Evaluate(double rate, double arg1, double arg2, double arg3, bool type);

		// Token: 0x04000561 RID: 1377
		private static global::NPOI.SS.Formula.Eval.ValueEval DEFAULT_ARG3 = global::NPOI.SS.Formula.Eval.NumberEval.ZERO;

		// Token: 0x04000562 RID: 1378
		private static global::NPOI.SS.Formula.Eval.ValueEval DEFAULT_ARG4 = global::NPOI.SS.Formula.Eval.BoolEval.FALSE;

		// Token: 0x04000563 RID: 1379
		public static readonly global::NPOI.SS.Formula.Functions.Function FV = new global::NPOI.SS.Formula.Functions.Fv();

		// Token: 0x04000564 RID: 1380
		public static readonly global::NPOI.SS.Formula.Functions.Function NPER = new global::NPOI.SS.Formula.Functions.Nper();

		// Token: 0x04000565 RID: 1381
		public static readonly global::NPOI.SS.Formula.Functions.Function PMT = new global::NPOI.SS.Formula.Functions.Pmt();

		// Token: 0x04000566 RID: 1382
		public static readonly global::NPOI.SS.Formula.Functions.Function PV = new global::NPOI.SS.Formula.Functions.Pv();
	}
}
