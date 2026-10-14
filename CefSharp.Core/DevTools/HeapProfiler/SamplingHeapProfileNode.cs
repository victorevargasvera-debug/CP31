using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using CefSharp.DevTools.Runtime;

namespace CefSharp.DevTools.HeapProfiler
{
	// Token: 0x0200006A RID: 106
	[global::System.Runtime.Serialization.DataContract]
	public class SamplingHeapProfileNode : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x1700016C RID: 364
		// (get) Token: 0x060003F7 RID: 1015 RVA: 0x00006C10 File Offset: 0x00004E10
		// (set) Token: 0x060003F8 RID: 1016 RVA: 0x00006C18 File Offset: 0x00004E18
		[global::System.Runtime.Serialization.DataMember(Name = "callFrame", IsRequired = true)]
		public global::CefSharp.DevTools.Runtime.CallFrame CallFrame { get; set; }

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x060003F9 RID: 1017 RVA: 0x00006C21 File Offset: 0x00004E21
		// (set) Token: 0x060003FA RID: 1018 RVA: 0x00006C29 File Offset: 0x00004E29
		[global::System.Runtime.Serialization.DataMember(Name = "selfSize", IsRequired = true)]
		public double SelfSize { get; set; }

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x060003FB RID: 1019 RVA: 0x00006C32 File Offset: 0x00004E32
		// (set) Token: 0x060003FC RID: 1020 RVA: 0x00006C3A File Offset: 0x00004E3A
		[global::System.Runtime.Serialization.DataMember(Name = "id", IsRequired = true)]
		public int Id { get; set; }

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x060003FD RID: 1021 RVA: 0x00006C43 File Offset: 0x00004E43
		// (set) Token: 0x060003FE RID: 1022 RVA: 0x00006C4B File Offset: 0x00004E4B
		[global::System.Runtime.Serialization.DataMember(Name = "children", IsRequired = true)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.HeapProfiler.SamplingHeapProfileNode> Children { get; set; }
	}
}
