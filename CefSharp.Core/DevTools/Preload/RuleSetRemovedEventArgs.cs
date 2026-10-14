using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Preload
{
	// Token: 0x020000A9 RID: 169
	[global::System.Runtime.Serialization.DataContract]
	public class RuleSetRemovedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x1700022E RID: 558
		// (get) Token: 0x060005CF RID: 1487 RVA: 0x000089FE File Offset: 0x00006BFE
		// (set) Token: 0x060005D0 RID: 1488 RVA: 0x00008A06 File Offset: 0x00006C06
		[global::System.Runtime.Serialization.DataMember(Name = "id", IsRequired = true)]
		public string Id { get; private set; }
	}
}
