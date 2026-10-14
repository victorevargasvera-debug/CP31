using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using CefSharp.DevTools.Runtime;

namespace CefSharp.DevTools.Debugger
{
	// Token: 0x0200008F RID: 143
	[global::System.Runtime.Serialization.DataContract]
	public class RestartFrameResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170001EF RID: 495
		// (get) Token: 0x06000523 RID: 1315 RVA: 0x00007A0D File Offset: 0x00005C0D
		// (set) Token: 0x06000524 RID: 1316 RVA: 0x00007A15 File Offset: 0x00005C15
		[global::System.Runtime.Serialization.DataMember]
		internal global::System.Collections.Generic.IList<global::CefSharp.DevTools.Debugger.CallFrame> callFrames { get; set; }

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x06000525 RID: 1317 RVA: 0x00007A1E File Offset: 0x00005C1E
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.Debugger.CallFrame> CallFrames
		{
			get
			{
				return this.callFrames;
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x06000526 RID: 1318 RVA: 0x00007A26 File Offset: 0x00005C26
		// (set) Token: 0x06000527 RID: 1319 RVA: 0x00007A2E File Offset: 0x00005C2E
		[global::System.Runtime.Serialization.DataMember]
		internal global::CefSharp.DevTools.Runtime.StackTrace asyncStackTrace { get; set; }

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x06000528 RID: 1320 RVA: 0x00007A37 File Offset: 0x00005C37
		public global::CefSharp.DevTools.Runtime.StackTrace AsyncStackTrace
		{
			get
			{
				return this.asyncStackTrace;
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x06000529 RID: 1321 RVA: 0x00007A3F File Offset: 0x00005C3F
		// (set) Token: 0x0600052A RID: 1322 RVA: 0x00007A47 File Offset: 0x00005C47
		[global::System.Runtime.Serialization.DataMember]
		internal global::CefSharp.DevTools.Runtime.StackTraceId asyncStackTraceId { get; set; }

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x0600052B RID: 1323 RVA: 0x00007A50 File Offset: 0x00005C50
		public global::CefSharp.DevTools.Runtime.StackTraceId AsyncStackTraceId
		{
			get
			{
				return this.asyncStackTraceId;
			}
		}
	}
}
