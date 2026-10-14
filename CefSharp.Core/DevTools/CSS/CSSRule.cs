using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.CSS
{
	// Token: 0x020002FC RID: 764
	[global::System.Runtime.Serialization.DataContract]
	public class CSSRule : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000907 RID: 2311
		// (get) Token: 0x0600174E RID: 5966 RVA: 0x000198E2 File Offset: 0x00017AE2
		// (set) Token: 0x0600174F RID: 5967 RVA: 0x000198EA File Offset: 0x00017AEA
		[global::System.Runtime.Serialization.DataMember(Name = "styleSheetId", IsRequired = false)]
		public string StyleSheetId { get; set; }

		// Token: 0x17000908 RID: 2312
		// (get) Token: 0x06001750 RID: 5968 RVA: 0x000198F3 File Offset: 0x00017AF3
		// (set) Token: 0x06001751 RID: 5969 RVA: 0x000198FB File Offset: 0x00017AFB
		[global::System.Runtime.Serialization.DataMember(Name = "selectorList", IsRequired = true)]
		public global::CefSharp.DevTools.CSS.SelectorList SelectorList { get; set; }

		// Token: 0x17000909 RID: 2313
		// (get) Token: 0x06001752 RID: 5970 RVA: 0x00019904 File Offset: 0x00017B04
		// (set) Token: 0x06001753 RID: 5971 RVA: 0x0001990C File Offset: 0x00017B0C
		[global::System.Runtime.Serialization.DataMember(Name = "nestingSelectors", IsRequired = false)]
		public string[] NestingSelectors { get; set; }

		// Token: 0x1700090A RID: 2314
		// (get) Token: 0x06001754 RID: 5972 RVA: 0x00019915 File Offset: 0x00017B15
		// (set) Token: 0x06001755 RID: 5973 RVA: 0x00019931 File Offset: 0x00017B31
		public global::CefSharp.DevTools.CSS.StyleSheetOrigin Origin
		{
			get
			{
				return (global::CefSharp.DevTools.CSS.StyleSheetOrigin)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.CSS.StyleSheetOrigin), this.origin);
			}
			set
			{
				this.origin = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x1700090B RID: 2315
		// (get) Token: 0x06001756 RID: 5974 RVA: 0x00019944 File Offset: 0x00017B44
		// (set) Token: 0x06001757 RID: 5975 RVA: 0x0001994C File Offset: 0x00017B4C
		[global::System.Runtime.Serialization.DataMember(Name = "origin", IsRequired = true)]
		internal string origin { get; set; }

		// Token: 0x1700090C RID: 2316
		// (get) Token: 0x06001758 RID: 5976 RVA: 0x00019955 File Offset: 0x00017B55
		// (set) Token: 0x06001759 RID: 5977 RVA: 0x0001995D File Offset: 0x00017B5D
		[global::System.Runtime.Serialization.DataMember(Name = "style", IsRequired = true)]
		public global::CefSharp.DevTools.CSS.CSSStyle Style { get; set; }

		// Token: 0x1700090D RID: 2317
		// (get) Token: 0x0600175A RID: 5978 RVA: 0x00019966 File Offset: 0x00017B66
		// (set) Token: 0x0600175B RID: 5979 RVA: 0x0001996E File Offset: 0x00017B6E
		[global::System.Runtime.Serialization.DataMember(Name = "media", IsRequired = false)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.CSS.CSSMedia> Media { get; set; }

		// Token: 0x1700090E RID: 2318
		// (get) Token: 0x0600175C RID: 5980 RVA: 0x00019977 File Offset: 0x00017B77
		// (set) Token: 0x0600175D RID: 5981 RVA: 0x0001997F File Offset: 0x00017B7F
		[global::System.Runtime.Serialization.DataMember(Name = "containerQueries", IsRequired = false)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.CSS.CSSContainerQuery> ContainerQueries { get; set; }

		// Token: 0x1700090F RID: 2319
		// (get) Token: 0x0600175E RID: 5982 RVA: 0x00019988 File Offset: 0x00017B88
		// (set) Token: 0x0600175F RID: 5983 RVA: 0x00019990 File Offset: 0x00017B90
		[global::System.Runtime.Serialization.DataMember(Name = "supports", IsRequired = false)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.CSS.CSSSupports> Supports { get; set; }

		// Token: 0x17000910 RID: 2320
		// (get) Token: 0x06001760 RID: 5984 RVA: 0x00019999 File Offset: 0x00017B99
		// (set) Token: 0x06001761 RID: 5985 RVA: 0x000199A1 File Offset: 0x00017BA1
		[global::System.Runtime.Serialization.DataMember(Name = "layers", IsRequired = false)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.CSS.CSSLayer> Layers { get; set; }

		// Token: 0x17000911 RID: 2321
		// (get) Token: 0x06001762 RID: 5986 RVA: 0x000199AA File Offset: 0x00017BAA
		// (set) Token: 0x06001763 RID: 5987 RVA: 0x000199B2 File Offset: 0x00017BB2
		[global::System.Runtime.Serialization.DataMember(Name = "scopes", IsRequired = false)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.CSS.CSSScope> Scopes { get; set; }
	}
}
