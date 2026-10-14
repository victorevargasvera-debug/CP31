using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Runtime
{
	// Token: 0x0200004D RID: 77
	[global::System.Runtime.Serialization.DataContract]
	public class ExecutionContextCreatedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x17000114 RID: 276
		// (get) Token: 0x0600030D RID: 781 RVA: 0x0000596E File Offset: 0x00003B6E
		// (set) Token: 0x0600030E RID: 782 RVA: 0x00005976 File Offset: 0x00003B76
		[global::System.Runtime.Serialization.DataMember(Name = "context", IsRequired = true)]
		public global::CefSharp.DevTools.Runtime.ExecutionContextDescription Context { get; private set; }
	}
}
