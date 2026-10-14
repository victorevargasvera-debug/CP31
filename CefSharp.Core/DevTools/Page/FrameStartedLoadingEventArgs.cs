using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Page
{
	// Token: 0x02000199 RID: 409
	[global::System.Runtime.Serialization.DataContract]
	public class FrameStartedLoadingEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06000C4C RID: 3148 RVA: 0x0000E42A File Offset: 0x0000C62A
		// (set) Token: 0x06000C4D RID: 3149 RVA: 0x0000E432 File Offset: 0x0000C632
		[global::System.Runtime.Serialization.DataMember(Name = "frameId", IsRequired = true)]
		public string FrameId { get; private set; }
	}
}
