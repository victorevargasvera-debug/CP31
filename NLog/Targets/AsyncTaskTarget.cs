using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using NLog.Common;

namespace NLog.Targets
{
	// Token: 0x02000027 RID: 39
	public abstract class AsyncTaskTarget : global::NLog.Targets.TargetWithContext
	{
		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000499 RID: 1177 RVA: 0x00009131 File Offset: 0x00007331
		// (set) Token: 0x0600049A RID: 1178 RVA: 0x00009139 File Offset: 0x00007339
		[global::System.ComponentModel.DefaultValue(150)]
		public int TaskTimeoutSeconds { get; set; }

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x0600049B RID: 1179 RVA: 0x00009142 File Offset: 0x00007342
		protected virtual global::System.Threading.Tasks.TaskScheduler TaskScheduler
		{
			get
			{
				return global::System.Threading.Tasks.TaskScheduler.Default;
			}
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x0000914C File Offset: 0x0000734C
		protected AsyncTaskTarget()
		{
			this.TaskTimeoutSeconds = 150;
			this._taskStartNext = delegate()
			{
				this.TaskStartNext(null);
			};
			this._taskCompletion = new global::System.Action<global::System.Threading.Tasks.Task, object>(this.TaskCompletion);
			this._taskCancelledToken = new global::System.Action(this.TaskCancelledToken);
			this._taskTimeoutTimer = new global::System.Threading.Timer(new global::System.Threading.TimerCallback(this.TaskTimeout), null, -1, -1);
			this._cancelTokenSource = new global::System.Threading.CancellationTokenSource();
			this._cancelTokenSource.Token.Register(this._taskCancelledToken);
			this._requestQueue = new global::System.Collections.Generic.Queue<global::NLog.Common.AsyncLogEventInfo>(10000);
		}

		// Token: 0x0600049D RID: 1181
		protected abstract global::System.Threading.Tasks.Task WriteAsyncTask(global::NLog.LogEventInfo logEvent, global::System.Threading.CancellationToken cancellationToken);

		// Token: 0x0600049E RID: 1182 RVA: 0x000091F0 File Offset: 0x000073F0
		protected override void Write(global::NLog.Common.AsyncLogEventInfo logEvent)
		{
			if (this._cancelTokenSource.IsCancellationRequested)
			{
				logEvent.Continuation(null);
				return;
			}
			base.PrecalculateVolatileLayouts(logEvent.LogEvent);
			this._requestQueue.Enqueue(logEvent);
			if (this._previousTask == null)
			{
				this._previousTask = global::System.Threading.Tasks.Task.Factory.StartNew(this._taskStartNext, this._cancelTokenSource.Token, global::System.Threading.Tasks.TaskCreationOptions.None, this.TaskScheduler);
			}
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x00009264 File Offset: 0x00007464
		protected override void FlushAsync(global::NLog.Common.AsyncContinuation asyncContinuation)
		{
			if (this._previousTask == null)
			{
				global::NLog.Common.InternalLogger.Debug<string>("{0} Flushing Nothing", base.Name);
				asyncContinuation(null);
				return;
			}
			global::NLog.Common.InternalLogger.Debug<string, int>("{0} Flushing {1} items", base.Name, this._requestQueue.Count + 1);
			this._requestQueue.Enqueue(new global::NLog.Common.AsyncLogEventInfo(null, asyncContinuation));
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x000092C0 File Offset: 0x000074C0
		protected override void CloseTarget()
		{
			this._taskTimeoutTimer.Change(-1, -1);
			this._cancelTokenSource.Cancel();
			this._requestQueue.Clear();
			this._previousTask = null;
			base.CloseTarget();
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x000092F3 File Offset: 0x000074F3
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
			if (disposing)
			{
				this._cancelTokenSource.Dispose();
				this._taskTimeoutTimer.WaitForDispose(global::System.TimeSpan.Zero);
			}
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x0000931C File Offset: 0x0000751C
		private void TaskStartNext(global::System.Threading.Tasks.Task previousTask)
		{
			global::NLog.Common.AsyncLogEventInfo logEvent;
			do
			{
				object syncRoot = base.SyncRoot;
				lock (syncRoot)
				{
					if (!base.IsInitialized)
					{
						break;
					}
					if (previousTask != null && previousTask != this._previousTask)
					{
						break;
					}
					if (this._requestQueue.Count == 0)
					{
						this._previousTask = null;
						break;
					}
					logEvent = this._requestQueue.Dequeue();
				}
			}
			while (!this.TaskCreation(logEvent));
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x0000939C File Offset: 0x0000759C
		private bool TaskCreation(global::NLog.Common.AsyncLogEventInfo logEvent)
		{
			try
			{
				if (this._cancelTokenSource.IsCancellationRequested)
				{
					logEvent.Continuation(null);
					return false;
				}
				if (logEvent.LogEvent == null)
				{
					global::NLog.Common.InternalLogger.Debug<string>("{0} Flush Completed", base.Name);
					logEvent.Continuation(null);
					return false;
				}
				global::System.Threading.Tasks.Task task = this.WriteAsyncTask(logEvent.LogEvent, this._cancelTokenSource.Token);
				if (task != null)
				{
					object syncRoot = base.SyncRoot;
					lock (syncRoot)
					{
						this._previousTask = task;
						if (this.TaskTimeoutSeconds > 0)
						{
							this._taskTimeoutTimer.Change(this.TaskTimeoutSeconds * 1000, -1);
						}
						this._previousTask.ContinueWith(this._taskCompletion, logEvent.Continuation);
						if (this._previousTask.Status == global::System.Threading.Tasks.TaskStatus.Created)
						{
							this._previousTask.Start(this.TaskScheduler);
						}
					}
					return true;
				}
				global::NLog.Common.InternalLogger.Debug<string>("{0} WriteAsyncTask returned null", base.Name);
			}
			catch (global::System.Exception ex)
			{
				try
				{
					global::NLog.Common.InternalLogger.Error(ex, "{0} WriteAsyncTask failed on creation", new object[]
					{
						base.Name
					});
					logEvent.Continuation(ex);
				}
				catch
				{
				}
			}
			return false;
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x0000952C File Offset: 0x0000772C
		private void TaskCompletion(global::System.Threading.Tasks.Task completedTask, object continuation)
		{
			try
			{
				if (completedTask == this._previousTask)
				{
					if (this.TaskTimeoutSeconds > 0)
					{
						this._taskTimeoutTimer.Change(-1, -1);
					}
				}
				else if (!base.IsInitialized)
				{
					return;
				}
				if (completedTask.IsCanceled)
				{
					if (completedTask.Exception != null)
					{
						global::NLog.Common.InternalLogger.Warn(completedTask.Exception, "{0} WriteAsyncTask was cancelled", new object[]
						{
							base.Name
						});
					}
					else
					{
						global::NLog.Common.InternalLogger.Info<string>("{0} WriteAsyncTask was cancelled", base.Name);
					}
				}
				else if (completedTask.Exception != null)
				{
					global::NLog.Common.InternalLogger.Warn(completedTask.Exception, "{0} WriteAsyncTask failed on completion", new object[]
					{
						base.Name
					});
				}
				((global::NLog.Common.AsyncContinuation)continuation)(completedTask.Exception);
			}
			finally
			{
				this.TaskStartNext(completedTask);
			}
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x00009600 File Offset: 0x00007800
		private void TaskTimeout(object state)
		{
			try
			{
				if (base.IsInitialized)
				{
					global::NLog.Common.InternalLogger.Warn<string>("{0} WriteAsyncTask had timeout. Task will be cancelled.", base.Name);
					global::System.Threading.Tasks.Task task = this._previousTask;
					try
					{
						object syncRoot = base.SyncRoot;
						lock (syncRoot)
						{
							if (task != null && task == this._previousTask)
							{
								this._previousTask = null;
								this._cancelTokenSource.Cancel();
							}
							else
							{
								task = null;
							}
						}
						if (task != null && task.Status != global::System.Threading.Tasks.TaskStatus.Canceled && task.Status != global::System.Threading.Tasks.TaskStatus.Faulted && task.Status != global::System.Threading.Tasks.TaskStatus.RanToCompletion && !task.Wait(100))
						{
							global::NLog.Common.InternalLogger.Debug<string, global::System.Threading.Tasks.TaskStatus>("{0} WriteAsyncTask had timeout. Task did not cancel properly: {1}.", base.Name, task.Status);
						}
					}
					catch (global::System.Exception ex)
					{
						global::NLog.Common.InternalLogger.Debug(ex, "{0} WriteAsyncTask had timeout. Task failed to cancel properly.", new object[]
						{
							base.Name
						});
					}
					if (task != null)
					{
						this.TaskStartNext(null);
					}
				}
			}
			catch (global::System.Exception ex2)
			{
				global::NLog.Common.InternalLogger.Error(ex2, "{0} WriteAsyncTask failed on timeout", new object[]
				{
					base.Name
				});
			}
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x0000971C File Offset: 0x0000791C
		private void TaskCancelledToken()
		{
			object syncRoot = base.SyncRoot;
			lock (syncRoot)
			{
				if (base.IsInitialized)
				{
					this._cancelTokenSource = new global::System.Threading.CancellationTokenSource();
					this._cancelTokenSource.Token.Register(this._taskCancelledToken);
				}
			}
		}

		// Token: 0x04000055 RID: 85
		private readonly global::System.Threading.Timer _taskTimeoutTimer;

		// Token: 0x04000056 RID: 86
		private global::System.Threading.CancellationTokenSource _cancelTokenSource;

		// Token: 0x04000057 RID: 87
		private readonly global::System.Collections.Generic.Queue<global::NLog.Common.AsyncLogEventInfo> _requestQueue;

		// Token: 0x04000058 RID: 88
		private readonly global::System.Action _taskStartNext;

		// Token: 0x04000059 RID: 89
		private readonly global::System.Action _taskCancelledToken;

		// Token: 0x0400005A RID: 90
		private readonly global::System.Action<global::System.Threading.Tasks.Task, object> _taskCompletion;

		// Token: 0x0400005B RID: 91
		private global::System.Threading.Tasks.Task _previousTask;
	}
}
