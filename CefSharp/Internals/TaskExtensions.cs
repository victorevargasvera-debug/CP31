using System;
using System.Threading;
using System.Threading.Tasks;

namespace CefSharp.Internals
{
	// Token: 0x020000F3 RID: 243
	public static class TaskExtensions
	{
		// Token: 0x06000735 RID: 1845 RVA: 0x0000BB5C File Offset: 0x00009D5C
		public static global::System.Threading.Tasks.Task<TResult> WithTimeout<TResult>(this global::System.Threading.Tasks.Task<TResult> task, global::System.TimeSpan timeout)
		{
			global::System.Threading.Tasks.TaskCompletionSource<TResult> result = new global::System.Threading.Tasks.TaskCompletionSource<TResult>(task.AsyncState);
			global::System.Threading.Timer timer = new global::System.Threading.Timer(delegate(object state)
			{
				((global::System.Threading.Tasks.TaskCompletionSource<TResult>)state).TrySetCanceled();
			}, result, timeout, global::System.TimeSpan.FromMilliseconds(-1.0));
			task.ContinueWith(delegate(global::System.Threading.Tasks.Task<TResult> t)
			{
				timer.Dispose();
				result.TrySetFromTask(t);
			}, global::System.Threading.Tasks.TaskContinuationOptions.ExecuteSynchronously);
			return result.Task;
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x0000BBE4 File Offset: 0x00009DE4
		public static bool TrySetFromTask<TResult>(this global::System.Threading.Tasks.TaskCompletionSource<TResult> resultSetter, global::System.Threading.Tasks.Task task)
		{
			switch (task.Status)
			{
			case global::System.Threading.Tasks.TaskStatus.RanToCompletion:
				return resultSetter.TrySetResult((task is global::System.Threading.Tasks.Task<TResult>) ? ((global::System.Threading.Tasks.Task<TResult>)task).Result : default(TResult));
			case global::System.Threading.Tasks.TaskStatus.Canceled:
				return resultSetter.TrySetCanceled();
			case global::System.Threading.Tasks.TaskStatus.Faulted:
				return resultSetter.TrySetException(task.Exception.InnerExceptions);
			default:
				throw new global::System.InvalidOperationException("The task was not completed.");
			}
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x0000BC56 File Offset: 0x00009E56
		public static bool TrySetFromTask<TResult>(this global::System.Threading.Tasks.TaskCompletionSource<TResult> resultSetter, global::System.Threading.Tasks.Task<TResult> task)
		{
			return resultSetter.TrySetFromTask(task);
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x0000BC60 File Offset: 0x00009E60
		public static global::System.Threading.Tasks.Task<T> FromResult<T>(T value)
		{
			global::System.Threading.Tasks.TaskCompletionSource<T> taskCompletionSource = new global::System.Threading.Tasks.TaskCompletionSource<T>();
			taskCompletionSource.SetResult(value);
			return taskCompletionSource.Task;
		}

		// Token: 0x06000739 RID: 1849 RVA: 0x0000BC80 File Offset: 0x00009E80
		public static global::System.Threading.Tasks.TaskCompletionSource<TResult> WithTimeout<TResult>(this global::System.Threading.Tasks.TaskCompletionSource<TResult> taskCompletionSource, global::System.TimeSpan timeout)
		{
			return taskCompletionSource.WithTimeout(timeout, null);
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x0000BC8C File Offset: 0x00009E8C
		public static global::System.Threading.Tasks.TaskCompletionSource<TResult> WithTimeout<TResult>(this global::System.Threading.Tasks.TaskCompletionSource<TResult> taskCompletionSource, global::System.TimeSpan timeout, global::System.Action cancelled)
		{
			global::System.Threading.Timer timer = null;
			timer = new global::System.Threading.Timer(delegate(object state)
			{
				timer.Dispose();
				if (taskCompletionSource.Task.Status != global::System.Threading.Tasks.TaskStatus.RanToCompletion)
				{
					taskCompletionSource.TrySetCanceled();
					if (cancelled != null)
					{
						cancelled();
					}
				}
			}, null, timeout, global::System.TimeSpan.FromMilliseconds(-1.0));
			return taskCompletionSource;
		}

		// Token: 0x0600073B RID: 1851 RVA: 0x0000BCE4 File Offset: 0x00009EE4
		public static void TrySetResultAsync<TResult>(this global::System.Threading.Tasks.TaskCompletionSource<TResult> taskCompletionSource, TResult result)
		{
			global::System.Threading.Tasks.Task.Factory.StartNew(delegate()
			{
				taskCompletionSource.TrySetResult(result);
			}, global::System.Threading.CancellationToken.None, global::System.Threading.Tasks.TaskCreationOptions.None, global::System.Threading.Tasks.TaskScheduler.Default);
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x0000BD28 File Offset: 0x00009F28
		public static void TrySetExceptionAsync<TResult>(this global::System.Threading.Tasks.TaskCompletionSource<TResult> taskCompletionSource, global::System.Exception ex)
		{
			global::System.Threading.Tasks.Task.Factory.StartNew(delegate()
			{
				taskCompletionSource.TrySetException(ex);
			}, global::System.Threading.CancellationToken.None, global::System.Threading.Tasks.TaskCreationOptions.None, global::System.Threading.Tasks.TaskScheduler.Default);
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x0000BD6C File Offset: 0x00009F6C
		public static void TrySetCanceledAsync<TResult>(this global::System.Threading.Tasks.TaskCompletionSource<TResult> taskCompletionSource)
		{
			global::System.Threading.Tasks.Task.Factory.StartNew(delegate()
			{
				taskCompletionSource.TrySetCanceled();
			}, global::System.Threading.CancellationToken.None, global::System.Threading.Tasks.TaskCreationOptions.None, global::System.Threading.Tasks.TaskScheduler.Default);
		}
	}
}
