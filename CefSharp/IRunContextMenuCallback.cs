using System;

namespace CefSharp
{
	// Token: 0x02000013 RID: 19
	public interface IRunContextMenuCallback : global::System.IDisposable
	{
		// Token: 0x06000037 RID: 55
		void Continue(global::CefSharp.CefMenuCommand commandId, global::CefSharp.CefEventFlags eventFlags);

		// Token: 0x06000038 RID: 56
		void Cancel();

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000039 RID: 57
		bool IsDisposed { get; }
	}
}
