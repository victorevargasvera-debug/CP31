using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Page
{
	// Token: 0x020001A3 RID: 419
	[global::System.Runtime.Serialization.DataContract]
	public class NavigatedWithinDocumentEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06000C8D RID: 3213 RVA: 0x0000E68A File Offset: 0x0000C88A
		// (set) Token: 0x06000C8E RID: 3214 RVA: 0x0000E692 File Offset: 0x0000C892
		[global::System.Runtime.Serialization.DataMember(Name = "frameId", IsRequired = true)]
		public string FrameId { get; private set; }

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x06000C8F RID: 3215 RVA: 0x0000E69B File Offset: 0x0000C89B
		// (set) Token: 0x06000C90 RID: 3216 RVA: 0x0000E6A3 File Offset: 0x0000C8A3
		[global::System.Runtime.Serialization.DataMember(Name = "url", IsRequired = true)]
		public string Url { get; private set; }
	}
}
