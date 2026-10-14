using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Page
{
	// Token: 0x02000172 RID: 370
	[global::System.Runtime.Serialization.DataContract]
	public class Frame : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x06000B46 RID: 2886 RVA: 0x0000D9F5 File Offset: 0x0000BBF5
		// (set) Token: 0x06000B47 RID: 2887 RVA: 0x0000D9FD File Offset: 0x0000BBFD
		[global::System.Runtime.Serialization.DataMember(Name = "id", IsRequired = true)]
		public string Id { get; set; }

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x06000B48 RID: 2888 RVA: 0x0000DA06 File Offset: 0x0000BC06
		// (set) Token: 0x06000B49 RID: 2889 RVA: 0x0000DA0E File Offset: 0x0000BC0E
		[global::System.Runtime.Serialization.DataMember(Name = "parentId", IsRequired = false)]
		public string ParentId { get; set; }

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x06000B4A RID: 2890 RVA: 0x0000DA17 File Offset: 0x0000BC17
		// (set) Token: 0x06000B4B RID: 2891 RVA: 0x0000DA1F File Offset: 0x0000BC1F
		[global::System.Runtime.Serialization.DataMember(Name = "loaderId", IsRequired = true)]
		public string LoaderId { get; set; }

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x06000B4C RID: 2892 RVA: 0x0000DA28 File Offset: 0x0000BC28
		// (set) Token: 0x06000B4D RID: 2893 RVA: 0x0000DA30 File Offset: 0x0000BC30
		[global::System.Runtime.Serialization.DataMember(Name = "name", IsRequired = false)]
		public string Name { get; set; }

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x06000B4E RID: 2894 RVA: 0x0000DA39 File Offset: 0x0000BC39
		// (set) Token: 0x06000B4F RID: 2895 RVA: 0x0000DA41 File Offset: 0x0000BC41
		[global::System.Runtime.Serialization.DataMember(Name = "url", IsRequired = true)]
		public string Url { get; set; }

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x06000B50 RID: 2896 RVA: 0x0000DA4A File Offset: 0x0000BC4A
		// (set) Token: 0x06000B51 RID: 2897 RVA: 0x0000DA52 File Offset: 0x0000BC52
		[global::System.Runtime.Serialization.DataMember(Name = "urlFragment", IsRequired = false)]
		public string UrlFragment { get; set; }

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x06000B52 RID: 2898 RVA: 0x0000DA5B File Offset: 0x0000BC5B
		// (set) Token: 0x06000B53 RID: 2899 RVA: 0x0000DA63 File Offset: 0x0000BC63
		[global::System.Runtime.Serialization.DataMember(Name = "domainAndRegistry", IsRequired = true)]
		public string DomainAndRegistry { get; set; }

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x06000B54 RID: 2900 RVA: 0x0000DA6C File Offset: 0x0000BC6C
		// (set) Token: 0x06000B55 RID: 2901 RVA: 0x0000DA74 File Offset: 0x0000BC74
		[global::System.Runtime.Serialization.DataMember(Name = "securityOrigin", IsRequired = true)]
		public string SecurityOrigin { get; set; }

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x06000B56 RID: 2902 RVA: 0x0000DA7D File Offset: 0x0000BC7D
		// (set) Token: 0x06000B57 RID: 2903 RVA: 0x0000DA85 File Offset: 0x0000BC85
		[global::System.Runtime.Serialization.DataMember(Name = "mimeType", IsRequired = true)]
		public string MimeType { get; set; }

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x06000B58 RID: 2904 RVA: 0x0000DA8E File Offset: 0x0000BC8E
		// (set) Token: 0x06000B59 RID: 2905 RVA: 0x0000DA96 File Offset: 0x0000BC96
		[global::System.Runtime.Serialization.DataMember(Name = "unreachableUrl", IsRequired = false)]
		public string UnreachableUrl { get; set; }

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x06000B5A RID: 2906 RVA: 0x0000DA9F File Offset: 0x0000BC9F
		// (set) Token: 0x06000B5B RID: 2907 RVA: 0x0000DAA7 File Offset: 0x0000BCA7
		[global::System.Runtime.Serialization.DataMember(Name = "adFrameStatus", IsRequired = false)]
		public global::CefSharp.DevTools.Page.AdFrameStatus AdFrameStatus { get; set; }

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x06000B5C RID: 2908 RVA: 0x0000DAB0 File Offset: 0x0000BCB0
		// (set) Token: 0x06000B5D RID: 2909 RVA: 0x0000DACC File Offset: 0x0000BCCC
		public global::CefSharp.DevTools.Page.SecureContextType SecureContextType
		{
			get
			{
				return (global::CefSharp.DevTools.Page.SecureContextType)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Page.SecureContextType), this.secureContextType);
			}
			set
			{
				this.secureContextType = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x06000B5E RID: 2910 RVA: 0x0000DADF File Offset: 0x0000BCDF
		// (set) Token: 0x06000B5F RID: 2911 RVA: 0x0000DAE7 File Offset: 0x0000BCE7
		[global::System.Runtime.Serialization.DataMember(Name = "secureContextType", IsRequired = true)]
		internal string secureContextType { get; set; }

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x06000B60 RID: 2912 RVA: 0x0000DAF0 File Offset: 0x0000BCF0
		// (set) Token: 0x06000B61 RID: 2913 RVA: 0x0000DB0C File Offset: 0x0000BD0C
		public global::CefSharp.DevTools.Page.CrossOriginIsolatedContextType CrossOriginIsolatedContextType
		{
			get
			{
				return (global::CefSharp.DevTools.Page.CrossOriginIsolatedContextType)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Page.CrossOriginIsolatedContextType), this.crossOriginIsolatedContextType);
			}
			set
			{
				this.crossOriginIsolatedContextType = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x06000B62 RID: 2914 RVA: 0x0000DB1F File Offset: 0x0000BD1F
		// (set) Token: 0x06000B63 RID: 2915 RVA: 0x0000DB27 File Offset: 0x0000BD27
		[global::System.Runtime.Serialization.DataMember(Name = "crossOriginIsolatedContextType", IsRequired = true)]
		internal string crossOriginIsolatedContextType { get; set; }

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x06000B64 RID: 2916 RVA: 0x0000DB30 File Offset: 0x0000BD30
		// (set) Token: 0x06000B65 RID: 2917 RVA: 0x0000DB4C File Offset: 0x0000BD4C
		public global::CefSharp.DevTools.Page.GatedAPIFeatures[] GatedAPIFeatures
		{
			get
			{
				return (global::CefSharp.DevTools.Page.GatedAPIFeatures[])global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Page.GatedAPIFeatures[]), this.gatedAPIFeatures);
			}
			set
			{
				this.gatedAPIFeatures = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x06000B66 RID: 2918 RVA: 0x0000DB5A File Offset: 0x0000BD5A
		// (set) Token: 0x06000B67 RID: 2919 RVA: 0x0000DB62 File Offset: 0x0000BD62
		[global::System.Runtime.Serialization.DataMember(Name = "gatedAPIFeatures", IsRequired = true)]
		internal string gatedAPIFeatures { get; set; }
	}
}
