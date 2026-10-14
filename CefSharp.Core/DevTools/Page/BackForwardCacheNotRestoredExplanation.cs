using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Page
{
	// Token: 0x0200018C RID: 396
	[global::System.Runtime.Serialization.DataContract]
	public class BackForwardCacheNotRestoredExplanation : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x06000BFB RID: 3067 RVA: 0x0000E08F File Offset: 0x0000C28F
		// (set) Token: 0x06000BFC RID: 3068 RVA: 0x0000E0AB File Offset: 0x0000C2AB
		public global::CefSharp.DevTools.Page.BackForwardCacheNotRestoredReasonType Type
		{
			get
			{
				return (global::CefSharp.DevTools.Page.BackForwardCacheNotRestoredReasonType)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Page.BackForwardCacheNotRestoredReasonType), this.type);
			}
			set
			{
				this.type = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x06000BFD RID: 3069 RVA: 0x0000E0BE File Offset: 0x0000C2BE
		// (set) Token: 0x06000BFE RID: 3070 RVA: 0x0000E0C6 File Offset: 0x0000C2C6
		[global::System.Runtime.Serialization.DataMember(Name = "type", IsRequired = true)]
		internal string type { get; set; }

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x06000BFF RID: 3071 RVA: 0x0000E0CF File Offset: 0x0000C2CF
		// (set) Token: 0x06000C00 RID: 3072 RVA: 0x0000E0EB File Offset: 0x0000C2EB
		public global::CefSharp.DevTools.Page.BackForwardCacheNotRestoredReason Reason
		{
			get
			{
				return (global::CefSharp.DevTools.Page.BackForwardCacheNotRestoredReason)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Page.BackForwardCacheNotRestoredReason), this.reason);
			}
			set
			{
				this.reason = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x06000C01 RID: 3073 RVA: 0x0000E0FE File Offset: 0x0000C2FE
		// (set) Token: 0x06000C02 RID: 3074 RVA: 0x0000E106 File Offset: 0x0000C306
		[global::System.Runtime.Serialization.DataMember(Name = "reason", IsRequired = true)]
		internal string reason { get; set; }

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x06000C03 RID: 3075 RVA: 0x0000E10F File Offset: 0x0000C30F
		// (set) Token: 0x06000C04 RID: 3076 RVA: 0x0000E117 File Offset: 0x0000C317
		[global::System.Runtime.Serialization.DataMember(Name = "context", IsRequired = false)]
		public string Context { get; set; }
	}
}
