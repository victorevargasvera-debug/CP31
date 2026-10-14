using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.DOM
{
	// Token: 0x020002D6 RID: 726
	[global::System.Runtime.Serialization.DataContract]
	public class MoveToResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170008A8 RID: 2216
		// (get) Token: 0x06001625 RID: 5669 RVA: 0x00017DD4 File Offset: 0x00015FD4
		// (set) Token: 0x06001626 RID: 5670 RVA: 0x00017DDC File Offset: 0x00015FDC
		[global::System.Runtime.Serialization.DataMember]
		internal int nodeId { get; set; }

		// Token: 0x170008A9 RID: 2217
		// (get) Token: 0x06001627 RID: 5671 RVA: 0x00017DE5 File Offset: 0x00015FE5
		public int NodeId
		{
			get
			{
				return this.nodeId;
			}
		}
	}
}
