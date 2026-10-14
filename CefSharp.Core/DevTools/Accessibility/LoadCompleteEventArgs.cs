using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Accessibility
{
	// Token: 0x02000388 RID: 904
	[global::System.Runtime.Serialization.DataContract]
	public class LoadCompleteEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x17000ABD RID: 2749
		// (get) Token: 0x06001B4F RID: 6991 RVA: 0x0001CC8D File Offset: 0x0001AE8D
		// (set) Token: 0x06001B50 RID: 6992 RVA: 0x0001CC95 File Offset: 0x0001AE95
		[global::System.Runtime.Serialization.DataMember(Name = "root", IsRequired = true)]
		public global::CefSharp.DevTools.Accessibility.AXNode Root { get; private set; }
	}
}
