using System;

namespace NLog.Conditions
{
	// Token: 0x0200017B RID: 379
	internal sealed class ConditionLoggerNameExpression : global::NLog.Conditions.ConditionExpression
	{
		// Token: 0x06001061 RID: 4193 RVA: 0x0002B3C6 File Offset: 0x000295C6
		public override string ToString()
		{
			return "logger";
		}

		// Token: 0x06001062 RID: 4194 RVA: 0x0002B3CD File Offset: 0x000295CD
		protected override object EvaluateNode(global::NLog.LogEventInfo context)
		{
			return context.LoggerName;
		}
	}
}
