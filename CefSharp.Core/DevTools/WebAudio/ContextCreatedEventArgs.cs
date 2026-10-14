using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.WebAudio
{
	// Token: 0x020000D4 RID: 212
	[global::System.Runtime.Serialization.DataContract]
	public class ContextCreatedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06000702 RID: 1794 RVA: 0x00009A9D File Offset: 0x00007C9D
		// (set) Token: 0x06000703 RID: 1795 RVA: 0x00009AA5 File Offset: 0x00007CA5
		[global::System.Runtime.Serialization.DataMember(Name = "context", IsRequired = true)]
		public global::CefSharp.DevTools.WebAudio.BaseAudioContext Context { get; private set; }
	}
}
