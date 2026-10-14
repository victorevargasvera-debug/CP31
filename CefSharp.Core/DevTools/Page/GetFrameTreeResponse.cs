using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Page
{
	// Token: 0x020001B0 RID: 432
	[global::System.Runtime.Serialization.DataContract]
	public class GetFrameTreeResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x06000CD6 RID: 3286 RVA: 0x0000E8F0 File Offset: 0x0000CAF0
		// (set) Token: 0x06000CD7 RID: 3287 RVA: 0x0000E8F8 File Offset: 0x0000CAF8
		[global::System.Runtime.Serialization.DataMember]
		internal global::CefSharp.DevTools.Page.FrameTree frameTree { get; set; }

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x06000CD8 RID: 3288 RVA: 0x0000E901 File Offset: 0x0000CB01
		public global::CefSharp.DevTools.Page.FrameTree FrameTree
		{
			get
			{
				return this.frameTree;
			}
		}
	}
}
