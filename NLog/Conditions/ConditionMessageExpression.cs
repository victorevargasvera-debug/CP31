using System;

namespace NLog.Conditions
{
	// Token: 0x0200017C RID: 380
	internal sealed class ConditionMessageExpression : global::NLog.Conditions.ConditionExpression
	{
		// Token: 0x06001064 RID: 4196 RVA: 0x0002B3DD File Offset: 0x000295DD
		public override string ToString()
		{
			return "message";
		}

		// Token: 0x06001065 RID: 4197 RVA: 0x0002B3E4 File Offset: 0x000295E4
		protected override object EvaluateNode(global::NLog.LogEventInfo context)
		{
			return context.FormattedMessage;
		}
	}
}
