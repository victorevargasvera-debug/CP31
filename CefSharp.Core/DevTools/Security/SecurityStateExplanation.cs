using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Security
{
	// Token: 0x0200014F RID: 335
	[global::System.Runtime.Serialization.DataContract]
	public class SecurityStateExplanation : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06000A7D RID: 2685 RVA: 0x0000D0AA File Offset: 0x0000B2AA
		// (set) Token: 0x06000A7E RID: 2686 RVA: 0x0000D0C6 File Offset: 0x0000B2C6
		public global::CefSharp.DevTools.Security.SecurityState SecurityState
		{
			get
			{
				return (global::CefSharp.DevTools.Security.SecurityState)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Security.SecurityState), this.securityState);
			}
			set
			{
				this.securityState = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06000A7F RID: 2687 RVA: 0x0000D0D9 File Offset: 0x0000B2D9
		// (set) Token: 0x06000A80 RID: 2688 RVA: 0x0000D0E1 File Offset: 0x0000B2E1
		[global::System.Runtime.Serialization.DataMember(Name = "securityState", IsRequired = true)]
		internal string securityState { get; set; }

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06000A81 RID: 2689 RVA: 0x0000D0EA File Offset: 0x0000B2EA
		// (set) Token: 0x06000A82 RID: 2690 RVA: 0x0000D0F2 File Offset: 0x0000B2F2
		[global::System.Runtime.Serialization.DataMember(Name = "title", IsRequired = true)]
		public string Title { get; set; }

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x06000A83 RID: 2691 RVA: 0x0000D0FB File Offset: 0x0000B2FB
		// (set) Token: 0x06000A84 RID: 2692 RVA: 0x0000D103 File Offset: 0x0000B303
		[global::System.Runtime.Serialization.DataMember(Name = "summary", IsRequired = true)]
		public string Summary { get; set; }

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x06000A85 RID: 2693 RVA: 0x0000D10C File Offset: 0x0000B30C
		// (set) Token: 0x06000A86 RID: 2694 RVA: 0x0000D114 File Offset: 0x0000B314
		[global::System.Runtime.Serialization.DataMember(Name = "description", IsRequired = true)]
		public string Description { get; set; }

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x06000A87 RID: 2695 RVA: 0x0000D11D File Offset: 0x0000B31D
		// (set) Token: 0x06000A88 RID: 2696 RVA: 0x0000D139 File Offset: 0x0000B339
		public global::CefSharp.DevTools.Security.MixedContentType MixedContentType
		{
			get
			{
				return (global::CefSharp.DevTools.Security.MixedContentType)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Security.MixedContentType), this.mixedContentType);
			}
			set
			{
				this.mixedContentType = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x06000A89 RID: 2697 RVA: 0x0000D14C File Offset: 0x0000B34C
		// (set) Token: 0x06000A8A RID: 2698 RVA: 0x0000D154 File Offset: 0x0000B354
		[global::System.Runtime.Serialization.DataMember(Name = "mixedContentType", IsRequired = true)]
		internal string mixedContentType { get; set; }

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06000A8B RID: 2699 RVA: 0x0000D15D File Offset: 0x0000B35D
		// (set) Token: 0x06000A8C RID: 2700 RVA: 0x0000D165 File Offset: 0x0000B365
		[global::System.Runtime.Serialization.DataMember(Name = "certificate", IsRequired = true)]
		public string[] Certificate { get; set; }

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x06000A8D RID: 2701 RVA: 0x0000D16E File Offset: 0x0000B36E
		// (set) Token: 0x06000A8E RID: 2702 RVA: 0x0000D176 File Offset: 0x0000B376
		[global::System.Runtime.Serialization.DataMember(Name = "recommendations", IsRequired = false)]
		public string[] Recommendations { get; set; }
	}
}
