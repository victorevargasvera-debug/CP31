using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Runtime
{
	// Token: 0x02000040 RID: 64
	[global::System.Runtime.Serialization.DataContract]
	public class InternalPropertyDescriptor : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x0600029F RID: 671 RVA: 0x000055AF File Offset: 0x000037AF
		// (set) Token: 0x060002A0 RID: 672 RVA: 0x000055B7 File Offset: 0x000037B7
		[global::System.Runtime.Serialization.DataMember(Name = "name", IsRequired = true)]
		public string Name { get; set; }

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x060002A1 RID: 673 RVA: 0x000055C0 File Offset: 0x000037C0
		// (set) Token: 0x060002A2 RID: 674 RVA: 0x000055C8 File Offset: 0x000037C8
		[global::System.Runtime.Serialization.DataMember(Name = "value", IsRequired = false)]
		public global::CefSharp.DevTools.Runtime.RemoteObject Value { get; set; }
	}
}
