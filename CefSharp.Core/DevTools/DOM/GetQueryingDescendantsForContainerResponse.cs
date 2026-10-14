using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.DOM
{
	// Token: 0x020002E4 RID: 740
	[global::System.Runtime.Serialization.DataContract]
	public class GetQueryingDescendantsForContainerResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170008C8 RID: 2248
		// (get) Token: 0x06001663 RID: 5731 RVA: 0x00017FD4 File Offset: 0x000161D4
		// (set) Token: 0x06001664 RID: 5732 RVA: 0x00017FDC File Offset: 0x000161DC
		[global::System.Runtime.Serialization.DataMember]
		internal int[] nodeIds { get; set; }

		// Token: 0x170008C9 RID: 2249
		// (get) Token: 0x06001665 RID: 5733 RVA: 0x00017FE5 File Offset: 0x000161E5
		public int[] NodeIds
		{
			get
			{
				return this.nodeIds;
			}
		}
	}
}
