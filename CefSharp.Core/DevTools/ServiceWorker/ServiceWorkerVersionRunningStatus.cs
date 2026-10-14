using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.ServiceWorker
{
	// Token: 0x02000141 RID: 321
	public enum ServiceWorkerVersionRunningStatus
	{
		// Token: 0x04000479 RID: 1145
		[global::System.Runtime.Serialization.EnumMember(Value = "stopped")]
		Stopped,
		// Token: 0x0400047A RID: 1146
		[global::System.Runtime.Serialization.EnumMember(Value = "starting")]
		Starting,
		// Token: 0x0400047B RID: 1147
		[global::System.Runtime.Serialization.EnumMember(Value = "running")]
		Running,
		// Token: 0x0400047C RID: 1148
		[global::System.Runtime.Serialization.EnumMember(Value = "stopping")]
		Stopping
	}
}
