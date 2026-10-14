using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using CefSharp.DevTools.Network;

namespace CefSharp.DevTools.Fetch
{
	// Token: 0x020000EA RID: 234
	[global::System.Runtime.Serialization.DataContract]
	public class RequestPausedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06000793 RID: 1939 RVA: 0x0000A158 File Offset: 0x00008358
		// (set) Token: 0x06000794 RID: 1940 RVA: 0x0000A160 File Offset: 0x00008360
		[global::System.Runtime.Serialization.DataMember(Name = "requestId", IsRequired = true)]
		public string RequestId { get; private set; }

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06000795 RID: 1941 RVA: 0x0000A169 File Offset: 0x00008369
		// (set) Token: 0x06000796 RID: 1942 RVA: 0x0000A171 File Offset: 0x00008371
		[global::System.Runtime.Serialization.DataMember(Name = "request", IsRequired = true)]
		public global::CefSharp.DevTools.Network.Request Request { get; private set; }

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06000797 RID: 1943 RVA: 0x0000A17A File Offset: 0x0000837A
		// (set) Token: 0x06000798 RID: 1944 RVA: 0x0000A182 File Offset: 0x00008382
		[global::System.Runtime.Serialization.DataMember(Name = "frameId", IsRequired = true)]
		public string FrameId { get; private set; }

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06000799 RID: 1945 RVA: 0x0000A18B File Offset: 0x0000838B
		// (set) Token: 0x0600079A RID: 1946 RVA: 0x0000A1A7 File Offset: 0x000083A7
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

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x0600079B RID: 1947 RVA: 0x0000A1BA File Offset: 0x000083BA
		// (set) Token: 0x0600079C RID: 1948 RVA: 0x0000A1C2 File Offset: 0x000083C2
		[global::System.Runtime.Serialization.DataMember(Name = "resourceType", IsRequired = true)]
		internal string resourceType { get; private set; }

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x0600079D RID: 1949 RVA: 0x0000A1CB File Offset: 0x000083CB
		// (set) Token: 0x0600079E RID: 1950 RVA: 0x0000A1E7 File Offset: 0x000083E7
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

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x0600079F RID: 1951 RVA: 0x0000A1FA File Offset: 0x000083FA
		// (set) Token: 0x060007A0 RID: 1952 RVA: 0x0000A202 File Offset: 0x00008402
		[global::System.Runtime.Serialization.DataMember(Name = "responseErrorReason", IsRequired = false)]
		internal string responseErrorReason { get; private set; }

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x060007A1 RID: 1953 RVA: 0x0000A20B File Offset: 0x0000840B
		// (set) Token: 0x060007A2 RID: 1954 RVA: 0x0000A213 File Offset: 0x00008413
		[global::System.Runtime.Serialization.DataMember(Name = "responseStatusCode", IsRequired = false)]
		public int? ResponseStatusCode { get; private set; }

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x060007A3 RID: 1955 RVA: 0x0000A21C File Offset: 0x0000841C
		// (set) Token: 0x060007A4 RID: 1956 RVA: 0x0000A224 File Offset: 0x00008424
		[global::System.Runtime.Serialization.DataMember(Name = "responseStatusText", IsRequired = false)]
		public string ResponseStatusText { get; private set; }

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x060007A5 RID: 1957 RVA: 0x0000A22D File Offset: 0x0000842D
		// (set) Token: 0x060007A6 RID: 1958 RVA: 0x0000A235 File Offset: 0x00008435
		[global::System.Runtime.Serialization.DataMember(Name = "responseHeaders", IsRequired = false)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.Fetch.HeaderEntry> ResponseHeaders { get; private set; }

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x060007A7 RID: 1959 RVA: 0x0000A23E File Offset: 0x0000843E
		// (set) Token: 0x060007A8 RID: 1960 RVA: 0x0000A246 File Offset: 0x00008446
		[global::System.Runtime.Serialization.DataMember(Name = "networkId", IsRequired = false)]
		public string NetworkId { get; private set; }

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x060007A9 RID: 1961 RVA: 0x0000A24F File Offset: 0x0000844F
		// (set) Token: 0x060007AA RID: 1962 RVA: 0x0000A257 File Offset: 0x00008457
		[global::System.Runtime.Serialization.DataMember(Name = "redirectedRequestId", IsRequired = false)]
		public string RedirectedRequestId { get; private set; }
	}
}
