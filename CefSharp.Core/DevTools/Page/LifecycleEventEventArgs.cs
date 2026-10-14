using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Page
{
	// Token: 0x020001A0 RID: 416
	[global::System.Runtime.Serialization.DataContract]
	public class LifecycleEventEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x06000C78 RID: 3192 RVA: 0x0000E5D9 File Offset: 0x0000C7D9
		// (set) Token: 0x06000C79 RID: 3193 RVA: 0x0000E5E1 File Offset: 0x0000C7E1
		[global::System.Runtime.Serialization.DataMember(Name = "frameId", IsRequired = true)]
		public string FrameId { get; private set; }

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x06000C7A RID: 3194 RVA: 0x0000E5EA File Offset: 0x0000C7EA
		// (set) Token: 0x06000C7B RID: 3195 RVA: 0x0000E5F2 File Offset: 0x0000C7F2
		[global::System.Runtime.Serialization.DataMember(Name = "loaderId", IsRequired = true)]
		public string LoaderId { get; private set; }

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x06000C7C RID: 3196 RVA: 0x0000E5FB File Offset: 0x0000C7FB
		// (set) Token: 0x06000C7D RID: 3197 RVA: 0x0000E603 File Offset: 0x0000C803
		[global::System.Runtime.Serialization.DataMember(Name = "name", IsRequired = true)]
		public string Name { get; private set; }

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x06000C7E RID: 3198 RVA: 0x0000E60C File Offset: 0x0000C80C
		// (set) Token: 0x06000C7F RID: 3199 RVA: 0x0000E614 File Offset: 0x0000C814
		[global::System.Runtime.Serialization.DataMember(Name = "timestamp", IsRequired = true)]
		public double Timestamp { get; private set; }
	}
}
