using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.DOMSnapshot
{
	// Token: 0x020002A1 RID: 673
	[global::System.Runtime.Serialization.DataContract]
	public class ComputedStyle : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x170007F1 RID: 2033
		// (get) Token: 0x0600148D RID: 5261 RVA: 0x00016CF1 File Offset: 0x00014EF1
		// (set) Token: 0x0600148E RID: 5262 RVA: 0x00016CF9 File Offset: 0x00014EF9
		[global::System.Runtime.Serialization.DataMember(Name = "properties", IsRequired = true)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.DOMSnapshot.NameValue> Properties { get; set; }
	}
}
