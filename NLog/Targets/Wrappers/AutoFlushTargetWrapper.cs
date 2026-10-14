using System;
using NLog.Common;
using NLog.Conditions;
using NLog.Internal;

namespace NLog.Targets.Wrappers
{
	// Token: 0x0200005F RID: 95
	[global::NLog.Targets.Target("AutoFlushWrapper", IsWrapper = true)]
	public class AutoFlushTargetWrapper : global::NLog.Targets.Wrappers.WrapperTargetBase
	{
		// Token: 0x17000146 RID: 326
		// (get) Token: 0x060007D5 RID: 2005 RVA: 0x00014114 File Offset: 0x00012314
		// (set) Token: 0x060007D6 RID: 2006 RVA: 0x0001411C File Offset: 0x0001231C
		public global::NLog.Conditions.ConditionExpression Condition { get; set; }

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x060007D7 RID: 2007 RVA: 0x00014128 File Offset: 0x00012328
		// (set) Token: 0x060007D8 RID: 2008 RVA: 0x0001414E File Offset: 0x0001234E
		public bool AsyncFlush
		{
			get
			{
				return this._asyncFlush ?? true;
			}
			set
			{
				this._asyncFlush = new bool?(value);
			}
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x0001415C File Offset: 0x0001235C
		public AutoFlushTargetWrapper() : this(null)
		{
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x00014165 File Offset: 0x00012365
		public AutoFlushTargetWrapper(string name, global::NLog.Targets.Target wrappedTarget) : this(wrappedTarget)
		{
			base.Name = name;
		}

		// Token: 0x060007DB RID: 2011 RVA: 0x00014175 File Offset: 0x00012375
		public AutoFlushTargetWrapper(global::NLog.Targets.Target wrappedTarget)
		{
			base.WrappedTarget = wrappedTarget;
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x0001418F File Offset: 0x0001238F
		protected override void InitializeTarget()
		{
			base.InitializeTarget();
			if (this._asyncFlush == null && base.WrappedTarget is global::NLog.Targets.Wrappers.BufferingTargetWrapper)
			{
				this.AsyncFlush = false;
			}
		}

		// Token: 0x060007DD RID: 2013 RVA: 0x000141B8 File Offset: 0x000123B8
		protected override void Write(global::NLog.Common.AsyncLogEventInfo logEvent)
		{
			if (this.Condition != null && !this.Condition.Evaluate(logEvent.LogEvent).Equals(true))
			{
				base.WrappedTarget.WriteAsyncLogEvent(logEvent);
				return;
			}
			if (this.AsyncFlush)
			{
				global::NLog.Common.AsyncContinuation currentContinuation = logEvent.Continuation;
				global::NLog.Common.AsyncContinuation asyncContinuation = delegate(global::System.Exception ex)
				{
					if (ex == null)
					{
						this.WrappedTarget.Flush(delegate(global::System.Exception e)
						{
						});
					}
					this._pendingManualFlushList.CompleteOperation(ex);
					currentContinuation(ex);
				};
				this._pendingManualFlushList.BeginOperation();
				base.WrappedTarget.WriteAsyncLogEvent(logEvent.LogEvent.WithContinuation(asyncContinuation));
				return;
			}
			base.WrappedTarget.WriteAsyncLogEvent(logEvent);
			this.FlushAsync(delegate(global::System.Exception e)
			{
			});
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x00014280 File Offset: 0x00012480
		protected override void FlushAsync(global::NLog.Common.AsyncContinuation asyncContinuation)
		{
			global::NLog.Common.AsyncContinuation asyncContinuation2 = this._pendingManualFlushList.RegisterCompletionNotification(asyncContinuation);
			base.WrappedTarget.Flush(asyncContinuation2);
		}

		// Token: 0x060007DF RID: 2015 RVA: 0x000142A6 File Offset: 0x000124A6
		protected override void CloseTarget()
		{
			this._pendingManualFlushList.Clear();
			base.CloseTarget();
		}

		// Token: 0x040001BD RID: 445
		private bool? _asyncFlush;

		// Token: 0x040001BE RID: 446
		private readonly global::NLog.Internal.AsyncOperationCounter _pendingManualFlushList = new global::NLog.Internal.AsyncOperationCounter();
	}
}
