using System;
using System.ComponentModel;
using NLog.Common;
using NLog.Time;

namespace NLog.Targets.Wrappers
{
	// Token: 0x02000067 RID: 103
	[global::NLog.Targets.Target("LimitingWrapper", IsWrapper = true)]
	public class LimitingTargetWrapper : global::NLog.Targets.Wrappers.WrapperTargetBase
	{
		// Token: 0x06000827 RID: 2087 RVA: 0x00014BBA File Offset: 0x00012DBA
		public LimitingTargetWrapper() : this(null)
		{
		}

		// Token: 0x06000828 RID: 2088 RVA: 0x00014BC3 File Offset: 0x00012DC3
		public LimitingTargetWrapper(string name, global::NLog.Targets.Target wrappedTarget) : this(wrappedTarget, 1000, global::System.TimeSpan.FromHours(1.0))
		{
			base.Name = name;
		}

		// Token: 0x06000829 RID: 2089 RVA: 0x00014BE6 File Offset: 0x00012DE6
		public LimitingTargetWrapper(global::NLog.Targets.Target wrappedTarget) : this(wrappedTarget, 1000, global::System.TimeSpan.FromHours(1.0))
		{
		}

		// Token: 0x0600082A RID: 2090 RVA: 0x00014C02 File Offset: 0x00012E02
		public LimitingTargetWrapper(global::NLog.Targets.Target wrappedTarget, int messageLimit, global::System.TimeSpan interval)
		{
			this.MessageLimit = messageLimit;
			this.Interval = interval;
			base.WrappedTarget = wrappedTarget;
			base.OptimizeBufferReuse = (base.GetType() == typeof(global::NLog.Targets.Wrappers.LimitingTargetWrapper));
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x0600082B RID: 2091 RVA: 0x00014C3A File Offset: 0x00012E3A
		// (set) Token: 0x0600082C RID: 2092 RVA: 0x00014C42 File Offset: 0x00012E42
		[global::System.ComponentModel.DefaultValue(1000)]
		public int MessageLimit { get; set; }

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x0600082D RID: 2093 RVA: 0x00014C4B File Offset: 0x00012E4B
		// (set) Token: 0x0600082E RID: 2094 RVA: 0x00014C53 File Offset: 0x00012E53
		[global::System.ComponentModel.DefaultValue(typeof(global::System.TimeSpan), "01:00")]
		public global::System.TimeSpan Interval { get; set; }

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x0600082F RID: 2095 RVA: 0x00014C5C File Offset: 0x00012E5C
		public global::System.DateTime IntervalResetsAt
		{
			get
			{
				return this._firstWriteInInterval + this.Interval;
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06000830 RID: 2096 RVA: 0x00014C6F File Offset: 0x00012E6F
		// (set) Token: 0x06000831 RID: 2097 RVA: 0x00014C77 File Offset: 0x00012E77
		public int MessagesWrittenCount { get; private set; }

		// Token: 0x06000832 RID: 2098 RVA: 0x00014C80 File Offset: 0x00012E80
		protected override void InitializeTarget()
		{
			if (this.MessageLimit <= 0)
			{
				throw new global::NLog.NLogConfigurationException("The LimitingTargetWrapper's MessageLimit property must be > 0.");
			}
			if (this.Interval <= global::System.TimeSpan.Zero)
			{
				throw new global::NLog.NLogConfigurationException("The LimitingTargetWrapper's property Interval must be > 0.");
			}
			base.InitializeTarget();
			this.ResetInterval();
			global::NLog.Common.InternalLogger.Trace<string, int, global::System.TimeSpan>("LimitingWrapper(Name={0}): Initialized with MessageLimit={1} and Interval={2}.", base.Name, this.MessageLimit, this.Interval);
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x00014CE8 File Offset: 0x00012EE8
		protected override void Write(global::NLog.Common.AsyncLogEventInfo logEvent)
		{
			if (this.IsIntervalExpired())
			{
				this.ResetInterval();
				global::NLog.Common.InternalLogger.Debug<string, global::System.TimeSpan>("LimitingWrapper(Name={0}): New interval of '{1}' started.", base.Name, this.Interval);
			}
			if (this.MessagesWrittenCount < this.MessageLimit)
			{
				base.WrappedTarget.WriteAsyncLogEvent(logEvent);
				int messagesWrittenCount = this.MessagesWrittenCount;
				this.MessagesWrittenCount = messagesWrittenCount + 1;
				return;
			}
			logEvent.Continuation(null);
			global::NLog.Common.InternalLogger.Trace<string, int>("LimitingWrapper(Name={0}): Discarded event, because MessageLimit of '{1}' was reached.", base.Name, this.MessageLimit);
		}

		// Token: 0x06000834 RID: 2100 RVA: 0x00014D67 File Offset: 0x00012F67
		private void ResetInterval()
		{
			this._firstWriteInInterval = global::NLog.Time.TimeSource.Current.Time;
			this.MessagesWrittenCount = 0;
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x00014D80 File Offset: 0x00012F80
		private bool IsIntervalExpired()
		{
			return global::NLog.Time.TimeSource.Current.Time - this._firstWriteInInterval > this.Interval;
		}

		// Token: 0x040001D9 RID: 473
		private global::System.DateTime _firstWriteInInterval;
	}
}
