using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.SystemInfo
{
	// Token: 0x0200011E RID: 286
	[global::System.Runtime.Serialization.DataContract]
	public class GetProcessInfoResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06000900 RID: 2304 RVA: 0x0000BA17 File Offset: 0x00009C17
		// (set) Token: 0x06000901 RID: 2305 RVA: 0x0000BA1F File Offset: 0x00009C1F
		[global::System.Runtime.Serialization.DataMember]
		internal global::System.Collections.Generic.IList<global::CefSharp.DevTools.SystemInfo.ProcessInfo> processInfo { get; set; }

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06000902 RID: 2306 RVA: 0x0000BA28 File Offset: 0x00009C28
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.SystemInfo.ProcessInfo> ProcessInfo
		{
			get
			{
				return this.processInfo;
			}
		}
	}
}
