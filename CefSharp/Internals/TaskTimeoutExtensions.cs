using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace CefSharp.Internals
{
	// Token: 0x020000F4 RID: 244
	public static class TaskTimeoutExtensions
	{
		// Token: 0x0600073E RID: 1854 RVA: 0x0000BDA8 File Offset: 0x00009FA8
		public static global::System.Threading.Tasks.Task<TResult> WaitAsync<TResult>(global::System.Threading.Tasks.Task<TResult> task, int millisecondsTimeout)
		{
			return global::CefSharp.Internals.TaskTimeoutExtensions.WaitAsync<TResult>(task, global::System.TimeSpan.FromMilliseconds((double)millisecondsTimeout), default(global::System.Threading.CancellationToken));
		}

		// Token: 0x0600073F RID: 1855 RVA: 0x0000BDCC File Offset: 0x00009FCC
		public static global::System.Threading.Tasks.Task<TResult> WaitAsync<TResult>(global::System.Threading.Tasks.Task<TResult> task, global::System.TimeSpan timeout)
		{
			return global::CefSharp.Internals.TaskTimeoutExtensions.WaitAsync<TResult>(task, timeout, default(global::System.Threading.CancellationToken));
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x0000BDE9 File Offset: 0x00009FE9
		public static global::System.Threading.Tasks.Task<TResult> WaitAsync<TResult>(global::System.Threading.Tasks.Task<TResult> task, global::System.Threading.CancellationToken cancellationToken)
		{
			return global::CefSharp.Internals.TaskTimeoutExtensions.WaitAsync<TResult>(task, global::System.Threading.Timeout.InfiniteTimeSpan, cancellationToken);
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x0000BDF8 File Offset: 0x00009FF8
		public static global::System.Threading.Tasks.Task<TResult> WaitAsync<TResult>(global::System.Threading.Tasks.Task<TResult> task, global::System.TimeSpan timeout, global::System.Threading.CancellationToken cancellationToken)
		{
			global::CefSharp.Internals.TaskTimeoutExtensions.<WaitAsync>d__3<TResult> <WaitAsync>d__;
			<WaitAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<TResult>.Create();
			<WaitAsync>d__.task = task;
			<WaitAsync>d__.timeout = timeout;
			<WaitAsync>d__.cancellationToken = cancellationToken;
			<WaitAsync>d__.<>1__state = -1;
			<WaitAsync>d__.<>t__builder.Start<global::CefSharp.Internals.TaskTimeoutExtensions.<WaitAsync>d__3<TResult>>(ref <WaitAsync>d__);
			return <WaitAsync>d__.<>t__builder.Task;
		}
	}
}
