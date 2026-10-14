using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x02000137 RID: 311
	public class Dec2Hex : global::NPOI.SS.Formula.Functions.Var1or2ArgFunction, global::NPOI.SS.Formula.Functions.FreeRefFunction
	{
		// Token: 0x06000A1B RID: 2587 RVA: 0x0001A4D4 File Offset: 0x000186D4
		public override global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval number, global::NPOI.SS.Formula.Eval.ValueEval places)
		{
			global::NPOI.SS.Formula.Eval.ValueEval singleValue;
			try
			{
				singleValue = global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(number, srcRowIndex, srcColumnIndex);
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
			{
				return ex.GetErrorEval();
			}
			double num = global::NPOI.SS.Formula.Eval.OperandResolver.ParseDouble(global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToString(singleValue));
			if (double.IsNaN(num))
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
			if (num < (double)global::NPOI.SS.Formula.Functions.Dec2Hex.MinValue || num > (double)global::NPOI.SS.Formula.Functions.Dec2Hex.MaxValue)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.NUM_ERROR;
			}
			int num2 = 0;
			if (num < 0.0)
			{
				num2 = global::NPOI.SS.Formula.Functions.Dec2Hex.DEFAULT_PLACES_VALUE;
			}
			else if (places != null)
			{
				global::NPOI.SS.Formula.Eval.ValueEval singleValue2;
				try
				{
					singleValue2 = global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(places, srcRowIndex, srcColumnIndex);
				}
				catch (global::NPOI.SS.Formula.Eval.EvaluationException ex2)
				{
					return ex2.GetErrorEval();
				}
				double num3 = global::NPOI.SS.Formula.Eval.OperandResolver.ParseDouble(global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToString(singleValue2));
				if (double.IsNaN(num3))
				{
					return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
				}
				num2 = (int)num3;
				if (num2 < 0)
				{
					return global::NPOI.SS.Formula.Eval.ErrorEval.NUM_ERROR;
				}
			}
			string text;
			if (num2 != 0)
			{
				text = string.Format("{0:X" + num2.ToString() + "}", (int)num);
			}
			else
			{
				text = string.Format("{0:X}", (long)num);
			}
			if (num < 0.0)
			{
				text = "FF" + text.Substring(2);
			}
			return new global::NPOI.SS.Formula.Eval.StringEval(text.ToUpper());
		}

		// Token: 0x06000A1C RID: 2588 RVA: 0x0001A448 File Offset: 0x00018648
		public override global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval arg0)
		{
			return this.Evaluate(srcRowIndex, srcColumnIndex, arg0, null);
		}

		// Token: 0x06000A1D RID: 2589 RVA: 0x0001A610 File Offset: 0x00018810
		public global::NPOI.SS.Formula.Eval.ValueEval Evaluate(global::NPOI.SS.Formula.Eval.ValueEval[] args, global::NPOI.SS.Formula.OperationEvaluationContext ec)
		{
			if (args.Length == 1)
			{
				return this.Evaluate(ec.RowIndex, ec.ColumnIndex, args[0]);
			}
			if (args.Length == 2)
			{
				return this.Evaluate(ec.RowIndex, ec.ColumnIndex, args[0], args[1]);
			}
			return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
		}

		// Token: 0x0400050C RID: 1292
		public static global::NPOI.SS.Formula.Functions.FreeRefFunction instance = new global::NPOI.SS.Formula.Functions.Dec2Hex();

		// Token: 0x0400050D RID: 1293
		private static long MinValue = -549755813888L;

		// Token: 0x0400050E RID: 1294
		private static long MaxValue = 549755813887L;

		// Token: 0x0400050F RID: 1295
		private static int DEFAULT_PLACES_VALUE = 10;
	}
}
