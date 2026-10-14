using System;
using System.Runtime.Serialization;
using CefSharp.DevTools.DOM;

namespace CefSharp.DevTools.Overlay
{
	// Token: 0x020001D2 RID: 466
	[global::System.Runtime.Serialization.DataContract]
	public class IsolationModeHighlightConfig : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x06000E23 RID: 3619 RVA: 0x000101D1 File Offset: 0x0000E3D1
		// (set) Token: 0x06000E24 RID: 3620 RVA: 0x000101D9 File Offset: 0x0000E3D9
		[global::System.Runtime.Serialization.DataMember(Name = "resizerColor", IsRequired = false)]
		public global::CefSharp.DevTools.DOM.RGBA ResizerColor { get; set; }

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x06000E25 RID: 3621 RVA: 0x000101E2 File Offset: 0x0000E3E2
		// (set) Token: 0x06000E26 RID: 3622 RVA: 0x000101EA File Offset: 0x0000E3EA
		[global::System.Runtime.Serialization.DataMember(Name = "resizerHandleColor", IsRequired = false)]
		public global::CefSharp.DevTools.DOM.RGBA ResizerHandleColor { get; set; }

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x06000E27 RID: 3623 RVA: 0x000101F3 File Offset: 0x0000E3F3
		// (set) Token: 0x06000E28 RID: 3624 RVA: 0x000101FB File Offset: 0x0000E3FB
		[global::System.Runtime.Serialization.DataMember(Name = "maskColor", IsRequired = false)]
		public global::CefSharp.DevTools.DOM.RGBA MaskColor { get; set; }
	}
}
