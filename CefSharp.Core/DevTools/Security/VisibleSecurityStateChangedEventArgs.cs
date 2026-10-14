using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Security
{
	// Token: 0x02000153 RID: 339
	[global::System.Runtime.Serialization.DataContract]
	public class VisibleSecurityStateChangedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x06000AAA RID: 2730 RVA: 0x0000D29F File Offset: 0x0000B49F
		// (set) Token: 0x06000AAB RID: 2731 RVA: 0x0000D2A7 File Offset: 0x0000B4A7
		[global::System.Runtime.Serialization.DataMember(Name = "visibleSecurityState", IsRequired = true)]
		public global::CefSharp.DevTools.Security.VisibleSecurityState VisibleSecurityState { get; private set; }
	}
}
