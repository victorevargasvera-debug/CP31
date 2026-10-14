using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.DOM
{
	// Token: 0x020002DD RID: 733
	[global::System.Runtime.Serialization.DataContract]
	public class RequestNodeResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170008B8 RID: 2232
		// (get) Token: 0x06001644 RID: 5700 RVA: 0x00017ED4 File Offset: 0x000160D4
		// (set) Token: 0x06001645 RID: 5701 RVA: 0x00017EDC File Offset: 0x000160DC
		[global::System.Runtime.Serialization.DataMember]
		internal int nodeId { get; set; }

		// Token: 0x170008B9 RID: 2233
		// (get) Token: 0x06001646 RID: 5702 RVA: 0x00017EE5 File Offset: 0x000160E5
		public int NodeId
		{
			get
			{
				return this.nodeId;
			}
		}
	}
}
