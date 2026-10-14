using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Page
{
	// Token: 0x0200019B RID: 411
	[global::System.Runtime.Serialization.DataContract]
	public class DownloadWillBeginEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x06000C52 RID: 3154 RVA: 0x0000E45C File Offset: 0x0000C65C
		// (set) Token: 0x06000C53 RID: 3155 RVA: 0x0000E464 File Offset: 0x0000C664
		[global::System.Runtime.Serialization.DataMember(Name = "frameId", IsRequired = true)]
		public string FrameId { get; private set; }

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x06000C54 RID: 3156 RVA: 0x0000E46D File Offset: 0x0000C66D
		// (set) Token: 0x06000C55 RID: 3157 RVA: 0x0000E475 File Offset: 0x0000C675
		[global::System.Runtime.Serialization.DataMember(Name = "guid", IsRequired = true)]
		public string Guid { get; private set; }

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x06000C56 RID: 3158 RVA: 0x0000E47E File Offset: 0x0000C67E
		// (set) Token: 0x06000C57 RID: 3159 RVA: 0x0000E486 File Offset: 0x0000C686
		[global::System.Runtime.Serialization.DataMember(Name = "url", IsRequired = true)]
		public string Url { get; private set; }

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x06000C58 RID: 3160 RVA: 0x0000E48F File Offset: 0x0000C68F
		// (set) Token: 0x06000C59 RID: 3161 RVA: 0x0000E497 File Offset: 0x0000C697
		[global::System.Runtime.Serialization.DataMember(Name = "suggestedFilename", IsRequired = true)]
		public string SuggestedFilename { get; private set; }
	}
}
