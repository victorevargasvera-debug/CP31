using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CefSharp.Internals
{
	// Token: 0x020000EF RID: 239
	public sealed class PendingTaskRepository<TResult>
	{
		// Token: 0x0600072B RID: 1835 RVA: 0x0000B97C File Offset: 0x00009B7C
		public global::System.Collections.Generic.KeyValuePair<long, global::System.Threading.Tasks.TaskCompletionSource<TResult>> CreatePendingTask(global::System.TimeSpan? timeout = null)
		{
			global::System.Threading.Tasks.TaskCompletionSource<TResult> taskCompletionSource = new global::System.Threading.Tasks.TaskCompletionSource<TResult>();
			long id = global::System.Threading.Interlocked.Increment(ref this.lastId);
			this.pendingTasks.TryAdd(id, taskCompletionSource);
			if (timeout != null)
			{
				taskCompletionSource = taskCompletionSource.WithTimeout(timeout.Value, delegate()
				{
					this.RemovePendingTask(id);
				});
			}
			return new global::System.Collections.Generic.KeyValuePair<long, global::System.Threading.Tasks.TaskCompletionSource<TResult>>(id, taskCompletionSource);
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x0000B9F0 File Offset: 0x00009BF0
		public global::System.Collections.Generic.KeyValuePair<long, global::System.Threading.Tasks.TaskCompletionSource<TResult>> CreateJavascriptCallbackPendingTask(long id, global::System.TimeSpan? timeout = null)
		{
			global::System.Threading.Tasks.TaskCompletionSource<TResult> taskCompletionSource = new global::System.Threading.Tasks.TaskCompletionSource<TResult>();
			this.callbackPendingTasks.TryAdd(id, taskCompletionSource);
			if (timeout != null)
			{
				taskCompletionSource = taskCompletionSource.WithTimeout(timeout.Value, delegate()
				{
					this.RemoveJavascriptCallbackPendingTask(id);
				});
			}
			return new global::System.Collections.Generic.KeyValuePair<long, global::System.Threading.Tasks.TaskCompletionSource<TResult>>(id, taskCompletionSource);
		}

		// Token: 0x0600072D RID: 1837 RVA: 0x0000BA5C File Offset: 0x00009C5C
		public global::System.Threading.Tasks.TaskCompletionSource<TResult> RemovePendingTask(long id)
		{
			global::System.Threading.Tasks.TaskCompletionSource<TResult> result;
			if (this.pendingTasks.TryRemove(id, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x0000BA7C File Offset: 0x00009C7C
		public global::System.Threading.Tasks.TaskCompletionSource<TResult> RemoveJavascriptCallbackPendingTask(long id)
		{
			global::System.Threading.Tasks.TaskCompletionSource<TResult> result;
			if (this.callbackPendingTasks.TryRemove(id, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x040003C4 RID: 964
		private readonly global::System.Collections.Concurrent.ConcurrentDictionary<long, global::System.Threading.Tasks.TaskCompletionSource<TResult>> pendingTasks = new global::System.Collections.Concurrent.ConcurrentDictionary<long, global::System.Threading.Tasks.TaskCompletionSource<TResult>>();

		// Token: 0x040003C5 RID: 965
		private readonly global::System.Collections.Concurrent.ConcurrentDictionary<long, global::System.Threading.Tasks.TaskCompletionSource<TResult>> callbackPendingTasks = new global::System.Collections.Concurrent.ConcurrentDictionary<long, global::System.Threading.Tasks.TaskCompletionSource<TResult>>();

		// Token: 0x040003C6 RID: 966
		private long lastId;
	}
}
