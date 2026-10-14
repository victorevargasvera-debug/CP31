using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.PerformanceTimeline
{
	// Token: 0x02000156 RID: 342
	[global::System.Runtime.Serialization.DataContract]
	public class LargestContentfulPaint : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x06000AC0 RID: 2752 RVA: 0x0000D3F1 File Offset: 0x0000B5F1
		// (set) Token: 0x06000AC1 RID: 2753 RVA: 0x0000D3F9 File Offset: 0x0000B5F9
		[global::System.Runtime.Serialization.DataMember(Name = "renderTime", IsRequired = true)]
		public double RenderTime { get; set; }

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x06000AC2 RID: 2754 RVA: 0x0000D402 File Offset: 0x0000B602
		// (set) Token: 0x06000AC3 RID: 2755 RVA: 0x0000D40A File Offset: 0x0000B60A
		[global::System.Runtime.Serialization.DataMember(Name = "loadTime", IsRequired = true)]
		public double LoadTime { get; set; }

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x06000AC4 RID: 2756 RVA: 0x0000D413 File Offset: 0x0000B613
		// (set) Token: 0x06000AC5 RID: 2757 RVA: 0x0000D41B File Offset: 0x0000B61B
		[global::System.Runtime.Serialization.DataMember(Name = "size", IsRequired = true)]
		public double Size { get; set; }

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06000AC6 RID: 2758 RVA: 0x0000D424 File Offset: 0x0000B624
		// (set) Token: 0x06000AC7 RID: 2759 RVA: 0x0000D42C File Offset: 0x0000B62C
		[global::System.Runtime.Serialization.DataMember(Name = "elementId", IsRequired = false)]
		public string ElementId { get; set; }

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x06000AC8 RID: 2760 RVA: 0x0000D435 File Offset: 0x0000B635
		// (set) Token: 0x06000AC9 RID: 2761 RVA: 0x0000D43D File Offset: 0x0000B63D
		[global::System.Runtime.Serialization.DataMember(Name = "url", IsRequired = false)]
		public string Url { get; set; }

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x06000ACA RID: 2762 RVA: 0x0000D446 File Offset: 0x0000B646
		// (set) Token: 0x06000ACB RID: 2763 RVA: 0x0000D44E File Offset: 0x0000B64E
		[global::System.Runtime.Serialization.DataMember(Name = "nodeId", IsRequired = false)]
		public int? NodeId { get; set; }
	}
}
