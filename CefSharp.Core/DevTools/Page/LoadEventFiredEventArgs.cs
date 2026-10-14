using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Page
{
	// Token: 0x020001A2 RID: 418
	[global::System.Runtime.Serialization.DataContract]
	public class LoadEventFiredEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x06000C8A RID: 3210 RVA: 0x0000E671 File Offset: 0x0000C871
		// (set) Token: 0x06000C8B RID: 3211 RVA: 0x0000E679 File Offset: 0x0000C879
		[global::System.Runtime.Serialization.DataMember(Name = "timestamp", IsRequired = true)]
		public double Timestamp { get; private set; }
	}
}
