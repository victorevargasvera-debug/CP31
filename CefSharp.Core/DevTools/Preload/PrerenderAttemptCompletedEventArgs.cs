using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Preload
{
	// Token: 0x020000AA RID: 170
	[global::System.Runtime.Serialization.DataContract]
	public class PrerenderAttemptCompletedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x1700022F RID: 559
		// (get) Token: 0x060005D2 RID: 1490 RVA: 0x00008A17 File Offset: 0x00006C17
		// (set) Token: 0x060005D3 RID: 1491 RVA: 0x00008A1F File Offset: 0x00006C1F
		[global::System.Runtime.Serialization.DataMember(Name = "key", IsRequired = true)]
		public global::CefSharp.DevTools.Preload.PreloadingAttemptKey Key { get; private set; }

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x060005D4 RID: 1492 RVA: 0x00008A28 File Offset: 0x00006C28
		// (set) Token: 0x060005D5 RID: 1493 RVA: 0x00008A30 File Offset: 0x00006C30
		[global::System.Runtime.Serialization.DataMember(Name = "initiatingFrameId", IsRequired = true)]
		public string InitiatingFrameId { get; private set; }

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x060005D6 RID: 1494 RVA: 0x00008A39 File Offset: 0x00006C39
		// (set) Token: 0x060005D7 RID: 1495 RVA: 0x00008A41 File Offset: 0x00006C41
		[global::System.Runtime.Serialization.DataMember(Name = "prerenderingUrl", IsRequired = true)]
		public string PrerenderingUrl { get; private set; }

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x060005D8 RID: 1496 RVA: 0x00008A4A File Offset: 0x00006C4A
		// (set) Token: 0x060005D9 RID: 1497 RVA: 0x00008A66 File Offset: 0x00006C66
		public global::CefSharp.DevTools.Preload.PrerenderFinalStatus FinalStatus
		{
			get
			{
				return (global::CefSharp.DevTools.Preload.PrerenderFinalStatus)global::CefSharp.DevTools.DevToolsDomainEventArgsBase.StringToEnum(typeof(global::CefSharp.DevTools.Preload.PrerenderFinalStatus), this.finalStatus);
			}
			set
			{
				this.finalStatus = global::CefSharp.DevTools.DevToolsDomainEventArgsBase.EnumToString(value);
			}
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x060005DA RID: 1498 RVA: 0x00008A79 File Offset: 0x00006C79
		// (set) Token: 0x060005DB RID: 1499 RVA: 0x00008A81 File Offset: 0x00006C81
		[global::System.Runtime.Serialization.DataMember(Name = "finalStatus", IsRequired = true)]
		internal string finalStatus { get; private set; }

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x060005DC RID: 1500 RVA: 0x00008A8A File Offset: 0x00006C8A
		// (set) Token: 0x060005DD RID: 1501 RVA: 0x00008A92 File Offset: 0x00006C92
		[global::System.Runtime.Serialization.DataMember(Name = "disallowedApiMethod", IsRequired = false)]
		public string DisallowedApiMethod { get; private set; }
	}
}
