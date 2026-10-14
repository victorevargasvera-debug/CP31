using System;
using System.Runtime.Serialization;
using CefSharp.DevTools.Security;

namespace CefSharp.DevTools.Network
{
	// Token: 0x020001F1 RID: 497
	[global::System.Runtime.Serialization.DataContract]
	public class Response : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x06000EEF RID: 3823 RVA: 0x000110A9 File Offset: 0x0000F2A9
		// (set) Token: 0x06000EF0 RID: 3824 RVA: 0x000110B1 File Offset: 0x0000F2B1
		[global::System.Runtime.Serialization.DataMember(Name = "url", IsRequired = true)]
		public string Url { get; set; }

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x06000EF1 RID: 3825 RVA: 0x000110BA File Offset: 0x0000F2BA
		// (set) Token: 0x06000EF2 RID: 3826 RVA: 0x000110C2 File Offset: 0x0000F2C2
		[global::System.Runtime.Serialization.DataMember(Name = "status", IsRequired = true)]
		public int Status { get; set; }

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x06000EF3 RID: 3827 RVA: 0x000110CB File Offset: 0x0000F2CB
		// (set) Token: 0x06000EF4 RID: 3828 RVA: 0x000110D3 File Offset: 0x0000F2D3
		[global::System.Runtime.Serialization.DataMember(Name = "statusText", IsRequired = true)]
		public string StatusText { get; set; }

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x06000EF5 RID: 3829 RVA: 0x000110DC File Offset: 0x0000F2DC
		// (set) Token: 0x06000EF6 RID: 3830 RVA: 0x000110E4 File Offset: 0x0000F2E4
		[global::System.Runtime.Serialization.DataMember(Name = "headers", IsRequired = true)]
		public global::CefSharp.DevTools.Network.Headers Headers { get; set; }

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x06000EF7 RID: 3831 RVA: 0x000110ED File Offset: 0x0000F2ED
		// (set) Token: 0x06000EF8 RID: 3832 RVA: 0x000110F5 File Offset: 0x0000F2F5
		[global::System.Runtime.Serialization.DataMember(Name = "headersText", IsRequired = false)]
		public string HeadersText { get; set; }

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x06000EF9 RID: 3833 RVA: 0x000110FE File Offset: 0x0000F2FE
		// (set) Token: 0x06000EFA RID: 3834 RVA: 0x00011106 File Offset: 0x0000F306
		[global::System.Runtime.Serialization.DataMember(Name = "mimeType", IsRequired = true)]
		public string MimeType { get; set; }

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x06000EFB RID: 3835 RVA: 0x0001110F File Offset: 0x0000F30F
		// (set) Token: 0x06000EFC RID: 3836 RVA: 0x00011117 File Offset: 0x0000F317
		[global::System.Runtime.Serialization.DataMember(Name = "requestHeaders", IsRequired = false)]
		public global::CefSharp.DevTools.Network.Headers RequestHeaders { get; set; }

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x06000EFD RID: 3837 RVA: 0x00011120 File Offset: 0x0000F320
		// (set) Token: 0x06000EFE RID: 3838 RVA: 0x00011128 File Offset: 0x0000F328
		[global::System.Runtime.Serialization.DataMember(Name = "requestHeadersText", IsRequired = false)]
		public string RequestHeadersText { get; set; }

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x06000EFF RID: 3839 RVA: 0x00011131 File Offset: 0x0000F331
		// (set) Token: 0x06000F00 RID: 3840 RVA: 0x00011139 File Offset: 0x0000F339
		[global::System.Runtime.Serialization.DataMember(Name = "connectionReused", IsRequired = true)]
		public bool ConnectionReused { get; set; }

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x06000F01 RID: 3841 RVA: 0x00011142 File Offset: 0x0000F342
		// (set) Token: 0x06000F02 RID: 3842 RVA: 0x0001114A File Offset: 0x0000F34A
		[global::System.Runtime.Serialization.DataMember(Name = "connectionId", IsRequired = true)]
		public double ConnectionId { get; set; }

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x06000F03 RID: 3843 RVA: 0x00011153 File Offset: 0x0000F353
		// (set) Token: 0x06000F04 RID: 3844 RVA: 0x0001115B File Offset: 0x0000F35B
		[global::System.Runtime.Serialization.DataMember(Name = "remoteIPAddress", IsRequired = false)]
		public string RemoteIPAddress { get; set; }

		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x06000F05 RID: 3845 RVA: 0x00011164 File Offset: 0x0000F364
		// (set) Token: 0x06000F06 RID: 3846 RVA: 0x0001116C File Offset: 0x0000F36C
		[global::System.Runtime.Serialization.DataMember(Name = "remotePort", IsRequired = false)]
		public int? RemotePort { get; set; }

		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x06000F07 RID: 3847 RVA: 0x00011175 File Offset: 0x0000F375
		// (set) Token: 0x06000F08 RID: 3848 RVA: 0x0001117D File Offset: 0x0000F37D
		[global::System.Runtime.Serialization.DataMember(Name = "fromDiskCache", IsRequired = false)]
		public bool? FromDiskCache { get; set; }

		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x06000F09 RID: 3849 RVA: 0x00011186 File Offset: 0x0000F386
		// (set) Token: 0x06000F0A RID: 3850 RVA: 0x0001118E File Offset: 0x0000F38E
		[global::System.Runtime.Serialization.DataMember(Name = "fromServiceWorker", IsRequired = false)]
		public bool? FromServiceWorker { get; set; }

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x06000F0B RID: 3851 RVA: 0x00011197 File Offset: 0x0000F397
		// (set) Token: 0x06000F0C RID: 3852 RVA: 0x0001119F File Offset: 0x0000F39F
		[global::System.Runtime.Serialization.DataMember(Name = "fromPrefetchCache", IsRequired = false)]
		public bool? FromPrefetchCache { get; set; }

		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x06000F0D RID: 3853 RVA: 0x000111A8 File Offset: 0x0000F3A8
		// (set) Token: 0x06000F0E RID: 3854 RVA: 0x000111B0 File Offset: 0x0000F3B0
		[global::System.Runtime.Serialization.DataMember(Name = "encodedDataLength", IsRequired = true)]
		public double EncodedDataLength { get; set; }

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x06000F0F RID: 3855 RVA: 0x000111B9 File Offset: 0x0000F3B9
		// (set) Token: 0x06000F10 RID: 3856 RVA: 0x000111C1 File Offset: 0x0000F3C1
		[global::System.Runtime.Serialization.DataMember(Name = "timing", IsRequired = false)]
		public global::CefSharp.DevTools.Network.ResourceTiming Timing { get; set; }

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x06000F11 RID: 3857 RVA: 0x000111CA File Offset: 0x0000F3CA
		// (set) Token: 0x06000F12 RID: 3858 RVA: 0x000111E6 File Offset: 0x0000F3E6
		public global::CefSharp.DevTools.Network.ServiceWorkerResponseSource? ServiceWorkerResponseSource
		{
			get
			{
				return (global::CefSharp.DevTools.Network.ServiceWorkerResponseSource?)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Network.ServiceWorkerResponseSource?), this.serviceWorkerResponseSource);
			}
			set
			{
				this.serviceWorkerResponseSource = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x06000F13 RID: 3859 RVA: 0x000111F9 File Offset: 0x0000F3F9
		// (set) Token: 0x06000F14 RID: 3860 RVA: 0x00011201 File Offset: 0x0000F401
		[global::System.Runtime.Serialization.DataMember(Name = "serviceWorkerResponseSource", IsRequired = false)]
		internal string serviceWorkerResponseSource { get; set; }

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x06000F15 RID: 3861 RVA: 0x0001120A File Offset: 0x0000F40A
		// (set) Token: 0x06000F16 RID: 3862 RVA: 0x00011212 File Offset: 0x0000F412
		[global::System.Runtime.Serialization.DataMember(Name = "responseTime", IsRequired = false)]
		public double? ResponseTime { get; set; }

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x06000F17 RID: 3863 RVA: 0x0001121B File Offset: 0x0000F41B
		// (set) Token: 0x06000F18 RID: 3864 RVA: 0x00011223 File Offset: 0x0000F423
		[global::System.Runtime.Serialization.DataMember(Name = "cacheStorageCacheName", IsRequired = false)]
		public string CacheStorageCacheName { get; set; }

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x06000F19 RID: 3865 RVA: 0x0001122C File Offset: 0x0000F42C
		// (set) Token: 0x06000F1A RID: 3866 RVA: 0x00011234 File Offset: 0x0000F434
		[global::System.Runtime.Serialization.DataMember(Name = "protocol", IsRequired = false)]
		public string Protocol { get; set; }

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x06000F1B RID: 3867 RVA: 0x0001123D File Offset: 0x0000F43D
		// (set) Token: 0x06000F1C RID: 3868 RVA: 0x00011259 File Offset: 0x0000F459
		public global::CefSharp.DevTools.Network.AlternateProtocolUsage? AlternateProtocolUsage
		{
			get
			{
				return (global::CefSharp.DevTools.Network.AlternateProtocolUsage?)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Network.AlternateProtocolUsage?), this.alternateProtocolUsage);
			}
			set
			{
				this.alternateProtocolUsage = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x06000F1D RID: 3869 RVA: 0x0001126C File Offset: 0x0000F46C
		// (set) Token: 0x06000F1E RID: 3870 RVA: 0x00011274 File Offset: 0x0000F474
		[global::System.Runtime.Serialization.DataMember(Name = "alternateProtocolUsage", IsRequired = false)]
		internal string alternateProtocolUsage { get; set; }

		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x06000F1F RID: 3871 RVA: 0x0001127D File Offset: 0x0000F47D
		// (set) Token: 0x06000F20 RID: 3872 RVA: 0x00011299 File Offset: 0x0000F499
		public global::CefSharp.DevTools.Security.SecurityState SecurityState
		{
			get
			{
				return (global::CefSharp.DevTools.Security.SecurityState)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Security.SecurityState), this.securityState);
			}
			set
			{
				this.securityState = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x06000F21 RID: 3873 RVA: 0x000112AC File Offset: 0x0000F4AC
		// (set) Token: 0x06000F22 RID: 3874 RVA: 0x000112B4 File Offset: 0x0000F4B4
		[global::System.Runtime.Serialization.DataMember(Name = "securityState", IsRequired = true)]
		internal string securityState { get; set; }

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x06000F23 RID: 3875 RVA: 0x000112BD File Offset: 0x0000F4BD
		// (set) Token: 0x06000F24 RID: 3876 RVA: 0x000112C5 File Offset: 0x0000F4C5
		[global::System.Runtime.Serialization.DataMember(Name = "securityDetails", IsRequired = false)]
		public global::CefSharp.DevTools.Network.SecurityDetails SecurityDetails { get; set; }
	}
}
