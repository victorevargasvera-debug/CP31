using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Page
{
	// Token: 0x020001A4 RID: 420
	[global::System.Runtime.Serialization.DataContract]
	public class ScreencastFrameEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06000C92 RID: 3218 RVA: 0x0000E6B4 File Offset: 0x0000C8B4
		// (set) Token: 0x06000C93 RID: 3219 RVA: 0x0000E6BC File Offset: 0x0000C8BC
		[global::System.Runtime.Serialization.DataMember(Name = "data", IsRequired = true)]
		public byte[] Data { get; private set; }

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x06000C94 RID: 3220 RVA: 0x0000E6C5 File Offset: 0x0000C8C5
		// (set) Token: 0x06000C95 RID: 3221 RVA: 0x0000E6CD File Offset: 0x0000C8CD
		[global::System.Runtime.Serialization.DataMember(Name = "metadata", IsRequired = true)]
		public global::CefSharp.DevTools.Page.ScreencastFrameMetadata Metadata { get; private set; }

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06000C96 RID: 3222 RVA: 0x0000E6D6 File Offset: 0x0000C8D6
		// (set) Token: 0x06000C97 RID: 3223 RVA: 0x0000E6DE File Offset: 0x0000C8DE
		[global::System.Runtime.Serialization.DataMember(Name = "sessionId", IsRequired = true)]
		public int SessionId { get; private set; }
	}
}
