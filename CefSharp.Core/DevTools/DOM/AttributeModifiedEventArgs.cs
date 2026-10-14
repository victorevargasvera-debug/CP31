using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.DOM
{
	// Token: 0x020002BD RID: 701
	[global::System.Runtime.Serialization.DataContract]
	public class AttributeModifiedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x17000871 RID: 2161
		// (get) Token: 0x060015AC RID: 5548 RVA: 0x000179E3 File Offset: 0x00015BE3
		// (set) Token: 0x060015AD RID: 5549 RVA: 0x000179EB File Offset: 0x00015BEB
		[global::System.Runtime.Serialization.DataMember(Name = "nodeId", IsRequired = true)]
		public int NodeId { get; private set; }

		// Token: 0x17000872 RID: 2162
		// (get) Token: 0x060015AE RID: 5550 RVA: 0x000179F4 File Offset: 0x00015BF4
		// (set) Token: 0x060015AF RID: 5551 RVA: 0x000179FC File Offset: 0x00015BFC
		[global::System.Runtime.Serialization.DataMember(Name = "name", IsRequired = true)]
		public string Name { get; private set; }

		// Token: 0x17000873 RID: 2163
		// (get) Token: 0x060015B0 RID: 5552 RVA: 0x00017A05 File Offset: 0x00015C05
		// (set) Token: 0x060015B1 RID: 5553 RVA: 0x00017A0D File Offset: 0x00015C0D
		[global::System.Runtime.Serialization.DataMember(Name = "value", IsRequired = true)]
		public string Value { get; private set; }
	}
}
