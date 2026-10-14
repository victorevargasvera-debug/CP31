using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Runtime
{
	// Token: 0x0200004E RID: 78
	[global::System.Runtime.Serialization.DataContract]
	public class ExecutionContextDestroyedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000310 RID: 784 RVA: 0x00005987 File Offset: 0x00003B87
		// (set) Token: 0x06000311 RID: 785 RVA: 0x0000598F File Offset: 0x00003B8F
		[global::System.Runtime.Serialization.DataMember(Name = "executionContextId", IsRequired = true)]
		public int ExecutionContextId { get; private set; }

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000312 RID: 786 RVA: 0x00005998 File Offset: 0x00003B98
		// (set) Token: 0x06000313 RID: 787 RVA: 0x000059A0 File Offset: 0x00003BA0
		[global::System.Runtime.Serialization.DataMember(Name = "executionContextUniqueId", IsRequired = true)]
		public string ExecutionContextUniqueId { get; private set; }
	}
}
