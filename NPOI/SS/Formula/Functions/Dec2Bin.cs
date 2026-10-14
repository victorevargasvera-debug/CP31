using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x02000136 RID: 310
	public class Dec2Bin : global::NPOI.SS.Formula.Functions.Var1or2ArgFunction, global::NPOI.SS.Formula.Functions.FreeRefFunction
	{
		// Token: 0x06000A16 RID: 2582 RVA: 0x0001A32C File Offset: 0x0001852C
		public override global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval numberVE, global::NPOI.SS.Formula.Eval.ValueEval placesVE)
		{
			global::NPOI.SS.Formula.Eval.ValueEval singleValue;
			try
			{
				singleValue = global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(numberVE, srcRowIndex, srcColumnIndex);
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
			if (num < (double)global::NPOI.SS.Formula.Functions.Dec2Bin.MinValue || num > (double)global::NPOI.SS.Formula.Functions.Dec2Bin.MaxValue)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.NUM_ERROR;
			}
			int num2;
			if (num < 0.0 || placesVE == null)
			{
				num2 = global::NPOI.SS.Formula.Functions.Dec2Bin.DEFAULT_PLACES_VALUE;
			}
			else
			{
				global::NPOI.SS.Formula.Eval.ValueEval singleValue2;
				try
				{
					singleValue2 = global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(placesVE, srcRowIndex, srcColumnIndex);
				}
				catch (global::NPOI.SS.Formula.Eval.EvaluationException ex2)
				{
					return ex2.GetErrorEval();
				}
				double d = global::NPOI.SS.Formula.Eval.OperandResolver.ParseDouble(global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToString(singleValue2));
				if (double.IsNaN(d))
				{
					return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
				}
				num2 = (int)global::System.Math.Floor(d);
				if (num2 < 0 || num2 == 0)
				{
					return global::NPOI.SS.Formula.Eval.ErrorEval.NUM_ERROR;
				}
			}
			string text = global::System.Convert.ToString((int)global::System.Math.Floor(num), 2);
			if (text.Length > global::NPOI.SS.Formula.Functions.Dec2Bin.DEFAULT_PLACES_VALUE)
			{
				text = text.Substring(text.Length - global::NPOI.SS.Formula.Functions.Dec2Bin.DEFAULT_PLACES_VALUE);
			}
			if (text.Length > num2)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.NUM_ERROR;
			}
			return new global::NPOI.SS.Formula.Eval.StringEval(text);
		}

		// Token: 0x06000A17 RID: 2583 RVA: 0x0001A448 File Offset: 0x00018648
		public override global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval numberVE)
		{
			return this.Evaluate(srcRowIndex, srcColumnIndex, numberVE, null);
		}

		// Token: 0x06000A18 RID: 2584 RVA: 0x0001A454 File Offset: 0x00018654
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

		// Token: 0x04000508 RID: 1288
		public static global::NPOI.SS.Formula.Functions.FreeRefFunction instance = new global::NPOI.SS.Formula.Functions.Dec2Bin();

		// Token: 0x04000509 RID: 1289
		private static long MinValue = -512L;

		// Token: 0x0400050A RID: 1290
		private static long MaxValue = 511L;

		// Token: 0x0400050B RID: 1291
		private static int DEFAULT_PLACES_VALUE = 10;
	}
}
