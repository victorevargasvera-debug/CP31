using System;
using System.Runtime.Serialization;

namespace CefSharp.Internals
{
	// Token: 0x020000E0 RID: 224
	[global::System.Runtime.Serialization.DataContract]
	public class JavascriptCallback
	{
		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x06000683 RID: 1667 RVA: 0x0000A0F5 File Offset: 0x000082F5
		// (set) Token: 0x06000684 RID: 1668 RVA: 0x0000A0FD File Offset: 0x000082FD
		[global::System.Runtime.Serialization.DataMember]
		public long Id { get; set; }

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x06000685 RID: 1669 RVA: 0x0000A106 File Offset: 0x00008306
		// (set) Token: 0x06000686 RID: 1670 RVA: 0x0000A10E File Offset: 0x0000830E
		[global::System.Runtime.Serialization.DataMember]
		public int BrowserId { get; set; }

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x06000687 RID: 1671 RVA: 0x0000A117 File Offset: 0x00008317
		// (set) Token: 0x06000688 RID: 1672 RVA: 0x0000A11F File Offset: 0x0000831F
		[global::System.Runtime.Serialization.DataMember]
		public long FrameId { get; set; }
	}
}
