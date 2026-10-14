using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Runtime
{
	// Token: 0x0200004F RID: 79
	[global::System.Runtime.Serialization.DataContract]
	public class InspectRequestedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000315 RID: 789 RVA: 0x000059B1 File Offset: 0x00003BB1
		// (set) Token: 0x06000316 RID: 790 RVA: 0x000059B9 File Offset: 0x00003BB9
		[global::System.Runtime.Serialization.DataMember(Name = "object", IsRequired = true)]
		public global::CefSharp.DevTools.Runtime.RemoteObject Object { get; private set; }

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000317 RID: 791 RVA: 0x000059C2 File Offset: 0x00003BC2
		// (set) Token: 0x06000318 RID: 792 RVA: 0x000059CA File Offset: 0x00003BCA
		[global::System.Runtime.Serialization.DataMember(Name = "hints", IsRequired = true)]
		public object Hints { get; private set; }

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000319 RID: 793 RVA: 0x000059D3 File Offset: 0x00003BD3
		// (set) Token: 0x0600031A RID: 794 RVA: 0x000059DB File Offset: 0x00003BDB
		[global::System.Runtime.Serialization.DataMember(Name = "executionContextId", IsRequired = false)]
		public int? ExecutionContextId { get; private set; }
	}
}
