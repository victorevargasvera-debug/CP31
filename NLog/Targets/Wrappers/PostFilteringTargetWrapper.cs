using System;
using System.Collections.Generic;
using NLog.Common;
using NLog.Conditions;
using NLog.Config;

namespace NLog.Targets.Wrappers
{
	// Token: 0x02000069 RID: 105
	[global::NLog.Targets.Target("PostFilteringWrapper", IsWrapper = true)]
	public class PostFilteringTargetWrapper : global::NLog.Targets.Wrappers.WrapperTargetBase
	{
		// Token: 0x06000836 RID: 2102 RVA: 0x00014DA2 File Offset: 0x00012FA2
		public PostFilteringTargetWrapper() : this(null)
		{
			this.Rules = new global::System.Collections.Generic.List<global::NLog.Targets.Wrappers.FilteringRule>();
		}

		// Token: 0x06000837 RID: 2103 RVA: 0x00014DB6 File Offset: 0x00012FB6
		public PostFilteringTargetWrapper(global::NLog.Targets.Target wrappedTarget)
		{
			this.Rules = new global::System.Collections.Generic.List<global::NLog.Targets.Wrappers.FilteringRule>();
			base.WrappedTarget = wrappedTarget;
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x00014DD0 File Offset: 0x00012FD0
		public PostFilteringTargetWrapper(string name, global::NLog.Targets.Target wrappedTarget) : this(wrappedTarget)
		{
			base.Name = name;
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06000839 RID: 2105 RVA: 0x00014DE0 File Offset: 0x00012FE0
		// (set) Token: 0x0600083A RID: 2106 RVA: 0x00014DE8 File Offset: 0x00012FE8
		public global::NLog.Conditions.ConditionExpression DefaultFilter { get; set; }

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x0600083B RID: 2107 RVA: 0x00014DF1 File Offset: 0x00012FF1
		// (set) Token: 0x0600083C RID: 2108 RVA: 0x00014DF9 File Offset: 0x00012FF9
		[global::NLog.Config.ArrayParameter(typeof(global::NLog.Targets.Wrappers.FilteringRule), "when")]
		public global::System.Collections.Generic.IList<global::NLog.Targets.Wrappers.FilteringRule> Rules { get; private set; }

		// Token: 0x0600083D RID: 2109 RVA: 0x00014E02 File Offset: 0x00013002
		[global::System.Obsolete("Instead override Write(IList<AsyncLogEventInfo> logEvents. Marked obsolete on NLog 4.5")]
		protected override void Write(global::NLog.Common.AsyncLogEventInfo[] logEvents)
		{
			this.Write(logEvents);
		}

		// Token: 0x0600083E RID: 2110 RVA: 0x00014E0C File Offset: 0x0001300C
		protected override void Write(global::System.Collections.Generic.IList<global::NLog.Common.AsyncLogEventInfo> logEvents)
		{
			global::NLog.Conditions.ConditionExpression conditionExpression = null;
			global::NLog.Common.InternalLogger.Trace<string, int>("PostFilteringWrapper(Name={0}): Running on {1} events", base.Name, logEvents.Count);
			for (int i = 0; i < logEvents.Count; i++)
			{
				foreach (global::NLog.Targets.Wrappers.FilteringRule filteringRule in this.Rules)
				{
					object obj = filteringRule.Exists.Evaluate(logEvents[i].LogEvent);
					if (global::NLog.Targets.Wrappers.PostFilteringTargetWrapper.boxedTrue.Equals(obj))
					{
						global::NLog.Common.InternalLogger.Trace<string, global::NLog.Conditions.ConditionExpression>("PostFilteringWrapper(Name={0}): Rule matched: {1}", base.Name, filteringRule.Exists);
						conditionExpression = filteringRule.Filter;
						break;
					}
				}
				if (conditionExpression != null)
				{
					break;
				}
			}
			if (conditionExpression == null)
			{
				conditionExpression = this.DefaultFilter;
			}
			if (conditionExpression == null)
			{
				base.WrappedTarget.WriteAsyncLogEvents(logEvents);
				return;
			}
			global::NLog.Common.InternalLogger.Trace<string, global::NLog.Conditions.ConditionExpression>("PostFilteringWrapper(Name={0}): Filter to apply: {1}", base.Name, conditionExpression);
			global::System.Collections.Generic.List<global::NLog.Common.AsyncLogEventInfo> list = new global::System.Collections.Generic.List<global::NLog.Common.AsyncLogEventInfo>();
			for (int j = 0; j < logEvents.Count; j++)
			{
				object obj2 = conditionExpression.Evaluate(logEvents[j].LogEvent);
				if (global::NLog.Targets.Wrappers.PostFilteringTargetWrapper.boxedTrue.Equals(obj2))
				{
					list.Add(logEvents[j]);
				}
				else
				{
					logEvents[j].Continuation(null);
				}
			}
			global::NLog.Common.InternalLogger.Trace<string, int>("PostFilteringWrapper(Name={0}): After filtering: {1} events.", base.Name, list.Count);
			if (list.Count > 0)
			{
				global::NLog.Common.InternalLogger.Trace<string, global::NLog.Targets.Target>("PostFilteringWrapper(Name={0}): Sending to {1}", base.Name, base.WrappedTarget);
				base.WrappedTarget.WriteAsyncLogEvents(list);
			}
		}

		// Token: 0x040001DF RID: 479
		private static object boxedTrue = true;
	}
}
