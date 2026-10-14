using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Page
{
	// Token: 0x020001A5 RID: 421
	[global::System.Runtime.Serialization.DataContract]
	public class ScreencastVisibilityChangedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06000C99 RID: 3225 RVA: 0x0000E6EF File Offset: 0x0000C8EF
		// (set) Token: 0x06000C9A RID: 3226 RVA: 0x0000E6F7 File Offset: 0x0000C8F7
		[global::System.Runtime.Serialization.DataMember(Name = "visible", IsRequired = true)]
		public bool Visible { get; private set; }
	}
}
