using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Tracing
{
	// Token: 0x020000F6 RID: 246
	[global::System.Runtime.Serialization.DataContract]
	public class DataCollectedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x060007EE RID: 2030 RVA: 0x0000A867 File Offset: 0x00008A67
		// (set) Token: 0x060007EF RID: 2031 RVA: 0x0000A86F File Offset: 0x00008A6F
		[global::System.Runtime.Serialization.DataMember(Name = "value", IsRequired = true)]
		public global::System.Collections.Generic.IList<object> Value { get; private set; }
	}
}
