using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using NLog.Common;
using NLog.Internal;

namespace NLog.Targets.Wrappers
{
	// Token: 0x0200005D RID: 93
	[global::NLog.Targets.Target("AsyncWrapper", IsWrapper = true)]
	public class AsyncTargetWrapper : global::NLog.Targets.Wrappers.WrapperTargetBase
	{
		// Token: 0x060007BA RID: 1978 RVA: 0x00013A78 File Offset: 0x00011C78
		public AsyncTargetWrapper() : this(null)
		{
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x00013A81 File Offset: 0x00011C81
		public AsyncTargetWrapper(string name, global::NLog.Targets.Target wrappedTarget) : this(wrappedTarget)
		{
			base.Name = name;
		}

		// Token: 0x060007BC RID: 1980 RVA: 0x00013A91 File Offset: 0x00011C91
		public AsyncTargetWrapper(global::NLog.Targets.Target wrappedTarget) : this(wrappedTarget, 10000, global::NLog.Targets.Wrappers.AsyncTargetWrapperOverflowAction.Discard)
		{
		}

		// Token: 0x060007BD RID: 1981 RVA: 0x00013AA0 File Offset: 0x00011CA0
		public AsyncTargetWrapper(global::NLog.Targets.Target wrappedTarget, int queueLimit, global::NLog.Targets.Wrappers.AsyncTargetWrapperOverflowAction overflowAction)
		{
			this.RequestQueue = new global::NLog.Targets.Wrappers.AsyncRequestQueue(10000, global::NLog.Targets.Wrappers.AsyncTargetWrapperOverflowAction.Discard);
			this.TimeToSleepBetweenBatches = 50;
			this.BatchSize = 200;
			this.FullBatchSizeWriteLimit = 5;
			base.WrappedTarget = wrappedTarget;
			this.QueueLimit = queueLimit;
			this.OverflowAction = overflowAction;
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x060007BE RID: 1982 RVA: 0x00013B19 File Offset: 0x00011D19
		// (set) Token: 0x060007BF RID: 1983 RVA: 0x00013B21 File Offset: 0x00011D21
		[global::System.ComponentModel.DefaultValue(200)]
		public int BatchSize { get; set; }

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x060007C0 RID: 1984 RVA: 0x00013B2A File Offset: 0x00011D2A
		// (set) Token: 0x060007C1 RID: 1985 RVA: 0x00013B32 File Offset: 0x00011D32
		[global::System.ComponentModel.DefaultValue(50)]
		public int TimeToSleepBetweenBatches { get; set; }

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x060007C2 RID: 1986 RVA: 0x00013B3B File Offset: 0x00011D3B
		// (set) Token: 0x060007C3 RID: 1987 RVA: 0x00013B48 File Offset: 0x00011D48
		[global::System.ComponentModel.DefaultValue("Discard")]
		public global::NLog.Targets.Wrappers.AsyncTargetWrapperOverflowAction OverflowAction
		{
			get
			{
				return this.RequestQueue.OnOverflow;
			}
			set
			{
				this.RequestQueue.OnOverflow = value;
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x060007C4 RID: 1988 RVA: 0x00013B56 File Offset: 0x00011D56
		// (set) Token: 0x060007C5 RID: 1989 RVA: 0x00013B63 File Offset: 0x00011D63
		[global::System.ComponentModel.DefaultValue(10000)]
		public int QueueLimit
		{
			get
			{
				return this.RequestQueue.RequestLimit;
			}
			set
			{
				this.RequestQueue.RequestLimit = value;
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x060007C6 RID: 1990 RVA: 0x00013B71 File Offset: 0x00011D71
		// (set) Token: 0x060007C7 RID: 1991 RVA: 0x00013B79 File Offset: 0x00011D79
		[global::System.ComponentModel.DefaultValue(5)]
		public int FullBatchSizeWriteLimit { get; set; }

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x060007C8 RID: 1992 RVA: 0x00013B82 File Offset: 0x00011D82
		// (set) Token: 0x060007C9 RID: 1993 RVA: 0x00013B8A File Offset: 0x00011D8A
		internal global::NLog.Targets.Wrappers.AsyncRequestQueue RequestQueue { get; private set; }

		// Token: 0x060007CA RID: 1994 RVA: 0x00013B93 File Offset: 0x00011D93
		protected override void FlushAsync(global::NLog.Common.AsyncContinuation asyncContinuation)
		{
			if (this._flushEventsInQueueDelegate == null)
			{
				this._flushEventsInQueueDelegate = new global::System.Action<object>(this.FlushEventsInQueue);
			}
			global::NLog.Common.AsyncHelpers.StartAsyncTask(this._flushEventsInQueueDelegate, asyncContinuation);
		}

		// Token: 0x060007CB RID: 1995 RVA: 0x00013BBC File Offset: 0x00011DBC
		protected override void InitializeTarget()
		{
			base.InitializeTarget();
			if (!base.OptimizeBufferReuse && base.WrappedTarget != null && base.WrappedTarget.OptimizeBufferReuse)
			{
				base.OptimizeBufferReuse = (base.GetType() == typeof(global::NLog.Targets.Wrappers.AsyncTargetWrapper));
			}
			this.RequestQueue.Clear();
			global::NLog.Common.InternalLogger.Trace<string>("AsyncWrapper(Name={0}): Start Timer", base.Name);
			this._lazyWriterTimer = new global::System.Threading.Timer(new global::System.Threading.TimerCallback(this.ProcessPendingEvents), null, -1, -1);
			this.StartLazyWriterTimer();
		}

		// Token: 0x060007CC RID: 1996 RVA: 0x00013C44 File Offset: 0x00011E44
		protected override void CloseTarget()
		{
			this.StopLazyWriterThread();
			if (global::System.Threading.Monitor.TryEnter(this._writeLockObject, 500))
			{
				try
				{
					this.WriteEventsInQueue(int.MaxValue, "Closing Target");
				}
				finally
				{
					global::System.Threading.Monitor.Exit(this._writeLockObject);
				}
			}
			base.CloseTarget();
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x00013CA0 File Offset: 0x00011EA0
		protected virtual void StartLazyWriterTimer()
		{
			object timerLockObject = this._timerLockObject;
			lock (timerLockObject)
			{
				if (this._lazyWriterTimer != null)
				{
					if (this.TimeToSleepBetweenBatches <= 0)
					{
						global::NLog.Common.InternalLogger.Trace<string>("AsyncWrapper(Name={0}): Throttled timer scheduled", base.Name);
						this._lazyWriterTimer.Change(1, -1);
					}
					else
					{
						this._lazyWriterTimer.Change(this.TimeToSleepBetweenBatches, -1);
					}
				}
			}
		}

		// Token: 0x060007CE RID: 1998 RVA: 0x00013D20 File Offset: 0x00011F20
		protected virtual bool StartInstantWriterTimer()
		{
			bool flag = false;
			bool result;
			try
			{
				flag = global::System.Threading.Monitor.TryEnter(this._writeLockObject);
				if (flag)
				{
					object timerLockObject = this._timerLockObject;
					lock (timerLockObject)
					{
						if (this._lazyWriterTimer != null)
						{
							this._lazyWriterTimer.Change(0, -1);
							return true;
						}
					}
				}
				result = false;
			}
			finally
			{
				if (flag)
				{
					global::System.Threading.Monitor.Exit(this._writeLockObject);
				}
			}
			return result;
		}

		// Token: 0x060007CF RID: 1999 RVA: 0x00013DA8 File Offset: 0x00011FA8
		protected virtual void StopLazyWriterThread()
		{
			object timerLockObject = this._timerLockObject;
			lock (timerLockObject)
			{
				global::System.Threading.Timer lazyWriterTimer = this._lazyWriterTimer;
				if (lazyWriterTimer != null)
				{
					this._lazyWriterTimer = null;
					lazyWriterTimer.WaitForDispose(global::System.TimeSpan.FromSeconds(1.0));
				}
			}
		}

		// Token: 0x060007D0 RID: 2000 RVA: 0x00013E08 File Offset: 0x00012008
		protected override void Write(global::NLog.Common.AsyncLogEventInfo logEvent)
		{
			base.PrecalculateVolatileLayouts(logEvent.LogEvent);
			if (this.RequestQueue.Enqueue(logEvent) && this.TimeToSleepBetweenBatches <= 0)
			{
				this.StartInstantWriterTimer();
			}
		}

		// Token: 0x060007D1 RID: 2001 RVA: 0x00013E38 File Offset: 0x00012038
		protected override void WriteAsyncThreadSafe(global::NLog.Common.AsyncLogEventInfo logEvent)
		{
			try
			{
				this.Write(logEvent);
			}
			catch (global::System.Exception exception)
			{
				if (exception.MustBeRethrown())
				{
					throw;
				}
				logEvent.Continuation(exception);
			}
		}

		// Token: 0x060007D2 RID: 2002 RVA: 0x00013E78 File Offset: 0x00012078
		private void ProcessPendingEvents(object state)
		{
			if (this._lazyWriterTimer == null)
			{
				return;
			}
			bool flag = false;
			try
			{
				object writeLockObject = this._writeLockObject;
				lock (writeLockObject)
				{
					if (this.WriteEventsInQueue(this.BatchSize, "Timer") == this.BatchSize)
					{
						flag = true;
					}
					if (flag && this.TimeToSleepBetweenBatches <= 0)
					{
						this.StartInstantWriterTimer();
					}
				}
			}
			catch (global::System.Exception ex)
			{
				flag = false;
				global::NLog.Common.InternalLogger.Error(ex, "AsyncWrapper(Name={0}): Error in lazy writer timer procedure.", new object[]
				{
					base.Name
				});
				if (ex.MustBeRethrownImmediately())
				{
					throw;
				}
			}
			finally
			{
				if (this.TimeToSleepBetweenBatches <= 0)
				{
					if (!flag && this.RequestQueue.RequestCount > 0)
					{
						this.StartLazyWriterTimer();
					}
				}
				else
				{
					this.StartLazyWriterTimer();
				}
			}
		}

		// Token: 0x060007D3 RID: 2003 RVA: 0x00013F58 File Offset: 0x00012158
		private void FlushEventsInQueue(object state)
		{
			try
			{
				global::NLog.Common.AsyncContinuation asyncContinuation = state as global::NLog.Common.AsyncContinuation;
				object writeLockObject = this._writeLockObject;
				lock (writeLockObject)
				{
					this.WriteEventsInQueue(int.MaxValue, "Flush Async");
					if (asyncContinuation != null)
					{
						base.FlushAsync(asyncContinuation);
					}
				}
				if (this.TimeToSleepBetweenBatches <= 0 && this.RequestQueue.RequestCount > 0)
				{
					this.StartLazyWriterTimer();
				}
			}
			catch (global::System.Exception ex)
			{
				global::NLog.Common.InternalLogger.Error(ex, "AsyncWrapper(Name={0}): Error in flush procedure.", new object[]
				{
					base.Name
				});
				if (ex.MustBeRethrownImmediately())
				{
					throw;
				}
			}
		}

		// Token: 0x060007D4 RID: 2004 RVA: 0x00014008 File Offset: 0x00012208
		private int WriteEventsInQueue(int batchSize, string reason)
		{
			if (base.WrappedTarget == null)
			{
				global::NLog.Common.InternalLogger.Error<string>("AsyncWrapper(Name={0}): WrappedTarget is NULL", base.Name);
				return 0;
			}
			int num = 0;
			for (int i = 0; i < this.FullBatchSizeWriteLimit; i++)
			{
				if (!base.OptimizeBufferReuse || batchSize == 2147483647)
				{
					global::NLog.Common.AsyncLogEventInfo[] array = this.RequestQueue.DequeueBatch(batchSize);
					if (array.Length != 0)
					{
						if (reason != null)
						{
							global::NLog.Common.InternalLogger.Trace<string, int, string>("AsyncWrapper(Name={0}): Writing {1} events ({2})", base.Name, array.Length, reason);
						}
						base.WrappedTarget.WriteAsyncLogEvents(array);
					}
					num = array.Length;
				}
				else
				{
					using (global::NLog.Internal.ReusableObjectCreator<global::System.Collections.Generic.IList<global::NLog.Common.AsyncLogEventInfo>>.LockOject lockOject = this._reusableAsyncLogEventList.Allocate())
					{
						global::System.Collections.Generic.IList<global::NLog.Common.AsyncLogEventInfo> result = lockOject.Result;
						this.RequestQueue.DequeueBatch(batchSize, result);
						if (result.Count > 0)
						{
							if (reason != null)
							{
								global::NLog.Common.InternalLogger.Trace<string, int, string>("AsyncWrapper(Name={0}): Writing {1} events ({2})", base.Name, result.Count, reason);
							}
							base.WrappedTarget.WriteAsyncLogEvents(result);
						}
						num = result.Count;
					}
				}
				if (num < batchSize)
				{
					break;
				}
			}
			return num;
		}

		// Token: 0x040001AF RID: 431
		private readonly object _writeLockObject = new object();

		// Token: 0x040001B0 RID: 432
		private readonly object _timerLockObject = new object();

		// Token: 0x040001B1 RID: 433
		private global::System.Threading.Timer _lazyWriterTimer;

		// Token: 0x040001B2 RID: 434
		private readonly global::NLog.Internal.ReusableAsyncLogEventList _reusableAsyncLogEventList = new global::NLog.Internal.ReusableAsyncLogEventList(200);

		// Token: 0x040001B7 RID: 439
		private global::System.Action<object> _flushEventsInQueueDelegate;
	}
}
