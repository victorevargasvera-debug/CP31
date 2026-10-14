using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using CefSharp.DevTools.Runtime;

namespace CefSharp.DevTools.Debugger
{
	// Token: 0x02000085 RID: 133
	[global::System.Runtime.Serialization.DataContract]
	public class PausedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x06000499 RID: 1177 RVA: 0x00007523 File Offset: 0x00005723
		// (set) Token: 0x0600049A RID: 1178 RVA: 0x0000752B File Offset: 0x0000572B
		[global::System.Runtime.Serialization.DataMember(Name = "callFrames", IsRequired = true)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.Debugger.CallFrame> CallFrames { get; private set; }

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x0600049B RID: 1179 RVA: 0x00007534 File Offset: 0x00005734
		// (set) Token: 0x0600049C RID: 1180 RVA: 0x00007550 File Offset: 0x00005750
		public global::CefSharp.DevTools.Debugger.PausedReason Reason
		{
			get
			{
				return (global::CefSharp.DevTools.Debugger.PausedReason)global::CefSharp.DevTools.DevToolsDomainEventArgsBase.StringToEnum(typeof(global::CefSharp.DevTools.Debugger.PausedReason), this.reason);
			}
			set
			{
				this.reason = global::CefSharp.DevTools.DevToolsDomainEventArgsBase.EnumToString(value);
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x0600049D RID: 1181 RVA: 0x00007563 File Offset: 0x00005763
		// (set) Token: 0x0600049E RID: 1182 RVA: 0x0000756B File Offset: 0x0000576B
		[global::System.Runtime.Serialization.DataMember(Name = "reason", IsRequired = true)]
		internal string reason { get; private set; }

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x0600049F RID: 1183 RVA: 0x00007574 File Offset: 0x00005774
		// (set) Token: 0x060004A0 RID: 1184 RVA: 0x0000757C File Offset: 0x0000577C
		[global::System.Runtime.Serialization.DataMember(Name = "data", IsRequired = false)]
		public object Data { get; private set; }

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x060004A1 RID: 1185 RVA: 0x00007585 File Offset: 0x00005785
		// (set) Token: 0x060004A2 RID: 1186 RVA: 0x0000758D File Offset: 0x0000578D
		[global::System.Runtime.Serialization.DataMember(Name = "hitBreakpoints", IsRequired = false)]
		public string[] HitBreakpoints { get; private set; }

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x060004A3 RID: 1187 RVA: 0x00007596 File Offset: 0x00005796
		// (set) Token: 0x060004A4 RID: 1188 RVA: 0x0000759E File Offset: 0x0000579E
		[global::System.Runtime.Serialization.DataMember(Name = "asyncStackTrace", IsRequired = false)]
		public global::CefSharp.DevTools.Runtime.StackTrace AsyncStackTrace { get; private set; }

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x060004A5 RID: 1189 RVA: 0x000075A7 File Offset: 0x000057A7
		// (set) Token: 0x060004A6 RID: 1190 RVA: 0x000075AF File Offset: 0x000057AF
		[global::System.Runtime.Serialization.DataMember(Name = "asyncStackTraceId", IsRequired = false)]
		public global::CefSharp.DevTools.Runtime.StackTraceId AsyncStackTraceId { get; private set; }

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x060004A7 RID: 1191 RVA: 0x000075B8 File Offset: 0x000057B8
		// (set) Token: 0x060004A8 RID: 1192 RVA: 0x000075C0 File Offset: 0x000057C0
		[global::System.Runtime.Serialization.DataMember(Name = "asyncCallStackTraceId", IsRequired = false)]
		public global::CefSharp.DevTools.Runtime.StackTraceId AsyncCallStackTraceId { get; private set; }
	}
}
