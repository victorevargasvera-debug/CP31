using System;

namespace NLog.Conditions
{
	// Token: 0x02000182 RID: 386
	internal sealed class ConditionOrExpression : global::NLog.Conditions.ConditionExpression
	{
		// Token: 0x0600107F RID: 4223 RVA: 0x0002B863 File Offset: 0x00029A63
		public ConditionOrExpression(global::NLog.Conditions.ConditionExpression left, global::NLog.Conditions.ConditionExpression right)
		{
			this.LeftExpression = left;
			this.RightExpression = right;
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06001080 RID: 4224 RVA: 0x0002B879 File Offset: 0x00029A79
		// (set) Token: 0x06001081 RID: 4225 RVA: 0x0002B881 File Offset: 0x00029A81
		public global::NLog.Conditions.ConditionExpression LeftExpression { get; private set; }

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06001082 RID: 4226 RVA: 0x0002B88A File Offset: 0x00029A8A
		// (set) Token: 0x06001083 RID: 4227 RVA: 0x0002B892 File Offset: 0x00029A92
		public global::NLog.Conditions.ConditionExpression RightExpression { get; private set; }

		// Token: 0x06001084 RID: 4228 RVA: 0x0002B89B File Offset: 0x00029A9B
		public override string ToString()
		{
			return string.Format("({0} or {1})", this.LeftExpression, this.RightExpression);
		}

		// Token: 0x06001085 RID: 4229 RVA: 0x0002B8B3 File Offset: 0x00029AB3
		protected override object EvaluateNode(global::NLog.LogEventInfo context)
		{
			if ((bool)this.LeftExpression.Evaluate(context))
			{
				return global::NLog.Conditions.ConditionOrExpression.boxedTrue;
			}
			if ((bool)this.RightExpression.Evaluate(context))
			{
				return global::NLog.Conditions.ConditionOrExpression.boxedTrue;
			}
			return global::NLog.Conditions.ConditionOrExpression.boxedFalse;
		}

		// Token: 0x04000487 RID: 1159
		private static readonly object boxedFalse = false;

		// Token: 0x04000488 RID: 1160
		private static readonly object boxedTrue = true;
	}
}
