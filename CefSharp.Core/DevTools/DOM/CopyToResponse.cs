using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.DOM
{
	// Token: 0x020002CB RID: 715
	[global::System.Runtime.Serialization.DataContract]
	public class CopyToResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x1700088E RID: 2190
		// (get) Token: 0x060015F3 RID: 5619 RVA: 0x00017C37 File Offset: 0x00015E37
		// (set) Token: 0x060015F4 RID: 5620 RVA: 0x00017C3F File Offset: 0x00015E3F
		[global::System.Runtime.Serialization.DataMember]
		internal int nodeId { get; set; }

		// Token: 0x1700088F RID: 2191
		// (get) Token: 0x060015F5 RID: 5621 RVA: 0x00017C48 File Offset: 0x00015E48
		public int NodeId
		{
			get
			{
				return this.nodeId;
			}
		}
	}
}
