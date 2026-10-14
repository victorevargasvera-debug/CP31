using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Runtime
{
	// Token: 0x02000047 RID: 71
	[global::System.Runtime.Serialization.DataContract]
	public class StackTraceId : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000104 RID: 260
		// (get) Token: 0x060002E8 RID: 744 RVA: 0x00005818 File Offset: 0x00003A18
		// (set) Token: 0x060002E9 RID: 745 RVA: 0x00005820 File Offset: 0x00003A20
		[global::System.Runtime.Serialization.DataMember(Name = "id", IsRequired = true)]
		public string Id { get; set; }

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x060002EA RID: 746 RVA: 0x00005829 File Offset: 0x00003A29
		// (set) Token: 0x060002EB RID: 747 RVA: 0x00005831 File Offset: 0x00003A31
		[global::System.Runtime.Serialization.DataMember(Name = "debuggerId", IsRequired = false)]
		public string DebuggerId { get; set; }
	}
}
