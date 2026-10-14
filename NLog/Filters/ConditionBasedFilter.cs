using System;
using NLog.Conditions;
using NLog.Config;

namespace NLog.Filters
{
	// Token: 0x0200014C RID: 332
	[global::NLog.Filters.Filter("when")]
	public class ConditionBasedFilter : global::NLog.Filters.Filter
	{
		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x06000EEB RID: 3819 RVA: 0x000260A4 File Offset: 0x000242A4
		// (set) Token: 0x06000EEC RID: 3820 RVA: 0x000260AC File Offset: 0x000242AC
		[global::NLog.Config.RequiredParameter]
		public global::NLog.Conditions.ConditionExpression Condition { get; set; }

		// Token: 0x06000EED RID: 3821 RVA: 0x000260B8 File Offset: 0x000242B8
		protected override global::NLog.Filters.FilterResult Check(global::NLog.LogEventInfo logEvent)
		{
			object obj = this.Condition.Evaluate(logEvent);
			if (global::NLog.Filters.ConditionBasedFilter.boxedTrue.Equals(obj))
			{
				return base.Action;
			}
			return global::NLog.Filters.FilterResult.Neutral;
		}

		// Token: 0x04000417 RID: 1047
		private static readonly object boxedTrue = true;
	}
}
