using System;

namespace CefSharp
{
	// Token: 0x02000011 RID: 17
	public interface IRequestCallback : global::System.IDisposable
	{
		// Token: 0x06000032 RID: 50
		void Continue(bool allow);

		// Token: 0x06000033 RID: 51
		void Cancel();

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000034 RID: 52
		bool IsDisposed { get; }
	}
}
