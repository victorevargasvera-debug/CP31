using System;
using System.Runtime.Serialization;
using CefSharp.DevTools.DOM;

namespace CefSharp.DevTools.Overlay
{
	// Token: 0x020001CC RID: 460
	[global::System.Runtime.Serialization.DataContract]
	public class ScrollSnapContainerHighlightConfig : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x06000DFF RID: 3583 RVA: 0x000100A2 File Offset: 0x0000E2A2
		// (set) Token: 0x06000E00 RID: 3584 RVA: 0x000100AA File Offset: 0x0000E2AA
		[global::System.Runtime.Serialization.DataMember(Name = "snapportBorder", IsRequired = false)]
		public global::CefSharp.DevTools.Overlay.LineStyle SnapportBorder { get; set; }

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x06000E01 RID: 3585 RVA: 0x000100B3 File Offset: 0x0000E2B3
		// (set) Token: 0x06000E02 RID: 3586 RVA: 0x000100BB File Offset: 0x0000E2BB
		[global::System.Runtime.Serialization.DataMember(Name = "snapAreaBorder", IsRequired = false)]
		public global::CefSharp.DevTools.Overlay.LineStyle SnapAreaBorder { get; set; }

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x06000E03 RID: 3587 RVA: 0x000100C4 File Offset: 0x0000E2C4
		// (set) Token: 0x06000E04 RID: 3588 RVA: 0x000100CC File Offset: 0x0000E2CC
		[global::System.Runtime.Serialization.DataMember(Name = "scrollMarginColor", IsRequired = false)]
		public global::CefSharp.DevTools.DOM.RGBA ScrollMarginColor { get; set; }

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x06000E05 RID: 3589 RVA: 0x000100D5 File Offset: 0x0000E2D5
		// (set) Token: 0x06000E06 RID: 3590 RVA: 0x000100DD File Offset: 0x0000E2DD
		[global::System.Runtime.Serialization.DataMember(Name = "scrollPaddingColor", IsRequired = false)]
		public global::CefSharp.DevTools.DOM.RGBA ScrollPaddingColor { get; set; }
	}
}
