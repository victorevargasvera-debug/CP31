using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.CSS
{
	// Token: 0x02000315 RID: 789
	[global::System.Runtime.Serialization.DataContract]
	public class StyleSheetAddedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x17000973 RID: 2419
		// (get) Token: 0x0600183E RID: 6206 RVA: 0x0001A182 File Offset: 0x00018382
		// (set) Token: 0x0600183F RID: 6207 RVA: 0x0001A18A File Offset: 0x0001838A
		[global::System.Runtime.Serialization.DataMember(Name = "header", IsRequired = true)]
		public global::CefSharp.DevTools.CSS.CSSStyleSheetHeader Header { get; private set; }
	}
}
