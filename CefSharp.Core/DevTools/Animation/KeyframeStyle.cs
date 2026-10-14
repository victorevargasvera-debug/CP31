using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Animation
{
	// Token: 0x02000377 RID: 887
	[global::System.Runtime.Serialization.DataContract]
	public class KeyframeStyle : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000A8F RID: 2703
		// (get) Token: 0x06001AD9 RID: 6873 RVA: 0x0001C639 File Offset: 0x0001A839
		// (set) Token: 0x06001ADA RID: 6874 RVA: 0x0001C641 File Offset: 0x0001A841
		[global::System.Runtime.Serialization.DataMember(Name = "offset", IsRequired = true)]
		public string Offset { get; set; }

		// Token: 0x17000A90 RID: 2704
		// (get) Token: 0x06001ADB RID: 6875 RVA: 0x0001C64A File Offset: 0x0001A84A
		// (set) Token: 0x06001ADC RID: 6876 RVA: 0x0001C652 File Offset: 0x0001A852
		[global::System.Runtime.Serialization.DataMember(Name = "easing", IsRequired = true)]
		public string Easing { get; set; }
	}
}
