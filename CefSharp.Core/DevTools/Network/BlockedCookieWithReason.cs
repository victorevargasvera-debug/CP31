using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x020001FC RID: 508
	[global::System.Runtime.Serialization.DataContract]
	public class BlockedCookieWithReason : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x06000F87 RID: 3975 RVA: 0x000116BA File Offset: 0x0000F8BA
		// (set) Token: 0x06000F88 RID: 3976 RVA: 0x000116D6 File Offset: 0x0000F8D6
		public global::CefSharp.DevTools.Network.CookieBlockedReason[] BlockedReasons
		{
			get
			{
				return (global::CefSharp.DevTools.Network.CookieBlockedReason[])global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Network.CookieBlockedReason[]), this.blockedReasons);
			}
			set
			{
				this.blockedReasons = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x06000F89 RID: 3977 RVA: 0x000116E4 File Offset: 0x0000F8E4
		// (set) Token: 0x06000F8A RID: 3978 RVA: 0x000116EC File Offset: 0x0000F8EC
		[global::System.Runtime.Serialization.DataMember(Name = "blockedReasons", IsRequired = true)]
		internal string blockedReasons { get; set; }

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x06000F8B RID: 3979 RVA: 0x000116F5 File Offset: 0x0000F8F5
		// (set) Token: 0x06000F8C RID: 3980 RVA: 0x000116FD File Offset: 0x0000F8FD
		[global::System.Runtime.Serialization.DataMember(Name = "cookie", IsRequired = true)]
		public global::CefSharp.DevTools.Network.Cookie Cookie { get; set; }
	}
}
