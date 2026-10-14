using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Page
{
	// Token: 0x020001B8 RID: 440
	[global::System.Runtime.Serialization.DataContract]
	public class GetPermissionsPolicyStateResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x06000D14 RID: 3348 RVA: 0x0000EAF8 File Offset: 0x0000CCF8
		// (set) Token: 0x06000D15 RID: 3349 RVA: 0x0000EB00 File Offset: 0x0000CD00
		[global::System.Runtime.Serialization.DataMember]
		internal global::System.Collections.Generic.IList<global::CefSharp.DevTools.Page.PermissionsPolicyFeatureState> states { get; set; }

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x06000D16 RID: 3350 RVA: 0x0000EB09 File Offset: 0x0000CD09
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.Page.PermissionsPolicyFeatureState> States
		{
			get
			{
				return this.states;
			}
		}
	}
}
