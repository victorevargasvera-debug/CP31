using System;
using System.Runtime.Serialization;
using CefSharp.DevTools.DOM;

namespace CefSharp.DevTools.Overlay
{
	// Token: 0x020001C6 RID: 454
	[global::System.Runtime.Serialization.DataContract]
	public class BoxStyle : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x06000DC5 RID: 3525 RVA: 0x0000FE7B File Offset: 0x0000E07B
		// (set) Token: 0x06000DC6 RID: 3526 RVA: 0x0000FE83 File Offset: 0x0000E083
		[global::System.Runtime.Serialization.DataMember(Name = "fillColor", IsRequired = false)]
		public global::CefSharp.DevTools.DOM.RGBA FillColor { get; set; }

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x06000DC7 RID: 3527 RVA: 0x0000FE8C File Offset: 0x0000E08C
		// (set) Token: 0x06000DC8 RID: 3528 RVA: 0x0000FE94 File Offset: 0x0000E094
		[global::System.Runtime.Serialization.DataMember(Name = "hatchColor", IsRequired = false)]
		public global::CefSharp.DevTools.DOM.RGBA HatchColor { get; set; }
	}
}
