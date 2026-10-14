using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Debugger
{
	// Token: 0x02000092 RID: 146
	[global::System.Runtime.Serialization.DataContract]
	public class SetInstrumentationBreakpointResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170001FB RID: 507
		// (get) Token: 0x06000538 RID: 1336 RVA: 0x00007ABB File Offset: 0x00005CBB
		// (set) Token: 0x06000539 RID: 1337 RVA: 0x00007AC3 File Offset: 0x00005CC3
		[global::System.Runtime.Serialization.DataMember]
		internal string breakpointId { get; set; }

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x0600053A RID: 1338 RVA: 0x00007ACC File Offset: 0x00005CCC
		public string BreakpointId
		{
			get
			{
				return this.breakpointId;
			}
		}
	}
}
