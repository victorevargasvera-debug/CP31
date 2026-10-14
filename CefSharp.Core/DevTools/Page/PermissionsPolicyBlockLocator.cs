using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Page
{
	// Token: 0x0200016A RID: 362
	[global::System.Runtime.Serialization.DataContract]
	public class PermissionsPolicyBlockLocator : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06000B15 RID: 2837 RVA: 0x0000D7C1 File Offset: 0x0000B9C1
		// (set) Token: 0x06000B16 RID: 2838 RVA: 0x0000D7C9 File Offset: 0x0000B9C9
		[global::System.Runtime.Serialization.DataMember(Name = "frameId", IsRequired = true)]
		public string FrameId { get; set; }

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x06000B17 RID: 2839 RVA: 0x0000D7D2 File Offset: 0x0000B9D2
		// (set) Token: 0x06000B18 RID: 2840 RVA: 0x0000D7EE File Offset: 0x0000B9EE
		public global::CefSharp.DevTools.Page.PermissionsPolicyBlockReason BlockReason
		{
			get
			{
				return (global::CefSharp.DevTools.Page.PermissionsPolicyBlockReason)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Page.PermissionsPolicyBlockReason), this.blockReason);
			}
			set
			{
				this.blockReason = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x06000B19 RID: 2841 RVA: 0x0000D801 File Offset: 0x0000BA01
		// (set) Token: 0x06000B1A RID: 2842 RVA: 0x0000D809 File Offset: 0x0000BA09
		[global::System.Runtime.Serialization.DataMember(Name = "blockReason", IsRequired = true)]
		internal string blockReason { get; set; }
	}
}
