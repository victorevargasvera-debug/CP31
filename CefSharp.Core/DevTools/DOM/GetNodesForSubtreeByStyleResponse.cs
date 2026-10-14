using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.DOM
{
	// Token: 0x020002D1 RID: 721
	[global::System.Runtime.Serialization.DataContract]
	public class GetNodesForSubtreeByStyleResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x1700089A RID: 2202
		// (get) Token: 0x0600160B RID: 5643 RVA: 0x00017CFD File Offset: 0x00015EFD
		// (set) Token: 0x0600160C RID: 5644 RVA: 0x00017D05 File Offset: 0x00015F05
		[global::System.Runtime.Serialization.DataMember]
		internal int[] nodeIds { get; set; }

		// Token: 0x1700089B RID: 2203
		// (get) Token: 0x0600160D RID: 5645 RVA: 0x00017D0E File Offset: 0x00015F0E
		public int[] NodeIds
		{
			get
			{
				return this.nodeIds;
			}
		}
	}
}
