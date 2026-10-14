using System;
using System.Runtime.Serialization;
using CefSharp.DevTools.Runtime;

namespace CefSharp.DevTools.Page
{
	// Token: 0x02000191 RID: 401
	[global::System.Runtime.Serialization.DataContract]
	public class FrameAttachedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06000C19 RID: 3097 RVA: 0x0000E1E6 File Offset: 0x0000C3E6
		// (set) Token: 0x06000C1A RID: 3098 RVA: 0x0000E1EE File Offset: 0x0000C3EE
		[global::System.Runtime.Serialization.DataMember(Name = "frameId", IsRequired = true)]
		public string FrameId { get; private set; }

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x06000C1B RID: 3099 RVA: 0x0000E1F7 File Offset: 0x0000C3F7
		// (set) Token: 0x06000C1C RID: 3100 RVA: 0x0000E1FF File Offset: 0x0000C3FF
		[global::System.Runtime.Serialization.DataMember(Name = "parentFrameId", IsRequired = true)]
		public string ParentFrameId { get; private set; }

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x06000C1D RID: 3101 RVA: 0x0000E208 File Offset: 0x0000C408
		// (set) Token: 0x06000C1E RID: 3102 RVA: 0x0000E210 File Offset: 0x0000C410
		[global::System.Runtime.Serialization.DataMember(Name = "stack", IsRequired = false)]
		public global::CefSharp.DevTools.Runtime.StackTrace Stack { get; private set; }
	}
}
