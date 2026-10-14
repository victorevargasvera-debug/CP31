using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Debugger
{
	// Token: 0x02000091 RID: 145
	[global::System.Runtime.Serialization.DataContract]
	public class SetBreakpointResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06000531 RID: 1329 RVA: 0x00007A81 File Offset: 0x00005C81
		// (set) Token: 0x06000532 RID: 1330 RVA: 0x00007A89 File Offset: 0x00005C89
		[global::System.Runtime.Serialization.DataMember]
		internal string breakpointId { get; set; }

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06000533 RID: 1331 RVA: 0x00007A92 File Offset: 0x00005C92
		public string BreakpointId
		{
			get
			{
				return this.breakpointId;
			}
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06000534 RID: 1332 RVA: 0x00007A9A File Offset: 0x00005C9A
		// (set) Token: 0x06000535 RID: 1333 RVA: 0x00007AA2 File Offset: 0x00005CA2
		[global::System.Runtime.Serialization.DataMember]
		internal global::CefSharp.DevTools.Debugger.Location actualLocation { get; set; }

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x06000536 RID: 1334 RVA: 0x00007AAB File Offset: 0x00005CAB
		public global::CefSharp.DevTools.Debugger.Location ActualLocation
		{
			get
			{
				return this.actualLocation;
			}
		}
	}
}
