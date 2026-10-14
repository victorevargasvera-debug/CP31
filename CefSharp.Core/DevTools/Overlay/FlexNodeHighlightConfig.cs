using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Overlay
{
	// Token: 0x020001CB RID: 459
	[global::System.Runtime.Serialization.DataContract]
	public class FlexNodeHighlightConfig : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x06000DFA RID: 3578 RVA: 0x00010078 File Offset: 0x0000E278
		// (set) Token: 0x06000DFB RID: 3579 RVA: 0x00010080 File Offset: 0x0000E280
		[global::System.Runtime.Serialization.DataMember(Name = "flexContainerHighlightConfig", IsRequired = true)]
		public global::CefSharp.DevTools.Overlay.FlexContainerHighlightConfig FlexContainerHighlightConfig { get; set; }

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x06000DFC RID: 3580 RVA: 0x00010089 File Offset: 0x0000E289
		// (set) Token: 0x06000DFD RID: 3581 RVA: 0x00010091 File Offset: 0x0000E291
		[global::System.Runtime.Serialization.DataMember(Name = "nodeId", IsRequired = true)]
		public int NodeId { get; set; }
	}
}
