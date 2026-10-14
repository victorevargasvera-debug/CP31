using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.SystemInfo
{
	// Token: 0x02000116 RID: 278
	[global::System.Runtime.Serialization.DataContract]
	public class VideoEncodeAcceleratorCapability : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x1700033F RID: 831
		// (get) Token: 0x060008C3 RID: 2243 RVA: 0x0000B7DF File Offset: 0x000099DF
		// (set) Token: 0x060008C4 RID: 2244 RVA: 0x0000B7E7 File Offset: 0x000099E7
		[global::System.Runtime.Serialization.DataMember(Name = "profile", IsRequired = true)]
		public string Profile { get; set; }

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x060008C5 RID: 2245 RVA: 0x0000B7F0 File Offset: 0x000099F0
		// (set) Token: 0x060008C6 RID: 2246 RVA: 0x0000B7F8 File Offset: 0x000099F8
		[global::System.Runtime.Serialization.DataMember(Name = "maxResolution", IsRequired = true)]
		public global::CefSharp.DevTools.SystemInfo.Size MaxResolution { get; set; }

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x060008C7 RID: 2247 RVA: 0x0000B801 File Offset: 0x00009A01
		// (set) Token: 0x060008C8 RID: 2248 RVA: 0x0000B809 File Offset: 0x00009A09
		[global::System.Runtime.Serialization.DataMember(Name = "maxFramerateNumerator", IsRequired = true)]
		public int MaxFramerateNumerator { get; set; }

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x060008C9 RID: 2249 RVA: 0x0000B812 File Offset: 0x00009A12
		// (set) Token: 0x060008CA RID: 2250 RVA: 0x0000B81A File Offset: 0x00009A1A
		[global::System.Runtime.Serialization.DataMember(Name = "maxFramerateDenominator", IsRequired = true)]
		public int MaxFramerateDenominator { get; set; }
	}
}
