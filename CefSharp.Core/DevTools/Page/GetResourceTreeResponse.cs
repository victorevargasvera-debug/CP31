using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Page
{
	// Token: 0x020001B4 RID: 436
	[global::System.Runtime.Serialization.DataContract]
	public class GetResourceTreeResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x06000CFB RID: 3323 RVA: 0x0000EA23 File Offset: 0x0000CC23
		// (set) Token: 0x06000CFC RID: 3324 RVA: 0x0000EA2B File Offset: 0x0000CC2B
		[global::System.Runtime.Serialization.DataMember]
		internal global::CefSharp.DevTools.Page.FrameResourceTree frameTree { get; set; }

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x06000CFD RID: 3325 RVA: 0x0000EA34 File Offset: 0x0000CC34
		public global::CefSharp.DevTools.Page.FrameResourceTree FrameTree
		{
			get
			{
				return this.frameTree;
			}
		}
	}
}
