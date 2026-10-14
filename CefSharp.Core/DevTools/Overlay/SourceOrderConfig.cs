using System;
using System.Runtime.Serialization;
using CefSharp.DevTools.DOM;

namespace CefSharp.DevTools.Overlay
{
	// Token: 0x020001C0 RID: 448
	[global::System.Runtime.Serialization.DataContract]
	public class SourceOrderConfig : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x06000D78 RID: 3448 RVA: 0x0000FBD1 File Offset: 0x0000DDD1
		// (set) Token: 0x06000D79 RID: 3449 RVA: 0x0000FBD9 File Offset: 0x0000DDD9
		[global::System.Runtime.Serialization.DataMember(Name = "parentOutlineColor", IsRequired = true)]
		public global::CefSharp.DevTools.DOM.RGBA ParentOutlineColor { get; set; }

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x06000D7A RID: 3450 RVA: 0x0000FBE2 File Offset: 0x0000DDE2
		// (set) Token: 0x06000D7B RID: 3451 RVA: 0x0000FBEA File Offset: 0x0000DDEA
		[global::System.Runtime.Serialization.DataMember(Name = "childOutlineColor", IsRequired = true)]
		public global::CefSharp.DevTools.DOM.RGBA ChildOutlineColor { get; set; }
	}
}
