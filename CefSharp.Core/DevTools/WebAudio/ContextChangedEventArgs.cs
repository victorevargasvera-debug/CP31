using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.WebAudio
{
	// Token: 0x020000D6 RID: 214
	[global::System.Runtime.Serialization.DataContract]
	public class ContextChangedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x06000708 RID: 1800 RVA: 0x00009ACF File Offset: 0x00007CCF
		// (set) Token: 0x06000709 RID: 1801 RVA: 0x00009AD7 File Offset: 0x00007CD7
		[global::System.Runtime.Serialization.DataMember(Name = "context", IsRequired = true)]
		public global::CefSharp.DevTools.WebAudio.BaseAudioContext Context { get; private set; }
	}
}
