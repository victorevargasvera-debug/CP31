using System;
using System.Runtime.Serialization;
using CefSharp.DevTools.Runtime;

namespace CefSharp.DevTools.Debugger
{
	// Token: 0x0200008E RID: 142
	[global::System.Runtime.Serialization.DataContract]
	public class GetStackTraceResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170001ED RID: 493
		// (get) Token: 0x0600051F RID: 1311 RVA: 0x000079EC File Offset: 0x00005BEC
		// (set) Token: 0x06000520 RID: 1312 RVA: 0x000079F4 File Offset: 0x00005BF4
		[global::System.Runtime.Serialization.DataMember]
		internal global::CefSharp.DevTools.Runtime.StackTrace stackTrace { get; set; }

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06000521 RID: 1313 RVA: 0x000079FD File Offset: 0x00005BFD
		public global::CefSharp.DevTools.Runtime.StackTrace StackTrace
		{
			get
			{
				return this.stackTrace;
			}
		}
	}
}
