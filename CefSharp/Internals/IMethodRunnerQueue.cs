using System;

namespace CefSharp.Internals
{
	// Token: 0x020000D9 RID: 217
	public interface IMethodRunnerQueue : global::System.IDisposable
	{
		// Token: 0x1400000D RID: 13
		// (add) Token: 0x06000653 RID: 1619
		// (remove) Token: 0x06000654 RID: 1620
		event global::System.EventHandler<global::CefSharp.Internals.MethodInvocationCompleteArgs> MethodInvocationComplete;

		// Token: 0x06000655 RID: 1621
		void Enqueue(global::CefSharp.Internals.MethodInvocation methodInvocation);
	}
}
