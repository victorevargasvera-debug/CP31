using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x020001EE RID: 494
	[global::System.Runtime.Serialization.DataContract]
	public class TrustTokenParams : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x06000EE4 RID: 3812 RVA: 0x00011010 File Offset: 0x0000F210
		// (set) Token: 0x06000EE5 RID: 3813 RVA: 0x0001102C File Offset: 0x0000F22C
		public global::CefSharp.DevTools.Network.TrustTokenOperationType Operation
		{
			get
			{
				return (global::CefSharp.DevTools.Network.TrustTokenOperationType)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Network.TrustTokenOperationType), this.operation);
			}
			set
			{
				this.operation = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x06000EE6 RID: 3814 RVA: 0x0001103F File Offset: 0x0000F23F
		// (set) Token: 0x06000EE7 RID: 3815 RVA: 0x00011047 File Offset: 0x0000F247
		[global::System.Runtime.Serialization.DataMember(Name = "operation", IsRequired = true)]
		internal string operation { get; set; }

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x06000EE8 RID: 3816 RVA: 0x00011050 File Offset: 0x0000F250
		// (set) Token: 0x06000EE9 RID: 3817 RVA: 0x0001106C File Offset: 0x0000F26C
		public global::CefSharp.DevTools.Network.TrustTokenParamsRefreshPolicy RefreshPolicy
		{
			get
			{
				return (global::CefSharp.DevTools.Network.TrustTokenParamsRefreshPolicy)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Network.TrustTokenParamsRefreshPolicy), this.refreshPolicy);
			}
			set
			{
				this.refreshPolicy = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x06000EEA RID: 3818 RVA: 0x0001107F File Offset: 0x0000F27F
		// (set) Token: 0x06000EEB RID: 3819 RVA: 0x00011087 File Offset: 0x0000F287
		[global::System.Runtime.Serialization.DataMember(Name = "refreshPolicy", IsRequired = true)]
		internal string refreshPolicy { get; set; }

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x06000EEC RID: 3820 RVA: 0x00011090 File Offset: 0x0000F290
		// (set) Token: 0x06000EED RID: 3821 RVA: 0x00011098 File Offset: 0x0000F298
		[global::System.Runtime.Serialization.DataMember(Name = "issuers", IsRequired = false)]
		public string[] Issuers { get; set; }
	}
}
