using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Debugger
{
	// Token: 0x02000078 RID: 120
	[global::System.Runtime.Serialization.DataContract]
	public class LocationRange : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000189 RID: 393
		// (get) Token: 0x06000451 RID: 1105 RVA: 0x00007269 File Offset: 0x00005469
		// (set) Token: 0x06000452 RID: 1106 RVA: 0x00007271 File Offset: 0x00005471
		[global::System.Runtime.Serialization.DataMember(Name = "scriptId", IsRequired = true)]
		public string ScriptId { get; set; }

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x06000453 RID: 1107 RVA: 0x0000727A File Offset: 0x0000547A
		// (set) Token: 0x06000454 RID: 1108 RVA: 0x00007282 File Offset: 0x00005482
		[global::System.Runtime.Serialization.DataMember(Name = "start", IsRequired = true)]
		public global::CefSharp.DevTools.Debugger.ScriptPosition Start { get; set; }

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x06000455 RID: 1109 RVA: 0x0000728B File Offset: 0x0000548B
		// (set) Token: 0x06000456 RID: 1110 RVA: 0x00007293 File Offset: 0x00005493
		[global::System.Runtime.Serialization.DataMember(Name = "end", IsRequired = true)]
		public global::CefSharp.DevTools.Debugger.ScriptPosition End { get; set; }
	}
}
