using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001ED RID: 493
	public class LeftRight : global::NPOI.SS.Formula.Functions.Var1or2ArgFunction
	{
		// Token: 0x06000C8A RID: 3210 RVA: 0x000224E1 File Offset: 0x000206E1
		public LeftRight(bool isLeft)
		{
			this._isLeft = isLeft;
		}

		// Token: 0x06000C8B RID: 3211 RVA: 0x000224F0 File Offset: 0x000206F0
		public override global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval arg0)
		{
			return this.Evaluate(srcRowIndex, srcColumnIndex, arg0, global::NPOI.SS.Formula.Functions.LeftRight.DEFAULT_ARG1);
		}

		// Token: 0x06000C8C RID: 3212 RVA: 0x00022500 File Offset: 0x00020700
		public override global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval arg0, global::NPOI.SS.Formula.Eval.ValueEval arg1)
		{
			string text;
			int num;
			try
			{
				text = global::NPOI.SS.Formula.Functions.TextFunction.EvaluateStringArg(arg0, srcRowIndex, srcColumnIndex);
				num = global::NPOI.SS.Formula.Functions.TextFunction.EvaluateIntArg(arg1, srcRowIndex, srcColumnIndex);
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
			{
				return ex.GetErrorEval();
			}
			if (num < 0)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
			string value;
			if (this._isLeft)
			{
				value = text.Substring(0, global::System.Math.Min(text.Length, num));
			}
			else
			{
				value = text.Substring(global::System.Math.Max(0, text.Length - num));
			}
			return new global::NPOI.SS.Formula.Eval.StringEval(value);
		}

		// Token: 0x040005B9 RID: 1465
		private static global::NPOI.SS.Formula.Eval.ValueEval DEFAULT_ARG1 = new global::NPOI.SS.Formula.Eval.NumberEval(1.0);

		// Token: 0x040005BA RID: 1466
		private bool _isLeft;
	}
}
