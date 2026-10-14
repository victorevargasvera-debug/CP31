using System;
using NLog.Common;
using NLog.Conditions;
using NLog.Config;

namespace NLog.Targets.Wrappers
{
	// Token: 0x02000065 RID: 101
	[global::NLog.Targets.Target("FilteringWrapper", IsWrapper = true)]
	public class FilteringTargetWrapper : global::NLog.Targets.Wrappers.WrapperTargetBase
	{
		// Token: 0x06000807 RID: 2055 RVA: 0x00014817 File Offset: 0x00012A17
		public FilteringTargetWrapper() : this(null, null)
		{
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x00014821 File Offset: 0x00012A21
		public FilteringTargetWrapper(string name, global::NLog.Targets.Target wrappedTarget, global::NLog.Conditions.ConditionExpression condition) : this(wrappedTarget, condition)
		{
			base.Name = name;
		}

		// Token: 0x06000809 RID: 2057 RVA: 0x00014832 File Offset: 0x00012A32
		public FilteringTargetWrapper(global::NLog.Targets.Target wrappedTarget, global::NLog.Conditions.ConditionExpression condition)
		{
			base.WrappedTarget = wrappedTarget;
			this.Condition = condition;
			base.OptimizeBufferReuse = (base.GetType() == typeof(global::NLog.Targets.Wrappers.FilteringTargetWrapper));
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x0600080A RID: 2058 RVA: 0x00014863 File Offset: 0x00012A63
		// (set) Token: 0x0600080B RID: 2059 RVA: 0x0001486B File Offset: 0x00012A6B
		[global::NLog.Config.RequiredParameter]
		public global::NLog.Conditions.ConditionExpression Condition { get; set; }

		// Token: 0x0600080C RID: 2060 RVA: 0x00014874 File Offset: 0x00012A74
		protected override void Write(global::NLog.Common.AsyncLogEventInfo logEvent)
		{
			object obj = this.Condition.Evaluate(logEvent.LogEvent);
			if (global::NLog.Targets.Wrappers.FilteringTargetWrapper.boxedBooleanTrue.Equals(obj))
			{
				base.WrappedTarget.WriteAsyncLogEvent(logEvent);
				return;
			}
			logEvent.Continuation(null);
		}

		// Token: 0x040001CE RID: 462
		private static readonly object boxedBooleanTrue = true;
	}
}
