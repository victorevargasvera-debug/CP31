using System;

namespace CefSharp
{
	// Token: 0x02000082 RID: 130
	public interface IUrlRequest : global::System.IDisposable
	{
		// Token: 0x17000111 RID: 273
		// (get) Token: 0x06000341 RID: 833
		bool ResponseWasCached { get; }

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x06000342 RID: 834
		global::CefSharp.IResponse Response { get; }

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x06000343 RID: 835
		global::CefSharp.UrlRequestStatus RequestStatus { get; }
	}
}
