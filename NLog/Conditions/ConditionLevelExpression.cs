using System;

namespace NLog.Conditions
{
	// Token: 0x02000179 RID: 377
	internal sealed class ConditionLevelExpression : global::NLog.Conditions.ConditionExpression
	{
		// Token: 0x06001059 RID: 4185 RVA: 0x0002B367 File Offset: 0x00029567
		public override string ToString()
		{
			return "level";
		}

		// Token: 0x0600105A RID: 4186 RVA: 0x0002B36E File Offset: 0x0002956E
		protected override object EvaluateNode(global::NLog.LogEventInfo context)
		{
			return context.Level;
		}
	}
}
