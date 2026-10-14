using System;
using System.Text;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x02000134 RID: 308
	public class Complex : global::NPOI.SS.Formula.Functions.Var2or3ArgFunction, global::NPOI.SS.Formula.Functions.FreeRefFunction
	{
		// Token: 0x06000A0D RID: 2573 RVA: 0x00019FFC File Offset: 0x000181FC
		public override global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval real_num, global::NPOI.SS.Formula.Eval.ValueEval i_num)
		{
			return this.Evaluate(srcRowIndex, srcColumnIndex, real_num, i_num, new global::NPOI.SS.Formula.Eval.StringEval(global::NPOI.SS.Formula.Functions.Complex.DEFAULT_SUFFIX));
		}

		// Token: 0x06000A0E RID: 2574 RVA: 0x0001A014 File Offset: 0x00018214
		public override global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval real_num, global::NPOI.SS.Formula.Eval.ValueEval i_num, global::NPOI.SS.Formula.Eval.ValueEval suffix)
		{
			global::NPOI.SS.Formula.Eval.ValueEval singleValue;
			try
			{
				singleValue = global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(real_num, srcRowIndex, srcColumnIndex);
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
			{
				return ex.GetErrorEval();
			}
			double num = 0.0;
			try
			{
				num = global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToDouble(singleValue);
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
			global::NPOI.SS.Formula.Eval.ValueEval singleValue2;
			try
			{
				singleValue2 = global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(i_num, srcRowIndex, srcColumnIndex);
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex2)
			{
				return ex2.GetErrorEval();
			}
			double num2 = 0.0;
			try
			{
				num2 = global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToDouble(singleValue2);
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
			string text = global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToString(suffix);
			if (text.Length == 0)
			{
				text = global::NPOI.SS.Formula.Functions.Complex.DEFAULT_SUFFIX;
			}
			if (text.Equals(global::NPOI.SS.Formula.Functions.Complex.DEFAULT_SUFFIX.ToUpper()) || text.Equals(global::NPOI.SS.Formula.Functions.Complex.SUPPORTED_SUFFIX.ToUpper()))
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
			if (!text.Equals(global::NPOI.SS.Formula.Functions.Complex.DEFAULT_SUFFIX) && !text.Equals(global::NPOI.SS.Formula.Functions.Complex.SUPPORTED_SUFFIX))
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder("");
			if (num != 0.0)
			{
				if (this.isDoubleAnInt(num))
				{
					stringBuilder.Append((int)num);
				}
				else
				{
					stringBuilder.Append(num);
				}
			}
			if (num2 != 0.0)
			{
				if (stringBuilder.Length != 0 && num2 > 0.0)
				{
					stringBuilder.Append("+");
				}
				if (num2 != 1.0 && num2 != -1.0)
				{
					if (this.isDoubleAnInt(num2))
					{
						stringBuilder.Append((int)num2);
					}
					else
					{
						stringBuilder.Append(num2);
					}
				}
				stringBuilder.Append(text);
			}
			return new global::NPOI.SS.Formula.Eval.StringEval(stringBuilder.ToString());
		}

		// Token: 0x06000A0F RID: 2575 RVA: 0x0001A1E0 File Offset: 0x000183E0
		private bool isDoubleAnInt(double number)
		{
			return number == global::System.Math.Floor(number) && !double.IsInfinity(number);
		}

		// Token: 0x06000A10 RID: 2576 RVA: 0x0001A1F8 File Offset: 0x000183F8
		public global::NPOI.SS.Formula.Eval.ValueEval Evaluate(global::NPOI.SS.Formula.Eval.ValueEval[] args, global::NPOI.SS.Formula.OperationEvaluationContext ec)
		{
			if (args.Length == 2)
			{
				return this.Evaluate(ec.RowIndex, ec.ColumnIndex, args[0], args[1]);
			}
			if (args.Length == 3)
			{
				return this.Evaluate(ec.RowIndex, ec.ColumnIndex, args[0], args[1], args[2]);
			}
			return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
		}

		// Token: 0x04000504 RID: 1284
		public static global::NPOI.SS.Formula.Functions.FreeRefFunction Instance = new global::NPOI.SS.Formula.Functions.Complex();

		// Token: 0x04000505 RID: 1285
		public static string DEFAULT_SUFFIX = "i";

		// Token: 0x04000506 RID: 1286
		public static string SUPPORTED_SUFFIX = "j";
	}
}
