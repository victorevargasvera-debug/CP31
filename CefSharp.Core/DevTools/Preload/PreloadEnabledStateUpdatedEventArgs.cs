using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Preload
{
	// Token: 0x020000AB RID: 171
	[global::System.Runtime.Serialization.DataContract]
	public class PreloadEnabledStateUpdatedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x17000235 RID: 565
		// (get) Token: 0x060005DF RID: 1503 RVA: 0x00008AA3 File Offset: 0x00006CA3
		// (set) Token: 0x060005E0 RID: 1504 RVA: 0x00008ABF File Offset: 0x00006CBF
		public global::CefSharp.DevTools.Preload.PreloadEnabledState State
		{
			get
			{
				return (global::CefSharp.DevTools.Preload.PreloadEnabledState)global::CefSharp.DevTools.DevToolsDomainEventArgsBase.StringToEnum(typeof(global::CefSharp.DevTools.Preload.PreloadEnabledState), this.state);
			}
			set
			{
				this.state = global::CefSharp.DevTools.DevToolsDomainEventArgsBase.EnumToString(value);
			}
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x060005E1 RID: 1505 RVA: 0x00008AD2 File Offset: 0x00006CD2
		// (set) Token: 0x060005E2 RID: 1506 RVA: 0x00008ADA File Offset: 0x00006CDA
		[global::System.Runtime.Serialization.DataMember(Name = "state", IsRequired = true)]
		internal string state { get; private set; }
	}
}
