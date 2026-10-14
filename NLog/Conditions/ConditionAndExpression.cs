using System;

namespace NLog.Conditions
{
	// Token: 0x02000175 RID: 373
	internal sealed class ConditionAndExpression : global::NLog.Conditions.ConditionExpression
	{
		// Token: 0x06001043 RID: 4163 RVA: 0x0002B207 File Offset: 0x00029407
		public ConditionAndExpression(global::NLog.Conditions.ConditionExpression left, global::NLog.Conditions.ConditionExpression right)
		{
			this.Left = left;
			this.Right = right;
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06001044 RID: 4164 RVA: 0x0002B21D File Offset: 0x0002941D
		// (set) Token: 0x06001045 RID: 4165 RVA: 0x0002B225 File Offset: 0x00029425
		public global::NLog.Conditions.ConditionExpression Left { get; private set; }

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06001046 RID: 4166 RVA: 0x0002B22E File Offset: 0x0002942E
		// (set) Token: 0x06001047 RID: 4167 RVA: 0x0002B236 File Offset: 0x00029436
		public global::NLog.Conditions.ConditionExpression Right { get; private set; }

		// Token: 0x06001048 RID: 4168 RVA: 0x0002B23F File Offset: 0x0002943F
		public override string ToString()
		{
			return string.Format("({0} and {1})", this.Left, this.Right);
		}

		// Token: 0x06001049 RID: 4169 RVA: 0x0002B257 File Offset: 0x00029457
		protected override object EvaluateNode(global::NLog.LogEventInfo context)
		{
			if (!(bool)this.Left.Evaluate(context))
			{
				return global::NLog.Conditions.ConditionAndExpression.boxedFalse;
			}
			if (!(bool)this.Right.Evaluate(context))
			{
				return global::NLog.Conditions.ConditionAndExpression.boxedFalse;
			}
			return global::NLog.Conditions.ConditionAndExpression.boxedTrue;
		}

		// Token: 0x0400047A RID: 1146
		private static readonly object boxedFalse = false;

		// Token: 0x0400047B RID: 1147
		private static readonly object boxedTrue = true;
	}
}
