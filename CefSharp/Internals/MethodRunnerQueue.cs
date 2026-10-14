using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CefSharp.Internals.Tasks;
using CefSharp.JavascriptBinding;

namespace CefSharp.Internals
{
	// Token: 0x020000E9 RID: 233
	public sealed class MethodRunnerQueue : global::CefSharp.Internals.IMethodRunnerQueue, global::System.IDisposable
	{
		// Token: 0x14000011 RID: 17
		// (add) Token: 0x0600070F RID: 1807 RVA: 0x0000B568 File Offset: 0x00009768
		// (remove) Token: 0x06000710 RID: 1808 RVA: 0x0000B5A0 File Offset: 0x000097A0
		public event global::System.EventHandler<global::CefSharp.Internals.MethodInvocationCompleteArgs> MethodInvocationComplete;

		// Token: 0x06000711 RID: 1809 RVA: 0x0000B5D5 File Offset: 0x000097D5
		public MethodRunnerQueue(global::CefSharp.Internals.IJavascriptObjectRepositoryInternal repository)
		{
			this.repository = repository;
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x0000B5FB File Offset: 0x000097FB
		public void Dispose()
		{
			this.cancellationTokenSource.Cancel();
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x0000B608 File Offset: 0x00009808
		public void Enqueue(global::CefSharp.Internals.MethodInvocation methodInvocation)
		{
			if (this.cancellationTokenSource.IsCancellationRequested)
			{
				return;
			}
			global::System.Threading.Tasks.Task.Factory.StartNew(delegate()
			{
				if (this.cancellationTokenSource.IsCancellationRequested)
				{
					return;
				}
				global::CefSharp.Internals.MethodInvocationResult result = this.ExecuteMethodInvocation(methodInvocation);
				global::System.EventHandler<global::CefSharp.Internals.MethodInvocationCompleteArgs> methodInvocationComplete = this.MethodInvocationComplete;
				if (!this.cancellationTokenSource.Token.IsCancellationRequested && methodInvocationComplete != null)
				{
					methodInvocationComplete(this, new global::CefSharp.Internals.MethodInvocationCompleteArgs(result));
				}
			}, this.cancellationTokenSource.Token, global::System.Threading.Tasks.TaskCreationOptions.HideScheduler, this.taskScheduler);
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x0000B664 File Offset: 0x00009864
		private global::CefSharp.Internals.MethodInvocationResult ExecuteMethodInvocation(global::CefSharp.Internals.MethodInvocation methodInvocation)
		{
			object obj = null;
			bool flag = false;
			global::CefSharp.JavascriptBinding.IJavascriptNameConverter nameConverter = this.repository.NameConverter;
			string message;
			try
			{
				global::CefSharp.Internals.TryCallMethodResult tryCallMethodResult = this.repository.TryCallMethod(methodInvocation.ObjectId, methodInvocation.MethodName, methodInvocation.Parameters.ToArray());
				flag = tryCallMethodResult.Success;
				obj = tryCallMethodResult.ReturnValue;
				message = tryCallMethodResult.Exception;
				if (flag && obj != null && typeof(global::System.Threading.Tasks.Task).IsAssignableFrom(obj.GetType()))
				{
					global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
					stringBuilder.AppendLine("Your method returned a Task which is not supported by default you must set CefSharpSettings.ConcurrentTaskExecution = true; before creating your first ChromiumWebBrowser instance.");
					stringBuilder.AppendLine("This will likely change to the default at some point in the near future, subscribe to the issue link below to be notified of any changes.");
					stringBuilder.AppendLine("See https://github.com/cefsharp/CefSharp/issues/2758 for more details, please report any issues you have there, make sure you have an example ready that reproduces your problem.");
					flag = false;
					message = stringBuilder.ToString();
				}
			}
			catch (global::System.Exception ex)
			{
				message = ex.Message;
			}
			return new global::CefSharp.Internals.MethodInvocationResult
			{
				BrowserId = methodInvocation.BrowserId,
				CallbackId = methodInvocation.CallbackId,
				FrameId = methodInvocation.FrameId,
				Message = message,
				Result = obj,
				Success = flag,
				NameConverter = nameConverter
			};
		}

		// Token: 0x040003BC RID: 956
		private readonly global::CefSharp.Internals.Tasks.LimitedConcurrencyLevelTaskScheduler taskScheduler = new global::CefSharp.Internals.Tasks.LimitedConcurrencyLevelTaskScheduler(1);

		// Token: 0x040003BD RID: 957
		private readonly global::CefSharp.Internals.IJavascriptObjectRepositoryInternal repository;

		// Token: 0x040003BE RID: 958
		private readonly global::System.Threading.CancellationTokenSource cancellationTokenSource = new global::System.Threading.CancellationTokenSource();
	}
}
