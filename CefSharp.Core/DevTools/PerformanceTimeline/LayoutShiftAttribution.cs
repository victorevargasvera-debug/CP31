using System;
using System.Runtime.Serialization;
using CefSharp.DevTools.DOM;

namespace CefSharp.DevTools.PerformanceTimeline
{
	// Token: 0x02000157 RID: 343
	[global::System.Runtime.Serialization.DataContract]
	public class LayoutShiftAttribution : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x06000ACD RID: 2765 RVA: 0x0000D45F File Offset: 0x0000B65F
		// (set) Token: 0x06000ACE RID: 2766 RVA: 0x0000D467 File Offset: 0x0000B667
		[global::System.Runtime.Serialization.DataMember(Name = "previousRect", IsRequired = true)]
		public global::CefSharp.DevTools.DOM.Rect PreviousRect { get; set; }

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x06000ACF RID: 2767 RVA: 0x0000D470 File Offset: 0x0000B670
		// (set) Token: 0x06000AD0 RID: 2768 RVA: 0x0000D478 File Offset: 0x0000B678
		[global::System.Runtime.Serialization.DataMember(Name = "currentRect", IsRequired = true)]
		public global::CefSharp.DevTools.DOM.Rect CurrentRect { get; set; }

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x06000AD1 RID: 2769 RVA: 0x0000D481 File Offset: 0x0000B681
		// (set) Token: 0x06000AD2 RID: 2770 RVA: 0x0000D489 File Offset: 0x0000B689
		[global::System.Runtime.Serialization.DataMember(Name = "nodeId", IsRequired = false)]
		public int? NodeId { get; set; }
	}
}
