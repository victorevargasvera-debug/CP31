using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.SystemInfo
{
	// Token: 0x02000115 RID: 277
	[global::System.Runtime.Serialization.DataContract]
	public class VideoDecodeAcceleratorCapability : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x1700033C RID: 828
		// (get) Token: 0x060008BC RID: 2236 RVA: 0x0000B7A4 File Offset: 0x000099A4
		// (set) Token: 0x060008BD RID: 2237 RVA: 0x0000B7AC File Offset: 0x000099AC
		[global::System.Runtime.Serialization.DataMember(Name = "profile", IsRequired = true)]
		public string Profile { get; set; }

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x060008BE RID: 2238 RVA: 0x0000B7B5 File Offset: 0x000099B5
		// (set) Token: 0x060008BF RID: 2239 RVA: 0x0000B7BD File Offset: 0x000099BD
		[global::System.Runtime.Serialization.DataMember(Name = "maxResolution", IsRequired = true)]
		public global::CefSharp.DevTools.SystemInfo.Size MaxResolution { get; set; }

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x060008C0 RID: 2240 RVA: 0x0000B7C6 File Offset: 0x000099C6
		// (set) Token: 0x060008C1 RID: 2241 RVA: 0x0000B7CE File Offset: 0x000099CE
		[global::System.Runtime.Serialization.DataMember(Name = "minResolution", IsRequired = true)]
		public global::CefSharp.DevTools.SystemInfo.Size MinResolution { get; set; }
	}
}
