using System;
using NPOI.SS.Formula.Eval;
using NPOI.SS.UserModel;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001B9 RID: 441
	public class Now : global::NPOI.SS.Formula.Functions.Fixed0ArgFunction
	{
		// Token: 0x06000BEE RID: 3054 RVA: 0x00020C18 File Offset: 0x0001EE18
		public override global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex)
		{
			return new global::NPOI.SS.Formula.Eval.NumberEval(global::NPOI.SS.UserModel.DateUtil.GetExcelDate(global::System.DateTime.Now));
		}
	}
}
