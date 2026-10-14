using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x020001FB RID: 507
	[global::System.Runtime.Serialization.DataContract]
	public class BlockedSetCookieWithReason : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x06000F7E RID: 3966 RVA: 0x00011655 File Offset: 0x0000F855
		// (set) Token: 0x06000F7F RID: 3967 RVA: 0x00011671 File Offset: 0x0000F871
		public global::CefSharp.DevTools.Network.SetCookieBlockedReason[] BlockedReasons
		{
			get
			{
				return (global::CefSharp.DevTools.Network.SetCookieBlockedReason[])global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Network.SetCookieBlockedReason[]), this.blockedReasons);
			}
			set
			{
				this.blockedReasons = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x06000F80 RID: 3968 RVA: 0x0001167F File Offset: 0x0000F87F
		// (set) Token: 0x06000F81 RID: 3969 RVA: 0x00011687 File Offset: 0x0000F887
		[global::System.Runtime.Serialization.DataMember(Name = "blockedReasons", IsRequired = true)]
		internal string blockedReasons { get; set; }

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x06000F82 RID: 3970 RVA: 0x00011690 File Offset: 0x0000F890
		// (set) Token: 0x06000F83 RID: 3971 RVA: 0x00011698 File Offset: 0x0000F898
		[global::System.Runtime.Serialization.DataMember(Name = "cookieLine", IsRequired = true)]
		public string CookieLine { get; set; }

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x06000F84 RID: 3972 RVA: 0x000116A1 File Offset: 0x0000F8A1
		// (set) Token: 0x06000F85 RID: 3973 RVA: 0x000116A9 File Offset: 0x0000F8A9
		[global::System.Runtime.Serialization.DataMember(Name = "cookie", IsRequired = false)]
		public global::CefSharp.DevTools.Network.Cookie Cookie { get; set; }
	}
}
