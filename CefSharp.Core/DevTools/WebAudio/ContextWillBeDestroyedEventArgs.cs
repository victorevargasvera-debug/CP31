using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.WebAudio
{
	// Token: 0x020000D5 RID: 213
	[global::System.Runtime.Serialization.DataContract]
	public class ContextWillBeDestroyedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x06000705 RID: 1797 RVA: 0x00009AB6 File Offset: 0x00007CB6
		// (set) Token: 0x06000706 RID: 1798 RVA: 0x00009ABE File Offset: 0x00007CBE
		[global::System.Runtime.Serialization.DataMember(Name = "contextId", IsRequired = true)]
		public string ContextId { get; private set; }
	}
}
