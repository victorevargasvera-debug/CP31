using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x020001F2 RID: 498
	[global::System.Runtime.Serialization.DataContract]
	public class WebSocketRequest : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x06000F26 RID: 3878 RVA: 0x000112D6 File Offset: 0x0000F4D6
		// (set) Token: 0x06000F27 RID: 3879 RVA: 0x000112DE File Offset: 0x0000F4DE
		[global::System.Runtime.Serialization.DataMember(Name = "headers", IsRequired = true)]
		public global::CefSharp.DevTools.Network.Headers Headers { get; set; }
	}
}
