using System;
using System.Globalization;
using System.Text;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x02000154 RID: 340
	public class Proper : global::NPOI.SS.Formula.Functions.SingleArgTextFunc
	{
		// Token: 0x06000A97 RID: 2711 RVA: 0x0001C9F4 File Offset: 0x0001ABF4
		public override global::NPOI.SS.Formula.Eval.ValueEval Evaluate(string text)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			bool flag = true;
			foreach (char c in text.ToCharArray())
			{
				if (flag)
				{
					stringBuilder.Append(c.ToString().ToUpper(global::System.Globalization.CultureInfo.CurrentCulture));
				}
				else
				{
					stringBuilder.Append(c.ToString().ToLower(global::System.Globalization.CultureInfo.CurrentCulture));
				}
				flag = !char.IsLetter(c);
			}
			return new global::NPOI.SS.Formula.Eval.StringEval(stringBuilder.ToString());
		}
	}
}
