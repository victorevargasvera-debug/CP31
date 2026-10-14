using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x020001F5 RID: 501
	[global::System.Runtime.Serialization.DataContract]
	public class CachedResource : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x06000F3D RID: 3901 RVA: 0x00011398 File Offset: 0x0000F598
		// (set) Token: 0x06000F3E RID: 3902 RVA: 0x000113A0 File Offset: 0x0000F5A0
		[global::System.Runtime.Serialization.DataMember(Name = "url", IsRequired = true)]
		public string Url { get; set; }

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x06000F3F RID: 3903 RVA: 0x000113A9 File Offset: 0x0000F5A9
		// (set) Token: 0x06000F40 RID: 3904 RVA: 0x000113C5 File Offset: 0x0000F5C5
		public global::CefSharp.DevTools.Network.ResourceType Type
		{
			get
			{
				return (global::CefSharp.DevTools.Network.ResourceType)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Network.ResourceType), this.type);
			}
			set
			{
				this.type = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x06000F41 RID: 3905 RVA: 0x000113D8 File Offset: 0x0000F5D8
		// (set) Token: 0x06000F42 RID: 3906 RVA: 0x000113E0 File Offset: 0x0000F5E0
		[global::System.Runtime.Serialization.DataMember(Name = "type", IsRequired = true)]
		internal string type { get; set; }

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x06000F43 RID: 3907 RVA: 0x000113E9 File Offset: 0x0000F5E9
		// (set) Token: 0x06000F44 RID: 3908 RVA: 0x000113F1 File Offset: 0x0000F5F1
		[global::System.Runtime.Serialization.DataMember(Name = "response", IsRequired = false)]
		public global::CefSharp.DevTools.Network.Response Response { get; set; }

		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x06000F45 RID: 3909 RVA: 0x000113FA File Offset: 0x0000F5FA
		// (set) Token: 0x06000F46 RID: 3910 RVA: 0x00011402 File Offset: 0x0000F602
		[global::System.Runtime.Serialization.DataMember(Name = "bodySize", IsRequired = true)]
		public double BodySize { get; set; }
	}
}
