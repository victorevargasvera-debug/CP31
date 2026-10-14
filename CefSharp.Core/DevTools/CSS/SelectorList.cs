using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.CSS
{
	// Token: 0x020002FA RID: 762
	[global::System.Runtime.Serialization.DataContract]
	public class SelectorList : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x170008F2 RID: 2290
		// (get) Token: 0x06001722 RID: 5922 RVA: 0x0001974F File Offset: 0x0001794F
		// (set) Token: 0x06001723 RID: 5923 RVA: 0x00019757 File Offset: 0x00017957
		[global::System.Runtime.Serialization.DataMember(Name = "selectors", IsRequired = true)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.CSS.Value> Selectors { get; set; }

		// Token: 0x170008F3 RID: 2291
		// (get) Token: 0x06001724 RID: 5924 RVA: 0x00019760 File Offset: 0x00017960
		// (set) Token: 0x06001725 RID: 5925 RVA: 0x00019768 File Offset: 0x00017968
		[global::System.Runtime.Serialization.DataMember(Name = "text", IsRequired = true)]
		public string Text { get; set; }
	}
}
