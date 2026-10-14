using System;
using NPOI.SS.Formula.Eval;
using NPOI.Util;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001E4 RID: 484
	public class Sumproduct : global::NPOI.SS.Formula.Functions.Function
	{
		// Token: 0x06000C6F RID: 3183 RVA: 0x00021F58 File Offset: 0x00020158
		public global::NPOI.SS.Formula.Eval.ValueEval Evaluate(global::NPOI.SS.Formula.Eval.ValueEval[] args, int srcCellRow, int srcCellCol)
		{
			if (args.Length < 1)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
			global::NPOI.SS.Formula.Eval.ValueEval valueEval = args[0];
			try
			{
				if (valueEval is global::NPOI.SS.Formula.Eval.NumericValueEval)
				{
					return this.EvaluateSingleProduct(args);
				}
				if (valueEval is global::NPOI.SS.Formula.Eval.RefEval)
				{
					return this.EvaluateSingleProduct(args);
				}
				if (valueEval is global::NPOI.SS.Formula.TwoDEval)
				{
					global::NPOI.SS.Formula.TwoDEval twoDEval = (global::NPOI.SS.Formula.TwoDEval)valueEval;
					if (twoDEval.IsRow && twoDEval.IsColumn)
					{
						return this.EvaluateSingleProduct(args);
					}
					return this.EvaluateAreaSumProduct(args);
				}
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
			{
				return ex.GetErrorEval();
			}
			throw new global::NPOI.Util.RuntimeException("Invalid arg type for SUMPRODUCT: (" + valueEval.GetType().Name + ")");
		}

		// Token: 0x06000C70 RID: 3184 RVA: 0x00022008 File Offset: 0x00020208
		private global::NPOI.SS.Formula.Eval.ValueEval EvaluateSingleProduct(global::NPOI.SS.Formula.Eval.ValueEval[] evalArgs)
		{
			int num = evalArgs.Length;
			double num2 = 1.0;
			for (int i = 0; i < num; i++)
			{
				double scalarValue = global::NPOI.SS.Formula.Functions.Sumproduct.GetScalarValue(evalArgs[i]);
				num2 *= scalarValue;
			}
			return new global::NPOI.SS.Formula.Eval.NumberEval(num2);
		}

		// Token: 0x06000C71 RID: 3185 RVA: 0x00022044 File Offset: 0x00020244
		private static double GetScalarValue(global::NPOI.SS.Formula.Eval.ValueEval arg)
		{
			global::NPOI.SS.Formula.Eval.ValueEval valueEval;
			if (arg is global::NPOI.SS.Formula.Eval.RefEval)
			{
				global::NPOI.SS.Formula.Eval.RefEval refEval = (global::NPOI.SS.Formula.Eval.RefEval)arg;
				if (refEval.NumberOfSheets > 1)
				{
					throw new global::NPOI.SS.Formula.Eval.EvaluationException(global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID);
				}
				valueEval = refEval.GetInnerValueEval(refEval.FirstSheetIndex);
			}
			else
			{
				valueEval = arg;
			}
			if (valueEval == null)
			{
				throw new global::System.ArgumentException("parameter may not be null");
			}
			if (valueEval is global::NPOI.SS.Formula.Eval.AreaEval)
			{
				global::NPOI.SS.Formula.Eval.AreaEval areaEval = (global::NPOI.SS.Formula.Eval.AreaEval)valueEval;
				if (!areaEval.IsColumn || !areaEval.IsRow)
				{
					throw new global::NPOI.SS.Formula.Eval.EvaluationException(global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID);
				}
				valueEval = areaEval.GetRelativeValue(0, 0);
			}
			if (valueEval == null)
			{
				throw new global::System.ArgumentException("Unexpected value eval class (" + valueEval.GetType().Name + ")");
			}
			return global::NPOI.SS.Formula.Functions.Sumproduct.GetProductTerm(valueEval, true);
		}

		// Token: 0x06000C72 RID: 3186 RVA: 0x000220F0 File Offset: 0x000202F0
		private global::NPOI.SS.Formula.Eval.ValueEval EvaluateAreaSumProduct(global::NPOI.SS.Formula.Eval.ValueEval[] evalArgs)
		{
			int num = evalArgs.Length;
			global::NPOI.SS.Formula.Eval.AreaEval[] array = new global::NPOI.SS.Formula.Eval.AreaEval[num];
			try
			{
				global::System.Array.Copy(evalArgs, 0, array, 0, num);
			}
			catch (global::System.Exception)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
			global::NPOI.SS.Formula.Eval.AreaEval areaEval = array[0];
			int num2 = areaEval.LastRow - areaEval.FirstRow + 1;
			int num3 = areaEval.LastColumn - areaEval.FirstColumn + 1;
			global::NPOI.SS.Formula.TwoDEval[] args = array;
			if (!global::NPOI.SS.Formula.Functions.Sumproduct.AreasAllSameSize(args, num2, num3))
			{
				for (int i = 1; i < array.Length; i++)
				{
					global::NPOI.SS.Formula.Functions.Sumproduct.ThrowFirstError(array[i]);
				}
				return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
			double num4 = 0.0;
			for (int j = 0; j < num2; j++)
			{
				for (int k = 0; k < num3; k++)
				{
					double num5 = 1.0;
					for (int l = 0; l < num; l++)
					{
						double productTerm = global::NPOI.SS.Formula.Functions.Sumproduct.GetProductTerm(array[l].GetRelativeValue(j, k), false);
						num5 *= productTerm;
					}
					num4 += num5;
				}
			}
			return new global::NPOI.SS.Formula.Eval.NumberEval(num4);
		}

		// Token: 0x06000C73 RID: 3187 RVA: 0x000221FC File Offset: 0x000203FC
		private static void ThrowFirstError(global::NPOI.SS.Formula.TwoDEval areaEval)
		{
			int height = areaEval.Height;
			int width = areaEval.Width;
			for (int i = 0; i < height; i++)
			{
				for (int j = 0; j < width; j++)
				{
					global::NPOI.SS.Formula.Eval.ValueEval value = areaEval.GetValue(i, j);
					if (value is global::NPOI.SS.Formula.Eval.ErrorEval)
					{
						throw new global::NPOI.SS.Formula.Eval.EvaluationException((global::NPOI.SS.Formula.Eval.ErrorEval)value);
					}
				}
			}
		}

		// Token: 0x06000C74 RID: 3188 RVA: 0x00022250 File Offset: 0x00020450
		private static bool AreasAllSameSize(global::NPOI.SS.Formula.TwoDEval[] args, int height, int width)
		{
			foreach (global::NPOI.SS.Formula.TwoDEval twoDEval in args)
			{
				if (twoDEval.Height != height)
				{
					return false;
				}
				if (twoDEval.Width != width)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000C75 RID: 3189 RVA: 0x00022288 File Offset: 0x00020488
		private static double GetProductTerm(global::NPOI.SS.Formula.Eval.ValueEval ve, bool IsScalarProduct)
		{
			if (ve is global::NPOI.SS.Formula.Eval.BlankEval || ve == null)
			{
				if (IsScalarProduct)
				{
					throw new global::NPOI.SS.Formula.Eval.EvaluationException(global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID);
				}
				return 0.0;
			}
			else
			{
				if (ve is global::NPOI.SS.Formula.Eval.ErrorEval)
				{
					throw new global::NPOI.SS.Formula.Eval.EvaluationException((global::NPOI.SS.Formula.Eval.ErrorEval)ve);
				}
				if (ve is global::NPOI.SS.Formula.Eval.StringEval)
				{
					if (IsScalarProduct)
					{
						throw new global::NPOI.SS.Formula.Eval.EvaluationException(global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID);
					}
					return 0.0;
				}
				else
				{
					if (ve is global::NPOI.SS.Formula.Eval.NumericValueEval)
					{
						return ((global::NPOI.SS.Formula.Eval.NumericValueEval)ve).NumberValue;
					}
					throw new global::NPOI.Util.RuntimeException("Unexpected value eval class (" + ve.GetType().Name + ")");
				}
			}
		}
	}
}
