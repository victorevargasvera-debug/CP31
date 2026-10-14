using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CefSharp.Internals.Tasks
{
	// Token: 0x020000FD RID: 253
	internal sealed class LimitedConcurrencyLevelTaskScheduler : global::System.Threading.Tasks.TaskScheduler
	{
		// Token: 0x0600076E RID: 1902 RVA: 0x0000C448 File Offset: 0x0000A648
		public LimitedConcurrencyLevelTaskScheduler(int maxDegreeOfParallelism)
		{
			if (maxDegreeOfParallelism < 1)
			{
				throw new global::System.ArgumentOutOfRangeException("maxDegreeOfParallelism");
			}
			this._maxDegreeOfParallelism = maxDegreeOfParallelism;
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x0000C474 File Offset: 0x0000A674
		protected sealed override void QueueTask(global::System.Threading.Tasks.Task task)
		{
			global::System.Collections.Generic.LinkedList<global::System.Threading.Tasks.Task> tasks = this._tasks;
			lock (tasks)
			{
				this._tasks.AddLast(task);
				if (this._delegatesQueuedOrRunning < this._maxDegreeOfParallelism)
				{
					this._delegatesQueuedOrRunning++;
					this.NotifyThreadPoolOfPendingWork();
				}
			}
		}

		// Token: 0x06000770 RID: 1904 RVA: 0x0000C4E0 File Offset: 0x0000A6E0
		private void NotifyThreadPoolOfPendingWork()
		{
			global::System.Threading.ThreadPool.UnsafeQueueUserWorkItem(delegate(object _)
			{
				global::CefSharp.Internals.Tasks.LimitedConcurrencyLevelTaskScheduler._currentThreadIsProcessingItems = true;
				try
				{
					for (;;)
					{
						global::System.Collections.Generic.LinkedList<global::System.Threading.Tasks.Task> tasks = this._tasks;
						global::System.Threading.Tasks.Task value;
						lock (tasks)
						{
							if (this._tasks.Count == 0)
							{
								this._delegatesQueuedOrRunning--;
								break;
							}
							value = this._tasks.First.Value;
							this._tasks.RemoveFirst();
						}
						base.TryExecuteTask(value);
					}
				}
				finally
				{
					global::CefSharp.Internals.Tasks.LimitedConcurrencyLevelTaskScheduler._currentThreadIsProcessingItems = false;
				}
			}, null);
		}

		// Token: 0x06000771 RID: 1905 RVA: 0x0000C4F5 File Offset: 0x0000A6F5
		protected sealed override bool TryExecuteTaskInline(global::System.Threading.Tasks.Task task, bool taskWasPreviouslyQueued)
		{
			if (!global::CefSharp.Internals.Tasks.LimitedConcurrencyLevelTaskScheduler._currentThreadIsProcessingItems)
			{
				return false;
			}
			if (taskWasPreviouslyQueued)
			{
				this.TryDequeue(task);
			}
			return base.TryExecuteTask(task);
		}

		// Token: 0x06000772 RID: 1906 RVA: 0x0000C514 File Offset: 0x0000A714
		protected sealed override bool TryDequeue(global::System.Threading.Tasks.Task task)
		{
			global::System.Collections.Generic.LinkedList<global::System.Threading.Tasks.Task> tasks = this._tasks;
			bool result;
			lock (tasks)
			{
				result = this._tasks.Remove(task);
			}
			return result;
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x06000773 RID: 1907 RVA: 0x0000C55C File Offset: 0x0000A75C
		public sealed override int MaximumConcurrencyLevel
		{
			get
			{
				return this._maxDegreeOfParallelism;
			}
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x0000C564 File Offset: 0x0000A764
		protected sealed override global::System.Collections.Generic.IEnumerable<global::System.Threading.Tasks.Task> GetScheduledTasks()
		{
			bool flag = false;
			global::System.Collections.Generic.IEnumerable<global::System.Threading.Tasks.Task> result;
			try
			{
				global::System.Threading.Monitor.TryEnter(this._tasks, ref flag);
				if (!flag)
				{
					throw new global::System.NotSupportedException();
				}
				result = this._tasks.ToArray<global::System.Threading.Tasks.Task>();
			}
			finally
			{
				if (flag)
				{
					global::System.Threading.Monitor.Exit(this._tasks);
				}
			}
			return result;
		}

		// Token: 0x040003D6 RID: 982
		[global::System.ThreadStatic]
		private static bool _currentThreadIsProcessingItems;

		// Token: 0x040003D7 RID: 983
		private readonly global::System.Collections.Generic.LinkedList<global::System.Threading.Tasks.Task> _tasks = new global::System.Collections.Generic.LinkedList<global::System.Threading.Tasks.Task>();

		// Token: 0x040003D8 RID: 984
		private readonly int _maxDegreeOfParallelism;

		// Token: 0x040003D9 RID: 985
		private int _delegatesQueuedOrRunning;
	}
}
