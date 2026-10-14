using System;
using System.Text;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001EA RID: 490
	public class Clean : global::NPOI.SS.Formula.Functions.SingleArgTextFunc
	{
		// Token: 0x06000C84 RID: 3204 RVA: 0x00022418 File Offset: 0x00020618
		public override global::NPOI.SS.Formula.Eval.ValueEval Evaluate(string arg)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			foreach (char c in arg)
			{
				if (global::NPOI.SS.Formula.Functions.TextFunction.IsPrintable(c))
				{
					stringBuilder.Append(c);
				}
			}
			return new global::NPOI.SS.Formula.Eval.StringEval(stringBuilder.ToString());
		}
	}
}
