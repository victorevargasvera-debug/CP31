using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Page
{
	// Token: 0x02000198 RID: 408
	[global::System.Runtime.Serialization.DataContract]
	public class FrameScheduledNavigationEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x06000C41 RID: 3137 RVA: 0x0000E3AF File Offset: 0x0000C5AF
		// (set) Token: 0x06000C42 RID: 3138 RVA: 0x0000E3B7 File Offset: 0x0000C5B7
		[global::System.Runtime.Serialization.DataMember(Name = "frameId", IsRequired = true)]
		public string FrameId { get; private set; }

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x06000C43 RID: 3139 RVA: 0x0000E3C0 File Offset: 0x0000C5C0
		// (set) Token: 0x06000C44 RID: 3140 RVA: 0x0000E3C8 File Offset: 0x0000C5C8
		[global::System.Runtime.Serialization.DataMember(Name = "delay", IsRequired = true)]
		public double Delay { get; private set; }

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x06000C45 RID: 3141 RVA: 0x0000E3D1 File Offset: 0x0000C5D1
		// (set) Token: 0x06000C46 RID: 3142 RVA: 0x0000E3ED File Offset: 0x0000C5ED
		public global::CefSharp.DevTools.Page.ClientNavigationReason Reason
		{
			get
			{
				return (global::CefSharp.DevTools.Page.ClientNavigationReason)global::CefSharp.DevTools.DevToolsDomainEventArgsBase.StringToEnum(typeof(global::CefSharp.DevTools.Page.ClientNavigationReason), this.reason);
			}
			set
			{
				this.reason = global::CefSharp.DevTools.DevToolsDomainEventArgsBase.EnumToString(value);
			}
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x06000C47 RID: 3143 RVA: 0x0000E400 File Offset: 0x0000C600
		// (set) Token: 0x06000C48 RID: 3144 RVA: 0x0000E408 File Offset: 0x0000C608
		[global::System.Runtime.Serialization.DataMember(Name = "reason", IsRequired = true)]
		internal string reason { get; private set; }

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06000C49 RID: 3145 RVA: 0x0000E411 File Offset: 0x0000C611
		// (set) Token: 0x06000C4A RID: 3146 RVA: 0x0000E419 File Offset: 0x0000C619
		[global::System.Runtime.Serialization.DataMember(Name = "url", IsRequired = true)]
		public string Url { get; private set; }
	}
}
