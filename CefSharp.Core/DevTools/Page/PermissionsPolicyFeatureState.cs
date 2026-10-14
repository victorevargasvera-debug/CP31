using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Page
{
	// Token: 0x0200016B RID: 363
	[global::System.Runtime.Serialization.DataContract]
	public class PermissionsPolicyFeatureState : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x06000B1C RID: 2844 RVA: 0x0000D81A File Offset: 0x0000BA1A
		// (set) Token: 0x06000B1D RID: 2845 RVA: 0x0000D836 File Offset: 0x0000BA36
		public global::CefSharp.DevTools.Page.PermissionsPolicyFeature Feature
		{
			get
			{
				return (global::CefSharp.DevTools.Page.PermissionsPolicyFeature)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Page.PermissionsPolicyFeature), this.feature);
			}
			set
			{
				this.feature = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x06000B1E RID: 2846 RVA: 0x0000D849 File Offset: 0x0000BA49
		// (set) Token: 0x06000B1F RID: 2847 RVA: 0x0000D851 File Offset: 0x0000BA51
		[global::System.Runtime.Serialization.DataMember(Name = "feature", IsRequired = true)]
		internal string feature { get; set; }

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x06000B20 RID: 2848 RVA: 0x0000D85A File Offset: 0x0000BA5A
		// (set) Token: 0x06000B21 RID: 2849 RVA: 0x0000D862 File Offset: 0x0000BA62
		[global::System.Runtime.Serialization.DataMember(Name = "allowed", IsRequired = true)]
		public bool Allowed { get; set; }

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x06000B22 RID: 2850 RVA: 0x0000D86B File Offset: 0x0000BA6B
		// (set) Token: 0x06000B23 RID: 2851 RVA: 0x0000D873 File Offset: 0x0000BA73
		[global::System.Runtime.Serialization.DataMember(Name = "locator", IsRequired = false)]
		public global::CefSharp.DevTools.Page.PermissionsPolicyBlockLocator Locator { get; set; }
	}
}
