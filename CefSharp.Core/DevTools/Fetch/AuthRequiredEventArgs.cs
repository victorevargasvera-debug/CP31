using System;
using System.Runtime.Serialization;
using CefSharp.DevTools.Network;

namespace CefSharp.DevTools.Fetch
{
	// Token: 0x020000EB RID: 235
	[global::System.Runtime.Serialization.DataContract]
	public class AuthRequiredEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x170002DC RID: 732
		// (get) Token: 0x060007AC RID: 1964 RVA: 0x0000A268 File Offset: 0x00008468
		// (set) Token: 0x060007AD RID: 1965 RVA: 0x0000A270 File Offset: 0x00008470
		[global::System.Runtime.Serialization.DataMember(Name = "requestId", IsRequired = true)]
		public string RequestId { get; private set; }

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x060007AE RID: 1966 RVA: 0x0000A279 File Offset: 0x00008479
		// (set) Token: 0x060007AF RID: 1967 RVA: 0x0000A281 File Offset: 0x00008481
		[global::System.Runtime.Serialization.DataMember(Name = "request", IsRequired = true)]
		public global::CefSharp.DevTools.Network.Request Request { get; private set; }

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x060007B0 RID: 1968 RVA: 0x0000A28A File Offset: 0x0000848A
		// (set) Token: 0x060007B1 RID: 1969 RVA: 0x0000A292 File Offset: 0x00008492
		[global::System.Runtime.Serialization.DataMember(Name = "frameId", IsRequired = true)]
		public string FrameId { get; private set; }

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x060007B2 RID: 1970 RVA: 0x0000A29B File Offset: 0x0000849B
		// (set) Token: 0x060007B3 RID: 1971 RVA: 0x0000A2B7 File Offset: 0x000084B7
		public global::CefSharp.DevTools.Network.ResourceType ResourceType
		{
			get
			{
				return (global::CefSharp.DevTools.Network.ResourceType)global::CefSharp.DevTools.DevToolsDomainEventArgsBase.StringToEnum(typeof(global::CefSharp.DevTools.Network.ResourceType), this.resourceType);
			}
			set
			{
				this.resourceType = global::CefSharp.DevTools.DevToolsDomainEventArgsBase.EnumToString(value);
			}
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x060007B4 RID: 1972 RVA: 0x0000A2CA File Offset: 0x000084CA
		// (set) Token: 0x060007B5 RID: 1973 RVA: 0x0000A2D2 File Offset: 0x000084D2
		[global::System.Runtime.Serialization.DataMember(Name = "resourceType", IsRequired = true)]
		internal string resourceType { get; private set; }

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x060007B6 RID: 1974 RVA: 0x0000A2DB File Offset: 0x000084DB
		// (set) Token: 0x060007B7 RID: 1975 RVA: 0x0000A2E3 File Offset: 0x000084E3
		[global::System.Runtime.Serialization.DataMember(Name = "authChallenge", IsRequired = true)]
		public global::CefSharp.DevTools.Fetch.AuthChallenge AuthChallenge { get; private set; }
	}
}
