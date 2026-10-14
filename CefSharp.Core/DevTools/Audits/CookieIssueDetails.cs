using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Audits
{
	// Token: 0x0200034E RID: 846
	[global::System.Runtime.Serialization.DataContract]
	public class CookieIssueDetails : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000A00 RID: 2560
		// (get) Token: 0x0600199E RID: 6558 RVA: 0x0001B8B1 File Offset: 0x00019AB1
		// (set) Token: 0x0600199F RID: 6559 RVA: 0x0001B8B9 File Offset: 0x00019AB9
		[global::System.Runtime.Serialization.DataMember(Name = "cookie", IsRequired = false)]
		public global::CefSharp.DevTools.Audits.AffectedCookie Cookie { get; set; }

		// Token: 0x17000A01 RID: 2561
		// (get) Token: 0x060019A0 RID: 6560 RVA: 0x0001B8C2 File Offset: 0x00019AC2
		// (set) Token: 0x060019A1 RID: 6561 RVA: 0x0001B8CA File Offset: 0x00019ACA
		[global::System.Runtime.Serialization.DataMember(Name = "rawCookieLine", IsRequired = false)]
		public string RawCookieLine { get; set; }

		// Token: 0x17000A02 RID: 2562
		// (get) Token: 0x060019A2 RID: 6562 RVA: 0x0001B8D3 File Offset: 0x00019AD3
		// (set) Token: 0x060019A3 RID: 6563 RVA: 0x0001B8EF File Offset: 0x00019AEF
		public global::CefSharp.DevTools.Audits.CookieWarningReason[] CookieWarningReasons
		{
			get
			{
				return (global::CefSharp.DevTools.Audits.CookieWarningReason[])global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Audits.CookieWarningReason[]), this.cookieWarningReasons);
			}
			set
			{
				this.cookieWarningReasons = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x17000A03 RID: 2563
		// (get) Token: 0x060019A4 RID: 6564 RVA: 0x0001B8FD File Offset: 0x00019AFD
		// (set) Token: 0x060019A5 RID: 6565 RVA: 0x0001B905 File Offset: 0x00019B05
		[global::System.Runtime.Serialization.DataMember(Name = "cookieWarningReasons", IsRequired = true)]
		internal string cookieWarningReasons { get; set; }

		// Token: 0x17000A04 RID: 2564
		// (get) Token: 0x060019A6 RID: 6566 RVA: 0x0001B90E File Offset: 0x00019B0E
		// (set) Token: 0x060019A7 RID: 6567 RVA: 0x0001B92A File Offset: 0x00019B2A
		public global::CefSharp.DevTools.Audits.CookieExclusionReason[] CookieExclusionReasons
		{
			get
			{
				return (global::CefSharp.DevTools.Audits.CookieExclusionReason[])global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Audits.CookieExclusionReason[]), this.cookieExclusionReasons);
			}
			set
			{
				this.cookieExclusionReasons = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x17000A05 RID: 2565
		// (get) Token: 0x060019A8 RID: 6568 RVA: 0x0001B938 File Offset: 0x00019B38
		// (set) Token: 0x060019A9 RID: 6569 RVA: 0x0001B940 File Offset: 0x00019B40
		[global::System.Runtime.Serialization.DataMember(Name = "cookieExclusionReasons", IsRequired = true)]
		internal string cookieExclusionReasons { get; set; }

		// Token: 0x17000A06 RID: 2566
		// (get) Token: 0x060019AA RID: 6570 RVA: 0x0001B949 File Offset: 0x00019B49
		// (set) Token: 0x060019AB RID: 6571 RVA: 0x0001B965 File Offset: 0x00019B65
		public global::CefSharp.DevTools.Audits.CookieOperation Operation
		{
			get
			{
				return (global::CefSharp.DevTools.Audits.CookieOperation)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Audits.CookieOperation), this.operation);
			}
			set
			{
				this.operation = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x17000A07 RID: 2567
		// (get) Token: 0x060019AC RID: 6572 RVA: 0x0001B978 File Offset: 0x00019B78
		// (set) Token: 0x060019AD RID: 6573 RVA: 0x0001B980 File Offset: 0x00019B80
		[global::System.Runtime.Serialization.DataMember(Name = "operation", IsRequired = true)]
		internal string operation { get; set; }

		// Token: 0x17000A08 RID: 2568
		// (get) Token: 0x060019AE RID: 6574 RVA: 0x0001B989 File Offset: 0x00019B89
		// (set) Token: 0x060019AF RID: 6575 RVA: 0x0001B991 File Offset: 0x00019B91
		[global::System.Runtime.Serialization.DataMember(Name = "siteForCookies", IsRequired = false)]
		public string SiteForCookies { get; set; }

		// Token: 0x17000A09 RID: 2569
		// (get) Token: 0x060019B0 RID: 6576 RVA: 0x0001B99A File Offset: 0x00019B9A
		// (set) Token: 0x060019B1 RID: 6577 RVA: 0x0001B9A2 File Offset: 0x00019BA2
		[global::System.Runtime.Serialization.DataMember(Name = "cookieUrl", IsRequired = false)]
		public string CookieUrl { get; set; }

		// Token: 0x17000A0A RID: 2570
		// (get) Token: 0x060019B2 RID: 6578 RVA: 0x0001B9AB File Offset: 0x00019BAB
		// (set) Token: 0x060019B3 RID: 6579 RVA: 0x0001B9B3 File Offset: 0x00019BB3
		[global::System.Runtime.Serialization.DataMember(Name = "request", IsRequired = false)]
		public global::CefSharp.DevTools.Audits.AffectedRequest Request { get; set; }
	}
}
