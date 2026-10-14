using System;

namespace CefSharp
{
	// Token: 0x02000015 RID: 21
	public interface ISetCookieCallback : global::System.IDisposable
	{
		// Token: 0x0600003C RID: 60
		void OnComplete(bool success);

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600003D RID: 61
		bool IsDisposed { get; }
	}
}
