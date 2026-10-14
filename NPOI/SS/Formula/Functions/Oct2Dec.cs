using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x0200014A RID: 330
	public class Oct2Dec : global::NPOI.SS.Formula.Functions.Fixed1ArgFunction, global::NPOI.SS.Formula.Functions.FreeRefFunction
	{
		// Token: 0x06000A6E RID: 2670 RVA: 0x0001BCD0 File Offset: 0x00019ED0
		public override global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval numberVE)
		{
			string value = global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToString(numberVE);
			global::NPOI.SS.Formula.Eval.ValueEval result;
			try
			{
				result = new global::NPOI.SS.Formula.Eval.NumberEval(global::NPOI.SS.Formula.Functions.BaseNumberUtils.ConvertToDecimal(value, global::NPOI.SS.Formula.Functions.Oct2Dec.OCTAL_BASE, global::NPOI.SS.Formula.Functions.Oct2Dec.MAX_NUMBER_OF_PLACES));
			}
			catch (global::System.ArgumentException)
			{
				result = global::NPOI.SS.Formula.Eval.ErrorEval.NUM_ERROR;
			}
			return result;
		}

		// Token: 0x06000A6F RID: 2671 RVA: 0x00019F68 File Offset: 0x00018168
		public global::NPOI.SS.Formula.Eval.ValueEval Evaluate(global::NPOI.SS.Formula.Eval.ValueEval[] args, global::NPOI.SS.Formula.OperationEvaluationContext ec)
		{
			if (args.Length != 1)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
			return this.Evaluate(ec.RowIndex, ec.ColumnIndex, args[0]);
		}

		// Token: 0x0400052A RID: 1322
		public static global::NPOI.SS.Formula.Functions.FreeRefFunction instance = new global::NPOI.SS.Formula.Functions.Oct2Dec();

		// Token: 0x0400052B RID: 1323
		private static int MAX_NUMBER_OF_PLACES = 10;

		// Token: 0x0400052C RID: 1324
		private static int OCTAL_BASE = 8;
	}
}
