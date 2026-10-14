using System;
using NPOI.SS.Formula.Eval;
using NPOI.SS.UserModel;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001FA RID: 506
	public class Today : global::NPOI.SS.Formula.Functions.Fixed0ArgFunction
	{
		// Token: 0x06000CB4 RID: 3252 RVA: 0x00022BF6 File Offset: 0x00020DF6
		public override global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex)
		{
			return new global::NPOI.SS.Formula.Eval.NumberEval(global::NPOI.SS.UserModel.DateUtil.GetExcelDate(global::System.DateTime.Today));
		}
	}
}
