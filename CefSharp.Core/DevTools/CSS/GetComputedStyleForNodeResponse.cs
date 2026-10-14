using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.CSS
{
	// Token: 0x0200031C RID: 796
	[global::System.Runtime.Serialization.DataContract]
	public class GetComputedStyleForNodeResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x17000982 RID: 2434
		// (get) Token: 0x0600185D RID: 6237 RVA: 0x0001A283 File Offset: 0x00018483
		// (set) Token: 0x0600185E RID: 6238 RVA: 0x0001A28B File Offset: 0x0001848B
		[global::System.Runtime.Serialization.DataMember]
		internal global::System.Collections.Generic.IList<global::CefSharp.DevTools.CSS.CSSComputedStyleProperty> computedStyle { get; set; }

		// Token: 0x17000983 RID: 2435
		// (get) Token: 0x0600185F RID: 6239 RVA: 0x0001A294 File Offset: 0x00018494
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.CSS.CSSComputedStyleProperty> ComputedStyle
		{
			get
			{
				return this.computedStyle;
			}
		}
	}
}
