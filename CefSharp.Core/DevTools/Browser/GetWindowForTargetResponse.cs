using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Browser
{
	// Token: 0x0200033F RID: 831
	[global::System.Runtime.Serialization.DataContract]
	public class GetWindowForTargetResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170009E7 RID: 2535
		// (get) Token: 0x06001947 RID: 6471 RVA: 0x0001B081 File Offset: 0x00019281
		// (set) Token: 0x06001948 RID: 6472 RVA: 0x0001B089 File Offset: 0x00019289
		[global::System.Runtime.Serialization.DataMember]
		internal int windowId { get; set; }

		// Token: 0x170009E8 RID: 2536
		// (get) Token: 0x06001949 RID: 6473 RVA: 0x0001B092 File Offset: 0x00019292
		public int WindowId
		{
			get
			{
				return this.windowId;
			}
		}

		// Token: 0x170009E9 RID: 2537
		// (get) Token: 0x0600194A RID: 6474 RVA: 0x0001B09A File Offset: 0x0001929A
		// (set) Token: 0x0600194B RID: 6475 RVA: 0x0001B0A2 File Offset: 0x000192A2
		[global::System.Runtime.Serialization.DataMember]
		internal global::CefSharp.DevTools.Browser.Bounds bounds { get; set; }

		// Token: 0x170009EA RID: 2538
		// (get) Token: 0x0600194C RID: 6476 RVA: 0x0001B0AB File Offset: 0x000192AB
		public global::CefSharp.DevTools.Browser.Bounds Bounds
		{
			get
			{
				return this.bounds;
			}
		}
	}
}
