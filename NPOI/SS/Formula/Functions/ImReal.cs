using System;
using System.Text.RegularExpressions;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x02000145 RID: 325
	public class ImReal : global::NPOI.SS.Formula.Functions.Fixed1ArgFunction, global::NPOI.SS.Formula.Functions.FreeRefFunction
	{
		// Token: 0x06000A5E RID: 2654 RVA: 0x0001B678 File Offset: 0x00019878
		public override global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval inumberVE)
		{
			global::NPOI.SS.Formula.Eval.ValueEval singleValue;
			try
			{
				singleValue = global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(inumberVE, srcRowIndex, srcColumnIndex);
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
			{
				return ex.GetErrorEval();
			}
			string input = global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToString(singleValue);
			global::System.Text.RegularExpressions.Match match = global::NPOI.SS.Formula.Functions.Imaginary.COMPLEX_NUMBER_PATTERN.Match(input);
			bool flag = match.Success && !string.IsNullOrEmpty(match.Groups[0].Value);
			string value = "";
			if (!flag)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.NUM_ERROR;
			}
			string value2 = match.Groups[2].Value;
			bool flag2 = value2.Length != 0;
			if (value2.Length == 0)
			{
				return new global::NPOI.SS.Formula.Eval.StringEval(global::System.Convert.ToString(0));
			}
			if (flag2)
			{
				string str = "";
				string value3 = match.Groups[global::NPOI.SS.Formula.Functions.Imaginary.GROUP1_REAL_SIGN].Value;
				if (value3.Length != 0 && !value3.Equals("+"))
				{
					str = value3;
				}
				string value4 = match.Groups[global::NPOI.SS.Formula.Functions.Imaginary.GROUP2_IMAGINARY_INTEGER_OR_DOUBLE].Value;
				if (value4.Length != 0)
				{
					value = str + value4;
				}
				else
				{
					value = str + "1";
				}
			}
			return new global::NPOI.SS.Formula.Eval.StringEval(value);
		}

		// Token: 0x06000A5F RID: 2655 RVA: 0x00019F68 File Offset: 0x00018168
		public global::NPOI.SS.Formula.Eval.ValueEval Evaluate(global::NPOI.SS.Formula.Eval.ValueEval[] args, global::NPOI.SS.Formula.OperationEvaluationContext ec)
		{
			if (args.Length != 1)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
			return this.Evaluate(ec.RowIndex, ec.ColumnIndex, args[0]);
		}

		// Token: 0x04000527 RID: 1319
		public static global::NPOI.SS.Formula.Functions.FreeRefFunction instance = new global::NPOI.SS.Formula.Functions.ImReal();
	}
}
