using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Overlay
{
	// Token: 0x020001D1 RID: 465
	[global::System.Runtime.Serialization.DataContract]
	public class IsolatedElementHighlightConfig : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x06000E1E RID: 3614 RVA: 0x000101A7 File Offset: 0x0000E3A7
		// (set) Token: 0x06000E1F RID: 3615 RVA: 0x000101AF File Offset: 0x0000E3AF
		[global::System.Runtime.Serialization.DataMember(Name = "isolationModeHighlightConfig", IsRequired = true)]
		public global::CefSharp.DevTools.Overlay.IsolationModeHighlightConfig IsolationModeHighlightConfig { get; set; }

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x06000E20 RID: 3616 RVA: 0x000101B8 File Offset: 0x0000E3B8
		// (set) Token: 0x06000E21 RID: 3617 RVA: 0x000101C0 File Offset: 0x0000E3C0
		[global::System.Runtime.Serialization.DataMember(Name = "nodeId", IsRequired = true)]
		public int NodeId { get; set; }
	}
}
