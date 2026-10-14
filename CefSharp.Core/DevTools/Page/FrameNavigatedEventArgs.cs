using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Page
{
	// Token: 0x02000195 RID: 405
	[global::System.Runtime.Serialization.DataContract]
	public class FrameNavigatedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x06000C2A RID: 3114 RVA: 0x0000E293 File Offset: 0x0000C493
		// (set) Token: 0x06000C2B RID: 3115 RVA: 0x0000E29B File Offset: 0x0000C49B
		[global::System.Runtime.Serialization.DataMember(Name = "frame", IsRequired = true)]
		public global::CefSharp.DevTools.Page.Frame Frame { get; private set; }

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06000C2C RID: 3116 RVA: 0x0000E2A4 File Offset: 0x0000C4A4
		// (set) Token: 0x06000C2D RID: 3117 RVA: 0x0000E2C0 File Offset: 0x0000C4C0
		public global::CefSharp.DevTools.Page.NavigationType Type
		{
			get
			{
				return (global::CefSharp.DevTools.Page.NavigationType)global::CefSharp.DevTools.DevToolsDomainEventArgsBase.StringToEnum(typeof(global::CefSharp.DevTools.Page.NavigationType), this.type);
			}
			set
			{
				this.type = global::CefSharp.DevTools.DevToolsDomainEventArgsBase.EnumToString(value);
			}
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06000C2E RID: 3118 RVA: 0x0000E2D3 File Offset: 0x0000C4D3
		// (set) Token: 0x06000C2F RID: 3119 RVA: 0x0000E2DB File Offset: 0x0000C4DB
		[global::System.Runtime.Serialization.DataMember(Name = "type", IsRequired = true)]
		internal string type { get; private set; }
	}
}
