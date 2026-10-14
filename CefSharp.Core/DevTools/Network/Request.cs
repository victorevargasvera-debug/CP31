using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using CefSharp.DevTools.Security;

namespace CefSharp.DevTools.Network
{
	// Token: 0x020001E5 RID: 485
	[global::System.Runtime.Serialization.DataContract]
	public class Request : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x06000E8A RID: 3722 RVA: 0x00010C7F File Offset: 0x0000EE7F
		// (set) Token: 0x06000E8B RID: 3723 RVA: 0x00010C87 File Offset: 0x0000EE87
		[global::System.Runtime.Serialization.DataMember(Name = "url", IsRequired = true)]
		public string Url { get; set; }

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x06000E8C RID: 3724 RVA: 0x00010C90 File Offset: 0x0000EE90
		// (set) Token: 0x06000E8D RID: 3725 RVA: 0x00010C98 File Offset: 0x0000EE98
		[global::System.Runtime.Serialization.DataMember(Name = "urlFragment", IsRequired = false)]
		public string UrlFragment { get; set; }

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x06000E8E RID: 3726 RVA: 0x00010CA1 File Offset: 0x0000EEA1
		// (set) Token: 0x06000E8F RID: 3727 RVA: 0x00010CA9 File Offset: 0x0000EEA9
		[global::System.Runtime.Serialization.DataMember(Name = "method", IsRequired = true)]
		public string Method { get; set; }

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x06000E90 RID: 3728 RVA: 0x00010CB2 File Offset: 0x0000EEB2
		// (set) Token: 0x06000E91 RID: 3729 RVA: 0x00010CBA File Offset: 0x0000EEBA
		[global::System.Runtime.Serialization.DataMember(Name = "headers", IsRequired = true)]
		public global::CefSharp.DevTools.Network.Headers Headers { get; set; }

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x06000E92 RID: 3730 RVA: 0x00010CC3 File Offset: 0x0000EEC3
		// (set) Token: 0x06000E93 RID: 3731 RVA: 0x00010CCB File Offset: 0x0000EECB
		[global::System.Runtime.Serialization.DataMember(Name = "postData", IsRequired = false)]
		public string PostData { get; set; }

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x06000E94 RID: 3732 RVA: 0x00010CD4 File Offset: 0x0000EED4
		// (set) Token: 0x06000E95 RID: 3733 RVA: 0x00010CDC File Offset: 0x0000EEDC
		[global::System.Runtime.Serialization.DataMember(Name = "hasPostData", IsRequired = false)]
		public bool? HasPostData { get; set; }

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x06000E96 RID: 3734 RVA: 0x00010CE5 File Offset: 0x0000EEE5
		// (set) Token: 0x06000E97 RID: 3735 RVA: 0x00010CED File Offset: 0x0000EEED
		[global::System.Runtime.Serialization.DataMember(Name = "postDataEntries", IsRequired = false)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.Network.PostDataEntry> PostDataEntries { get; set; }

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x06000E98 RID: 3736 RVA: 0x00010CF6 File Offset: 0x0000EEF6
		// (set) Token: 0x06000E99 RID: 3737 RVA: 0x00010D12 File Offset: 0x0000EF12
		public global::CefSharp.DevTools.Security.MixedContentType? MixedContentType
		{
			get
			{
				return (global::CefSharp.DevTools.Security.MixedContentType?)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Security.MixedContentType?), this.mixedContentType);
			}
			set
			{
				this.mixedContentType = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x06000E9A RID: 3738 RVA: 0x00010D25 File Offset: 0x0000EF25
		// (set) Token: 0x06000E9B RID: 3739 RVA: 0x00010D2D File Offset: 0x0000EF2D
		[global::System.Runtime.Serialization.DataMember(Name = "mixedContentType", IsRequired = false)]
		internal string mixedContentType { get; set; }

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x06000E9C RID: 3740 RVA: 0x00010D36 File Offset: 0x0000EF36
		// (set) Token: 0x06000E9D RID: 3741 RVA: 0x00010D52 File Offset: 0x0000EF52
		public global::CefSharp.DevTools.Network.ResourcePriority InitialPriority
		{
			get
			{
				return (global::CefSharp.DevTools.Network.ResourcePriority)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Network.ResourcePriority), this.initialPriority);
			}
			set
			{
				this.initialPriority = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x06000E9E RID: 3742 RVA: 0x00010D65 File Offset: 0x0000EF65
		// (set) Token: 0x06000E9F RID: 3743 RVA: 0x00010D6D File Offset: 0x0000EF6D
		[global::System.Runtime.Serialization.DataMember(Name = "initialPriority", IsRequired = true)]
		internal string initialPriority { get; set; }

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x06000EA0 RID: 3744 RVA: 0x00010D76 File Offset: 0x0000EF76
		// (set) Token: 0x06000EA1 RID: 3745 RVA: 0x00010D92 File Offset: 0x0000EF92
		public global::CefSharp.DevTools.Network.RequestReferrerPolicy ReferrerPolicy
		{
			get
			{
				return (global::CefSharp.DevTools.Network.RequestReferrerPolicy)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Network.RequestReferrerPolicy), this.referrerPolicy);
			}
			set
			{
				this.referrerPolicy = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x06000EA2 RID: 3746 RVA: 0x00010DA5 File Offset: 0x0000EFA5
		// (set) Token: 0x06000EA3 RID: 3747 RVA: 0x00010DAD File Offset: 0x0000EFAD
		[global::System.Runtime.Serialization.DataMember(Name = "referrerPolicy", IsRequired = true)]
		internal string referrerPolicy { get; set; }

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x06000EA4 RID: 3748 RVA: 0x00010DB6 File Offset: 0x0000EFB6
		// (set) Token: 0x06000EA5 RID: 3749 RVA: 0x00010DBE File Offset: 0x0000EFBE
		[global::System.Runtime.Serialization.DataMember(Name = "isLinkPreload", IsRequired = false)]
		public bool? IsLinkPreload { get; set; }

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x06000EA6 RID: 3750 RVA: 0x00010DC7 File Offset: 0x0000EFC7
		// (set) Token: 0x06000EA7 RID: 3751 RVA: 0x00010DCF File Offset: 0x0000EFCF
		[global::System.Runtime.Serialization.DataMember(Name = "trustTokenParams", IsRequired = false)]
		public global::CefSharp.DevTools.Network.TrustTokenParams TrustTokenParams { get; set; }

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x06000EA8 RID: 3752 RVA: 0x00010DD8 File Offset: 0x0000EFD8
		// (set) Token: 0x06000EA9 RID: 3753 RVA: 0x00010DE0 File Offset: 0x0000EFE0
		[global::System.Runtime.Serialization.DataMember(Name = "isSameSite", IsRequired = false)]
		public bool? IsSameSite { get; set; }
	}
}
