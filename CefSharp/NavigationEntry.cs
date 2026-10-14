using System;

namespace CefSharp
{
	// Token: 0x0200008D RID: 141
	public sealed class NavigationEntry
	{
		// Token: 0x17000142 RID: 322
		// (get) Token: 0x060003B9 RID: 953 RVA: 0x000037DC File Offset: 0x000019DC
		// (set) Token: 0x060003BA RID: 954 RVA: 0x000037E4 File Offset: 0x000019E4
		public global::System.DateTime CompletionTime { get; private set; }

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x060003BB RID: 955 RVA: 0x000037ED File Offset: 0x000019ED
		// (set) Token: 0x060003BC RID: 956 RVA: 0x000037F5 File Offset: 0x000019F5
		public string DisplayUrl { get; private set; }

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x060003BD RID: 957 RVA: 0x000037FE File Offset: 0x000019FE
		// (set) Token: 0x060003BE RID: 958 RVA: 0x00003806 File Offset: 0x00001A06
		public int HttpStatusCode { get; private set; }

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x060003BF RID: 959 RVA: 0x0000380F File Offset: 0x00001A0F
		// (set) Token: 0x060003C0 RID: 960 RVA: 0x00003817 File Offset: 0x00001A17
		public string OriginalUrl { get; private set; }

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x060003C1 RID: 961 RVA: 0x00003820 File Offset: 0x00001A20
		// (set) Token: 0x060003C2 RID: 962 RVA: 0x00003828 File Offset: 0x00001A28
		public string Title { get; private set; }

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x060003C3 RID: 963 RVA: 0x00003831 File Offset: 0x00001A31
		// (set) Token: 0x060003C4 RID: 964 RVA: 0x00003839 File Offset: 0x00001A39
		public global::CefSharp.TransitionType TransitionType { get; private set; }

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x060003C5 RID: 965 RVA: 0x00003842 File Offset: 0x00001A42
		// (set) Token: 0x060003C6 RID: 966 RVA: 0x0000384A File Offset: 0x00001A4A
		public string Url { get; private set; }

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x060003C7 RID: 967 RVA: 0x00003853 File Offset: 0x00001A53
		// (set) Token: 0x060003C8 RID: 968 RVA: 0x0000385B File Offset: 0x00001A5B
		public bool HasPostData { get; private set; }

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x060003C9 RID: 969 RVA: 0x00003864 File Offset: 0x00001A64
		// (set) Token: 0x060003CA RID: 970 RVA: 0x0000386C File Offset: 0x00001A6C
		public bool IsValid { get; private set; }

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x060003CB RID: 971 RVA: 0x00003875 File Offset: 0x00001A75
		// (set) Token: 0x060003CC RID: 972 RVA: 0x0000387D File Offset: 0x00001A7D
		public bool IsCurrent { get; private set; }

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x060003CD RID: 973 RVA: 0x00003886 File Offset: 0x00001A86
		// (set) Token: 0x060003CE RID: 974 RVA: 0x0000388E File Offset: 0x00001A8E
		public global::CefSharp.SslStatus SslStatus { get; private set; }

		// Token: 0x060003CF RID: 975 RVA: 0x00003898 File Offset: 0x00001A98
		public NavigationEntry(bool isCurrent, global::System.DateTime completionTime, string displayUrl, int httpStatusCode, string originalUrl, string title, global::CefSharp.TransitionType transitionType, string url, bool hasPostData, bool isValid, global::CefSharp.SslStatus sslStatus)
		{
			this.IsCurrent = isCurrent;
			this.CompletionTime = completionTime;
			this.DisplayUrl = displayUrl;
			this.HttpStatusCode = httpStatusCode;
			this.OriginalUrl = originalUrl;
			this.Title = title;
			this.TransitionType = transitionType;
			this.Url = url;
			this.HasPostData = hasPostData;
			this.IsValid = isValid;
			this.SslStatus = sslStatus;
		}
	}
}
