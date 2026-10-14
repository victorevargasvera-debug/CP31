using System;
using NLog.Common;
using NLog.Config;
using NLog.Internal;

namespace NLog.Conditions
{
	// Token: 0x02000177 RID: 375
	[global::NLog.Config.NLogConfigurationItem]
	[global::NLog.Config.ThreadAgnostic]
	public abstract class ConditionExpression
	{
		// Token: 0x0600104F RID: 4175 RVA: 0x0002B2CD File Offset: 0x000294CD
		public static implicit operator global::NLog.Conditions.ConditionExpression(string conditionExpressionText)
		{
			return global::NLog.Conditions.ConditionParser.ParseExpression(conditionExpressionText);
		}

		// Token: 0x06001050 RID: 4176 RVA: 0x0002B2D8 File Offset: 0x000294D8
		public object Evaluate(global::NLog.LogEventInfo context)
		{
			object result;
			try
			{
				result = this.EvaluateNode(context);
			}
			catch (global::System.Exception ex)
			{
				global::NLog.Common.InternalLogger.Warn(ex, "Exception occurred when evaluating condition");
				if (ex.MustBeRethrownImmediately())
				{
					throw;
				}
				throw new global::NLog.Conditions.ConditionEvaluationException("Exception occurred when evaluating condition", ex);
			}
			return result;
		}

		// Token: 0x06001051 RID: 4177
		public abstract override string ToString();

		// Token: 0x06001052 RID: 4178
		protected abstract object EvaluateNode(global::NLog.LogEventInfo context);
	}
}
