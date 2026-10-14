using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Page
{
	// Token: 0x02000174 RID: 372
	[global::System.Runtime.Serialization.DataContract]
	public class FrameResourceTree : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x06000B7A RID: 2938 RVA: 0x0000DC21 File Offset: 0x0000BE21
		// (set) Token: 0x06000B7B RID: 2939 RVA: 0x0000DC29 File Offset: 0x0000BE29
		[global::System.Runtime.Serialization.DataMember(Name = "frame", IsRequired = true)]
		public global::CefSharp.DevTools.Page.Frame Frame { get; set; }

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x06000B7C RID: 2940 RVA: 0x0000DC32 File Offset: 0x0000BE32
		// (set) Token: 0x06000B7D RID: 2941 RVA: 0x0000DC3A File Offset: 0x0000BE3A
		[global::System.Runtime.Serialization.DataMember(Name = "childFrames", IsRequired = false)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.Page.FrameResourceTree> ChildFrames { get; set; }

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x06000B7E RID: 2942 RVA: 0x0000DC43 File Offset: 0x0000BE43
		// (set) Token: 0x06000B7F RID: 2943 RVA: 0x0000DC4B File Offset: 0x0000BE4B
		[global::System.Runtime.Serialization.DataMember(Name = "resources", IsRequired = true)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.Page.FrameResource> Resources { get; set; }
	}
}
