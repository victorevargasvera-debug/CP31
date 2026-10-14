using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Overlay
{
	// Token: 0x020001CD RID: 461
	[global::System.Runtime.Serialization.DataContract]
	public class ScrollSnapHighlightConfig : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x06000E08 RID: 3592 RVA: 0x000100EE File Offset: 0x0000E2EE
		// (set) Token: 0x06000E09 RID: 3593 RVA: 0x000100F6 File Offset: 0x0000E2F6
		[global::System.Runtime.Serialization.DataMember(Name = "scrollSnapContainerHighlightConfig", IsRequired = true)]
		public global::CefSharp.DevTools.Overlay.ScrollSnapContainerHighlightConfig ScrollSnapContainerHighlightConfig { get; set; }

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x06000E0A RID: 3594 RVA: 0x000100FF File Offset: 0x0000E2FF
		// (set) Token: 0x06000E0B RID: 3595 RVA: 0x00010107 File Offset: 0x0000E307
		[global::System.Runtime.Serialization.DataMember(Name = "nodeId", IsRequired = true)]
		public int NodeId { get; set; }
	}
}
