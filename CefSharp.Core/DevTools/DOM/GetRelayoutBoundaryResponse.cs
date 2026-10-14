using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.DOM
{
	// Token: 0x020002D4 RID: 724
	[global::System.Runtime.Serialization.DataContract]
	public class GetRelayoutBoundaryResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170008A4 RID: 2212
		// (get) Token: 0x0600161D RID: 5661 RVA: 0x00017D92 File Offset: 0x00015F92
		// (set) Token: 0x0600161E RID: 5662 RVA: 0x00017D9A File Offset: 0x00015F9A
		[global::System.Runtime.Serialization.DataMember]
		internal int nodeId { get; set; }

		// Token: 0x170008A5 RID: 2213
		// (get) Token: 0x0600161F RID: 5663 RVA: 0x00017DA3 File Offset: 0x00015FA3
		public int NodeId
		{
			get
			{
				return this.nodeId;
			}
		}
	}
}
