using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Page
{
	// Token: 0x02000192 RID: 402
	[global::System.Runtime.Serialization.DataContract]
	public class FrameClearedScheduledNavigationEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06000C20 RID: 3104 RVA: 0x0000E221 File Offset: 0x0000C421
		// (set) Token: 0x06000C21 RID: 3105 RVA: 0x0000E229 File Offset: 0x0000C429
		[global::System.Runtime.Serialization.DataMember(Name = "frameId", IsRequired = true)]
		public string FrameId { get; private set; }
	}
}
