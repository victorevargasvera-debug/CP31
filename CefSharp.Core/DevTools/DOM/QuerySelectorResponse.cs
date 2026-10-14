using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.DOM
{
	// Token: 0x020002DA RID: 730
	[global::System.Runtime.Serialization.DataContract]
	public class QuerySelectorResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170008B2 RID: 2226
		// (get) Token: 0x06001638 RID: 5688 RVA: 0x00017E71 File Offset: 0x00016071
		// (set) Token: 0x06001639 RID: 5689 RVA: 0x00017E79 File Offset: 0x00016079
		[global::System.Runtime.Serialization.DataMember]
		internal int nodeId { get; set; }

		// Token: 0x170008B3 RID: 2227
		// (get) Token: 0x0600163A RID: 5690 RVA: 0x00017E82 File Offset: 0x00016082
		public int NodeId
		{
			get
			{
				return this.nodeId;
			}
		}
	}
}
