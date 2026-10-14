using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.DOM
{
	// Token: 0x020002D8 RID: 728
	[global::System.Runtime.Serialization.DataContract]
	public class PushNodeByPathToFrontendResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170008AE RID: 2222
		// (get) Token: 0x06001630 RID: 5680 RVA: 0x00017E2F File Offset: 0x0001602F
		// (set) Token: 0x06001631 RID: 5681 RVA: 0x00017E37 File Offset: 0x00016037
		[global::System.Runtime.Serialization.DataMember]
		internal int nodeId { get; set; }

		// Token: 0x170008AF RID: 2223
		// (get) Token: 0x06001632 RID: 5682 RVA: 0x00017E40 File Offset: 0x00016040
		public int NodeId
		{
			get
			{
				return this.nodeId;
			}
		}
	}
}
