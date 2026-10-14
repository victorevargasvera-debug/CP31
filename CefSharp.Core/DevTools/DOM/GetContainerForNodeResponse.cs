using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.DOM
{
	// Token: 0x020002E3 RID: 739
	[global::System.Runtime.Serialization.DataContract]
	public class GetContainerForNodeResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170008C6 RID: 2246
		// (get) Token: 0x0600165F RID: 5727 RVA: 0x00017FB3 File Offset: 0x000161B3
		// (set) Token: 0x06001660 RID: 5728 RVA: 0x00017FBB File Offset: 0x000161BB
		[global::System.Runtime.Serialization.DataMember]
		internal int? nodeId { get; set; }

		// Token: 0x170008C7 RID: 2247
		// (get) Token: 0x06001661 RID: 5729 RVA: 0x00017FC4 File Offset: 0x000161C4
		public int? NodeId
		{
			get
			{
				return this.nodeId;
			}
		}
	}
}
