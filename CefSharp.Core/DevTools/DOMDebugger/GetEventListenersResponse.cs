using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.DOMDebugger
{
	// Token: 0x020002AF RID: 687
	[global::System.Runtime.Serialization.DataContract]
	public class GetEventListenersResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x17000836 RID: 2102
		// (get) Token: 0x06001524 RID: 5412 RVA: 0x000172CE File Offset: 0x000154CE
		// (set) Token: 0x06001525 RID: 5413 RVA: 0x000172D6 File Offset: 0x000154D6
		[global::System.Runtime.Serialization.DataMember]
		internal global::System.Collections.Generic.IList<global::CefSharp.DevTools.DOMDebugger.EventListener> listeners { get; set; }

		// Token: 0x17000837 RID: 2103
		// (get) Token: 0x06001526 RID: 5414 RVA: 0x000172DF File Offset: 0x000154DF
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.DOMDebugger.EventListener> Listeners
		{
			get
			{
				return this.listeners;
			}
		}
	}
}
