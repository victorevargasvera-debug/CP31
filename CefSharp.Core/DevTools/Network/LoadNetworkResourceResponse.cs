using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x02000240 RID: 576
	[global::System.Runtime.Serialization.DataContract]
	public class LoadNetworkResourceResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x060011A7 RID: 4519 RVA: 0x00012BAF File Offset: 0x00010DAF
		// (set) Token: 0x060011A8 RID: 4520 RVA: 0x00012BB7 File Offset: 0x00010DB7
		[global::System.Runtime.Serialization.DataMember]
		internal global::CefSharp.DevTools.Network.LoadNetworkResourcePageResult resource { get; set; }

		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x060011A9 RID: 4521 RVA: 0x00012BC0 File Offset: 0x00010DC0
		public global::CefSharp.DevTools.Network.LoadNetworkResourcePageResult Resource
		{
			get
			{
				return this.resource;
			}
		}
	}
}
