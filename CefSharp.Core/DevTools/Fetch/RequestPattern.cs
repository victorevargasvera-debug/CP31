using System;
using System.Runtime.Serialization;
using CefSharp.DevTools.Network;

namespace CefSharp.DevTools.Fetch
{
	// Token: 0x020000E4 RID: 228
	[global::System.Runtime.Serialization.DataContract]
	public class RequestPattern : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x0600076F RID: 1903 RVA: 0x00009FB0 File Offset: 0x000081B0
		// (set) Token: 0x06000770 RID: 1904 RVA: 0x00009FB8 File Offset: 0x000081B8
		[global::System.Runtime.Serialization.DataMember(Name = "urlPattern", IsRequired = false)]
		public string UrlPattern { get; set; }

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x06000771 RID: 1905 RVA: 0x00009FC1 File Offset: 0x000081C1
		// (set) Token: 0x06000772 RID: 1906 RVA: 0x00009FDD File Offset: 0x000081DD
		public global::CefSharp.DevTools.Network.ResourceType? ResourceType
		{
			get
			{
				return (global::CefSharp.DevTools.Network.ResourceType?)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Network.ResourceType?), this.resourceType);
			}
			set
			{
				this.resourceType = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x06000773 RID: 1907 RVA: 0x00009FF0 File Offset: 0x000081F0
		// (set) Token: 0x06000774 RID: 1908 RVA: 0x00009FF8 File Offset: 0x000081F8
		[global::System.Runtime.Serialization.DataMember(Name = "resourceType", IsRequired = false)]
		internal string resourceType { get; set; }

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x06000775 RID: 1909 RVA: 0x0000A001 File Offset: 0x00008201
		// (set) Token: 0x06000776 RID: 1910 RVA: 0x0000A01D File Offset: 0x0000821D
		public global::CefSharp.DevTools.Fetch.RequestStage? RequestStage
		{
			get
			{
				return (global::CefSharp.DevTools.Fetch.RequestStage?)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Fetch.RequestStage?), this.requestStage);
			}
			set
			{
				this.requestStage = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06000777 RID: 1911 RVA: 0x0000A030 File Offset: 0x00008230
		// (set) Token: 0x06000778 RID: 1912 RVA: 0x0000A038 File Offset: 0x00008238
		[global::System.Runtime.Serialization.DataMember(Name = "requestStage", IsRequired = false)]
		internal string requestStage { get; set; }
	}
}
