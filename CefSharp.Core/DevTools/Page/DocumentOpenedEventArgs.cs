using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Page
{
	// Token: 0x02000196 RID: 406
	[global::System.Runtime.Serialization.DataContract]
	public class DocumentOpenedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06000C31 RID: 3121 RVA: 0x0000E2EC File Offset: 0x0000C4EC
		// (set) Token: 0x06000C32 RID: 3122 RVA: 0x0000E2F4 File Offset: 0x0000C4F4
		[global::System.Runtime.Serialization.DataMember(Name = "frame", IsRequired = true)]
		public global::CefSharp.DevTools.Page.Frame Frame { get; private set; }
	}
}
