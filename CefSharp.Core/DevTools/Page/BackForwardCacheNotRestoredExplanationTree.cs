using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Page
{
	// Token: 0x0200018D RID: 397
	[global::System.Runtime.Serialization.DataContract]
	public class BackForwardCacheNotRestoredExplanationTree : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x06000C06 RID: 3078 RVA: 0x0000E128 File Offset: 0x0000C328
		// (set) Token: 0x06000C07 RID: 3079 RVA: 0x0000E130 File Offset: 0x0000C330
		[global::System.Runtime.Serialization.DataMember(Name = "url", IsRequired = true)]
		public string Url { get; set; }

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x06000C08 RID: 3080 RVA: 0x0000E139 File Offset: 0x0000C339
		// (set) Token: 0x06000C09 RID: 3081 RVA: 0x0000E141 File Offset: 0x0000C341
		[global::System.Runtime.Serialization.DataMember(Name = "explanations", IsRequired = true)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.Page.BackForwardCacheNotRestoredExplanation> Explanations { get; set; }

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x06000C0A RID: 3082 RVA: 0x0000E14A File Offset: 0x0000C34A
		// (set) Token: 0x06000C0B RID: 3083 RVA: 0x0000E152 File Offset: 0x0000C352
		[global::System.Runtime.Serialization.DataMember(Name = "children", IsRequired = true)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.Page.BackForwardCacheNotRestoredExplanationTree> Children { get; set; }
	}
}
