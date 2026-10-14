using System;

namespace CefSharp.Callback
{
	// Token: 0x02000125 RID: 293
	public interface IResourceReadCallback : global::System.IDisposable
	{
		// Token: 0x0600085C RID: 2140
		void Continue(int bytesRead);

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x0600085D RID: 2141
		bool IsDisposed { get; }
	}
}
