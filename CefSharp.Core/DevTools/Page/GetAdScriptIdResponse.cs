using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Page
{
	// Token: 0x020001AF RID: 431
	[global::System.Runtime.Serialization.DataContract]
	public class GetAdScriptIdResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x06000CD2 RID: 3282 RVA: 0x0000E8CF File Offset: 0x0000CACF
		// (set) Token: 0x06000CD3 RID: 3283 RVA: 0x0000E8D7 File Offset: 0x0000CAD7
		[global::System.Runtime.Serialization.DataMember]
		internal global::CefSharp.DevTools.Page.AdScriptId adScriptId { get; set; }

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x06000CD4 RID: 3284 RVA: 0x0000E8E0 File Offset: 0x0000CAE0
		public global::CefSharp.DevTools.Page.AdScriptId AdScriptId
		{
			get
			{
				return this.adScriptId;
			}
		}
	}
}
