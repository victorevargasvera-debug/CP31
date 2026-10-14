using System;
using NPOI.SS.Formula.Eval;
using NPOI.SS.Formula.Functions;

namespace NPOI.SS.Formula.Atp
{
	// Token: 0x0200023A RID: 570
	public class NotImplemented : global::NPOI.SS.Formula.Functions.FreeRefFunction
	{
		// Token: 0x06000DE1 RID: 3553 RVA: 0x00027005 File Offset: 0x00025205
		public NotImplemented(string functionName)
		{
			this._functionName = functionName;
		}

		// Token: 0x06000DE2 RID: 3554 RVA: 0x00027014 File Offset: 0x00025214
		public global::NPOI.SS.Formula.Eval.ValueEval Evaluate(global::NPOI.SS.Formula.Eval.ValueEval[] args, global::NPOI.SS.Formula.OperationEvaluationContext ec)
		{
			throw new global::NPOI.SS.Formula.Eval.NotImplementedFunctionException(this._functionName);
		}

		// Token: 0x0400062C RID: 1580
		private string _functionName;
	}
}
