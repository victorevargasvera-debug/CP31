using System;
using System.Runtime.Serialization;
using CefSharp.DevTools.DOM;

namespace CefSharp.DevTools.Overlay
{
	// Token: 0x020001C5 RID: 453
	[global::System.Runtime.Serialization.DataContract]
	public class LineStyle : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x06000DBE RID: 3518 RVA: 0x0000FE22 File Offset: 0x0000E022
		// (set) Token: 0x06000DBF RID: 3519 RVA: 0x0000FE2A File Offset: 0x0000E02A
		[global::System.Runtime.Serialization.DataMember(Name = "color", IsRequired = false)]
		public global::CefSharp.DevTools.DOM.RGBA Color { get; set; }

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x06000DC0 RID: 3520 RVA: 0x0000FE33 File Offset: 0x0000E033
		// (set) Token: 0x06000DC1 RID: 3521 RVA: 0x0000FE4F File Offset: 0x0000E04F
		public global::CefSharp.DevTools.Overlay.LineStylePattern? Pattern
		{
			get
			{
				return (global::CefSharp.DevTools.Overlay.LineStylePattern?)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Overlay.LineStylePattern?), this.pattern);
			}
			set
			{
				this.pattern = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x06000DC2 RID: 3522 RVA: 0x0000FE62 File Offset: 0x0000E062
		// (set) Token: 0x06000DC3 RID: 3523 RVA: 0x0000FE6A File Offset: 0x0000E06A
		[global::System.Runtime.Serialization.DataMember(Name = "pattern", IsRequired = false)]
		internal string pattern { get; set; }
	}
}
