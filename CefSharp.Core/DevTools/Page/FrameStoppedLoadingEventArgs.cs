using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Page
{
	// Token: 0x0200019A RID: 410
	[global::System.Runtime.Serialization.DataContract]
	public class FrameStoppedLoadingEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x06000C4F RID: 3151 RVA: 0x0000E443 File Offset: 0x0000C643
		// (set) Token: 0x06000C50 RID: 3152 RVA: 0x0000E44B File Offset: 0x0000C64B
		[global::System.Runtime.Serialization.DataMember(Name = "frameId", IsRequired = true)]
		public string FrameId { get; private set; }
	}
}
