using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.WebAudio
{
	// Token: 0x020000D9 RID: 217
	[global::System.Runtime.Serialization.DataContract]
	public class AudioNodeCreatedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x06000713 RID: 1811 RVA: 0x00009B2B File Offset: 0x00007D2B
		// (set) Token: 0x06000714 RID: 1812 RVA: 0x00009B33 File Offset: 0x00007D33
		[global::System.Runtime.Serialization.DataMember(Name = "node", IsRequired = true)]
		public global::CefSharp.DevTools.WebAudio.AudioNode Node { get; private set; }
	}
}
