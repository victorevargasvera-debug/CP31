using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.DOM
{
	// Token: 0x020002DB RID: 731
	[global::System.Runtime.Serialization.DataContract]
	public class QuerySelectorAllResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170008B4 RID: 2228
		// (get) Token: 0x0600163C RID: 5692 RVA: 0x00017E92 File Offset: 0x00016092
		// (set) Token: 0x0600163D RID: 5693 RVA: 0x00017E9A File Offset: 0x0001609A
		[global::System.Runtime.Serialization.DataMember]
		internal int[] nodeIds { get; set; }

		// Token: 0x170008B5 RID: 2229
		// (get) Token: 0x0600163E RID: 5694 RVA: 0x00017EA3 File Offset: 0x000160A3
		public int[] NodeIds
		{
			get
			{
				return this.nodeIds;
			}
		}
	}
}
