using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Preload
{
	// Token: 0x020000AD RID: 173
	[global::System.Runtime.Serialization.DataContract]
	public class PrerenderStatusUpdatedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x1700023C RID: 572
		// (get) Token: 0x060005EF RID: 1519 RVA: 0x00008B66 File Offset: 0x00006D66
		// (set) Token: 0x060005F0 RID: 1520 RVA: 0x00008B6E File Offset: 0x00006D6E
		[global::System.Runtime.Serialization.DataMember(Name = "key", IsRequired = true)]
		public global::CefSharp.DevTools.Preload.PreloadingAttemptKey Key { get; private set; }

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x060005F1 RID: 1521 RVA: 0x00008B77 File Offset: 0x00006D77
		// (set) Token: 0x060005F2 RID: 1522 RVA: 0x00008B7F File Offset: 0x00006D7F
		[global::System.Runtime.Serialization.DataMember(Name = "initiatingFrameId", IsRequired = true)]
		public string InitiatingFrameId { get; private set; }

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x060005F3 RID: 1523 RVA: 0x00008B88 File Offset: 0x00006D88
		// (set) Token: 0x060005F4 RID: 1524 RVA: 0x00008B90 File Offset: 0x00006D90
		[global::System.Runtime.Serialization.DataMember(Name = "prerenderingUrl", IsRequired = true)]
		public string PrerenderingUrl { get; private set; }

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x060005F5 RID: 1525 RVA: 0x00008B99 File Offset: 0x00006D99
		// (set) Token: 0x060005F6 RID: 1526 RVA: 0x00008BB5 File Offset: 0x00006DB5
		public global::CefSharp.DevTools.Preload.PreloadingStatus Status
		{
			get
			{
				return (global::CefSharp.DevTools.Preload.PreloadingStatus)global::CefSharp.DevTools.DevToolsDomainEventArgsBase.StringToEnum(typeof(global::CefSharp.DevTools.Preload.PreloadingStatus), this.status);
			}
			set
			{
				this.status = global::CefSharp.DevTools.DevToolsDomainEventArgsBase.EnumToString(value);
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x060005F7 RID: 1527 RVA: 0x00008BC8 File Offset: 0x00006DC8
		// (set) Token: 0x060005F8 RID: 1528 RVA: 0x00008BD0 File Offset: 0x00006DD0
		[global::System.Runtime.Serialization.DataMember(Name = "status", IsRequired = true)]
		internal string status { get; private set; }
	}
}
