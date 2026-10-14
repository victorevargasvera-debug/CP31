using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.PerformanceTimeline
{
	// Token: 0x02000159 RID: 345
	[global::System.Runtime.Serialization.DataContract]
	public class TimelineEvent : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06000ADD RID: 2781 RVA: 0x0000D4E6 File Offset: 0x0000B6E6
		// (set) Token: 0x06000ADE RID: 2782 RVA: 0x0000D4EE File Offset: 0x0000B6EE
		[global::System.Runtime.Serialization.DataMember(Name = "frameId", IsRequired = true)]
		public string FrameId { get; set; }

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06000ADF RID: 2783 RVA: 0x0000D4F7 File Offset: 0x0000B6F7
		// (set) Token: 0x06000AE0 RID: 2784 RVA: 0x0000D4FF File Offset: 0x0000B6FF
		[global::System.Runtime.Serialization.DataMember(Name = "type", IsRequired = true)]
		public string Type { get; set; }

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06000AE1 RID: 2785 RVA: 0x0000D508 File Offset: 0x0000B708
		// (set) Token: 0x06000AE2 RID: 2786 RVA: 0x0000D510 File Offset: 0x0000B710
		[global::System.Runtime.Serialization.DataMember(Name = "name", IsRequired = true)]
		public string Name { get; set; }

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x06000AE3 RID: 2787 RVA: 0x0000D519 File Offset: 0x0000B719
		// (set) Token: 0x06000AE4 RID: 2788 RVA: 0x0000D521 File Offset: 0x0000B721
		[global::System.Runtime.Serialization.DataMember(Name = "time", IsRequired = true)]
		public double Time { get; set; }

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x06000AE5 RID: 2789 RVA: 0x0000D52A File Offset: 0x0000B72A
		// (set) Token: 0x06000AE6 RID: 2790 RVA: 0x0000D532 File Offset: 0x0000B732
		[global::System.Runtime.Serialization.DataMember(Name = "duration", IsRequired = false)]
		public double? Duration { get; set; }

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06000AE7 RID: 2791 RVA: 0x0000D53B File Offset: 0x0000B73B
		// (set) Token: 0x06000AE8 RID: 2792 RVA: 0x0000D543 File Offset: 0x0000B743
		[global::System.Runtime.Serialization.DataMember(Name = "lcpDetails", IsRequired = false)]
		public global::CefSharp.DevTools.PerformanceTimeline.LargestContentfulPaint LcpDetails { get; set; }

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x06000AE9 RID: 2793 RVA: 0x0000D54C File Offset: 0x0000B74C
		// (set) Token: 0x06000AEA RID: 2794 RVA: 0x0000D554 File Offset: 0x0000B754
		[global::System.Runtime.Serialization.DataMember(Name = "layoutShiftDetails", IsRequired = false)]
		public global::CefSharp.DevTools.PerformanceTimeline.LayoutShift LayoutShiftDetails { get; set; }
	}
}
