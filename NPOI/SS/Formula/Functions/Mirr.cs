using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x02000149 RID: 329
	public class Mirr : global::NPOI.SS.Formula.Functions.MultiOperandNumericFunction
	{
		// Token: 0x06000A6A RID: 2666 RVA: 0x0001BB03 File Offset: 0x00019D03
		public Mirr() : base(false, false)
		{
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x06000A6B RID: 2667 RVA: 0x000169FF File Offset: 0x00014BFF
		protected override int MaxNumOperands
		{
			get
			{
				return 3;
			}
		}

		// Token: 0x06000A6C RID: 2668 RVA: 0x0001BB10 File Offset: 0x00019D10
		protected internal override double Evaluate(double[] values)
		{
			double financeRate = values[values.Length - 1];
			double reinvestRate = values[values.Length - 2];
			double[] array = new double[values.Length - 2];
			global::System.Array.Copy(values, 0, array, 0, array.Length);
			bool flag = true;
			foreach (double num in array)
			{
				flag &= (num < 0.0);
			}
			if (flag)
			{
				return -1.0;
			}
			bool flag2 = true;
			foreach (double num2 in array)
			{
				flag2 &= (num2 > 0.0);
			}
			if (flag2)
			{
				throw new global::NPOI.SS.Formula.Eval.EvaluationException(global::NPOI.SS.Formula.Eval.ErrorEval.DIV_ZERO);
			}
			return global::NPOI.SS.Formula.Functions.Mirr.mirr(array, financeRate, reinvestRate);
		}

		// Token: 0x06000A6D RID: 2669 RVA: 0x0001BBCC File Offset: 0x00019DCC
		private static double mirr(double[] in1, double financeRate, double reinvestRate)
		{
			double result = 0.0;
			int num = in1.Length - 1;
			double num2 = 0.0;
			double num3 = 0.0;
			int num4 = 0;
			foreach (double num5 in in1)
			{
				if (num5 < 0.0)
				{
					num2 += num5 / global::System.Math.Pow(1.0 + financeRate + reinvestRate, (double)num4++);
				}
			}
			foreach (double num6 in in1)
			{
				if (num6 > 0.0)
				{
					num3 += num6 * global::System.Math.Pow(1.0 + financeRate, (double)(num - num4++));
				}
			}
			if (num3 != 0.0 && num2 != 0.0)
			{
				result = global::System.Math.Pow(-num3 / num2, 1.0 / (double)num) - 1.0;
			}
			return result;
		}
	}
}
