using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.WebAuthn
{
	// Token: 0x020000C2 RID: 194
	[global::System.Runtime.Serialization.DataContract]
	public class VirtualAuthenticatorOptions : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06000666 RID: 1638 RVA: 0x000091AC File Offset: 0x000073AC
		// (set) Token: 0x06000667 RID: 1639 RVA: 0x000091C8 File Offset: 0x000073C8
		public global::CefSharp.DevTools.WebAuthn.AuthenticatorProtocol Protocol
		{
			get
			{
				return (global::CefSharp.DevTools.WebAuthn.AuthenticatorProtocol)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.WebAuthn.AuthenticatorProtocol), this.protocol);
			}
			set
			{
				this.protocol = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06000668 RID: 1640 RVA: 0x000091DB File Offset: 0x000073DB
		// (set) Token: 0x06000669 RID: 1641 RVA: 0x000091E3 File Offset: 0x000073E3
		[global::System.Runtime.Serialization.DataMember(Name = "protocol", IsRequired = true)]
		internal string protocol { get; set; }

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x0600066A RID: 1642 RVA: 0x000091EC File Offset: 0x000073EC
		// (set) Token: 0x0600066B RID: 1643 RVA: 0x00009208 File Offset: 0x00007408
		public global::CefSharp.DevTools.WebAuthn.Ctap2Version? Ctap2Version
		{
			get
			{
				return (global::CefSharp.DevTools.WebAuthn.Ctap2Version?)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.WebAuthn.Ctap2Version?), this.ctap2Version);
			}
			set
			{
				this.ctap2Version = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x0600066C RID: 1644 RVA: 0x0000921B File Offset: 0x0000741B
		// (set) Token: 0x0600066D RID: 1645 RVA: 0x00009223 File Offset: 0x00007423
		[global::System.Runtime.Serialization.DataMember(Name = "ctap2Version", IsRequired = false)]
		internal string ctap2Version { get; set; }

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x0600066E RID: 1646 RVA: 0x0000922C File Offset: 0x0000742C
		// (set) Token: 0x0600066F RID: 1647 RVA: 0x00009248 File Offset: 0x00007448
		public global::CefSharp.DevTools.WebAuthn.AuthenticatorTransport Transport
		{
			get
			{
				return (global::CefSharp.DevTools.WebAuthn.AuthenticatorTransport)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.WebAuthn.AuthenticatorTransport), this.transport);
			}
			set
			{
				this.transport = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x06000670 RID: 1648 RVA: 0x0000925B File Offset: 0x0000745B
		// (set) Token: 0x06000671 RID: 1649 RVA: 0x00009263 File Offset: 0x00007463
		[global::System.Runtime.Serialization.DataMember(Name = "transport", IsRequired = true)]
		internal string transport { get; set; }

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06000672 RID: 1650 RVA: 0x0000926C File Offset: 0x0000746C
		// (set) Token: 0x06000673 RID: 1651 RVA: 0x00009274 File Offset: 0x00007474
		[global::System.Runtime.Serialization.DataMember(Name = "hasResidentKey", IsRequired = false)]
		public bool? HasResidentKey { get; set; }

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x06000674 RID: 1652 RVA: 0x0000927D File Offset: 0x0000747D
		// (set) Token: 0x06000675 RID: 1653 RVA: 0x00009285 File Offset: 0x00007485
		[global::System.Runtime.Serialization.DataMember(Name = "hasUserVerification", IsRequired = false)]
		public bool? HasUserVerification { get; set; }

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06000676 RID: 1654 RVA: 0x0000928E File Offset: 0x0000748E
		// (set) Token: 0x06000677 RID: 1655 RVA: 0x00009296 File Offset: 0x00007496
		[global::System.Runtime.Serialization.DataMember(Name = "hasLargeBlob", IsRequired = false)]
		public bool? HasLargeBlob { get; set; }

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06000678 RID: 1656 RVA: 0x0000929F File Offset: 0x0000749F
		// (set) Token: 0x06000679 RID: 1657 RVA: 0x000092A7 File Offset: 0x000074A7
		[global::System.Runtime.Serialization.DataMember(Name = "hasCredBlob", IsRequired = false)]
		public bool? HasCredBlob { get; set; }

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x0600067A RID: 1658 RVA: 0x000092B0 File Offset: 0x000074B0
		// (set) Token: 0x0600067B RID: 1659 RVA: 0x000092B8 File Offset: 0x000074B8
		[global::System.Runtime.Serialization.DataMember(Name = "hasMinPinLength", IsRequired = false)]
		public bool? HasMinPinLength { get; set; }

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x0600067C RID: 1660 RVA: 0x000092C1 File Offset: 0x000074C1
		// (set) Token: 0x0600067D RID: 1661 RVA: 0x000092C9 File Offset: 0x000074C9
		[global::System.Runtime.Serialization.DataMember(Name = "hasPrf", IsRequired = false)]
		public bool? HasPrf { get; set; }

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x0600067E RID: 1662 RVA: 0x000092D2 File Offset: 0x000074D2
		// (set) Token: 0x0600067F RID: 1663 RVA: 0x000092DA File Offset: 0x000074DA
		[global::System.Runtime.Serialization.DataMember(Name = "automaticPresenceSimulation", IsRequired = false)]
		public bool? AutomaticPresenceSimulation { get; set; }

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x06000680 RID: 1664 RVA: 0x000092E3 File Offset: 0x000074E3
		// (set) Token: 0x06000681 RID: 1665 RVA: 0x000092EB File Offset: 0x000074EB
		[global::System.Runtime.Serialization.DataMember(Name = "isUserVerified", IsRequired = false)]
		public bool? IsUserVerified { get; set; }
	}
}
