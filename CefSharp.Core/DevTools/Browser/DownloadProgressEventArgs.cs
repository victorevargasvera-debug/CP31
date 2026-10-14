using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Browser
{
	// Token: 0x02000339 RID: 825
	[global::System.Runtime.Serialization.DataContract]
	public class DownloadProgressEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x170009D0 RID: 2512
		// (get) Token: 0x0600191C RID: 6428 RVA: 0x0001AEFD File Offset: 0x000190FD
		// (set) Token: 0x0600191D RID: 6429 RVA: 0x0001AF05 File Offset: 0x00019105
		[global::System.Runtime.Serialization.DataMember(Name = "guid", IsRequired = true)]
		public string Guid { get; private set; }

		// Token: 0x170009D1 RID: 2513
		// (get) Token: 0x0600191E RID: 6430 RVA: 0x0001AF0E File Offset: 0x0001910E
		// (set) Token: 0x0600191F RID: 6431 RVA: 0x0001AF16 File Offset: 0x00019116
		[global::System.Runtime.Serialization.DataMember(Name = "totalBytes", IsRequired = true)]
		public double TotalBytes { get; private set; }

		// Token: 0x170009D2 RID: 2514
		// (get) Token: 0x06001920 RID: 6432 RVA: 0x0001AF1F File Offset: 0x0001911F
		// (set) Token: 0x06001921 RID: 6433 RVA: 0x0001AF27 File Offset: 0x00019127
		[global::System.Runtime.Serialization.DataMember(Name = "receivedBytes", IsRequired = true)]
		public double ReceivedBytes { get; private set; }

		// Token: 0x170009D3 RID: 2515
		// (get) Token: 0x06001922 RID: 6434 RVA: 0x0001AF30 File Offset: 0x00019130
		// (set) Token: 0x06001923 RID: 6435 RVA: 0x0001AF4C File Offset: 0x0001914C
		public global::CefSharp.DevTools.Browser.DownloadProgressState State
		{
			get
			{
				return (global::CefSharp.DevTools.Browser.DownloadProgressState)global::CefSharp.DevTools.DevToolsDomainEventArgsBase.StringToEnum(typeof(global::CefSharp.DevTools.Browser.DownloadProgressState), this.state);
			}
			set
			{
				this.state = global::CefSharp.DevTools.DevToolsDomainEventArgsBase.EnumToString(value);
			}
		}

		// Token: 0x170009D4 RID: 2516
		// (get) Token: 0x06001924 RID: 6436 RVA: 0x0001AF5F File Offset: 0x0001915F
		// (set) Token: 0x06001925 RID: 6437 RVA: 0x0001AF67 File Offset: 0x00019167
		[global::System.Runtime.Serialization.DataMember(Name = "state", IsRequired = true)]
		internal string state { get; private set; }
	}
}
