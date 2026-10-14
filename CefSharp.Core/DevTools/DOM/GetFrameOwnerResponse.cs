using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.DOM
{
	// Token: 0x020002E2 RID: 738
	[global::System.Runtime.Serialization.DataContract]
	public class GetFrameOwnerResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170008C2 RID: 2242
		// (get) Token: 0x06001658 RID: 5720 RVA: 0x00017F79 File Offset: 0x00016179
		// (set) Token: 0x06001659 RID: 5721 RVA: 0x00017F81 File Offset: 0x00016181
		[global::System.Runtime.Serialization.DataMember]
		internal int backendNodeId { get; set; }

		// Token: 0x170008C3 RID: 2243
		// (get) Token: 0x0600165A RID: 5722 RVA: 0x00017F8A File Offset: 0x0001618A
		public int BackendNodeId
		{
			get
			{
				return this.backendNodeId;
			}
		}

		// Token: 0x170008C4 RID: 2244
		// (get) Token: 0x0600165B RID: 5723 RVA: 0x00017F92 File Offset: 0x00016192
		// (set) Token: 0x0600165C RID: 5724 RVA: 0x00017F9A File Offset: 0x0001619A
		[global::System.Runtime.Serialization.DataMember]
		internal int? nodeId { get; set; }

		// Token: 0x170008C5 RID: 2245
		// (get) Token: 0x0600165D RID: 5725 RVA: 0x00017FA3 File Offset: 0x000161A3
		public int? NodeId
		{
			get
			{
				return this.nodeId;
			}
		}
	}
}
