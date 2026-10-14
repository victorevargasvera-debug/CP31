using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001FF RID: 511
	public class Vlookup : global::NPOI.SS.Formula.Functions.Var3or4ArgFunction
	{
		// Token: 0x06000CC5 RID: 3269 RVA: 0x00022FAF File Offset: 0x000211AF
		public override global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval arg0, global::NPOI.SS.Formula.Eval.ValueEval arg1, global::NPOI.SS.Formula.Eval.ValueEval arg2)
		{
			return this.Evaluate(srcRowIndex, srcColumnIndex, arg0, arg1, arg2, global::NPOI.SS.Formula.Functions.Vlookup.DEFAULT_ARG3);
		}

		// Token: 0x06000CC6 RID: 3270 RVA: 0x00022FC4 File Offset: 0x000211C4
		public override global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval lookup_value, global::NPOI.SS.Formula.Eval.ValueEval table_array, global::NPOI.SS.Formula.Eval.ValueEval col_index, global::NPOI.SS.Formula.Eval.ValueEval range_lookup)
		{
			global::NPOI.SS.Formula.Eval.ValueEval result;
			try
			{
				global::NPOI.SS.Formula.Eval.ValueEval singleValue = global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(lookup_value, srcRowIndex, srcColumnIndex);
				global::NPOI.SS.Formula.TwoDEval tableArray = global::NPOI.SS.Formula.Functions.LookupUtils.ResolveTableArrayArg(table_array);
				bool isRangeLookup = global::NPOI.SS.Formula.Functions.LookupUtils.ResolveRangeLookupArg(range_lookup, srcRowIndex, srcColumnIndex);
				int index = global::NPOI.SS.Formula.Functions.LookupUtils.LookupIndexOfValue(singleValue, global::NPOI.SS.Formula.Functions.LookupUtils.CreateColumnVector(tableArray, 0), isRangeLookup);
				int colIndex = global::NPOI.SS.Formula.Functions.LookupUtils.ResolveRowOrColIndexArg(col_index, srcRowIndex, srcColumnIndex);
				result = this.CreateResultColumnVector(tableArray, colIndex).GetItem(index);
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
			{
				result = ex.GetErrorEval();
			}
			return result;
		}

		// Token: 0x06000CC7 RID: 3271 RVA: 0x00023030 File Offset: 0x00021230
		private global::NPOI.SS.Formula.Functions.ValueVector CreateResultColumnVector(global::NPOI.SS.Formula.TwoDEval tableArray, int colIndex)
		{
			if (colIndex >= tableArray.Width)
			{
				throw global::NPOI.SS.Formula.Eval.EvaluationException.InvalidRef();
			}
			return global::NPOI.SS.Formula.Functions.LookupUtils.CreateColumnVector(tableArray, colIndex);
		}

		// Token: 0x040005D3 RID: 1491
		private static global::NPOI.SS.Formula.Eval.ValueEval DEFAULT_ARG3 = global::NPOI.SS.Formula.Eval.BoolEval.TRUE;
	}
}
