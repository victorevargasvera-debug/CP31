using System;
using System.Collections.Generic;

namespace CefSharp
{
	// Token: 0x02000068 RID: 104
	public interface IBrowser : global::System.IDisposable
	{
		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000185 RID: 389
		bool IsValid { get; }

		// Token: 0x06000186 RID: 390
		global::CefSharp.IBrowserHost GetHost();

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000187 RID: 391
		bool CanGoBack { get; }

		// Token: 0x06000188 RID: 392
		void GoBack();

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000189 RID: 393
		bool CanGoForward { get; }

		// Token: 0x0600018A RID: 394
		void GoForward();

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x0600018B RID: 395
		bool IsLoading { get; }

		// Token: 0x0600018C RID: 396
		void CloseBrowser(bool forceClose);

		// Token: 0x0600018D RID: 397
		void Reload(bool ignoreCache = false);

		// Token: 0x0600018E RID: 398
		void StopLoad();

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x0600018F RID: 399
		int Identifier { get; }

		// Token: 0x06000190 RID: 400
		bool IsSame(global::CefSharp.IBrowser that);

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000191 RID: 401
		bool IsPopup { get; }

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000192 RID: 402
		bool HasDocument { get; }

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000193 RID: 403
		global::CefSharp.IFrame MainFrame { get; }

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000194 RID: 404
		global::CefSharp.IFrame FocusedFrame { get; }

		// Token: 0x06000195 RID: 405
		global::CefSharp.IFrame GetFrame(long identifier);

		// Token: 0x06000196 RID: 406
		global::CefSharp.IFrame GetFrame(string name);

		// Token: 0x06000197 RID: 407
		int GetFrameCount();

		// Token: 0x06000198 RID: 408
		global::System.Collections.Generic.List<long> GetFrameIdentifiers();

		// Token: 0x06000199 RID: 409
		global::System.Collections.Generic.List<string> GetFrameNames();

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x0600019A RID: 410
		bool IsDisposed { get; }
	}
}
