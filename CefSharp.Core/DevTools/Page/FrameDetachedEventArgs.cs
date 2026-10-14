using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Page
{
	// Token: 0x02000194 RID: 404
	[global::System.Runtime.Serialization.DataContract]
	public class FrameDetachedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x06000C23 RID: 3107 RVA: 0x0000E23A File Offset: 0x0000C43A
		// (set) Token: 0x06000C24 RID: 3108 RVA: 0x0000E242 File Offset: 0x0000C442
		[global::System.Runtime.Serialization.DataMember(Name = "frameId", IsRequired = true)]
		public string FrameId { get; private set; }

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06000C25 RID: 3109 RVA: 0x0000E24B File Offset: 0x0000C44B
		// (set) Token: 0x06000C26 RID: 3110 RVA: 0x0000E267 File Offset: 0x0000C467
		public global::CefSharp.DevTools.Page.FrameDetachedReason Reason
		{
			get
			{
				return (global::CefSharp.DevTools.Page.FrameDetachedReason)global::CefSharp.DevTools.DevToolsDomainEventArgsBase.StringToEnum(typeof(global::CefSharp.DevTools.Page.FrameDetachedReason), this.reason);
			}
			set
			{
				this.reason = global::CefSharp.DevTools.DevToolsDomainEventArgsBase.EnumToString(value);
			}
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x06000C27 RID: 3111 RVA: 0x0000E27A File Offset: 0x0000C47A
		// (set) Token: 0x06000C28 RID: 3112 RVA: 0x0000E282 File Offset: 0x0000C482
		[global::System.Runtime.Serialization.DataMember(Name = "reason", IsRequired = true)]
		internal string reason { get; private set; }
	}
}
