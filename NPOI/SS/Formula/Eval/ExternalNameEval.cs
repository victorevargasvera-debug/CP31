using System;
using System.Text;

namespace NPOI.SS.Formula.Eval
{
	// Token: 0x0200020F RID: 527
	public class ExternalNameEval : global::NPOI.SS.Formula.Eval.ValueEval
	{
		// Token: 0x06000D27 RID: 3367 RVA: 0x00024EE6 File Offset: 0x000230E6
		public ExternalNameEval(global::NPOI.SS.Formula.IEvaluationName name)
		{
			this._name = name;
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06000D28 RID: 3368 RVA: 0x00024EF5 File Offset: 0x000230F5
		public global::NPOI.SS.Formula.IEvaluationName Name
		{
			get
			{
				return this._name;
			}
		}

		// Token: 0x06000D29 RID: 3369 RVA: 0x00024F00 File Offset: 0x00023100
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(64);
			stringBuilder.Append(base.GetType().Name).Append(" [");
			stringBuilder.Append(this._name.NameText);
			stringBuilder.Append("]");
			return stringBuilder.ToString();
		}

		// Token: 0x040005F5 RID: 1525
		private global::NPOI.SS.Formula.IEvaluationName _name;
	}
}
