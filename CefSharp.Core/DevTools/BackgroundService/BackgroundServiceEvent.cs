using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.BackgroundService
{
	// Token: 0x02000344 RID: 836
	[global::System.Runtime.Serialization.DataContract]
	public class BackgroundServiceEvent : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x170009ED RID: 2541
		// (get) Token: 0x06001969 RID: 6505 RVA: 0x0001B5A5 File Offset: 0x000197A5
		// (set) Token: 0x0600196A RID: 6506 RVA: 0x0001B5AD File Offset: 0x000197AD
		[global::System.Runtime.Serialization.DataMember(Name = "timestamp", IsRequired = true)]
		public double Timestamp { get; set; }

		// Token: 0x170009EE RID: 2542
		// (get) Token: 0x0600196B RID: 6507 RVA: 0x0001B5B6 File Offset: 0x000197B6
		// (set) Token: 0x0600196C RID: 6508 RVA: 0x0001B5BE File Offset: 0x000197BE
		[global::System.Runtime.Serialization.DataMember(Name = "origin", IsRequired = true)]
		public string Origin { get; set; }

		// Token: 0x170009EF RID: 2543
		// (get) Token: 0x0600196D RID: 6509 RVA: 0x0001B5C7 File Offset: 0x000197C7
		// (set) Token: 0x0600196E RID: 6510 RVA: 0x0001B5CF File Offset: 0x000197CF
		[global::System.Runtime.Serialization.DataMember(Name = "serviceWorkerRegistrationId", IsRequired = true)]
		public string ServiceWorkerRegistrationId { get; set; }

		// Token: 0x170009F0 RID: 2544
		// (get) Token: 0x0600196F RID: 6511 RVA: 0x0001B5D8 File Offset: 0x000197D8
		// (set) Token: 0x06001970 RID: 6512 RVA: 0x0001B5F4 File Offset: 0x000197F4
		public global::CefSharp.DevTools.BackgroundService.ServiceName Service
		{
			get
			{
				return (global::CefSharp.DevTools.BackgroundService.ServiceName)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.BackgroundService.ServiceName), this.service);
			}
			set
			{
				this.service = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x170009F1 RID: 2545
		// (get) Token: 0x06001971 RID: 6513 RVA: 0x0001B607 File Offset: 0x00019807
		// (set) Token: 0x06001972 RID: 6514 RVA: 0x0001B60F File Offset: 0x0001980F
		[global::System.Runtime.Serialization.DataMember(Name = "service", IsRequired = true)]
		internal string service { get; set; }

		// Token: 0x170009F2 RID: 2546
		// (get) Token: 0x06001973 RID: 6515 RVA: 0x0001B618 File Offset: 0x00019818
		// (set) Token: 0x06001974 RID: 6516 RVA: 0x0001B620 File Offset: 0x00019820
		[global::System.Runtime.Serialization.DataMember(Name = "eventName", IsRequired = true)]
		public string EventName { get; set; }

		// Token: 0x170009F3 RID: 2547
		// (get) Token: 0x06001975 RID: 6517 RVA: 0x0001B629 File Offset: 0x00019829
		// (set) Token: 0x06001976 RID: 6518 RVA: 0x0001B631 File Offset: 0x00019831
		[global::System.Runtime.Serialization.DataMember(Name = "instanceId", IsRequired = true)]
		public string InstanceId { get; set; }

		// Token: 0x170009F4 RID: 2548
		// (get) Token: 0x06001977 RID: 6519 RVA: 0x0001B63A File Offset: 0x0001983A
		// (set) Token: 0x06001978 RID: 6520 RVA: 0x0001B642 File Offset: 0x00019842
		[global::System.Runtime.Serialization.DataMember(Name = "eventMetadata", IsRequired = true)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.BackgroundService.EventMetadata> EventMetadata { get; set; }

		// Token: 0x170009F5 RID: 2549
		// (get) Token: 0x06001979 RID: 6521 RVA: 0x0001B64B File Offset: 0x0001984B
		// (set) Token: 0x0600197A RID: 6522 RVA: 0x0001B653 File Offset: 0x00019853
		[global::System.Runtime.Serialization.DataMember(Name = "storageKey", IsRequired = true)]
		public string StorageKey { get; set; }
	}
}
