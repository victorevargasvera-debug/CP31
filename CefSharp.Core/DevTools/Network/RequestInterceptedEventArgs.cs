using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x0200021C RID: 540
	[global::System.Runtime.Serialization.DataContract]
	public class RequestInterceptedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x06001089 RID: 4233 RVA: 0x00012157 File Offset: 0x00010357
		// (set) Token: 0x0600108A RID: 4234 RVA: 0x0001215F File Offset: 0x0001035F
		[global::System.Runtime.Serialization.DataMember(Name = "interceptionId", IsRequired = true)]
		public string InterceptionId { get; private set; }

		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x0600108B RID: 4235 RVA: 0x00012168 File Offset: 0x00010368
		// (set) Token: 0x0600108C RID: 4236 RVA: 0x00012170 File Offset: 0x00010370
		[global::System.Runtime.Serialization.DataMember(Name = "request", IsRequired = true)]
		public global::CefSharp.DevTools.Network.Request Request { get; private set; }

		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x0600108D RID: 4237 RVA: 0x00012179 File Offset: 0x00010379
		// (set) Token: 0x0600108E RID: 4238 RVA: 0x00012181 File Offset: 0x00010381
		[global::System.Runtime.Serialization.DataMember(Name = "frameId", IsRequired = true)]
		public string FrameId { get; private set; }

		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x0600108F RID: 4239 RVA: 0x0001218A File Offset: 0x0001038A
		// (set) Token: 0x06001090 RID: 4240 RVA: 0x000121A6 File Offset: 0x000103A6
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

		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x06001091 RID: 4241 RVA: 0x000121B9 File Offset: 0x000103B9
		// (set) Token: 0x06001092 RID: 4242 RVA: 0x000121C1 File Offset: 0x000103C1
		[global::System.Runtime.Serialization.DataMember(Name = "resourceType", IsRequired = true)]
		internal string resourceType { get; private set; }

		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x06001093 RID: 4243 RVA: 0x000121CA File Offset: 0x000103CA
		// (set) Token: 0x06001094 RID: 4244 RVA: 0x000121D2 File Offset: 0x000103D2
		[global::System.Runtime.Serialization.DataMember(Name = "isNavigationRequest", IsRequired = true)]
		public bool IsNavigationRequest { get; private set; }

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x06001095 RID: 4245 RVA: 0x000121DB File Offset: 0x000103DB
		// (set) Token: 0x06001096 RID: 4246 RVA: 0x000121E3 File Offset: 0x000103E3
		[global::System.Runtime.Serialization.DataMember(Name = "isDownload", IsRequired = false)]
		public bool? IsDownload { get; private set; }

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x06001097 RID: 4247 RVA: 0x000121EC File Offset: 0x000103EC
		// (set) Token: 0x06001098 RID: 4248 RVA: 0x000121F4 File Offset: 0x000103F4
		[global::System.Runtime.Serialization.DataMember(Name = "redirectUrl", IsRequired = false)]
		public string RedirectUrl { get; private set; }

		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x06001099 RID: 4249 RVA: 0x000121FD File Offset: 0x000103FD
		// (set) Token: 0x0600109A RID: 4250 RVA: 0x00012205 File Offset: 0x00010405
		[global::System.Runtime.Serialization.DataMember(Name = "authChallenge", IsRequired = false)]
		public global::CefSharp.DevTools.Network.AuthChallenge AuthChallenge { get; private set; }

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x0600109B RID: 4251 RVA: 0x0001220E File Offset: 0x0001040E
		// (set) Token: 0x0600109C RID: 4252 RVA: 0x0001222A File Offset: 0x0001042A
		public global::CefSharp.DevTools.Network.ErrorReason? ResponseErrorReason
		{
			get
			{
				return (global::CefSharp.DevTools.Network.ErrorReason?)global::CefSharp.DevTools.DevToolsDomainEventArgsBase.StringToEnum(typeof(global::CefSharp.DevTools.Network.ErrorReason?), this.responseErrorReason);
			}
			set
			{
				this.responseErrorReason = global::CefSharp.DevTools.DevToolsDomainEventArgsBase.EnumToString(value);
			}
		}

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x0600109D RID: 4253 RVA: 0x0001223D File Offset: 0x0001043D
		// (set) Token: 0x0600109E RID: 4254 RVA: 0x00012245 File Offset: 0x00010445
		[global::System.Runtime.Serialization.DataMember(Name = "responseErrorReason", IsRequired = false)]
		internal string responseErrorReason { get; private set; }

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x0600109F RID: 4255 RVA: 0x0001224E File Offset: 0x0001044E
		// (set) Token: 0x060010A0 RID: 4256 RVA: 0x00012256 File Offset: 0x00010456
		[global::System.Runtime.Serialization.DataMember(Name = "responseStatusCode", IsRequired = false)]
		public int? ResponseStatusCode { get; private set; }

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x060010A1 RID: 4257 RVA: 0x0001225F File Offset: 0x0001045F
		// (set) Token: 0x060010A2 RID: 4258 RVA: 0x00012267 File Offset: 0x00010467
		[global::System.Runtime.Serialization.DataMember(Name = "responseHeaders", IsRequired = false)]
		public global::CefSharp.DevTools.Network.Headers ResponseHeaders { get; private set; }

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x060010A3 RID: 4259 RVA: 0x00012270 File Offset: 0x00010470
		// (set) Token: 0x060010A4 RID: 4260 RVA: 0x00012278 File Offset: 0x00010478
		[global::System.Runtime.Serialization.DataMember(Name = "requestId", IsRequired = false)]
		public string RequestId { get; private set; }
	}
}
