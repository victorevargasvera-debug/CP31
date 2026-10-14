using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Page
{
	// Token: 0x02000197 RID: 407
	[global::System.Runtime.Serialization.DataContract]
	public class FrameRequestedNavigationEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06000C34 RID: 3124 RVA: 0x0000E305 File Offset: 0x0000C505
		// (set) Token: 0x06000C35 RID: 3125 RVA: 0x0000E30D File Offset: 0x0000C50D
		[global::System.Runtime.Serialization.DataMember(Name = "frameId", IsRequired = true)]
		public string FrameId { get; private set; }

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06000C36 RID: 3126 RVA: 0x0000E316 File Offset: 0x0000C516
		// (set) Token: 0x06000C37 RID: 3127 RVA: 0x0000E332 File Offset: 0x0000C532
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

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06000C38 RID: 3128 RVA: 0x0000E345 File Offset: 0x0000C545
		// (set) Token: 0x06000C39 RID: 3129 RVA: 0x0000E34D File Offset: 0x0000C54D
		[global::System.Runtime.Serialization.DataMember(Name = "reason", IsRequired = true)]
		internal string reason { get; private set; }

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06000C3A RID: 3130 RVA: 0x0000E356 File Offset: 0x0000C556
		// (set) Token: 0x06000C3B RID: 3131 RVA: 0x0000E35E File Offset: 0x0000C55E
		[global::System.Runtime.Serialization.DataMember(Name = "url", IsRequired = true)]
		public string Url { get; private set; }

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x06000C3C RID: 3132 RVA: 0x0000E367 File Offset: 0x0000C567
		// (set) Token: 0x06000C3D RID: 3133 RVA: 0x0000E383 File Offset: 0x0000C583
		public global::CefSharp.DevTools.Page.ClientNavigationDisposition Disposition
		{
			get
			{
				return (global::CefSharp.DevTools.Page.ClientNavigationDisposition)global::CefSharp.DevTools.DevToolsDomainEventArgsBase.StringToEnum(typeof(global::CefSharp.DevTools.Page.ClientNavigationDisposition), this.disposition);
			}
			set
			{
				this.disposition = global::CefSharp.DevTools.DevToolsDomainEventArgsBase.EnumToString(value);
			}
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x06000C3E RID: 3134 RVA: 0x0000E396 File Offset: 0x0000C596
		// (set) Token: 0x06000C3F RID: 3135 RVA: 0x0000E39E File Offset: 0x0000C59E
		[global::System.Runtime.Serialization.DataMember(Name = "disposition", IsRequired = true)]
		internal string disposition { get; private set; }
	}
}
