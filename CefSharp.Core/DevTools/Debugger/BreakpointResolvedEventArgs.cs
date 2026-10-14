using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Debugger
{
	// Token: 0x02000083 RID: 131
	[global::System.Runtime.Serialization.DataContract]
	public class BreakpointResolvedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x06000494 RID: 1172 RVA: 0x000074F9 File Offset: 0x000056F9
		// (set) Token: 0x06000495 RID: 1173 RVA: 0x00007501 File Offset: 0x00005701
		[global::System.Runtime.Serialization.DataMember(Name = "breakpointId", IsRequired = true)]
		public string BreakpointId { get; private set; }

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x06000496 RID: 1174 RVA: 0x0000750A File Offset: 0x0000570A
		// (set) Token: 0x06000497 RID: 1175 RVA: 0x00007512 File Offset: 0x00005712
		[global::System.Runtime.Serialization.DataMember(Name = "location", IsRequired = true)]
		public global::CefSharp.DevTools.Debugger.Location Location { get; private set; }
	}
}
