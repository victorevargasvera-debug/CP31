using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.DOM
{
	// Token: 0x020002D2 RID: 722
	[global::System.Runtime.Serialization.DataContract]
	public class GetNodeForLocationResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x1700089C RID: 2204
		// (get) Token: 0x0600160F RID: 5647 RVA: 0x00017D1E File Offset: 0x00015F1E
		// (set) Token: 0x06001610 RID: 5648 RVA: 0x00017D26 File Offset: 0x00015F26
		[global::System.Runtime.Serialization.DataMember]
		internal int backendNodeId { get; set; }

		// Token: 0x1700089D RID: 2205
		// (get) Token: 0x06001611 RID: 5649 RVA: 0x00017D2F File Offset: 0x00015F2F
		public int BackendNodeId
		{
			get
			{
				return this.backendNodeId;
			}
		}

		// Token: 0x1700089E RID: 2206
		// (get) Token: 0x06001612 RID: 5650 RVA: 0x00017D37 File Offset: 0x00015F37
		// (set) Token: 0x06001613 RID: 5651 RVA: 0x00017D3F File Offset: 0x00015F3F
		[global::System.Runtime.Serialization.DataMember]
		internal string frameId { get; set; }

		// Token: 0x1700089F RID: 2207
		// (get) Token: 0x06001614 RID: 5652 RVA: 0x00017D48 File Offset: 0x00015F48
		public string FrameId
		{
			get
			{
				return this.frameId;
			}
		}

		// Token: 0x170008A0 RID: 2208
		// (get) Token: 0x06001615 RID: 5653 RVA: 0x00017D50 File Offset: 0x00015F50
		// (set) Token: 0x06001616 RID: 5654 RVA: 0x00017D58 File Offset: 0x00015F58
		[global::System.Runtime.Serialization.DataMember]
		internal int? nodeId { get; set; }

		// Token: 0x170008A1 RID: 2209
		// (get) Token: 0x06001617 RID: 5655 RVA: 0x00017D61 File Offset: 0x00015F61
		public int? NodeId
		{
			get
			{
				return this.nodeId;
			}
		}
	}
}
