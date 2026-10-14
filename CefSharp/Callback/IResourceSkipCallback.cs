using System;

namespace CefSharp.Callback
{
	// Token: 0x02000126 RID: 294
	public interface IResourceSkipCallback : global::System.IDisposable
	{
		// Token: 0x0600085E RID: 2142
		void Continue(long bytesSkipped);

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x0600085F RID: 2143
		bool IsDisposed { get; }
	}
}
