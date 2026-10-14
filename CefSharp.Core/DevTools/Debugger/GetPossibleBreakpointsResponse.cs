using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Debugger
{
	// Token: 0x0200008A RID: 138
	[global::System.Runtime.Serialization.DataContract]
	public class GetPossibleBreakpointsResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170001DD RID: 477
		// (get) Token: 0x06000503 RID: 1283 RVA: 0x000078FE File Offset: 0x00005AFE
		// (set) Token: 0x06000504 RID: 1284 RVA: 0x00007906 File Offset: 0x00005B06
		[global::System.Runtime.Serialization.DataMember]
		internal global::System.Collections.Generic.IList<global::CefSharp.DevTools.Debugger.BreakLocation> locations { get; set; }

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x06000505 RID: 1285 RVA: 0x0000790F File Offset: 0x00005B0F
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.Debugger.BreakLocation> Locations
		{
			get
			{
				return this.locations;
			}
		}
	}
}
