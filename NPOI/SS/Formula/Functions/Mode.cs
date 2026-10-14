using System;
using System.Collections;
using NPOI.SS.Formula.Eval;
using NPOI.Util;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001B5 RID: 437
	public class Mode : global::NPOI.SS.Formula.Functions.Function
	{
		// Token: 0x06000BD9 RID: 3033 RVA: 0x0002063C File Offset: 0x0001E83C
		public static double Evaluate(double[] v)
		{
			if (v.Length < 2)
			{
				throw new global::NPOI.SS.Formula.Eval.EvaluationException(global::NPOI.SS.Formula.Eval.ErrorEval.NA);
			}
			int[] array = new int[v.Length];
			global::NPOI.Util.Arrays.Fill<int>(array, 1);
			int i = 0;
			int num = v.Length;
			while (i < num)
			{
				int j = i + 1;
				int num2 = v.Length;
				while (j < num2)
				{
					if (v[i] == v[j])
					{
						array[i]++;
					}
					j++;
				}
				i++;
			}
			double result = 0.0;
			int num3 = 0;
			int k = 0;
			int num4 = array.Length;
			while (k < num4)
			{
				if (array[k] > num3)
				{
					result = v[k];
					num3 = array[k];
				}
				k++;
			}
			if (num3 > 1)
			{
				return result;
			}
			throw new global::NPOI.SS.Formula.Eval.EvaluationException(global::NPOI.SS.Formula.Eval.ErrorEval.NA);
		}

		// Token: 0x06000BDA RID: 3034 RVA: 0x000206EC File Offset: 0x0001E8EC
		public global::NPOI.SS.Formula.Eval.ValueEval Evaluate(global::NPOI.SS.Formula.Eval.ValueEval[] args, int srcCellRow, int srcCellCol)
		{
			double value;
			try
			{
				global::System.Collections.IList list = new global::System.Collections.ArrayList();
				for (int i = 0; i < args.Length; i++)
				{
					global::NPOI.SS.Formula.Functions.Mode.CollectValues(args[i], list);
				}
				double[] array = new double[list.Count];
				for (int j = 0; j < array.Length; j++)
				{
					array[j] = (double)list[j];
				}
				value = global::NPOI.SS.Formula.Functions.Mode.Evaluate(array);
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
			{
				return ex.GetErrorEval();
			}
			return new global::NPOI.SS.Formula.Eval.NumberEval(value);
		}

		// Token: 0x06000BDB RID: 3035 RVA: 0x00020770 File Offset: 0x0001E970
		private static void CollectValues(global::NPOI.SS.Formula.Eval.ValueEval arg, global::System.Collections.IList temp)
		{
			if (arg is global::NPOI.SS.Formula.TwoDEval)
			{
				global::NPOI.SS.Formula.TwoDEval twoDEval = (global::NPOI.SS.Formula.TwoDEval)arg;
				int width = twoDEval.Width;
				int height = twoDEval.Height;
				for (int i = 0; i < height; i++)
				{
					for (int j = 0; j < width; j++)
					{
						global::NPOI.SS.Formula.Functions.Mode.CollectValue(twoDEval.GetValue(i, j), temp, false);
					}
				}
				return;
			}
			if (arg is global::NPOI.SS.Formula.Eval.RefEval)
			{
				global::NPOI.SS.Formula.Eval.RefEval refEval = (global::NPOI.SS.Formula.Eval.RefEval)arg;
				int firstSheetIndex = refEval.FirstSheetIndex;
				int lastSheetIndex = refEval.LastSheetIndex;
				for (int k = firstSheetIndex; k <= lastSheetIndex; k++)
				{
					global::NPOI.SS.Formula.Functions.Mode.CollectValue(refEval.GetInnerValueEval(k), temp, true);
				}
				return;
			}
			global::NPOI.SS.Formula.Functions.Mode.CollectValue(arg, temp, true);
		}

		// Token: 0x06000BDC RID: 3036 RVA: 0x00020814 File Offset: 0x0001EA14
		private static void CollectValue(global::NPOI.SS.Formula.Eval.ValueEval arg, global::System.Collections.IList temp, bool mustBeNumber)
		{
			if (arg is global::NPOI.SS.Formula.Eval.ErrorEval)
			{
				throw new global::NPOI.SS.Formula.Eval.EvaluationException((global::NPOI.SS.Formula.Eval.ErrorEval)arg);
			}
			if (arg == global::NPOI.SS.Formula.Eval.BlankEval.instance || arg is global::NPOI.SS.Formula.Eval.BoolEval || arg is global::NPOI.SS.Formula.Eval.StringEval)
			{
				if (mustBeNumber)
				{
					throw global::NPOI.SS.Formula.Eval.EvaluationException.InvalidValue();
				}
				return;
			}
			else
			{
				if (arg is global::NPOI.SS.Formula.Eval.NumberEval)
				{
					temp.Add(((global::NPOI.SS.Formula.Eval.NumberEval)arg).NumberValue);
					return;
				}
				throw new global::System.InvalidOperationException("Unexpected value type (" + arg.GetType().Name + ")");
			}
		}
	}
}
