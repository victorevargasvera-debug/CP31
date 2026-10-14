using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.WebAudio
{
	// Token: 0x020000D7 RID: 215
	[global::System.Runtime.Serialization.DataContract]
	public class AudioListenerCreatedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x0600070B RID: 1803 RVA: 0x00009AE8 File Offset: 0x00007CE8
		// (set) Token: 0x0600070C RID: 1804 RVA: 0x00009AF0 File Offset: 0x00007CF0
		[global::System.Runtime.Serialization.DataMember(Name = "listener", IsRequired = true)]
		public global::CefSharp.DevTools.WebAudio.AudioListener Listener { get; private set; }
	}
}
