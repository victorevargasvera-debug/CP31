using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.PerformanceTimeline
{
	// Token: 0x0200015A RID: 346
	[global::System.Runtime.Serialization.DataContract]
	public class TimelineEventAddedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06000AEC RID: 2796 RVA: 0x0000D565 File Offset: 0x0000B765
		// (set) Token: 0x06000AED RID: 2797 RVA: 0x0000D56D File Offset: 0x0000B76D
		[global::System.Runtime.Serialization.DataMember(Name = "event", IsRequired = true)]
		public global::CefSharp.DevTools.PerformanceTimeline.TimelineEvent Event { get; private set; }
	}
}
