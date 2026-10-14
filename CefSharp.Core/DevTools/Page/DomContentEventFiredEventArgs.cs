using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Page
{
	// Token: 0x0200018E RID: 398
	[global::System.Runtime.Serialization.DataContract]
	public class DomContentEventFiredEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x06000C0D RID: 3085 RVA: 0x0000E163 File Offset: 0x0000C363
		// (set) Token: 0x06000C0E RID: 3086 RVA: 0x0000E16B File Offset: 0x0000C36B
		[global::System.Runtime.Serialization.DataMember(Name = "timestamp", IsRequired = true)]
		public double Timestamp { get; private set; }
	}
}
