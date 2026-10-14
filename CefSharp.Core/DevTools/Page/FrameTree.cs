using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Page
{
	// Token: 0x02000175 RID: 373
	[global::System.Runtime.Serialization.DataContract]
	public class FrameTree : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x06000B81 RID: 2945 RVA: 0x0000DC5C File Offset: 0x0000BE5C
		// (set) Token: 0x06000B82 RID: 2946 RVA: 0x0000DC64 File Offset: 0x0000BE64
		[global::System.Runtime.Serialization.DataMember(Name = "frame", IsRequired = true)]
		public global::CefSharp.DevTools.Page.Frame Frame { get; set; }

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x06000B83 RID: 2947 RVA: 0x0000DC6D File Offset: 0x0000BE6D
		// (set) Token: 0x06000B84 RID: 2948 RVA: 0x0000DC75 File Offset: 0x0000BE75
		[global::System.Runtime.Serialization.DataMember(Name = "childFrames", IsRequired = false)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.Page.FrameTree> ChildFrames { get; set; }
	}
}
