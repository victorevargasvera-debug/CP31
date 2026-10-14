using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x02000141 RID: 321
	public class Hex2Dec : global::NPOI.SS.Formula.Functions.Fixed1ArgFunction, global::NPOI.SS.Formula.Functions.FreeRefFunction
	{
		// Token: 0x06000A51 RID: 2641 RVA: 0x0001B40C File Offset: 0x0001960C
		public override global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval numberVE)
		{
			string value;
			if (numberVE is global::NPOI.SS.Formula.Eval.RefEval)
			{
				global::NPOI.SS.Formula.Eval.RefEval refEval = (global::NPOI.SS.Formula.Eval.RefEval)numberVE;
				value = global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToString(refEval.GetInnerValueEval(refEval.FirstSheetIndex));
			}
			else
			{
				value = global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToString(numberVE);
			}
			global::NPOI.SS.Formula.Eval.ValueEval result;
			try
			{
				result = new global::NPOI.SS.Formula.Eval.NumberEval(global::NPOI.SS.Formula.Functions.BaseNumberUtils.ConvertToDecimal(value, global::NPOI.SS.Formula.Functions.Hex2Dec.HEXADECIMAL_BASE, global::NPOI.SS.Formula.Functions.Hex2Dec.MAX_NUMBER_OF_PLACES));
			}
			catch (global::System.ArgumentException)
			{
				result = global::NPOI.SS.Formula.Eval.ErrorEval.NUM_ERROR;
			}
			return result;
		}

		// Token: 0x06000A52 RID: 2642 RVA: 0x00019F68 File Offset: 0x00018168
		public global::NPOI.SS.Formula.Eval.ValueEval Evaluate(global::NPOI.SS.Formula.Eval.ValueEval[] args, global::NPOI.SS.Formula.OperationEvaluationContext ec)
		{
			if (args.Length != 1)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
			return this.Evaluate(ec.RowIndex, ec.ColumnIndex, args[0]);
		}

		// Token: 0x04000519 RID: 1305
		public static global::NPOI.SS.Formula.Functions.FreeRefFunction instance = new global::NPOI.SS.Formula.Functions.Hex2Dec();

		// Token: 0x0400051A RID: 1306
		private static int HEXADECIMAL_BASE = 16;

		// Token: 0x0400051B RID: 1307
		private static int MAX_NUMBER_OF_PLACES = 10;
	}
}
