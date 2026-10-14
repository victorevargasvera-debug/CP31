using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.DOM
{
	// Token: 0x020002D5 RID: 725
	[global::System.Runtime.Serialization.DataContract]
	public class GetSearchResultsResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170008A6 RID: 2214
		// (get) Token: 0x06001621 RID: 5665 RVA: 0x00017DB3 File Offset: 0x00015FB3
		// (set) Token: 0x06001622 RID: 5666 RVA: 0x00017DBB File Offset: 0x00015FBB
		[global::System.Runtime.Serialization.DataMember]
		internal int[] nodeIds { get; set; }

		// Token: 0x170008A7 RID: 2215
		// (get) Token: 0x06001623 RID: 5667 RVA: 0x00017DC4 File Offset: 0x00015FC4
		public int[] NodeIds
		{
			get
			{
				return this.nodeIds;
			}
		}
	}
}
