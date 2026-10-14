using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.WebAudio
{
	// Token: 0x020000CF RID: 207
	[global::System.Runtime.Serialization.DataContract]
	public class ContextRealtimeData : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x1700027D RID: 637
		// (get) Token: 0x060006B9 RID: 1721 RVA: 0x0000979D File Offset: 0x0000799D
		// (set) Token: 0x060006BA RID: 1722 RVA: 0x000097A5 File Offset: 0x000079A5
		[global::System.Runtime.Serialization.DataMember(Name = "currentTime", IsRequired = true)]
		public double CurrentTime { get; set; }

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x060006BB RID: 1723 RVA: 0x000097AE File Offset: 0x000079AE
		// (set) Token: 0x060006BC RID: 1724 RVA: 0x000097B6 File Offset: 0x000079B6
		[global::System.Runtime.Serialization.DataMember(Name = "renderCapacity", IsRequired = true)]
		public double RenderCapacity { get; set; }

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x060006BD RID: 1725 RVA: 0x000097BF File Offset: 0x000079BF
		// (set) Token: 0x060006BE RID: 1726 RVA: 0x000097C7 File Offset: 0x000079C7
		[global::System.Runtime.Serialization.DataMember(Name = "callbackIntervalMean", IsRequired = true)]
		public double CallbackIntervalMean { get; set; }

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x060006BF RID: 1727 RVA: 0x000097D0 File Offset: 0x000079D0
		// (set) Token: 0x060006C0 RID: 1728 RVA: 0x000097D8 File Offset: 0x000079D8
		[global::System.Runtime.Serialization.DataMember(Name = "callbackIntervalVariance", IsRequired = true)]
		public double CallbackIntervalVariance { get; set; }
	}
}
