using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Overlay
{
	// Token: 0x020001C3 RID: 451
	[global::System.Runtime.Serialization.DataContract]
	public class FlexItemHighlightConfig : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x06000DB7 RID: 3511 RVA: 0x0000FDE7 File Offset: 0x0000DFE7
		// (set) Token: 0x06000DB8 RID: 3512 RVA: 0x0000FDEF File Offset: 0x0000DFEF
		[global::System.Runtime.Serialization.DataMember(Name = "baseSizeBox", IsRequired = false)]
		public global::CefSharp.DevTools.Overlay.BoxStyle BaseSizeBox { get; set; }

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x06000DB9 RID: 3513 RVA: 0x0000FDF8 File Offset: 0x0000DFF8
		// (set) Token: 0x06000DBA RID: 3514 RVA: 0x0000FE00 File Offset: 0x0000E000
		[global::System.Runtime.Serialization.DataMember(Name = "baseSizeBorder", IsRequired = false)]
		public global::CefSharp.DevTools.Overlay.LineStyle BaseSizeBorder { get; set; }

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x06000DBB RID: 3515 RVA: 0x0000FE09 File Offset: 0x0000E009
		// (set) Token: 0x06000DBC RID: 3516 RVA: 0x0000FE11 File Offset: 0x0000E011
		[global::System.Runtime.Serialization.DataMember(Name = "flexibilityArrow", IsRequired = false)]
		public global::CefSharp.DevTools.Overlay.LineStyle FlexibilityArrow { get; set; }
	}
}
