using System;
using System.Runtime.Serialization;
using CefSharp.DevTools.Page;

namespace CefSharp.DevTools.Overlay
{
	// Token: 0x020001D6 RID: 470
	[global::System.Runtime.Serialization.DataContract]
	public class ScreenshotRequestedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x06000E30 RID: 3632 RVA: 0x0001023E File Offset: 0x0000E43E
		// (set) Token: 0x06000E31 RID: 3633 RVA: 0x00010246 File Offset: 0x0000E446
		[global::System.Runtime.Serialization.DataMember(Name = "viewport", IsRequired = true)]
		public global::CefSharp.DevTools.Page.Viewport Viewport { get; private set; }
	}
}
