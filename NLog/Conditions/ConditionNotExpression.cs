using System;

namespace NLog.Conditions
{
	// Token: 0x02000181 RID: 385
	internal sealed class ConditionNotExpression : global::NLog.Conditions.ConditionExpression
	{
		// Token: 0x0600107A RID: 4218 RVA: 0x0002B816 File Offset: 0x00029A16
		public ConditionNotExpression(global::NLog.Conditions.ConditionExpression expression)
		{
			this.Expression = expression;
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x0600107B RID: 4219 RVA: 0x0002B825 File Offset: 0x00029A25
		// (set) Token: 0x0600107C RID: 4220 RVA: 0x0002B82D File Offset: 0x00029A2D
		public global::NLog.Conditions.ConditionExpression Expression { get; private set; }

		// Token: 0x0600107D RID: 4221 RVA: 0x0002B836 File Offset: 0x00029A36
		public override string ToString()
		{
			return string.Format("(not {0})", this.Expression);
		}

		// Token: 0x0600107E RID: 4222 RVA: 0x0002B848 File Offset: 0x00029A48
		protected override object EvaluateNode(global::NLog.LogEventInfo context)
		{
			return !(bool)this.Expression.Evaluate(context);
		}
	}
}
