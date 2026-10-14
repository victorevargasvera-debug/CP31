using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Memory
{
	// Token: 0x02000247 RID: 583
	[global::System.Runtime.Serialization.DataContract]
	public class GetDOMCountersResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x17000705 RID: 1797
		// (get) Token: 0x0600121E RID: 4638 RVA: 0x00013B53 File Offset: 0x00011D53
		// (set) Token: 0x0600121F RID: 4639 RVA: 0x00013B5B File Offset: 0x00011D5B
		[global::System.Runtime.Serialization.DataMember]
		internal int documents { get; set; }

		// Token: 0x17000706 RID: 1798
		// (get) Token: 0x06001220 RID: 4640 RVA: 0x00013B64 File Offset: 0x00011D64
		public int Documents
		{
			get
			{
				return this.documents;
			}
		}

		// Token: 0x17000707 RID: 1799
		// (get) Token: 0x06001221 RID: 4641 RVA: 0x00013B6C File Offset: 0x00011D6C
		// (set) Token: 0x06001222 RID: 4642 RVA: 0x00013B74 File Offset: 0x00011D74
		[global::System.Runtime.Serialization.DataMember]
		internal int nodes { get; set; }

		// Token: 0x17000708 RID: 1800
		// (get) Token: 0x06001223 RID: 4643 RVA: 0x00013B7D File Offset: 0x00011D7D
		public int Nodes
		{
			get
			{
				return this.nodes;
			}
		}

		// Token: 0x17000709 RID: 1801
		// (get) Token: 0x06001224 RID: 4644 RVA: 0x00013B85 File Offset: 0x00011D85
		// (set) Token: 0x06001225 RID: 4645 RVA: 0x00013B8D File Offset: 0x00011D8D
		[global::System.Runtime.Serialization.DataMember]
		internal int jsEventListeners { get; set; }

		// Token: 0x1700070A RID: 1802
		// (get) Token: 0x06001226 RID: 4646 RVA: 0x00013B96 File Offset: 0x00011D96
		public int JsEventListeners
		{
			get
			{
				return this.jsEventListeners;
			}
		}
	}
}
