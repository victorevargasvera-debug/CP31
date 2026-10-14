using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Preload
{
	// Token: 0x020000AE RID: 174
	[global::System.Runtime.Serialization.DataContract]
	public class PreloadingAttemptSourcesUpdatedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x17000241 RID: 577
		// (get) Token: 0x060005FA RID: 1530 RVA: 0x00008BE1 File Offset: 0x00006DE1
		// (set) Token: 0x060005FB RID: 1531 RVA: 0x00008BE9 File Offset: 0x00006DE9
		[global::System.Runtime.Serialization.DataMember(Name = "loaderId", IsRequired = true)]
		public string LoaderId { get; private set; }

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x060005FC RID: 1532 RVA: 0x00008BF2 File Offset: 0x00006DF2
		// (set) Token: 0x060005FD RID: 1533 RVA: 0x00008BFA File Offset: 0x00006DFA
		[global::System.Runtime.Serialization.DataMember(Name = "preloadingAttemptSources", IsRequired = true)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.Preload.PreloadingAttemptSource> PreloadingAttemptSources { get; private set; }
	}
}
