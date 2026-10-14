using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.ServiceWorker
{
	// Token: 0x02000143 RID: 323
	[global::System.Runtime.Serialization.DataContract]
	public class ServiceWorkerVersion : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06000A05 RID: 2565 RVA: 0x0000C9BB File Offset: 0x0000ABBB
		// (set) Token: 0x06000A06 RID: 2566 RVA: 0x0000C9C3 File Offset: 0x0000ABC3
		[global::System.Runtime.Serialization.DataMember(Name = "versionId", IsRequired = true)]
		public string VersionId { get; set; }

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06000A07 RID: 2567 RVA: 0x0000C9CC File Offset: 0x0000ABCC
		// (set) Token: 0x06000A08 RID: 2568 RVA: 0x0000C9D4 File Offset: 0x0000ABD4
		[global::System.Runtime.Serialization.DataMember(Name = "registrationId", IsRequired = true)]
		public string RegistrationId { get; set; }

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06000A09 RID: 2569 RVA: 0x0000C9DD File Offset: 0x0000ABDD
		// (set) Token: 0x06000A0A RID: 2570 RVA: 0x0000C9E5 File Offset: 0x0000ABE5
		[global::System.Runtime.Serialization.DataMember(Name = "scriptURL", IsRequired = true)]
		public string ScriptURL { get; set; }

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06000A0B RID: 2571 RVA: 0x0000C9EE File Offset: 0x0000ABEE
		// (set) Token: 0x06000A0C RID: 2572 RVA: 0x0000CA0A File Offset: 0x0000AC0A
		public global::CefSharp.DevTools.ServiceWorker.ServiceWorkerVersionRunningStatus RunningStatus
		{
			get
			{
				return (global::CefSharp.DevTools.ServiceWorker.ServiceWorkerVersionRunningStatus)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.ServiceWorker.ServiceWorkerVersionRunningStatus), this.runningStatus);
			}
			set
			{
				this.runningStatus = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06000A0D RID: 2573 RVA: 0x0000CA1D File Offset: 0x0000AC1D
		// (set) Token: 0x06000A0E RID: 2574 RVA: 0x0000CA25 File Offset: 0x0000AC25
		[global::System.Runtime.Serialization.DataMember(Name = "runningStatus", IsRequired = true)]
		internal string runningStatus { get; set; }

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06000A0F RID: 2575 RVA: 0x0000CA2E File Offset: 0x0000AC2E
		// (set) Token: 0x06000A10 RID: 2576 RVA: 0x0000CA4A File Offset: 0x0000AC4A
		public global::CefSharp.DevTools.ServiceWorker.ServiceWorkerVersionStatus Status
		{
			get
			{
				return (global::CefSharp.DevTools.ServiceWorker.ServiceWorkerVersionStatus)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.ServiceWorker.ServiceWorkerVersionStatus), this.status);
			}
			set
			{
				this.status = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06000A11 RID: 2577 RVA: 0x0000CA5D File Offset: 0x0000AC5D
		// (set) Token: 0x06000A12 RID: 2578 RVA: 0x0000CA65 File Offset: 0x0000AC65
		[global::System.Runtime.Serialization.DataMember(Name = "status", IsRequired = true)]
		internal string status { get; set; }

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06000A13 RID: 2579 RVA: 0x0000CA6E File Offset: 0x0000AC6E
		// (set) Token: 0x06000A14 RID: 2580 RVA: 0x0000CA76 File Offset: 0x0000AC76
		[global::System.Runtime.Serialization.DataMember(Name = "scriptLastModified", IsRequired = false)]
		public double? ScriptLastModified { get; set; }

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06000A15 RID: 2581 RVA: 0x0000CA7F File Offset: 0x0000AC7F
		// (set) Token: 0x06000A16 RID: 2582 RVA: 0x0000CA87 File Offset: 0x0000AC87
		[global::System.Runtime.Serialization.DataMember(Name = "scriptResponseTime", IsRequired = false)]
		public double? ScriptResponseTime { get; set; }

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06000A17 RID: 2583 RVA: 0x0000CA90 File Offset: 0x0000AC90
		// (set) Token: 0x06000A18 RID: 2584 RVA: 0x0000CA98 File Offset: 0x0000AC98
		[global::System.Runtime.Serialization.DataMember(Name = "controlledClients", IsRequired = false)]
		public string[] ControlledClients { get; set; }

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06000A19 RID: 2585 RVA: 0x0000CAA1 File Offset: 0x0000ACA1
		// (set) Token: 0x06000A1A RID: 2586 RVA: 0x0000CAA9 File Offset: 0x0000ACA9
		[global::System.Runtime.Serialization.DataMember(Name = "targetId", IsRequired = false)]
		public string TargetId { get; set; }
	}
}
