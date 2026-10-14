using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x020001E1 RID: 481
	[global::System.Runtime.Serialization.DataContract]
	public class ResourceTiming : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x06000E62 RID: 3682 RVA: 0x00010B2C File Offset: 0x0000ED2C
		// (set) Token: 0x06000E63 RID: 3683 RVA: 0x00010B34 File Offset: 0x0000ED34
		[global::System.Runtime.Serialization.DataMember(Name = "requestTime", IsRequired = true)]
		public double RequestTime { get; set; }

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x06000E64 RID: 3684 RVA: 0x00010B3D File Offset: 0x0000ED3D
		// (set) Token: 0x06000E65 RID: 3685 RVA: 0x00010B45 File Offset: 0x0000ED45
		[global::System.Runtime.Serialization.DataMember(Name = "proxyStart", IsRequired = true)]
		public double ProxyStart { get; set; }

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x06000E66 RID: 3686 RVA: 0x00010B4E File Offset: 0x0000ED4E
		// (set) Token: 0x06000E67 RID: 3687 RVA: 0x00010B56 File Offset: 0x0000ED56
		[global::System.Runtime.Serialization.DataMember(Name = "proxyEnd", IsRequired = true)]
		public double ProxyEnd { get; set; }

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x06000E68 RID: 3688 RVA: 0x00010B5F File Offset: 0x0000ED5F
		// (set) Token: 0x06000E69 RID: 3689 RVA: 0x00010B67 File Offset: 0x0000ED67
		[global::System.Runtime.Serialization.DataMember(Name = "dnsStart", IsRequired = true)]
		public double DnsStart { get; set; }

		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x06000E6A RID: 3690 RVA: 0x00010B70 File Offset: 0x0000ED70
		// (set) Token: 0x06000E6B RID: 3691 RVA: 0x00010B78 File Offset: 0x0000ED78
		[global::System.Runtime.Serialization.DataMember(Name = "dnsEnd", IsRequired = true)]
		public double DnsEnd { get; set; }

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x06000E6C RID: 3692 RVA: 0x00010B81 File Offset: 0x0000ED81
		// (set) Token: 0x06000E6D RID: 3693 RVA: 0x00010B89 File Offset: 0x0000ED89
		[global::System.Runtime.Serialization.DataMember(Name = "connectStart", IsRequired = true)]
		public double ConnectStart { get; set; }

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x06000E6E RID: 3694 RVA: 0x00010B92 File Offset: 0x0000ED92
		// (set) Token: 0x06000E6F RID: 3695 RVA: 0x00010B9A File Offset: 0x0000ED9A
		[global::System.Runtime.Serialization.DataMember(Name = "connectEnd", IsRequired = true)]
		public double ConnectEnd { get; set; }

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x06000E70 RID: 3696 RVA: 0x00010BA3 File Offset: 0x0000EDA3
		// (set) Token: 0x06000E71 RID: 3697 RVA: 0x00010BAB File Offset: 0x0000EDAB
		[global::System.Runtime.Serialization.DataMember(Name = "sslStart", IsRequired = true)]
		public double SslStart { get; set; }

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x06000E72 RID: 3698 RVA: 0x00010BB4 File Offset: 0x0000EDB4
		// (set) Token: 0x06000E73 RID: 3699 RVA: 0x00010BBC File Offset: 0x0000EDBC
		[global::System.Runtime.Serialization.DataMember(Name = "sslEnd", IsRequired = true)]
		public double SslEnd { get; set; }

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x06000E74 RID: 3700 RVA: 0x00010BC5 File Offset: 0x0000EDC5
		// (set) Token: 0x06000E75 RID: 3701 RVA: 0x00010BCD File Offset: 0x0000EDCD
		[global::System.Runtime.Serialization.DataMember(Name = "workerStart", IsRequired = true)]
		public double WorkerStart { get; set; }

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x06000E76 RID: 3702 RVA: 0x00010BD6 File Offset: 0x0000EDD6
		// (set) Token: 0x06000E77 RID: 3703 RVA: 0x00010BDE File Offset: 0x0000EDDE
		[global::System.Runtime.Serialization.DataMember(Name = "workerReady", IsRequired = true)]
		public double WorkerReady { get; set; }

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x06000E78 RID: 3704 RVA: 0x00010BE7 File Offset: 0x0000EDE7
		// (set) Token: 0x06000E79 RID: 3705 RVA: 0x00010BEF File Offset: 0x0000EDEF
		[global::System.Runtime.Serialization.DataMember(Name = "workerFetchStart", IsRequired = true)]
		public double WorkerFetchStart { get; set; }

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x06000E7A RID: 3706 RVA: 0x00010BF8 File Offset: 0x0000EDF8
		// (set) Token: 0x06000E7B RID: 3707 RVA: 0x00010C00 File Offset: 0x0000EE00
		[global::System.Runtime.Serialization.DataMember(Name = "workerRespondWithSettled", IsRequired = true)]
		public double WorkerRespondWithSettled { get; set; }

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x06000E7C RID: 3708 RVA: 0x00010C09 File Offset: 0x0000EE09
		// (set) Token: 0x06000E7D RID: 3709 RVA: 0x00010C11 File Offset: 0x0000EE11
		[global::System.Runtime.Serialization.DataMember(Name = "sendStart", IsRequired = true)]
		public double SendStart { get; set; }

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x06000E7E RID: 3710 RVA: 0x00010C1A File Offset: 0x0000EE1A
		// (set) Token: 0x06000E7F RID: 3711 RVA: 0x00010C22 File Offset: 0x0000EE22
		[global::System.Runtime.Serialization.DataMember(Name = "sendEnd", IsRequired = true)]
		public double SendEnd { get; set; }

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x06000E80 RID: 3712 RVA: 0x00010C2B File Offset: 0x0000EE2B
		// (set) Token: 0x06000E81 RID: 3713 RVA: 0x00010C33 File Offset: 0x0000EE33
		[global::System.Runtime.Serialization.DataMember(Name = "pushStart", IsRequired = true)]
		public double PushStart { get; set; }

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x06000E82 RID: 3714 RVA: 0x00010C3C File Offset: 0x0000EE3C
		// (set) Token: 0x06000E83 RID: 3715 RVA: 0x00010C44 File Offset: 0x0000EE44
		[global::System.Runtime.Serialization.DataMember(Name = "pushEnd", IsRequired = true)]
		public double PushEnd { get; set; }

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x06000E84 RID: 3716 RVA: 0x00010C4D File Offset: 0x0000EE4D
		// (set) Token: 0x06000E85 RID: 3717 RVA: 0x00010C55 File Offset: 0x0000EE55
		[global::System.Runtime.Serialization.DataMember(Name = "receiveHeadersEnd", IsRequired = true)]
		public double ReceiveHeadersEnd { get; set; }
	}
}
