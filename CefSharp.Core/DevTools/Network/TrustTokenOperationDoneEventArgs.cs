using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x0200022F RID: 559
	[global::System.Runtime.Serialization.DataContract]
	public class TrustTokenOperationDoneEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x06001147 RID: 4423 RVA: 0x00012851 File Offset: 0x00010A51
		// (set) Token: 0x06001148 RID: 4424 RVA: 0x0001286D File Offset: 0x00010A6D
		public global::CefSharp.DevTools.Network.TrustTokenOperationDoneStatus Status
		{
			get
			{
				return (global::CefSharp.DevTools.Network.TrustTokenOperationDoneStatus)global::CefSharp.DevTools.DevToolsDomainEventArgsBase.StringToEnum(typeof(global::CefSharp.DevTools.Network.TrustTokenOperationDoneStatus), this.status);
			}
			set
			{
				this.status = global::CefSharp.DevTools.DevToolsDomainEventArgsBase.EnumToString(value);
			}
		}

		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x06001149 RID: 4425 RVA: 0x00012880 File Offset: 0x00010A80
		// (set) Token: 0x0600114A RID: 4426 RVA: 0x00012888 File Offset: 0x00010A88
		[global::System.Runtime.Serialization.DataMember(Name = "status", IsRequired = true)]
		internal string status { get; private set; }

		// Token: 0x170006CF RID: 1743
		// (get) Token: 0x0600114B RID: 4427 RVA: 0x00012891 File Offset: 0x00010A91
		// (set) Token: 0x0600114C RID: 4428 RVA: 0x000128AD File Offset: 0x00010AAD
		public global::CefSharp.DevTools.Network.TrustTokenOperationType Type
		{
			get
			{
				return (global::CefSharp.DevTools.Network.TrustTokenOperationType)global::CefSharp.DevTools.DevToolsDomainEventArgsBase.StringToEnum(typeof(global::CefSharp.DevTools.Network.TrustTokenOperationType), this.type);
			}
			set
			{
				this.type = global::CefSharp.DevTools.DevToolsDomainEventArgsBase.EnumToString(value);
			}
		}

		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x0600114D RID: 4429 RVA: 0x000128C0 File Offset: 0x00010AC0
		// (set) Token: 0x0600114E RID: 4430 RVA: 0x000128C8 File Offset: 0x00010AC8
		[global::System.Runtime.Serialization.DataMember(Name = "type", IsRequired = true)]
		internal string type { get; private set; }

		// Token: 0x170006D1 RID: 1745
		// (get) Token: 0x0600114F RID: 4431 RVA: 0x000128D1 File Offset: 0x00010AD1
		// (set) Token: 0x06001150 RID: 4432 RVA: 0x000128D9 File Offset: 0x00010AD9
		[global::System.Runtime.Serialization.DataMember(Name = "requestId", IsRequired = true)]
		public string RequestId { get; private set; }

		// Token: 0x170006D2 RID: 1746
		// (get) Token: 0x06001151 RID: 4433 RVA: 0x000128E2 File Offset: 0x00010AE2
		// (set) Token: 0x06001152 RID: 4434 RVA: 0x000128EA File Offset: 0x00010AEA
		[global::System.Runtime.Serialization.DataMember(Name = "topLevelOrigin", IsRequired = false)]
		public string TopLevelOrigin { get; private set; }

		// Token: 0x170006D3 RID: 1747
		// (get) Token: 0x06001153 RID: 4435 RVA: 0x000128F3 File Offset: 0x00010AF3
		// (set) Token: 0x06001154 RID: 4436 RVA: 0x000128FB File Offset: 0x00010AFB
		[global::System.Runtime.Serialization.DataMember(Name = "issuerOrigin", IsRequired = false)]
		public string IssuerOrigin { get; private set; }

		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x06001155 RID: 4437 RVA: 0x00012904 File Offset: 0x00010B04
		// (set) Token: 0x06001156 RID: 4438 RVA: 0x0001290C File Offset: 0x00010B0C
		[global::System.Runtime.Serialization.DataMember(Name = "issuedTokenCount", IsRequired = false)]
		public int? IssuedTokenCount { get; private set; }
	}
}
