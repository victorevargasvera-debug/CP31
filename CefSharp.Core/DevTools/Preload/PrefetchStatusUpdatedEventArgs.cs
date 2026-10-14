using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Preload
{
	// Token: 0x020000AC RID: 172
	[global::System.Runtime.Serialization.DataContract]
	public class PrefetchStatusUpdatedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x17000237 RID: 567
		// (get) Token: 0x060005E4 RID: 1508 RVA: 0x00008AEB File Offset: 0x00006CEB
		// (set) Token: 0x060005E5 RID: 1509 RVA: 0x00008AF3 File Offset: 0x00006CF3
		[global::System.Runtime.Serialization.DataMember(Name = "key", IsRequired = true)]
		public global::CefSharp.DevTools.Preload.PreloadingAttemptKey Key { get; private set; }

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x060005E6 RID: 1510 RVA: 0x00008AFC File Offset: 0x00006CFC
		// (set) Token: 0x060005E7 RID: 1511 RVA: 0x00008B04 File Offset: 0x00006D04
		[global::System.Runtime.Serialization.DataMember(Name = "initiatingFrameId", IsRequired = true)]
		public string InitiatingFrameId { get; private set; }

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x060005E8 RID: 1512 RVA: 0x00008B0D File Offset: 0x00006D0D
		// (set) Token: 0x060005E9 RID: 1513 RVA: 0x00008B15 File Offset: 0x00006D15
		[global::System.Runtime.Serialization.DataMember(Name = "prefetchUrl", IsRequired = true)]
		public string PrefetchUrl { get; private set; }

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x060005EA RID: 1514 RVA: 0x00008B1E File Offset: 0x00006D1E
		// (set) Token: 0x060005EB RID: 1515 RVA: 0x00008B3A File Offset: 0x00006D3A
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

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x060005EC RID: 1516 RVA: 0x00008B4D File Offset: 0x00006D4D
		// (set) Token: 0x060005ED RID: 1517 RVA: 0x00008B55 File Offset: 0x00006D55
		[global::System.Runtime.Serialization.DataMember(Name = "status", IsRequired = true)]
		internal string status { get; private set; }
	}
}
