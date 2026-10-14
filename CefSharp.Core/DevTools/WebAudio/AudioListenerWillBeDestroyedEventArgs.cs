using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.WebAudio
{
	// Token: 0x020000D8 RID: 216
	[global::System.Runtime.Serialization.DataContract]
	public class AudioListenerWillBeDestroyedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x0600070E RID: 1806 RVA: 0x00009B01 File Offset: 0x00007D01
		// (set) Token: 0x0600070F RID: 1807 RVA: 0x00009B09 File Offset: 0x00007D09
		[global::System.Runtime.Serialization.DataMember(Name = "contextId", IsRequired = true)]
		public string ContextId { get; private set; }

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x06000710 RID: 1808 RVA: 0x00009B12 File Offset: 0x00007D12
		// (set) Token: 0x06000711 RID: 1809 RVA: 0x00009B1A File Offset: 0x00007D1A
		[global::System.Runtime.Serialization.DataMember(Name = "listenerId", IsRequired = true)]
		public string ListenerId { get; private set; }
	}
}
