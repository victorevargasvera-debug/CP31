using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x0200020D RID: 525
	[global::System.Runtime.Serialization.DataContract]
	public class ClientSecurityState : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x06001003 RID: 4099 RVA: 0x00011BDC File Offset: 0x0000FDDC
		// (set) Token: 0x06001004 RID: 4100 RVA: 0x00011BE4 File Offset: 0x0000FDE4
		[global::System.Runtime.Serialization.DataMember(Name = "initiatorIsSecureContext", IsRequired = true)]
		public bool InitiatorIsSecureContext { get; set; }

		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x06001005 RID: 4101 RVA: 0x00011BED File Offset: 0x0000FDED
		// (set) Token: 0x06001006 RID: 4102 RVA: 0x00011C09 File Offset: 0x0000FE09
		public global::CefSharp.DevTools.Network.IPAddressSpace InitiatorIPAddressSpace
		{
			get
			{
				return (global::CefSharp.DevTools.Network.IPAddressSpace)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Network.IPAddressSpace), this.initiatorIPAddressSpace);
			}
			set
			{
				this.initiatorIPAddressSpace = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x06001007 RID: 4103 RVA: 0x00011C1C File Offset: 0x0000FE1C
		// (set) Token: 0x06001008 RID: 4104 RVA: 0x00011C24 File Offset: 0x0000FE24
		[global::System.Runtime.Serialization.DataMember(Name = "initiatorIPAddressSpace", IsRequired = true)]
		internal string initiatorIPAddressSpace { get; set; }

		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x06001009 RID: 4105 RVA: 0x00011C2D File Offset: 0x0000FE2D
		// (set) Token: 0x0600100A RID: 4106 RVA: 0x00011C49 File Offset: 0x0000FE49
		public global::CefSharp.DevTools.Network.PrivateNetworkRequestPolicy PrivateNetworkRequestPolicy
		{
			get
			{
				return (global::CefSharp.DevTools.Network.PrivateNetworkRequestPolicy)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Network.PrivateNetworkRequestPolicy), this.privateNetworkRequestPolicy);
			}
			set
			{
				this.privateNetworkRequestPolicy = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x0600100B RID: 4107 RVA: 0x00011C5C File Offset: 0x0000FE5C
		// (set) Token: 0x0600100C RID: 4108 RVA: 0x00011C64 File Offset: 0x0000FE64
		[global::System.Runtime.Serialization.DataMember(Name = "privateNetworkRequestPolicy", IsRequired = true)]
		internal string privateNetworkRequestPolicy { get; set; }
	}
}
