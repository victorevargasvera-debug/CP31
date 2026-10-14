using System;
using System.Runtime.Serialization;
using CefSharp.DevTools.DOM;

namespace CefSharp.DevTools.Overlay
{
	// Token: 0x020001CE RID: 462
	[global::System.Runtime.Serialization.DataContract]
	public class HingeConfig : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x06000E0D RID: 3597 RVA: 0x00010118 File Offset: 0x0000E318
		// (set) Token: 0x06000E0E RID: 3598 RVA: 0x00010120 File Offset: 0x0000E320
		[global::System.Runtime.Serialization.DataMember(Name = "rect", IsRequired = true)]
		public global::CefSharp.DevTools.DOM.Rect Rect { get; set; }

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x06000E0F RID: 3599 RVA: 0x00010129 File Offset: 0x0000E329
		// (set) Token: 0x06000E10 RID: 3600 RVA: 0x00010131 File Offset: 0x0000E331
		[global::System.Runtime.Serialization.DataMember(Name = "contentColor", IsRequired = false)]
		public global::CefSharp.DevTools.DOM.RGBA ContentColor { get; set; }

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x06000E11 RID: 3601 RVA: 0x0001013A File Offset: 0x0000E33A
		// (set) Token: 0x06000E12 RID: 3602 RVA: 0x00010142 File Offset: 0x0000E342
		[global::System.Runtime.Serialization.DataMember(Name = "outlineColor", IsRequired = false)]
		public global::CefSharp.DevTools.DOM.RGBA OutlineColor { get; set; }
	}
}
