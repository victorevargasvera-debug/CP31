using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Preload
{
	// Token: 0x020000A8 RID: 168
	[global::System.Runtime.Serialization.DataContract]
	public class RuleSetUpdatedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x1700022D RID: 557
		// (get) Token: 0x060005CC RID: 1484 RVA: 0x000089E5 File Offset: 0x00006BE5
		// (set) Token: 0x060005CD RID: 1485 RVA: 0x000089ED File Offset: 0x00006BED
		[global::System.Runtime.Serialization.DataMember(Name = "ruleSet", IsRequired = true)]
		public global::CefSharp.DevTools.Preload.RuleSet RuleSet { get; private set; }
	}
}
