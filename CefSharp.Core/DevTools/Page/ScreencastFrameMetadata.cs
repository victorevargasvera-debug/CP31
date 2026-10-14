using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Page
{
	// Token: 0x02000178 RID: 376
	[global::System.Runtime.Serialization.DataContract]
	public class ScreencastFrameMetadata : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x06000B93 RID: 2963 RVA: 0x0000DD12 File Offset: 0x0000BF12
		// (set) Token: 0x06000B94 RID: 2964 RVA: 0x0000DD1A File Offset: 0x0000BF1A
		[global::System.Runtime.Serialization.DataMember(Name = "offsetTop", IsRequired = true)]
		public double OffsetTop { get; set; }

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x06000B95 RID: 2965 RVA: 0x0000DD23 File Offset: 0x0000BF23
		// (set) Token: 0x06000B96 RID: 2966 RVA: 0x0000DD2B File Offset: 0x0000BF2B
		[global::System.Runtime.Serialization.DataMember(Name = "pageScaleFactor", IsRequired = true)]
		public double PageScaleFactor { get; set; }

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x06000B97 RID: 2967 RVA: 0x0000DD34 File Offset: 0x0000BF34
		// (set) Token: 0x06000B98 RID: 2968 RVA: 0x0000DD3C File Offset: 0x0000BF3C
		[global::System.Runtime.Serialization.DataMember(Name = "deviceWidth", IsRequired = true)]
		public double DeviceWidth { get; set; }

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x06000B99 RID: 2969 RVA: 0x0000DD45 File Offset: 0x0000BF45
		// (set) Token: 0x06000B9A RID: 2970 RVA: 0x0000DD4D File Offset: 0x0000BF4D
		[global::System.Runtime.Serialization.DataMember(Name = "deviceHeight", IsRequired = true)]
		public double DeviceHeight { get; set; }

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x06000B9B RID: 2971 RVA: 0x0000DD56 File Offset: 0x0000BF56
		// (set) Token: 0x06000B9C RID: 2972 RVA: 0x0000DD5E File Offset: 0x0000BF5E
		[global::System.Runtime.Serialization.DataMember(Name = "scrollOffsetX", IsRequired = true)]
		public double ScrollOffsetX { get; set; }

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x06000B9D RID: 2973 RVA: 0x0000DD67 File Offset: 0x0000BF67
		// (set) Token: 0x06000B9E RID: 2974 RVA: 0x0000DD6F File Offset: 0x0000BF6F
		[global::System.Runtime.Serialization.DataMember(Name = "scrollOffsetY", IsRequired = true)]
		public double ScrollOffsetY { get; set; }

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x06000B9F RID: 2975 RVA: 0x0000DD78 File Offset: 0x0000BF78
		// (set) Token: 0x06000BA0 RID: 2976 RVA: 0x0000DD80 File Offset: 0x0000BF80
		[global::System.Runtime.Serialization.DataMember(Name = "timestamp", IsRequired = false)]
		public double? Timestamp { get; set; }
	}
}
