using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Overlay
{
	// Token: 0x020001D0 RID: 464
	[global::System.Runtime.Serialization.DataContract]
	public class ContainerQueryContainerHighlightConfig : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x06000E19 RID: 3609 RVA: 0x0001017D File Offset: 0x0000E37D
		// (set) Token: 0x06000E1A RID: 3610 RVA: 0x00010185 File Offset: 0x0000E385
		[global::System.Runtime.Serialization.DataMember(Name = "containerBorder", IsRequired = false)]
		public global::CefSharp.DevTools.Overlay.LineStyle ContainerBorder { get; set; }

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x06000E1B RID: 3611 RVA: 0x0001018E File Offset: 0x0000E38E
		// (set) Token: 0x06000E1C RID: 3612 RVA: 0x00010196 File Offset: 0x0000E396
		[global::System.Runtime.Serialization.DataMember(Name = "descendantBorder", IsRequired = false)]
		public global::CefSharp.DevTools.Overlay.LineStyle DescendantBorder { get; set; }
	}
}
