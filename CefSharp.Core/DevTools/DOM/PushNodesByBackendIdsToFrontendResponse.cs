using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.DOM
{
	// Token: 0x020002D9 RID: 729
	[global::System.Runtime.Serialization.DataContract]
	public class PushNodesByBackendIdsToFrontendResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170008B0 RID: 2224
		// (get) Token: 0x06001634 RID: 5684 RVA: 0x00017E50 File Offset: 0x00016050
		// (set) Token: 0x06001635 RID: 5685 RVA: 0x00017E58 File Offset: 0x00016058
		[global::System.Runtime.Serialization.DataMember]
		internal int[] nodeIds { get; set; }

		// Token: 0x170008B1 RID: 2225
		// (get) Token: 0x06001636 RID: 5686 RVA: 0x00017E61 File Offset: 0x00016061
		public int[] NodeIds
		{
			get
			{
				return this.nodeIds;
			}
		}
	}
}
