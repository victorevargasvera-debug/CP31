using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.WebAudio
{
	// Token: 0x020000DA RID: 218
	[global::System.Runtime.Serialization.DataContract]
	public class AudioNodeWillBeDestroyedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x06000716 RID: 1814 RVA: 0x00009B44 File Offset: 0x00007D44
		// (set) Token: 0x06000717 RID: 1815 RVA: 0x00009B4C File Offset: 0x00007D4C
		[global::System.Runtime.Serialization.DataMember(Name = "contextId", IsRequired = true)]
		public string ContextId { get; private set; }

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x06000718 RID: 1816 RVA: 0x00009B55 File Offset: 0x00007D55
		// (set) Token: 0x06000719 RID: 1817 RVA: 0x00009B5D File Offset: 0x00007D5D
		[global::System.Runtime.Serialization.DataMember(Name = "nodeId", IsRequired = true)]
		public string NodeId { get; private set; }
	}
}
