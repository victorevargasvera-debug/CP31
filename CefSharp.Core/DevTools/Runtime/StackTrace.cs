using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Runtime
{
	// Token: 0x02000046 RID: 70
	[global::System.Runtime.Serialization.DataContract]
	public class StackTrace : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000100 RID: 256
		// (get) Token: 0x060002DF RID: 735 RVA: 0x000057CC File Offset: 0x000039CC
		// (set) Token: 0x060002E0 RID: 736 RVA: 0x000057D4 File Offset: 0x000039D4
		[global::System.Runtime.Serialization.DataMember(Name = "description", IsRequired = false)]
		public string Description { get; set; }

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x060002E1 RID: 737 RVA: 0x000057DD File Offset: 0x000039DD
		// (set) Token: 0x060002E2 RID: 738 RVA: 0x000057E5 File Offset: 0x000039E5
		[global::System.Runtime.Serialization.DataMember(Name = "callFrames", IsRequired = true)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.Runtime.CallFrame> CallFrames { get; set; }

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x060002E3 RID: 739 RVA: 0x000057EE File Offset: 0x000039EE
		// (set) Token: 0x060002E4 RID: 740 RVA: 0x000057F6 File Offset: 0x000039F6
		[global::System.Runtime.Serialization.DataMember(Name = "parent", IsRequired = false)]
		public global::CefSharp.DevTools.Runtime.StackTrace Parent { get; set; }

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x060002E5 RID: 741 RVA: 0x000057FF File Offset: 0x000039FF
		// (set) Token: 0x060002E6 RID: 742 RVA: 0x00005807 File Offset: 0x00003A07
		[global::System.Runtime.Serialization.DataMember(Name = "parentId", IsRequired = false)]
		public global::CefSharp.DevTools.Runtime.StackTraceId ParentId { get; set; }
	}
}
