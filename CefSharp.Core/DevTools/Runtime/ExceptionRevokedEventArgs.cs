using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Runtime
{
	// Token: 0x0200004B RID: 75
	[global::System.Runtime.Serialization.DataContract]
	public class ExceptionRevokedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000303 RID: 771 RVA: 0x0000591A File Offset: 0x00003B1A
		// (set) Token: 0x06000304 RID: 772 RVA: 0x00005922 File Offset: 0x00003B22
		[global::System.Runtime.Serialization.DataMember(Name = "reason", IsRequired = true)]
		public string Reason { get; private set; }

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x06000305 RID: 773 RVA: 0x0000592B File Offset: 0x00003B2B
		// (set) Token: 0x06000306 RID: 774 RVA: 0x00005933 File Offset: 0x00003B33
		[global::System.Runtime.Serialization.DataMember(Name = "exceptionId", IsRequired = true)]
		public int ExceptionId { get; private set; }
	}
}
