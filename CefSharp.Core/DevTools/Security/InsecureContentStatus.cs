using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Security
{
	// Token: 0x02000150 RID: 336
	[global::System.Runtime.Serialization.DataContract]
	public class InsecureContentStatus : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x06000A90 RID: 2704 RVA: 0x0000D187 File Offset: 0x0000B387
		// (set) Token: 0x06000A91 RID: 2705 RVA: 0x0000D18F File Offset: 0x0000B38F
		[global::System.Runtime.Serialization.DataMember(Name = "ranMixedContent", IsRequired = true)]
		public bool RanMixedContent { get; set; }

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x06000A92 RID: 2706 RVA: 0x0000D198 File Offset: 0x0000B398
		// (set) Token: 0x06000A93 RID: 2707 RVA: 0x0000D1A0 File Offset: 0x0000B3A0
		[global::System.Runtime.Serialization.DataMember(Name = "displayedMixedContent", IsRequired = true)]
		public bool DisplayedMixedContent { get; set; }

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x06000A94 RID: 2708 RVA: 0x0000D1A9 File Offset: 0x0000B3A9
		// (set) Token: 0x06000A95 RID: 2709 RVA: 0x0000D1B1 File Offset: 0x0000B3B1
		[global::System.Runtime.Serialization.DataMember(Name = "containedMixedForm", IsRequired = true)]
		public bool ContainedMixedForm { get; set; }

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x06000A96 RID: 2710 RVA: 0x0000D1BA File Offset: 0x0000B3BA
		// (set) Token: 0x06000A97 RID: 2711 RVA: 0x0000D1C2 File Offset: 0x0000B3C2
		[global::System.Runtime.Serialization.DataMember(Name = "ranContentWithCertErrors", IsRequired = true)]
		public bool RanContentWithCertErrors { get; set; }

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x06000A98 RID: 2712 RVA: 0x0000D1CB File Offset: 0x0000B3CB
		// (set) Token: 0x06000A99 RID: 2713 RVA: 0x0000D1D3 File Offset: 0x0000B3D3
		[global::System.Runtime.Serialization.DataMember(Name = "displayedContentWithCertErrors", IsRequired = true)]
		public bool DisplayedContentWithCertErrors { get; set; }

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x06000A9A RID: 2714 RVA: 0x0000D1DC File Offset: 0x0000B3DC
		// (set) Token: 0x06000A9B RID: 2715 RVA: 0x0000D1F8 File Offset: 0x0000B3F8
		public global::CefSharp.DevTools.Security.SecurityState RanInsecureContentStyle
		{
			get
			{
				return (global::CefSharp.DevTools.Security.SecurityState)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Security.SecurityState), this.ranInsecureContentStyle);
			}
			set
			{
				this.ranInsecureContentStyle = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06000A9C RID: 2716 RVA: 0x0000D20B File Offset: 0x0000B40B
		// (set) Token: 0x06000A9D RID: 2717 RVA: 0x0000D213 File Offset: 0x0000B413
		[global::System.Runtime.Serialization.DataMember(Name = "ranInsecureContentStyle", IsRequired = true)]
		internal string ranInsecureContentStyle { get; set; }

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x06000A9E RID: 2718 RVA: 0x0000D21C File Offset: 0x0000B41C
		// (set) Token: 0x06000A9F RID: 2719 RVA: 0x0000D238 File Offset: 0x0000B438
		public global::CefSharp.DevTools.Security.SecurityState DisplayedInsecureContentStyle
		{
			get
			{
				return (global::CefSharp.DevTools.Security.SecurityState)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Security.SecurityState), this.displayedInsecureContentStyle);
			}
			set
			{
				this.displayedInsecureContentStyle = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x06000AA0 RID: 2720 RVA: 0x0000D24B File Offset: 0x0000B44B
		// (set) Token: 0x06000AA1 RID: 2721 RVA: 0x0000D253 File Offset: 0x0000B453
		[global::System.Runtime.Serialization.DataMember(Name = "displayedInsecureContentStyle", IsRequired = true)]
		internal string displayedInsecureContentStyle { get; set; }
	}
}
