using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace CefSharp.Internals
{
	// Token: 0x020000CF RID: 207
	public sealed class ConcurrentMethodRunnerQueue : global::CefSharp.Internals.IMethodRunnerQueue, global::System.IDisposable
	{
		// Token: 0x1400000C RID: 12
		// (add) Token: 0x0600061D RID: 1565 RVA: 0x00009D14 File Offset: 0x00007F14
		// (remove) Token: 0x0600061E RID: 1566 RVA: 0x00009D4C File Offset: 0x00007F4C
		public event global::System.EventHandler<global::CefSharp.Internals.MethodInvocationCompleteArgs> MethodInvocationComplete;

		// Token: 0x0600061F RID: 1567 RVA: 0x00009D81 File Offset: 0x00007F81
		public ConcurrentMethodRunnerQueue(global::CefSharp.Internals.IJavascriptObjectRepositoryInternal repository)
		{
			this.repository = repository;
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x00009D9B File Offset: 0x00007F9B
		public void Dispose()
		{
			this.MethodInvocationComplete = null;
			this.cancellationTokenSource.Cancel();
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x00009DB0 File Offset: 0x00007FB0
		public void Enqueue(global::CefSharp.Internals.MethodInvocation methodInvocation)
		{
			global::CefSharp.Internals.ConcurrentMethodRunnerQueue.<>c__DisplayClass8_0 CS$<>8__locals1 = new global::CefSharp.Internals.ConcurrentMethodRunnerQueue.<>c__DisplayClass8_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.methodInvocation = methodInvocation;
			if (this.cancellationTokenSource.IsCancellationRequested)
			{
				return;
			}
			global::System.Threading.Tasks.Task.Run(delegate()
			{
				global::CefSharp.Internals.ConcurrentMethodRunnerQueue.<>c__DisplayClass8_0.<<Enqueue>b__0>d <<Enqueue>b__0>d;
				<<Enqueue>b__0>d.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
				<<Enqueue>b__0>d.<>4__this = CS$<>8__locals1;
				<<Enqueue>b__0>d.<>1__state = -1;
				<<Enqueue>b__0>d.<>t__builder.Start<global::CefSharp.Internals.ConcurrentMethodRunnerQueue.<>c__DisplayClass8_0.<<Enqueue>b__0>d>(ref <<Enqueue>b__0>d);
				return <<Enqueue>b__0>d.<>t__builder.Task;
			}, this.cancellationTokenSource.Token);
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x00009DFC File Offset: 0x00007FFC
		private global::System.Threading.Tasks.Task<global::CefSharp.Internals.MethodInvocationResult> ExecuteMethodInvocation(global::CefSharp.Internals.MethodInvocation methodInvocation)
		{
			global::CefSharp.Internals.ConcurrentMethodRunnerQueue.<ExecuteMethodInvocation>d__9 <ExecuteMethodInvocation>d__;
			<ExecuteMethodInvocation>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<global::CefSharp.Internals.MethodInvocationResult>.Create();
			<ExecuteMethodInvocation>d__.<>4__this = this;
			<ExecuteMethodInvocation>d__.methodInvocation = methodInvocation;
			<ExecuteMethodInvocation>d__.<>1__state = -1;
			<ExecuteMethodInvocation>d__.<>t__builder.Start<global::CefSharp.Internals.ConcurrentMethodRunnerQueue.<ExecuteMethodInvocation>d__9>(ref <ExecuteMethodInvocation>d__);
			return <ExecuteMethodInvocation>d__.<>t__builder.Task;
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x00009E47 File Offset: 0x00008047
		private void OnMethodInvocationComplete(global::CefSharp.Internals.MethodInvocationResult e, global::System.Threading.CancellationToken token)
		{
			if (!token.IsCancellationRequested)
			{
				global::System.EventHandler<global::CefSharp.Internals.MethodInvocationCompleteArgs> methodInvocationComplete = this.MethodInvocationComplete;
				if (methodInvocationComplete == null)
				{
					return;
				}
				methodInvocationComplete(this, new global::CefSharp.Internals.MethodInvocationCompleteArgs(e));
			}
		}

		// Token: 0x04000377 RID: 887
		private static readonly global::System.Type VoidTaskResultType = global::System.Type.GetType("System.Threading.Tasks.VoidTaskResult");

		// Token: 0x04000378 RID: 888
		private readonly global::CefSharp.Internals.IJavascriptObjectRepositoryInternal repository;

		// Token: 0x04000379 RID: 889
		private readonly global::System.Threading.CancellationTokenSource cancellationTokenSource = new global::System.Threading.CancellationTokenSource();
	}
}
