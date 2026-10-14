using System;

namespace CefSharp.Callback
{
	// Token: 0x02000128 RID: 296
	public sealed class NoOpCompletionCallback : global::CefSharp.ICompletionCallback, global::System.IDisposable
	{
		// Token: 0x06000861 RID: 2145 RVA: 0x0000CFD2 File Offset: 0x0000B1D2
		void global::CefSharp.ICompletionCallback.OnComplete()
		{
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x06000862 RID: 2146 RVA: 0x0000CFD4 File Offset: 0x0000B1D4
		bool global::CefSharp.ICompletionCallback.IsDisposed
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x0000CFD7 File Offset: 0x0000B1D7
		void global::System.IDisposable.Dispose()
		{
		}
	}
}
