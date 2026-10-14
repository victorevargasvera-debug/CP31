using System;
using System.IO;
using CefSharp.Callback;

namespace CefSharp
{
	// Token: 0x02000065 RID: 101
	public interface IResourceHandler : global::System.IDisposable
	{
		// Token: 0x06000174 RID: 372
		bool Open(global::CefSharp.IRequest request, out bool handleRequest, global::CefSharp.ICallback callback);

		// Token: 0x06000175 RID: 373
		[global::System.Obsolete("This method is deprecated and will be removed in the next version. Use Open instead.")]
		bool ProcessRequest(global::CefSharp.IRequest request, global::CefSharp.ICallback callback);

		// Token: 0x06000176 RID: 374
		void GetResponseHeaders(global::CefSharp.IResponse response, out long responseLength, out string redirectUrl);

		// Token: 0x06000177 RID: 375
		bool Skip(long bytesToSkip, out long bytesSkipped, global::CefSharp.Callback.IResourceSkipCallback callback);

		// Token: 0x06000178 RID: 376
		bool Read(global::System.IO.Stream dataOut, out int bytesRead, global::CefSharp.Callback.IResourceReadCallback callback);

		// Token: 0x06000179 RID: 377
		[global::System.Obsolete("This method is deprecated and will be removed in the next version. Use Skip and Read instead.")]
		bool ReadResponse(global::System.IO.Stream dataOut, out int bytesRead, global::CefSharp.ICallback callback);

		// Token: 0x0600017A RID: 378
		void Cancel();
	}
}
