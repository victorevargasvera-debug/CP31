using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Debugger
{
	// Token: 0x02000093 RID: 147
	[global::System.Runtime.Serialization.DataContract]
	public class SetBreakpointByUrlResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170001FD RID: 509
		// (get) Token: 0x0600053C RID: 1340 RVA: 0x00007ADC File Offset: 0x00005CDC
		// (set) Token: 0x0600053D RID: 1341 RVA: 0x00007AE4 File Offset: 0x00005CE4
		[global::System.Runtime.Serialization.DataMember]
		internal string breakpointId { get; set; }

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x0600053E RID: 1342 RVA: 0x00007AED File Offset: 0x00005CED
		public string BreakpointId
		{
			get
			{
				return this.breakpointId;
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x0600053F RID: 1343 RVA: 0x00007AF5 File Offset: 0x00005CF5
		// (set) Token: 0x06000540 RID: 1344 RVA: 0x00007AFD File Offset: 0x00005CFD
		[global::System.Runtime.Serialization.DataMember]
		internal global::System.Collections.Generic.IList<global::CefSharp.DevTools.Debugger.Location> locations { get; set; }

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x06000541 RID: 1345 RVA: 0x00007B06 File Offset: 0x00005D06
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.Debugger.Location> Locations
		{
			get
			{
				return this.locations;
			}
		}
	}
}
