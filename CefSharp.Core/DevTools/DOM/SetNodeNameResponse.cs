using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.DOM
{
	// Token: 0x020002E1 RID: 737
	[global::System.Runtime.Serialization.DataContract]
	public class SetNodeNameResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170008C0 RID: 2240
		// (get) Token: 0x06001654 RID: 5716 RVA: 0x00017F58 File Offset: 0x00016158
		// (set) Token: 0x06001655 RID: 5717 RVA: 0x00017F60 File Offset: 0x00016160
		[global::System.Runtime.Serialization.DataMember]
		internal int nodeId { get; set; }

		// Token: 0x170008C1 RID: 2241
		// (get) Token: 0x06001656 RID: 5718 RVA: 0x00017F69 File Offset: 0x00016169
		public int NodeId
		{
			get
			{
				return this.nodeId;
			}
		}
	}
}
