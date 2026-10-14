using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.WebAudio
{
	// Token: 0x020000DB RID: 219
	[global::System.Runtime.Serialization.DataContract]
	public class AudioParamCreatedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x0600071B RID: 1819 RVA: 0x00009B6E File Offset: 0x00007D6E
		// (set) Token: 0x0600071C RID: 1820 RVA: 0x00009B76 File Offset: 0x00007D76
		[global::System.Runtime.Serialization.DataMember(Name = "param", IsRequired = true)]
		public global::CefSharp.DevTools.WebAudio.AudioParam Param { get; private set; }
	}
}
