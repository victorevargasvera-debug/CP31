using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x0200014E RID: 334
	public class Rate : global::NPOI.SS.Formula.Functions.Function
	{
		// Token: 0x06000A7E RID: 2686 RVA: 0x0001C00C File Offset: 0x0001A20C
		public global::NPOI.SS.Formula.Eval.ValueEval Evaluate(global::NPOI.SS.Formula.Eval.ValueEval[] args, int srcRowIndex, int srcColumnIndex)
		{
			if (args.Length < 3)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
			double fv = 0.0;
			double type = 0.0;
			double guess = 0.1;
			double num;
			try
			{
				global::NPOI.SS.Formula.Eval.ValueEval singleValue = global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(args[0], srcRowIndex, srcColumnIndex);
				global::NPOI.SS.Formula.Eval.ValueEval singleValue2 = global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(args[1], srcRowIndex, srcColumnIndex);
				global::NPOI.SS.Formula.Eval.ValueEval singleValue3 = global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(args[2], srcRowIndex, srcColumnIndex);
				global::NPOI.SS.Formula.Eval.ValueEval ev = null;
				if (args.Length >= 4)
				{
					ev = global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(args[3], srcRowIndex, srcColumnIndex);
				}
				global::NPOI.SS.Formula.Eval.ValueEval ev2 = null;
				if (args.Length >= 5)
				{
					ev2 = global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(args[4], srcRowIndex, srcColumnIndex);
				}
				global::NPOI.SS.Formula.Eval.ValueEval ev3 = null;
				if (args.Length >= 6)
				{
					ev3 = global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(args[5], srcRowIndex, srcColumnIndex);
				}
				double nper = global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToDouble(singleValue);
				double pmt = global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToDouble(singleValue2);
				double pv = global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToDouble(singleValue3);
				if (args.Length >= 4)
				{
					fv = global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToDouble(ev);
				}
				if (args.Length >= 5)
				{
					type = global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToDouble(ev2);
				}
				if (args.Length >= 6)
				{
					guess = global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToDouble(ev3);
				}
				num = this.CalculateRate(nper, pmt, pv, fv, type, guess);
				global::NPOI.SS.Formula.Functions.Rate.CheckValue(num);
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
			{
				return ex.GetErrorEval();
			}
			return new global::NPOI.SS.Formula.Eval.NumberEval(num);
		}

		// Token: 0x06000A7F RID: 2687 RVA: 0x0001C124 File Offset: 0x0001A324
		private double CalculateRate(double nper, double pmt, double pv, double fv, double type, double guess)
		{
			int num = 20;
			double num2 = 1E-07;
			double num3 = 0.0;
			double num4 = guess;
			if (global::System.Math.Abs(num4) < num2)
			{
				double num5 = pv * (1.0 + nper * num4) + pmt * (1.0 + num4 * type) * nper + fv;
			}
			else
			{
				num3 = global::System.Math.Exp(nper * global::System.Math.Log(1.0 + num4));
				double num5 = pv * num3 + pmt * (1.0 / num4 + type) * (num3 - 1.0) + fv;
			}
			double num6 = pv + pmt * nper + fv;
			double num7 = pv * num3 + pmt * (1.0 / num4 + type) * (num3 - 1.0) + fv;
			double num9;
			double num8 = num9 = 0.0;
			double num10 = num4;
			while (global::System.Math.Abs(num6 - num7) > num2 && num9 < (double)num)
			{
				num4 = (num7 * num8 - num6 * num10) / (num7 - num6);
				num8 = num10;
				num10 = num4;
				double num5;
				if (global::System.Math.Abs(num4) < num2)
				{
					num5 = pv * (1.0 + nper * num4) + pmt * (1.0 + num4 * type) * nper + fv;
				}
				else
				{
					num3 = global::System.Math.Exp(nper * global::System.Math.Log(1.0 + num4));
					num5 = pv * num3 + pmt * (1.0 / num4 + type) * (num3 - 1.0) + fv;
				}
				num6 = num7;
				num7 = num5;
				num9 += 1.0;
			}
			return num4;
		}

		// Token: 0x06000A80 RID: 2688 RVA: 0x0001C2D9 File Offset: 0x0001A4D9
		private static void CheckValue(double result)
		{
			if (double.IsNaN(result) || double.IsInfinity(result))
			{
				throw new global::NPOI.SS.Formula.Eval.EvaluationException(global::NPOI.SS.Formula.Eval.ErrorEval.NUM_ERROR);
			}
		}
	}
}
