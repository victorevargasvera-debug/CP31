using System;
using System.Collections.Specialized;
using System.ComponentModel;

namespace CefSharp
{
	// Token: 0x0200007B RID: 123
	public interface IRequest : global::System.IDisposable
	{
		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x060002FE RID: 766
		// (set) Token: 0x060002FF RID: 767
		global::CefSharp.UrlRequestFlags Flags { get; set; }

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000300 RID: 768
		// (set) Token: 0x06000301 RID: 769
		string Url { get; set; }

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000302 RID: 770
		ulong Identifier { get; }

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000303 RID: 771
		// (set) Token: 0x06000304 RID: 772
		string Method { get; set; }

		// Token: 0x06000305 RID: 773
		void SetReferrer(string referrerUrl, global::CefSharp.ReferrerPolicy policy);

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000306 RID: 774
		string ReferrerUrl { get; }

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000307 RID: 775
		global::CefSharp.ResourceType ResourceType { get; }

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000308 RID: 776
		global::CefSharp.ReferrerPolicy ReferrerPolicy { get; }

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000309 RID: 777
		// (set) Token: 0x0600030A RID: 778
		global::System.Collections.Specialized.NameValueCollection Headers { get; set; }

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x0600030B RID: 779
		// (set) Token: 0x0600030C RID: 780
		global::CefSharp.IPostData PostData { get; set; }

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x0600030D RID: 781
		global::CefSharp.TransitionType TransitionType { get; }

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x0600030E RID: 782
		bool IsDisposed { get; }

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x0600030F RID: 783
		bool IsReadOnly { get; }

		// Token: 0x06000310 RID: 784
		void InitializePostData();

		// Token: 0x06000311 RID: 785
		string GetHeaderByName(string name);

		// Token: 0x06000312 RID: 786
		void SetHeaderByName(string name, string value, bool overwrite);

		// Token: 0x06000313 RID: 787
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		global::CefSharp.IRequest UnWrap();
	}
}
