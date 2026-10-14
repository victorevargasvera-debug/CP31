using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using CefSharp.DevTools.Runtime;

namespace CefSharp.DevTools.Debugger
{
	// Token: 0x02000095 RID: 149
	[global::System.Runtime.Serialization.DataContract]
	public class SetScriptSourceResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x17000203 RID: 515
		// (get) Token: 0x06000547 RID: 1351 RVA: 0x00007B37 File Offset: 0x00005D37
		// (set) Token: 0x06000548 RID: 1352 RVA: 0x00007B3F File Offset: 0x00005D3F
		[global::System.Runtime.Serialization.DataMember]
		internal global::System.Collections.Generic.IList<global::CefSharp.DevTools.Debugger.CallFrame> callFrames { get; set; }

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x06000549 RID: 1353 RVA: 0x00007B48 File Offset: 0x00005D48
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.Debugger.CallFrame> CallFrames
		{
			get
			{
				return this.callFrames;
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x0600054A RID: 1354 RVA: 0x00007B50 File Offset: 0x00005D50
		// (set) Token: 0x0600054B RID: 1355 RVA: 0x00007B58 File Offset: 0x00005D58
		[global::System.Runtime.Serialization.DataMember]
		internal bool? stackChanged { get; set; }

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x0600054C RID: 1356 RVA: 0x00007B61 File Offset: 0x00005D61
		public bool? StackChanged
		{
			get
			{
				return this.stackChanged;
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x0600054D RID: 1357 RVA: 0x00007B69 File Offset: 0x00005D69
		// (set) Token: 0x0600054E RID: 1358 RVA: 0x00007B71 File Offset: 0x00005D71
		[global::System.Runtime.Serialization.DataMember]
		internal global::CefSharp.DevTools.Runtime.StackTrace asyncStackTrace { get; set; }

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x0600054F RID: 1359 RVA: 0x00007B7A File Offset: 0x00005D7A
		public global::CefSharp.DevTools.Runtime.StackTrace AsyncStackTrace
		{
			get
			{
				return this.asyncStackTrace;
			}
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06000550 RID: 1360 RVA: 0x00007B82 File Offset: 0x00005D82
		// (set) Token: 0x06000551 RID: 1361 RVA: 0x00007B8A File Offset: 0x00005D8A
		[global::System.Runtime.Serialization.DataMember]
		internal global::CefSharp.DevTools.Runtime.StackTraceId asyncStackTraceId { get; set; }

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x06000552 RID: 1362 RVA: 0x00007B93 File Offset: 0x00005D93
		public global::CefSharp.DevTools.Runtime.StackTraceId AsyncStackTraceId
		{
			get
			{
				return this.asyncStackTraceId;
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x06000553 RID: 1363 RVA: 0x00007B9B File Offset: 0x00005D9B
		// (set) Token: 0x06000554 RID: 1364 RVA: 0x00007BA3 File Offset: 0x00005DA3
		[global::System.Runtime.Serialization.DataMember]
		internal string status { get; set; }

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x06000555 RID: 1365 RVA: 0x00007BAC File Offset: 0x00005DAC
		public string Status
		{
			get
			{
				return this.status;
			}
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x06000556 RID: 1366 RVA: 0x00007BB4 File Offset: 0x00005DB4
		// (set) Token: 0x06000557 RID: 1367 RVA: 0x00007BBC File Offset: 0x00005DBC
		[global::System.Runtime.Serialization.DataMember]
		internal global::CefSharp.DevTools.Runtime.ExceptionDetails exceptionDetails { get; set; }

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x06000558 RID: 1368 RVA: 0x00007BC5 File Offset: 0x00005DC5
		public global::CefSharp.DevTools.Runtime.ExceptionDetails ExceptionDetails
		{
			get
			{
				return this.exceptionDetails;
			}
		}
	}
}
