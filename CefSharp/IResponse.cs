using System;
using System.Collections.Specialized;

namespace CefSharp
{
	// Token: 0x0200007E RID: 126
	public interface IResponse : global::System.IDisposable
	{
		// Token: 0x17000108 RID: 264
		// (get) Token: 0x0600032D RID: 813
		// (set) Token: 0x0600032E RID: 814
		string Charset { get; set; }

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x0600032F RID: 815
		// (set) Token: 0x06000330 RID: 816
		string MimeType { get; set; }

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06000331 RID: 817
		// (set) Token: 0x06000332 RID: 818
		global::System.Collections.Specialized.NameValueCollection Headers { get; set; }

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x06000333 RID: 819
		bool IsReadOnly { get; }

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x06000334 RID: 820
		// (set) Token: 0x06000335 RID: 821
		global::CefSharp.CefErrorCode ErrorCode { get; set; }

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x06000336 RID: 822
		// (set) Token: 0x06000337 RID: 823
		int StatusCode { get; set; }

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000338 RID: 824
		// (set) Token: 0x06000339 RID: 825
		string StatusText { get; set; }

		// Token: 0x0600033A RID: 826
		string GetHeaderByName(string name);

		// Token: 0x0600033B RID: 827
		void SetHeaderByName(string name, string value, bool overwrite);
	}
}
