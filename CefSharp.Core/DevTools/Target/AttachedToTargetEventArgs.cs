using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Target
{
	// Token: 0x02000102 RID: 258
	[global::System.Runtime.Serialization.DataContract]
	public class AttachedToTargetEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x17000312 RID: 786
		// (get) Token: 0x0600083F RID: 2111 RVA: 0x0000ADDB File Offset: 0x00008FDB
		// (set) Token: 0x06000840 RID: 2112 RVA: 0x0000ADE3 File Offset: 0x00008FE3
		[global::System.Runtime.Serialization.DataMember(Name = "sessionId", IsRequired = true)]
		public string SessionId { get; private set; }

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06000841 RID: 2113 RVA: 0x0000ADEC File Offset: 0x00008FEC
		// (set) Token: 0x06000842 RID: 2114 RVA: 0x0000ADF4 File Offset: 0x00008FF4
		[global::System.Runtime.Serialization.DataMember(Name = "targetInfo", IsRequired = true)]
		public global::CefSharp.DevTools.Target.TargetInfo TargetInfo { get; private set; }

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06000843 RID: 2115 RVA: 0x0000ADFD File Offset: 0x00008FFD
		// (set) Token: 0x06000844 RID: 2116 RVA: 0x0000AE05 File Offset: 0x00009005
		[global::System.Runtime.Serialization.DataMember(Name = "waitingForDebugger", IsRequired = true)]
		public bool WaitingForDebugger { get; private set; }
	}
}
