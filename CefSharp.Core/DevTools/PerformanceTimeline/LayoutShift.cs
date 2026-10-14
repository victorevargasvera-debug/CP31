using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.PerformanceTimeline
{
	// Token: 0x02000158 RID: 344
	[global::System.Runtime.Serialization.DataContract]
	public class LayoutShift : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x06000AD4 RID: 2772 RVA: 0x0000D49A File Offset: 0x0000B69A
		// (set) Token: 0x06000AD5 RID: 2773 RVA: 0x0000D4A2 File Offset: 0x0000B6A2
		[global::System.Runtime.Serialization.DataMember(Name = "value", IsRequired = true)]
		public double Value { get; set; }

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x06000AD6 RID: 2774 RVA: 0x0000D4AB File Offset: 0x0000B6AB
		// (set) Token: 0x06000AD7 RID: 2775 RVA: 0x0000D4B3 File Offset: 0x0000B6B3
		[global::System.Runtime.Serialization.DataMember(Name = "hadRecentInput", IsRequired = true)]
		public bool HadRecentInput { get; set; }

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06000AD8 RID: 2776 RVA: 0x0000D4BC File Offset: 0x0000B6BC
		// (set) Token: 0x06000AD9 RID: 2777 RVA: 0x0000D4C4 File Offset: 0x0000B6C4
		[global::System.Runtime.Serialization.DataMember(Name = "lastInputTime", IsRequired = true)]
		public double LastInputTime { get; set; }

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06000ADA RID: 2778 RVA: 0x0000D4CD File Offset: 0x0000B6CD
		// (set) Token: 0x06000ADB RID: 2779 RVA: 0x0000D4D5 File Offset: 0x0000B6D5
		[global::System.Runtime.Serialization.DataMember(Name = "sources", IsRequired = true)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.PerformanceTimeline.LayoutShiftAttribution> Sources { get; set; }
	}
}
