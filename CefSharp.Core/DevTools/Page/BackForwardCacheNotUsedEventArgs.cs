using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Page
{
	// Token: 0x020001A1 RID: 417
	[global::System.Runtime.Serialization.DataContract]
	public class BackForwardCacheNotUsedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x06000C81 RID: 3201 RVA: 0x0000E625 File Offset: 0x0000C825
		// (set) Token: 0x06000C82 RID: 3202 RVA: 0x0000E62D File Offset: 0x0000C82D
		[global::System.Runtime.Serialization.DataMember(Name = "loaderId", IsRequired = true)]
		public string LoaderId { get; private set; }

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06000C83 RID: 3203 RVA: 0x0000E636 File Offset: 0x0000C836
		// (set) Token: 0x06000C84 RID: 3204 RVA: 0x0000E63E File Offset: 0x0000C83E
		[global::System.Runtime.Serialization.DataMember(Name = "frameId", IsRequired = true)]
		public string FrameId { get; private set; }

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06000C85 RID: 3205 RVA: 0x0000E647 File Offset: 0x0000C847
		// (set) Token: 0x06000C86 RID: 3206 RVA: 0x0000E64F File Offset: 0x0000C84F
		[global::System.Runtime.Serialization.DataMember(Name = "notRestoredExplanations", IsRequired = true)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.Page.BackForwardCacheNotRestoredExplanation> NotRestoredExplanations { get; private set; }

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x06000C87 RID: 3207 RVA: 0x0000E658 File Offset: 0x0000C858
		// (set) Token: 0x06000C88 RID: 3208 RVA: 0x0000E660 File Offset: 0x0000C860
		[global::System.Runtime.Serialization.DataMember(Name = "notRestoredExplanationsTree", IsRequired = false)]
		public global::CefSharp.DevTools.Page.BackForwardCacheNotRestoredExplanationTree NotRestoredExplanationsTree { get; private set; }
	}
}
