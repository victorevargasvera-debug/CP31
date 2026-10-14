using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Log
{
	// Token: 0x02000252 RID: 594
	[global::System.Runtime.Serialization.DataContract]
	public class EntryAddedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x17000722 RID: 1826
		// (get) Token: 0x06001263 RID: 4707 RVA: 0x00013F79 File Offset: 0x00012179
		// (set) Token: 0x06001264 RID: 4708 RVA: 0x00013F81 File Offset: 0x00012181
		[global::System.Runtime.Serialization.DataMember(Name = "entry", IsRequired = true)]
		public global::CefSharp.DevTools.Log.LogEntry Entry { get; private set; }
	}
}
