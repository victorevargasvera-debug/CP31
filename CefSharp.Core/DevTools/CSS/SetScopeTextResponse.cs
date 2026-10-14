using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.CSS
{
	// Token: 0x02000328 RID: 808
	[global::System.Runtime.Serialization.DataContract]
	public class SetScopeTextResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170009AC RID: 2476
		// (get) Token: 0x060018A8 RID: 6312 RVA: 0x0001A4F0 File Offset: 0x000186F0
		// (set) Token: 0x060018A9 RID: 6313 RVA: 0x0001A4F8 File Offset: 0x000186F8
		[global::System.Runtime.Serialization.DataMember]
		internal global::CefSharp.DevTools.CSS.CSSScope scope { get; set; }

		// Token: 0x170009AD RID: 2477
		// (get) Token: 0x060018AA RID: 6314 RVA: 0x0001A501 File Offset: 0x00018701
		public global::CefSharp.DevTools.CSS.CSSScope Scope
		{
			get
			{
				return this.scope;
			}
		}
	}
}
