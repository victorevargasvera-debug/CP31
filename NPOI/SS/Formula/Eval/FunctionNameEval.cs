using System;
using System.Text;

namespace NPOI.SS.Formula.Eval
{
	// Token: 0x0200020E RID: 526
	public class FunctionNameEval : global::NPOI.SS.Formula.Eval.ValueEval
	{
		// Token: 0x06000D24 RID: 3364 RVA: 0x00024E7F File Offset: 0x0002307F
		public FunctionNameEval(string functionName)
		{
			this._functionName = functionName;
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06000D25 RID: 3365 RVA: 0x00024E8E File Offset: 0x0002308E
		public string FunctionName
		{
			get
			{
				return this._functionName;
			}
		}

		// Token: 0x06000D26 RID: 3366 RVA: 0x00024E98 File Offset: 0x00023098
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(64);
			stringBuilder.Append(base.GetType().Name).Append(" [");
			stringBuilder.Append(this._functionName);
			stringBuilder.Append("]");
			return stringBuilder.ToString();
		}

		// Token: 0x040005F4 RID: 1524
		private string _functionName;
	}
}
