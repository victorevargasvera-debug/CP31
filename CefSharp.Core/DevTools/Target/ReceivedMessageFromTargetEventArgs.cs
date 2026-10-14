using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Target
{
	// Token: 0x02000104 RID: 260
	[global::System.Runtime.Serialization.DataContract]
	public class ReceivedMessageFromTargetEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x17000317 RID: 791
		// (get) Token: 0x0600084B RID: 2123 RVA: 0x0000AE40 File Offset: 0x00009040
		// (set) Token: 0x0600084C RID: 2124 RVA: 0x0000AE48 File Offset: 0x00009048
		[global::System.Runtime.Serialization.DataMember(Name = "sessionId", IsRequired = true)]
		public string SessionId { get; private set; }

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x0600084D RID: 2125 RVA: 0x0000AE51 File Offset: 0x00009051
		// (set) Token: 0x0600084E RID: 2126 RVA: 0x0000AE59 File Offset: 0x00009059
		[global::System.Runtime.Serialization.DataMember(Name = "message", IsRequired = true)]
		public string Message { get; private set; }

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x0600084F RID: 2127 RVA: 0x0000AE62 File Offset: 0x00009062
		// (set) Token: 0x06000850 RID: 2128 RVA: 0x0000AE6A File Offset: 0x0000906A
		[global::System.Runtime.Serialization.DataMember(Name = "targetId", IsRequired = false)]
		public string TargetId { get; private set; }
	}
}
