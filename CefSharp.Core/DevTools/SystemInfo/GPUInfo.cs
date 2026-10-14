using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.SystemInfo
{
	// Token: 0x0200011A RID: 282
	[global::System.Runtime.Serialization.DataContract]
	public class GPUInfo : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000349 RID: 841
		// (get) Token: 0x060008D9 RID: 2265 RVA: 0x0000B8D0 File Offset: 0x00009AD0
		// (set) Token: 0x060008DA RID: 2266 RVA: 0x0000B8D8 File Offset: 0x00009AD8
		[global::System.Runtime.Serialization.DataMember(Name = "devices", IsRequired = true)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.SystemInfo.GPUDevice> Devices { get; set; }

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x060008DB RID: 2267 RVA: 0x0000B8E1 File Offset: 0x00009AE1
		// (set) Token: 0x060008DC RID: 2268 RVA: 0x0000B8E9 File Offset: 0x00009AE9
		[global::System.Runtime.Serialization.DataMember(Name = "auxAttributes", IsRequired = false)]
		public object AuxAttributes { get; set; }

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x060008DD RID: 2269 RVA: 0x0000B8F2 File Offset: 0x00009AF2
		// (set) Token: 0x060008DE RID: 2270 RVA: 0x0000B8FA File Offset: 0x00009AFA
		[global::System.Runtime.Serialization.DataMember(Name = "featureStatus", IsRequired = false)]
		public object FeatureStatus { get; set; }

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x060008DF RID: 2271 RVA: 0x0000B903 File Offset: 0x00009B03
		// (set) Token: 0x060008E0 RID: 2272 RVA: 0x0000B90B File Offset: 0x00009B0B
		[global::System.Runtime.Serialization.DataMember(Name = "driverBugWorkarounds", IsRequired = true)]
		public string[] DriverBugWorkarounds { get; set; }

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x060008E1 RID: 2273 RVA: 0x0000B914 File Offset: 0x00009B14
		// (set) Token: 0x060008E2 RID: 2274 RVA: 0x0000B91C File Offset: 0x00009B1C
		[global::System.Runtime.Serialization.DataMember(Name = "videoDecoding", IsRequired = true)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.SystemInfo.VideoDecodeAcceleratorCapability> VideoDecoding { get; set; }

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x060008E3 RID: 2275 RVA: 0x0000B925 File Offset: 0x00009B25
		// (set) Token: 0x060008E4 RID: 2276 RVA: 0x0000B92D File Offset: 0x00009B2D
		[global::System.Runtime.Serialization.DataMember(Name = "videoEncoding", IsRequired = true)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.SystemInfo.VideoEncodeAcceleratorCapability> VideoEncoding { get; set; }

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x060008E5 RID: 2277 RVA: 0x0000B936 File Offset: 0x00009B36
		// (set) Token: 0x060008E6 RID: 2278 RVA: 0x0000B93E File Offset: 0x00009B3E
		[global::System.Runtime.Serialization.DataMember(Name = "imageDecoding", IsRequired = true)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.SystemInfo.ImageDecodeAcceleratorCapability> ImageDecoding { get; set; }
	}
}
