using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.WebAudio
{
	// Token: 0x020000D1 RID: 209
	[global::System.Runtime.Serialization.DataContract]
	public class AudioListener : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x1700028A RID: 650
		// (get) Token: 0x060006D5 RID: 1749 RVA: 0x000098C6 File Offset: 0x00007AC6
		// (set) Token: 0x060006D6 RID: 1750 RVA: 0x000098CE File Offset: 0x00007ACE
		[global::System.Runtime.Serialization.DataMember(Name = "listenerId", IsRequired = true)]
		public string ListenerId { get; set; }

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x060006D7 RID: 1751 RVA: 0x000098D7 File Offset: 0x00007AD7
		// (set) Token: 0x060006D8 RID: 1752 RVA: 0x000098DF File Offset: 0x00007ADF
		[global::System.Runtime.Serialization.DataMember(Name = "contextId", IsRequired = true)]
		public string ContextId { get; set; }
	}
}
