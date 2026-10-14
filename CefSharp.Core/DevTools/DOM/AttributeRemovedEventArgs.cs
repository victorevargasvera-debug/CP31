using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.DOM
{
	// Token: 0x020002BE RID: 702
	[global::System.Runtime.Serialization.DataContract]
	public class AttributeRemovedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x17000874 RID: 2164
		// (get) Token: 0x060015B3 RID: 5555 RVA: 0x00017A1E File Offset: 0x00015C1E
		// (set) Token: 0x060015B4 RID: 5556 RVA: 0x00017A26 File Offset: 0x00015C26
		[global::System.Runtime.Serialization.DataMember(Name = "nodeId", IsRequired = true)]
		public int NodeId { get; private set; }

		// Token: 0x17000875 RID: 2165
		// (get) Token: 0x060015B5 RID: 5557 RVA: 0x00017A2F File Offset: 0x00015C2F
		// (set) Token: 0x060015B6 RID: 5558 RVA: 0x00017A37 File Offset: 0x00015C37
		[global::System.Runtime.Serialization.DataMember(Name = "name", IsRequired = true)]
		public string Name { get; private set; }
	}
}
