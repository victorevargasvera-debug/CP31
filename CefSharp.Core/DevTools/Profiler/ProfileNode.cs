using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using CefSharp.DevTools.Runtime;

namespace CefSharp.DevTools.Profiler
{
	// Token: 0x0200005C RID: 92
	[global::System.Runtime.Serialization.DataContract]
	public class ProfileNode : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000142 RID: 322
		// (get) Token: 0x0600038B RID: 907 RVA: 0x000066E8 File Offset: 0x000048E8
		// (set) Token: 0x0600038C RID: 908 RVA: 0x000066F0 File Offset: 0x000048F0
		[global::System.Runtime.Serialization.DataMember(Name = "id", IsRequired = true)]
		public int Id { get; set; }

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x0600038D RID: 909 RVA: 0x000066F9 File Offset: 0x000048F9
		// (set) Token: 0x0600038E RID: 910 RVA: 0x00006701 File Offset: 0x00004901
		[global::System.Runtime.Serialization.DataMember(Name = "callFrame", IsRequired = true)]
		public global::CefSharp.DevTools.Runtime.CallFrame CallFrame { get; set; }

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x0600038F RID: 911 RVA: 0x0000670A File Offset: 0x0000490A
		// (set) Token: 0x06000390 RID: 912 RVA: 0x00006712 File Offset: 0x00004912
		[global::System.Runtime.Serialization.DataMember(Name = "hitCount", IsRequired = false)]
		public int? HitCount { get; set; }

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x06000391 RID: 913 RVA: 0x0000671B File Offset: 0x0000491B
		// (set) Token: 0x06000392 RID: 914 RVA: 0x00006723 File Offset: 0x00004923
		[global::System.Runtime.Serialization.DataMember(Name = "children", IsRequired = false)]
		public int[] Children { get; set; }

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x06000393 RID: 915 RVA: 0x0000672C File Offset: 0x0000492C
		// (set) Token: 0x06000394 RID: 916 RVA: 0x00006734 File Offset: 0x00004934
		[global::System.Runtime.Serialization.DataMember(Name = "deoptReason", IsRequired = false)]
		public string DeoptReason { get; set; }

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x06000395 RID: 917 RVA: 0x0000673D File Offset: 0x0000493D
		// (set) Token: 0x06000396 RID: 918 RVA: 0x00006745 File Offset: 0x00004945
		[global::System.Runtime.Serialization.DataMember(Name = "positionTicks", IsRequired = false)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.Profiler.PositionTickInfo> PositionTicks { get; set; }
	}
}
