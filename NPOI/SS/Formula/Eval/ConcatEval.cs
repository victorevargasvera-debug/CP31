using System;
using System.Text;
using NPOI.SS.Formula.Functions;

namespace NPOI.SS.Formula.Eval
{
	// Token: 0x02000207 RID: 519
	public class ConcatEval : global::NPOI.SS.Formula.Functions.Fixed2ArgFunction
	{
		// Token: 0x06000D05 RID: 3333 RVA: 0x0001A752 File Offset: 0x00018952
		private ConcatEval()
		{
		}

		// Token: 0x06000D06 RID: 3334 RVA: 0x000235DC File Offset: 0x000217DC
		public override global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval arg0, global::NPOI.SS.Formula.Eval.ValueEval arg1)
		{
			global::NPOI.SS.Formula.Eval.ValueEval singleValue;
			global::NPOI.SS.Formula.Eval.ValueEval singleValue2;
			try
			{
				singleValue = global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(arg0, srcRowIndex, srcColumnIndex);
				singleValue2 = global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(arg1, srcRowIndex, srcColumnIndex);
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
			{
				return ex.GetErrorEval();
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(this.GetText(singleValue));
			stringBuilder.Append(this.GetText(singleValue2));
			return new global::NPOI.SS.Formula.Eval.StringEval(stringBuilder.ToString());
		}

		// Token: 0x06000D07 RID: 3335 RVA: 0x00023644 File Offset: 0x00021844
		private object GetText(global::NPOI.SS.Formula.Eval.ValueEval ve)
		{
			if (ve is global::NPOI.SS.Formula.Eval.StringValueEval)
			{
				return ((global::NPOI.SS.Formula.Eval.StringValueEval)ve).StringValue;
			}
			if (ve == global::NPOI.SS.Formula.Eval.BlankEval.instance)
			{
				return "";
			}
			throw new global::System.InvalidOperationException("Unexpected value type (" + ve.GetType().Name + ")");
		}

		// Token: 0x040005E3 RID: 1507
		public static global::NPOI.SS.Formula.Functions.Function instance = new global::NPOI.SS.Formula.Eval.ConcatEval();
	}
}
