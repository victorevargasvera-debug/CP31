using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using CefSharp.DevTools.Runtime;

namespace CefSharp.DevTools.Debugger
{
	// Token: 0x02000079 RID: 121
	[global::System.Runtime.Serialization.DataContract]
	public class CallFrame : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x1700018C RID: 396
		// (get) Token: 0x06000458 RID: 1112 RVA: 0x000072A4 File Offset: 0x000054A4
		// (set) Token: 0x06000459 RID: 1113 RVA: 0x000072AC File Offset: 0x000054AC
		[global::System.Runtime.Serialization.DataMember(Name = "callFrameId", IsRequired = true)]
		public string CallFrameId { get; set; }

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x0600045A RID: 1114 RVA: 0x000072B5 File Offset: 0x000054B5
		// (set) Token: 0x0600045B RID: 1115 RVA: 0x000072BD File Offset: 0x000054BD
		[global::System.Runtime.Serialization.DataMember(Name = "functionName", IsRequired = true)]
		public string FunctionName { get; set; }

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x0600045C RID: 1116 RVA: 0x000072C6 File Offset: 0x000054C6
		// (set) Token: 0x0600045D RID: 1117 RVA: 0x000072CE File Offset: 0x000054CE
		[global::System.Runtime.Serialization.DataMember(Name = "functionLocation", IsRequired = false)]
		public global::CefSharp.DevTools.Debugger.Location FunctionLocation { get; set; }

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x0600045E RID: 1118 RVA: 0x000072D7 File Offset: 0x000054D7
		// (set) Token: 0x0600045F RID: 1119 RVA: 0x000072DF File Offset: 0x000054DF
		[global::System.Runtime.Serialization.DataMember(Name = "location", IsRequired = true)]
		public global::CefSharp.DevTools.Debugger.Location Location { get; set; }

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06000460 RID: 1120 RVA: 0x000072E8 File Offset: 0x000054E8
		// (set) Token: 0x06000461 RID: 1121 RVA: 0x000072F0 File Offset: 0x000054F0
		[global::System.Runtime.Serialization.DataMember(Name = "url", IsRequired = true)]
		public string Url { get; set; }

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x06000462 RID: 1122 RVA: 0x000072F9 File Offset: 0x000054F9
		// (set) Token: 0x06000463 RID: 1123 RVA: 0x00007301 File Offset: 0x00005501
		[global::System.Runtime.Serialization.DataMember(Name = "scopeChain", IsRequired = true)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.Debugger.Scope> ScopeChain { get; set; }

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x06000464 RID: 1124 RVA: 0x0000730A File Offset: 0x0000550A
		// (set) Token: 0x06000465 RID: 1125 RVA: 0x00007312 File Offset: 0x00005512
		[global::System.Runtime.Serialization.DataMember(Name = "this", IsRequired = true)]
		public global::CefSharp.DevTools.Runtime.RemoteObject This { get; set; }

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x06000466 RID: 1126 RVA: 0x0000731B File Offset: 0x0000551B
		// (set) Token: 0x06000467 RID: 1127 RVA: 0x00007323 File Offset: 0x00005523
		[global::System.Runtime.Serialization.DataMember(Name = "returnValue", IsRequired = false)]
		public global::CefSharp.DevTools.Runtime.RemoteObject ReturnValue { get; set; }

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x06000468 RID: 1128 RVA: 0x0000732C File Offset: 0x0000552C
		// (set) Token: 0x06000469 RID: 1129 RVA: 0x00007334 File Offset: 0x00005534
		[global::System.Runtime.Serialization.DataMember(Name = "canBeRestarted", IsRequired = false)]
		public bool? CanBeRestarted { get; set; }
	}
}
